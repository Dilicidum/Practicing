using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
