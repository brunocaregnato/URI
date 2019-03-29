#include <iostream>
using namespace std;

int main()
{
    long long nmr,i;
    while(cin >> nmr && nmr > 0){
        for(i=1; i<=nmr; i++){
            if (i > 1) cout << " ";
            cout << i;
        }
        cout << endl;
    }

    return 0;
}