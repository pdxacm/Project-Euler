// Name: Harmanpreet Singh
// Project Euler problem: 1

#include <iostream>

using namespace std;

int main()
{
	int sum = 0;
	for (int i = 0; i < 1000; i++)
	{
		if (i % 3 == 0 || i % 5 == 0)
		{
			sum += i;
		}
	}
	cout << "The sum of all the multiples of 3 and 5 below 1000 is: " << sum << endl;
	system("pause");
	return 0;
}
