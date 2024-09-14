/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
define
include
###End banned keyword*/
#include <iostream>
#include <vector>
#include <map>



using namespace std;

struct TNode {
    int key;
    TNode * left, * right;
};

typedef TNode * TREE;

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


int MaxLevel(TREE);

int main() {

    vector<int> nlr, lnr;
    int n, key, m, lvl;

    Input(nlr);
    Input(lnr);


    TREE r = CreateTree(nlr, lnr, 0, nlr.size()-1, 0, lnr.size()-1);

    cout << MaxLevel(r) << endl;

    return 0;
}

	
//###INSERT CODE HERE -
// Bai ni ko co test case, nop moi biet dung hay sai
int level[100000];

int heightOfTree(TREE T) {
    if (T == NULL) return -1;
    return 1 + max(heightOfTree(T->left), heightOfTree(T->right));
}

int calLevel(TREE T, int height) {
    (T == NULL) return -1;
    int h =  1 + max(calLevel(T->left, height), calLevel(T->right, height));
    level[height-h] += T->key;
    return h;
}

int MaxLevel(TREE T) {
    int height = heightOfTree(T);
    int h = calLevel(T, height);
    int ans = 0;
    for (int i = 0; i <= height; i++) 
        if (level[ans] < level[i]) ans = i;
    return ans;
}