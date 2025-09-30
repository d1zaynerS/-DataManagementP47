#include <iostream>
#include <fstream>
#include <string>

class DirectoryEntry
{
    std::string company_;
    std::string owner_;
    std::string phone_;
    std::string address_;
    std::string activity_;
public:
    DirectoryEntry() = default;
    DirectoryEntry(const std::string& company, const std::string& owner,
        const std::string& phone, const std::string& address,
        const std::string& activity)
        : company_{ company }, owner_{ owner }, phone_{ phone }, address_{ address }, activity_{ activity } {
    }

    friend std::ostream& operator<<(std::ostream& os, const DirectoryEntry& entry)
    {
        os << entry.company_ << " " << entry.owner_ << " " << entry.phone_ << " "
            << entry.address_ << " " << entry.activity_;
        return os;
    }

    bool matchesCompany(const std::string& company) { return company_ == company; }

    void saveToFile(std::ofstream& out)
    {
        out << company_ << std::endl;
        out << owner_ << std::endl;
        out << phone_ << std::endl;
        out << address_ << std::endl;
        out << activity_ << std::endl;
    }

    void loadFromFile(std::ifstream& in)
    {
        std::getline(in, company_);
        std::getline(in, owner_);
        std::getline(in, phone_);
        std::getline(in, address_);
        std::getline(in, activity_);
    }
};

int main()
{
    const std::string fileName = "directory.txt";
    const int maxSize = 5;
    DirectoryEntry entries[maxSize] = {
        {"Apple", "Jobs", "123456", "Cupertino", "Technology"},
        {"Google", "Pichai", "654321", "MountainView", "Technology"}
    };
    int count = 2;

    std::ofstream output(fileName);
    for (int i = 0; i < count; ++i)
        entries[i].saveToFile(output);
    output.close();

    std::string company, owner, phone, address, activity;
    std::cout << "Enter company: ";
    std::getline(std::cin, company);
    std::cout << "Enter owner: ";
    std::getline(std::cin, owner);
    std::cout << "Enter phone: ";
    std::getline(std::cin, phone);
    std::cout << "Enter address: ";
    std::getline(std::cin, address);
    std::cout << "Enter activity: ";
    std::getline(std::cin, activity);

    if (count < maxSize)
        entries[count++] = DirectoryEntry(company, owner, phone, address, activity);

    std::ofstream outFile(fileName);
    for (int i = 0; i < count; ++i)
        entries[i].saveToFile(outFile);
    outFile.close();

    std::cout << "Search by company: ";
    std::getline(std::cin, company);
    for (int i = 0; i < count; ++i)
        if (entries[i].matchesCompany(company))
            std::cout << entries[i] << std::endl;

    std::cout << "All entries:\n";
    for (int i = 0; i < count; ++i)
        std::cout << entries[i] << std::endl;
}
