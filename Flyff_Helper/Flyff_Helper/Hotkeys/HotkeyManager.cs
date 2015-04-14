namespace FlyFF_Helper.Hotkeys
{
    public class HotkeyManager
    {
        public string _HotkeyFile;
        public Hotkeys _Hotkeys;

        /// <summary>
        ///  Constructor. 
        ///  Takes in hotkey file to load hotkeys.
        /// </summary>
        public HotkeyManager(string hkFile)
        {
            _HotkeyFile = hkFile;
            _Hotkeys = new Hotkeys();

            _Hotkeys.LoadHotkeysFromFile(hkFile);
        }
    }
}