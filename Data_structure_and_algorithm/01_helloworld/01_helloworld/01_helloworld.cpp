// 01_helloworld.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>

using namespace std;

struct Animal {
	string name;
	int kg;
	int age;
};

class Human {
	string address;
public:
	string name;
	int age;
	int height;
	string sex;
};


int main()
{
	Animal cat;
	Human Anar;

	cat.age = 1;
	cat.name = "neko";
	cat.kg = 5;

	Anar.name = "anarconda";
	Anar.age = 25;
	Anar.sex = "Male";
	Anar.height = 70;

	cout << Anar.age << endl;
	cout << Anar.height << endl;
	cout << Anar.name << endl;
	cout << Anar.sex << endl;
	cout << cat.age << endl;
	cout << cat.kg << endl;
	cout << cat.name << endl;

	return 0;
}
