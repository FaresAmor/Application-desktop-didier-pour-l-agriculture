namespace MyAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            temp = new Label();
            panel3 = new Panel();
            label1 = new Label();
            hum = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            gazp = new Panel();
            etatgaz = new Label();
            label3 = new Label();
            on = new Button();
            off = new Button();
            splitter1 = new Splitter();
            label4 = new Label();
            panel4 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            hey = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            gazp.SuspendLayout();
            panel4.SuspendLayout();
            hey.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label5);
            panel1.Location = new Point(30, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 75);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 20);
            label5.Name = "label5";
            label5.Size = new Size(251, 35);
            label5.TabIndex = 4;
            label5.Text = "Capteur intelligent";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(label2);
            panel2.Controls.Add(temp);
            panel2.Location = new Point(30, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 222);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 13);
            label2.Name = "label2";
            label2.Size = new Size(201, 27);
            label2.TabIndex = 6;
            label2.Text = "Temperature";
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.BackColor = Color.LightGray;
            temp.BorderStyle = BorderStyle.Fixed3D;
            temp.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temp.Location = new Point(65, 161);
            temp.Name = "temp";
            temp.Size = new Size(2, 39);
            temp.TabIndex = 0;
            temp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(label1);
            panel3.Controls.Add(hum);
            panel3.Location = new Point(248, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 222);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 13);
            label1.Name = "label1";
            label1.Size = new Size(140, 27);
            label1.TabIndex = 5;
            label1.Text = "humidité";
            // 
            // hum
            // 
            hum.AutoSize = true;
            hum.BackColor = Color.LightGray;
            hum.BorderStyle = BorderStyle.Fixed3D;
            hum.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hum.Location = new Point(64, 161);
            hum.Name = "hum";
            hum.Size = new Size(2, 39);
            hum.TabIndex = 4;
            hum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(468, 120);
            chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "temperature";
            chart1.Series.Add(series1);
            chart1.Size = new Size(442, 322);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // gazp
            // 
            gazp.Controls.Add(etatgaz);
            gazp.Controls.Add(label3);
            gazp.Location = new Point(29, 357);
            gazp.Name = "gazp";
            gazp.Size = new Size(419, 85);
            gazp.TabIndex = 4;
            // 
            // etatgaz
            // 
            etatgaz.AutoSize = true;
            etatgaz.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etatgaz.Location = new Point(216, 23);
            etatgaz.Name = "etatgaz";
            etatgaz.Size = new Size(0, 35);
            etatgaz.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 23);
            label3.Name = "label3";
            label3.Size = new Size(169, 35);
            label3.TabIndex = 7;
            label3.Text = "Capteur du gaz";
            // 
            // on
            // 
            on.BackColor = Color.Green;
            on.BackgroundImageLayout = ImageLayout.None;
            on.Cursor = Cursors.Hand;
            on.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            on.Location = new Point(30, 463);
            on.Name = "on";
            on.Size = new Size(95, 101);
            on.TabIndex = 5;
            on.Text = "ON";
            on.UseVisualStyleBackColor = false;
            on.Click += on_Click;
            // 
            // off
            // 
            off.BackColor = Color.Red;
            off.Cursor = Cursors.Hand;
            off.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            off.ForeColor = SystemColors.ControlText;
            off.Location = new Point(141, 463);
            off.Name = "off";
            off.Size = new Size(89, 101);
            off.TabIndex = 6;
            off.Text = "OFF";
            off.UseVisualStyleBackColor = false;
            off.Click += off_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 645);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 64);
            label4.Location = new Point(202, -1);
            label4.Name = "label4";
            label4.Size = new Size(126, 35);
            label4.TabIndex = 8;
            label4.Text = "Set color";
            // 
            // panel4
            // 
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(248, 463);
            panel4.Name = "panel4";
            panel4.Size = new Size(522, 125);
            panel4.TabIndex = 9;
            // 
            // button10
            // 
            button10.Location = new Point(429, 37);
            button10.Name = "button10";
            button10.Size = new Size(57, 29);
            button10.TabIndex = 18;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(429, 72);
            button9.Name = "button9";
            button9.Size = new Size(57, 29);
            button9.TabIndex = 17;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Yellow;
            button8.Location = new Point(329, 37);
            button8.Name = "button8";
            button8.Size = new Size(57, 29);
            button8.TabIndex = 16;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.Location = new Point(329, 72);
            button7.Name = "button7";
            button7.Size = new Size(57, 29);
            button7.TabIndex = 15;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Maroon;
            button6.Location = new Point(29, 72);
            button6.Name = "button6";
            button6.Size = new Size(57, 29);
            button6.TabIndex = 14;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 192);
            button5.Location = new Point(229, 72);
            button5.Name = "button5";
            button5.Size = new Size(57, 29);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Location = new Point(129, 37);
            button4.Name = "button4";
            button4.Size = new Size(57, 29);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 255);
            button3.Location = new Point(129, 72);
            button3.Name = "button3";
            button3.Size = new Size(57, 29);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(229, 37);
            button2.Name = "button2";
            button2.Size = new Size(57, 29);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(29, 37);
            button1.Name = "button1";
            button1.Size = new Size(57, 29);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // hey
            // 
            hey.Controls.Add(label6);
            hey.Location = new Point(796, 462);
            hey.Name = "hey";
            hey.Size = new Size(126, 126);
            hey.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(124, 43);
            label6.Name = "label6";
            label6.Size = new Size(0, 35);
            label6.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 645);
            Controls.Add(hey);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(off);
            Controls.Add(on);
            Controls.Add(gazp);
            Controls.Add(chart1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            gazp.ResumeLayout(false);
            gazp.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            hey.ResumeLayout(false);
            hey.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel gazp;
        private Label label2;
        private Label label1;
        private Label hum;
        private Label label3;
        private Label etatgaz;
        private Button on;
        private Button off;
        private Splitter splitter1;
        private Label label4;
        private Panel panel4;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel hey;
        private Label label6;
    }
}
