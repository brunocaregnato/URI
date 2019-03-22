#include <stdio.h>

int main() {

    int numeroFunc, hrsTrab;
    double vlrHora, salario;
    scanf("%d %d %lf",&numeroFunc, &hrsTrab, &vlrHora);

    salario = hrsTrab * vlrHora;

    printf("NUMBER = %d\nSALARY = U$ %.2lf\n",numeroFunc,salario);

    return 0;
}
