package hospitalManagement;

import java.util.Scanner;
public abstract class Employee implements IBill 
    {
        //Field
        private String id;

        // Infor field
        private String firstName;

        private String lastName;

        private int age;

        private int gentle;

        private String description;

        private String address;

        private String email;

        private String phone;

        //  Management field
        private String facultyId;

        private String departmentId;

        private Boolean state;


        private ComeAndLeaveDate admissionDates;

        private Salary salaries;

        // Dynamic field
        static Scanner input = new Scanner(System.in);

        // Properties
        public String getId() {
            return id;
        }

        public void setId(String id) {
            this.id = id;
        }

        public String getFirstName() {
            return firstName;
        }

        public void setFirstName(String firstName) {
            this.firstName = firstName;
        }

        public String getLastName() {
            return lastName;
        }

        public void setLastName(String lastName) {
            this.lastName = lastName;
        }

        public int getAge() {
            return age;
        }

        public void setAge(int age) {
            this.age = age;
        }

        public int getGentle() {
            return gentle;
        }

        public void setGentle(int gentle) {
            this.gentle = gentle;
        }

        public String getDescription() {
            return description;
        }

        public void setDescription(String description) {
            this.description = description;
        }

        public String getAddress() {
            return address;
        }

        public void setAddress(String address) {
            this.address = address;
        }

        public String getEmail() {
            return email;
        }

        public void setEmail(String email) {
            this.email = email;
        }

        public String getPhone() {
            return phone;
        }

        public void setPhone(String phone) {
            this.phone = phone;
        }

        public String getFacultyId() {
            return facultyId;
        }

        public void setFacultyId(String facultyId) {
            this.facultyId = facultyId;
        }

        public String getDepartmentId() {
            return departmentId;
        }

        public void setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
        }

        public Boolean getState() {
            return state;
        }

        public void setState(Boolean state) {
            this.state = state;
        }

        public ComeAndLeaveDate getAdmissionDates() {
            return admissionDates;
        }

        public void setAdmissionDates(ComeAndLeaveDate admissionDates) {
            this.admissionDates = admissionDates;
        }

        public Salary getSalaries() {
            return salaries;
        }

        public void setSalaries(Salary salaries) {
            this.salaries = salaries;
        }
        
        // Constructors

        public Employee() { }

        public Employee (String Id
        , String firstName
        , String lastName
        , int age
        , int gentle
        , String description
        , String address
        , String email
        , String phone
        , String facultyId
        , String departmentId
        , Boolean state
        , ComeAndLeaveDate admissionDates
        , Salary salaries)
        {
            this.id = Id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gentle = gentle;
            this.description = description;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.facultyId = facultyId;
            this.departmentId = departmentId;
            this.state = state;
            this.admissionDates = admissionDates;
            this.salaries = salaries;
        }


        // Destructors
        // Methods
        // in, output
        public  void Input()
        {
            System.out.println("Employee Id: ");
            id = input.nextLine();
            System.out.println("FirstName: ");
            firstName = input.nextLine();
            System.out.println("LastName: ");
            lastName = input.nextLine();
            System.out.println("Age: ");
            age = input.nextInt();
            System.out.println("Gentle (0: male, 1: female): ");
            gentle = input.nextInt();
            System.out.println("Description: ");
            description = input.nextLine();
            System.out.println("Address: ");
            address = input.nextLine();
            System.out.println("Email: ");
            email = input.nextLine();
            System.out.println("Phone: ");
            phone = input.nextLine();
            System.out.println("FacultyId: ");
            facultyId = input.nextLine();
            System.out.println("DepartmentId: ");
            departmentId = input.nextLine();
            System.out.println("State(1: free, other: 0): ");
            state = input.nextInt() == 1 ? true : false;
            System.out.println("AdmissionDates: ");
            admissionDates.Input();
            System.out.println("Salaries: ");
            salaries.Input();

            
        }
        public void Output()
        {
            System.out.format("Employee Id: %s\n", id);
            System.out.format("FirstName: %s\n", firstName);
            System.out.format("LastName: %s\n}", lastName);
            System.out.format("Age: %d", age);
            System.out.format("Gentle: %d\n", gentle);
            System.out.format("Description: %s\n", description);
            System.out.format("Address: %s\n", address);
            System.out.format("Email: %s\n%s\n", email);
            System.out.format("Phone: %s\n", phone);
            System.out.format("FacultyId: %s\n", facultyId);
            System.out.format("DepartmentId: %s\n", departmentId);
            System.out.format("State: " + state +" \n");
            System.out.format("The patient list: ");
            System.out.format("AdmissionDates: %s\n", admissionDates);
            System.out.format("Salaries: " + salaries +" \n");

        }

        // General method
        // Other method
        // Overriding
        public void ExportBill()
        {

            System.out.format("The salary ( basis + bonus, allowance ): " + CalcBill() + " \n");
        }
        public float CalcBill(){
            return salaries.getBasic() + salaries.getBonus() + salaries.getAllowance();
        }

    }