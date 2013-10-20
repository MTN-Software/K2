#include <iostream>
#include <conio.h>
#include <string>
#include <vector>

int main()
{
	using std::cout;
	using std::cin;
	using std::endl;

	double dblProducts;

	cout << " --- Product Entry --- " << endl << endl;
	cout << "# of products for entry: ";
	cin >> dblProducts;
	std::vector<double> productQuant(dblProducts);
	std::vector<std::string> productName(dblProducts);
	std::vector<double> productPrice(dblProducts);
	cout << endl << endl;

	for (double _Iter = 0.00; _Iter < dblProducts; _Iter++)
	{
		cout << "Product #" << _Iter + 1 << ":\n\n";
		cout << "\tName: ";
		cin >> productName[_Iter];
		cout << "\tQuantity: ";
		cin >> productQuant[_Iter];
		cout << "\tPrice: ";
		cin >> productPrice[_Iter];
		cout << "\n\n";
	}


	cout << " --- Results --- " << endl << endl;
	cout << "Name\tQuantity\tPrice" << endl;

	for (double _Iter = 0.00; _Iter < dblProducts; _Iter++)
	{
		cout << productName[_Iter] << "\t" << productQuant[_Iter] << "\t\t$" << productPrice[_Iter];
		cout << endl;
	}

	_getch();
	return 0;
}