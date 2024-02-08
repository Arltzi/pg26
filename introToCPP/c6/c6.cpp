#include <iostream>
#include "Utility.h"
#include "LinkedList.h"

int main()
{
    LinkedList pg26;

    // pg26.AddToTail("Henry");
    pg26.AddToTail("Alisa");
    pg26.AddToTail("Spencer");
    pg26.AddToTail("Xav");
    //pg26.AddToTail("Levi");
    pg26.AddToTail("Alex");
    pg26.AddToTail("Preetham");
    pg26.AddToTail("Max");
    pg26.AddToTail("Tee");
    pg26.AddToTail("Robert");
    pg26.AddToTail("Lev");

    pg26.AddHead("Henry");
    pg26.AddAfterNode("Xav", "Levi");

    PRINT_LINE(pg26.GetSize());

    int index;
    READ_USER_INPUT(index);
    pg26.GetNodeAtIndex(index);
}