package hospitalManagement;

import java.util.Scanner;

public class MedicalEquipment extends Equipment {
	 //
    // Field
    private String medicalType;
    private ComeAndLeaveDate expiryDate;

    // Infor field
    // Management field
    // Dynamic field
    // Properties

    public String getMedicalType() {
		return medicalType;
	}
	public void setMedicalType(String medicalType) {
		this.medicalType = medicalType;
	}
	public ComeAndLeaveDate getExpiryDate() {
		return expiryDate;
	}
	public void setExpiryDate(ComeAndLeaveDate expiryDate) {
		this.expiryDate = expiryDate;
	}
	// Constructors
    public MedicalEquipment()
    {
        expiryDate = new ComeAndLeaveDate();
    }
    public MedicalEquipment(String id
        , String name
        , String description
        , String type
        , float price
        , boolean state
        , String origin
        , String medicalType
        , int quantity
        , ComeAndLeaveDate expiryDate) 
    {
    	super(id, name, description, price, state, origin, quantity);
        this.medicalType = medicalType;
        this.expiryDate = expiryDate;
    }


    // Destructors

    // Methods
    // in, output
    public  void Input()
    {
    	Scanner ip = new Scanner(System.in);
        super.Input();
        System.out.print("Medical type: ");
        medicalType = ip.nextLine();
        expiryDate.Input();
        ip.close();
    }
    public  void Output()
    {
        System.out.format("The information of $s\n", this.getClass().getSimpleName());
        super.Output();
        System.out.format("Medical type: %s\n",medicalType);
        expiryDate.Output();
    }
    // General method
    // Other method
    // Overriding


    public String toString()
    {
    	return super.toString() +
    			"\nMedical type:" + medicalType +
    			"\n" +
    			expiryDate.toString();
    }
}
