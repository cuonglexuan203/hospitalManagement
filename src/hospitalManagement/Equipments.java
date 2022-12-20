package hospitalManagement;

import java.util.ArrayList;
import java.util.Scanner;

public class Equipments implements IBasicActivities<Equipment> {

	//Field
    private ArrayList<Equipment> equipmentList;
    

	private long count;

    // Infor field
    //  Management field
    // Dynamic field
    // Properties
	public ArrayList<Equipment> getEquipmentList() {
		return equipmentList;
	}
	public void setEquipmentList(ArrayList<Equipment> equipmentList) {
		this.equipmentList = equipmentList;
	}
	public long getCount() {
		return count;
	}
	public void setCount(long count) {
		this.count = count;
	}

    // Constructors
    public Equipments()
    {
        equipmentList = new ArrayList<Equipment>();
        count = 0;
    }
    public Equipments(ArrayList<Equipment> equipmentList, long count)
    {
        this.equipmentList = equipmentList;
        this.count = count;
    }
    // Destructors

    // Methods
    // in, output
    // General method
    // Other method
    public void AddItem()
    {
    	Scanner ip = new Scanner(System.in);
        System.out.println("New the equipment");
        System.out.println("Type of equipment(choose one): 1.Medical 2.Movement\n");
        String choice = ip.next();
        Equipment equipment = null;
        if (choice.toLowerCase() == "medical" || Integer.parseInt(choice) == 1)
        {
            equipment = new MedicalEquipment();
        }
        else
        {
            System.out.println("Choose type of the movement transportation:");
            int index = 0;
            int choiceTransportation = 0;
            String[] em = { "Ambulance" };
            String[] nonEm = { "WheelChair", "AmbulatoryTransportation", "FlightEscort", "Stretcher"  };
            while (index < em.length)
            {
                System.out.format("%d. %s\n", index,em[index++]);
            }
            while (index - em.length < nonEm.length)
            {
                System.out.format("%d. %s\n", index,nonEm[index++ - em.length] );
            }
            choiceTransportation = ip.nextInt();
            switch (choiceTransportation)
            {
                case 0:
                    equipment = new Ambulance();
                    break;
                case 1:
                    equipment = new WheelChair();
                    break;
                case 2:
                    equipment = new AmbulatoryTransportation();
                    break;
                case 3:
                    equipment = new FlightEscort();
                    break;
                case 4:
                    equipment = new Stretcher();
                    break;
            };
        }
        equipment.Input();
        equipmentList.add(equipment);
        this.count++;
        System.out.println("Done!");
        ip.close();
    }

    public boolean Clear()
    {
        System.out.println("Clear all equipments");

        equipmentList.clear();
        this.count = 0;
        System.out.println("Done!");

        return true;
    }

    public Equipment FindItem(String id)
    {
        System.out.println("Find the equipment");

        Equipment res = null;
        for(var value: equipmentList) {
        	if(value.getId() == id) {
        		res = value;
        	}
        }
        if (res == null)
        {
            System.out.format("Not found equipment with id: %s\n",id);

        }
        else
        {
            System.out.println("Had found!");

        }
        return res;
    }

    public boolean RemoveItem(String id)
    {
        System.out.println("Remove the equipment");

        boolean res = false;
        Equipment temp = null;
        for (var value : equipmentList)
        {
            if (value.getId() == id)
            {
                temp = value;
                res = true;
                this.count--;
            }
        }
        equipmentList.remove(temp);
        if (res == false)
        {
            System.out.format("Not found equipment with id: %s\n",id);
        }
        else
        {
            System.out.println("Done!");

        }
        return res;
    }

    public void ShowInformation()
    {

        System.out.println("\tShow information of all equipments");

        equipmentList.forEach((value)->
        {
            value.Output();
            System.out.println();
        });
        System.out.println("Done!");
    }

    public Equipment UpdateItem(String id)
    {
        System.out.println("Update the equipment");
        Equipment res = null;
        for(var value: equipmentList){
        	if(value.getId() == id){
        	res = value;
        	}
        }
        if (res == null)
        {
            System.out.format("Not found equipment with id: %s\n",id);
        }
        else
        {
            System.out.println("Done!");
        }
        return res;
    }

    // Overriding
    

}
