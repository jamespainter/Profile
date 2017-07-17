#ifndef _SALESEMPLOYEE_H_ 
#define _SALESEMPLOYEE_H_
#include "Employee.h"
#include "SalariedEmployee.h"
#include <iostream>
#include <string>
using namespace std;

class SalesEmployee : public SalariedEmployee
{

private:
	double commission;
	double sales; 

public:
	SalesEmployee(string name, double salary, double a_commission, double a_sales) :SalariedEmployee(name, salary), commission(a_commission), sales(a_sales){}


	void display()
	{
		SalariedEmployee::display(); cout << commission << " " << sales << endl;
	}

	friend ostream& operator<<(ostream& out, SalesEmployee& me)
	{
		out << (SalariedEmployee &)me << " " << me.commission << " " << me.sales << endl;
			return out;
	}
};
#endif
