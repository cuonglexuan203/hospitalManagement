package hospitalManagement;

import java.util.Scanner;
public class Neurology extends Faculty
    {
        //Field
        // Information field
        //  Management field
        static Scanner input = new Scanner(System.in);
        // Dynamic field
        // Properties
        // Constructors
        public Neurology()
        {

        }

        public Neurology(String id, String name, String description, String room, Doctors doctorList, Patients patientList)
        {
            super(id, name, description, room, doctorList, patientList);
        }
        
        // Methods
        // in, output
        public void Input()
        {
            super.Input();
        }

        public void Input1()
        {
            super.Input1();
        }

        public void Output()
        {
            super.Output();
        }
        // General method
        // Other method
        // Overriding
    }