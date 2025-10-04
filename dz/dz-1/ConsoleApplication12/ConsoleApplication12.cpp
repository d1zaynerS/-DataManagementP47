#include <iostream>
#include <fstream>
#include <string>

class Student
{
private:
    std::string firstName_;
    std::string lastName_;
    int age_;
public:
    Student() = default;
    Student(std::string firstName, std::string lastName, int age)
        : firstName_{ firstName }
        , lastName_{ lastName }
        , age_{ age }
    {
    }

    friend std::ostream& operator<<(std::ostream& os, const Student& stud)
    {
        os << "Имя: " << stud.firstName_ << ", Фамилия: " << stud.lastName_ << ", Возраст: " << stud.age_;
        return os;
    }

    void saveToFile(const std::string& fileName_) const
    {
        std::ofstream output(fileName_);

        if (!output.is_open())
        {
            throw "Ошибка: Невозможно открыть файл для ЗАПИСИ!";
        }

        output << firstName_ << std::endl;
        output << lastName_ << std::endl;
        output << age_ << std::endl;

        output.close();
    }

    void loadFromFile(const std::string& fileName_)
    {
        std::ifstream input(fileName_);

        if (!input.is_open())
        {
            throw "Ошибка: Невозможно открыть файл для ЧТЕНИЯ!";
        }

        input >> firstName_;
        input >> lastName_;
        input >> age_;

        if (input.fail())
        {
            throw "Ошибка: Некорректный формат данных!";
        }

        input.close();
    }
};

int main()
{
    const std::string FILE_NAME_ = "student_data.txt";

    std::cout << "--- Тест 1: Сохранение ---" << std::endl;
    Student originalStud("Иван", "Иванов", 21);

    try
    {
        std::cout << "Исходный объект: " << originalStud << std::endl;
        originalStud.saveToFile(FILE_NAME_);
        std::cout << "Сохранено!" << std::endl;
    }
    catch (const char* ex)
    {
        std::cout << "Ошибка: " << ex << std::endl;
    }

    std::cout << "\n--- Тест 2: Загрузка ---" << std::endl;
    Student loadedStud;
    std::cout << "Объект до загрузки: " << loadedStud << std::endl;

    try
    {
        loadedStud.loadFromFile(FILE_NAME_);
        std::cout << "Загружено!" << std::endl;
        std::cout << "Объект после загрузки: " << loadedStud << std::endl;
    }
    catch (const char* ex)
    {
        std::cout << "Ошибка: " << ex << std::endl;
    }

    std::cout << "\n--- Тест 3: Ошибка файла ---" << std::endl;
    const std::string WRONG_FILE_ = "нету_такого.txt";
    try
    {
        std::cout << "Попытка загрузки из " << WRONG_FILE_ << std::endl;
        loadedStud.loadFromFile(WRONG_FILE_);
    }
    catch (const char* ex)
    {
        std::cout << "Ошибка: " << ex << std::endl;
    }

    return 0;
}
