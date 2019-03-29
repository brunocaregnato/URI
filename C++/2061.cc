#include <iostream>

using namespace std;

int main()
{
    
    int abas, acoes, i=0;
    char acao[6];
    scanf("%d %d", &abas, &acoes);
    
    for(;i<acoes;i++){
        scanf("%s",acao);
        if(acao[0] == 'f'){
            abas++;
        }
        else{
            abas--;
        }
    }
    
    cout<< abas << endl;

    return 0;
}

