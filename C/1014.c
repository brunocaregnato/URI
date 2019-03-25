#include <stdio.h>
 
int main() {
 
    int X;
    double Y;
    scanf("%d %lf", &X, &Y);
    
    double media = 0;
    media = X/Y;
    
    printf("%.3lf km/l\n",media);
    
    return 0;
}