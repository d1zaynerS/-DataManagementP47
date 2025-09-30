#include <iostream>

class Animal {
public:
    virtual void speak() {
        std::cout << "Some animal sound" << std::endl;
    }
};

class Dog : public Animal {
public:
    void speak() override {
        std::cout << "Woof" << std::endl;
    }

    void bark() {
        std::cout << "Bark!" << std::endl;
    }
};

template<class T>
void checkPtr(T value) {
    if (value)
        std::cout << "Successful casting" << std::endl;
    else
        std::cout << "Bad casting" << std::endl;
}

int main() {
    Animal* animal = new Animal;
    Animal* dogAnimal = new Dog;

    Dog* d1 = dynamic_cast<Dog*>(animal);
    checkPtr(d1);

    Dog* d2 = dynamic_cast<Dog*>(dogAnimal);
    checkPtr(d2);

    if (d2)
        d2->bark();

    delete animal;
    delete dogAnimal;
}

