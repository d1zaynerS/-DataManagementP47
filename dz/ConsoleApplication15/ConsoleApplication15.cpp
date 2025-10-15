#include <iostream>
#include <fstream>
#include <string>

class Company
{
    std::string name_;
    std::string owner_;
    std::string phone_;
    std::string address_;
    std::string activity_;

public:
    Company() = default;

    Company(std::string name, std::string owner, std::string phone,
        std::string address, std::string activity)
        : name_{ name }, owner_{ owner }, phone_{ phone }, address_{ address }, activity_{ activity } {
    }

    friend std::ostream& operator<<(std::ostream& os, const Company& c)
    {
        os << c.name_ << ' ' << c.owner_ << ' ' << c.phone_ << ' '
            << c.address_ << ' ' << c.activity_;
        return os;
    }

    std::string getName() const { return name_; }
    std::string getOwner() const { return owner_; }
    std::string getPhone() const { return phone_; }
    std::string getActivity() const { return activity_; }

    void print() const
    {
        std::cout << name_ << ' ' << owner_ << ' ' << phone_ << ' '
            << address_ << ' ' << activity_ << std::endl;
    }
};

int main()
{
    const std::string fileName = "companies.txt";

    std::ifstream input(fileName);
    size_t count = 0;
    if (input.is_open())
    {
        std::string line;
        while (std::getline(input, line))
            ++count;
        input.close();
    }

    Company** firms = nullptr;
    if (count > 0)
    {
        firms = new Company * [count];
        std::ifstream input2(fileName);
        for (size_t i = 0; i < count; ++i)
        {
            std::string name, owner, phone, address, activity;
            input2 >> name >> owner >> phone >> address >> activity;
            firms[i] = new Company(name, owner, phone, address, activity);
        }
        input2.close();
    }

    int choice;
    do
    {
        std::cout << "\nМеню:\n"
            << "1. Додати фірму\n"
            << "2. Пошук за назвою\n"
            << "3. Пошук за власником\n"
            << "4. Пошук за телефоном\n"
            << "5. Пошук за родом діяльності\n"
            << "6. Вивести всі записи\n"
            << "0. Вихід\n"
            << "Ваш вибір: ";
        std::cin >> choice;

        if (choice == 1)
        {
            std::string name, owner, phone, address, activity;
            std::cout << "Назва: ";
            std::cin >> name;
            std::cout << "Власник: ";
            std::cin >> owner;
            std::cout << "Телефон: ";
            std::cin >> phone;
            std::cout << "Адреса: ";
            std::cin >> address;
            std::cout << "Рід діяльності: ";
            std::cin >> activity;


            Company** newFirms = new Company * [count + 1];
            for (size_t i = 0; i < count; ++i)
                newFirms[i] = firms[i];

            newFirms[count] = new Company(name, owner, phone, address, activity);

            delete[] firms;
            firms = newFirms;
            ++count;


            std::ofstream output(fileName, std::ios::app);
            output << name << ' ' << owner << ' ' << phone << ' '
                << address << ' ' << activity << std::endl;
            output.close();
        }
        else if (choice >= 2 && choice <= 5)
        {
            std::string key;
            std::cout << "Введіть значення для пошуку: ";
            std::cin >> key;

            for (size_t i = 0; i < count; ++i)
            {
                if ((choice == 2 && firms[i]->getName() == key) ||
                    (choice == 3 && firms[i]->getOwner() == key) ||
                    (choice == 4 && firms[i]->getPhone() == key) ||
                    (choice == 5 && firms[i]->getActivity() == key))
                    firms[i]->print();
            }
        }
        else if (choice == 6)
        {
            for (size_t i = 0; i < count; ++i)
                firms[i]->print();
        }

    } while (choice != 0);


    for (size_t i = 0; i < count; ++i)
        delete firms[i];
    delete[] firms;

    return 0;
}

