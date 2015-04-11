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
    private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const uint MOUSEEVENTF_LEFTUP = 0x0004;
    private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
    private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();
    
    [DllImport("user32.dll")]
    private static extern bool keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    public enum MouseClickStatus
    {
      MOUSE_DOWN = 1,
      MOUSE_UP = 2
    }

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
      var r = new Random();

      Thread.Sleep(10 + r.Next(8));
      keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
      Thread.Sleep(125 + r.Next(35));
      keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
      Thread.Sleep(10 + r.Next(8));
    }

    public static void Mouse_LeftClick(int numClicks)
    {
      var r = new Random();

      for (var i = 0; i < numClicks; i++)
      {
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(98 + r.Next(34));
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
      }
    }

    public static void Mouse_RightClick(int numClicks)
    {
      var r = new Random();

    }

    public static void Mouse_RightHold(MouseClickStatus status)
    {
      if (status == MouseClickStatus.MOUSE_DOWN)
      {
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
      }
      else
      {
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
      }
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
