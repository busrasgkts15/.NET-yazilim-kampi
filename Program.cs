using customer;

IndividualCustomer customer1 = new IndividualCustomer();

customer1.Id = 1;
customer1.FirstName = "Büşra";

IndividualCustomer customer2 = new IndividualCustomer();

customer2.Id = 2;
customer2.FirstName = "Özge";

BaseCustomer[] customers = { customer1, customer2 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.Id);

}