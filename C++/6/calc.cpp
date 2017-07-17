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
			one.read();
			two.read();
			outval = one.add(two);
			outval.print();
			break;

		case 'S':
		case 's':
			one.read();
			two.read();
			outval = one.sub(two);
			outval.print();
			break;

		case 'M':
		case 'm':
			one.read();
			two.read();
			outval = one.mult(two);
			outval.print();
			break;

		case 'D':
		case 'd':
			one.read();
			two.read();
			outval = one.div(two);
			outval.print();
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