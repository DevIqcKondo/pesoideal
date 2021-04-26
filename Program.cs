using System;

namespace pesoideal
{
    class Program
    {
        static void Main(string[] args)
        {
            double m=0;
            double a=0;
            double imc=0;
            char sexo;

            Console.WriteLine("---------------");
            Console.WriteLine("Calculando IMC!");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write("Digite seu peso em kg: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            m=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write("Digite sua altura em metros: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            a=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write("Informe seu sexo usando F para feminino ou M para masculino: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            sexo=Convert.ToChar(Console.ReadLine());
            Console.ResetColor();

            imc= Math.Round(m/(a*a),2);



            

            if(imc<17){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Diagnóstico: Muito abaixo do peso.");
                Console.ResetColor();

            }else if (imc>=17.00&&imc<=18.49){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Abaixo do peso.");
                Console.ResetColor();

            }else if (imc>=18.50&&imc<=24.99){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Peso normal.");
                Console.ResetColor();

            } else if (imc>=25.00&&imc<=29.99){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Acima do peso.");
                Console.ResetColor();

            } else if (imc>=30.00&&imc<=34.99){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Obesidade 1.");
                Console.ResetColor();

            } else if(imc>=35.00&&imc<=39.99){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Obesidade 2 (severa).");
                Console.ResetColor();

            } else if (imc>=40.00){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Obasidade 3 (mórbida).");
                Console.ResetColor();

            }
            Console.Beep();
        }
    }
}
