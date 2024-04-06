public class Product
{
    private string _name;
    private int _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public override string ToString()
    {
        return $"{_name} (ID: {_productId})";
    }
}