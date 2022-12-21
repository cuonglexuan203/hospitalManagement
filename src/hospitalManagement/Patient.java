package hospitalManagement;

import java.util.Scanner;

public class Patient implements IBill
    {
        //Field	
        private String id;

        // Information field	
        private String firstName;
        private String lastName;
        private String dateOfBirth;
        private String ethnic;
        private String religion;
        private String nationality;
        private String numberOfHealthInsurance;
        private String career;
        private String address;
        private String phoneNumber;
        private int gentle;
        private String relative;
        private String phoneNumberOfRelative;

        // Management field
        private Fee fees;
        private ComeAndLeaveDate admissionDates;

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

        public String getDateOfBirth() {
            return dateOfBirth;
        }

        public void setDateOfBirth(String dateOfBirth) {
            this.dateOfBirth = dateOfBirth;
        }

        public String getEthnic() {
            return ethnic;
        }

        public void setEthnic(String ethnic) {
            this.ethnic = ethnic;
        }

        public String getReligion() {
            return religion;
        }

        public void setReligion(String religion) {
            this.religion = religion;
        }

        public String getNationality() {
            return nationality;
        }

        public void setNationality(String nationality) {
            this.nationality = nationality;
        }

        public String getNumberOfHealthInsurance() {
            return numberOfHealthInsurance;
        }

        public void setNumberOfHealthInsurance(String numberOfHealthInsurance) {
            this.numberOfHealthInsurance = numberOfHealthInsurance;
        }

        public String getCareer() {
            return career;
        }

        public void setCareer(String career) {
            this.career = career;
        }

        public String getAddress() {
            return address;
        }

        public void setAddress(String address) {
            this.address = address;
        }

        public String getPhonenumber() {
            return phoneNumber;
        }

        public void setPhonenumber(String phonenumber) {
            this.phoneNumber = phonenumber;
        }

        public int getGentle() {
            return gentle;
        }

        public void setGentle(int gentle) {
            this.gentle = gentle;
        }

        public String getRelative() {
            return relative;
        }

        public void setRelative(String relative) {
            this.relative = relative;
        }

        public String getPhoneNumberOfRelative() {
            return phoneNumberOfRelative;
        }

        public void setPhoneNumberOfRelative(String phoneNumberOfRelative) {
            this.phoneNumberOfRelative = phoneNumberOfRelative;
        }

        public Fee getFees() {
            return fees;
        }

        public void setFees(Fee fees) {
            this.fees = fees;
        }

        public ComeAndLeaveDate getAdmissionDates() {
            return admissionDates;
        }

        public void setAdmissionDates(ComeAndLeaveDate admissionDates) {
            this.admissionDates = admissionDates;
        }

        //
        // Constructors	
        public Patient()
        {
            fees = new Fee();
            admissionDates = new ComeAndLeaveDate();
        }

        public Patient(String firstName
        , String lastName
        , String dateOfBirth
        , String ethnic
        , String religion
        , String nationality
        , String numberOfHealthInsurance
        , String career
        , String address
        , String phonenumber
        , int gentle
        , String relative
        , String phoneNumberOfRelative
        , Fee fees
        , ComeAndLeaveDate admissionDates
        )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.ethnic = ethnic;
            this.religion = religion;
            this.nationality = nationality;
            this.numberOfHealthInsurance = numberOfHealthInsurance;
            this.career = career;
            this.address = address;
            this.phoneNumber = phonenumber;
            this.gentle = gentle;
            this.relative = relative;
            this.phoneNumberOfRelative = phoneNumberOfRelative;
            this.fees = fees;
            this.admissionDates = admissionDates;
        }


       
        // Methods	

        // in, output
        public void Input(String firstName,
                     String lastName,
                     String dateOfBirth,
                     String ethnic,
                     String religion,
                     String nationality,
                     String numberOfHealthInsurance,
                     String career,
                     String address,
                     String phonenumber,
                     int gentle,
                     String relative,
                     String phoneNumberOfRelative,
                     Fee fees,
                     ComeAndLeaveDate admissionDates
                     )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.ethnic = ethnic;
            this.religion = religion;
            this.nationality = nationality;
            this.numberOfHealthInsurance = numberOfHealthInsurance;
            this.career = career;
            this.address = address;
            this.phoneNumber = phonenumber;
            this.gentle = gentle;
            this.relative = relative;
            this.phoneNumberOfRelative = phoneNumberOfRelative;
            this.fees = fees;
            this.admissionDates = admissionDates;
            
        }
        public void Input()
        {
            System.out.println("Id: ");
            id = input.nextLine();
            System.out.println("FirstName: ");
            firstName = input.nextLine();
            System.out.println("LastName: ");
            lastName = input.nextLine();
            System.out.println("DateOfBirth: ");
            dateOfBirth = input.nextLine();
            System.out.println("Ethnic: ");
            ethnic = input.nextLine();
            System.out.println("Religion: ");
            religion = input.nextLine();
            System.out.println("Nationality: ");
            nationality = input.nextLine();
            System.out.println("NumberOfHealthInsurance: ");
            numberOfHealthInsurance = input.nextLine();
            System.out.println("Career: ");
            career = input.nextLine();
            System.out.println("Address: ");
            address = input.nextLine();
            System.out.println("Phonenumber: ");
            phoneNumber = input.nextLine();
            System.out.println("Gentle: ");
            gentle = input.nextInt() == 0 ? 0 : 1;
            System.out.println("Relative: ");
            relative = input.nextLine();
            System.out.println("PhoneNumberOfRelative: ");
            phoneNumberOfRelative = input.nextLine();
            System.out.println("Fees: ");
            fees.Input();
            System.out.println("AdmissionDates: ");
            admissionDates.Input();
            
        }
        public  void Output()
        {
            System.out.format("Id: %s", this.id);
            System.out.format("FirstName: %s\n", this.firstName);
            System.out.format("LastName: %s\n", this.lastName);
            System.out.format("DateOfBirth: %s\n", this.dateOfBirth);
            System.out.format("Ethnic: %s\n", this.ethnic);
            System.out.format("Religion: %s\n", this.religion);
            System.out.format("Nationality: %s\n", this.nationality);
            System.out.format("NumberOfHealthInsurance: %s\n", this.numberOfHealthInsurance);
            System.out.format("Career: %s\n", this.career);
            System.out.format("Address: %s\n", this.address);
            System.out.format("PhoneNumber: %s\n", this.phoneNumber);
            System.out.format("Gentle: %s\n", this.gentle);
            System.out.format("Relative: %s\n", this.relative);
            System.out.format("PhoneNumberOfRelative: %s\n", this.phoneNumberOfRelative);
            System.out.format("Fees: %s\n", this.fees);
            System.out.format("AdmissionDates: %s\n", this.admissionDates);
        }


        // General method

        // Other method	



        // Overriding	
        public String ToString(){
       return "Id: " + id
       + "\nFirstName: " + firstName
       + "\nLastName: " + lastName
       + "\nDateOfBirth: " + dateOfBirth
       + "\nEthnic: " + ethnic
       + "\nReligion: " + religion
       + "\nNationality: " + nationality
       + "\nNumberOfHealthInsurance: " + numberOfHealthInsurance
       + "\nCareer: " + career
       + "\nAddress: " + address
       + "\nPhonenumber: " + phoneNumber
       + "\nGentle: " + gentle
       + "\nRelative: " + relative
       + "\nPhoneNumberOfRelative: " + phoneNumberOfRelative
       + "\nFees: " + fees
       + "\nAdmissionDates: " + admissionDates;
        }

        public void ExportBill()
        {

            System.out.println("             RECEIPT             ");
            System.out.format("ID of patient: %s\n", this.id);
            System.out.println("Fullname of patient: " + firstName + " " + lastName);
            System.out.format("Number of Health Insurance: %s\n", this.numberOfHealthInsurance);
            float temp = CalcBill();
            System.out.println("Subtotal: " + temp);
            System.out.println("Tax: " +temp * 8 / 100);
            System.out.println("TOTAL: " + temp + (temp * 8 / 100));
        }

        public float CalcBill(){
        
            return fees.getDrugCosts() + fees.getTreatmentCosts() + fees.getAdvanceFee();
        }

    }