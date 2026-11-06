namespace MiniMes.Core;

public class WorkOrder
{
    public int Id { get; set; }
    public string OrderNo { get; set; } = "";
    public string ProductName { get; set; } = "";
    public int Quantity { get; set; }
    public WorkOrderStatus Status { get; set; } = WorkOrderStatus.NotStarted;
}