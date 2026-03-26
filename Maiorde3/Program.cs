internal class Program
{
    private static void Main(string[] args)
    {
        List<double> listNumero = new List<double>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o {i+1}° número: ");
                                  
            string? num = Console.ReadLine();
            double numeroInformado;

            while (!double.TryParse(num, out numeroInformado))
            {
                Console.Write("Número inválido. Tente novamente: ");
                num = Console.ReadLine();
            }

            listNumero.Add(numeroInformado);
        }

        listNumero.Reverse();
        double? maiorNumero = listNumero.First();

        //foreach (double numero in listNumero)
        //{
        //    if (numero > maiorNumero)
        //    {
        //        maiorNumero = numero;
        //    }

        //}


        Console.WriteLine($"O maior número dos três digitados é {maiorNumero}");
        Console.ReadLine();
    }
}