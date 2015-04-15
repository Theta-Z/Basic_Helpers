using System.IO;

namespace FlyFF_Helper.Helpers
{
    /// <summary>
    ///  Directories? Create them if not there? Ok.
    /// </summary>
    public class Directories
    {
        /// <summary>
        ///  Create a local directory if it doesn't exist.
        ///  Path: [currentdirectory]\CreateFolder\MoreFolders
        /// </summary>
        /// <param name="directory">The specific directory to create.</param>
        public static void CreateLocalDirectoryIfNotExists(string directory)
        {
            var pwd = Directory.GetCurrentDirectory();

            if (!Directory.Exists(string.Format(@"{0}\{1}", pwd, directory)))
                Directory.CreateDirectory(string.Format(@"{0}\{1}", pwd, directory));
        }

        /// <summary>
        ///  Setup the Directories needed for FlyFF_Helper
        /// </summary>
        public static void SetupDirectories()
        {
            CreateLocalDirectoryIfNotExists("Settings");
            CreateLocalDirectoryIfNotExists(@"Settings\Hotkeys");
        }
    }
}