using System;

namespace QueueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            QueueA qu = new QueueA();

            while(true)
            {
                Console.WriteLine("1.Insert an element in th queue ");
                Console.WriteLine("2.Delete an element from the queue ");
                Console.WriteLine("3.Display element at the front ");
                Console.WriteLine("4.Display all the elements of the queue ");
                Console.WriteLine("5.Display size of the queue ");
                Console.WriteLine("6.Quit");
                Console.Write("Ente your choice ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.Write("enter the element to be inserted ");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break;
                    case 2:
                        x = qu.Delete();
                        Console.WriteLine("Element deleted is : " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at te front is: " + qu.Peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of the queue is: " + qu.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;

                }
                Console.WriteLine();
            
            }
        }
    }
}
