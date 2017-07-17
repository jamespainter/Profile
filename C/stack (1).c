#include "stack.h"
#include <stdio.h>


int counter = 0; 
int counter1 = 0; 

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
//	printf("%c\n", temp->value); 
	stack->head = temp; 
	counter++; 		
	counter1 = counter;  	
//	printf("%d\n", counter); 
}

valueT Pop(stackT *stack)
{ 
         
	if(counter == 0){ //stack->head->next == NULL
		counter1 =0; 
		stack->head = NULL;
		printf("Error!!!!!\n");
		return 0;  
	}
	else if(counter == counter1){
	//	 stack->head = stack->head->next;
		stack->head = stack->head; 
	        counter--; 
	}
	 else{
		stack->head = stack->head->next; 
		counter--;
	}
 
	return stack->head->value; 
		

}

void EmptyStack(stackT *stack)
{
	counter = 0; 
	stack-> = NULL; 

}

void FreeStack(stackT *stack)
{
	if(counter != 0)
	{
		
		printf("Error!\n"); 
		 
	
	}
	else{
               counter = 0;  
	       stack = malloc(sizeof(stackT));  
	//	stack->head = NULL; 
	}

}

bool IsEmpty(stackT *stack)
{
 	 if(stack->head  == NULL)
		return true; 
 	 else
		return false; 
}

