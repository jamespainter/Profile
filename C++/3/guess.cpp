#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;

int main()
{
	srand((unsigned)time(NULL)); // seed the generator
	int target = rand() % 100; // numbers [0..99]
	
	int guess =100;
	while (guess != target)
	{
		cout << "Enter a guess between 0 and 99: " << endl;
		cin >> guess;

		if (guess < 0);
			exit;
		if (guess == target)
		{
			cout << "YOU WIN" << endl;
		}

		if (guess < target)
		{
			cout << "Low" << endl;
		}
		if (guess > target)
		{
			cout << "High" << endl;
		}

	}
	return 0;
}