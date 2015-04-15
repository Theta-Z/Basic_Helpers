#ifndef _VECTOR_

#define _VECTOR_
#define VECTOR_BASE_CAPACITY    8
    
    typedef struct Vector
    {
        void **items;
        int capacity;
        int length;
    }Vector;

    void vector_init(Vector *);
    void vector_add(Vector *,void *);
    void vector_garbage_collect(Vector *);
    void *vector_get(Vector *, int);
    void vector_remove(Vector *, int);
#endif