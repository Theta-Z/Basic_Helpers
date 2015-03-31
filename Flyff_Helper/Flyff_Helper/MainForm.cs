using System;
using System.Windows.Forms;
using FlyFF_Helper.Helpers;
using Gma.UserActivityMonitor;

namespace FlyFF_Helper
{
  /// <summary>
  /// The main form
  /// </summary>
  public partial class MainForm : Form
  {
    //: DEBUG SWITCH STATEMENTS
    private bool DEBUG = false;

    //: IGNORE
    private bool IGNORE { get; set; }
    private bool TildeDown { get; set; }

    //: Used for HWND [window handle]
    private IntPtr _HealerClient, _MainClient;

    /// <summary>
    /// default constructor
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      HookManager.KeyDown += new KeyEventHandler(HookManager_KeyDown);
      HookManager.KeyUp += new KeyEventHandler(HookManager_KeyUp);
    }

    /// <summary>
    /// Set healer client HWND.
    /// </summary>
    private void btnGetHealerClient_Click(object sender, EventArgs e)
    {
      Timers.OneUseTimer(3000,
        () =>
        {
          _HealerClient = WinAPI.GetActiveWindow();
          Console.Beep(200, 400);
        });
    }

    /// <summary>
    /// Set main client HWND.
    /// </summary>
    private void btnGetMainClient_Click(object sender, EventArgs e)
    {
      Timers.OneUseTimer(3000,
        () => 
        {
          _MainClient = WinAPI.GetActiveWindow();
          Console.Beep(200, 400);
        });
    }

    /// <summary>
    /// Set text of Toggle Status after turning on / off.
    /// </summary>
    private void chkToggleStatus_CheckedChanged(object sender, EventArgs e)
    {
      chkToggleStatus.Text =
        !chkToggleStatus.Checked
          ? "Helper is currently: OFF"
          : "Helper is currently: ON";
    }

    /// <summary>
    /// On global KeyUp, run this.
    /// </summary>
    private void HookManager_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Oemtilde)
        TildeDown = false;
    }

    /// <summary>
    /// On global KeyDown, run this.
    /// Purpose: Send keys {such as F1-9 and C} to the healer client.
    /// </summary>
    private void HookManager_KeyDown(object sender, KeyEventArgs e)
    {
      if (IGNORE || !chkToggleStatus.Checked) return;

      if (TildeDown && e.KeyCode != Keys.Oemtilde)
      {
        if (DEBUG)
        {
          Console.Beep(500, 500);
          btnGetHealerClient.Text = e.KeyCode.ToString();
          return;
        }

        e.Handled = true;
        IGNORE = true;

        WinAPI.SetActiveWindow(_HealerClient);
        WinAPI.Keybd_Event((byte)e.KeyCode);
        WinAPI.SetActiveWindow(_MainClient);

        IGNORE = false;
      }

      if (e.KeyCode == Keys.Oemtilde)
        TildeDown = true;
    }
  }
}
