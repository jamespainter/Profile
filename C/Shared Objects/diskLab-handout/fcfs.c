/*
 * =====================================================================================
 *
 *       Filename:  fcfs.c
 *       	Usage:  ./fcfs.c
 *    Description:  First Come, First Serve
 *
 * =====================================================================================
 */
#include <stdlib.h>
#include <stdio.h>
#include "disk.h"
/* Function Defenitions */
void Fcfs(int position, int array[])
{

	int movement = 0;
	printf("Starting FCFS algorithm\n");
	printf("\tInitial position %d\n", position);
	int i = 0; 
	for(i = 0; i < sizeof(array); i++)
	{
			
			if(i == 0)
			{
        		movement = array[i]-position; 
			position = movement; 
		//	printf("position 0: %d\n", position); 
			}
			if(i > 0)
			{
			if(array[i] > array[i-1])
			{
		            	movement = array[i] - array[i-1]+position;  
		//		printf("%d", movement); 
				position = movement;
			}
			else
			{
				movement = array[i-1] - array[i] + position;
		//		printf("%d", movement); 
				position = movement; 
			}
			}
		
		printf("\tServicing: %d Movement: %d\n",array[i],movement);  
	}
		printf("FCFS = %d movements\n", position); 
	return;
}
