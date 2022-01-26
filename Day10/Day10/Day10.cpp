// Day10.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;

enum class Supers
{
    Math, Riddles, CPP = 10, Read
};
int age = 12;

void PrintPowers(Supers powers)
{
    switch (powers)
    {
    case Supers::Math:
        cout << "I can do Math!\n";
        break;
    case Supers::Riddles:
        cout << "I can do Riddles!\n";
        break;
    case Supers::CPP:
        break;
    case Supers::Read:
        break;
    default:
        break;
    }
}

int main()
{
    Supers myPowers = Supers::Riddles;
    PrintPowers(myPowers);

    //std - namespace
    //:: - scope resolution operator
    //cout - console output stream
    //<< - insertion operator
    std::cout << "Hello World!\n" << 5 << "\n";

    int nums[] = { 5,4,3,2,1 };
    char name[] = "Bruce Wayne";//adds a null terminator \0
    char alter[] = { 'B','a','t' };//does NOT add a \0
    std::cout << name << "\n" << alter << "\n";

    std::cout << sizeof(char) << "bytes\n";

    for (size_t i = 0; i < 5; i++)
    {
        std::cout << nums[i] << "\n";
    }

    srand(time(NULL));
    int rando = rand();//0-RAND_MAX 
    //0-100
    // %
    rando = rand() % 101;//0-100

    //template
    vector<int> scores;
    cout << "capacity: " << scores.capacity() << "\n";
    scores.push_back(rand());
    cout << "capacity: " << scores.capacity() << "\n";
    scores.push_back(rand());
    cout << "capacity: " << scores.capacity() << "\n";
    scores.push_back(rand());
    cout << "capacity: " << scores.capacity() << "\n";
    scores.push_back(rand());
    cout << "capacity: " << scores.capacity() << "\n";
    scores.push_back(rand());

    for (size_t i = 0; i < scores.size(); i++)
    {
        cout << scores[i] << "\n";
    }
    cout << "capacity: " << scores.capacity();
}
