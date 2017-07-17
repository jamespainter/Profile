#include <iostream>
#include "fraction.h"
using namespace std;

int main()
{
	char	choice;
	fraction one;
	fraction two;
	fraction outval;
	
	
	

	do
	{
		cout << "A\tAdd\n";
		cout << "S\tSub\n";
		cout << "M\tMult\n";
		cout << "D\tDiv\n";
		cout << "E\tExit\n";

		cout << "\nChoice?: ";

		cin >> choice;
		cin.ignore();

		switch (choice)
		{
		case 'A':
		case 'a':
			cin >> one;
			cin >> two;
			outval = one+two;
			cout << outval;
			break;

		case 'S':
		case 's':
			cin >> one;
			cin >> two;
			outval = one - two;
			cout << outval;
			break;

		case 'M':
		case 'm':
			cin >> one;
			cin >> two;
			outval = one * two;
			cout << outval;
			break;

		case 'D':
		case 'd':
			cin >> one;
			cin >> two;
			outval = one / two;
			cout << outval;
			break;

		case 'e':
		case 'E':
			break;

		default:
			cerr << "Unrecognized choice: " <<
				choice << endl;
			break;
		}
	} while (choice != 'e' && choice != 'E');

	return 0;
}