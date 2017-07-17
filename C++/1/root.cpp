#include <iostream>
using namespace std; 

int main()
{
	double a;
	double b;
	double c; 
	

	cout << " Enter in a :";
		cin >> a;
		
	cout << " Enter in b :";
		cin >> b;

		cout << " Enter in c :";
		cin >> c;

		double x1 = (-b + sqrt(pow(b, 2.0) - 4.0*a*c)) / (2.0*a);
		double x2 = (-b - sqrt(pow(b, 2.0) - 4.0 * a*c)) / (2.0 * a);
		cout <<"x1="<< x1 << endl;
		cout <<"x2="<< x2 << endl;


}