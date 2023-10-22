namespace Stocks
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
            System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation verticalLineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.chart1_stocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1_apikey = new System.Windows.Forms.TextBox();
            this.button2_setedit = new System.Windows.Forms.Button();
            this.label1_plsapi = new System.Windows.Forms.Label();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_up = new System.Windows.Forms.PictureBox();
            this.label_up = new System.Windows.Forms.Label();
            this.label_down = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_stocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Stock Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1_stocks
            // 
            verticalLineAnnotation2.AxisXName = "ChartArea1\\rX";
            verticalLineAnnotation2.ClipToChartArea = "ChartArea1";
            verticalLineAnnotation2.LineColor = System.Drawing.Color.Red;
            verticalLineAnnotation2.Name = "VerticalLineAnnotation1";
            verticalLineAnnotation2.YAxisName = "ChartArea1\\rY2";
            this.chart1_stocks.Annotations.Add(verticalLineAnnotation2);
            this.chart1_stocks.BackColor = System.Drawing.Color.Transparent;
            this.chart1_stocks.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1_stocks.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chart1_stocks.ChartAreas.Add(chartArea3);
            this.chart1_stocks.Cursor = System.Windows.Forms.Cursors.Cross;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.TitleForeColor = System.Drawing.Color.White;
            legend3.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1_stocks.Legends.Add(legend3);
            this.chart1_stocks.Location = new System.Drawing.Point(595, -7);
            this.chart1_stocks.Name = "chart1_stocks";
            this.chart1_stocks.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series3.BorderColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series3.Color = System.Drawing.Color.SteelBlue;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "StockPrices";
            series3.ShadowColor = System.Drawing.Color.White;
            series3.YValuesPerPoint = 2;
            this.chart1_stocks.Series.Add(series3);
            this.chart1_stocks.Size = new System.Drawing.Size(580, 334);
            this.chart1_stocks.TabIndex = 5;
            this.chart1_stocks.Text = "chart1_stocks";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.HeaderSeparatorColor = System.Drawing.Color.White;
            legend4.IsTextAutoFit = false;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            legend4.TitleForeColor = System.Drawing.Color.White;
            legend4.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, -7);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series4.BorderColor = System.Drawing.Color.White;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "StockPricesZoomed";
            series4.ShadowColor = System.Drawing.Color.White;
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(589, 334);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "---CryptoCurrencies---",
            "Bitcoin#BTCUSD",
            "Ether#ETH",
            "Litecoin#LTC",
            "---Forex---",
            "EUR/USD#EURUSD",
            "GBP/USD#GBPUSD",
            "USD/JPY#USDJPY",
            "USD/CAD#USDCAD"});
            this.listBox1.Location = new System.Drawing.Point(0, 389);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 121);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // textBox1_apikey
            // 
            this.textBox1_apikey.Location = new System.Drawing.Point(483, 521);
            this.textBox1_apikey.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_apikey.Name = "textBox1_apikey";
            this.textBox1_apikey.Size = new System.Drawing.Size(153, 20);
            this.textBox1_apikey.TabIndex = 8;
            this.textBox1_apikey.Text = "MW8FO6ADJ32J3TLP";
            this.textBox1_apikey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_apikey_KeyDown);
            // 
            // button2_setedit
            // 
            this.button2_setedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2_setedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2_setedit.ForeColor = System.Drawing.SystemColors.Control;
            this.button2_setedit.Location = new System.Drawing.Point(641, 521);
            this.button2_setedit.Name = "button2_setedit";
            this.button2_setedit.Size = new System.Drawing.Size(60, 23);
            this.button2_setedit.TabIndex = 9;
            this.button2_setedit.Text = "SET";
            this.button2_setedit.UseVisualStyleBackColor = false;
            this.button2_setedit.Click += new System.EventHandler(this.button2_setedit_Click);
            // 
            // label1_plsapi
            // 
            this.label1_plsapi.AutoSize = true;
            this.label1_plsapi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_plsapi.Location = new System.Drawing.Point(492, 545);
            this.label1_plsapi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1_plsapi.Name = "label1_plsapi";
            this.label1_plsapi.Size = new System.Drawing.Size(144, 13);
            this.label1_plsapi.TabIndex = 10;
            this.label1_plsapi.Text = "PLEASE SET THE API KEY:";
            this.label1_plsapi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.Image = global::Stocks.Properties.Resources.PinClipart_com_triangle_clip_art_1008699;
            this.pictureBox_down.Location = new System.Drawing.Point(721, 343);
            this.pictureBox_down.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(48, 54);
            this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_down.TabIndex = 12;
            this.pictureBox_down.TabStop = false;
            this.pictureBox_down.Visible = false;
            // 
            // pictureBox_up
            // 
            this.pictureBox_up.Image = global::Stocks.Properties.Resources.PinClipart_com_green_arrows_clip_art_4082067__1_;
            this.pictureBox_up.Location = new System.Drawing.Point(937, 343);
            this.pictureBox_up.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_up.Name = "pictureBox_up";
            this.pictureBox_up.Size = new System.Drawing.Size(48, 54);
            this.pictureBox_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_up.TabIndex = 11;
            this.pictureBox_up.TabStop = false;
            this.pictureBox_up.Visible = false;
            // 
            // label_up
            // 
            this.label_up.AutoSize = true;
            this.label_up.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_up.ForeColor = System.Drawing.Color.Lime;
            this.label_up.Location = new System.Drawing.Point(954, 399);
            this.label_up.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_up.Name = "label_up";
            this.label_up.Size = new System.Drawing.Size(31, 20);
            this.label_up.TabIndex = 13;
            this.label_up.Text = "5%";
            this.label_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_up.Visible = false;
            // 
            // label_down
            // 
            this.label_down.AutoSize = true;
            this.label_down.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_down.ForeColor = System.Drawing.Color.Red;
            this.label_down.Location = new System.Drawing.Point(738, 399);
            this.label_down.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_down.Name = "label_down";
            this.label_down.Size = new System.Drawing.Size(31, 20);
            this.label_down.TabIndex = 14;
            this.label_down.Text = "5%";
            this.label_down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_down.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Stock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1172, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_down);
            this.Controls.Add(this.label_up);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_up);
            this.Controls.Add(this.label1_plsapi);
            this.Controls.Add(this.button2_setedit);
            this.Controls.Add(this.textBox1_apikey);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart1_stocks);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STONKS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1_stocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_stocks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1_apikey;
        private System.Windows.Forms.Button button2_setedit;
        private System.Windows.Forms.Label label1_plsapi;
        private System.Windows.Forms.PictureBox pictureBox_up;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.Label label_up;
        private System.Windows.Forms.Label label_down;
        private System.Windows.Forms.Label label1;
    }
}

