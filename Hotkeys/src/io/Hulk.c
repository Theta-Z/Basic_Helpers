#include <stdlib.h>
#include <windows.h>
#include "../Hotkey.h"
#include "Hulk.h"

HWND pm_click_HWND;

/*
    <summary>
        Press and release the key, maybe add more functionality later for keydown & keyup.
    </summary>
*/
void key_press(int vk, int scan)
{
    key_down(vk, scan);
    Sleep(101 + next(10) + next(9) + next(12) + next(15) + next(11) + next(11));
    key_up(vk, scan);
}

/*
    <summary>
        Use mouse event to send clicks.
    </summary>
*/
void me_click(int click_type)
{
    POINT cur;
    GetCursorPos(&cur);
    
    switch(click_type)
    {
        case LEFT_CLICK:
            mouse_event(MOUSEEVENTF_LEFTDOWN, cur.x, cur.y, 0, 0);
            Sleep(83 + next(21) + next(25) + next(19) + next(8) + next(11) + next(9) + next(11));
            mouse_event(MOUSEEVENTF_LEFTUP, cur.x, cur.y, 0, 0);
            break;
        case LEFT_DOWN:
            mouse_event(MOUSEEVENTF_LEFTDOWN, cur.x, cur.y, 0, 0);
            break;
        case LEFT_UP:
            mouse_event(MOUSEEVENTF_LEFTUP, cur.x, cur.y, 0, 0);
            break;
        
        case RIGHT_CLICK:
            mouse_event(MOUSEEVENTF_RIGHTDOWN, cur.x, cur.y, 0, 0);
            Sleep(72 + next(20) + next(19) + next(21) + next(8) + next(12) + next(9) + next(11));
            mouse_event(MOUSEEVENTF_RIGHTUP, cur.x, cur.y, 0, 0);
            break;
        case RIGHT_DOWN:
            mouse_event(MOUSEEVENTF_RIGHTDOWN, cur.x, cur.y, 0, 0);
            break;
        case RIGHT_UP:
            mouse_event(MOUSEEVENTF_RIGHTUP, cur.x, cur.y, 0, 0);
            break;
        default: ;
    }
}

/*
    <summary>
        I was not expecting to have to post messages directly to the window...
        Still a bit suprised the directX frame isn't registered under a private HWND to 
        stop cheating.. hue^max
    </summary>
*/
void pm_click(int click_type)
{
    pm_click_HWND = GetForegroundWindow();
    SetCapture(pm_click_HWND);
    
    switch(click_type)
    {
        case LEFT_CLICK:
            PostMessage(pm_click_HWND, WM_LBUTTONDOWN, 0, 0);
            Sleep(next(11) + next(16) + next(8) + next(17) + 91 + next(12) + next(11));
            PostMessage(pm_click_HWND, WM_LBUTTONUP, 0, 0);
            break;
        case LEFT_DOWN:
            PostMessage(pm_click_HWND, WM_LBUTTONDOWN, 0, 0);
            break;
        case LEFT_UP:
            PostMessage(pm_click_HWND, WM_LBUTTONUP, 0, 0);
            break;
        
        case RIGHT_CLICK:
            PostMessage(pm_click_HWND, WM_RBUTTONDOWN, 0, 0);
            Sleep(next(15) + next(18) + next(3) + next(15) + 69 + next(14) + next(19));
            PostMessage(pm_click_HWND, WM_RBUTTONUP, 0, 0);
            break;
        case RIGHT_DOWN:
            PostMessage(pm_click_HWND, WM_RBUTTONDOWN, 0, 0);
            break;
        case RIGHT_UP:
            PostMessage(pm_click_HWND, WM_RBUTTONUP, 0, 0);
            break;
        default: ;
    }
    
    ReleaseCapture();
}