package hospitalManagement;

import java.util.ArrayList;
import java.util.Scanner;

public class Doctors implements IBasicActivities<Doctor>
    {
        //field
        private ArrayList<Doctor> doctorList;
        private long count;



        // Information field
        //  Management field
        // Dynamic 
        static Scanner input = new Scanner(System.in);

        // Properties
        
        public ArrayList<Doctor> getDoctorList() {
            return doctorList;
        }
        public void setDoctorList(ArrayList<Doctor> doctorList) {
            this.doctorList = doctorList;
        }
        public long getCount() {
            return count;
        }
        public void setCount(long count) {
            this.count = count;
        }

        // Constructors

        public Doctors()
        {
            doctorList = new ArrayList<Doctor>();
            count = 0;
        }
        public Doctors(ArrayList<Doctor> doctorList, long count)
        {
            this.doctorList = doctorList;
            this.count = count;
        }

        public void AddItem()
        {
            System.out.println("Add doctor");

            Doctor doctor = new Doctor();
            doctor.Input();
            doctorList.add(doctor);
            this.count++;
            System.out.println("Done!");

        }

        public void AddItem(Doctor value)
        {
            System.out.println("Add doctor");

            doctorList.add(value);
            this.count++;
            System.out.println("Done!");

        }

        public boolean Clear()
        {
            System.out.println("Clear all doctors");

            doctorList.clear();
            
            System.out.println("Done!");
            return true;
        }

        public Doctor FindItem(String id)
        {
            Doctor res = null;
            for (Doctor i : doctorList) {
                if( i.getId() == id)
                {
                    res = i;
                }
            }
            if (res == null)
            {
                System.out.println("Not found doctor with id: " + id);

            }
            else
            {
                System.out.println("Done!");

            }
            return res;
        }

        public boolean RemoveItem(String id)
        {
            System.out.println("Remove the Doctor");

            boolean res = false;
            for (Doctor i : doctorList) {
                if( i.getId() == id)
                {
                    doctorList.remove(i);
                    this.count--;
                }
            }
            if (res == false)
            {
                System.out.println("Not found doctor with id: " + id);

            }
            else
            {
                System.out.println("Done!");

            }
            return res;
        }

        public void ShowInformation()
        {
            System.out.println("Show information of all doctors");

            doctorList.forEach(value -> { value.Output(); System.out.println(); });
            System.out.println("Done!");
        }

        public Doctor UpdateItem(String id)
        {
            System.out.println("Update the doctor");

            Doctor res = null;
            for (Doctor i : doctorList) {
                if( i.getId() == id)
                {
                    i.Input();
                    res = i;
                }
            }
            if (res == null)
            {
                System.out.println("Not found the doctor with id: " + id);

            }
            else
            {
                System.out.println("Done!");

            }
            return res;
        }
    }