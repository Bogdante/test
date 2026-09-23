// Изменения от напарника
using System.Numerics;

BigInteger fact(BigInteger i)
{
    if (i <= 1)
    { 
        return 1;
    }

    return i * fact(i - 1);
}

Console.WriteLine(fact(5));

// Локальное изменение
// Ещё одно локальное изменение