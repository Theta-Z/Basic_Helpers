#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>
#include "Glasses.h"
#include "../Hotkey.h"
#include "../std/Vector.h"

/*
    <summary>
        Print messages for why the hotkey is invalid, then free the memory...
        Or, if the hotkey is valid, add it to the Vector.
    </summary>
*/
void add_or_free_hk(Vector *v, Hotkey *hk, int *hotkey_index)
{
    if (hk->scan < 0)
        printf("Error loading hotkey line %d\n\tInvalid ScanCode.\n", *hotkey_index);

    if (hk->behaviour == ERR)
        printf("Error loading hotkey line %d\n\tInvalid Behaviour.\n", *hotkey_index);
    
    if (hk->pm_click == -1 && hk->me_click == -1 && hk->vk == 0)
        printf("Error loading hotkey line %d\n\tInvalid Action.\n", *hotkey_index);
    
    if (hk->binding_key == 0)
        printf("Error loading hotkey line %d\n\tInvalid Binding Key.\n", *hotkey_index);
    
    if (hk->scan < 0 || hk->behaviour == ERR || (hk->pm_click == -1 && hk->me_click == -1 && hk->vk == 0) || hk->binding_key == 0)
        free(hk);
    else
        vector_add(v, hk);
    
    (*hotkey_index)++;
}

/*
    <summary>
        Get the behaviour based on the name passed in.
    </summary>
*/
Behaviour get_behaviour(char *name)
{    
    if(strcmp(name, "once") == 0)
        return ONCE;
    
    if(strcmp(name, "repeat") == 0)
        return REPEAT;
    
    return ERR;
}

/*
    <summary>
        Get the mouse code for use with PostMsg and mouse_event, based on the name of it.
    </summary>
*/
int get_click(char *name)
{
    if (strcmp(name,"right_click") == 0)
        return RIGHT_CLICK;
    
    if (strcmp(name,"left_click") == 0)
        return LEFT_CLICK;
    
    if (strcmp(name,"left_down") == 0)
        return LEFT_DOWN;
    
    if (strcmp(name,"right_down") == 0)
        return RIGHT_DOWN;
    
    if (strcmp(name,"left_up") == 0)
        return LEFT_UP;
    
    if (strcmp(name,"right_up") == 0)
        return RIGHT_UP;
    
    return -1;
}

/*
    <summary>
        Get the virtual keycode for the name passed in.
    </summary>
*/
int get_hotkey(char *name)
{
    if (strcmp(name,"backspace") == 0)
        return VK_BACK;
    
    if (strcmp(name,"space") == 0)
        return VK_SPACE;
    
    if (strcmp(name,"numpad1") == 0)
        return VK_NUMPAD1;
    
    if (strcmp(name,"numpad2") == 0)
        return VK_NUMPAD2;
    
    if (strcmp(name,"numpad3") == 0)
        return VK_NUMPAD3;
    
    if (strcmp(name,"numpad4") == 0)
        return VK_NUMPAD4;
    
    if (strcmp(name,"numpad5") == 0)
        return VK_NUMPAD5;
    
    if (strcmp(name,"numpad6") == 0)
        return VK_NUMPAD6;
    
    if (strcmp(name,"numpad7") == 0)
        return VK_NUMPAD7;
    
    if (strcmp(name,"numpad8") == 0)
        return VK_NUMPAD8;
    
    if (strcmp(name,"numpad9") == 0)
        return VK_NUMPAD9;
    
    if (strcmp(name,"numpad_minus") == 0)
        return VK_SUBTRACT;
    
    if (strcmp(name,"numpad_plus") == 0)
        return VK_ADD;
    
    if (strcmp(name,"numpad_period") == 0)
        return VK_DECIMAL;
    
    if (strcmp(name,"numpad_star") == 0)
        return VK_MULTIPLY;
    
    if (strcmp(name,"numpad_slash") == 0)
        return VK_DIVIDE;
    
    if (strcmp(name,"tab") == 0)
        return VK_TAB;
    
    if (strcmp(name,"left_arrow") == 0)
        return VK_LEFT;
    
    if (strcmp(name,"right_arrow") == 0)
        return VK_RIGHT;
    
    if (strcmp(name,"up_arrow") == 0)
        return VK_UP;
    
    if (strcmp(name,"down_arrow") == 0)
        return VK_DOWN;
    
    if (strcmp(name,"delete") == 0)
        return VK_DELETE;
    
    if (strcmp(name,"grave") == 0)
        return VK_OEM_3;
    
    if (strcmp(name,"F1") == 0)
        return VK_F1;
    
    if (strcmp(name,"F2") == 0)
        return VK_F2;
    
    if (strcmp(name,"F3") == 0)
        return VK_F3;
    
    if (strcmp(name,"F4") == 0)
        return VK_F4;
    
    if (strcmp(name,"F5") == 0)
        return VK_F5;
    
    if (strcmp(name,"F6") == 0)
        return VK_F6;
    
    if (strcmp(name,"F7") == 0)
        return VK_F7;
    
    if (strcmp(name,"F8") == 0)
        return VK_F8;
    
    if (strcmp(name,"F9") == 0)
        return VK_F9;
    
    if (strcmp(name,"F10") == 0)
        return VK_F10;
    
    if (strcmp(name,"F11") == 0)
        return VK_F11;
    
    if (strcmp(name,"F12") == 0)
        return VK_F12;
    
    if (strlen(name) == 1)
        switch (name[0])
        {
            case '0' : return 0x30;
            case '1' : return 0x31;
            case '2' : return 0x32;
            case '3' : return 0x33;
            case '4' : return 0x34;
            case '5' : return 0x35;
            case '6' : return 0x36;
            case '7' : return 0x37;
            case '8' : return 0x38;
            case '9' : return 0x39;
            case 'a' : return 0x41;
            case 'b' : return 0x42;
            case 'c' : return 0x43;
            case 'd' : return 0x44;
            case 'e' : return 0x45;
            case 'f' : return 0x46;
            case 'g' : return 0x47;
            case 'h' : return 0x48;
            case 'i' : return 0x49;
            case 'j' : return 0x4A;
            case 'k' : return 0x4B;
            case 'l' : return 0x4C;
            case 'm' : return 0x4D;
            case 'n' : return 0x4E;
            case 'o' : return 0x4F;
            case 'p' : return 0x50;
            case 'q' : return 0x51;
            case 'r' : return 0x52;
            case 's' : return 0x53;
            case 't' : return 0x54;
            case 'u' : return 0x55;
            case 'v' : return 0x56;
            case 'w' : return 0x57;
            case 'x' : return 0x58;
            case 'y' : return 0x59;
            case 'z' : return 0x5A;
        }
    
    return 0x0;
}

