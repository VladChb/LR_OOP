#pragma once
#include <iostream>
using namespace std;
class Person
{	
		string name;
		int age;
		bool sex;

	public:
		Person();
		Person(string name, int age, bool sex);
		string getName();
		int getAge();
		bool getSex();
		void setPerson(string n, int old, bool pol);
		void setName(string n);
		void setAge(int old);
		void setSex(bool pol);
		void printPerson();
		Person(const Person&);
		

		

};

