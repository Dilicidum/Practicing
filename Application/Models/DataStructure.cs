using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public abstract class DataStructure<T>
    {
        private Node<T> head;
        public virtual Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        Node<T> Tail { get; set; }

        public virtual void Add(T value)
        {

        }

        public virtual void Remove(T value)
        {

        }

        public virtual void RemoveLast()
        {
            Head = Head.Next;
        }

        public virtual void Iterate()
        {
            int i = 1;
            while(Head != null)
            {
                Console.WriteLine($"{i} Value = {Head.Value}");
                i++;
                Head = Head.Next;
            }
        }
    }


}
