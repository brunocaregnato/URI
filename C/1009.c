#include <stdio.h>
#include <stdlib.h>
 
int main() {
 
    char vendedor[20];
    double salario, vendas, bonus;
    
    scanf("%s %lf %lf",vendedor, &salario, &vendas);
    bonus = vendas * 0.15;
    salario += bonus;
    
    printf("TOTAL = R$ %.2lf\n", salario);
 
    return 0;
}