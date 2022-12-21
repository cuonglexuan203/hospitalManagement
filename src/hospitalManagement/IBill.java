package hospitalManagement;

public interface IBill {
    void ExportBill();
    float CalcBill(); // calculate salary if doctor, calculate fee if patient
}
