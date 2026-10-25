namespace RestaurantApp.Models;


public class Dish
{
    public decimal _price;
    
    public string Name { get; }
    public string Category { get; }

    public decimal Price
    {
        get => _price;
        private set
        {
            if (value > 0)
            {
                _price = value;
            }
        }
    }
    public int CookingTime { get; }
    public bool IsVegeterian { get; }

    public Dish(string name, string category, decimal price, int cookingTime, bool isVegeterian)
    {
        Name = name;
        Category = category;
        Price = price;
        CookingTime = cookingTime;
        IsVegeterian = isVegeterian;
    }
}


