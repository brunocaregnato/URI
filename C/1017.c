#include<stdio.h>

int main(){

    int tempo, valor;
    float gasolina;
    
    scanf("%d %d", &tempo, &valor);

    gasolina = ((tempo * valor) / 12.0);

    printf("%.3f\n", gasolina);

    return 0;
}