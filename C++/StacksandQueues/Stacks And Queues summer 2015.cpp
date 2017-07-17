//Copyright 2015, Bradley Peterson, Weber State University, All rights reserved.

#include <iostream>
#include <string>
#include <sstream>
//To prevent those using g++ from trying to use a library
//they don't have
#ifndef __GNUC__
#include <conio.h>
#endif

using namespace std;

#include <stdio.h>
typedef enum {
	false, true
} bool;

typedef char valueT;

typedef struct _nodeT {
	valueT value;
	struct _nodeT *next;
} nodeT;

typedef struct {
	nodeT *head;
} stackT;
:w
stackT *NewStack(void);
void Push(stackT *stack, valueT value);
valueT Pop(stackT *stack);
void EmptyStack(stackT *stack);
void FreeStack(stackT *stack);
bool IsEmpty(stackT *stack);




stackT *NewStack(void)
{
	stackT *nT;
	nT->head = NULL;
	return nT;

}
void Push(stackT *stack, valueT value)
{
	nodeT * temp = malloc(sizeof(nodeT));
	temp->next = stack->head;
	temp->value = value;
	stack->head = temp;

	
}

valueT Pop(stackT *stack)
{

	if (IsEmpty(stack) == true)
	{
		printf("Error\n");
		return 0;

	}
	nodeT * temp;
	temp->next = stack->head;
//	FreeStack(stack);
	return temp->value;


}

void EmptyStack(stackT *stack)
{
	//      if(stack)
	//      {
	//              FreeStack(stack->head->next);
	//              free(stack);
	//      }
}


//**********************************
//Write your code below here
//**********************************
template <typename T> 
class CustomStack
{
private:
	unsigned int currentSize;
	unsigned int capacity; 
	T* arr; 

public:
	CustomStack(const unsigned int currentSize);
	~CustomStack(); 
	void push(const T& value);
	T pop();
	unsigned int size(); 
};

template <typename T> 
CustomStack<T>::CustomStack(unsigned int capacity)
{ 
	arr = new T[capacity]; 
	this->capacity = capacity; 
}

template <typename T> 
CustomStack<T>::~CustomStack()
{
	delete[] arr; 
	arr = NULL; 
}


template <typename T>
void CustomStack <T> ::push(const T& value)
{
	if (currentSize == capacity) {
		throw 1;
	}
	
	arr[currentSize] = value;
	currentSize++;

}

template <typename T>
T CustomStack <T>:: pop()
{
	if (currentSize == 0)
	{
		throw 1;
	}
	currentSize--;
	return arr[currentSize]; 
	
}

template <typename T>
unsigned int CustomStack <T>::size(){
	return currentSize; 
}

template <typename T> 
class CustomQueue {
	private: 
		unsigned int front; 
		unsigned int back; 
		unsigned int currentSize;
		unsigned int capacity;
		T* arr;

	public:
		CustomQueue(const unsigned int capacity);
		~CustomQueue(); 
		void push_back(const T& value);
		T pop_front();
		unsigned int size();

};

template <typename T> 
CustomQueue<T> ::CustomQueue(const unsigned int capacity)
{
	arr = new T[capacity];
	this->capacity = capacity;
}

template <typename T> 
CustomQueue<T>::~CustomQueue(){
	delete[] arr; 
	arr = NULL; 
}

template <typename T> 
void CustomQueue<T>::push_back(const T& value){
	if (back >= capacity) {
		back = 0; 
		
	}
	if (currentSize == 0){
		front = 0; 
		back = 0; 
	}
	if (currentSize == capacity)
	{
		throw 1; 
	}
	
	arr[back] = value;
	back++; 
	currentSize++;
}

template <typename T> 
T CustomQueue<T>::pop_front(){
	if (currentSize == 0)
	{
		throw 1;
	}
	if (front >= capacity){
		front = 0; 
	}
	currentSize--;
	front++;
	return arr[front-1];
	 
}
template <typename T>
unsigned int CustomQueue <T>::size(){
	return currentSize;
}
//**********************************
//Write your code above here
//**********************************

//This helps with testing, do not modify.
bool checkTest(string testName, int whatItShouldBe, int whatItIs) {

	if (whatItShouldBe == whatItIs) {
		cout << "Passed " << testName << endl;
		return true;
	}
	else {
		cout << "***Failed test " << testName << " *** " << endl << "   Output was " << whatItIs << endl << "   Output should have been " << whatItShouldBe << endl;
		return false;
	}
}


//This helps with testing, do not modify.
bool checkTest(string testName, string whatItShouldBe, string whatItIs) {

	if (whatItShouldBe == whatItIs) {
		cout << "Passed " << testName << endl;
		return true;
	}
	else {
		if (whatItShouldBe == "") {
			cout << "***Failed test " << testName << " *** " << endl << "   Output was " << whatItIs << endl << "   Output should have been blank. " << endl;
		}
		else {
			cout << "***Failed test " << testName << " *** " << endl << "   Output was " << whatItIs << endl << "   Output should have been " << whatItShouldBe << endl;
		}
		return false;
	}
}

//This helps with testing, do not modify.
bool checkTestMemory(string testName, int whatItShouldBe, int whatItIs) {

	if (whatItShouldBe == whatItIs) {
		cout << "Passed " << testName << endl;
		return true;
	}
	else {
		cout << "***Failed test " << testName << " *** " << endl << ".  ";
		cout << "You are manually managing " << whatItIs << " bytes in memory, but it should be " << whatItShouldBe << " bytes." << endl;
		return false;
	}
}



