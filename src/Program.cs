using System;
using GFT.src;
using static System.Console;

namespace GFT.src
{
    class Program
    {
        static bool VerificaLetra(string letra){
            letra.ToUpper();

            if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            StructPessoa[] pessoas = new StructPessoa[10];
            int qtdIdade50 = 0; int qtdPorcentagem = 0; int i;
            float media = 0, porcentagem = 0;

            for (i = 0; i < 10; i++)
            {
                pessoas[i].Idade = int.Parse(ReadLine());
                pessoas[i].altura = float.Parse(ReadLine());
                pessoas[i].peso = float.Parse(ReadLine());

                if (pessoas[i].Idade > 50)
                {
                    qtdIdade50++;
                }

                if (pessoas[i].Idade >= 10 && pessoas[i].Idade <= 20)
                {
                    media += pessoas[i].altura;
                }

                if (pessoas[i].peso < 40)
                {
                    qtdPorcentagem++;
                }
            }

            media = media / i;

            porcentagem = (qtdPorcentagem/i)*100;

            WriteLine($@"
            Quantidade de pessoas com idade superior a 50: {qtdIdade50}
            A média das Alturas das pessoas com idade entre 10 e 20 anos {media}
            A porcentagem das pessoas com peso inferior a 40 quilos {porcentagem}
            ");

            ///////////////////////////////////////////////////////////////////////

            double valorTotal, valorPago, valor;
            double[] CedulasMoedas = {100,50,20,10,5,2,1,0.5,0.1,0.05,0.01};
            double total;

            WriteLine($"Digite o valor total a ser pago:");
            valorTotal = double.Parse(ReadLine());
            WriteLine("");
            WriteLine($"Digite o valor pago:");
            valorPago = double.Parse(ReadLine());

            valor = valorTotal - valorPago;

            WriteLine($"O troco irá ter: ");
            
            for(int j = 0; j < 11; j++){
                total = valor / CedulasMoedas[j];

                if (j < 7 )
                {
                    WriteLine($"{total} nota(s) de R$ {CedulasMoedas[j]},00");
                }else if (j > 7)
                {
                    WriteLine($"{total} moedas(s) de R$ {CedulasMoedas[j]}");
                }
                 valor %= CedulasMoedas[j];
            }

            ///////////////////////////////////////////////////////////////////////

            string Letra;

            Letra = ReadLine();

            if (VerificaLetra(Letra))
            {
                WriteLine($"A letra digitada é Vogal");
            }else
            {
                WriteLine($"A letra digitada é Consoante");
            }

        }
    }
}
