namespace Coursework2.Models.Payments;

public class PayByMobileMoney: IPaymentStarategy
{
    private readonly Double tax = 0.01;
    
    private string Number { get; set; }
    
    public string MakePayment()
    {
        return "Payment made successfully";
    }

    public void CollectPaymentDetails()
    {
        throw new NotImplementedException();
    }
}