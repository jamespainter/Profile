#ifndef _EMPLOYEE_H_ 
#define _EMPLOYEE_H_
#include <iostream>
#include <string>
#include "Date.h"
#include "Address.h"
using namespace std;


class Employee {

private:
	
	string name; 
	Date bDate;
	Address* num;
public:
	Employee(string a_name, int a_year, int a_month, int a_day) :name(a_name), bDate(a_year, a_month, a_day), num(NULL) {}
	
	~Employee(){ if (num != NULL) delete num;}
	
	string getName(){ return name; }
	
	virtual double calcPay() = 0;
	

	void setAddress(string a_street, string a_city)
	{
		if (num != NULL) delete num; num = new Address(a_street, a_city);
	}
	void virtual display()
	{
		cout << name << endl;
		bDate.display();
		num->display();
	}

	friend ostream& operator<<(ostream& out, Employee& me)
	{
		out << me.name << " " << me.bDate << " " << *me.num << endl;
		return out;
	}
};
#endif
