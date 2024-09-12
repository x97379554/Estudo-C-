using System;

namespace ClassificacaoTemperatura
{
    class Program
    {

        static void Main(string[] args)
        {
            //Temperatura();
            //Desconto();
            //Impostos();
            Bissexto();
        }
        private static void Temperatura()
        {
            /*
                Classificação de Temperatura: Escreva um programa que receba a temperatura
                emgraus Celsius do usuário e informe a categoria de clima:
                ○ "Frio" para temperaturas abaixo de 10°C.
                ○ "Ameno" para temperaturas entre 10°C e 25°C.
                ○ "Quente" para temperaturas acima de 25°C. Além disso, informe se a
                temperatura está "Perigosa" se for maior que 40°C.
                */
            Console.WriteLine(
                "Digite a temperatura em graus Celsius: "
            );
            double temperatura = double.Parse(Console.ReadLine());

            if (temperatura > 33)
            {
                Console.WriteLine("Perigoso");

            }
            else if (temperatura > 25)
            {
                Console.WriteLine("Quente");
            }
            else if (temperatura > 10)
            {
                Console.WriteLine("Ameno");
            }
            Console.WriteLine(temperatura);

        }

        private static void Desconto()
        {
            /*
              Desconto por Faixa Etária: Desenvolva um programa que peça ao usuário sua
                 idade e o valor total de uma compra. Aplique os seguintes descontos baseados na
                 faixa etária:
                 ○ 20%paramaiores de 65 anos.
                 ○ 15%parapessoas entre 18 e 64 anos.
                 ○ 10%paramenores de 18 anos. Exiba o valor final com o desconto aplicado
             */
            Console.WriteLine(
"Digite sua idade: "
            );
            int idade = int.Parse(Console.ReadLine());

           Console.WriteLine(
"Digite o valor total da compra: "
            );
            int valor = int.Parse(Console.ReadLine());

            if (valor > 64)
            {
                Console.WriteLine(
$"Valor final com desconto de 20%: {valor - (valor * 0.20)}"
                );
            }
            else if (valor > 18 && valor < 65)
            {
                Console.WriteLine($"O valor final de com desconto de 15 % {valor - (valor * 0.15)}");
            }
            else if (valor < 18)
            {
                Console.WriteLine($"Valor final com desconto de 10%: {valor - (valor * 0.10)}");
            }
            Console.WriteLine(valor);
        }

        private static void Impostos()
        {
            /*
              Calculadora de Imposto: Crie um programa que receba o salário bruto de um
             usuário e calcule o imposto a ser pago com base nas seguintes faixas:
             ○ 0%parasalários até R$2.000,00.
             ○ 10%parasalários entre R$2.000,01 e R$5.000,00.
             ○ 20%parasalários acima de R$5.000,00. Exiba o valor do imposto a ser pago
             e osalário líquido após o desconto.
            Faixa	Base de Cálculo (R$)	Alíquota (%)
            2ª	De 2.259,21 até 2.826,65	7,5
            3ª	De 2.826,66 até 3.751,05	15
            4ª	De 3.751,06 até 4.664,68	22,5
            5ª	Acima de 4.664,68	27,5
             */
            
            Console.WriteLine("Digite seu salário  ");
            double salario = double.Parse(Console.ReadLine());
            double imposto = 7.5 * (salario);
            Console.WriteLine(
                $"Valor do imposto: {imposto}\n Salario liquido: {salario - imposto}");
            
        }
        private static void Bissexto()
        {
            /*
              Determinação de Ano Bissexto: Escreva um programa que peça ao usuário um
                 ano e determine se é um ano bissexto. Um ano é bissexto se:
                 ○ Édivisível por 4, mas não por 100, ou
                 ○ Édivisível por 400. Informe se o ano é bissexto ou não
             */
            Console.WriteLine("Digite o ano ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine(
                (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0 ? "Ano bissexto" +
                "Por que Só vai até  366 dias" : "Ano não bissexto" +
                "Por que Só vai até  365 dias");
           
        }
        private static void frete() {
            /*
             Calculadora de Frete de Envio: Desenvolva um programa que receba o peso do
             pacote (em kg) e a distância do envio (em km). Aplique a seguinte tabela de frete:
             ○ Até5kg:R$10,00 por kg.
             ○ Acimade5kgeaté10kg: R$8,00 por kg.
             ○ Acimade10kg: R$6,00 por kg. Além disso, aplique um adicional de 5%
             sobre o valor total se a distância for maior que 500 km. Exiba o custo total do
             frete.
             */
            Console.WriteLine("Digite o preço do produto  ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Preco de produto ");



        }
    }

}
