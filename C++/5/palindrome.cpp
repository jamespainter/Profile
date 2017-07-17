#include <iostream>
#include <string>	// for the string class / fucntions
#include <cstring> 
#include <string>// for - string functions
using namespace std;
// int main() // for versions 1 and 2
int main(unsigned argc, char* argv[])
{

	// c- string and command line version 
	

	char palindrome[1000] = ""; // empty string
	
	for (unsigned i = 1; i < argc; i++){
		strcat_s(palindrome, argv[i]);
		cout << argv[i] ;
	}
	char	pal[1000];

	strcpy_s(pal, palindrome);
	reverse(pal, palindrome);					// version 2

	if (strcmp(palindrome, pal) == 0)	// they are equal
	{
		cout << " It is a palindrome " <<  endl;
		
	}
	else
		cout << " It is not a palindrome " << endl;

}

void reverse(char* s)						// version 2
{
	for (unsigned i = 0; i < strlen(s) / 2; i++)
	{
		char	temp = s[i];
		s[i] = s[strlen(s) - 1 - i];
		s[strlen(s) - 1 - i] = temp;
	}
}