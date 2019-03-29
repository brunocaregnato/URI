#include <iostream>

using namespace std;

int main() {

    int inter, gremio, resp, qtdGrenais = 0, vitGremio = 0, vitInter = 0, empates=0;

    while(true){

        cin >> inter >> gremio;
        qtdGrenais++;
        if(inter>gremio) vitInter++;
        else if(gremio>inter) vitGremio++;
        else empates++;
        cout << "Novo grenal (1-sim 2-nao)\n";
        cin >> resp;
        if(resp==2) break;
    }
    cout << qtdGrenais << " grenais\nInter:" << vitInter << "\nGremio:" << vitGremio << "\nEmpates:" << empates << endl;
    if(vitInter>vitGremio) cout << "Inter venceu mais" << endl;
    else if(vitGremio>vitInter) cout << "Gremio venceu mais" << endl;
    else cout << "Nao houve vencedor" << endl;

    return 0;
}
