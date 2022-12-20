package hospitalManagement;

public interface IBasicActivities<T> {
	 // 
    void AddItem();
    void ShowInformation();
    T UpdateItem(String id);
    boolean RemoveItem(String id);
    T FindItem(String id);
    boolean Clear();
}
