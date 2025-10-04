#include <iostream>

int StringToInt(const char* str)
{
	int result_ = 0;
	int sign_ = 1;
	int i_ = 0;

	if (str[0] == '-')
	{
		sign_ = -1;
		i_ = 1;
	}

	for (; str[i_] != '\0'; ++i_)
	{
		if (str[i_] < '0' || str[i_] > '9')
		{
			throw "Недопустимый символ в строке";
		}

		int digit_ = str[i_] - '0';

		if (sign_ == 1)
		{

			if (result_ > 214748364 || (result_ == 214748364 && digit_ > 7))
			{
				throw "Превышен диапазон INT_MAX";
			}
		}

		else
		{

			if (result_ > 214748364 || (result_ == 214748364 && digit_ > 8))
			{
				throw "Превышен диапазон INT_MIN";
			}
		}

		result_ = result_ * 10 + digit_;
	}

	return result_ * sign_;
}

int main()
{
	const char* valid_str_1 = "12345";
	const char* valid_str_2 = "-9876";
	const char* invalid_char = "100a00";
	const char* overflow_str = "2147483648";
	const char* underflow_str = "-2147483649";

	std::cout << "--- Проверка корректных значений ---" << std::endl;

	try
	{
		int res1 = StringToInt(valid_str_1);
		std::cout << "Строка \"" << valid_str_1 << "\" -> Результат: " << res1 << std::endl;

		int res2 = StringToInt(valid_str_2);
		std::cout << "Строка \"" << valid_str_2 << "\" -> Результат: " << res2 << std::endl;
	}
	catch (const char* ex)
	{
		std::cout << "Перехвачена ошибка: " << ex << std::endl;
	}

	std::cout << "\n--- Проверка ошибок (Exceptions) ---" << std::endl;

	try
	{
		std::cout << "Тест 1: Строка \"" << invalid_char << "\"" << std::endl;
		StringToInt(invalid_char);
	}
	catch (const char* ex)
	{
		std::cout << "Ошибка 1: " << ex << std::endl;
	}

	try
	{
		std::cout << "Тест 2: Строка \"" << overflow_str << "\"" << std::endl;
		StringToInt(overflow_str);
	}
	catch (const char* ex)
	{
		std::cout << "Ошибка 2: " << ex << std::endl;
	}

	try
	{
		std::cout << "Тест 3: Строка \"" << underflow_str << "\"" << std::endl;
		StringToInt(underflow_str);
	}
	catch (const char* ex)
	{
		std::cout << "Ошибка 3: " << ex << std::endl;
	}

	return 0;
}