﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenLayers.Base;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.Data.Matlab;

namespace CSharpControl2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupChart();           
        }

        #region DAQLite Drivers WARNING! Do not Change

        //EagleDaq.EagleDaq DAQ = new EagleDaq.EagleDaq();
        string fileName = "C:\\ServoMotorLogs\\ServoMotorData.CSV";
        bool Logging = false;
        long LogSamples=0;
        int chartPeriod = 84;
        double XValue;
        int inputType = 1;                  // controls input type
        int count = 0;                      // Timer variable   

		#endregion

		#region DT9812
		Device device;
		DeviceMgr deviceManager;
		AnalogInputSubsystem input;
		AnalogOutputSubsystem output;

        private void FormLoad(object sender, EventArgs e)   // Connect to ADC/DAC
        {
            deviceManager = DeviceMgr.Get();

            if (device != null)
            { device.Dispose(); }
            try
            {
                string[] deviceNames;
                deviceNames = deviceManager.GetDeviceNames();
                device = deviceManager.GetDevice(deviceNames[0].ToString());
                output = device.AnalogOutputSubsystem(0);
                input = device.AnalogInputSubsystem(0);
                textBoxDAQName.Text = deviceNames[0].ToString();
                textBoxDAQSerial.Text = "Data Translation";
            }
            catch
            {
                MessageBox.Show("DT9812 not connected", "Cannot read DT9812",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDAQName.Text = "DAQ Fault";
                textBoxDAQSerial.Text = "Data Translation";
            }

            output.DataFlow = DataFlow.SingleValue;
            input.DataFlow = DataFlow.SingleValue;
            input.Config();
            output.Config();
        }
        #endregion

        //GLOBAL CONTROL VARIBLES

        double yt_PlantOutput;              // Output of plant for position @ ADC INPUT 0 (Temperature output from sensor)
        double rt_SetPoint = 0;             // Setpoint @ ADC INPUT 1 //Main global variable to have variable with regards to time
		double rt_Gain = 0;
        double ut_PlantInput;               // Output of Controller to heater input   @ ADC INPUT 2	
        double errorPrev;
        double ut_Out_prev;

        double Gain=1;                      // Gain Default to one

        // CONTROL SAMPLE RUNNING ON A TIMER
        private void ControlSampleTimer(object sender, EventArgs e)
        {
            string WriteData = "";
            double Increment = Convert.ToDouble(timer1.Interval) / 1000;
            XValue = XValue+Increment;
            //double XValue = count * timer1.Interval;

            // Timer recording
            double TimeElapsed = XValue;
            textBoxTimeElapsed.Clear();
            textBoxTimeElapsed.AppendText(TimeElapsed.ToString("0.00"));
            WriteData = TimeElapsed.ToString("0.00"); // Record into text string for data logging

            yt_PlantOutput = input.GetSingleValueAsVolts(0, 1);            // Read and Display yt @ ADC INPUT 0             
            textBoxPlantOutput.Text = yt_PlantOutput.ToString("0.000");     // Display yt
            WriteData += "," + yt_PlantOutput.ToString("0.000");            // Record into text string for data logging
            chart1.Series["yt_Output"].Points.AddXY(XValue, yt_PlantOutput);
            
            string InputSignal = comboBoxInputSignal.Text;
            if (InputSignal == "EXTERNAL(DAQ-1)")
            {
                rt_SetPoint = input.GetSingleValueAsVolts(1, 1);            // Read and Setpoint @ ADC INPUT 1 
            }
            else
            {
                try
                {
                    rt_SetPoint = Convert.ToDouble(rt_Gain) + TimeElapsed * Convert.ToDouble(textBoxRamp.Text);
                }
                catch
                { }
            }  
                
            textBoxSetPoint.Text = rt_SetPoint.ToString("0.000");                // Display Setpoint
            WriteData += "," + rt_SetPoint.ToString("0.000");    
            chart1.Series["rt_SetPoint"].Points.AddXY(XValue, rt_SetPoint);

            double Velocity = input.GetSingleValueAsVolts(2, 1);           // Read and Setpoint @ ADC INPUT 2
			textBoxMotorVelocity.Text = Velocity.ToString("0.000");
            WriteData += "," + Velocity.ToString("0.000");
            chart1.Series["Motor Speed"].Points.AddXY(XValue, Velocity);

            // Controller           
            double Error = Gain*rt_SetPoint - yt_PlantOutput - 0.5*Velocity;
                   
            double ut_Output = Error + 0.7 * errorPrev - 0.1*ut_Out_prev;


            if (ut_Output > 9)
            {
                ut_Output = 9;
            }
            else if (ut_Output < -9)
            {
                ut_Output = -9;
            }

            // Send output to DAQ           
            string ControlLoop = comboBoxControlLoop.Text;
            if (ControlLoop == "OPEN")
            { ut_Output = rt_SetPoint; }

			output.SetSingleValueAsVolts(0, ut_Output);
			//DAQ.Output(0, ut_Output);

            ut_PlantInput = ut_Output;        // Read and Display Controller Output            
            textBoxControllerOutput_ut.Text = ut_PlantInput.ToString("0.000");
            WriteData += "," + ut_PlantInput.ToString("0.000");
            chart1.Series["ut_Input"].Points.AddXY(XValue, ut_PlantInput);
            errorPrev = Error;
            ut_Out_prev = ut_Output;

            #region // FOR LOGGING DATA
            if (Logging == true)
            {
                // Write data into file 
                StreamWriter Datafile = new StreamWriter(fileName, true);
                Datafile.WriteLine(WriteData);
                Datafile.Close();
                // Show the sample count
                LogSamples++;
                textBoxLogSamples.Clear();
                textBoxLogSamples.Text = LogSamples.ToString();
            }


            if (XValue > 420)
            {
                timer1.Enabled = false;
            }

            #endregion
        }

        #region START STOP CONTROL
        private void StartControl(object sender, EventArgs e)
        {            
            int interval;       // Enable and set timer            
            interval = Convert.ToInt16(textBoxInterval.Text);
            timer1.Interval = interval;
            buttonStartControl.Text = "CHART ON";
            textBoxInterval.Enabled = false;        // Disable appropriate text boxes
            //textBoxChartPeriod.Enabled = false;
            if (inputType == 0)
            {
                textBoxInputSignal.Enabled = false; 
                //textBoxStepLength.Enabled = false;
            }

            try
            {                
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("DT9812 not connected", "Cannot read DT9812",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = false;
            }

            SetupChart();      // Charts reset

           //chartPeriod = Convert.ToInt32(textBoxChartPeriod.Text) * 1000;      // Sets chart period

            count = 0;      // Reset counter

            // Initially Read Input from the TextBox
            try
            {
                rt_SetPoint = Convert.ToDouble(textBoxInputSignal.Text);
            }
            catch { }
            textBoxSetPoint.Text = rt_SetPoint.ToString("0.0");          // Display rt 
        }
        private void StopControl(object sender, EventArgs e)
        {            
            timer1.Enabled = false;     // Disable timer
            buttonStartControl.Text = "CHART OFF";
            textBoxInterval.Enabled = true;
            textBoxInputSignal.Enabled = true;
            //textBoxStepLength.Enabled = true;
            //textBoxChartPeriod.Enabled = true;

            //output.SetSingleValueAsVolts(0, 0);     // Write ut to DAC Output 0	            
            textBoxPlantOutput.Text = "0";          // Set output text to 0;
            yt_PlantOutput = 0;            
            count = 0;      // Reset counter
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            //output.SetSingleValueAsVolts(0, 0);     // Write ut to DAC Output 0	            
            textBoxPlantOutput.Text = "0";      // Set output text to 0;
            
            this.Close();
        }
        #endregion

        #region DATA LOGGING 

        private void Startlogging(object sender, EventArgs e)
        {
            int interval = timer1.Interval;
            string sInterval = interval.ToString();
            FileStream Datafile1;
            
            buttonLogging.Text = "LOGGING ON";
            Logging = true;

            textBoxLogSamples.BackColor = System.Drawing.ColorTranslator.FromWin32(-16776961);
            textBoxLogSamples.ForeColor = System.Drawing.ColorTranslator.FromWin32(-1 );

            // Recreate Create file              
            Datafile1 = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            Datafile1.Close();

            StreamWriter Datafile = new StreamWriter(fileName, true);
            Datafile.WriteLine("DATA LOGGER INTERVAL @ " + sInterval + "ms");
            Datafile.WriteLine("TIME(s),y(t)_Output,r(t)_SetPoint,Motor Velocity,u(t)_Input");
            Datafile.Close();           
        }

        private void StopLogging(object sender, EventArgs e)
        {
            buttonLogging.Text = "START LOGGING";
            Logging = false;
            LogSamples = 0;
            textBoxLogSamples.BackColor = System.Drawing.ColorTranslator.FromWin32(-1);
            textBoxLogSamples.ForeColor = System.Drawing.ColorTranslator.FromWin32(-16777216);
        }

        #endregion

        #region CHART SETUP
        private void button1_Click(object sender, EventArgs e)
        {
            SetupChart();
        }      
        public void SetupChart()
        {
            if (Convert.ToInt32(textBoxInterval.Text) < 20) textBoxInterval.Text = "20";        // Limit minimum time interval
            timer1.Interval = Convert.ToInt32(textBoxInterval.Text); // Setting timer interval

            XValue = 0;

            chart1.Series.Clear();                                   // Initialising chart components

            chart1.Series.Add("yt_Output");                          // Add series for yt and rt
            chart1.Series.Add("rt_SetPoint");
            chart1.Series.Add("ut_Input");
            chart1.Series.Add("Motor Speed");

            chart1.Series["yt_Output"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine; // Set type of graph to line
            chart1.Series["rt_SetPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["ut_Input"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Motor Speed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            // Assign colours to series
            chart1.Series["yt_Output"].Color = Color.Blue;
            chart1.Series["rt_SetPoint"].Color = Color.Red;
            chart1.Series["ut_Input"].Color = Color.Black;
            chart1.Series["Motor Speed"].Color = Color.Brown;

            chart1.ChartAreas[0].AxisY.Maximum = 10;                // Set Axis limits
            chart1.ChartAreas[0].AxisY.Minimum = -10;           
            chart1.ChartAreas[0].AxisY.MajorTickMark.Interval = 1;  // Settings for grids  setting on 1
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0.2;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 1;

            // X-Axis Settings
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 5;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 5;

            chart1.ChartAreas[0].AxisX.Maximum = chartPeriod;
            chart1.ChartAreas[0].AxisX.Minimum = 0;


            //chart1.Series.Clear();      // Reset chart
            //chart1.Series.Add("yt");
            //chart1.Series.Add("rt");
            //chart1.Series["yt"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            //chart1.Series["rt"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            //chart1.Series["yt"].Color = Color.Blue;
            //chart1.Series["rt"].Color = Color.Red;
            //chart1.ChartAreas[0].AxisX.Maximum = chartPeriod;
            //chart1.ChartAreas[0].AxisX.Minimum = 0;


            count = 0;      // Reset counter
        }
        #endregion

        #region CHANGE INPUT EVENTS
        //private void ChangeStep(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        try
        //        {
        //            rt_SetPoint = Convert.ToDouble(textBoxInputSignal.Text);                   
        //        }
        //        catch { }                                   
        //        textBoxSetPoint.Text = rt_SetPoint.ToString("0.0");          // Display rt  
        //    }
        //}

        // Change Gain
        private void ChangeSystemGain(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gain = Convert.ToDouble(textBoxSetGain.Text);                              
            }
        }
		// Implement the input
		private void ApplyInput(object sender, EventArgs e)
		{
			try
			{
				rt_Gain = Convert.ToDouble(textBoxInputSignal.Text);
			}
			catch { }
			textBoxSetPoint.Text = rt_Gain.ToString("0.0");          // Display rt  
		}
        #endregion
    }
}
