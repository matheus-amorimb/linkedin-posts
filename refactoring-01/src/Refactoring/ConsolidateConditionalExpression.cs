namespace Refactoring;

public class ConsolidateConditionalExpression
{
    public double GetDiscountPercent(Customer customer)
    {
        if (customer.Age >= 60)
        {
            return 0.1;
        }

        if (customer.HasPrimeSubscription)
        {
            return 0.1;
        }

        if (customer.TotalPurchases > 1000)
        {
            return 0.1;
        }
        
        if (customer.isFirstPurchase)
        {
            return 0.1;
        }

        return 0.05;
    }

    public double GetDiscountPercentRefactored(Customer customer)
    {
        return IsEligibleForDiscount(customer) ? 0.1 : 0.05;
    }
    
    private bool IsEligibleForDiscount(Customer customer)
    {
        return customer.Age >= 60 ||
               customer.HasPrimeSubscription ||
               customer.TotalPurchases > 1000 || 
               customer.isFirstPurchase;
    }
}