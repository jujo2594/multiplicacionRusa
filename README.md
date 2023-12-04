# Ejercicio 2:

El método de multiplicación rusa consiste en multiplicar sucesivamente por 2 el multiplicando y  dividir por 2 el multiplicador hasta que el multiplicador tome el valor 1. Luego, se suman todos los multiplicandos correspondientes a los multiplicadores impares. Dicha suma es el producto de los dos números. La siguiente tabla muestra el cálculo realizado para  multiplicar 37 por 12, cuyo resultado final es 12 + 48 + 384 = 444.

Desarrolle un programa que reciba como entrada el multiplicador y el multiplicando, y entregue  como resultado el producto de ambos, calculado mediante el método de multiplicación rusa.



```c#
 Console.WriteLine("Ingrese el multiplicador");
        int multiplicador = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el multiplicando");
        int multiplicando = int.Parse(Console.ReadLine());
        List<int> ListMultiplicador = [multiplicador];
        List<int> ListMultiplicando = [multiplicando];
        int final = 0;
        for(int i = 0; i <= ListMultiplicador.Count + 1; i++ )
        {
                int result = ListMultiplicador[i]/ 2;
                int result2 = ListMultiplicando[i]*2;
                if(result >= 1)
                {
                    ListMultiplicador.Add(result);
                    ListMultiplicando.Add(result2);
                    if(ListMultiplicador[i] % 2 !=0)
                    {
                        final += ListMultiplicando[i];
                    }
                }
                else{
                    break;
                }
```



