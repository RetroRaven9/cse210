using System.Net.Sockets;

public class Adress
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;

    public Adress(string street, string city, string state, string zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;


    }

    public static void adress(string street, string city, string state, string zip, string country)
    {
        List<Adress> adressList = new List<Adress>();

        Adress adress1 = new Adress("123 Main Street", "Dallas", "TX", "75201", "United States");
        adressList.Add(adress1);

        Adress adress2 = new Adress("456 Oak Street", "Idaho Falls", "ID", "83406", "United States");
        adressList.Add(adress2);

        Adress adress3 = new Adress("789 Pine Street", "Provo", "UT", "23454", "United States");
        adressList.Add(adress3);

        Adress adress4 = new Adress("567 Elm Street", "Santa Fe", "NM", "78701", "United States");
        adressList.Add(adress4);

        Adress adress5 = new Adress("901 Maple Street", "Denver", "CO", "98765", "United States");
        adressList.Add(adress5);

        Adress adress6 = new Adress("123 Roxas", "Baguio", "PH-BEN", "98765", "Phillipines");
        adressList.Add(adress6);


    }
}