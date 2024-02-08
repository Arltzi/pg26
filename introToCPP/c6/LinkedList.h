#pragma once
#include "Utility.h"

class Node;

class LinkedList
{
public:
	LinkedList();
	~LinkedList();

	void AddToTail(string newNode);
	void AddAfterNode(string priorNode, string newNode);
	void AddHead(string newNode);
	int GetSize();
	Node* GetNodeAtIndex(int index);

private:
	Node* mHead;
};

