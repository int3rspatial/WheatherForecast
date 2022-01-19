namespace WeatherForecast
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.forecastBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(16, 49);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1100, 400);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // forecastBtn
            // 
            this.forecastBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forecastBtn.Location = new System.Drawing.Point(667, 8);
            this.forecastBtn.Name = "forecastBtn";
            this.forecastBtn.Size = new System.Drawing.Size(149, 35);
            this.forecastBtn.TabIndex = 1;
            this.forecastBtn.Text = "Forecast";
            this.forecastBtn.UseVisualStyleBackColor = true;
            this.forecastBtn.Click += new System.EventHandler(this.forecastBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude:";
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latitudeTextBox.Location = new System.Drawing.Point(112, 11);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(178, 32);
            this.latitudeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(319, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitude:";
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.longitudeTextBox.Location = new System.Drawing.Point(436, 11);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(178, 32);
            this.longitudeTextBox.TabIndex = 5;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(16, 481);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1100, 400);
            this.cartesianChart2.TabIndex = 6;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 907);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastBtn);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wheather forecast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button forecastBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
    }
}

