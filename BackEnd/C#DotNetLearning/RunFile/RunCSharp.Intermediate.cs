using C_DotNetLearning.LogicalProgarm;
using C_DotNetLearning.Modifiers;
using C_DotNetLearning.ParameterPassingMechanisms;
using CSharp.Intermediate.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_DotNetLearning.AccessModifiers.AccessModifiers;
using static C_DotNetLearning.Delegates.BasicDelegates;

namespace C_DotNetLearning.RunFile
{
    public static class RunCSharpIntermediate
    {

        //LinQ

        //Collections

        public static void RunGenericCollections()
        {
            //List
            var list = Generic.List();
            foreach(var item in list)
            {
                //Console.WriteLine(item);
            }

            //Dictionary
            var dictionary = Generic.Dictionary();
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }

            //HashSet
            var hashSet = Generic.HashSet();
            foreach(var item in hashSet)
            {
                Console.WriteLine(item);
            }

            //Queue
            var queue = Generic.Queue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            //SortedDictionary
            var sortedDictionary = Generic.SortedDictionary();
            foreach(var item in sortedDictionary)
            {
                Console.WriteLine(item);
            }

            //Stack
            var stack = Generic.Stack();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }


        public static void RunNonGenericCollections()
        {
            //ArrayList
            var list = NonGeneric.ArrayList();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //Hashtable
            var table = NonGeneric.Hashtable();
            foreach(var item in table)
            {
                Console.WriteLine(item);
            }

            //SortedList
            var sortedList = NonGeneric.SortedList();
            foreach(var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        //Delegates & Events

        public static void RunDelegates()
        {
            // 3️⃣ Create an instance of the delegate
            PrintMessage del = ShowMessage;

            // 4️⃣ Call the method using delegate
            del("Hello from Delegate!");

            Console.ReadLine();

        }

    }
}
