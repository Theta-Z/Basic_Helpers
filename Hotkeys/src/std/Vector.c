#include <stdio.h>
#include <stdlib.h>
#include "Vector.h"

//: this could definitely use a good "touch up"
//: there is no current index checking for out of range.
//: garbage in, garbage out ; feel free to add that

//: possibly add v->ready_for_use
//: true on init; false on GC

/*
    <summary>
        Resize the vector with current capacity + new capacity.
    </summary>
*/
void vector_resize(Vector *v, int new_capacity);

/*
    <summary>
        Initialize the vector with a capacity of VECTOR_BASE_CAPACITY.
    </summary>
*/
void vector_init(Vector *v)
{
    v->capacity = VECTOR_BASE_CAPACITY;
    v->items = malloc(sizeof(void *) * v->capacity);
    v->length = 0;
}

/*
    <summary>
        Add the item to the vector.
    </summary>
*/
void vector_add(Vector *v, void *item)
{
    if (v->length == v->capacity)
    {
        // can be lowered if memory is an issue
        vector_resize(v, v->capacity + VECTOR_BASE_CAPACITY);
    }
    
    v->items[v->length] = item;
    v->length = v->length + 1;
}

/*
    <summay>
        ~Destroy this vector.
    </summay>
*/
void vector_garbage_collect(Vector *v)
{
    free(v->items);
}

/*
    <summary>
        Get the item at position [index] for this vector.
    </summary>
*/
void *vector_get(Vector *v, int index)
{
    return v->items[index];
}

/*
    <summary>
        Delete the item at position [index] for this vector.
    </summay>
*/
void vector_remove(Vector *v, int index)
{
    int i;
    void *itm = v->items[index];
    free(itm);
    
    v->items[index] = NULL;
    
    
    for (i = index; i < v->length - 1; i++)
    {
        v->items[i] = v->items[i + 1];
        v->items[i + 1] = NULL;
    }
    
    v->length--;
    //: could resize here for memory
}

/*
    <summary>
        Resize the vector with current capacity + new capacity.
    </summary>
*/
void vector_resize(Vector *v, int new_capacity)
{
    v->capacity = new_capacity;
    v->items = realloc(v->items, sizeof(void *) * v->capacity);
}