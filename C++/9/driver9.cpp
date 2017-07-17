#include "Employee.h"
#include "SalariedEmployee.h"
#include "SalesEmployee.h"
#include "WagedEmployee.h"
#include "Date.h"
#include "Address.h"
#include "CList.h"
#include <iostream>
#include <string>
using namespace std;


void prompt(char* message, string& variable);
void prompt(char* message, int& number);
void prompt(char* message, double& number);


int main()
{
	//instantiate a circularly linked list before the while loop 
	CList<Employee> mylist;

	

	while (true)
	{
		cout << endl;
		cout << "1. Waged Employee" << endl;
		cout << "2. Salaried Employee" << endl;
		cout << "3. Sales Employee" << endl;
		cout << "4. List" << endl << endl;		// used in a future lab
		cout << "5. Exit" << endl << endl;
		cout << "Choose an Employee or an Action: ";

		char	c;
		cin >> c;
		cin.ignore();

		string	name;				// variables used by all employee types
		int	year;
		int	month;
		int	day;
		string	street;
		string	city;

		switch (c)
		{
		case '1':	// waged employee
		{
			double	wage;
			double	hours;
			prompt("Name", name);
			prompt("Wage", wage);
			prompt("Hours", hours);
			prompt("Year", year);
			prompt("Month", month);
			prompt("Date", day);
			prompt("Street", street);
			prompt("City", city);
			WagedEmployee* we = new WagedEmployee(name, wage, hours, year, month, day);
			we->setAddress(street, city);
			mylist.insert(we);
			//cout << *we << endl;
			//we->display();
			break;
		}

		case '2':	// salaried employee
		{
			double	salary;
			prompt("Name", name);
			prompt("Salary", salary);
			prompt("Year", year);
			prompt("Month", month);
			prompt("Date", day);
			prompt("Street", street);
			prompt("City", city);
			SalariedEmployee* se = new SalariedEmployee(name, salary, year, month, day);
			se->setAddress(street, city);
			//cout << *se << endl;
			mylist.insert(se);
			//se->display();
			break;
		}

		case '3':	// sales employee
		{
			double	salary;
			double	commission;
			double	sales;
			prompt("Name", name);
			prompt("Salary", salary);
			prompt("Commission", commission);
			prompt("Sales", sales);
			prompt("Year", year);
			prompt("Month", month);
			prompt("Date", day);
			prompt("Street", street);
			prompt("City", city);
			SalesEmployee* se = new SalesEmployee(name, salary, commission, sales, year, month, day);
			se->setAddress(street, city);
			//cout << *se << endl;
			mylist.insert(se);
			//se->display();
			break;
		}

		case '4': // Clist 
			mylist.list();
			break;

		case '5':
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


void prompt(char* message, int& number)
{
	cout << message << ": ";
	cin >> number;
	cin.ignore();		// discard \n following number
}

void prompt(char* message, double& number)
{
	cout << message << ": ";
	cin >> number;
	cin.ignore();		// discard \n following number
}
