package hospitalManagement;

import java.util.ArrayList;
import java.util.Scanner;
public class Patients implements IBasicActivities<Patient>
    {
        //Field	
        private ArrayList<Patient> patientList;
        private long count;

        // Information field	
        //  Management field	
        static Scanner input = new Scanner(System.in);

        // Dynamic field	
        // Properties	

        


        public ArrayList<Patient> getPatientList() {
            return patientList;
        }

        public void setPatientList(ArrayList<Patient> patientList) {
            this.patientList = patientList;
        }

        public long getCount() {
            return count;
        }

        public void setCount(long count) {
            this.count = count;
        }

        // Constructors	
        public Patients()
        {
            patientList = new ArrayList<Patient>();
            count = 0;
        }

        public Patients(ArrayList<Patient> patientList, long count)
        {
            this.patientList = patientList;
            this.count = count;
        }


        // Methods	
        // in, output
        // General method	
        // Other method


        public void AddItem()
        {
            System.out.println("Add patient");

            Patient patient = new Patient();
            patient.Input();
            patientList.add(patient);
            this.count++;
            System.out.println("Done!");

        }

        public void AddItem(Patient patient)
        {
            System.out.println("Add patient");
            patientList.add(patient);
            this.count++;
            System.out.println("Done!");

        }

        public void ShowInformation()
        {
            System.out.println("Show information of all patients");

            patientList.forEach(value -> { value.Output(); System.out.println(); });
            System.out.println("Done!");
        }

        public Patient UpdateItem(String id)
        {
            System.out.println("Update the patient");

            Patient res = null;
            for (Patient i : patientList) {
                if( i.getId() == id)
                {
                    i.Input();
                    res = i;
                }
            }
            if (res == null)
            {
                System.out.format("Not found the medicine with id: %s", id);
            }
            else
            {
                System.out.println("Done!");
    
            }
            return res;
        }

        public boolean RemoveItem(String id)
        {
            System.out.println("Remove the patient");

            boolean res = false;
            for (Patient i : patientList) {
                if( i.getId() == id)
                {
                    patientList.remove(i);
                    this.count--;
                }
            }
            if (res == false)
            {
                System.out.println("Not found patient with id: " + id);

            }
            else
            {
                System.out.println("Done!");

            }
            return res;
        }

        public Patient FindItem(String id)
        {
            Patient res = null;
            for (Patient i : patientList) {
                if( i.getId() == id)
                {
                    res = i;
                }
            }
            if (res == null)
            {
                System.out.println("Not found patient with id: " + id);

            }
            else
            {
                System.out.println("Done!");

            }
            return res;
        }

        public boolean Clear()
        {
            System.out.println("Clear all patients");

            patientList.clear();
           
            System.out.println("Done!");
            return true;
        }

        // Overriding	


    }