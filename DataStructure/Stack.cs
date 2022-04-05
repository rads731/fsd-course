using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack
    {
        int[] array = new int[5];
        int topPointer = -1;
        int maxLength = 5;
        
       
        public void Do()
        {
            Stack stack = new Stack();
            stack.Push(12);
            stack.Push(24);
            stack.Push(36);
            stack.Push(48);
            stack.Push(60);
            stack.Push(72);
            stack.Print();
            stack.Peek();
            stack.Pop();
            stack.Print();
        }
        public void Push(int element) {
            
            if (this.topPointer == this.maxLength-1)
            {
                Console.Write("Element cannot be pushed, stack is full");
            }
            else
            {
               
                this.topPointer += 1;
                array[this.topPointer] = element;
            }
        }

        public void Peek()
        {
            if (this.topPointer == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine($"Top Element {array[this.topPointer]}");
            }
        }

        public int Pop()
        {
            if (this.topPointer == -1)
            {
                Console.WriteLine("Empty Array");
                return -1;
            }
            else
            {
                return array[this.topPointer];
                
            }
        }

        public void Print()
        {
            Console.WriteLine("Elements of Stack");
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }

        

    }
}
