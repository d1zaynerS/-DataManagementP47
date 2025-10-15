#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

struct Car {
	std::string name;
	int year;
	double engine;
	double price;
};

void print(const std::vector<Car>& vec)
{
	for (const auto& c : vec)
	{
		std::cout << c.name << ' ' << c.year << ' ' << c.engine << ' ' << c.price << std::endl;
	}
}

struct SortName {
	bool operator()(const Car& a, const Car& b)
	{
		return a.name < b.name;
	}
};

struct SortYear {
	bool operator()(const Car& a, const Car& b)
	{
		return a.year < b.year;
	}
};

struct SortEngine {
	bool operator()(const Car& a, const Car& b)
	{
		return a.engine < b.engine;
	}
};

struct SortPrice {
	bool operator()(const Car& a, const Car& b)
	{
		return a.price < b.price;
	}
};

int main()
{
	std::vector<Car> vec;
	int choice;

	do
	{
		std::cout << "\n1-add 2-del 3-show 4-sort 5-search 6-exit\nChoose: ";
		std::cin >> choice;

		if (choice == 1)
		{
			Car c;
			std::cout << "Enter name year engine price: ";
			std::cin >> c.name >> c.year >> c.engine >> c.price;
			vec.push_back(c);
		}
		else if (choice == 2)
		{
			std::string target;
			std::cout << "Enter name to delete: ";
			std::cin >> target;
			vec.erase(std::remove_if(vec.begin(), vec.end(), [target](const Car& c) { return c.name == target; }), vec.end());
		}
		else if (choice == 3)
		{
			print(vec);
		}
		else if (choice == 4)
		{
			int t;
			std::cout << "Sort by 1-name 2-year 3-engine 4-price: ";
			std::cin >> t;
			if (t == 1) std::sort(vec.begin(), vec.end(), SortName());
			else if (t == 2) std::sort(vec.begin(), vec.end(), SortYear());
			else if (t == 3) std::sort(vec.begin(), vec.end(), SortEngine());
			else if (t == 4) std::sort(vec.begin(), vec.end(), SortPrice());
		}
		else if (choice == 5)
		{
			int t;
			std::cout << "Search by 1-name 2-year 3-engine 4-price: ";
			std::cin >> t;

			if (t == 1)
			{
				std::string target;
				std::cout << "Enter name: ";
				std::cin >> target;
				auto it = std::find_if(vec.begin(), vec.end(), [target](const Car& c) { return c.name == target; });
				if (it != vec.end()) std::cout << it->name << ' ' << it->year << ' ' << it->engine << ' ' << it->price << std::endl;
				else std::cout << "Not found\n";
			}
			else if (t == 2)
			{
				int target;
				std::cout << "Enter year: ";
				std::cin >> target;
				auto it = std::find_if(vec.begin(), vec.end(), [target](const Car& c) { return c.year == target; });
				if (it != vec.end()) std::cout << it->name << ' ' << it->year << ' ' << it->engine << ' ' << it->price << std::endl;
				else std::cout << "Not found\n";
			}
			else if (t == 3)
			{
				double target;
				std::cout << "Enter engine: ";
				std::cin >> target;
				auto it = std::find_if(vec.begin(), vec.end(), [target](const Car& c) { return c.engine == target; });
				if (it != vec.end()) std::cout << it->name << ' ' << it->year << ' ' << it->engine << ' ' << it->price << std::endl;
				else std::cout << "Not found\n";
			}
			else if (t == 4)
			{
				double target;
				std::cout << "Enter price: ";
				std::cin >> target;
				auto it = std::find_if(vec.begin(), vec.end(), [target](const Car& c) { return c.price == target; });
				if (it != vec.end()) std::cout << it->name << ' ' << it->year << ' ' << it->engine << ' ' << it->price << std::endl;
				else std::cout << "Not found\n";
			}
		}
	} while (choice != 6);
}


