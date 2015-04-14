using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FlyFF_Helper.Helpers;
using Gma.UserActivityMonitor;

namespace FlyFF_Helper.Hotkeys
{
    public partial class HotkeyForm : Form
    {
        private Dictionary<string, Enums.HOTKEY_ENUM> _AllHotkeys;
        public HotkeyManager _HkManager;
        private Keys _NewHotkey;
        public Action _OnExit;

        public HotkeyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  On exit, we need to invoke the delegate specified in the area that created this form.
        ///  Generally needed to update hotkeys on the fly
        /// </summary>
        protected override void OnClosing(CancelEventArgs e)
        {
            _OnExit.Invoke();
            base.OnClosing(e);
        }

        /// <summary>
        ///  When the user decides to change the hotkey, we need to create a new instance of the GMA
        ///  hook manager. This allows compatability with global hotkey recognition.
        /// </summary>
        private void btnHKChange_Click(object sender, EventArgs e)
        {
            HookManager.KeyDown += new KeyEventHandler(HookManager_KeyDown);
            txtHKSet.Focus();
        }

        /// <summary>
        ///  Update the hotkey dictionary in HotkeyManager.
        /// </summary>
        private void btnHKUpdate_Click(object sender, EventArgs e)
        {
            _HkManager._Hotkeys.UpdateHotkey(_AllHotkeys[cbHotkeys.SelectedItem.ToString()], _NewHotkey);
        }

        /// <summary>
        ///  Exit()
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///  When the user selects a different hotkey to change, we need to update the interface
        ///  to show all about the hotkey they're changing.
        /// </summary>
        private void cbHotkeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hotkey = _HkManager._Hotkeys.GetHotkey(_AllHotkeys[cbHotkeys.SelectedItem.ToString()]);

            lblHKDesc.Text = hotkey.HotkeyDescription;
            lblHKName.Text = hotkey.HotkeyName;
            txtHKSet.Text = hotkey.HotkeyKey.ToString();
            _NewHotkey = hotkey.HotkeyKey;
            gbHotkeyUpdate.Visible = true;
        }

        /// <summary>
        ///  Global Keydown
        /// </summary>
        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            _NewHotkey = e.KeyData;
            txtHKSet.Text = e.KeyData.ToString();
        }

        /// <summary>
        ///  On Hotkey startup, we need to get all the hotkeys to load in cbHotkeys
        /// </summary>
        private void HotkeyForm_Load(object sender, EventArgs e)
        {
            _AllHotkeys = new Dictionary<string, Enums.HOTKEY_ENUM>();

            foreach (var hotkey in _HkManager._Hotkeys.GetAllHotkeys())
            {
                _AllHotkeys.Add(hotkey.HotkeyName, hotkey.HotkeyEnum);
                cbHotkeys.Items.Add(hotkey.HotkeyName);
            }
        }
    }
}