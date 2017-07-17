/*
 * =====================================================================================
 *
 *       Filename:  cscan.c iiii
 *       	Usage:  ./cscan.c
 *    Description:  is a variant of SCAN designed to provide a more
 *    				uniform wait time. Like SCAN, C-SCAN moves the head from
 *    				one end of the disk to the other, servicing requests 
 *    				along the way. When the head reaches the other end, 
 *    				however, it immediately returns to the beginning of
 *    				the disk without servicing any request on the return
 *    				trip. 
 * =====================================================================================
 */
#include <stdlib.h>
#include <stdio.h>
#include "disk.h"
/* Function Defenitions */
void Cscan(int position, int array[])
{
	printf("Starting CSCAN Algorithm\n");
	printf("\tInitial Position %d\n", position);
	            //98 183 37 122 14 124 65 67
        int movement = 0;
        int i = 0;
        int j = 0;
        int temp = 0;
        for(i =0; i < sizeof(array); i++)
        {
                for(j = i+1; j < sizeof(array) ; j++)
                {
                        if(position > array[i] && position < array[j])
                        {
                        	
			        temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                        }
                 
                }
        }
	int a = 0; 
	int b = 0; 
	int tmp = 0; 
	for(a=0; a < sizeof(array); a++)
	{
	  for(b = a+1; b < sizeof(array); b++)
	  {
		if(array[a] < position)
		{
			tmp = array[a];
			array[a] = array[b];
			array[b] = tmp; 
		}	

          }
		

	}
    
       /*
      int y = 0; 
      for(y = 0; y< sizeof(array); y++)
      printf("sorted array %d\n", array[y]);
	*/
	int z = 0; 
	int k = 0;
	int endValue  = 199;
	int offset = 200; 
        //int position2 = position;
        //int compare = position;
        for(k = 0; k < sizeof(array); k++)
        {
//		printf("position = %d\n", position); 
                if(position < array[k])
                {
                        if(k == 0)
                        {
                                movement =abs(position -  array[k]);
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
                                movement = (endValue - array[k-1])+offset+array[k]+movement;
                                position = movement;
                                z++;
                        }
                        else
                        {
                                movement = abs(array[k] - array[k-1])+position;
                                position = movement;
                        }

                }

                printf("\tServicing: %d Movement: %d\n",array[k],movement);
                
               
               
          }
          printf("CSCAN = %d movements \n", position);

	return;
}


