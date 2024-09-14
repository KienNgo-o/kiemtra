/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
###End banned keyword*/

#include <iostream>
using namespace std;

struct TNODE {
	int key;
	TNODE* pLeft;
	TNODE* pRight;
};
typedef TNODE* TREE;

//###INSERT CODE HERE -
TNODE* CreateNode(int x) {
    TNODE* p = new TNODE;
    if (p == NULL) exit(1);
    p->key = x;
    p->pLeft = NULL;
    p->pRight = NULL;
    return p;
}

int Insert(TREE &T, int x) {
    if (T != NULL) {
        if (T->key == x) return 0;
        if (x < T->key) return Insert(T->pLeft, x);
        else return Insert(T->pRight, x);
    }
    T = CreateNode(x);
    return 1;
}

void CreateTree(TREE& T) {
    int x;
    do {
        cin >> x;
        if (x == -1) break;
        Insert(T, x);
    } while(1);
}

int SumNode(TREE T) {
    if (T == NULL) return 0;
    return T->key + SumNode(T->pLeft) + SumNode(T->pRight);
}

int main() {
	TREE T; //hay: TNODE* T;
	T = NULL; // Khoi tao cay T rong, or: CreateEmptyTree(T)
	CreateTree(T);
	cout << SumNode(T);
	return 0;
}

