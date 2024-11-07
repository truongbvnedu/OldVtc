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
struct LinkedList3
{
    LinkedList* Listsum = new LinkedList;
    Element* head = nullptr;
    Element* tail = nullptr;

};
LinkedList3* Lsum = new LinkedList3;
int cout = 0;
void InsertFirst(LinkedList* L, Element* p) {
    if (L->head == nullptr) L->head = L->tail = p;
    else
    {
        p->pointer = L->head;
        L->head = p;
    }
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
void PrintListsum(LinkedList3* L) {
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
void createbangsum(LinkedList3* Lsum, int value) {
    Element* newElement = new Element;
    newElement->data = value;
    newElement->pointer = nullptr;
    if (Lsum->head == nullptr) {
        Lsum->head = Lsum->tail = newElement;
    }
    else {
        Lsum->tail->pointer = newElement;
        Lsum->tail = newElement;
    }
    cout++;
}
void sumlist(LinkedList* L, LinkedList2* L2) {
    Element* p = L->head;
    Element* p2 = L2->head;
   
    while (p != nullptr)
    {
        createbangsum(Lsum,p->data);
        p = p->pointer;
    }
    while (p2 != nullptr)
    {
        createbangsum(Lsum, p2->data);
        p2 = p2->pointer;
    }
}
void softsum(LinkedList3* Lsum) {
    Element* p = Lsum->head;
    Element* p2 = Lsum->head->pointer;
    while (p!=nullptr)
    {
        for (int i = 1; i <= cout; i++) {
            if (p->data > p2->data)
            {
                int tam;
                p->data = tam;
                p->data = p2->data;
                p2->data = tam;
                p2->pointer;
            }
        }
        p = p->pointer;
    }
}
int main()
{
    int i = 0;
    LinkedList* L = new LinkedList;
    Element* e = new Element;
    while (i!=5)
    {
        i++;
      std::cout << "\n nhap gia tri bang 1 :";
        e = new Element;
        std::cin >> e->data;
        InsertFirst(L, e);      
    } 
    LinkedList2* L2 = new LinkedList2;
    Element* e2 = new Element;
    i = 0;
    while(i!=5)
    {   
       
        i++;
        std::cout << "\n nhap gia tri bang 2 :";
        e2 = new Element;
        std::cin >> e2->data;
        Insertbang2(L2, e2);

    } 
    system("cls");
    PrintList(L);
    std::cout << "\n";
    inbang2(L2);
    sumlist(L, L2);
    softsum(Lsum);
    std::cout << "\n";
    PrintListsum(Lsum);  
}
