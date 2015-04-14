namespace FlyFF_Helper
{
    partial class MainForm
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
            this.btnGetHealerClient = new System.Windows.Forms.Button();
            this.btnGetMainClient = new System.Windows.Forms.Button();
            this.chkToggleStatus = new System.Windows.Forms.CheckBox();
            this.chkDoubleClickT = new System.Windows.Forms.CheckBox();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu_Hotkeys = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetHealerClient
            // 
            this.btnGetHealerClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetHealerClient.Location = new System.Drawing.Point(12, 32);
            this.btnGetHealerClient.Name = "btnGetHealerClient";
            this.btnGetHealerClient.Size = new System.Drawing.Size(180, 53);
            this.btnGetHealerClient.TabIndex = 0;
            this.btnGetHealerClient.Text = "Set RM Client";
            this.btnGetHealerClient.UseVisualStyleBackColor = true;
            this.btnGetHealerClient.Click += new System.EventHandler(this.btnGetHealerClient_Click);
            // 
            // btnGetMainClient
            // 
            this.btnGetMainClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetMainClient.Location = new System.Drawing.Point(12, 91);
            this.btnGetMainClient.Name = "btnGetMainClient";
            this.btnGetMainClient.Size = new System.Drawing.Size(180, 53);
            this.btnGetMainClient.TabIndex = 2;
            this.btnGetMainClient.Text = "Set Main Client";
            this.btnGetMainClient.UseVisualStyleBackColor = true;
            this.btnGetMainClient.Click += new System.EventHandler(this.btnGetMainClient_Click);
            // 
            // chkToggleStatus
            // 
            this.chkToggleStatus.AutoSize = true;
            this.chkToggleStatus.Location = new System.Drawing.Point(12, 148);
            this.chkToggleStatus.Name = "chkToggleStatus";
            this.chkToggleStatus.Size = new System.Drawing.Size(167, 17);
            this.chkToggleStatus.TabIndex = 3;
            this.chkToggleStatus.Text = "Helper status is currently: OFF";
            this.chkToggleStatus.UseVisualStyleBackColor = true;
            this.chkToggleStatus.CheckedChanged += new System.EventHandler(this.chkToggleStatus_CheckedChanged);
            // 
            // chkDoubleClickT
            // 
            this.chkDoubleClickT.AutoSize = true;
            this.chkDoubleClickT.Location = new System.Drawing.Point(12, 168);
            this.chkDoubleClickT.Name = "chkDoubleClickT";
            this.chkDoubleClickT.Size = new System.Drawing.Size(176, 17);
            this.chkDoubleClickT.TabIndex = 4;
            this.chkDoubleClickT.Text = "Double Click T is Currently: OFF";
            this.chkDoubleClickT.UseVisualStyleBackColor = true;
            this.chkDoubleClickT.CheckedChanged += new System.EventHandler(this.chkDoubleClickT_CheckedChanged);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(204, 24);
            this.msMainMenu.TabIndex = 5;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenu_Hotkeys});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // msMainMenu_Hotkeys
            // 
            this.msMainMenu_Hotkeys.Name = "msMainMenu_Hotkeys";
            this.msMainMenu_Hotkeys.Size = new System.Drawing.Size(152, 22);
            this.msMainMenu_Hotkeys.Text = "Hotkeys";
            this.msMainMenu_Hotkeys.Click += new System.EventHandler(this.msMainMenu_Hotkeys_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 195);
            this.Controls.Add(this.chkDoubleClickT);
            this.Controls.Add(this.chkToggleStatus);
            this.Controls.Add(this.btnGetMainClient);
            this.Controls.Add(this.btnGetHealerClient);
            this.Controls.Add(this.msMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.MaximumSize = new System.Drawing.Size(220, 233);
            this.MinimumSize = new System.Drawing.Size(220, 233);
            this.Name = "MainForm";
            this.Text = "FlyFF Helper";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetHealerClient;
        private System.Windows.Forms.Button btnGetMainClient;
        private System.Windows.Forms.CheckBox chkToggleStatus;
        private System.Windows.Forms.CheckBox chkDoubleClickT;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msMainMenu_Hotkeys;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

