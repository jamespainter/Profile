#ifndef _EMPLOYEE_H_ 
#define _EMPLOYEE_H_
#include <iostream>
#include <string>
using namespace std;

class Employee {

private:
	string name; 

public:
	Employee(string a_name) : name(a_name) {}

	void display()
	{
		cout << name << endl;
	}

	friend ostream& operator<<(ostream& out, Employee& me)
	{
		out << me.name << endl;
		return out;
	}
};
#endif
