#include <iostream>
#include <iomanip>

int main()
{
    double pi;
    std::cout << "Enter a double: ";
    std::cin >> pi;

    int value = static_cast<int>(pi);

    std::cout << "Double: " << pi << std::endl;
    std::cout << "Integer: " << value << std::endl;
}
