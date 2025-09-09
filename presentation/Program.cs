/********************************************************************************************************
 * Name: Sam Leal 
 * Role: Full Stack Developer 
 * Company: MPIUA/RIJRA 
 * Date: 09/08/2025 
 * Description: Demonstration project for PPT presentation on GitHub Integration in Visual Studio 2022. 
 *******************************************************************************************************/
public class Program
{
    public static void Main(string[] args)
    {
        // get input from the user 
        Console.Write("Please enter the value of the Home in USD: ");
        double valueOfHome = Double.Parse(Console.ReadLine()!);

        // compute the yearly premium amount 
        double premiumAmount = ComputePremiumAmount(valueOfHome);

        // compute the monthly premium amount 
        double monthlyAmount = ComputeMonthlyAmount(premiumAmount);

        // display results 
        Console.WriteLine("Home Value: " +  valueOfHome);
        Console.WriteLine("Premium Amount: " + premiumAmount);
        Console.WriteLine("Monthly Amount: " + monthlyAmount);
    }
    private static double ComputePremiumAmount(double valueOfHome)
    {
        return (valueOfHome * 0.00125 * 5);
    }
    private static double ComputeMonthlyAmount(double premiumAmount)
    {
        return (premiumAmount / 12);
    }
}
