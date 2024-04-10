namespace Coursework2.Models.Payments;

public interface IPaymentStarategy
{
    public abstract String MakePayment();
    public abstract void CollectPaymentDetails();
}