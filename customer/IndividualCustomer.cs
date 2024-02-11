namespace customer;

public class IndividualCustomer : BaseCustomer
{

    public string CustomerNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

public class CorporateCustomer : BaseCustomer
{

}

public class BaseCustomer
{
    public int Id { get; set; }

}