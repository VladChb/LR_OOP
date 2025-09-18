

#include "Person.h" 

int main()
{
    Person lud;
    Person* lud1;
    lud1 = new Person;
    Person Spis[2];
    lud.setPerson("Zahar", 100, true);
    lud1->setPerson("Anna", 12, false);
    lud1->printPerson();
    lud.printPerson();
    lud1->~Person();
    lud.~Person();
    Spis[0].~Person();
    Spis[1].~Person();
    return 0;
}
