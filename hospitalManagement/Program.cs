using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public static void ShowFunctionality(string[] features)
        {
            ClearScreen();
            ShowFrame();
            ShowItemsInFrame(features);
        }
        public static void ImplementFeatures(Hospital ad, string[] features, int type)
        {
            string idRepo = "";
            Console.Write("Input id of the repository want to add item: ");
            idRepo = Console.ReadLine();
            Repository root = ad.Repo.FindItem(idRepo);
            if (root == null)
            {
                Console.ReadKey();
                return;
            }
            while (true)
            {
                ShowFunctionality(features);
                int choice = -1;
                int isQuit = 0;
                choice = Int32.Parse(Console.ReadLine());
                string idFind = "";
                switch (choice)
                {
                    case 1:

                        if (type == 1) // equipment
                        {
                            root.AddEquipment();
                        }
                        else if (type == 2) // medicine
                        {
                            root.AddMedicine();
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        if (type == 1)
                        {
                            root.EquipmentsList.ShowInformation();
                        }
                        else if (type == 2)
                        {
                            root.MedicinesList.ShowInformation();
                        }
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.WriteLine("Input id want to find: ");
                        idFind = Console.ReadLine();

                        if (type == 1)
                        {
                            root.FindEquipment(idFind)?.Output();
                        }
                        else if (type == 2)
                        {
                            root.FindMedicine(idFind)?.Output();
                        }
                        Console.ReadKey();

                        break;
                    case 4:
                        Console.WriteLine("Input id want to update: ");
                        idFind = Console.ReadLine();

                        if (type == 1)
                        {
                            root.UpdateEquipment(idFind);
                        }
                        else if (type == 2)
                        {
                            root.UpdateMedicine(idFind);
                        }
                        Console.ReadKey();

                        break;
                    case 5:
                        Console.WriteLine("Input id want to remove: ");
                        idFind = Console.ReadLine();

                        if (type == 1)
                        {
                            root.RemoveEquipment(idFind);
                        }
                        else if (type == 2)
                        {
                            root.RemoveMedicine(idFind);
                        }
                        Console.ReadKey();

                        break;
                    case 6:


                        if (type == 1)
                        {
                            root.ClearEquipment();
                        }
                        else if (type == 2)
                        {
                            root.ClearMedicine();
                        }
                        Console.ReadKey();

                        break;
                    case 7:
                        isQuit = 1;
                        break;
                }
                if (isQuit == 1)
                {
                    break;
                }
            }

        }



        
        public static void ImplementFaculty(Hospital ad, string[] features, int type)
        {
            string idFac = "";
            Console.Write("Input id of the faculty want to add item: ");
            idFac = Console.ReadLine();
            Faculty root = ad.Faculties.FindItem(idFac);
            if (root == null)
            {
                Console.ReadKey();
                return;
            }
            while (true)
            {
                ShowFunctionality(features);
                int choice = -1;
                int isQuit = 0;
                choice = Int32.Parse(Console.ReadLine());
                string idFind = "";
                switch (choice)
                {
                    case 1:

                        if (type == 1) // patient
                        {
                            root.AddPatient();
                        }
                        else if (type == 2) // employee
                        {
                            root.AddEmployee();
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        if (type == 1)
                        {
                            root.PatientList.ShowInformation();
                        }
                        else if (type == 2)
                        {
                            root.EmployeeList.ShowInformation();
                        }
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.WriteLine("Input id want to find: ");
                        idFind = Console.ReadLine();

                        if (type == 1)
                        {
                            root.FindPatient(idFind)?.Output();
                        }
                        else if (type == 2)
                        {
                            root.FindEmployee(idFind)?.Output();
                        }
                        Console.ReadKey();

                        break;
                    case 4:
                        Console.WriteLine("Input id want to update: ");
                        idFind = Console.ReadLine();

                        if (type == 1)
                        {
                            root.UpdatePatient(idFind);
                        }
                        else if (type == 2)
                        {
                            root.UpdateEmployee(idFind);
                        }
                        Console.ReadKey();

                        break;
                    case 5:
                        Console.WriteLine("Input id want to remove: ");
                        idFind = Console.ReadLine();

                        if (type == 1)
                        {
                            root.RemovePatient(idFind);
                        }
                        else if (type == 2)
                        {
                            root.RemoveEmployee(idFind);
                        }
                        Console.ReadKey();

                        break;
                    case 6:


                        if (type == 1)
                        {
                            root.ClearPatient();
                        }
                        else if (type == 2)
                        {
                            root.ClearEmployee();
                        }
                        Console.ReadKey();

                        break;
                    case 7:
                        isQuit = 1;
                        break;
                }
                if (isQuit == 1)
                {
                    break;
                }
            }

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
                // faculty branch
                if (choice == 1)
                {
                    string[] mainFunctionality = {
                                                        "Add a faculty",
                                                        "Show information of all faculties",
                                                        "Find a faculty (by id)",
                                                        "Update a faculty (by id)",
                                                        "Remove a faculty (by id)",
                                                        "Clear all of faculties",
                                                        "Patient",
                                                        "Employee",
                                                        "Quit"};

                    string[] patientFunctionality = {
                                                        "Add a patient",
                                                        "Show information of all patients",
                                                        "Find a patient (by id)",
                                                        "Update a patient (by id)",
                                                        "Remove a patient(by id)",
                                                        "Clear all of patients",
                                                        "Quit"};


                    string[] employeeFunctionality = {
                                                        "Add a employee",
                                                        "Show information of all employees",
                                                        "Find a employees (by id)",
                                                        "Update a employee (by id)",
                                                        "Remove a employee (by id)",
                                                        "Clear all of employees",
                                                        "Quit"};
                    while (true)
                    {
                        ClearScreen();
                        ShowFrame();
                        ShowItemsInFrame(mainFunctionality);
                        int choiceOfFac = -1;
                        int isQuit = 0;
                        choiceOfFac = Int32.Parse(Console.ReadLine());
                        string idFind = "";
                        switch (choiceOfFac)
                        {
                            case 1:
                                ad.AddFaculty();
                                break;
                            case 2:
                                ad.ShowAllFaculty();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Write("Input id want to find: ");
                                idFind = Console.ReadLine();
                                ad.ShowFaculty(idFind);
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Write("Input id want to update: ");
                                idFind = Console.ReadLine();
                                ad.UpdateFaculty(idFind);
                                break;
                            case 5:
                                Console.Write("Input id want to remove: ");
                                idFind = Console.ReadLine();
                                ad.RemoveFaculty(idFind);
                                break;
                            case 6:
                                ad.ClearFaculty();
                                break;
                            case 7:
                                ImplementFaculty(ad, patientFunctionality, 1);
                                break;
                            case 8:
                                ImplementFaculty(ad, employeeFunctionality, 2);
                                break;
                            case 9:
                                isQuit = 1;
                                ClearScreen();
                                break;
                        }
                        if (isQuit == 1)
                        {
                            break;
                        }
                    }
                }
                // end faculty branch
                else if (choice == 2) // Repository branch
                {
                    // Features
                    string[] mainFunctionality = {"Add a repository",
                                                    "Show all repositories",
                                                     "Find the repository ( by id )" ,
                                                    "Update the repository ( by id )",
                                                     "Remove a repository ( by id )",
                                                    "Clear all",
                                                    "Equipment mamagement",
                                                    "Medicine management",
                                                    "Quit"};

                    string[] medicineFunctionality = {"Add a medicine",
                                                        "Show all medicines",
                                                         "Find the medicine( by id )" ,
                                                        "Update the medicine( by id )",
                                                         "Remove a medicine( by id )",
                                                        "Clear all",
                                                        "Quit"};

                    string[] equipmentFunctionality = {"Add a equipment",
                                                        "Show all equipments",
                                                         "Find the equipment( by id )" ,
                                                        "Update the equipment( by id )",
                                                         "Remove a equipment( by id )",
                                                        "Clear all",
                                                        "Quit"};
                    // Logic 
                    while (true)
                    {
                        ShowFunctionality(mainFunctionality);
                        int choiceOfRepo = -1;
                        int isQuit = 0;
                        Console.Write("Choose: ");
                        choiceOfRepo = Int32.Parse(Console.ReadLine());
                        string idFind = "";
                        switch (choiceOfRepo)
                        {
                            case 1:
                                ad.AddRepository();
                                Console.ReadKey();

                                break;
                            case 2:
                                ad.ShowAllRepository();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Write("Input id want to find: ");
                                idFind = Console.ReadLine();
                                ad.ShowRepository(idFind);
                                Console.ReadKey();

                                break;
                            case 4:
                                Console.Write("Input id want to update: ");
                                idFind = Console.ReadLine();
                                ad.UpdateRepository(idFind);
                                Console.ReadKey();

                                break;
                            case 5:
                                Console.Write("Input id want to remove: ");
                                idFind = Console.ReadLine();
                                ad.RemoveRepository(idFind);
                                Console.ReadKey();

                                break;
                            case 6:
                                ad.ClearRepository();
                                Console.ReadKey();

                                break;
                            case 7:
                                ImplementFeatures(ad, equipmentFunctionality, 1);
                                break;
                            case 8:
                                ImplementFeatures(ad, medicineFunctionality, 2);
                                break;
                            case 9:
                                isQuit = 1;
                                ClearScreen();
                                break;
                        }
                        if (isQuit == 1)
                        {
                            break;
                        }
                    }
                }
                //end repository branch
                else if (choice == 3)
                {
                    break;
                }


            }

        }
    }
}


