#include "Employee.h"
#include "SalariedEmployee.h"
#include "SalesEmployee.h"
#include "WagedEmployee.h"
#include <iostream>
#include <string>
using namespace std;


void prompt(char* message, string& variable);
void prompt(char* message, double& number);


int main()
{
	while (true)
	{
		cout << endl;
		cout << "1. Waged Employee" << endl;
		cout << "2. Salaried Employee" << endl;
		cout << "3. Sales Employee" << endl;
		//cout << "4. List" << endl << endl;		// used in a future lab
		cout << "5. Exit" << endl << endl;
		cout << "Choose an Employee or an Action: ";

		char c;
		cin >> c;
		cin.ignore();				// discard new-line (see the 2nd version of prompt)

		string	name;				// variables used by all employee types

		switch (c)
		{
			case '1' :
				{
					double	wage;
					double	hours;
					prompt("Name", name);
					prompt("Wage", wage);
					prompt("Hours", hours);
					WagedEmployee* we = new WagedEmployee(name, wage, hours);
					cout << *we << endl;
					we->display();
					break;
				}

			case '2' :
				{
					double	salary;
					prompt("Name", name);
					prompt("Salary", salary);
					SalariedEmployee* se = new SalariedEmployee(name, salary);
					cout << *se << endl;
					se->display();
					break;
				}

			case '3' :
				{
					double	salary;
					double	commission;
					double	sales;
					prompt("Name", name);
					prompt("Salary", salary);
					prompt("Commission", commission);
					prompt("Sales", sales);
					SalesEmployee* se = new SalesEmployee(name, salary, commission, sales);
					cout << *se << endl;
					se->display();
					break;
				}

			//case '4' :
			//	break;

			case '5' :
				exit(0);
		}
	}

	return 0;
}


void prompt(char* message, string& variable)
{
	cout << message << ": ";
	getline(cin, variable);
}


void prompt(char* message, double& number)
{
	cout << message << ": ";
	cin >> number;
	cin.get();		// discard \n following number
}


