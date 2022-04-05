using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        int max_length = 5;
        int frontEnd = -1;
        int rearEnd = 5;
        int[] input = new int[5];

        public void Do()
        {
            Queue queue = new Queue();
            queue.Insert(12);
            queue.Insert(24);
            queue.Insert(36);
            queue.Insert(48);
            queue.Insert(60);
            queue.Print();
            queue.Insert(72);
            queue.Print();
            queue.Delete();
            queue.Print();
        }


        void Insert(int element)
        {
            if(this.frontEnd==this.max_length-1 ||this.rearEnd == this.frontEnd)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                this.frontEnd += 1;
                input[this.frontEnd] = element;
            }
        }

        int Delete()
        {
            if (this.frontEnd == this.max_length)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int element = input[this.frontEnd];
                if (this.frontEnd >= this.rearEnd)
                {
                    this.frontEnd = this.rearEnd = -1;
                }
                else
                {
                    this.frontEnd += 1;
                }
                Console.WriteLine(element +" is deleted from the queue");
                return element;
            }
        }

        void Print()
        {
            if (this.frontEnd == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for(int i = 0; i < input.Length; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
