using _30._02._2022task.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _30._02._2022task
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> list = new CustomList<int>(1,2,3,4,5,6,7);
            //Console.WriteLine(list[100]); (indexer)
            list.Add(20);
            list.Remove(2);
            list.Show();






        }
    }
}

