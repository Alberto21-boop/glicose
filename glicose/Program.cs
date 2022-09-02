namespace glicose;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler a quantidade de glicose no sangue de uma pessoa, e depois mostrar na tela a
        //classificação desta glicose de acordo com a tabela de referencia.

        //Tabela de referencia

        //Classificação        Glicose
        //Normal              Até 100 mg / dl

        //Elevado Maior que 100 até 140 mg / dl

        //Diabetes Maior de 140 mg / dl

        double A;

        Console.WriteLine("Digite a medida da glicose:");
        Console.Write("Glicose = ");
        A = double.Parse(Console.ReadLine());

        if(A <= 100.0)
        {
            Console.WriteLine("Classificação = Normal");
        }
        else if(A <= 140.0)
        {
            Console.WriteLine("Classificação = Elevado");
        }
        else if(A > 140.0)
        {
            Console.WriteLine("Classificação = Diabetes");
        }

    }
}