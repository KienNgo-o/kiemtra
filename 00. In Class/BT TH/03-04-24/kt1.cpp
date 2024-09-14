/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
###End banned keyword*/

#include <iostream>

using namespace std;
#define MAXN 150000

void NhapMang(int A[], const int N) {
    for (int i = 0; i < N; i++)
        std::cin >> A[i];
}

//###INSERT CODE HERE -
void ChenTang(int x, int a[], int &n)
{
    if (n == 0) {
        a[0] = x;
        n++;
        return;
    }
    if (x > a[n-1]) {
        a[n] = x;
        n++;
        return;
    }
    for (int i = n - 1; i >= 0; i--) {
        if (a[i] >= x) {
            a[i+1] = a[i];
        } else {
            a[i+1] = x;
            n++;
            return;
        }
    }
    a[0] = x;
    n++;
}

void XuatMang(int A[], const int N) {
    for (int i = 0; i < N; i++)
        std::cout << A[i] << " ";
}

int main() {
    int a[MAXN];
    int x; cin >> x;
    int n; cin >> n;

    NhapMang(a, n);

    ChenTang(x, a, n);

    XuatMang(a, n);

    return 0;
}

