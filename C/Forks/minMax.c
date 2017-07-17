#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>

 int main(int argc, char * argv[])
 {
   int arg = atoi(argv[1]); 
//   const char * filename="test.txt";
   const char * filename = argv[2];
   FILE * ft= fopen(filename, "rb") ;
   if (ft) {
     int pid = getpid();
     fseek (ft,0,SEEK_END); //go to end of file
     long size = ftell(ft); //what byte in file am I at?
     fseek (ft,0,SEEK_SET); //go to beginning of file
     int num = (int)size / (int)sizeof(int);
     int offset = num/ (int)sizeof(int); 
     int offset2 = offset + offset;
     int offset3 = offset2 + offset; 
//     printf("size of the file: %li ,sizeof(int) = %i\n, the number of numbers = %i\n\n", size, (int) sizeof(int), num);
     int min =10000000;  
     int max = 0; 
     int i;
	if(arg == 0)
	{
		for(i = 0; i < num; i++){
			int temp = 0;
			fread(&temp,sizeof(int),1,ft); 
			if(temp > max)
			{
				max = temp; 
			}
			if(temp < min)
			{
				min = temp; 
		
			}	

			//        printf("%i: %i\t",pid,temp);
//			printf("%i ", temp);
        		usleep(200);
     		}
		printf("\n\nMin = %i\nMax = %i \n", min, max);
	}
	if(arg == 1)
	{
		for(i = 0; i < offset; i++){
                        int temp = 0;
			fread(&temp,sizeof(int),1,ft);
                        if(temp > max)
                        {
                                max = temp;
                        }
                        if(temp < min)
                        {
                                min = temp;

                        }

                        //        printf("%i: %i\t",pid,temp);
 //                       printf("%i ", temp);
                        usleep(200);
                }
	
		printf("\n\nMin = %i\nMax = %i \n", min, max);
   	}
	if(arg == 2)
        {	fseek (ft, num, SEEK_SET);
                for(i = offset; i < offset2; i++){
                        int temp = 0;
                        fread(&temp,sizeof(int),1,ft);
                        if(temp > max)
                        {
                                max = temp;
                        }
                        if(temp < min)
                        {
                                min = temp;

                        }

                        //        printf("%i: %i\t",pid,temp);
//                        printf("%i ", temp);
                        usleep(200);
                }

                printf("\n\nMin = %i\nMax = %i \n", min, max);
        }
	if(arg == 3)
        {	fseek (ft, num + num, SEEK_SET);
                for(i = offset2; i < offset3; i++){
                        int temp = 0;
                        fread(&temp,sizeof(int),1,ft);
                        if(temp > max)
                        {
                                max = temp;
                        }
                        if(temp < min)
                        {
                                min = temp;

                        }

                        //        printf("%i: %i\t",pid,temp);
 //                       printf("%i ", temp);
                        usleep(200);
                }

                printf("\n\nMin = %i\nMax = %i\n", min, max);
        }
	if(arg == 4)
        {	fseek (ft, num + num + num, SEEK_SET);
                for(i = offset3; i < num; i++){
                        int temp = 0;
                        fread(&temp,sizeof(int),1,ft);
                        if(temp > max)
                        {
                                max = temp;
                        }
                        if(temp < min)
                        {
                                min = temp;

                        }

                        //        printf("%i: %i\t",pid,temp);
//                        printf("%i ", temp);
                        usleep(200);
                }

                printf("\n\nMin = %i\nMax = %i\n", min, max);
        }


	fclose( ft ) ;
   }
   printf("\n");
   return 1;
 }
