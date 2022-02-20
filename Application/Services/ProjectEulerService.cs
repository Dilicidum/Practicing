using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
namespace Application.Services
{
    public class ProjectEulerService
    {
        public int Task2()
        {
            Stack<int> stack = new Stack<int>();

            int Fibonacchi_Sum = 0;
            int Result_Sum = 0;
            while (Fibonacchi_Sum < 4000000)
            {
                if (stack.Head == null)
                {
                    stack.Add(1);
                    stack.Add(2);
                }

                Fibonacchi_Sum = stack.PrecedingHead.Value + stack.Head.Value;

                if (Fibonacchi_Sum < 4000000)
                {
                    stack.Add(Fibonacchi_Sum);
                }

            }

            while (stack.Head != null)
            {
                if (stack.Head.Value % 2 == 0)
                {
                    Result_Sum += stack.Head.Value;
                }
                stack.Head = stack.Head.Next;
            }

            Console.WriteLine($"Result sum is {Result_Sum}");
            return Result_Sum;
        }
    }
}
