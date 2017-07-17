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
	SalesEmployee(string name, double salary, double a_commission, double a_sales, int a_year, int a_month, int a_day) :SalariedEmployee(name, salary, a_year, a_month, a_day), commission(a_commission), sales(a_sales){}
	
	double semPay;
	virtual double calcPay()
	{ 
		double pay = SalariedEmployee::calcPay();
		semPay = pay + (commission * sales); 
		return semPay; 
	}

	void display()
	{
		double pay = calcPay();
		SalariedEmployee::display(); cout << commission << " " << sales << " " << pay << endl;
	}

	friend ostream& operator<<(ostream& out, SalesEmployee& me)
	{
		out << (SalariedEmployee &)me << " " << me.commission << " " << me.sales << endl;
			return out;
	}
};
#endif