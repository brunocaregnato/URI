#include <iostream>			/// cin/cout

using namespace std;

int main() {
    int h1, m1, h2, m2, horaIni, horaFim;
    while(true){
        cin >> h1 >> m1 >> h2 >> m2;
        if(h1 == 0 && m1 == 0 && h2 == 0 && m2 == 0) break;
        else{
            if(h1 == 0) horaIni = 24*60+m1;
            else horaIni = h1*60+m1;

            if(h2 == 0) horaFim = 24*60+m2;
            else horaFim = h2*60+m2;

            if(horaFim>horaIni) cout << horaFim-horaIni << endl;
            else cout << 24*60 - (horaIni-horaFim) << endl;
        }
    }
    return 0;
}

