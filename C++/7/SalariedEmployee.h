#ifndef _SALARIEDEMPLOYEE_H_ 
#define _SALARIEDEMPLOYEE_H_
#include "Employee.h"
#include <iostream>
#include <string>
using namespace std;

class SalariedEmployee : public Employee
{

private:
	double salary;

public:
	SalariedEmployee(string name, double a_salary) : Employee(name), salary(a_salary){}


	void display()
	{
		Employee::display(); cout << salary << endl;
	}

	friend ostream& operator<<(ostream& out, SalariedEmployee& me)
	{
		out << (Employee &)me << " " << me.salary << endl;
			return out;
	}
};
#endif
