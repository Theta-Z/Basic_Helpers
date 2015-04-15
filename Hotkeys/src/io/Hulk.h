#ifndef HULK

#define HULK
#include <stdlib.h>

#define key_down(key,scan)    keybd_event(key, scan, KEYEVENTF_EXTENDEDKEY | 0, 0)
#define key_up(key,scan)    keybd_event(key, scan, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0)
#define next(a)                (rand() % a)

    void key_press(int, int);
    void me_click(int);
    void pm_click(int);
#endif