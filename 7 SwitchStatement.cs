using System.Dynamic;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####################################################");
            Console.WriteLine("                 My Basic Calculator");
            Console.WriteLine("#####################################################");

            int fv, sv, opr, result;

            Console.WriteLine("Enter First Value:");
            fv = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Value:");
            sv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#####################################################");
            Console.WriteLine("To Perform the Operation please select a number below");
            Console.WriteLine("1 for Add");
            Console.WriteLine("2 for Substract");
            Console.WriteLine("3 for Multiply");
            Console.WriteLine("4 for Divid");
            opr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#####################################################");


            switch (opr)
            {
                case 1:
                    result = fv + sv;
                    break;
                case 2:
                    result = fv - sv;
                    break;
                case 3:
                    result = fv * sv;
                    break;
                case 4:
                    result = fv / sv;
                    break;


                default:
                    result = fv + sv;
                    break;
            }



            Console.WriteLine("Result is:" + result);
            Console.WriteLine("#####################################################");


            Console.ReadLine();
        }
    }
}