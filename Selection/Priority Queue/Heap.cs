using System;

namespace PriorityQueue
{
    public class Heap
    {
        private int size;
        private int last;
        private int[] priorities;

        public Heap(int size)
        {
            this.size = size;
            priorities = new int[size + 1];
            last = 0;
        }

        public void Insert(int value)
        {
            if (last == size) 
                throw new Exception("Heap is full!");

            priorities[++last] = value;
            BubbleUp(last);
        }

        public int Retrieve()
        {
            if (last == 0) 
                throw new Exception("Heap is empty!");

            int root = priorities[1]; 
            priorities[1] = priorities[last--]; 
            BubbleDown(1); 

            return root; 
        }

        public void BubbleUp(int i)
        {
            if (i == 1) return; 

            int parent = i / 2; 
            if (priorities[i] > priorities[parent]) 
            {
                Swap(i, parent);
                BubbleUp(parent);
            }
        }

        public void BubbleDown(int i)
        {
            int leftChild = 2 * i;
            int rightChild = 2 * i + 1;
            int largest = i;

            if (leftChild <= last && priorities[leftChild] > priorities[largest])
                largest = leftChild;

            if (rightChild <= last && priorities[rightChild] > priorities[largest])
                largest = rightChild;

            if (largest != i)
            {
                Swap(i, largest);
                BubbleDown(largest);
            }
        }

        public void Swap(int i, int j)
        {
            int temp = priorities[i];
            priorities[i] = priorities[j];
            priorities[j] = temp;
        }

        public void Display()
        {
            for (int i = 1; i <= last; i++)
                Console.Write(priorities[i] + " ");
            Console.WriteLine();
        }
    }
}
