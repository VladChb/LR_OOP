#include "Person.h"




Person::Person(string n, int old, bool pol) : name(n), age(old), sex(pol) {
	cout << "parametru vuznacheni z adresom: " << this << endl;
}

Person::Person() :name(" "), age(0), sex(false) {
	cout << "parametru ne vuznacheni: "<<this<<endl;
}

Person::Person(const Person& other)
	: name(other.name), age(other.age), sex(other.sex) {
	cout << "kopiuvanna" << endl;
}


string Person::getName() {
	return name;
}
int Person::getAge() {
	return age;
}
bool Person::getSex() {
	return sex;
}
void Person::setName(string n) {
	name = n;
}
void Person::setAge(int old) {
	age = old;
}
void Person::setSex(bool pol) {
	sex = pol;
}

void Person::printPerson() {
	string pol;
	if (sex) pol = "men";
	else pol = "women";
	cout << "Name: " << name << "\t Age: " << age << "\t Sex: " << pol << endl;
}

void Person::setPerson(string n, int old, bool pol) {
	name = n;
	age = old;
	sex = pol;
	string pol1;
	if (sex) pol1 = "men";
	else pol1 = "women";
	cout << "Name: " << name << "\t Age: " << age << "\t Sex: " << pol1 << endl;

}