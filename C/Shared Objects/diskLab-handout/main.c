/*
 * =====================================================================================
 *
 *       Filename:  main.c 
 *       	Usage:  ./main.c
 *    Description:  Main program to run disk scheduler
 *
 *        Version:  1.0
 *        Created:  11/09/2015 02:29:41 PM
 *       Compiler:  gcc
 *         Author:  Dr. Hugo Valle (), hugovalle1@weber.edu
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>		/* For Standard I/O */
#include <stdlib.h>		/* For exit */
#include <unistd.h>		/* For UNIX function prototypes */
#include <string.h>		/* For strings prototypes */
#include <getopt.h>
#include <time.h>
#include "disk.h"

/* Function Prototypes */
void Usage(char **args);

/* Main Program */
int main(int argc, char* argv[])
{
	//Get the options
	int cylinders[CYL] = {98, 183, 37, 122, 14, 124, 65, 67}; // fixed positions
	// Get options (input parameters)
	
	// If option is for random generated array
	// Do it here. Remember to keep your random number
	// between 0-199
	
	
	// Display cylender
	for(int i = 0; i < CYL; i++)
	{
		printf("%d ", cylinders[i]);
	}
	printf("\n\n");
	

	int pos = atoi(argv[4]); 
	// Write a Makefile to compile all the files
	// as well as to compile the shared library
	//Method Calls
  	Fcfs(pos, cylinders);
  	Sstf(pos, cylinders);
  	Scan(pos, cylinders);
  	Cscan(pos, cylinders);

	return 0;
}


/* Function Defenitions */
void Usage(char **args)
{
	printf("Usage: %s -s <setType:'R'andom or 'F'ixed> -p <InitialNeedlePosition>\n", args[0]);
	return;
}
