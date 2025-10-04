#include <iostream>

template<class T>
class Array
{
private:
    T* array_;
    size_t capacity_;
    size_t size_;
public:
    Array(size_t capacity) : array_{ nullptr }, capacity_{ capacity }, size_{ 0 }
    {
        if (capacity == 999999)
        {
            throw "Ошибка: Недостаточно ресурсов для выделения памяти";
        }

        array_ = new T[capacity];
    }

    Array() : Array(5) {}
    Array(const Array& other) = delete;
    Array& operator=(const Array& other) = delete;
    ~Array() { delete[] array_; }

    void push(T value)
    {
        if (size_ == capacity_)
        {
            throw "Array Error: Массив полон";
        }
        array_[size_++] = value;
    }

    void pop()
    {
        if (size_ == 0)
            throw 1;

        --size_;
    }

    size_t getSize() const { return size_; }
    T& operator[](int index) { return array_[index]; }
};

template<class T>
class Stack
{
private:
    Array<T> data_;
    size_t capacity_;

public:
    Stack(size_t capacity) : capacity_{ capacity }, data_{ capacity }
    {
    }

    void push(T value)
    {
        try
        {
            data_.push(value);
        }
        catch (const char* ex)
        {
            throw "Исключение: Переполнение стека. Нельзя добавить элемент";
        }
    }

    void pop()
    {
        try
        {
            data_.pop();
        }
        catch (int ex)
        {
            throw "Исключение: Стек пуст. Нельзя удалить элемент";
        }
    }

    void display() const
    {
        std::cout << "Стек (LIFO): [";
        for (int i_ = 0; i_ < data_.getSize(); ++i_)
        {
            std::cout << (const_cast<Array<T>&>(data_))[i_] << (i_ < data_.getSize() - 1 ? ", " : "");
        }
        std::cout << "]\n";
    }
};

void testOverflow(Stack<int>* stack_)
{
    std::cout << "Добавление элементов (5 раз)..." << std::endl;
    for (int i_ = 0; i_ < 5; ++i_)
    {
        stack_->push(i_ * 10);
    }
    stack_->display();
    std::cout << "Попытка добавить 6-й элемент (Переполнение)..." << std::endl;
    stack_->push(60);
}

void testUnderflow(Stack<int>* stack_)
{
    std::cout << "Удаление всех элементов (5 раз)..." << std::endl;
    for (int i_ = 0; i_ < 5; ++i_)
    {
        stack_->push(i_ * 10);
    }
    for (int i_ = 0; i_ < 5; ++i_)
    {
        stack_->pop();
    }
    stack_->display();
    std::cout << "Попытка удалить еще один элемент (Стек пуст)..." << std::endl;
    stack_->pop();
}

void processStackTest(int test_num, const char* name, void (*test_func)(Stack<int>*))
{
    std::cout << "\n=== Тест " << test_num << ": " << name << " ===" << std::endl;
    try
    {
        Stack<int>* stack_ = new Stack<int>(5);
        test_func(stack_);
        delete stack_;
    }
    catch (const char* ex)
    {
        std::cout << "Перехвачено исключение (const char*): " << ex << std::endl;
    }
    catch (int ex)
    {
        std::cout << "Перехвачено исключение (int): " << ex << std::endl;
    }
    catch (...)
    {
        std::cout << "Перехвачено неизвестное исключение" << std::endl;
    }
}

void testMemoryAllocation()
{
    std::cout << "\n=== Тест 3: Ошибка выделения памяти ===" << std::endl;
    try
    {
        std::cout << "Попытка создать стек с capacity = 999999 (Симуляция ошибки)..." << std::endl;
        Stack<int>* stack_ = new Stack<int>(999999);
        delete stack_;
    }
    catch (const char* ex)
    {
        std::cout << "Перехвачено исключение (const char*): " << ex << std::endl;
    }
    catch (...)
    {
        std::cout << "Перехвачено неизвестное исключение" << std::endl;
    }
}

int main()
{
    processStackTest(1, "Переполнение стека", testOverflow);
    processStackTest(2, "Стек пуст", testUnderflow);
    testMemoryAllocation();

    return 0;
}