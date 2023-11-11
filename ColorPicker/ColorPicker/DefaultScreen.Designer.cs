﻿namespace ColorPicker
{
    partial class DefaultScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultScreen));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton3 = new ColorPicker.Visual.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedLabel2 = new ColorPicker.Visual.RoundedLabel();
            this.roundedButton2 = new ColorPicker.Visual.RoundedButton();
            this.roundedLabel1 = new ColorPicker.Visual.RoundedLabel();
            this.roundedButton1 = new ColorPicker.Visual.RoundedButton();
            this.roundedPanel2 = new ColorPicker.Visual.RoundedPanel();
            this.roundedButton4 = new ColorPicker.Visual.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.roundedButton4);
            this.panel1.Controls.Add(this.roundedButton3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 29);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // roundedButton3
            // 
            this.roundedButton3._cornerRadiusX = 10;
            this.roundedButton3._cornerRadiusY = 10;
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.roundedButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton3.Image = global::ColorPicker.Properties.Resources.pin20x20;
            this.roundedButton3.Location = new System.Drawing.Point(122, 3);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(42, 23);
            this.roundedButton3.TabIndex = 13;
            this.roundedButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color Picker";
            // 
            // roundedLabel2
            // 
            this.roundedLabel2._cornerRadiusX = 15;
            this.roundedLabel2._cornerRadiusY = 15;
            this.roundedLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedLabel2.Location = new System.Drawing.Point(14, 85);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(84, 57);
            this.roundedLabel2.TabIndex = 11;
            this.roundedLabel2.Text = "HEX:";
            this.roundedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedLabel2.UseCompatibleTextRendering = true;
            // 
            // roundedButton2
            // 
            this.roundedButton2._cornerRadiusX = 10;
            this.roundedButton2._cornerRadiusY = 10;
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.roundedButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton2.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton2.Image")));
            this.roundedButton2.Location = new System.Drawing.Point(104, 111);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(84, 31);
            this.roundedButton2.TabIndex = 10;
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedLabel1
            // 
            this.roundedLabel1._cornerRadiusX = 15;
            this.roundedLabel1._cornerRadiusY = 15;
            this.roundedLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedLabel1.Location = new System.Drawing.Point(104, 85);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(84, 23);
            this.roundedLabel1.TabIndex = 8;
            this.roundedLabel1.Text = "#C7C6C5";
            this.roundedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedLabel1.UseCompatibleTextRendering = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1._cornerRadiusX = 10;
            this.roundedButton1._cornerRadiusY = 10;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton1.Image")));
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(14, 37);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedButton1.Size = new System.Drawing.Size(84, 42);
            this.roundedButton1.TabIndex = 6;
            this.roundedButton1.Text = "Select";
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.roundedButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2._cornerRadiusX = 10;
            this.roundedPanel2._cornerRadiusY = 10;
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.roundedPanel2.Location = new System.Drawing.Point(104, 37);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(83, 42);
            this.roundedPanel2.TabIndex = 1;
            this.roundedPanel2.Text = "roundedPanel2";
            // 
            // roundedButton4
            // 
            this.roundedButton4._cornerRadiusX = 10;
            this.roundedButton4._cornerRadiusY = 10;
            this.roundedButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.roundedButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton4.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton4.Image")));
            this.roundedButton4.Location = new System.Drawing.Point(171, 3);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(23, 23);
            this.roundedButton4.TabIndex = 14;
            this.roundedButton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DefaultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(197, 151);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefaultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Visual.RoundedPanel roundedPanel2;
        private Visual.RoundedButton roundedButton1;
        private Visual.RoundedLabel roundedLabel1;
        private Visual.RoundedButton roundedButton2;
        private Visual.RoundedLabel roundedLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Visual.RoundedButton roundedButton3;
        private Visual.RoundedButton roundedButton4;
    }
}

