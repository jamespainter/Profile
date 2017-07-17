#include <iostream> 
#include <iomanip>
#include "sterling.h"
using namespace std; 

sterling make_sterling(int pounds, int shillings, int pence)
{
	sterling temp; 

	temp.pounds = pounds; 
	temp.shillings = shillings;
	temp.pence = pence; 

	return temp;
}

sterling make_sterling(int pence)
{
	sterling temp; 

	temp.pounds = pence / 240;
	pence = pence % 240;

	temp.shillings = pence / 12;
	temp.pence = pence % 12;

	return temp;
}

void print(sterling& a)
{
	 cout << (char)156 << a.pounds << "." << a.shillings << "." << a.pence << " " << endl;
}

sterling	add(sterling t1, sterling t2)
{
	int p1 = t1.pounds * 240 + t1.shillings * 12 + t1.pence;
	int p2 = t2.pounds * 240 + t2.shillings * 12 + t2.pence;

	return make_sterling(p1 + p2);
}

void read(sterling* b)
{
	cout << " Please enter Pounds: ";
	cin >> b->pounds;

	cout << "Please enter the Shillings: ";
	cin >> b->shillings;

	cout << " Please enter the Pence: "; 
	cin >> b->pence; 
	
	
}