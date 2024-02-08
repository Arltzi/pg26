#pragma once
#include "Utility.h"

class Node
{
public:
	// CONSTRUCTORS
	Node() = delete;
	Node(string newName);
	Node(string newName, Node* nextNode);
	~Node();

	// gets & sets
	Node* GetNext();
	void SetNext(Node* newNextNode);

	string GetName();
	void SetName(string newName);

private:
	Node* mNext;
	string mName;
};

