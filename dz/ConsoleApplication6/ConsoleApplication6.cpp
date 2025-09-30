#include <iostream>

template<typename T>
class MyUniquePtr {
    T* ptr_;
public:
    explicit MyUniquePtr(T* ptr = nullptr) : ptr_(ptr) {}
    ~MyUniquePtr() { delete ptr_; }

    T& operator*() { return *ptr_; }
    T* operator->() { return ptr_; }

    MyUniquePtr(const MyUniquePtr&) = delete;
    MyUniquePtr& operator=(const MyUniquePtr&) = delete;

    MyUniquePtr(MyUniquePtr&& other) noexcept : ptr_(other.ptr_) { other.ptr_ = nullptr; }
    MyUniquePtr& operator=(MyUniquePtr&& other) noexcept {
        if (this != &other) {
            delete ptr_;
            ptr_ = other.ptr_;
            other.ptr_ = nullptr;
        }
        return *this;
    }
};


template<typename T>
class MySharedPtr {
    T* ptr_;
    size_t* count_;
public:
    explicit MySharedPtr(T* ptr = nullptr) : ptr_(ptr), count_(ptr ? new size_t(1) : nullptr) {}

    ~MySharedPtr() { release(); }

    MySharedPtr(const MySharedPtr& other) : ptr_(other.ptr_), count_(other.count_) {
        if (count_) ++(*count_);
    }

    MySharedPtr& operator=(const MySharedPtr& other) {
        if (this != &other) {
            release();
            ptr_ = other.ptr_;
            count_ = other.count_;
            if (count_) ++(*count_);
        }
        return *this;
    }

    T& operator*() { return *ptr_; }
    T* operator->() { return ptr_; }

private:
    void release() {
        if (count_) {
            --(*count_);
            if (*count_ == 0) {
                delete ptr_;
                delete count_;
            }
        }
    }
};

class Student {
    std::string name_;
public:
    Student(const std::string& name) : name_(name) {}
    void print() { std::cout << name_ << std::endl; }
};

int main() {
    std::cout << "--- Testing MyUniquePtr ---\n";
    MyUniquePtr<Student> uPtr(new Student("John"));
    uPtr->print();

    MyUniquePtr<Student> uPtr2 = std::move(uPtr);
    uPtr2->print();

    std::cout << "--- Testing MySharedPtr ---\n";
    MySharedPtr<Student> sPtr1(new Student("Alice"));
    MySharedPtr<Student> sPtr2 = sPtr1;
    sPtr1->print();
    sPtr2->print();
}
