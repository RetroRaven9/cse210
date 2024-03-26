public class Customer:Adress
{
    public string _name;

    public string _email;


    public void customer()
    {
        List<Customer> customerList = new List<Customer>();

        Customer customer1 = new Customer();
        customer1._name = "Mason";
        customer1._email = "Mason@example.com";
        customerList.Add(customer1);

        Customer customer2 = new Customer();
        customer2._name = "Jacob";
        customer2._email = "Jacob@example.com";
        customerList.Add(customer2);

         Customer customer3 = new Customer();
        customer3._name = "Mitch";
        customer3._email = "Rhoades@example.com";
        customerList.Add(customer3);

        Customer customer4 = new Customer();
        customer4._name = "Nick";
        customer4._email = "nick@example.com";
        customerList.Add(customer4);

        
        
    }
}