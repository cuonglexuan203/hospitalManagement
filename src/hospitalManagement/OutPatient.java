package hospitalManagement;

import java.util.Scanner;
public class OutPatient extends Patient
    {
        //Field	
        // Information field	
        // Management field	
        private String ordinalNumber;
        private String appointmentDate;
        // Dynamic field
        static Scanner input = new Scanner(System.in);
	
        // Properties

        
        public String getOrdinalNumber() {
            return ordinalNumber;
        }

        public void setOrdinalNumber(String ordinalNumber) {
            this.ordinalNumber = ordinalNumber;
        }

        public String getAppointmentDate() {
            return appointmentDate;
        }

        public void setAppointmentDate(String appointmentDate) {
            this.appointmentDate = appointmentDate;
        }

        // Constructors	
        public OutPatient()
        {

        }

        public OutPatient(String ordinalNumber, String appointmentDate)
        {
            this.ordinalNumber = ordinalNumber;
            this.appointmentDate = appointmentDate;
        }

        public OutPatient(String firstName
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
        , String ordinalNumber
        , String appointmentDate) 
        {
            super(firstName, lastName, dateOfBirth, ethnic, religion, nationality, numberOfHealthInsurance, career, address, phonenumber, gentle, relative, phoneNumberOfRelative, fees, admissionDates);
            
            this.ordinalNumber = ordinalNumber;
            this.appointmentDate = appointmentDate;
        }



        // Methods	

        // in, output

        // General method

        // Other method	

        // Overriding	

        public  void Input()
        {
            super.Input();
            System.out.println("Ordinal Number: ");
            ordinalNumber = input.nextLine();
            System.out.println("Appointment Date: ");
            appointmentDate = input.nextLine();
        }


        public void Output()
        {
            super.Output();
            System.out.println("Ordinal Number: " + ordinalNumber);
            System.out.println("Appointment Date: " + appointmentDate);
        }

        public void ExportBill()
        {
            super.ExportBill();
        }

        public float CalcBill()
        {
            return super.CalcBill();
        }

        public String ToString()
        {
            return super.ToString();
        }

    }