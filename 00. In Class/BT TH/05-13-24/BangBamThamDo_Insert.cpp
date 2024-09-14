/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
define
include
###End banned keyword*/
#include <iostream>
#include <string>

#define LOAD 0.7
#define EMPTY 0
#define DELETE -1
using namespace std;

struct Hocsinh {
    int Maso;
    string Hoten;
    int Namsinh;
    bool Gioitinh;
    double TBK;
};

struct Hashtable {
    int M; // Kich thuoc bang bam
    int n; // so phan tu trong bang bam
    Hocsinh *table;
};

void CreateHashtable(Hashtable &, int);
int Insert(Hashtable &, Hocsinh);
void PrintHashtable(Hashtable);
void DeleteHashtable(Hashtable &);

void Input(Hocsinh &x) {
    cin >> x.Maso;
    getline(cin>>ws, x.Hoten);
    cin >> x.Namsinh;
    cin >> x.Gioitinh;
    cin >> x.TBK;
}
int main()
{
    Hashtable hashtable;

    int m, n;
    Hocsinh hs;

    cin >> m;
    CreateHashtable(hashtable, m);
    cin >> n;
    for (int i = 0; i < n; i++) {
        Input(hs);
        Insert(hashtable, hs);
    }
    PrintHashtable(hashtable);
    DeleteHashtable(hashtable);
    return 0;
}

void CreateHashtable(Hashtable &ht, int m) {
    ht.table = new Hocsinh[m];
    if (ht.table == NULL)
        exit(1);
    for (int i = 0; i < m; i++) {
        ht.table[i].Maso = EMPTY;
    }
    ht.M = m;
    ht.n = 0;
}

void PrintHashtable(Hashtable ht) {
    for (int i = 0; i < ht.M; i ++) {
        Hocsinh hs = ht.table[i];
        if (hs.Maso > 0)
            cout << '[' << hs.Maso << ",  " << hs.Hoten << "  , " << hs.Gioitinh << ", " << hs.Namsinh << ", " << hs.TBK << "]\n";
        else
            cout << "[" << hs.Maso <<  ",  " << "  , " << ", " << ", " << "]\n";
    }
}
void DeleteHashtable(Hashtable &ht) {
    delete [] ht.table;
    ht.table = NULL;
    ht.M = 0;
}

int Insert(Hashtable &ht, Hocsinh x) {


//###INSERT CODE HERE -
    ht.n++;
    if ((float)ht.n / ht.M > LOAD) return 0;
    int key = x.Maso % ht.M;
    if (ht.table[key].Maso == EMPTY) {
        ht.table[key] = x;
    } else {
        int i = 1;
        int h_key;
        do {
            h_key = (key + i++) % ht.M;
            if (ht.table[h_key].Maso == DELETE) break;
        } while (ht.table[h_key].Maso != EMPTY && i <= ht.M);
        if (i > ht.M) return 0;
        ht.table[h_key] = x;
    }
    return 1;
}