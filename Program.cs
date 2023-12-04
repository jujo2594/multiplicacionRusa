internal class Program
{
    private static void Main(string[] args)
    {
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
        }
    }
}