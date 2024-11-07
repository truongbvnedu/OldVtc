#include "stdio.h"
#include <iostream>
int tong = 0,cunt=0,chan=0;
int minx, maxx;
struct NODE {
	int Key;
	NODE* pLeft;
	NODE* pRight;
};

void Init(NODE*& TREE)
{
	TREE = nullptr;
}void Insert(NODE*& pRoot, int x)
{
	if (pRoot == nullptr) {
		NODE* q;
		q = new NODE; q->Key = x;
		q->pLeft = q->pRight = nullptr; pRoot = q;
	}
	else
	{
		if (x < pRoot->Key)
			Insert(pRoot->pLeft, x);
		else if (x > pRoot->Key)
			Insert(pRoot->pRight, x);
	}
}
void CreateTree(NODE*& pRoot)
{
	int Data; do {
		printf("Nhap vao du lieu, -1 de ket thuc: "); std::cin >> Data;
		if (Data == -1)
			break; Insert(pRoot, Data);
	} while (1);
}
void NLR(NODE* pTree)
{
	if (pTree != nullptr)
	{
		printf("%4d", pTree->Key);
		NLR(pTree->pLeft);
		NLR(pTree->pRight);
	}
}
NODE* Search(NODE* pRoot, int x)
{
	if (pRoot == nullptr)
		return nullptr;
	if (x < pRoot->Key)
		Search(pRoot->pLeft, x);
	else
		if (x > pRoot->Key)
			Search(pRoot->pRight, x);
		else
		{
			//Ghi chú: Trong trường hợp nào dòng bên dưới được thực hiện?
			return pRoot;

		}
}
int Height(NODE* pNode)
{
	if (pNode == nullptr)
		return 0; int HL, HR;
	HL = Height(pNode->pLeft); HR = Height(pNode->pRight); if (HL > HR)
		return (1 + HL); return (1 + HR);
}
void SearchStandFor(NODE*& Tree, NODE*& q)
{
	if (Tree->pRight)
		SearchStandFor(Tree->pRight, q);
	else
	{
		q->Key = Tree->Key;
		q = Tree;
		Tree = Tree->pLeft;
	}
}
void RemoveNode(NODE*& Tree, int x)
{
	NODE* p;
	if (Tree == nullptr)
		std::cout << x <<"khong co trong cay";
	else
	{
		if (x < Tree->Key)
			RemoveNode(Tree->pLeft, x);
		else
			if (x > Tree->Key)
			{
				RemoveNode(Tree->pRight, x);
			}
			else
			{
				//Ghi chú: Mục đích phép gán này là gì?
				p = Tree;
				if (p->pRight == nullptr)
					Tree = p->pLeft;
				else
					if (p->pLeft == nullptr)
						Tree = p->pRight;
					else
					{
						SearchStandFor(Tree->pLeft, p);
					}
				delete p;
			}
	}
}
void sumtree(NODE* pTree)
{
	if (pTree != NULL)
	{
		tong = tong + pTree->Key;
		sumtree(pTree->pLeft);
		sumtree(pTree->pRight);
	}
}
void min(NODE*& pRoot) {
	NODE* p = pRoot;
	while (p->pLeft !=nullptr)
	{
		p = p->pLeft;
	}
	std::cout << "gia tri nho nhat cau cay la:" << p->Key<<"\n";
}
void max(NODE*& pRoot) {
	NODE* p = pRoot;
	while (p->pRight != nullptr)
	{
		p = p->pRight;
	}
	std::cout << "gia tri nho nhat cau cay la:" << p->Key<<"\n";
}
void counttree(NODE* pTree)
{
	if (pTree != NULL)
	{
		cunt++;
		counttree(pTree->pLeft);
		counttree(pTree->pRight);
	}
}
void demsochan(NODE* pTree) {
	if (pTree != NULL)
	{
		if (pTree->Key % 2 == 0)  chan++;
		demsochan(pTree->pLeft);
		demsochan(pTree->pRight);
	}
}
void main()
{
	NODE* pTree, * p;
	int x;
	Init(pTree);
	CreateTree(pTree);
	NLR(pTree);
	sumtree(pTree);
	std::cout << "\ntong cac gia tri trong tree la:" << tong << "\n";
	min(pTree);
	max(pTree);
	demsochan(pTree); std::cout <<"\ntong gia tri chan trong tree la:" << chan<<"\n";
	counttree(pTree); std::cout << "tong cac phan tu trong tree la:" << cunt << "\n";
	std::cout << "Nhap vao 1 gia tri de tim: ";
	std::cin >> x;
	p = Search(pTree, x);
	if (p != nullptr) {
		std::cout << x << " co xuat hien trong cay.\n", x;
		std::cout << "Chieu cao cua nut " << x << " la " << Height(p) << " \n";
		RemoveNode(pTree, x);
		NLR(pTree);
	}
	else
	{
		std::cout << x << " khong co trong cay.\n", x;
	}
}