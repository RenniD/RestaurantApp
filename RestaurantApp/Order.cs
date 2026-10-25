namespace RestaurantApp.Models;

public class Order
{
    public List<Dish> _dishes;
    
    public int Number { get; }
    public int TableNumber { get; }
    public string Status { get; private set; }
    public int DishesCount { get; private set; }

    public Order(int number, int tableNumber, string status, int dishesCount)
    {
        Number = number;
        TableNumber = tableNumber;
        Status = status;
        DishesCount = dishesCount;
    }
}