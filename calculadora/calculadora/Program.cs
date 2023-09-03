namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

        inicio:
            Console.Clear();


            Console.WriteLine("Digite o Primeiro numero");
            double num1;
             if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Erro: só é valido numeros, clique em alguma tecla pra tentar novamente");
                Console.ReadKey();
                goto inicio;
                
            }
            Console.WriteLine("Digite o segundo numero");

            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Erro: só é valido numeros, clique em alguma tecla pra tentar novamente");
                Console.ReadKey();
                goto inicio;

            }




            Console.WriteLine("escolha a operação (+ - x /): ");
            char operacao = char.Parse(Console.ReadLine());

            double res;

            switch (operacao)
            {
                default:
                    Console.WriteLine("operação invalida");
                    break;

                 case '+':
                    res = num1 + num2;
                    Console.WriteLine("o resultado da sua Soma é: " + res);
                    break;

                 case '-':
                    res = num1 - num2;
                    Console.WriteLine("o resultado da sua Subtração é: " + res);
                    break;

                 case 'x':
                    res = num2 * num1;
                    Console.WriteLine("o resultado da sua Multiplicação é: " + res);
                    break;

                case '/':
                    res = num2 / num1;
                    Console.WriteLine("o resultado da sua Divisão é: " + res);
                    break;

            }
            Console.WriteLine("você deseja fazer outra operação ( s / n )?");
            char continuar = char.Parse(Console.ReadLine());
            if (continuar == 's' || continuar == 'S')
            {
                goto inicio;

            } else{
                Console.WriteLine("Clique (enter) para fechar o programa ");
            }
           
            Console.ReadKey();
        }
    }
}