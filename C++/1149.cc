#include <iostream>
using namespace std;

int main()
{
    long long a, n, soma=0, i;
    cin >> a;
    do{
        cin >> n;
    }while(n<=0);

    for(i=0;i<=n-1;i++){
        soma += a+i;
    }
    cout << soma << endl;

    return 0;
}
