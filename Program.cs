using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
       static List<string> taskList;
        static void Main(string[] args)
        {
            taskList = new List<string>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add new task");
                Console.WriteLine("2. Show task list");
                Console.WriteLine("3. Edit task");
                Console.WriteLine("4. Delete task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add new task:");
                        string task = Console.ReadLine();
                        Add(task);
                        break;
                    case "2":
                        Console.WriteLine(".............................");
                        Console.WriteLine("Task List:");
                        Show(taskList);
                        break;
                    case "3":
                        Console.WriteLine("Enter task index to edit:");
                        int editValue = Convert.ToInt32(Console.ReadLine());
                        Edit(editValue);
                        break;
                    case "4":
                        Console.WriteLine("Enter task index to delete:");
                        int deleteValue = Convert.ToInt32(Console.ReadLine());
                        Delete(deleteValue);
                        break;
                    default:
                        return;
                }
                Console.WriteLine(".............................");
                Console.WriteLine("Do you want to continue? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response.Equals("n"))
                {
                    exit = true;
                }
            }
        }

        static void Add(String task)
        {
            taskList.Add(task);
            Console.WriteLine("Task added successfully!!");
        }

        static void Show(List<string> tasklist)
        {
            Console.WriteLine(".............................");
            Console.WriteLine(" To Do list");
            Console.WriteLine(".............................");

                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + taskList[i]);
                }
            }

        static void Edit(int indexValue)
        {
            if (indexValue != -1)
            {
                Console.WriteLine("Enter new task:");
                string newTask = Console.ReadLine();
                taskList[indexValue] = newTask;
                Console.WriteLine("Task edited successfully!!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        static void Delete(int indexValue)
        {
            if (indexValue != -1)
            {
                taskList.RemoveAt(indexValue);
                Console.WriteLine("Task deleted successfully!!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
            
        }
    }

}
