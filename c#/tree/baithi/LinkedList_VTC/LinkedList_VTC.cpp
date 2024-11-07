#include <iostream>
#include "stdio.h"
#include <cstdlib>
struct Element {
    int data;
    Element* pointer = nullptr;
};
struct LinkedList
{
    Element* head = nullptr;
    Element* tail = nullptr;

};
struct LinkedList2
{
    LinkedList* List = new LinkedList;
    Element* head = nullptr;
    Element* tail = nullptr;

};
void hapxapsep(LinkedList* chan, LinkedList* le,LinkedList* L, LinkedList2* L2 ) {
    Element* p = L->head;
    Element* p2 = L2->head;
    if (p != nullptr) {
        if (p->data % 2 == 0) {
            InsertFirst(chan, p);
            p = p->pointer;
        }
        else
        {
            InsertFirst(le, p);
            p = p->pointer;
        }
    }
    if (p2 != nullptr) {
        if (p2->data % 2 == 0) {
            InsertFirst(chan, p2);
            p2 = p2->pointer;
        }
        else
        {
            InsertFirst(le, p2);
            p2 = p2->pointer;
        }
    }


}
void InsertFirst(LinkedList* L, Element* p) {
    if (L->head == nullptr) L->head = L->tail = p;
    else
    {
        p->pointer = L->head;
        L->head = p;
    }
}
void nhapbang1(LinkedList* L) {
    Element* d = new Element;
    do
    {
        d = new Element;
        std::cout << "\nnhap du lieu bao bang 1 nhap -1 de end: ";
        std::cin >> d->data;
        if (d->data != -1)
            InsertFirst(L, d);
    } while (d->data != -1);
}
void nhapbang2(LinkedList2* L2) {
    Element* d = new Element;
    do
    {
        d = new Element;
        std::cout << "\nnhap du lieu bao bang 2 nhap -1 de end: ";
        std::cin >> d->data;
        if (d->data != -1)
            Insertbang2(L2,d);
    } while (d->data != -1);
}
void Insertbang2(LinkedList2* L2, Element* p) {
    if (L2->head == nullptr) L2->head = L2->tail = p;
    else
    {
        p->pointer = L2->head;
        L2->head = p;
    }
}
void PrintList(LinkedList* L) {
    Element* p = L->head;
    while (p != nullptr) {
        std::cout << p->data << " ";
        p = p->pointer;
    }
}
void inbang2(LinkedList2* L2) {
    Element* p = L2->head;
    while (p != nullptr) {
        std::cout << p->data << " ";
        p = p->pointer;
    }
}
int main()
{
    LinkedList* chan = new LinkedList;
    LinkedList* le = new LinkedList;
    LinkedList2* L2 = new LinkedList2;
    LinkedList* L = new LinkedList;
    nhapbang1(L);
    system("cls");
    nhapbang2(L2);
    system("cls");
    hapxapsep(chan, le, L, L2);
    PrintList(L);
    inbang2(L2);

    
    
}
