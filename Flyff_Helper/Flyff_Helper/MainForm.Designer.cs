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
      this.SuspendLayout();
      // 
      // btnGetHealerClient
      // 
      this.btnGetHealerClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnGetHealerClient.Location = new System.Drawing.Point(12, 3);
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
      this.btnGetMainClient.Location = new System.Drawing.Point(12, 62);
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
      this.chkToggleStatus.Location = new System.Drawing.Point(12, 119);
      this.chkToggleStatus.Name = "chkToggleStatus";
      this.chkToggleStatus.Size = new System.Drawing.Size(167, 17);
      this.chkToggleStatus.TabIndex = 3;
      this.chkToggleStatus.Text = "Helper status is currently: OFF";
      this.chkToggleStatus.UseVisualStyleBackColor = true;
      this.chkToggleStatus.CheckedChanged += new System.EventHandler(this.chkToggleStatus_CheckedChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(204, 139);
      this.Controls.Add(this.chkToggleStatus);
      this.Controls.Add(this.btnGetMainClient);
      this.Controls.Add(this.btnGetHealerClient);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(220, 177);
      this.MinimumSize = new System.Drawing.Size(220, 177);
      this.Name = "MainForm";
      this.Text = "FlyFF Helper";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGetHealerClient;
    private System.Windows.Forms.Button btnGetMainClient;
    private System.Windows.Forms.CheckBox chkToggleStatus;
  }
}

