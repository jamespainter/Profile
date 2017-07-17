#include <iostream> 
#include "sterling.h"
using namespace std; 

int main()
{
	sterling  s; 
	read(&s);
	print(s);

	sterling   t;
	read(&t); 
	print(t);

	sterling r = add(t, s);
	print(r);

		return 0;
}