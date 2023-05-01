using System.ComponentModel.Design;
using System.Globalization;
using ToDoList;

class Program
{
    static void Main(string[] args)
    {
        int menu;
        int confirm;
        try
        { 
            Operator Operator = new Operator();
            do
            {
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
                Console.WriteLine("!TO-DO LIST!\n");
                Console.WriteLine("1 - MODIFY LIST\n2 - FINISH PROGRAM\n");
                Console.WriteLine("----------------------------------------------------------------------------\n");
                Console.WriteLine(Operator.OutList());
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    Console.WriteLine(Operator.List());
                    Console.Clear();
                }
                else if (menu == 2)
                {
                    do
                    {
                        Console.WriteLine("\n----------------------------------------------------------------------------\n");
                        Console.WriteLine("TYPE 2 TO CONFIRM FINISH SYSTEM.\nTYPE 1 TO RETURN.");
                        Console.WriteLine("\n----------------------------------------------------------------------------\n");
                        confirm = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (confirm == 2)
                        {
                            menu = 834834;
                        }
                        else if (confirm == 1) { }
                    } while (confirm != 1 && confirm != 2);
                }
            } while (menu != 834834);

            Console.WriteLine("\nFINISHED.\n");
            Console.WriteLine("----------------------------------------------------------------------------\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
