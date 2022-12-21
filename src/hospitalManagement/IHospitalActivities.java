package hospitalManagement;

public interface IHospitalActivities {
	void AddFaculty();
    void AddRepository();
    void RemoveFaculty(String id);
    void RemoveRepository(String id);
    void ShowFaculty(String id);
    void ShowRepository(String id);
    void ShowAllFaculty();
    void ShowAllRepository();
    void UpdateFaculty(String id);
    void UpdateRepository(String id);
    void ClearFaculty();
    void ClearRepository();
}
