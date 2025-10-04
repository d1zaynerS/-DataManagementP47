#include <iostream>

template<class T>
class Array
{
	T* array_;
	size_t capacity_;
	size_t size_;
public:
	Array() : Array(5) {}

	Array(size_t capacity) : array_{ new T[capacity] }, capacity_{ capacity }, size_{ 0 } {}
	Array(const Array& other) = delete;
	Array& operator=(const Array& other) = delete;
	~Array()
	{
		delete[] array_;
	}

	void push(T value)
	{
		if (size_ == capacity_)
		{
			throw "Массив полон";
		}
		array_[size_++] = value;
	}

	void pop()
	{
		if (size_ == 0)
			throw 1;

		--size_;
	}

	size_t getSize() const
	{
		return size_;
	}

	T& operator[](int index)
	{
		return array_[index];
	}
};

template<class T>
class IList
{
public:
	virtual void push(T value) = 0;
	// pop без параметров, как в Array::pop
	virtual void pop() = 0;
	virtual void display() const = 0;
	virtual ~IList()
	{
		std::cout << "Уничтожение IList\n";
	}
};

template<class T>
class Stack : public IList<T>
{
private:
	Array<T> data_;

public:

	Stack(size_t capacity) : data_{ capacity } {}

	void push(T value) override
	{
		data_.push(value);
	}

	void pop() override
	{
		data_.pop();
	}

	void display() const override
	{
		std::cout << "Стек (LIFO): [";
		for (int i = 0; i < data_.getSize(); ++i)
		{
			std::cout << (const_cast<Array<T>&>(data_))[i] << (i < data_.getSize() - 1 ? ", " : "");
		}
		std::cout << "]\n";
	}
};

template<class T>
class Queue : public IList<T>
{
private:
	Array<T> data_;

public:

	Queue(size_t capacity) : data_{ capacity } {}

	void push(T value) override
	{
		data_.push(value);
	}

	void pop() override
	{
		if (data_.getSize() == 0)
		{
			data_.pop();
		}

		for (int i = 0; i < data_.getSize() - 1; ++i)
		{
			data_[i] = data_[i + 1];
		}

		data_.pop();
	}

	void display() const override
	{
		std::cout << "Очередь (FIFO): [";
		for (int i = 0; i < data_.getSize(); ++i)
		{
			std::cout << (const_cast<Array<T>&>(data_))[i] << (i < data_.getSize() - 1 ? ", " : "");
		}
		std::cout << "]\n";
	}
};

void processList(IList<int>* list, const char* name)
{
	std::cout << "=== Обработка " << name << " ===" << std::endl;

	try
	{
		list->push(10);
		list->push(20);
		list->push(30);

		std::cout << "После добавления 10, 20, 30: ";
		list->display();

		std::cout << "Удаление элемента..." << std::endl;
		list->pop();
		std::cout << "После 1-го удаления: ";
		list->display();

		std::cout << "Удаление еще одного элемента..." << std::endl;
		list->pop();
		std::cout << "После 2-го удаления: ";
		list->display();

	}
	catch (const char* ex)
	{
		std::cout << "Перехвачено исключение char*: " << ex << std::endl;
	}
	catch (int ex)
	{
		std::cout << "Перехвачено исключение int (Список пуст): " << ex << std::endl;
	}
	catch (...)
	{
		std::cout << "Перехвачено неизвестное исключение" << std::endl;
	}

	std::cout << "======================================\n";
}

int main()
{
	IList<int>* myStack = new Stack<int>(5);
	processList(myStack, "Стек (LIFO)");
	delete myStack;

	IList<int>* myQueue = new Queue<int>(5);
	processList(myQueue, "Очередь (FIFO)");
	delete myQueue;

	return 0;
}