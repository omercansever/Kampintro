namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndıvidualCustomer customer1= new IndıvidualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Ömercan";
            customer1.Surname = "Cansever";
            customer1.TcNo = "1234567890";


            CoorporateCustomer customer2= new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.Company = "Kodlama.İo";
            customer2.TaxNo = "0987654321";


            Customer customer3 = new IndıvidualCustomer();
            Customer customer4 = new CoorporateCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}