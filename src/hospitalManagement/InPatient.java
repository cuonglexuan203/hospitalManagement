package hospitalManagement;
import java.util.Scanner;

public class InPatient extends Patient {
    //Field	
        // Information field	
        private String room;

        // Management field	
        // Dynamic field
        static Scanner input = new Scanner(System.in);
        // Properties	

        public String getRoom() {
            return room;
        }

        public void setRoom(String room) {
            this.room = room;
        }

        // Constructors	
        public InPatient()
        {

        }

        public InPatient(String firstName
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
        , String room) 
        {
            super(firstName, lastName, dateOfBirth, ethnic, religion, nationality, numberOfHealthInsurance, career, address, phonenumber, gentle, relative, phoneNumberOfRelative, fees, admissionDates);
            
            this.room = room;
        }

        // Methods	

        // in, output

        // General method

        // Other method	

        // Overriding	
        public void Input()
        {
            super.Input();
            System.out.println("Room: ");
            room = input.nextLine();
        }

        public void Output()
        {
            super.Output();
            System.out.println("Room: " + room);
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
