namespace CSharpControl2013
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStartControl = new System.Windows.Forms.Button();
            this.textBoxSetPoint = new System.Windows.Forms.TextBox();
            this.textBoxPlantOutput = new System.Windows.Forms.TextBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clearChartButton = new System.Windows.Forms.Button();
            this.textBoxControllerOutput_ut = new System.Windows.Forms.TextBox();
            this.stepSizeLabel = new System.Windows.Forms.Label();
            this.textBoxInputSignal = new System.Windows.Forms.TextBox();
            this.textBoxTimeElapsed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSetGain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDAQSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDAQName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLogSamples = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonStopLogging = new System.Windows.Forms.Button();
            this.buttonLogging = new System.Windows.Forms.Button();
            this.comboBoxInputSignal = new System.Windows.Forms.ComboBox();
            this.labelInputControl = new System.Windows.Forms.Label();
            this.comboBoxControlLoop = new System.Windows.Forms.ComboBox();
            this.labelControlLoop = new System.Windows.Forms.Label();
            this.textBoxMotorVelocity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.ControlSampleTimer);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(176, 25);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 35);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.StopControl);
            // 
            // buttonStartControl
            // 
            this.buttonStartControl.BackColor = System.Drawing.Color.Lime;
            this.buttonStartControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartControl.Location = new System.Drawing.Point(33, 25);
            this.buttonStartControl.Name = "buttonStartControl";
            this.buttonStartControl.Size = new System.Drawing.Size(100, 35);
            this.buttonStartControl.TabIndex = 1;
            this.buttonStartControl.Text = "CHART OFF";
            this.buttonStartControl.UseVisualStyleBackColor = false;
            this.buttonStartControl.Click += new System.EventHandler(this.StartControl);
            // 
            // textBoxSetPoint
            // 
            this.textBoxSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetPoint.Location = new System.Drawing.Point(33, 138);
            this.textBoxSetPoint.Name = "textBoxSetPoint";
            this.textBoxSetPoint.ReadOnly = true;
            this.textBoxSetPoint.Size = new System.Drawing.Size(100, 22);
            this.textBoxSetPoint.TabIndex = 2;
            // 
            // textBoxPlantOutput
            // 
            this.textBoxPlantOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlantOutput.Location = new System.Drawing.Point(167, 220);
            this.textBoxPlantOutput.Name = "textBoxPlantOutput";
            this.textBoxPlantOutput.ReadOnly = true;
            this.textBoxPlantOutput.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlantOutput.TabIndex = 3;
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(147, 90);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(39, 20);
            this.textBoxInterval.TabIndex = 5;
            this.textBoxInterval.Text = "100";
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "r(t) Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "y(t) Plant Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "u(t) Controller Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sample Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ms";
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "Time (s)";
            chartArea2.AxisY.Title = "Voltage (V)";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(301, 1);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1178, 570);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // clearChartButton
            // 
            this.clearChartButton.Location = new System.Drawing.Point(33, 74);
            this.clearChartButton.Name = "clearChartButton";
            this.clearChartButton.Size = new System.Drawing.Size(100, 36);
            this.clearChartButton.TabIndex = 13;
            this.clearChartButton.Text = "Clear Chart";
            this.clearChartButton.UseVisualStyleBackColor = true;
            this.clearChartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxControllerOutput_ut
            // 
            this.textBoxControllerOutput_ut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxControllerOutput_ut.Location = new System.Drawing.Point(167, 138);
            this.textBoxControllerOutput_ut.Name = "textBoxControllerOutput_ut";
            this.textBoxControllerOutput_ut.ReadOnly = true;
            this.textBoxControllerOutput_ut.Size = new System.Drawing.Size(100, 22);
            this.textBoxControllerOutput_ut.TabIndex = 14;
            // 
            // stepSizeLabel
            // 
            this.stepSizeLabel.AutoSize = true;
            this.stepSizeLabel.Location = new System.Drawing.Point(18, 24);
            this.stepSizeLabel.Name = "stepSizeLabel";
            this.stepSizeLabel.Size = new System.Drawing.Size(49, 13);
            this.stepSizeLabel.TabIndex = 18;
            this.stepSizeLabel.Text = "r(t)_Input";
            // 
            // textBoxInputSignal
            // 
            this.textBoxInputSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputSignal.Location = new System.Drawing.Point(73, 19);
            this.textBoxInputSignal.Name = "textBoxInputSignal";
            this.textBoxInputSignal.Size = new System.Drawing.Size(48, 22);
            this.textBoxInputSignal.TabIndex = 19;
            this.textBoxInputSignal.Text = "5";
            // 
            // textBoxTimeElapsed
            // 
            this.textBoxTimeElapsed.Location = new System.Drawing.Point(224, 90);
            this.textBoxTimeElapsed.Name = "textBoxTimeElapsed";
            this.textBoxTimeElapsed.ReadOnly = true;
            this.textBoxTimeElapsed.Size = new System.Drawing.Size(52, 20);
            this.textBoxTimeElapsed.TabIndex = 34;
            this.textBoxTimeElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Time Elapsed ";
            // 
            // textBoxSetGain
            // 
            this.textBoxSetGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetGain.Location = new System.Drawing.Point(33, 179);
            this.textBoxSetGain.Name = "textBoxSetGain";
            this.textBoxSetGain.Size = new System.Drawing.Size(100, 22);
            this.textBoxSetGain.TabIndex = 37;
            this.textBoxSetGain.Text = "5";
            this.textBoxSetGain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeSystemGain);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Gain";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.textBoxDAQSerial);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxDAQName);
            this.groupBox1.Location = new System.Drawing.Point(12, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DAQ ";
            // 
            // textBoxDAQSerial
            // 
            this.textBoxDAQSerial.Location = new System.Drawing.Point(85, 41);
            this.textBoxDAQSerial.Name = "textBoxDAQSerial";
            this.textBoxDAQSerial.ReadOnly = true;
            this.textBoxDAQSerial.Size = new System.Drawing.Size(100, 20);
            this.textBoxDAQSerial.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Serial Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Name of DAQ";
            // 
            // textBoxDAQName
            // 
            this.textBoxDAQName.Location = new System.Drawing.Point(85, 19);
            this.textBoxDAQName.Name = "textBoxDAQName";
            this.textBoxDAQName.ReadOnly = true;
            this.textBoxDAQName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDAQName.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.textBoxLogSamples);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonStopLogging);
            this.groupBox2.Controls.Add(this.buttonLogging);
            this.groupBox2.Controls.Add(this.comboBoxInputSignal);
            this.groupBox2.Controls.Add(this.labelInputControl);
            this.groupBox2.Controls.Add(this.comboBoxControlLoop);
            this.groupBox2.Controls.Add(this.labelControlLoop);
            this.groupBox2.Location = new System.Drawing.Point(12, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 150);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signal and Data Control ";
            // 
            // textBoxLogSamples
            // 
            this.textBoxLogSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogSamples.Location = new System.Drawing.Point(85, 122);
            this.textBoxLogSamples.Name = "textBoxLogSamples";
            this.textBoxLogSamples.ReadOnly = true;
            this.textBoxLogSamples.Size = new System.Drawing.Size(66, 20);
            this.textBoxLogSamples.TabIndex = 14;
            this.textBoxLogSamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Log Samples";
            // 
            // buttonStopLogging
            // 
            this.buttonStopLogging.Location = new System.Drawing.Point(164, 96);
            this.buttonStopLogging.Name = "buttonStopLogging";
            this.buttonStopLogging.Size = new System.Drawing.Size(75, 23);
            this.buttonStopLogging.TabIndex = 12;
            this.buttonStopLogging.Text = "STOP";
            this.buttonStopLogging.UseVisualStyleBackColor = true;
            this.buttonStopLogging.Click += new System.EventHandler(this.StopLogging);
            // 
            // buttonLogging
            // 
            this.buttonLogging.Location = new System.Drawing.Point(9, 96);
            this.buttonLogging.Name = "buttonLogging";
            this.buttonLogging.Size = new System.Drawing.Size(133, 23);
            this.buttonLogging.TabIndex = 11;
            this.buttonLogging.Text = "START LOGGING";
            this.buttonLogging.UseVisualStyleBackColor = true;
            this.buttonLogging.Click += new System.EventHandler(this.Startlogging);
            // 
            // comboBoxInputSignal
            // 
            this.comboBoxInputSignal.FormattingEnabled = true;
            this.comboBoxInputSignal.Items.AddRange(new object[] {
            "INTERNAL(r(t)_Input)",
            "EXTERNAL(DAQ-1)"});
            this.comboBoxInputSignal.Location = new System.Drawing.Point(105, 58);
            this.comboBoxInputSignal.Name = "comboBoxInputSignal";
            this.comboBoxInputSignal.Size = new System.Drawing.Size(133, 21);
            this.comboBoxInputSignal.TabIndex = 10;
            this.comboBoxInputSignal.Text = "INTERNAL(r(t)_Input)";
            // 
            // labelInputControl
            // 
            this.labelInputControl.AutoSize = true;
            this.labelInputControl.Location = new System.Drawing.Point(48, 61);
            this.labelInputControl.Name = "labelInputControl";
            this.labelInputControl.Size = new System.Drawing.Size(31, 13);
            this.labelInputControl.TabIndex = 9;
            this.labelInputControl.Text = "Input";
            // 
            // comboBoxControlLoop
            // 
            this.comboBoxControlLoop.FormattingEnabled = true;
            this.comboBoxControlLoop.Items.AddRange(new object[] {
            "OPEN",
            "CLOSED"});
            this.comboBoxControlLoop.Location = new System.Drawing.Point(105, 25);
            this.comboBoxControlLoop.Name = "comboBoxControlLoop";
            this.comboBoxControlLoop.Size = new System.Drawing.Size(80, 21);
            this.comboBoxControlLoop.TabIndex = 8;
            this.comboBoxControlLoop.Text = "OPEN";
            // 
            // labelControlLoop
            // 
            this.labelControlLoop.AutoSize = true;
            this.labelControlLoop.Location = new System.Drawing.Point(18, 28);
            this.labelControlLoop.Name = "labelControlLoop";
            this.labelControlLoop.Size = new System.Drawing.Size(67, 13);
            this.labelControlLoop.TabIndex = 7;
            this.labelControlLoop.Text = "Control Loop";
            // 
            // textBoxMotorVelocity
            // 
            this.textBoxMotorVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMotorVelocity.Location = new System.Drawing.Point(167, 179);
            this.textBoxMotorVelocity.Name = "textBoxMotorVelocity";
            this.textBoxMotorVelocity.ReadOnly = true;
            this.textBoxMotorVelocity.Size = new System.Drawing.Size(100, 22);
            this.textBoxMotorVelocity.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Motor Velocity";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxRamp);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxInputSignal);
            this.groupBox3.Controls.Add(this.stepSizeLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 82);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal Inputs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Apply Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ApplyInput);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(200, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "t";
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRamp.Location = new System.Drawing.Point(146, 19);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(48, 22);
            this.textBoxRamp.TabIndex = 22;
            this.textBoxRamp.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(122, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1484, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxMotorVelocity);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSetGain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTimeElapsed);
            this.Controls.Add(this.textBoxControllerOutput_ut);
            this.Controls.Add(this.clearChartButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.textBoxPlantOutput);
            this.Controls.Add(this.textBoxSetPoint);
            this.Controls.Add(this.buttonStartControl);
            this.Controls.Add(this.buttonStop);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Servo Motor Controller Release 2";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStartControl;
        private System.Windows.Forms.TextBox textBoxSetPoint;
        private System.Windows.Forms.TextBox textBoxPlantOutput;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button clearChartButton;
        private System.Windows.Forms.TextBox textBoxControllerOutput_ut;
        private System.Windows.Forms.Label stepSizeLabel;
        private System.Windows.Forms.TextBox textBoxInputSignal;
        private System.Windows.Forms.TextBox textBoxTimeElapsed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSetGain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDAQSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDAQName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxControlLoop;
        private System.Windows.Forms.Label labelControlLoop;
        private System.Windows.Forms.ComboBox comboBoxInputSignal;
        private System.Windows.Forms.Label labelInputControl;
        private System.Windows.Forms.Button buttonLogging;
        private System.Windows.Forms.TextBox textBoxMotorVelocity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonStopLogging;
        private System.Windows.Forms.TextBox textBoxLogSamples;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button1;
	}
}

