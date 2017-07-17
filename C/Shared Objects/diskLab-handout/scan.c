/*
 * =====================================================================================
 *
 *       Filename:  scan.c 
 *       	Usage:  ./scan.c
 *    Description: Disk arm starts at one end of the disk and moves
 *    				toward the other end, servicing request as it
 *    				reaches each cylinder, until it gets to the 
 *    				other end of the disk
 * =====================================================================================
 */
#include <stdlib.h>
#include <stdio.h>
#include "disk.h"

/* Function Defenitions */
void Scan(int position, int array[])
{
	printf("Starting SCAN Algorithm\n");
	printf("\tInitial Position %d\n", position);
	
	    //98 183 37 122 14 124 65 67
        int movement = 0;
	int movement2 = 0; 
        int i = 0;
        int j = 0;
        int temp = 0;
        for(i =0; i < sizeof(array); i++)
        {
                for(j = i+1; j < sizeof(array) ; j++)
                {
                        if(position < array[i]&& position > array[j])
                        {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                        }
                 
                }
        }
//      int y = 0; 
//      for(y = 0; y< sizeof(array); y++)
//      printf("sorted array %d\n", array[y]);
	int z =0; 
	 int k = 0;
	int position2 = position; 
	int compare = position; 
        for(k = 0; k < sizeof(array); k++)
        {

		if(position > array[k])
		{
			if(k == 0)
			{
				movement = abs(array[k]-position); 
				position = movement; 

			}
			else 
			{
				movement = abs(array[k]- array[k-1])+position; 
				position = movement; 
			}
		}
		else
		{
			if(z== 0)
			{
				movement2 = abs(array[k]+position2);
				position2 = movement2; 
				z++;
			}
			else
			{
				movement2 = abs(array[k] - array[k-1])+position2; 
				position2 = movement2; 
			}	

		}

		if(compare >  array[k])
		{
                printf("\tServicing: %d Movement: %d LEFT\n",array[k],movement);
		}
		else
		{
		 printf("\tServicing: %d Movement: %d RIGHT\n",array[k],movement2);
		}
        }
                printf("SCAN = %d movements\n", position2);



	return;
}


