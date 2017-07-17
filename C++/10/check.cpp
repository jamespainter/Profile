#include <iostream> 
#include <fstream> 
#include <string> 
#include <iomanip>
using namespace std; 



int main()
{
	for (int i = 0; i < 70; i++)
	{
		cout << "_";
	}
	cout << endl; 
	string file; 
	cout << "What is the name of your file " << endl;
		cin >> file; 
		cout.setf(ios::fixed);
		cout.precision(2); 
	ifstream in(file); 

	if (!in.good())
	{
		cerr << "Unable to open checkbook.txt" << endl; 
	}
	string position1;
	string position2;
	string position3;
	string position4; 
	double balance =0;
	
	while (!in.eof())
	{
		
		getline(in, position1, ':');
		getline(in, position2, ':');
		getline(in, position3, ':');
		getline(in, position4);

		if (position1 == "deposit")
		{
			double amount = stod(position4);
			balance = balance + stod(position4);
			cout << left << setw(20) << position1 << left << setw(20) << position2 << left << setw(15) << position3 << setw(5) << "$" << right << setw(8) << amount << endl;
		}
		else
		{
			double amount = stod(position4); 
			balance = balance - stod(position4); 
			cout << left << setw(20) << position1 << left << setw(20) << position2 << left << setw(15) << position3 << setw(5) << "$" << right <<  setw(8) << amount << endl;
		}
		
		

	}
	for (int i = 0; i < 70; i++)
	{
		cout << "_"; 
	}
	cout << "_" << endl;
	cout << right << setw(55) << "Balance: " << "$"  << setw(12) << balance << endl;
	

	return 0; 
}

