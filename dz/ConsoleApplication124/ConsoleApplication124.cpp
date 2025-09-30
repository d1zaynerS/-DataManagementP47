#include <iostream>
#include <fstream>
#include <string>

class File
{
public:
    virtual void Display(const char* path)
    {
        std::ifstream in(path);
        if (!in.is_open())
        {
            std::cout << "File not found" << std::endl;
            return;
        }

        char c;
        while (in.get(c))
            std::cout << c;

        std::cout << std::endl;
    }
};

class FileAscii : public File
{
public:
    void Display(const char* path) override
    {
        std::ifstream in(path);
        if (!in.is_open())
        {
            std::cout << "File not found" << std::endl;
            return;
        }

        char c;
        while (in.get(c))
            std::cout << static_cast<int>(c) << " ";

        std::cout << std::endl;
    }
};

class FileBinary : public File
{
public:
    void Display(const char* path) override
    {
        std::ifstream in(path, std::ios::binary);
        if (!in.is_open())
        {
            std::cout << "File not found" << std::endl;
            return;
        }

        unsigned char c;
        while (in.read((char*)&c, 1))
        {
            for (int i = 7; i >= 0; --i)
                std::cout << ((c >> i) & 1);
            std::cout << " ";
        }

        std::cout << std::endl;
    }
};

int main()
{
    const char* path = "text.txt";

    File base;
    FileAscii ascii;
    FileBinary bin;

    File* f = &base;
    f->Display(path);

    f = &ascii;
    f->Display(path);

    f = &bin;
    f->Display(path);

    return 0;
}
