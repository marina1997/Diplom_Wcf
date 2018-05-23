namespace FormsWKR1
{
    partial class algorithm_grover
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textbox4 = new System.Windows.Forms.TextBox();
            this.textbox5 = new System.Windows.Forms.TextBox();
            this.textbox6 = new System.Windows.Forms.TextBox();
            this.textbox7 = new System.Windows.Forms.TextBox();
            this.textbox8 = new System.Windows.Forms.TextBox();
            this.textbox9 = new System.Windows.Forms.TextBox();
            this.textbox10 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.label1.Location = new System.Drawing.Point(200, 93);
            this.label1.MaximumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество выполнений алгоритма";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.label2.Location = new System.Drawing.Point(196, 239);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество выполнений итерации Гровера";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.SteelBlue;
            this.run.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.run.Location = new System.Drawing.Point(241, 409);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(92, 27);
            this.run.TabIndex = 12;
            this.run.Text = "Старт";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Empty;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(404, 68);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.Azure;
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(354, 313);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(76, 146);
            this.textbox1.MaxLength = 1;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(28, 20);
            this.textbox1.TabIndex = 14;
            this.textbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox1_KeyPress);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(76, 172);
            this.textbox2.MaxLength = 1;
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(28, 20);
            this.textbox2.TabIndex = 15;
            this.textbox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox2_KeyPress);
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(76, 198);
            this.textbox3.MaxLength = 1;
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(28, 20);
            this.textbox3.TabIndex = 16;
            this.textbox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox3_KeyPress);
            // 
            // textbox4
            // 
            this.textbox4.Location = new System.Drawing.Point(76, 224);
            this.textbox4.MaxLength = 1;
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(28, 20);
            this.textbox4.TabIndex = 17;
            this.textbox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox4_KeyPress);
            // 
            // textbox5
            // 
            this.textbox5.Location = new System.Drawing.Point(76, 250);
            this.textbox5.MaxLength = 1;
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(28, 20);
            this.textbox5.TabIndex = 18;
            this.textbox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox5_KeyPress);
            // 
            // textbox6
            // 
            this.textbox6.Location = new System.Drawing.Point(76, 276);
            this.textbox6.MaxLength = 1;
            this.textbox6.Name = "textbox6";
            this.textbox6.Size = new System.Drawing.Size(28, 20);
            this.textbox6.TabIndex = 19;
            this.textbox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox6_KeyPress);
            // 
            // textbox7
            // 
            this.textbox7.Location = new System.Drawing.Point(76, 302);
            this.textbox7.MaxLength = 1;
            this.textbox7.Name = "textbox7";
            this.textbox7.Size = new System.Drawing.Size(28, 20);
            this.textbox7.TabIndex = 20;
            this.textbox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox7_KeyPress);
            // 
            // textbox8
            // 
            this.textbox8.Location = new System.Drawing.Point(76, 328);
            this.textbox8.MaxLength = 1;
            this.textbox8.Name = "textbox8";
            this.textbox8.Size = new System.Drawing.Size(28, 20);
            this.textbox8.TabIndex = 21;
            this.textbox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox8_KeyPress);
            // 
            // textbox9
            // 
            this.textbox9.Location = new System.Drawing.Point(233, 157);
            this.textbox9.Name = "textbox9";
            this.textbox9.Size = new System.Drawing.Size(100, 20);
            this.textbox9.TabIndex = 22;
            this.textbox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox9_KeyPress);
            // 
            // textbox10
            // 
            this.textbox10.Location = new System.Drawing.Point(233, 302);
            this.textbox10.Name = "textbox10";
            this.textbox10.Size = new System.Drawing.Size(100, 20);
            this.textbox10.TabIndex = 23;
            this.textbox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox10_KeyPress);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SteelBlue;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.back.Location = new System.Drawing.Point(25, 409);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 27);
            this.back.TabIndex = 24;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.SteelBlue;
            this.button_clear.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button_clear.Location = new System.Drawing.Point(466, 409);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(92, 27);
            this.button_clear.TabIndex = 25;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.SteelBlue;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.exit.Location = new System.Drawing.Point(666, 409);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(92, 27);
            this.exit.TabIndex = 26;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Алгоритм Гровера";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Введите пространство поиска";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // algorithm_grover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(770, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textbox10);
            this.Controls.Add(this.textbox9);
            this.Controls.Add(this.textbox8);
            this.Controls.Add(this.textbox7);
            this.Controls.Add(this.textbox6);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "algorithm_grover";
            this.Text = "Алгоритм Гровера";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.TextBox textbox5;
        private System.Windows.Forms.TextBox textbox6;
        private System.Windows.Forms.TextBox textbox7;
        private System.Windows.Forms.TextBox textbox8;
        private System.Windows.Forms.TextBox textbox9;
        private System.Windows.Forms.TextBox textbox10;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}