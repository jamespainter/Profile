#include <iostream>
#include <iostream>
#include "fraction.h"
using namespace std;


fraction operator+(fraction one, fraction two)
{
	fraction retval;
	retval.numerator = (one.numerator * two.denominator + one.denominator * two.numerator);
	retval.denominator = (one.denominator * two.denominator);

  return retval;
}

fraction operator-(fraction one, fraction two)
{
	fraction subtractedval;
	subtractedval.numerator = (one.numerator * two.denominator - one.numerator * two.denominator);
	subtractedval.denominator = (one.denominator * two.denominator);
	
	return subtractedval;
}


fraction operator*(fraction one, fraction two)
{
	fraction multval;
	multval.numerator = (one.numerator * two.numerator);
	multval.denominator = (one.denominator * two.denominator);
	return multval;
}

fraction operator/(fraction one, fraction two)
{
	fraction dival; 
	dival.numerator = (one.numerator * two.denominator);
	dival.denominator = (one.denominator * two.numerator);
	return dival;
}

 ostream& operator<<(ostream& out, fraction& f)
{
	out << f.numerator << " / " << f.denominator << endl; 
	return out;
}

istream& operator>>(istream& in, fraction& i)
{
	cout << "Enter in the Numerator: ";
	in >> i.numerator;
	cout << "Enter the Denominator: ";
	in >> i.denominator;
	return in;
}

int gcd(int u, int v)
{
	u = (u < 0) ? -u : u; // make u non-negative
	v = (v < 0) ? -v : v; // make v non-negative
	while (u > 0)
	{
		if (u < v)
		{
			int t = u; // swap u and v
			u = v;
			v = t;
		}
		u -= v;
	}
	return v; // the GCD of u and v
}