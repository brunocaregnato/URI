#include <iostream>
using namespace std;

int main()
{
    long long a, n, nmrs=1, i=0;
    cin >> a;
    do{
        cin >> n;
    }while(n<=a);

    i = a;
    while(true){
        nmrs++;
        if(a+i > n) break;
        a += ++i;

    }
    cout << nmrs << endl;

    return 0;
}
