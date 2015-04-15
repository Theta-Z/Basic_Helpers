#ifndef HOTKEY

#define HOTKEY
#define RIGHT_CLICK   1
#define LEFT_CLICK    2
#define LEFT_DOWN     3
#define LEFT_UP       4
#define RIGHT_DOWN    5
#define RIGHT_UP      6
    
    typedef enum Behaviour
    {
        ONCE,
        REPEAT,
        ERR
    }Behaviour;
    
    typedef enum TokenType_Hotkey
    {
        ACTION,
        BEHAVIOUR,
        BIND,
        EVENT,
        SCAN,
        SPEED
    }TokenType_Hotkey;
    
    typedef struct Hotkey
    {
        int vk;
        int scan;
        
        int pm_click;
        int me_click;
        int binding_key;
        
        Behaviour behaviour;
    }Hotkey;
    
#endif

