#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

struct TNode {
    int key;
    TNode *left, *right;
};

typedef TNode* TREE;

// Cai nay xu ly tao cay
TREE CreateTree(vector<int> pre, vector<int> in, int preB, int preE, int inB, int inE) {
	int i;
	TREE root;
	if (inE < inB) return NULL;
	root = new TNode;
	if (root != NULL) {
		root->key = pre[preB];
		for (i = inB; i <= inE; i++)
			if (in[i] == pre[preB]) break;
		root->left = CreateTree(pre, in, preB+1, preE, inB, i - 1);
		root->right = CreateTree(pre, in, preB+i-inB+1, preE, i+1,inE);
	} return root;
}

void Input(vector<int> &v)
{
	int tmp;
	cin >> tmp;
	while (tmp > 0) {
		v.push_back(tmp);
		cin >> tmp;
	}
}

//Write code here
// Idea: Chỉ cần tính chiều cao của con trái của root và con phải của root rồi so sánh thôi
int heightOfNode (TNode* node) {
	if (node == NULL) return 0;
	return 1 + max(heightOfNode(node->left), heightOfNode(node->right));
}

void Fun (TREE root) {
	if (root == NULL) cout << "Empty Tree.";
	if (heightOfNode(root->left) < heightOfNode(root->right)) cout << "1";
	else if (heightOfNode(root->left) > heightOfNode(root->right)) cout << "-1";
	else cout << "0";
}

int main() {
	freopen ("TK_CayNhiPhan.inp", "r", stdin);
	freopen ("TK_CayNhiPhan.out", "w", stdout);
    vector<int> duyetNLR;
    vector<int> duyetLNR;
    Input(duyetNLR);
    Input(duyetLNR);
    int Num=duyetNLR.size()-1;
    TREE root = CreateTree(duyetNLR, duyetLNR, 0, Num, 0, Num);
    Fun(root);
    return 0;
}