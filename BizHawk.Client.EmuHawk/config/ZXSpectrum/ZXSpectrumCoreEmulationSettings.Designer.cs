﻿namespace BizHawk.Client.EmuHawk
{
    partial class ZXSpectrumCoreEmulationSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZXSpectrumCoreEmulationSettings));
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MachineSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMachineNotes = new System.Windows.Forms.Label();
            this.determEmucheckBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borderTypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBorderInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(247, 485);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(60, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "&OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(313, 485);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(60, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Emulated Machine:";
            // 
            // MachineSelectionComboBox
            // 
            this.MachineSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MachineSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineSelectionComboBox.FormattingEnabled = true;
            this.MachineSelectionComboBox.Location = new System.Drawing.Point(12, 62);
            this.MachineSelectionComboBox.Name = "MachineSelectionComboBox";
            this.MachineSelectionComboBox.Size = new System.Drawing.Size(361, 21);
            this.MachineSelectionComboBox.TabIndex = 13;
            this.MachineSelectionComboBox.SelectionChangeCommitted += new System.EventHandler(this.MachineSelectionComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ZX Spectrum Emulation Settings";
            // 
            // lblMachineNotes
            // 
            this.lblMachineNotes.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineNotes.Location = new System.Drawing.Point(15, 95);
            this.lblMachineNotes.Name = "lblMachineNotes";
            this.lblMachineNotes.Size = new System.Drawing.Size(358, 204);
            this.lblMachineNotes.TabIndex = 20;
            this.lblMachineNotes.Text = "null\r\n";
            // 
            // determEmucheckBox1
            // 
            this.determEmucheckBox1.AutoSize = true;
            this.determEmucheckBox1.Location = new System.Drawing.Point(15, 302);
            this.determEmucheckBox1.Name = "determEmucheckBox1";
            this.determEmucheckBox1.Size = new System.Drawing.Size(135, 17);
            this.determEmucheckBox1.TabIndex = 21;
            this.determEmucheckBox1.Text = "Deterministic Emulation";
            this.determEmucheckBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Rendered Border Type:";
            // 
            // borderTypecomboBox1
            // 
            this.borderTypecomboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderTypecomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderTypecomboBox1.FormattingEnabled = true;
            this.borderTypecomboBox1.Location = new System.Drawing.Point(12, 351);
            this.borderTypecomboBox1.Name = "borderTypecomboBox1";
            this.borderTypecomboBox1.Size = new System.Drawing.Size(157, 21);
            this.borderTypecomboBox1.TabIndex = 22;
            this.borderTypecomboBox1.SelectedIndexChanged += new System.EventHandler(this.borderTypecomboBox1_SelectedIndexChanged);
            // 
            // lblBorderInfo
            // 
            this.lblBorderInfo.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorderInfo.Location = new System.Drawing.Point(175, 351);
            this.lblBorderInfo.Name = "lblBorderInfo";
            this.lblBorderInfo.Size = new System.Drawing.Size(196, 21);
            this.lblBorderInfo.TabIndex = 24;
            this.lblBorderInfo.Text = "null";
            this.lblBorderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ZXSpectrumCoreEmulationSettings
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(385, 520);
            this.Controls.Add(this.lblBorderInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borderTypecomboBox1);
            this.Controls.Add(this.determEmucheckBox1);
            this.Controls.Add(this.lblMachineNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MachineSelectionComboBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZXSpectrumCoreEmulationSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Core Emulation Settings";
            this.Load += new System.EventHandler(this.IntvControllerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MachineSelectionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMachineNotes;
        private System.Windows.Forms.CheckBox determEmucheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox borderTypecomboBox1;
        private System.Windows.Forms.Label lblBorderInfo;
    }
}