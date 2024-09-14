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
TNODE* CreateTreeNode (int x) {
    TNODE* p = new TNODE;
    if (p == NULL) exit(1);
    p->key = x;
    p->pLeft = NULL;
    p->pRight = NULL;
    return p;
}

int Insert(TREE& T, int x) {
    if (T != NULL) {
        if (x == T->key) return 0;
        if (x > T->key) return Insert(T->pRight, x);
        return Insert(T->pLeft, x);
    }
    T = CreateTreeNode(x);
    return 1;
}

void CreateTree(TREE& T) {
    int x;
    do {
        cin >> x;
        if (x == -1) break;
        Insert(T, x);
    } while (true);
}

TNODE* FindMin(TREE Root) {
    if (Root != NULL) {
        if (Root->pLeft != NULL) return FindMin(Root->pLeft);
        return Root; 
    }
    return NULL;
}

int main() {
	TREE T; //hay: TNODE* T;
	T = NULL; // Khoi tao cay T rong, or: CreateEmptyTree(T)
	CreateTree(T);

	if(T==NULL) cout << "Empty Tree.";
	else cout << FindMin(T)->key;
	return 0;
}
