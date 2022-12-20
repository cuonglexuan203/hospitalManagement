package hospitalManagement;

import java.util.Scanner;

public class Medicine {
	//Field
    private String id;
    // Infor field
    private String name;
    private String description;
    private String type;
    private String dosage;
    private String storage;
    private float weight;
    private String serialNumber;
    private ComeAndLeaveDate expiryDate;


    //  Management field
    // Dynamic field
    // Properties
   

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
	public String getType() {
		return type;
	}
	public void setType(String type) {
		this.type = type;
	}
	public String getDosage() {
		return dosage;
	}
	public void setDosage(String dosage) {
		this.dosage = dosage;
	}
	public String getStorage() {
		return storage;
	}
	public void setStorage(String storage) {
		this.storage = storage;
	}
	public float getWeight() {
		return weight;
	}
	public void setWeight(float weight) {
		this.weight = weight;
	}
	public String getSerialNumber() {
		return serialNumber;
	}
	public void setSerialNumber(String serialNumber) {
		this.serialNumber = serialNumber;
	}
	public ComeAndLeaveDate getExpiryDate() {
		return expiryDate;
	}
	public void setExpiryDate(ComeAndLeaveDate expiryDate) {
		this.expiryDate = expiryDate;
	}
	
	// Constructors
    public Medicine()
    {
        expiryDate = new ComeAndLeaveDate();
    }
    public Medicine(String id
        , String name
        , String description
        , String type
        , String dosage
        , String storage
        , float weight
        , String serialNumber
        , ComeAndLeaveDate expiryDate)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.type = type;
        this.dosage = dosage;
        this.storage = storage;
        this.weight = weight;
        this.serialNumber = serialNumber;
        this.expiryDate = expiryDate;
    }
    // Destructors
    
    // Methods
    // in, output
    public void Input()
    {
    	Scanner input = new Scanner(System.in);
        System.out.format("Id: ");
        id = input.nextLine();
        System.out.format("Name: ");
        name = input.nextLine();
        System.out.format("Description: ");
        description = input.nextLine();
        System.out.format("Type: ");
        type = input.nextLine();
        System.out.format("Dosage: ");
        dosage = input.nextLine();
        System.out.format("Storage: ");
        storage = input.nextLine();
        System.out.format("Weight: ");
        weight = input.nextInt();
        System.out.format("The serial number: ");
        serialNumber = input.nextLine();
        System.out.format("The expiry date: \n");
        expiryDate.Input();
        input.close();
    }
    public void Output()
    {                     
        System.out.format("Id: %s\n", id);
        System.out.format("Name: %s\n", name);
        System.out.format("Description: %s\n", description);
        System.out.format("Type: %s\n", type);
        System.out.format("Dosage: %s\n", dosage);
        System.out.format("Storage: %s\n", storage);
        System.out.format("Weight: %d", weight);
        System.out.format("SerialNumber: %s\n", serialNumber);
        expiryDate.Output();
    }



    // General method

    // Other method


    // Overriding
    public  String toString()
    {
    	return "Id: " + id
			    + "\nName: " + name
			    + "\nDescription: " + description
			    + "\nType: " + type
			    + "\nDosage: " + dosage
			    + "\nStorage: " + storage
			    + "\nWeight: " + weight
			    + "\nSerialNumber: " + serialNumber
			    + "\n" + expiryDate;
    }
}