/*
    <summary>
        Get attributes that are shared amoung hotkeys.
    </sumamry>
*/
void get_shared_attributes(char *buffer, char *event, char *action, Hotkey *hk)
{
    char behaviour[15], bind[15];
    char *token;
    
    strtok(buffer, "=");
        
    //: Pull useful data out of the specific sets
    //: Primative, in future use specific names so scripts can be in any order
    //: e.g., binding key before behaviour etc.
    token = strtok(NULL, "=");
    read_until(token, event, ';');
    
    token = strtok(NULL, "=");
    read_until(token, action, ';');
    
    token = strtok(NULL, "=");
    read_until(token, behaviour, ';');
    
    token = strtok(NULL, "=");
    read_until(token, bind, ';');
    
    token = strtok(NULL, "=");
    read_until(token, buffer, ';');
    
    //: Shared attributes
    hk->behaviour = get_behaviour(behaviour);
    hk->binding_key = get_hotkey(bind);
    hk->scan = atoi(buffer);
}

/*
    <summary>
        Format: "event=%s; action=%s; behaviour=%s; bind=%s; scan=%d;"
    </summary>
*/
void read_hotkeys(Vector *v, char *filename)
{
    FILE *hotkeys;
    hotkeys = fopen(filename, "r");
    
    int hotkey_index = 1;
    
    char buffer[150]
        ,event[15]
        ,action[25];

    while(!feof(hotkeys))
    {
        fgets(buffer, 150, hotkeys);
        if(strcmp(buffer,"0") == 0) continue;
        
        Hotkey *hk;
        hk = (Hotkey *)malloc(sizeof(Hotkey *));
        
        get_shared_attributes(buffer, event, action, hk);
        
        if(strcmp(event, "keybd") == 0)
        {
            hk->vk = get_hotkey(action);
            hk->pm_click = 0;
            hk->me_click = 0;
        }
        
        if(strcmp(event, "mouse") == 0)
        {
            hk->vk = 0x0;
            hk->me_click = get_click(action);
            hk->pm_click = 0;
        }
        
        if(strcmp(event, "postmsg") == 0)
        {
            hk->vk = 0x0;
            hk->me_click = 0;
            hk->pm_click = get_click(action);
        }
        
        //: Finally, add hk to the Vector [if it's valid]
        add_or_free_hk(v, hk, &hotkey_index);
    }

    if (hotkeys)
    {
        fclose(hotkeys);
        hotkeys = NULL;
    }
}

/*
    <summary>
        result = src.substring(0, src.indexOf(stopper))
        ignores whitespace.
    </summary>
*/
void read_until(char *src, char *result, char stopper)
{
    int i;
    char c;
    
    for(i = 0; (c = src[i]) != stopper; i++)
        if(c != ' ')
            result[i] = c;
    
    result[i] = '\0';
}

/*
    <summary>
        Return whether or not vk has been pressed.
    </summary>
*/
int was_key_pressed(int vk)
{
    return (GetAsyncKeyState(vk) & 0x0001);
}