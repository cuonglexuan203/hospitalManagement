package hospitalManagement;

public interface IRepositoryActivities {
	 //
    void AddMedicine();
    void RemoveMedicine(String id);
    Medicine FindMedicine(String id);
    Medicine UpdateMedicine(String id);
    void ClearMedicine();
    //
    void AddEquipment();
    void RemoveEquipment(String id);
    Equipment FindEquipment(String id);
    Equipment UpdateEquipment(String id);
    void ClearEquipment();
}
