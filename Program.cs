using System;
using System.Collections.Generic;

    


namespace Strategy.Demonstraition
{
    class Client
    {
        static void Main()
        {
            SortedList studentRecord = new SortedList();
            studentRecord.Add("Reza");
            studentRecord.Add("Sara");
            studentRecord.Add("Ali");
            studentRecord.Add("Murat");
            studentRecord.Add("Nur");
            
            studentRecord.SetSortStrategy(new QuickSort());
            studentRecord.Sort();
            
            studentRecord.SetSortStrategy(new ShellSort());
            studentRecord.Sort();
            
            studentRecord.SetSortStrategy(new MergeSort());
            studentRecord.Sort();
            
            //Wait for User
            Console.ReadKey();

        }
    }
    
    
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
    
    // A 'concreteStrategy' class
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); //default is quicksort
            Console.WriteLine("QuickSorted List ");
            
        }
    }
    // A 'concreteStrategy' class
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort();not_implemented
            Console.WriteLine("ShellSorted List ");
        }
    }
    
    // A 'concreteStrategy' class
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergelSort();not_implemented 
            Console.WriteLine("MergeSorted List ");
        }
        
    }
    
    //the "Context" class
    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
            //Iterate over list and display results
            foreach (string name in _list)
            {
                Console.WriteLine(" "+name);
            }
            Console.WriteLine();
            
        }
    }
     
}