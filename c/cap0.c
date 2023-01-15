/**
 * Receba via teclado um número X, onde este número representa a quantidade de termos que o usuário desena.
 * n representa cada um desses números, calcule a média dos X números.
 * ps: n deve ser múltiplo de 7.
 **/

#include <stdio.h>

#ifdef exer1
#define ex1
int main()
{
    int x, n, aux = 0;
    float aux1;
    do
    {
        printf("Informe a quatidade de termos que será tratada:");
        scanf("%i", &x);

    } while (x <= 0);

    for (size_t i = 0; i < x; i++)
    {
        n = 0;
        do
        {
            printf("Informe os valores que terão a média calculada\nPS: Os valores devem ser múltipĺos de 7...\n");
            scanf("%i", &n);

        } while (n % 7 != 0);

        aux += n;
    }
    aux1 = aux / x;
    printf("A média dos valores escritos é %i", aux1);
}
#endif

#ifdef exer2
#define ex2
/** Receba K números inteiros quaisquer, K representa a quantidade de termos solicitada pelo usuário e
 * cada termo pode ser representado pela variável N. Exiba a quantidade de números
 * positivos e múltiplos de 5 e a média dos números ímpares.**/
int main()
{
    int k, n, aux = 0, aux1 = 0, aux2 = 0, aux3 = 0, aux4 = 0;

    do
    {
        printf("Informe a quatidade de termos que será tratada:");
        scanf("%i", &k);

    } while (k < 0);

    if (k == 0)
    {
        printf("Você tratará nenhum termo, então o código parará a execução....");
    }
    else
    {
        printf("Informe os valores que terão a média calculada\nPS: Os valores devem ser múltipĺos de 7...\n");
        for (size_t i = 0; i < k; i++)
        {
            n = 0;
            do
            {
                scanf("%i", &n);
                if (n % 7 == 0)
                {
                    if (n > 0)
                    {
                        aux++;
                    }
                    if (n % 2 != 0)
                    {
                        aux1++;
                        aux2 += n;
                    }
                }
                else
                {
                    printf("%i não é multiplo de 7, tente novamente\n", n);
                }
            } while (n % 7 != 0);
        }
        aux4 = aux2 / aux1;
        printf("A média dos valores ímpares que foram escritos é %i \n", aux4);
        printf("A quantidade de números positivos é %i \n", aux);
    }
}
#endif

#ifdef exer3
#define ex3
/**Receba a quantidade de salários de K indivíduos. K representa essa quantidade e deve ser digitada pelo usuário. A variável Salário armazena cada uma dos K salários digitados. Calcule e mostre a somatória dos salários superiores a 3 salários-mínimos e inferior ou igual a 7 salários-mínimos. Exiba também o maior salário encontrado. Obs. Pesquise na Internet o valor do salário-mínimo atual e defina como uma constante no programa.**/
int main()
{
    float s, auxS, somatoria1, somatoria2;
    int k;
    const int SMINIMO = 1212;

    do
    {
        printf("Informe a quatidade de termos que será tratada:\n");
        scanf("%i", &k);

    } while (k < 0);

    if (k == 0)
    {
        printf("Você tratará nenhum termo, então o código parará a execução....\n\n");
    }
    else
    {
        printf("Por favor informe os salários...\n");
        for (size_t i = 0; i < k; i++)
        {
            s = 0;
            do
            {
                scanf("%f", &s);
                if (s != 0 && s > 0)
                {
                    if (s > SMINIMO * 3)
                    {
                        somatoria1 += s;
                    }
                    if (s <= SMINIMO * 7)
                    {
                        somatoria2 += s;
                    }
                    if (s > auxS)
                    {
                        auxS = s;
                    }
                }
                else
                {
                    printf("Um salário não pode ser menor ou igal a zero....\n", n);
                }
            } while (k % 7 != 0);
        }
    }
    printf("A somatória de salários que são superiores à três salários-mínimos é: %f\n", somatoria1);
    printf("A somatória de salários que são inferioes ou igual à sete salários-mínimos é: %f\n", somatoria2);
    printf("O maior salário inserido foi: %f", auxS);
}

#endif
