#ifndef _WAGEDEMPLOYEE_H_ 
#define _WAGEDEMPLOYEE_H_
#include "Employee.h"
#include <iostream>
#include <string>
using namespace std;

class WagedEmployee : public Employee
{

private:
	double wage;
	double hours;

public:
	WagedEmployee(string name, double a_wage, double hours) : Employee(name), wage(a_wage), hours(hours){}


	void display()
	{
		Employee::display(); cout << wage << hours << endl;
	}

	friend ostream& operator<<(ostream& out, WagedEmployee& me)
	{
		out << (Employee &)me << " " << me.wage << " " << me.hours << endl;
			return out;
	}
};
#endif
