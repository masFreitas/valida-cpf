using System;

namespace ValidaCPF
{
    class Program
    {
        //Foi solicitado a criação de um programa que faça a validação de CPF. Com isso desenvolva um programa que leia um CPF (apenas os dígitos) e escreva o CPF e se ele é válido ou não. Para ajudar, um link: https://www.somatematica.com.br/faq/cpf.php
        static void Main(string[] args)
        {
            int [] verifica1 = new int[9] {10, 9, 8, 7, 6, 5, 4, 3, 2};
            int [] verifica2 = new int[10] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            int soma, resto, i;
            string cpf, cpfTemp, digito, cpfValido;

            Console.Write("Digite um CPF: ");
            cpf = Console.ReadLine();

            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF {0} é inválido", cpf);
            }
            else if (cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
            {
                Console.WriteLine("CPF {0} é inválido", cpf);
            }
            else
            {
                cpfTemp = cpf.Substring(0,9);
                soma = 0;

                for (i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpfTemp[i].ToString()) * verifica1[i];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                cpfTemp = cpfTemp + digito;
                soma = 0;

                for (i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpfTemp[i].ToString()) * verifica2[i];
                }

                resto = soma % 11;
                
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                cpfValido = cpfTemp + digito;

                if (cpfValido == cpf)
                {
                    Console.WriteLine("CPF {0} é válido", cpfValido);
                }
                else
                {
                    Console.WriteLine("CPF {0} é inválido", cpf);
                }
                       
            }
            
        }
    }
}
