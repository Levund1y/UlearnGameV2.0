﻿namespace CityDefense
{
    partial class MainWindow
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
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.renderBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Enabled = true;
            this.Frame.Interval = 40;
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // renderBox
            // 
            this.renderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.renderBox.Location = new System.Drawing.Point(2, -2);
            this.renderBox.Margin = new System.Windows.Forms.Padding(2);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(1920, 1080);
            this.renderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.renderBox.TabIndex = 0;
            this.renderBox.TabStop = false;
            this.renderBox.Click += new System.EventHandler(this.renderBox_Click);
            this.renderBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.renderBox_MouseDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.renderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Students Defence";
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Frame;
        private System.Windows.Forms.PictureBox renderBox;
    }
}

