/*
 * =====================================================================================
 *
 *       Filename:  sstf.c
 *       	Usage:  ./sstf.c
 *    Description: Shortest-seek-time-first 
 *
 * =====================================================================================
 */
#include <stdlib.h>
#include <stdio.h>
#include "disk.h"
#include <float.h>
#include <math.h>

/* Function Defenitions */
void Sstf(int position, int array[])
{

	//98 183 37 122 14 124 65 67
	printf("Starting SSTF Algorithm\n");
	printf("\tInitial Position %d\n", position);
	int movement = 0; 
	int i = 0; 
	int j = 0;
	int temp = 0;     
	for(i =0; i < sizeof(array); i++)
	{
		for(j = i+1; j < sizeof(array) ; j++)
		{
			if(abs(array[i]-position) > abs(array[j]-position))
			{
				temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
				
		} 
	}
//	int y = 0; 
//	for(y = 0; y< sizeof(array); y++)
//	printf("sorted array %d\n", array[y]);


	int k = 0;
        for(k = 0; k < sizeof(array); k++)
        {

                        if(k == 0)
                        {
                        movement = array[k]-position;
                        position = movement;
                //      printf("position 0: %d\n", position); 
                        }
                        if(k > 0)
                        {
                        if(array[k] > array[k-1])
                        {
                                movement = array[k] - array[k-1]+position;
                //              printf("%d", movement); 
                                position = movement;
                        }
                        else
                        {
                                movement = array[k-1] - array[k] + position;
                //              printf("%d", movement); 
                                position = movement;
                        }
                        }

                printf("\tServicing: %d Movement: %d\n",array[k],movement);
        }
                printf("SSTF = %d movements\n", position);



	return;
}



