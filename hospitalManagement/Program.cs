using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace hospitalManagement
{
    internal class Program
    {
        //
        public static void ShowFrame()
        {
            string frame = new string('-', 19) + "Hospital Management Program" + new string('-', 19);
            Console.WriteLine(frame);
        }
        public static void ShowItemsInFrame(string[] items)
        {
            int idx = 1;
            foreach (string i in items)
            {
                Console.WriteLine($"|{idx++}.{i,-60}|");
            }
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
        //
        static void Main(string[] args)
        {
            Hospital ad = new Hospital();
            while (true)
            {

                int choice = -1;
                ShowFrame();
                Console.WriteLine($"| 1.{"Faculty management",-60}|");
                Console.WriteLine($"| 2.{"Repository management",-60}|");
                Console.WriteLine($"| 3.{"Quit",-60}|");

                choice = Int32.Parse(Console.ReadLine());
                //
                if (choice == 1)
                {
                    string[] mainFunctionality = {
                                                        "Add a faculty",
                                                        "Show information of all faculties",
                                                        "Find a faculty (by id)",
                                                        "Update a faculty (by id)",
                                                        "Remove a faculty (by id)",
                                                        "Clear all of faculties"};

                    string[] patientFunctionality = {
                                                        "Add a patient",
                                                        "Show information of all patients",
                                                        "Find a patient (by id)",
                                                        "Update a patient (by id)",
                                                        "Remove a patient(by id)",
                                                        "Clear all of patients"};

                    string[] employeeFunctionality = {
                                                        "Add a employee",
                                                        "Show information of all employees",
                                                        "Find a employees (by id)",
                                                        "Update a employee (by id)",
                                                        "Remove a employee (by id)",
                                                        "Clear all of employees"};
                    ShowItemsInFrame(mainFunctionality);
                }

                else if (choice == 2)
                {

                    string[] mainFunctionality = {"Add a repository",
                                                    "Show the repository",
                                                     "Find the repository ( by id )" ,
                                                    "Update the repository ( by id )",
                                                     "Remove a repository ( by id )",
                                                    "Clear all",
                                                    "Medicine management",
                                                    "Equipment mamagement",
                                                    "Quit"};

                    string[] medicineFunctionality = {"Add a medicine",
                                                        "Show the medicine",
                                                         "Find the medicine( by id )" ,
                                                        "Update the medicine( by id )",
                                                         "Remove a medicine( by id )",
                                                        "Clear all"};

                    string[] equipmentFunctionality = {"Add a equipment",
                                                        "Show the equipment",
                                                         "Find the equipment( by id )" ,
                                                        "Update the equipment( by id )",
                                                         "Remove a equipment( by id )",
                                                        "Clear all"};
                    while (true)
                    {
                        ClearScreen();
                        ShowFrame();
                        ShowItemsInFrame(mainFunctionality);
                        int choiceOfRepo = -1;
                        int isQuit = 0;
                        choiceOfRepo = Int32.Parse(Console.ReadLine());
                        string idFind = "";
                        switch (choiceOfRepo)
                        {
                            case 1:
                                ad.AddRepository();
                                break;
                            case 2:
                                ad.ShowAllRepository();
                                break;
                            case 3:
                                idFind = Console.ReadLine();
                                ad.ShowRepository(idFind);
                                break;
                            case 4:
                                idFind = Console.ReadLine();
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            case 8:
                                break;
                            case 9:
                                isQuit = 1;
                                break;
                        }
                        if (isQuit == 1)
                        {
                            break;
                        }
                    }
                }
                else if (choice == 3)
                {
                    break;
                }


            }
        }
    }
}


