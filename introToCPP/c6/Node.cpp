#include "Node.h"

Node::Node(string newName)
{
	mName = newName;
	mNext = nullptr;
}

Node::Node(string newName, Node* nextNode)
{
	mName = newName;
	mNext = nextNode;
}

Node* Node::GetNext()
{
	return mNext;
}

void Node::SetNext(Node* newNextNode)
{
	mNext = newNextNode;
}

string Node::GetName()
{
	return mName;
}

void Node::SetName(string newName)
{
	mName = newName;
}
