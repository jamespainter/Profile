#include <iostream>
using namespace std;

int main()
{
	int height;

	cout << "How tall should the tree be? " << endl;
	cin >> height;

	if (height < 3 || height > 15)
	{
		cerr << "Error Message" << endl;
		exit;
	}

	for (int level = 0; level < height; level++)
	{
		for (int spaces = 0; spaces < height - level - 1; spaces++)
			cout << ' ';
		cout << "/";
		for (int strLine = 0; strLine < 2 * level; strLine++)
			cout << ' ';
		cout << "\\" << endl;

	}

	for (int b = 0; b < 2 * height; b++)
		cout << '-';
	cout << endl;
	for (int level = 0; level < height / 2; level++)
	{
	for (int i = 0; i < height - 1; i++)
		cout << ' ';
		cout << "||" << endl;
    }


	return 0;
}