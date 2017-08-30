using System;

public class Order
{
    public int Id { get; set; }

    public string OrderNumber { get; set; }

    public DateTime OrderedOn { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public decimal TotalAmount { get; set; }

    public OrderStatus Orderstatus{ get; set; }
}
public enum PaymentMethod
{
    weixin,

    zhifubao

}
public enum OrderStatus
{
    Open,
    Cancelled,
}