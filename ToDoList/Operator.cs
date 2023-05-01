using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Operator
    {
        string[] toDo = new string[10];

        public string List()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("CHOOSE A LINE! ( 1 - 10 )");

            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            int line = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("INPUT ACTIVITY BELOW: ");
            string activity = Console.ReadLine();
            if (activity != null)
            {
                toDo[line - 1] = activity;
            }else
            {
                Console.WriteLine("INPUT VALID ACTIVITY BELOW: ");
                activity = Console.ReadLine();
                if (activity != null)
                {
                    toDo[line - 1] = activity;
                }
                
            }

            return "";
        }
        public string OutList()
        {
            return $"1:{toDo[0]}\n2: {toDo[1]}\n3: {toDo[2]}\n4: {toDo[3]}\n5: {toDo[4]}\n6:{toDo[5]}\n7: {toDo[6]}\n8: {toDo[7]}\n9: {toDo[8]}\n10: {toDo[9]}";
        }
    }
}
