
using System;

namespace TwoTanks
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmModeling = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnDownIn1 = new System.Windows.Forms.Button();
            this.btnUpIn1 = new System.Windows.Forms.Button();
            this.tbValveIn1 = new System.Windows.Forms.TextBox();
            this.tbValveIn2 = new System.Windows.Forms.TextBox();
            this.btnUpIn2 = new System.Windows.Forms.Button();
            this.btnDownIn2 = new System.Windows.Forms.Button();
            this.tbValve12 = new System.Windows.Forms.TextBox();
            this.btnUp12 = new System.Windows.Forms.Button();
            this.btnDown12 = new System.Windows.Forms.Button();
            this.tbValveOut1 = new System.Windows.Forms.TextBox();
            this.btnUpOut1 = new System.Windows.Forms.Button();
            this.btnDownOut1 = new System.Windows.Forms.Button();
            this.lbIn1 = new System.Windows.Forms.Label();
            this.lbIn2 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.lbOut1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TwoTanks.Properties.Resources._2tanks;
            this.pictureBox1.Location = new System.Drawing.Point(205, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chPlot
            // 
            this.chPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chPlot.Legends.Add(legend1);
            this.chPlot.Location = new System.Drawing.Point(62, 222);
            this.chPlot.Name = "chPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Z1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Z2";
            this.chPlot.Series.Add(series1);
            this.chPlot.Series.Add(series2);
            this.chPlot.Size = new System.Drawing.Size(812, 299);
            this.chPlot.TabIndex = 1;
            this.chPlot.Text = "chPlot";
            this.chPlot.Click += new System.EventHandler(this.chPlot_Click);
            // 
            // tmModeling
            // 
            this.tmModeling.Interval = 1000;
            this.tmModeling.Tick += new System.EventHandler(this.tmModeling_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 26);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(71, 26);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnX10
            // 
            this.btnX10.Location = new System.Drawing.Point(103, 12);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(65, 26);
            this.btnX10.TabIndex = 4;
            this.btnX10.Text = "x10";
            this.btnX10.UseVisualStyleBackColor = true;
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            // 
            // btnX1
            // 
            this.btnX1.Location = new System.Drawing.Point(103, 44);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(65, 26);
            this.btnX1.TabIndex = 5;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnDownIn1
            // 
            this.btnDownIn1.Location = new System.Drawing.Point(812, 12);
            this.btnDownIn1.Name = "btnDownIn1";
            this.btnDownIn1.Size = new System.Drawing.Size(34, 31);
            this.btnDownIn1.TabIndex = 6;
            this.btnDownIn1.Text = "<";
            this.btnDownIn1.UseVisualStyleBackColor = true;
            this.btnDownIn1.Click += new System.EventHandler(this.btnDownIn1_Click);
            // 
            // btnUpIn1
            // 
            this.btnUpIn1.Location = new System.Drawing.Point(934, 12);
            this.btnUpIn1.Name = "btnUpIn1";
            this.btnUpIn1.Size = new System.Drawing.Size(34, 31);
            this.btnUpIn1.TabIndex = 7;
            this.btnUpIn1.Text = ">";
            this.btnUpIn1.UseVisualStyleBackColor = true;
            this.btnUpIn1.Click += new System.EventHandler(this.btnUpIn1_Click);
            // 
            // tbValveIn1
            // 
            this.tbValveIn1.Location = new System.Drawing.Point(862, 16);
            this.tbValveIn1.Name = "tbValveIn1";
            this.tbValveIn1.Size = new System.Drawing.Size(50, 22);
            this.tbValveIn1.TabIndex = 10;
            this.tbValveIn1.Text = "0";
            this.tbValveIn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValveIn1.TextChanged += new System.EventHandler(this.tbValveIn1_TextChanged);
            // 
            // tbValveIn2
            // 
            this.tbValveIn2.Location = new System.Drawing.Point(862, 63);
            this.tbValveIn2.Name = "tbValveIn2";
            this.tbValveIn2.Size = new System.Drawing.Size(50, 22);
            this.tbValveIn2.TabIndex = 13;
            this.tbValveIn2.Text = "0";
            this.tbValveIn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValveIn2.TextChanged += new System.EventHandler(this.tbValveIn2_TextChanged);
            // 
            // btnUpIn2
            // 
            this.btnUpIn2.Location = new System.Drawing.Point(934, 59);
            this.btnUpIn2.Name = "btnUpIn2";
            this.btnUpIn2.Size = new System.Drawing.Size(34, 31);
            this.btnUpIn2.TabIndex = 12;
            this.btnUpIn2.Text = ">";
            this.btnUpIn2.UseVisualStyleBackColor = true;
            this.btnUpIn2.Click += new System.EventHandler(this.btnUpIn2_Click);
            // 
            // btnDownIn2
            // 
            this.btnDownIn2.Location = new System.Drawing.Point(812, 59);
            this.btnDownIn2.Name = "btnDownIn2";
            this.btnDownIn2.Size = new System.Drawing.Size(34, 31);
            this.btnDownIn2.TabIndex = 11;
            this.btnDownIn2.Text = "<";
            this.btnDownIn2.UseVisualStyleBackColor = true;
            this.btnDownIn2.Click += new System.EventHandler(this.btnDownIn2_Click);
            // 
            // tbValve12
            // 
            this.tbValve12.Location = new System.Drawing.Point(862, 109);
            this.tbValve12.Name = "tbValve12";
            this.tbValve12.Size = new System.Drawing.Size(50, 22);
            this.tbValve12.TabIndex = 16;
            this.tbValve12.Text = "0";
            this.tbValve12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValve12.TextChanged += new System.EventHandler(this.tbValve12_TextChanged);
            // 
            // btnUp12
            // 
            this.btnUp12.Location = new System.Drawing.Point(934, 105);
            this.btnUp12.Name = "btnUp12";
            this.btnUp12.Size = new System.Drawing.Size(34, 31);
            this.btnUp12.TabIndex = 15;
            this.btnUp12.Text = ">";
            this.btnUp12.UseVisualStyleBackColor = true;
            this.btnUp12.Click += new System.EventHandler(this.btnUp12_Click);
            // 
            // btnDown12
            // 
            this.btnDown12.Location = new System.Drawing.Point(812, 105);
            this.btnDown12.Name = "btnDown12";
            this.btnDown12.Size = new System.Drawing.Size(34, 31);
            this.btnDown12.TabIndex = 14;
            this.btnDown12.Text = "<";
            this.btnDown12.UseVisualStyleBackColor = true;
            this.btnDown12.Click += new System.EventHandler(this.btnDown12_Click);
            // 
            // tbValveOut1
            // 
            this.tbValveOut1.Location = new System.Drawing.Point(862, 155);
            this.tbValveOut1.Name = "tbValveOut1";
            this.tbValveOut1.Size = new System.Drawing.Size(50, 22);
            this.tbValveOut1.TabIndex = 19;
            this.tbValveOut1.Text = "0";
            this.tbValveOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValveOut1.TextChanged += new System.EventHandler(this.tbValveOut1_TextChanged);
            // 
            // btnUpOut1
            // 
            this.btnUpOut1.Location = new System.Drawing.Point(934, 151);
            this.btnUpOut1.Name = "btnUpOut1";
            this.btnUpOut1.Size = new System.Drawing.Size(34, 31);
            this.btnUpOut1.TabIndex = 18;
            this.btnUpOut1.Text = ">";
            this.btnUpOut1.UseVisualStyleBackColor = true;
            this.btnUpOut1.Click += new System.EventHandler(this.btnUpOut1_Click);
            // 
            // btnDownOut1
            // 
            this.btnDownOut1.Location = new System.Drawing.Point(812, 151);
            this.btnDownOut1.Name = "btnDownOut1";
            this.btnDownOut1.Size = new System.Drawing.Size(34, 31);
            this.btnDownOut1.TabIndex = 17;
            this.btnDownOut1.Text = "<";
            this.btnDownOut1.UseVisualStyleBackColor = true;
            this.btnDownOut1.Click += new System.EventHandler(this.btnDownOut1_Click);
            // 
            // lbIn1
            // 
            this.lbIn1.AutoSize = true;
            this.lbIn1.Location = new System.Drawing.Point(748, 19);
            this.lbIn1.Name = "lbIn1";
            this.lbIn1.Size = new System.Drawing.Size(27, 17);
            this.lbIn1.TabIndex = 20;
            this.lbIn1.Text = "In1";
            // 
            // lbIn2
            // 
            this.lbIn2.AutoSize = true;
            this.lbIn2.Location = new System.Drawing.Point(748, 66);
            this.lbIn2.Name = "lbIn2";
            this.lbIn2.Size = new System.Drawing.Size(27, 17);
            this.lbIn2.TabIndex = 21;
            this.lbIn2.Text = "In2";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Location = new System.Drawing.Point(748, 112);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(29, 17);
            this.lb12.TabIndex = 22;
            this.lb12.Text = "1-2";
            // 
            // lbOut1
            // 
            this.lbOut1.AutoSize = true;
            this.lbOut1.Location = new System.Drawing.Point(748, 158);
            this.lbOut1.Name = "lbOut1";
            this.lbOut1.Size = new System.Drawing.Size(39, 17);
            this.lbOut1.TabIndex = 23;
            this.lbOut1.Text = "Out1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 551);
            this.Controls.Add(this.lbOut1);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.lbIn2);
            this.Controls.Add(this.lbIn1);
            this.Controls.Add(this.tbValveOut1);
            this.Controls.Add(this.btnUpOut1);
            this.Controls.Add(this.btnDownOut1);
            this.Controls.Add(this.tbValve12);
            this.Controls.Add(this.btnUp12);
            this.Controls.Add(this.btnDown12);
            this.Controls.Add(this.tbValveIn2);
            this.Controls.Add(this.btnUpIn2);
            this.Controls.Add(this.btnDownIn2);
            this.Controls.Add(this.tbValveIn1);
            this.Controls.Add(this.btnUpIn1);
            this.Controls.Add(this.btnDownIn1);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chPlot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Two tanks";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chPlot_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPlot;
        private System.Windows.Forms.Timer tmModeling;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnX10;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnDownIn1;
        private System.Windows.Forms.Button btnUpIn1;
        private System.Windows.Forms.TextBox tbValveIn1;
        private System.Windows.Forms.TextBox tbValveIn2;
        private System.Windows.Forms.Button btnUpIn2;
        private System.Windows.Forms.Button btnDownIn2;
        private System.Windows.Forms.TextBox tbValve12;
        private System.Windows.Forms.Button btnUp12;
        private System.Windows.Forms.Button btnDown12;
        private System.Windows.Forms.TextBox tbValveOut1;
        private System.Windows.Forms.Button btnUpOut1;
        private System.Windows.Forms.Button btnDownOut1;
        private System.Windows.Forms.Label lbIn1;
        private System.Windows.Forms.Label lbIn2;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lbOut1;
    }
}

