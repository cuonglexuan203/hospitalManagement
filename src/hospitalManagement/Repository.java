package hospitalManagement;

import java.util.Scanner;

public class Repository {
  //Field
  private String id;

  // Infor field
  private String name;
  private String description;
  private String room;
  //  Management fields
  private Medicines medicineList;
  private Equipments equipmentList;

  // Dynamic field
  private static Scanner input = new Scanner(System.in);

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

  public String getRoom() {
    return room;
  }

  public void setRoom(String room) {
    this.room = room;
  }

  public Medicines getMedicineList() {
    return medicineList;
  }

  public void setMedicineList(Medicines medicineList) {
    this.medicineList = medicineList;
  }

  public Equipments getEquipmentList() {
    return equipmentList;
  }

  public void setEquipmentList(Equipments equipmentList) {
    this.equipmentList = equipmentList;
  }

  // Constructors
  public Repository() {
    medicineList = new Medicines();
    equipmentList = new Equipments();
  }

  public Repository(
    String id,
    String name,
    String description,
    String room,
    Medicines medicinesList,
    Equipments equipmentsList
  ) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.room = room;
    this.medicineList = medicinesList;
    this.equipmentList = equipmentsList;
  }

  // Destructors

  // Methods
  // in, output
  public void Input() {
    System.out.print("Id: ");
    id = input.nextLine();
    System.out.print("Name: ");
    name = input.nextLine();
    System.out.print("Description: ");
    description = input.nextLine();
    System.out.print("Room number: ");
    room = input.nextLine();
  }

  public void Output() {
    System.out.format("The repository");
    System.out.format("Id: %s", id);
    System.out.format("Name: %s",name);
    System.out.format("Description: %s", description);
    System.out.format("Room: %s",room);
    System.out.format("The equipment list: %d",medicineList.Count + equipmentList.Count);
    System.out.format("The medicine list: %d",medicineList.Count);
    medicineList.ShowInformation();
    System.out.format("The equipment list: %d",equipmentList.Count);
    equipmentList.ShowInformation();
  }
  // General method

  // Overriding
  public String toString() {
	  return "Id: " + id +
			  "\nName: " + name +
			  "\nDescription: " + description +
	          "\nRoom: " + room +
	          "\nMedicines count:  " + medicinesList.Count +
	          "\nEquipment count: " + equipmentsList.Count;
  }
}
