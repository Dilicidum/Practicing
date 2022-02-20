using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Stack<T> : DataStructure<T>
    {
        public  Node<T> PrecedingHead 
        {
            get
            {
                return Head.Next;
            }
        }
        public override Node<T> Head { get; set; }

        public override void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if( Head == null)
            {
                Head = node;
            }
            else
            {
                Node<T> temp = Head;
                Head = node;
                Head.Next = temp;
            }
            Head = node;
        }

        public override void Remove(T value)
        {
            
        }

        public override void RemoveLast()
        {
            Head = Head.Next;   
        }
    }
}
