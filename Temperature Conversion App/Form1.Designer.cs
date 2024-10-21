namespace Temperature_Conversion_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.CelciusBtn = new System.Windows.Forms.RadioButton();
            this.fahrenheitBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kelvinBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(199, 317);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(111, 36);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "CONVERT";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CelciusBtn
            // 
            this.CelciusBtn.AutoSize = true;
            this.CelciusBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelciusBtn.Location = new System.Drawing.Point(83, 72);
            this.CelciusBtn.Name = "CelciusBtn";
            this.CelciusBtn.Size = new System.Drawing.Size(76, 23);
            this.CelciusBtn.TabIndex = 1;
            this.CelciusBtn.TabStop = true;
            this.CelciusBtn.Text = "Celcius";
            this.CelciusBtn.UseVisualStyleBackColor = true;
            // 
            // fahrenheitBtn
            // 
            this.fahrenheitBtn.AutoSize = true;
            this.fahrenheitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitBtn.Location = new System.Drawing.Point(375, 72);
            this.fahrenheitBtn.Name = "fahrenheitBtn";
            this.fahrenheitBtn.Size = new System.Drawing.Size(100, 23);
            this.fahrenheitBtn.TabIndex = 2;
            this.fahrenheitBtn.TabStop = true;
            this.fahrenheitBtn.Text = "Fahrenheit";
            this.fahrenheitBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 33);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTER VALUE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "SELECT TEMPERATURE";
            // 
            // kelvinBtn
            // 
            this.kelvinBtn.AutoSize = true;
            this.kelvinBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelvinBtn.Location = new System.Drawing.Point(239, 72);
            this.kelvinBtn.Name = "kelvinBtn";
            this.kelvinBtn.Size = new System.Drawing.Size(71, 23);
            this.kelvinBtn.TabIndex = 8;
            this.kelvinBtn.TabStop = true;
            this.kelvinBtn.Text = "Kelvin";
            this.kelvinBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 484);
            this.Controls.Add(this.kelvinBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fahrenheitBtn);
            this.Controls.Add(this.CelciusBtn);
            this.Controls.Add(this.btn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temperature Conversion App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RadioButton CelciusBtn;
        private System.Windows.Forms.RadioButton fahrenheitBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton kelvinBtn;
    }
}

