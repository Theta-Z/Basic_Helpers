using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FlyFF_Helper.Helpers;
using FlyFF_Helper.Hotkeys;
using Gma.UserActivityMonitor;

namespace FlyFF_Helper
{
    /// <summary>
    /// The main form
    /// </summary>
    public partial class MainForm : Form
    {
        //: Properties
        private bool HotkeyFormOpen { get; set; }
        private bool IGNORE { get; set; }
        private Keys SendToRM { get; set; }

        //: Used for HWND [window handle]
        private IntPtr _HealerClient, 
                       _MainClient;
        private HotkeyManager _HkManager;
        private IList<Keys> _KeysDown;

        /// <summary>
        /// default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            HookManager.KeyDown += new KeyEventHandler(HookManager_KeyDown);
            HookManager.KeyUp += new KeyEventHandler(HookManager_KeyUp);
            Directories.SetupDirectories();
            _HkManager = new HotkeyManager(string.Format("{0}{1}", Directory.GetCurrentDirectory(), FlyffHelper.HotkeyFile));
            _KeysDown = new List<Keys>();
            SendToRM = _HkManager._Hotkeys.GetHotkey(Enums.HOTKEY_ENUM.MODIFIER_SEND_TO_OTHER_CLIENT).HotkeyKey;
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
        ///  Toggle [ T = Double click ]
        /// </summary>
        private void chkDoubleClickT_CheckedChanged(object sender, EventArgs e)
        {
            chkDoubleClickT.Text =
                chkDoubleClickT.Checked
                ? "Double Click T is Currently: ON"
                : "Double Click T is Currently: OFF";
        }

        #region Global Hook Manager

        /// <summary>
        /// On global KeyUp, run this.
        /// </summary>
        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
#if DEBUG
            {
                _KeysDown.Remove((Keys)e.KeyValue);
                btnGetHealerClient.Text = "";

                foreach (var key in _KeysDown)
                    btnGetHealerClient.Text += key.ToString();

                return;
            }
#endif

            if (e.KeyData == _HkManager._Hotkeys.GetHotkey(Enums.HOTKEY_ENUM.TOGGLE_FLYFF_HELPER).HotkeyKey)
            {
                chkToggleStatus.Checked = !chkToggleStatus.Checked;
                e.Handled = true;
                return;
            }

            _KeysDown.Remove(e.KeyData);

            if (chkDoubleClickT.Checked && e.KeyCode == Keys.G)
            {
                e.Handled = true;
                WinAPI.Mouse_RightHold(WinAPI.MouseClickStatus.MOUSE_UP);
            }
        }

        /// <summary>
        /// On global KeyDown, run this.
        /// Purpose: Send keys {such as F1-9 and C} to the healer client.
        /// </summary>
        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
#if DEBUG
            {
                if (!_KeysDown.Contains((Keys)e.KeyValue))
                {
                    _KeysDown.Add((Keys)e.KeyValue);
                }
                btnGetHealerClient.Text = "";

                foreach (var key in _KeysDown)
                    btnGetHealerClient.Text += key.ToString();

                return;
            }
#endif

            if (HotkeyFormOpen || IGNORE || !chkToggleStatus.Checked) return;

            #region TODO: Make these into hotkeys

            if (chkDoubleClickT.Checked && e.KeyCode == Keys.T)
            {
                WinAPI.Mouse_LeftClick(2);
                e.Handled = true;
                return;
            }

            if (chkDoubleClickT.Checked && e.KeyCode == Keys.G)
            {
                e.Handled = true;
                WinAPI.Mouse_RightHold(WinAPI.MouseClickStatus.MOUSE_DOWN);
                return;
            }

            #endregion TODO: Make these into hotkeys

            if (!_KeysDown.Contains(e.KeyData))
                _KeysDown.Add(e.KeyData);

            if (_KeysDown.Contains(SendToRM) && e.KeyData != SendToRM)
            {
                e.Handled = true;
                IGNORE = true;

                WinAPI.SetActiveWindow(_HealerClient);
                WinAPI.Keybd_Event((byte)e.KeyCode);
                WinAPI.SetActiveWindow(_MainClient);

                IGNORE = false;
            }
        }

        #endregion Global Hook Manager

        /// <summary>
        ///  Open hotkeys area
        /// </summary>
        private void msMainMenu_Hotkeys_Click(object sender, EventArgs e)
        {
            HotkeyFormOpen = true;
            new HotkeyForm
            {
                _HkManager = this._HkManager,
                _OnExit = () =>
                {
                    _HkManager._Hotkeys.SaveHotkeysToFile(_HkManager._HotkeyFile);
                    SendToRM = _HkManager._Hotkeys.GetHotkey(Enums.HOTKEY_ENUM.MODIFIER_SEND_TO_OTHER_CLIENT).HotkeyKey;
                    HotkeyFormOpen = false;
                }
            }.Show();
        }
    }
}