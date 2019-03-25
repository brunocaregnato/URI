#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main()
{
    int N;
    char linha[1002];
    int i, j, tamanho, metade, aux;

    fgets(linha, 10, stdin);
    sscanf(linha, "%d", &N);

    for (i = 0; i < N; ++i) {
        fgets(linha, 1001, stdin);

        tamanho = strlen(linha) - 1;
        metade = tamanho / 2;
        linha[tamanho] = '\0';

        for (j = 0; j < tamanho; ++j) {
            if (isalpha(linha[j]))
                linha[j] += 3;
        }

        for (j = 0; j < metade; ++j) {
            aux = linha[j];
            linha[j] = linha[tamanho - 1 - j];
            linha[tamanho - 1 - j] = aux;
        }

        for (j = metade; j < tamanho; ++j)
            linha[j] -= 1;

        puts(linha);
    }

    return 0;
}