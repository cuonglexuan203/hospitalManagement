package hospitalManagement;

import java.util.Scanner;
public class Faculty
    {
        //Field
        private String id;
        // INFO field
        private String name;
        private String description;
        private String room;
        //  Management field
        private Doctors doctorList;
        private Patients patientList;
        // Dynamic field
        static Scanner input = new Scanner(System.in);
        // Properties(getter and setter)

        

        public String getId() {
            return id;
        }
        public void setId(String id) {
            this.id = id;
        }
        public String getName() {
            return name;
        }
        public void setName(String name) {
            this.name = name;
        }
        public String getDescription() {
            return description;
        }
        public void setDescription(String description) {
            this.description = description;
        }
        public String getRoom() {
            return room;
        }
        public void setRoom(String room) {
            this.room = room;
        }
        public Doctors getDoctorList() {
            return doctorList;
        }
        public void setDoctorList(Doctors doctorList) {
            this.doctorList = doctorList;
        }
        public Patients getPatientList() {
            return patientList;
        }
        public void setPatientList(Patients patientList) {
            this.patientList = patientList;
        }
        
        // Constructors
       
        public Faculty()
        {
            doctorList = new Doctors();
            patientList = new Patients();

        }
        public Faculty(String id, String name, String description, String room, Doctors doctorList,
                Patients patientList) {
            this.id = id;
            this.name = name;
            this.description = description;
            this.room = room;
            this.doctorList = doctorList;
            this.patientList = patientList;
        }

        // Destructors
 

        // Methods
        // in, output
        public void Input()
        {
            System.out.println("ID: ");
            id = System.in.toString();
            System.out.println("Name: ");
            name = System.in.toString();
            System.out.println("Description: ");
            description = System.in.toString();
        }

        public  void Input1()
        {
            System.out.println("ID: ");
            id = System.in.toString();
            System.out.println("Name: ");
            name = System.in.toString();
            System.out.println("Description: ");
            description = System.in.toString();
            System.out.println("List of doctors: ");
            System.out.println("Number of doctors: ");
            int i = input.nextInt();

            for (int j = 0; j < i; j++)
            {
                Doctor doctor = new Doctor();
                doctorList.AddItem(doctor);
            }

            
            System.out.println ("The patient list: ");
            System.out.println("Number of patient in charge: ");
            int k = input.nextInt();

            for (int j = 0; j < k; j++)
            {
                Patient patient = new Patient();
                patientList.AddItem(patient);
            }
        }

        public  void Output()
        {
            System.out.println("The faculty");
            System.out.format("Id: %s\n", this.id);
            System.out.format("Name: %s\n", this.name);
            System.out.format("Description: %s\n", this.description);
            System.out.format("Room: %s\n", this.room);
            System.out.format("The patients list: \n");
            patientList.ShowInformation();
            System.out.format("The doctors list: \n");
            doctorList.ShowInformation();
        }
        // General method
        // Other method
        // Overriding
    }