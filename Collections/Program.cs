using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            var names=new List<string>();//STORES THE ALL VALUES (DUPLICATES,UNIQUE VALUES)
            names.Add("b");
            names.Add("h");
            names.Add("a");
            names.Add("n");
            names.Add("u");
            foreach(string noun in names)
            {
                Console.WriteLine(noun);
            }
        }
    }
   

  

    //initialiser
    public class ListExample
    {
        public static void Main(string[] args)
        {
            var names = new List<string>() { "n", "a", "r", "e", "s", "h" };
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
       
    public class HashsetExample
    {
        public static void Main(string[] args)
        {
            var names=new HashSet<string>();//AVOIDS THE DUPLICATE VALUES
            names.Add("P");
            names.Add("R");
            names.Add("A");
            names.Add("S");
            names.Add("A");
            names.Add("D");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            //OUTPUT:
            //P
            //R
            //A
            //S
            //D
        }
    }

    public class SortedsettEx

    {
        public static void Main(string[] args)
        {
            var names=new SortedSet<string>();
            names.Add("bhanu");
            names.Add("akhil");
            names.Add("charan");
            names.Add("Star");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            //akhil
            //bhanu
            //charan
            //Star
        }
    }
   
    public class SortedsettEx

    {
        public static void Main(string[] args)
        {
            var names = new SortedSet<string>() { "bhanu","akhil","bhanu","siddu","pinky"};
            foreach (var name in names) 
            { 
                Console.WriteLine(name);
            }
            //akhil
            //bhanu
            //pinky
            //siddu 
            //does not allow the duplicate values


        }
    }
    
    public class StackEX
    {
        public static void Main(string[] args)
        {
            Stack<string> NAMES = new Stack<string>();
            NAMES.Push("ajeeth");
            NAMES.Push("bhanu");
            NAMES.Push("bhanu");
            NAMES.Push("sai");
            foreach (string name in NAMES)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine("peek element:" + NAMES.Peek());
            Console.WriteLine("pop element:" + NAMES.Pop());
            Console.WriteLine("after pop.peek element:" + NAMES.Peek());

        }
    }
    //sai
    //bhanu
    //bhanu
    //ajeeth
    //peek element:sai
    //pop element:sai
    //after pop.peek element:bhanu
    //the output is the LIFO last in first out and it allows the duplicate values 

    public class QueueEX
    {
        public static void Main(string[] args)
        {
            Queue<string> NAMES = new Queue<string>()  ;
            NAMES.Enqueue("bhanu");
            NAMES.Enqueue("sai");
            NAMES.Enqueue("ajeeth");
            NAMES.Enqueue("ajeeth");

            
            foreach (string name in NAMES)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine("peek element:" + NAMES.Peek());
            Console.WriteLine("dequeue:" + NAMES.Dequeue());
            Console.WriteLine("after pop.peek element:" + NAMES.Peek());

        }
        // bhanu
        //sai
        //ajeeth
        //ajeeth
        //peek element:bhanu
        //dequeue:bhanu
        //after pop.peek element:sai
        //the output is the FIFO first in first out and it allows the duplicate values 

    }
  
    public class LinkedListEx
    {
        public static void Main(string[] args)
        {
            var names=new LinkedList<string>();
            names.AddLast("sai");
            names.AddLast("ajeeth");
            names.AddLast("bala");
            names.AddFirst("bhanu");
            foreach (string star in names) 
            {
                Console.WriteLine(star);
            }

        }
// bhanu
//sai
//ajeeth
//bala
    }

    public class LinkedListEx
    {
        public static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("sai");
            names.AddLast("ajeeth");
            names.AddLast("bala");
            names.AddFirst("bhanu");
            LinkedListNode<string> node = names.Find("ajeeth");
            names.AddBefore(node, "satwika");
            names.AddAfter(node, "Krishna");
            foreach (string star in names)
            {
                Console.WriteLine(star);
            }

        }
    }
//    bhanu
//sai
//satwika
//ajeeth
//Krishna
//bala

    public class DictionaryEx
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            {
                names.Add("1", "bhanu");
                names.Add("2", "sai");
                names.Add("3", "ajeeth");
                names.Add("4", "bala");
                foreach (KeyValuePair<string, string> name in names)
                {
                    Console.WriteLine(name.Key + " " + name.Value);
                }
            }
        }
    }
    //1 bhanu
    //2 sai
    //3 ajeeth
    //4 bala
    
    public class SortedDictionaryEx
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            {
                names.Add("1", "bhanu");
                names.Add("5", "sai");
                names.Add("3", "ajeeth");
                names.Add("2", "bala");
                names.Add("4", "praveen");
                foreach (KeyValuePair<string, string> name in names)
                {
                    Console.WriteLine(name.Key + " " + name.Value);
                }
            }
        }
    }
    //1 bhanu
    //2 bala
    //3 ajeeth
    //4 praveen
    //5 sai

    public class SortedDictionaryEx
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            {
                names.Add("1", "bhanu");
                names.Add("5", "sai");
                names.Add("6", "ajeeth");
                names.Add("2", "bala");
                names.Add("4", "praveen");
                foreach (KeyValuePair<string, string> name in names)
                {
                    Console.WriteLine(name.Key + " " + name.Value);
                }
            }
        }
    }
//1 bhanu
//2 bala
//4 praveen
//5 sai
//6 ajeeth
*/
    public class SortedlistEx
    {
        public static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            {
                names.Add("1", "bhanu");
                names.Add("5", "sai");
                names.Add("3", "ajeeth");
                names.Add("2", "bala");
                names.Add("4", "praveen");
                foreach (KeyValuePair<string, string> name in names)
                {
                    Console.WriteLine(name.Key + " " + name.Value);
                }
            }
        }
    }
//1 bhanu
//2 bala
//3 ajeeth
//4 praveen
//5 sai
}
