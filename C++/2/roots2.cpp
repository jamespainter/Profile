#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>
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

	double d = (pow(b, 2.0) - 4.0 * a * c);

	if (d >= 0)
	{
		double x1 = (-b + sqrt(pow(b, 2.0) - 4.0*a*c)) / 2.0*a;
		double x2 = (-b - sqrt(pow(b, 2.0) - 4.0 * a*c)) / 2.0 * a;
		cout << "x1=" << x1 << endl;
		cout << "x2=" << x2 << endl;
	}

	else if (d < 0)
	{
		double real = -b / (2.0 *a);
		double imag = sqrt(-d) / (2.0 * a);
		cout << "x1 =" << real << '+' << imag << 'i' << endl;
		cout << "x2 =" << real << '-' << imag << 'i' << endl;
	}


	return 0;
}