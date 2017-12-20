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
            this.ConfigButton = new System.Windows.Forms.Button();
            this.configDataGridView = new System.Windows.Forms.DataGridView();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.configDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SyncSaveButton
            // 
            this.SyncSaveButton.BackColor = System.Drawing.Color.White;
            this.SyncSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SyncSaveButton.Location = new System.Drawing.Point(12, 444);
            this.SyncSaveButton.Name = "SyncSaveButton";
            this.SyncSaveButton.Size = new System.Drawing.Size(222, 36);
            this.SyncSaveButton.TabIndex = 3;
            this.SyncSaveButton.Text = "Sync Save";
            this.SyncSaveButton.UseVisualStyleBackColor = false;
            this.SyncSaveButton.Click += new System.EventHandler(this.SyncSaveButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackColor = System.Drawing.Color.White;
            this.ConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfigButton.Image")));
            this.ConfigButton.Location = new System.Drawing.Point(240, 444);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(45, 36);
            this.ConfigButton.TabIndex = 5;
            this.ConfigButton.UseVisualStyleBackColor = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // configDataGridView
            // 
            this.configDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameName});
            this.configDataGridView.Location = new System.Drawing.Point(12, 12);
            this.configDataGridView.MultiSelect = false;
            this.configDataGridView.Name = "configDataGridView";
            this.configDataGridView.ReadOnly = true;
            this.configDataGridView.RowTemplate.Height = 24;
            this.configDataGridView.Size = new System.Drawing.Size(274, 426);
            this.configDataGridView.TabIndex = 6;
            // 
            // gameName
            // 
            this.gameName.HeaderText = "Game Name";
            this.gameName.Name = "gameName";
            this.gameName.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.Controls.Add(this.configDataGridView);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.SyncSaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Saves";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SyncSaveButton;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.DataGridView configDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
    }
}

