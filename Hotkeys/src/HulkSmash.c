#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>
#include "io/Glasses.h"
#include "Hotkey.h"
#include "io/Hulk.h"
#include "std/Vector.h"

//#define DEBUG

Vector hotkeys;

/*
    <summary>
        Take proper action based on information stored within the hotkey.
    </summary>
*/
void handle_key_from_behaviour(Hotkey *hk)
{    
    int key_down_prevent = 0;
    int stop_loop = 0;
    
    if (hk->behaviour == REPEAT)
    {
#ifdef DEBUG
        printf("--------------------------------\n");
        printf("Starting repeat behaviour: ");
        
            if (hk->vk > 0)
                printf("Keyboard\n");
            if (hk->me_click > 0)
                printf("Mouse\n");
            if (hk->pm_click > 0)
                printf("Message\n");
            
        printf("--------------------------------\n");
#endif
        
        while(stop_loop == 0)
        {
            if (hk->vk > 0)
                key_press(hk->vk, hk->scan);
            if (hk->me_click > 0)
                me_click(hk->me_click);
            if (hk->pm_click > 0)
                pm_click(hk->pm_click);
            
            stop_loop = key_down_prevent < 5 ? 0 : was_key_pressed(hk->binding_key) == 0;
            
            //: take a nap between presses.
            Sleep(next(21) + next(31) + next(14) + 60 + next(14) + next(15) + next(21) + next(14));
            
            //: Make sure that key wasn't pressed.
            if (stop_loop == 0)    
                stop_loop = key_down_prevent < 5 ? 0 : was_key_pressed(hk->binding_key) == 0;    
            
            //: Disallow the detection of the binding key within the first 5 tries.
            if(key_down_prevent < 5)key_down_prevent++;
        }
        
        int i;
        for(i = 0; i < next(3); i++)
        {
            if (hk->vk > 0)
                key_press(hk->vk, hk->scan);
            if (hk->me_click > 0)
                me_click(hk->me_click);
            if (hk->pm_click > 0)
                pm_click(hk->pm_click);
            
            Sleep(next(21) + next(31) + next(14) + 115 + next(14) + next(10));
        }
    }
    
    else if (hk->behaviour == ONCE)
    {
#ifdef DEBUG
        printf("---------------------\n");
        printf("One Time Triggered Behaviour\n");
        printf("---------------------\n");
#endif
        if (hk->vk > 0)
            key_press(hk->vk, hk->scan);
        if (hk->me_click > 0)
            me_click(hk->me_click);
        if (hk->pm_click > 0)
            pm_click(hk->pm_click);
    }
    
    else
    {
        printf("%d", hk->behaviour);
    }
}

int main(int argc, char **argv)
{
    if(argc != 2)
    {
        printf("Correct usage:\n\t hotkeyer.exe [hotkey filename]\n");
        scanf(" ");
        return 0;
    }
    
    srand((unsigned) time(NULL));
    printf("Loading Hotkeys...\n");
    vector_init(&hotkeys);
    Sleep(1000);
    
    read_hotkeys(&hotkeys, argv[1]);
    printf("Hotkeys Loaded...\n    Number of Hotkeys Loaded: %d\n\n", hotkeys.length);
    
    int i;
    Hotkey *hk;
    
    while (1) 
    {
        for(i = 0; i < hotkeys.length; i++)
        {
            hk = (Hotkey *)vector_get(&hotkeys, i);
            
            if(was_key_pressed(hk->binding_key))
            {
                handle_key_from_behaviour(hk);
            }
        }
        
        Sleep(next(12) + 15);
    }
    
    vector_garbage_collect(&hotkeys);
    return 0;
}