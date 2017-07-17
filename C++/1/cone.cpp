#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	 
	
	double r;
	double h;

	cout << "Enter in the radius :" << endl;
	cin >> r;

	cout << "Enter in the height :" << endl;
	cin >> h;

	double V = (1.0 / 3.0) * M_PI*(pow(r, 2)*h);

	double S = M_PI * pow(r,2.0) + M_PI* r*sqrt(pow(r,2.0)+pow(h,2.0));

	cout << "Volume = " <<V << endl;
	cout << "Surface Area = "<< S << endl;

	return 0; 
}