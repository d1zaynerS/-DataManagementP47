#include <iostream>

class Pet
{
protected:

	const char* name_;
	const char* characteristics_;
public:

	Pet(const char* name, const char* characteristics) : name_{ name }, characteristics_{ characteristics }
	{
	}

	virtual ~Pet()
	{
		std::cout << "Уничтожение Pet " << name_ << std::endl;
	}


	virtual void Sound() const = 0;

	virtual void Show() const
	{
		std::cout << "Имя: " << name_ << " (Характеристики: " << characteristics_ << ")\n";
	}

	virtual void Type() const = 0;
};

class Dog : public Pet
{
public:

	Dog(const char* name, const char* characteristics) : Pet(name, characteristics)
	{
	}

	void Sound() const override
	{
		std::cout << "Звук: Гав! Гав!\n";
	}

	void Type() const override
	{
		std::cout << "Тип: Собака\n";
	}
};

class Cat : public Pet
{
public:
	Cat(const char* name, const char* characteristics) : Pet(name, characteristics)
	{
	}

	void Sound() const override
	{
		std::cout << "Звук: Мяу! Муррр...\n";
	}

	void Type() const override
	{
		std::cout << "Тип: Кошка\n";
	}
};

class Parrot : public Pet
{
public:
	Parrot(const char* name, const char* characteristics) : Pet(name, characteristics)
	{
	}

	void Sound() const override
	{
		std::cout << "Звук: Полли хочет крекер! (Каррр)\n";
	}

	void Type() const override
	{
		std::cout << "Тип: Попугай\n";
	}
};

class Hamster : public Pet
{
public:
	Hamster(const char* name, const char* characteristics) : Pet(name, characteristics)
	{
	}

	void Sound() const override
	{
		std::cout << "Звук: Писк-писк!\n";
	}

	void Type() const override
	{
		std::cout << "Тип: Хомяк\n";
	}
};

void performPetActions(Pet* pet)
{
	pet->Show();
	pet->Type();
	pet->Sound();
	std::cout << "-----------------------\n";
}

int main()
{

	Pet* bobby = new Dog("Бобби", "Золотистый ретривер");
	Pet* kitty = new Cat("Васька", "Сибирская, любит спать");
	Pet* polly = new Parrot("Капитан", "Серый попугай, имитирует голоса");

	performPetActions(bobby);
	performPetActions(kitty);
	performPetActions(polly);

	delete bobby;
	delete kitty;
	delete polly;

	return 0;
}
