using System;
using System.Runtime.CompilerServices;

Program p = new Program();
int torre1 = 1;
int torre2 = 2;
int torre3 = 3;
int n = 4;
hanoi(n, torre1, torre3, torre2);

static void hanoi (int n, int ori, int des, int aux)
{
    if (n == 1)
    {
        Console.WriteLine("Mueva el disco " + n + 
            " desde la torre " + ori + " hasta la torre " + des);
        return;
    }
    hanoi(n - 1, ori, aux, des);
    Console.WriteLine("Mueva el disco " + n +
            " desde la torre " + ori + " hasta la torre " + des);
    hanoi(n - 1, aux, des, ori);
}
