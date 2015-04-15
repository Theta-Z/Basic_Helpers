namespace FlyFF_Helper.Hotkeys
{
    partial class HotkeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbHotkeys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHotkeyUpdate = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHKChange = new System.Windows.Forms.Button();
            this.btnHKUpdate = new System.Windows.Forms.Button();
            this.lblHKDesc = new System.Windows.Forms.Label();
            this.lblHKName = new System.Windows.Forms.Label();
            this.txtHKSet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbHotkeyUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHotkeys
            // 
            this.cbHotkeys.FormattingEnabled = true;
            this.cbHotkeys.Location = new System.Drawing.Point(12, 34);
            this.cbHotkeys.Name = "cbHotkeys";
            this.cbHotkeys.Size = new System.Drawing.Size(253, 21);
            this.cbHotkeys.TabIndex = 0;
            this.cbHotkeys.SelectedIndexChanged += new System.EventHandler(this.cbHotkeys_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotkeys";
            // 
            // gbHotkeyUpdate
            // 
            this.gbHotkeyUpdate.Controls.Add(this.btnQuit);
            this.gbHotkeyUpdate.Controls.Add(this.btnHKChange);
            this.gbHotkeyUpdate.Controls.Add(this.btnHKUpdate);
            this.gbHotkeyUpdate.Controls.Add(this.lblHKDesc);
            this.gbHotkeyUpdate.Controls.Add(this.lblHKName);
            this.gbHotkeyUpdate.Controls.Add(this.txtHKSet);
            this.gbHotkeyUpdate.Controls.Add(this.label4);
            this.gbHotkeyUpdate.Controls.Add(this.label3);
            this.gbHotkeyUpdate.Controls.Add(this.label2);
            this.gbHotkeyUpdate.Location = new System.Drawing.Point(12, 76);
            this.gbHotkeyUpdate.Name = "gbHotkeyUpdate";
            this.gbHotkeyUpdate.Size = new System.Drawing.Size(253, 191);
            this.gbHotkeyUpdate.TabIndex = 2;
            this.gbHotkeyUpdate.TabStop = false;
            this.gbHotkeyUpdate.Text = "Update Hotkey";
            this.gbHotkeyUpdate.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(94, 154);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(63, 28);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnHKChange
            // 
            this.btnHKChange.Location = new System.Drawing.Point(163, 154);
            this.btnHKChange.Name = "btnHKChange";
            this.btnHKChange.Size = new System.Drawing.Size(84, 28);
            this.btnHKChange.TabIndex = 7;
            this.btnHKChange.Text = "Change Key";
            this.btnHKChange.UseVisualStyleBackColor = true;
            this.btnHKChange.Click += new System.EventHandler(this.btnHKChange_Click);
            // 
            // btnHKUpdate
            // 
            this.btnHKUpdate.Location = new System.Drawing.Point(6, 154);
            this.btnHKUpdate.Name = "btnHKUpdate";
            this.btnHKUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnHKUpdate.TabIndex = 6;
            this.btnHKUpdate.Text = "Save";
            this.btnHKUpdate.UseVisualStyleBackColor = true;
            this.btnHKUpdate.Click += new System.EventHandler(this.btnHKUpdate_Click);
            // 
            // lblHKDesc
            // 
            this.lblHKDesc.AutoSize = true;
            this.lblHKDesc.Location = new System.Drawing.Point(39, 83);
            this.lblHKDesc.Name = "lblHKDesc";
            this.lblHKDesc.Size = new System.Drawing.Size(13, 13);
            this.lblHKDesc.TabIndex = 5;
            this.lblHKDesc.Text = "--";
            // 
            // lblHKName
            // 
            this.lblHKName.AutoSize = true;
            this.lblHKName.Location = new System.Drawing.Point(39, 41);
            this.lblHKName.Name = "lblHKName";
            this.lblHKName.Size = new System.Drawing.Size(13, 13);
            this.lblHKName.TabIndex = 4;
            this.lblHKName.Text = "--";
            // 
            // txtHKSet
            // 
            this.txtHKSet.Location = new System.Drawing.Point(6, 128);
            this.txtHKSet.Name = "txtHKSet";
            this.txtHKSet.ReadOnly = true;
            this.txtHKSet.Size = new System.Drawing.Size(241, 20);
            this.txtHKSet.TabIndex = 3;
            this.txtHKSet.Text = "{ Click me and press a key! }";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hotkey : Set Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hotkey Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotkey Name";
            // 
            // HotkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 275);
            this.Controls.Add(this.gbHotkeyUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHotkeys);
            this.MaximumSize = new System.Drawing.Size(295, 313);
            this.MinimumSize = new System.Drawing.Size(295, 313);
            this.Name = "HotkeyForm";
            this.Text = "HotkeyForm";
            this.Load += new System.EventHandler(this.HotkeyForm_Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.gbHotkeyUpdate.ResumeLayout(false);
            this.gbHotkeyUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHotkeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHotkeyUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHKDesc;
        private System.Windows.Forms.Label lblHKName;
        private System.Windows.Forms.TextBox txtHKSet;
        private System.Windows.Forms.Button btnHKChange;
        private System.Windows.Forms.Button btnHKUpdate;
        private System.Windows.Forms.Button btnQuit;

    }
}