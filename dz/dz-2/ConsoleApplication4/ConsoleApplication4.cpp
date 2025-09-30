#include <iostream>

void modify(char* str) {
    str[0] = 'H';
}

int main() {
    // Массив char — память изменяемая
    char text[] = "hello";

    modify(text);

    std::cout << text << std::endl; // Выведет: Hello
}