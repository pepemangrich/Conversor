using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //decimal para binário
            int iBinaryNum; 
            string sDecimalNum; 
            Console.WriteLine("Coloque o número decimal que você quer converter para binário");
            iBinaryNum = Convert.ToInt32(Console.ReadLine());
            sDecimalNum = Convert.ToString(iBinaryNum, 2);
            Console.WriteLine("Convertido para binário fica: " + sDecimalNum);
            Console.ReadKey();
            //binario para decimal
            Console.WriteLine("Coloque o numero binario que deseja converter para decimal");
            sDecimalNum = Convert.ToString(Console.ReadLine());
            iBinaryNum = Convert.ToInt32(sDecimalNum, 2);
            Console.WriteLine("Convertido para decimal fica:" + iBinaryNum);
            Console.ReadKey();
            //decimal para hexadecimal
            int decimalNumber, quotient;
            int i = 1, j, temp = 0;
            char[] hexadecimalNumber = new char[100];
            char temp1;
            Console.WriteLine("Coloque o numero decimal que voce queira passar para hexadecimal:");
            decimalNumber = int.Parse(Console.ReadLine());
            quotient = decimalNumber;
            while (quotient != 0)
            {
                temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                quotient = quotient / 16;
            }
            Console.Write("Número na base hexadecimal:");
            for (j = i - 1; j > 0; j--)
                Console.Write(hexadecimalNumber[j]);
            Console.Read();
            //hexadecimal para decimal
          


        }
    }
}
