using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FlyFF_Helper.Helpers;
using Newtonsoft.Json;

namespace FlyFF_Helper.Hotkeys
{
    /// <summary>
    ///  Hotkeys? We got those.
    /// </summary>
    public class Hotkeys
    {
        private Dictionary<Enums.HOTKEY_ENUM, Hotkey> _Hotkeys;

        public Hotkeys()
        {
            _Hotkeys = new Dictionary<Enums.HOTKEY_ENUM, Hotkey>();
        }

        /// <summary>
        ///  Add or update a hotkey, based on a full Hotkey object.
        /// </summary>
        /// <param name="key">HOTKEY_ENUM for which key we're updating / adding</param>
        /// <param name="hotkey">Full Hotkey object to add/update</param>
        public void AddUpdateHotkey(Enums.HOTKEY_ENUM key, Hotkey hotkey)
        {
            if (_Hotkeys.ContainsKey(key))
                _Hotkeys.Remove(key);

            _Hotkeys.Add(key, hotkey);
        }

        /// <summary>
        ///  Get all the hotkeys!
        /// </summary>
        /// <returns>A list of Hotkeys that we currently have.</returns>
        public IList<Hotkey> GetAllHotkeys()
        {
            var hotkeys = new List<Hotkey>();
            foreach (var hotkey in _Hotkeys)
                hotkeys.Add(hotkey.Value);

            return hotkeys;
        }

        /// <summary>
        ///  Gotta create hotkeys sometimes.. I reckon... Mmmhmmm..
        /// </summary>
        public void CreateHotkeys()
        {
            AddUpdateHotkey(
                Enums.HOTKEY_ENUM.TOGGLE_FLYFF_HELPER,
                new Hotkey()
                {
                    HotkeyDescription = "Press this button to toggle on/off the program.",
                    HotkeyEnum = Enums.HOTKEY_ENUM.TOGGLE_FLYFF_HELPER,
                    HotkeyKey = Keys.Up,
                    HotkeyName = Enums.HOTKEY_ENUM.TOGGLE_FLYFF_HELPER.ToString()
                });

            AddUpdateHotkey(
                Enums.HOTKEY_ENUM.MODIFIER_SEND_TO_OTHER_CLIENT,
                new Hotkey()
                {
                    HotkeyDescription = "Hold this key down to send input to your RM client.",
                    HotkeyEnum = Enums.HOTKEY_ENUM.MODIFIER_SEND_TO_OTHER_CLIENT,
                    HotkeyKey = Keys.Oemtilde,
                    HotkeyName = Enums.HOTKEY_ENUM.MODIFIER_SEND_TO_OTHER_CLIENT.ToString()
                });
        }

        /// <summary>
        ///  Get a hotkey based on HOTKEY_ENUM; from our current hotkeys.
        /// </summary>
        /// <param name="hkEnum">The HOTKEY_ENUM you want returned.</param>
        /// <returns>The hotkey based on HOTKEY_ENUM</returns>
        public Hotkey GetHotkey(Enums.HOTKEY_ENUM hkEnum)
        {
            if (_Hotkeys.ContainsKey(hkEnum))
                return _Hotkeys[hkEnum];

            return null;
        }

        /// <summary>
        ///  Loads hotkeys [JSON] from hotkeyFile, or creates a new set of hotkeys if the file is missing.
        /// </summary>
        /// <param name="hotkeyFile"></param>
        /// <returns>True is the File was loaded, false if hotkeys were created.</returns>
        public bool LoadHotkeysFromFile(string hotkeyFile)
        {
            if (!File.Exists(hotkeyFile))
            {
                CreateHotkeys();
                return false;
            }

            using (var sr = new StreamReader(hotkeyFile))
            {
                _Hotkeys = JsonConvert.DeserializeObject<Dictionary<Enums.HOTKEY_ENUM, Hotkey>>(sr.ReadToEnd());

                sr.Close();
            }

            return true;
        }

        /// <summary>
        ///  Save the hotkeys to the hotkeyFile
        /// </summary>
        /// <param name="hotkeyFile">File to save the hotkey JSON in.</param>
        public void SaveHotkeysToFile(string hotkeyFile)
        {
            using (var sw = new StreamWriter(hotkeyFile))
            {
                sw.Write(JsonConvert.SerializeObject(_Hotkeys));
                sw.Close();
            }
        }

        /// <summary>
        ///  Update a hotkey.
        /// </summary>
        /// <param name="key">The HOTKEY_ENUM value for the _Hotkeys Dictionary to update.</param>
        /// <param name="newKey">The [Keys] value for the new hotkey definition.</param>
        public void UpdateHotkey(Enums.HOTKEY_ENUM key, Keys newKey)
        {
            var hotkey = _Hotkeys[key];
            hotkey.HotkeyKey = newKey;

            if (_Hotkeys.ContainsKey(key))
                _Hotkeys.Remove(key);

            _Hotkeys.Add(key, hotkey);
        }
    }
}