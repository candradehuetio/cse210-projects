public class Customer
{
    private string _name;
    private Address _addres;

    public Customer(string name, Address address)
    {
        _name = name;
        _addres = address;
    }

    public bool IsFromUsa()
    {
        return _addres.IsInUsa();
    }

    public string GetNameAddress()
    {
        return $"Customer: {_name} Address: {_addres.GetAddress()}";
    }


    

}