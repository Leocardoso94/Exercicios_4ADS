using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //exercicio1();
        //exercicio2();
        //exercicio3();
        //exercicio4(10);
        //exercicio8(3);
        //exercicio9(5);
        exercicio10();
    }

    public static void exercicio1()
    {
        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }

        Console.WriteLine(soma);
    }

    public static void exercicio2()
    {
        for (int i = 1; i <= 200; i++)
        {
            if (i % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void exercicio3()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static double exercicio4(int x)
    {
        double s = 0;

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                s -= x / i;
            }
            else
            {
                s += x / i;
            }
        }

        Console.WriteLine(s);

        return s;
    }
    public static void exercicio8(int qtd)
    {
        ArrayList ar = new ArrayList();
        double media = 0;
        int soma = 0;
        int i = 0;
        while (i < qtd)
        {
            Console.WriteLine("informe uma nota: ");
            string valor = Console.ReadLine();
            int nota = Convert.ToInt32(valor);
            ar.Add(nota);
            i++;
        }
        for (int j = 0; j < ar.Count; j++)
        {
            soma += Convert.ToInt32(ar[j]);
        }
        media = soma / ar.Count;
        Console.WriteLine("notas maiores que a média: " + media);
        for (int j = 0; j < ar.Count; j++)
        {
            if (Convert.ToInt32(ar[j]) > media)
            {
                Console.WriteLine(ar[j]);
            }
        }
        Console.WriteLine("notas menores que a média: " + media);
        for (int j = 0; j < ar.Count; j++)
        {
            if (Convert.ToInt32(ar[j]) < media)
            {
                Console.WriteLine(ar[j]);
            }
        }
    }
    public static void exercicio9(int numDeAlunos)
    {
        Dictionary<String, double> notaPorAluno = new Dictionary<String, double>();
        while (notaPorAluno.Count < numDeAlunos)
        {
            Console.WriteLine("Informe o nome do aluno: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Informe a nota do aluno: " + nome);
            string nota = Console.ReadLine();
            double notaConvertida = Convert.ToDouble(nota);
            notaPorAluno.Add(nome, notaConvertida);
        }
        double soma = 0;
        foreach (KeyValuePair<String, double> par in notaPorAluno)
        {
            soma += par.Value;
        }
        double media = soma / notaPorAluno.Count;
        foreach (KeyValuePair<String, double> par in notaPorAluno)
        {
            if (par.Value > media)
            {
                Console.WriteLine("Aluno: " + par.Key + ", nota: " + par.Value);
            }
        }
        Console.WriteLine("Media das notas: " + media);
    }
    public static void exercicio10()
    {
        ArrayList salarios = new ArrayList();
        double salario = 0;
        while (salario != -1)
        {
            Console.WriteLine("Informe um salário: ");
            string salarioStr = Console.ReadLine();
            salario = Convert.ToDouble(salarioStr);
            salarios.Add(salario);
        }
        Console.WriteLine("Informe o valor de reajuste: ");
        string reajusteStr = Console.ReadLine();
        double reajuste = Convert.ToDouble(reajusteStr);
        for (int i = 0; i <= salarios.Count && Convert.ToDouble(salarios[i]) != -1; i++)
        {
            Console.WriteLine("Salário reajustado: " + (Convert.ToDouble(salarios[i]) + reajuste));
        }

    }
}
