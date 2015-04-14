using System.Windows.Forms;
using FlyFF_Helper.Helpers;

namespace FlyFF_Helper.Hotkeys
{
    /// <summary>
    ///  Definition of what a Hotkey is. 
    ///  Thank you dear sweet Newtonsoft.JSON, oh how we love you.
    ///  #NoSarcasm
    /// </summary>
    public class Hotkey
    {
        public string HotkeyDescription;
        public Enums.HOTKEY_ENUM HotkeyEnum;
        public Keys HotkeyKey;
        public string HotkeyName;
    }
}