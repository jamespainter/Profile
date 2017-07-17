#include <iostream>
#include <iostream>
#include "fraction.h"
using namespace std;



fraction fraction::add(fraction two)
{
	fraction retval;
	retval.numerator = (numerator * two.denominator + denominator*two.numerator);
	retval.denominator = (denominator*two.denominator);

  return retval;
}

fraction fraction::sub(fraction two)
{
	fraction subtractedval;
	subtractedval.numerator = (numerator * two.denominator - numerator * two.denominator);
	subtractedval.denominator = (denominator * two.denominator);
	
	return subtractedval;
}


fraction fraction::mult(fraction two)
{
	fraction multval;
	multval.numerator = (numerator * two.numerator);
	multval.denominator = (denominator * two.denominator);
	return multval;
}

fraction fraction::div(fraction two)
{
	fraction dival; 
	dival.numerator = (numerator * two.denominator);
	dival.denominator = (denominator * two.numerator);
	return dival;
}

void fraction::print()
{
	cout << numerator << " / " << denominator << endl; 
}

void fraction::read()
{
	cout << "Enter in the Numerator: ";
	cin >> numerator;
	cout << "Enter the Denominator: ";
	cin >> denominator;

}

