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
	
	SalariedEmployee(string name, double a_salary, int a_year, int a_month, int a_day) : Employee(name, a_year, a_month, a_day), salary(a_salary){}
	
	
	double sPay;
	virtual double calcPay()
	{ 
		sPay = salary/24; 
	return sPay; 
	}

	void display()
	{
		double pay = calcPay();
		Employee::display(); cout << salary << " " << pay << endl;
	}

	friend ostream& operator<<(ostream& out, SalariedEmployee& me)
	{
		out << (Employee &)me << " " << me.salary << endl;
			return out;
	}
};
#endif
