#include "LinkedList.h"
#include "Node.h"

LinkedList::LinkedList()
{
}

LinkedList::~LinkedList()
{
}

void LinkedList::AddToTail(string newNodeName)
{
	if (mHead == nullptr) // if linkedlist is empty
	{
		mHead = new Node(newNodeName);
		return;
	}

	// iterate to the end of the linked list
	Node* iterator = mHead;
	while (iterator->GetNext() != nullptr)
	{
		iterator = iterator->GetNext();
	}

	// create new node, add to end of list
	iterator->SetNext(new Node(newNodeName));
}

void LinkedList::AddAfterNode(string priorNode, string newNode)
{
	Node* newInnerNode = new Node(newNode);

	Node* iterator = mHead;
	while (iterator->GetName() != priorNode)
	{
		iterator = iterator->GetNext();
	}

	newInnerNode->SetNext(iterator->GetNext());
	iterator->SetNext(newInnerNode);
}

void LinkedList::AddHead(string newNode)
{
	Node* newHead = new Node(newNode);
	newHead->SetNext(mHead);
	mHead = newHead;
}

int LinkedList::GetSize()
{
	if (mHead == nullptr)
	{
		return 0;
	}

	Node* iterator = mHead;
	int size = 1;
	while (iterator->GetNext() != nullptr)
	{
		++size;
		iterator = iterator->GetNext();
	}

	return size;
}

Node* LinkedList::GetNodeAtIndex(int index)
{
	if (0 <= index && index <= GetSize())
	{
		Node* iterator = mHead;
		for (size_t i = 0; i < index; i++)
		{
			iterator = iterator->GetNext();
		}
		PRINT_LINE("index in range");
		return iterator;
	}
	else
	{
		PRINT_LINE("Index not in range");
		return nullptr;
	}
}
