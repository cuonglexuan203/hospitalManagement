package hospitalManagement;

import java.util.Scanner;

public class ComeAndLeaveDate {
	 //Field
    private String hospitalAdmissionDate;
    private String hospitalDischargeDate;
    static Scanner input = new Scanner(System.in);


    // Infor field
    //  Management field
    // Dynamic field
    // Properties
    public String getHospitalAdmissionDate() {
		return hospitalAdmissionDate;
	}
	public void setHospitalAdmissionDate(String hospitalAdmissionDate) {
		this.hospitalAdmissionDate = hospitalAdmissionDate;
	}
	public String getHospitalDischargeDate() {
		return hospitalDischargeDate;
	}
	public void setHospitalDischargeDate(String hospitalDischargeDate) {
		this.hospitalDischargeDate = hospitalDischargeDate;
	}

    // Constructors
    public ComeAndLeaveDate() 
    {
        
    }
   
	public ComeAndLeaveDate(String hospitalAdmissionDate, String hospitalDischargeDate)
    {
        this.hospitalAdmissionDate = hospitalAdmissionDate;
        this.hospitalDischargeDate = hospitalDischargeDate;
    }
    // Destructors


    // Operators
    // Methods
    // in, Output
    public void Input()
    {
        System.out.format("hospitalAdmissionDate: ");
        this.hospitalAdmissionDate = input.nextLine();
        System.out.format("hospitalDischargeDate: ");
        this.hospitalDischargeDate = input.nextLine();
    }
    public void Input(String hospitalAdmissionDate, String hospitalDischargeDate)
    {
        this.hospitalAdmissionDate = hospitalAdmissionDate;
        this.hospitalDischargeDate = hospitalDischargeDate;
    }
    public void Output()
    {
        System.out.format("HospitalAdmissionDate: %s\n", this.getHospitalAdmissionDate());
        System.out.format("HospitalDischargeDate: %s\n", this.getHospitalDischargeDate());
    }
    // General method
    // Other method
    // Overriding
	@Override
	public String toString() {
		return "Hospital admission date: " + hospitalAdmissionDate + "\nHospital discharge date: "
				+ hospitalDischargeDate;
	}
	}