//This helps with testing, do not modify.
void testCustomStack() {

	string result;
	string caughtError;
	CustomStack<int> *stack = new CustomStack<int>(5);

	stack->push(1);
	int data = stack->pop();
	checkTest("testCustomStack #1", 1, data);

	stack->push(1);
	stack->push(2);
	stack->push(3);
	stack->push(4);
	stack->push(5);
	checkTest("testCustomStack #2", 5, stack->pop());
	checkTest("testCustomStack #3", 4, stack->pop());
	checkTest("testCustomStack #4", 3, stack->pop());
	checkTest("testCustomStack #5", 2, stack->pop());
	checkTest("testCustomStack #6", 1, stack->pop());

	//now cover error handling
	try {
		result = stack->pop();
	}
	catch (int e) {
		caughtError = "caught";
	}
	checkTest("testCustomStack #7", "caught", caughtError);

	//check currentSize
	checkTest("testCustomStack #8", 0, stack->size());
	stack->push(12);
	stack->push(32);
	checkTest("testCustomStack #9", 2, stack->size());

	//now test filling it up
	stack->push(14);
	stack->push(53);
	stack->push(47);
	checkTest("testCustomStack #10", 5, stack->size());

	//now cover error handling
	caughtError = "";
	try {
		stack->push(8);
	}
	catch (int e) {
		caughtError = "caught";
	}
	checkTest("testCustomStack #11", "caught", caughtError);

	delete stack;

	//test some strings
	CustomStack<string> *sstack = new CustomStack<string>(10);

	sstack->push("apple");
	sstack->push("banana");
	sstack->push("cherry");

	checkTest("testCustomStack #12", 3, sstack->size());

	//remove banana from the stack.
	string temp = sstack->pop();
	sstack->pop();
	sstack->push(temp);

	//see if it worked 
	checkTest("testCustomStack #13", "cherry", sstack->pop());
	checkTest("testCustomStack #14", "apple", sstack->pop());

	delete sstack;

}



//This helps with testing, do not modify.
void testCustomQueue() {
	
	string result;
	string caughtError;
	CustomQueue<string> *pQueue = new CustomQueue<string>(5);

	//Tests push_back
	pQueue->push_back("penny");
	pQueue->push_back("nickel");
	pQueue->push_back("dime");
	pQueue->push_back("quarter");

	checkTest("testCustomQueue #1", 4, pQueue->size());

	checkTest("testCustomQueue #2", "penny", pQueue->pop_front());
	checkTest("testCustomQueue #3", 3, pQueue->size());

	checkTest("testCustomQueue #4", "nickel", pQueue->pop_front());
	checkTest("testCustomQueue #5", "dime", pQueue->pop_front());
	checkTest("testCustomQueue #6", "quarter", pQueue->pop_front());
	checkTest("testCustomQueue #7", 0, pQueue->size());

	caughtError = "not caught";
	try {
	result = pQueue->pop_front();
	} catch (int e) {
	caughtError = "caught";
	}
	checkTest("testCustomQueue #8", "caught", caughtError);
	checkTest("testCustomQueue #9", 0, pQueue->size());

	//Try it again.  This should make it wrap around, and fill up.
	pQueue->push_back("penny");
	pQueue->push_back("nickel");
	pQueue->push_back("dime");
	pQueue->push_back("quarter");

	checkTest("testCustomQueue #10", "penny", pQueue->pop_front());
	pQueue->push_back("half dollar");
	pQueue->push_back("silver dollar");

	//It should be full, no more room to add more.
	caughtError = "not caught";
	try {
	pQueue->push_back("million dollar bill");
	} catch (int e) {
	caughtError = "caught";
	}
	checkTest("testCustomQueue #11", "caught", caughtError);

	checkTest("testCustomQueue #12", "nickel", pQueue->pop_front());
	checkTest("testCustomQueue #13", "dime", pQueue->pop_front());
	checkTest("testCustomQueue #14", "quarter", pQueue->pop_front());
	checkTest("testCustomQueue #15", "half dollar", pQueue->pop_front());
	checkTest("testCustomQueue #16", "silver dollar", pQueue->pop_front());
	caughtError = "not caught";
	try {
	result = pQueue->pop_front();
	} catch (int e) {
	caughtError = "caught";
	}
	checkTest("testCustomQueue #17", "caught", caughtError);

	//Test adding and removing back and forth
	pQueue->push_back("penny");
	checkTest("testCustomQueue #18", "penny", pQueue->pop_front());
	pQueue->push_back("nickel");
	checkTest("testCustomQueue #19", "nickel", pQueue->pop_front());
	pQueue->push_back("dime");
	checkTest("testCustomQueue #20", "dime", pQueue->pop_front());
	pQueue->push_back("quarter");
	checkTest("testCustomQueue #21", "quarter", pQueue->pop_front());
	pQueue->push_back("half dollar");
	checkTest("testCustomQueue #22", "half dollar", pQueue->pop_front());
	pQueue->push_back("silver dollar");
	checkTest("testCustomQueue #23", 1, pQueue->size());

	checkTest("testCustomQueue #24", "silver dollar", pQueue->pop_front());
	caughtError = "not caught";
	try {
	result = pQueue->pop_front();
	} catch (int e) {
	caughtError = "caught";
	}
	checkTest("testCustomQueue #25", "caught", caughtError);

	delete pQueue;
	
}

void pressAnyKeyToContinue() {
	cout << "Press any key to continue...";

	//Linux and Mac users with g++ don't need this
	//But everyone else will see this message.
#ifndef __GNUC__
	_getch();

#else
	int c;
	fflush(stdout);
	do c = getchar(); while ((c != '\n') && (c != EOF));
#endif
	cout << endl;
}


int main() {


	testCustomStack();
	pressAnyKeyToContinue();
	testCustomQueue();
	pressAnyKeyToContinue();

	return 0;
}