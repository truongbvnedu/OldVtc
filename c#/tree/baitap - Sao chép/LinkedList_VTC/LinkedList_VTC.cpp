#include "stdio.h"
#include <iostream>
#include <cmath>
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
bool kiemtrachinhphuong(int number) {
	int sqrtNum = sqrt(number);
	if (sqrtNum * sqrtNum == number)
		return true;
	else
	{
		return false;
	}
}
void xoaso(NODE*& pTree) {
	if (pTree == nullptr) {
		return;
	}
	if (kiemtrachinhphuong(pTree->Key)) {
		RemoveNode(pTree, pTree->Key);
	}

	xoaso(pTree->pLeft);
	xoaso(pTree->pRight);
}
int demsonut(NODE* node) {
	if (node == nullptr) {
		return 0;
	}
	int leftCount = demsonut(node->pLeft);
	int rightCount = demsonut(node->pRight);

	if (leftCount == rightCount) {
		std::cout << "nut ma co so nut con bang nhau co chua gia tri :" << node->Key;
	}
	return leftCount + rightCount + 1;
}
void main()
{
	NODE* pTree, * p;
	int x;
	Init(pTree);
	CreateTree(pTree);
	NLR(pTree);
	std::cout << "\n";
	xoaso(pTree);
	NLR(pTree);
	std::cout << "\n";
	demsonut(pTree);
}