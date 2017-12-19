using System;

namespace CloudSaves
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
            this.SyncSaveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyncSaveButton
            // 
            this.SyncSaveButton.BackColor = System.Drawing.Color.White;
            this.SyncSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SyncSaveButton.Location = new System.Drawing.Point(13, 43);
            this.SyncSaveButton.Name = "SyncSaveButton";
            this.SyncSaveButton.Size = new System.Drawing.Size(222, 36);
            this.SyncSaveButton.TabIndex = 3;
            this.SyncSaveButton.Text = "Sync Save";
            this.SyncSaveButton.UseVisualStyleBackColor = false;
            this.SyncSaveButton.Click += new System.EventHandler(this.SyncSaveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackColor = System.Drawing.Color.White;
            this.ConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfigButton.Image")));
            this.ConfigButton.Location = new System.Drawing.Point(241, 43);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(45, 36);
            this.ConfigButton.TabIndex = 5;
            this.ConfigButton.UseVisualStyleBackColor = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 93);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SyncSaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Saves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SyncSaveButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ConfigButton;
    }
}

