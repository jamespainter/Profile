#include <iostream>
using namespace std;

int gcd(int u, int v);

class fraction
{
	private: 
		int numerator;
		int denominator;

	public:
	
	fraction(int n = 0, int d = 1) : numerator(n), denominator(d)
	{
		int common = gcd(numerator, denominator);
		numerator /= common;
		denominator /= common;
	}

	friend fraction operator+(fraction, fraction curval);
	friend fraction operator-(fraction, fraction curval);
	friend fraction operator*(fraction, fraction curval);
	friend fraction operator/(fraction, fraction curval);
	friend ostream& operator<<(ostream& out, fraction& curval);
	friend istream& operator>>(istream& in, fraction& curval);
	

};



