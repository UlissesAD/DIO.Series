using System;

namespace DIO.Series
{
    class Program
    {
        static SeriesOption Series = new SeriesOption();
		 static FilmesOptions Filmes = new FilmesOptions();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Series.Main();
                        break;
                    case "2":
                        Filmes.Main();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem Vindo!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Acessar séries");
            Console.WriteLine("2- Acessar filmes");
            Console.WriteLine();

            string opcaoUsuario = Read().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string Read()
        {
            return Console.ReadLine();
        }
    }
}


