using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace FlyFF_Helper.Helpers
{
  /// <summary>
  /// Wrappers for windows API functions.
  /// </summary>
  public class WinAPI
  {
    //: Used for keybd_event API
    private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
    private const uint KEYEVENTF_KEYUP = 0x0002;

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();
    
    [DllImport("user32.dll")]
    private static extern bool keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    /// <summary>
    /// Get the active window
    /// </summary>
    /// <returns>HWND to active window.</returns>
    public static IntPtr GetActiveWindow()
    {
      return GetForegroundWindow();
    }

    /// <summary>
    ///   Send a keyboard event.
    /// </summary>
    /// <param name="keyCode">The (byte)Keys.Key to send.</param>
    public static void Keybd_Event(byte keyCode)
    {
      Thread.Sleep(10);
      keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
      Thread.Sleep(130);
      keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
      Thread.Sleep(10);
    }

    /// <summary>
    /// Set the active window
    /// </summary>
    /// <param name="HWND">HWND to window to set to active / foreground.</param>
    public static void SetActiveWindow(IntPtr HWND)
    {
      SetForegroundWindow(HWND);
    }
  }
}
