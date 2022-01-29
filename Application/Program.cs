using System;
using System.Linq;
using Application.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using System.Diagnostics;
namespace Application
{

    public class Stack
    {
        public Node Head { get; set; }

        public Node PrecedingHead
        {
            get
            {
                return Head.Next;
            }
            set
            {
                PrecedingHead = value;
            }
        }

        public int Sum { get; set; }

        public void Pop()
        {
            if(Head != null)
            {
                Head = Head.Next;
                Sum = Sum - Head.Value;
            } else
            {
                throw new Exception("Stack does not contain elements");
            }
        }

        public void Push(int value)
        {
            Node element = new Node();
            element.Value = value;
            if(Head != null)
            {
                Node temp = Head;
                this.Head = element;
                this.Head.Next = temp;
            }
            else
            {
                this.Head = element;
            }
            Sum = Sum + Head.Value;
        }

        public void Iterate()
        {
            Node temp = Head;
            while(temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
    public class Node
    {
        public Node Next { get; set; }

        public int Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    stack.Push(i);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"time = {stopwatch.ElapsedTicks.ToString()}");
            Console.WriteLine($"Sum = {stack.Sum}");
            Console.ReadLine();
        }

        
        
    }
}
