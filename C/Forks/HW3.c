#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include "rctimer.h"


int main(int arc, char * argv[])
{
	printf("\nJames R. Painter, HW3\n");
	int cp[2];
	int cp1[2];
	int cp2[2];
	int cp3[2];
	int cp4[2];

	int arg = atoi(argv[1]);

	if (pipe(cp) < 0 || pipe(cp1) < 0 || pipe(cp2) < 0 || pipe(cp3) < 0 || pipe(cp4) < 0)
	{
		printf("didn't work, couldn't not establish pipe.\n");
		return -1;
	}
	if(arg == 1)
	{
		start_timer();
		int pid = fork();
		if (pid == 0)
		{
//			printf("this is the child. not the original\n");
			close(1); //close stdout
			dup(cp[1]); //move stdout to pipe of cp[1]
			close(0); //close stdin
			close(cp[0]); //close pipe in
			execl("MinMax","MinMax","0", argv[2],(char *) 0);
//		execl("minMax", argv[1], argv[2], (char*) 0); 
		}
		else
		{

			close(cp[1]); //if you don't close this part of the pipe then the while loop (three lines down) will never return
//			printf("this is the parent. the 'original.'\n");
			char ch;
			while( read(cp[0], &ch, 1) == 1)
			{
				printf("%c",ch);
				//write(1, &ch, 1);
				//outcount++;
			}
			end_timer();
			printf("Elapsed time: %s\n\n", get_elapsed_time());
//			printf("all done.\n");
//		execl("minMax", "minMax",argv[1], argv[2],(char *) 0);
		}
	}

	if(arg == 4)
        {
                int pid1 = fork();
                if (pid1 == 0)
                {
		        start_timer();
 //                     printf("this is the child. not the original\n");
                        close(1); //close stdout
                        dup(cp1[1]); //move stdout to pipe of cp[1]
                        close(0); //close stdin
                        close(cp1[0]); //close pipe in
                        execl("MinMax","MinMax","1", argv[2],(char *) 0);
//              execl("minMax", argv[1], argv[2], (char*) 0); 
                }
                else
                {

                        close(cp1[1]); //if you don't close this part of the pipe then the while loop (three lines down) will never return
//                      printf("this is the parent. the 'original.'\n");
                        char ch1;
                        while( read(cp1[0], &ch1, 1) == 1)
                        {
                                printf("%c",ch1);
                                //write(1, &ch, 1);
                                //outcount++;
                        }
			end_timer();
                        printf("Elapsed time: %s\n\n", get_elapsed_time());
//                        printf("all done.\n");
//                      execl("minMax", "minMax",argv[1], argv[2],(char *) 0);
                }
		int pid2 = fork();
                if (pid2 == 0)
                {
			start_timer();
//                        printf("this is the child. not the original\n");
                        close(1); //close stdout
                        dup(cp2[1]); //move stdout to pipe of cp[1]
                        close(0); //close stdin
                        close(cp2[0]); //close pipe in
                        execl("MinMax","MinMax","2", argv[2],(char *) 0);
//              execl("minMax", argv[1], argv[2], (char*) 0); 
                }
                else
                {

                        close(cp2[1]); //if you don't close this part of the pipe then the while loop (three lines down) will never return
//                        printf("this is the parent. the 'original.'\n");
                        char ch2;
                        while( read(cp2[0], &ch2, 1) == 1)
                        {
                                printf("%c",ch2);
                                //write(1, &ch, 1);
                                //outcount++;
                        }
			 end_timer();
                        printf("Elapsed time: %s\n\n", get_elapsed_time());
//                        printf("all done.\n");
//                      execl("minMax", "minMax",argv[1], argv[2],(char *) 0);
                }
		int pid3 = fork();
                if (pid3 == 0)
                {
			start_timer();
//                        printf("this is the child. not the original\n");
                        close(1); //close stdout
                        dup(cp3[1]); //move stdout to pipe of cp[1]
                        close(0); //close stdin
                        close(cp3[0]); //close pipe in
                        execl("MinMax","MinMax","3", argv[2],(char *) 0);
                }
                else
                {

                        close(cp3[1]); //if you don't close this part of the pipe then the while loop (three lines down) will never return
//                        printf("this is the parent. the 'original.'\n");
                        char ch3;
                        while( read(cp3[0], &ch3, 1) == 1)
                        {
                                printf("%c",ch3);
                                //write(1, &ch, 1);
                                //outcount++;
                        }
			 end_timer();
                        printf("Elapsed time: %s\n\n", get_elapsed_time());
//                        printf("all done.\n");
//                      execl("minMax", "minMax",argv[1], argv[2],(char *) 0);
                }
		int pid4 = fork();
                if (pid4 == 0)
                {
		        start_timer();
//                        printf("this is the child. not the original\n");
                        close(1); //close stdout
                        dup(cp4[1]); //move stdout to pipe of cp[1]
                        close(0); //close stdin
                        close(cp4[0]); //close pipe in
                        execl("MinMax","MinMax","4", argv[2],(char *) 0);
//              execl("minMax", argv[1], argv[2], (char*) 0); 
                }
                else
                {

                        close(cp4[1]); //if you don't close this part of the pipe then the while loop (three lines down) will never return
//                        printf("this is the parent. the 'original.'\n");
                        char ch4;
                        while( read(cp4[0], &ch4, 1) == 1)
                        {
                                printf("%c",ch4);
                                //write(1, &ch, 1);
                                //outcount++;
                        }
			 end_timer();
                        printf("Elapsed time: %s\n\n", get_elapsed_time());
//                        printf("all done.\n");
//                        execl("minMax", "minMax",argv[1], argv[2],(char *) 0);
                }


        }
	
//	printf("This is after the fork.\n");
	return 0;
}
