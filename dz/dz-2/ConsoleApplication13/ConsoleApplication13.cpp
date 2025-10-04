#include <iostream>
#include <fstream>
#include <string>

class Fraction
{
private:
    int numerator_;
    int denominator_;
public:
    Fraction() : numerator_{ 0 }, denominator_{ 1 } {}

    Fraction(int num, int den)
        : numerator_{ num }
        , denominator_{ den }
    {
        if (denominator_ == 0)
        {
            throw "Ошибка: Знаменатель не может быть равен нулю!";
        }
    }

    friend std::ostream& operator<<(std::ostream& os, const Fraction& f)
    {
        os << f.numerator_ << "/" << f.denominator_;
        return os;
    }

    void saveToFile(const std::string& fileName_) const
    {
        std::ofstream output(fileName_);

        if (!output.is_open())
        {
            throw "Ошибка: Невозможно открыть файл для ЗАПИСИ!";
        }

        output << numerator_ << std::endl;
        output << denominator_ << std::endl;

        output.close();
    }

    void loadFromFile(const std::string& fileName_)
    {
        std::ifstream input(fileName_);

        if (!input.is_open())
        {
            throw "Ошибка: Невозможно открыть файл для ЧТЕНИЯ!";
        }

        input >> numerator_;
        input >> denominator_;

        if (input.fail() || denominator_ == 0)
        {
            throw "Ошибка: Некорректные данные или нулевой знаменатель!";
        }

        input.close();
    }
};

int main()
{
    const std::string FILE_NAME_ = "fraction_data.txt";

    std::cout << "--- Тест 1: Сохранение ---" << std::endl;
    try
    {
        Fraction originalF(3, 4);
        std::cout << "Исходный объект: " << originalF << std::endl;
        originalF.saveToFile(FILE_NAME_);
        std::cout << "Сохранено!" << std::endl;
    }
    catch (const char* ex)
    {
        std::cout << "Ошибка: " << ex << std::endl;
    }

    std::cout << "\n--- Тест 2: Загрузка ---" << std::endl;
    Fraction loadedF;
    std::cout << "Объект до загрузки: " << loadedF << std::endl;

    try
    {
        loadedF.loadFromFile(FILE_NAME_);
        std::cout << "Загружено!" << std::endl;
        std::cout << "Объект после загрузки: " << loadedF << std::endl;
    }
    catch (const char* ex)
    {
        std::cout << "Ошибка: " << ex << std::endl;
    }

    std::cout << "\n--- Тест 3: Ошибка файла ---" << std::endl;
    const std::string WRONG_FILE_ = "нет_такого_файла.txt";
    try
    {
        std::cout << "Попытка загрузки из " << WRONG_FILE_ << std::endl;
        loadedF.loadFromFile(WRONG_FILE_);
    }
    catch (const char* ex)
    {
        std::cout << "Ошибка: " << ex << std::endl;
    }

    return 0;
}