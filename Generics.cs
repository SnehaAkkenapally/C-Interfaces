using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenerics
{
    public class Generics<T>
    {
        List<T> elements = new List<T>();

        // Method to return the number of elements in the stack
        public int Count()
        {
            return elements.Count;
        }

        // Method to add an element onto the stack
        public void Push(T item)
        {
            elements.Add(item);
        }

        // Method to remove and return the top element from the stack
        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            // Get the last item (top of the stack)
            T item = elements[elements.Count - 1];

            // Remove the last item
            elements.RemoveAt(elements.Count - 1);

            return item;
        }
    }
}
