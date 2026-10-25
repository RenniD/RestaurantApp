using RestaurantApp.Models;


Dish borsch = new Dish("Borsch", "Soup", 150m, 25, false);
Dish mushroomSoup = new Dish("Mushroom soup", "Soup", 150m, 25, true);
Dish greekSalad = new Dish("Greek salad", "Salad", 200m, 15, true);
Dish tunaSalad = new Dish("Tuna salad", "Salad", 175m, 15, false);
Dish cesarSalad = new Dish("Cesar salad", "Salad", 225m, 15, false);
Dish mashedPotatoesWithKievCutlet = new Dish("Mashed potatoes with Kiev cutlet", "Main", 300m, 25, false);
Dish riceWithChickenTeriyaki = new Dish("Rice with chicken teriyaki", "Main", 320m, 25, false);
Dish garlicYeastBuns = new Dish("Garlic yeast buns", "Side", 60m, 10, true);
Dish whiteBread = new Dish("White bread", "Side", 40m, 10, true);
Dish blackBread = new Dish("Black bread", "Side", 40m, 10, true);
Dish kompot = new Dish("Kompot", "Drink", 60m, 0, true);
Dish cokeZero = new Dish("Coke zero", "Drink", 60m, 0, true);
Dish sparklingWater = new Dish("Sparkling water", "Drink", 0, 0, true);
Dish stillgWater = new Dish("Still water", "Drink", 0, 0, true);

int orderOption = 20;
int choice = 20;

int tableChoice1 = 0;
int tableChoice2 = 0;
int tableChoice3 = 0;
int tableChoice4 = 0;
int tableChoice5 = 0;
int tableChoice6 = 0;
int tableChoice7 = 0;
int tableChoice8 = 0;

string order1Status = "";
string order2Status = "";
string order3Status = "";
string order4Status = "";
string order5Status = "";
string order6Status = "";
string order7Status = "";
string order8Status = "";

int switchingOrderStatus = 99;

List<Dish> order1 = new List<Dish>() {};
List<Dish> order2 = new List<Dish>() {};
List<Dish> order3 = new List<Dish>() {};
List<Dish> order4 = new List<Dish>() {};
List<Dish> order5 = new List<Dish>() {};
List<Dish> order6 = new List<Dish>() {};
List<Dish> order7 = new List<Dish>() {};
List<Dish> order8 = new List<Dish>() {};

int option = 8;
while (option != 0)
{ 
MainMenu();
option = Convert.ToInt32(Console.ReadLine());
switch (option)
    {
        case 1 : Showmenu(); break;
        case 2 : CreatingNewOrder(); break;
        case 3 : AddingDishToTheOrder(); break;
        case 4 : RemoingDishFromTheOrder(); break;
        case 5 : ShowingOrderReceipt(); break;
    }
    
}

void Showmenu()
{
    Console.WriteLine($"<<<MENU>>>");
    Console.WriteLine($"1.Borsch");
    Console.WriteLine($"2.Mushroom soup");
    Console.WriteLine($"3.Greek salad");
    Console.WriteLine($"4.Tuna salad");
    Console.WriteLine($"5.Cesar salad");
    Console.WriteLine($"6.Mashed potatoes with Kiev cutlet");
    Console.WriteLine($"7.Rice with chicken teriyaki");
    Console.WriteLine($"8.Garlic yeast buns");
    Console.WriteLine($"9.White bread");
    Console.WriteLine($"10.Black bread");
    Console.WriteLine($"11.Kompot");
    Console.WriteLine($"12.Coke zero");
    Console.WriteLine($"13.Sparkling water");
    Console.WriteLine($"14.Still water");
    Console.WriteLine($"Write '+' if you would like to order/add something OR '-' if you want go back to the main menu: ");
    string option = Console.ReadLine();
    if (option == "+")
    {
        Console.WriteLine($"<<<MENU>>>");
        Console.WriteLine($"1.Borsch");
        Console.WriteLine($"2.Mushroom soup");
        Console.WriteLine($"3.Greek salad");
        Console.WriteLine($"4.Tuna salad");
        Console.WriteLine($"5.Cesar salad");
        Console.WriteLine($"6.Mashed potatoes with Kiev cutlet");
        Console.WriteLine($"7.Rice with chicken teriyaki");
        Console.WriteLine($"8.Garlic yeast buns");
        Console.WriteLine($"9.White bread");
        Console.WriteLine($"10.Black bread");
        Console.WriteLine($"11.Kompot");
        Console.WriteLine($"12.Coke zero");
        Console.WriteLine($"13.Sparkling water");
        Console.WriteLine($"14.Still water");
        CreatingNewOrder();
    }
    if (option == "-")
    {
        MainMenu();
    }
    Console.WriteLine($"Wrong symbol");
    return;
}

void MainMenu()
{
    Console.WriteLine("===RESTAURANT===");
    Console.WriteLine("1.Show menu");
    Console.WriteLine("2.Create new order");
    Console.WriteLine("3.Add dish to the order");
    Console.WriteLine("4.Remove dish from the order");
    Console.WriteLine("5.Show order receipt");
    Console.WriteLine("0.Exit");
    Console.WriteLine("Your choice: ");
}

void CreatingNewOrder()
{
    choice = 9;
    while (choice != 0)
    {
        Console.WriteLine($"1.Create order1");
        Console.WriteLine($"2.Create order2");
        Console.WriteLine($"3.Create order3");
        Console.WriteLine($"4.Create order4");
        Console.WriteLine($"5.Create order5");
        Console.WriteLine($"6.Create order6");
        Console.WriteLine($"7.Create order7");
        Console.WriteLine($"8.Create order8");
        Console.WriteLine($"0.Exit");
        Console.WriteLine($"Your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice < 0 || choice > 8)
        {
            Console.WriteLine($"Wrong number");
            continue;
        }
        Console.WriteLine($"Choose the table#(1-8)");
        Console.WriteLine($"Your choice: ");
        int tableChoice = Convert.ToInt32(Console.ReadLine());
        if (tableChoice == tableChoice1 ||
            tableChoice == tableChoice2 ||
            tableChoice == tableChoice3 ||
            tableChoice == tableChoice4 ||
            tableChoice == tableChoice5 ||
            tableChoice == tableChoice6 ||
            tableChoice == tableChoice7 ||
            tableChoice == tableChoice8)
        {
            Console.WriteLine("Table already picked");
            return;
        }
        switch (choice)
        {
            case 1 :
                if (tableChoice1 == 0)
                {
                    tableChoice1 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 2 :
                if (tableChoice2 == 0)
                {
                    tableChoice2 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 3 :
                if (tableChoice3 == 0)
                {
                    tableChoice3 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 4 :
                if (tableChoice4 == 0)
                {
                    tableChoice4 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 5 :
                if (tableChoice5 == 0)
                {
                    tableChoice5 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 6 :
                if (tableChoice6 == 0)
                {
                    tableChoice6 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 7 :
                if (tableChoice7 == 0)
                {
                    tableChoice7 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
            case 8 :
                if (tableChoice8 == 0)
                {
                    tableChoice8 = tableChoice; 
                }
                else
                {
                    Console.WriteLine($"table already picked");
                    return;
                }
                break;
        }
        break;
    }
    for (int i = 1; i < 1000; i++)
    {
        Console.WriteLine($"Choose #{i} position you like to order/add: ");
        Console.WriteLine($"0.Exit");
        orderOption = Convert.ToInt32(Console.ReadLine());
        if (orderOption == 0)
        {
            switch (choice) 
            {
                case 1 : finalOrder1(); break;
                case 2 : finalOrder2(); break;
                case 3 : finalOrder3(); break;
                case 4 : finalOrder4(); break;
                case 5 : finalOrder5(); break;
                case 6 : finalOrder6(); break;
                case 7 : finalOrder7(); break;
                case 8 : finalOrder8(); break;
            }
            break;
        }
        if (orderOption < 0  || orderOption > 14)
        {
            Console.WriteLine($"Wrong number");
            break;
        }
        switch (choice)
        {
            case 1 : order1Case(); break;
            case 2 : order2Case(); break;
            case 3 : order3Case(); break;
            case 4 : order4Case(); break;
            case 5 : order5Case(); break;
            case 6 : order6Case(); break;
            case 7 : order7Case(); break;
            case 8 : order8Case(); break;
        }
        
    }
    
}

void order1Case()
{
    switch (orderOption)
    {
        case 1 : order1.Add(borsch); break;
        case 2 : order1.Add(mushroomSoup); break;
        case 3 : order1.Add(greekSalad); break;
        case 4 : order1.Add(tunaSalad); break;
        case 5 : order1.Add(cesarSalad); break;
        case 6 : order1.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order1.Add(riceWithChickenTeriyaki); break;
        case 8 : order1.Add(garlicYeastBuns); break;
        case 9 : order1.Add(whiteBread); break;
        case 10 : order1.Add(blackBread); break;
        case 11 : order1.Add(kompot); break;
        case 12 : order1.Add(cokeZero); break;
        case 13 : order1.Add(sparklingWater); break;
        case 14 : order1.Add(stillgWater); break;
        case 0 : finalOrder1(); return;
    }
}
void order2Case()
{
    switch (orderOption)
    {
        case 1 : order2.Add(borsch); break;
        case 2 : order2.Add(mushroomSoup); break;
        case 3 : order2.Add(greekSalad); break;
        case 4 : order2.Add(tunaSalad); break;
        case 5 : order2.Add(cesarSalad); break;
        case 6 : order2.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order2.Add(riceWithChickenTeriyaki); break;
        case 8 : order2.Add(garlicYeastBuns); break;
        case 9 : order2.Add(whiteBread); break;
        case 10 : order2.Add(blackBread); break;
        case 11 : order2.Add(kompot); break;
        case 12 : order2.Add(cokeZero); break;
        case 13 : order2.Add(sparklingWater); break;
        case 14 : order2.Add(stillgWater); break;
        case 0 : finalOrder2(); break;

    }
}
void order3Case()
{
    switch (orderOption)
    {
        case 1 : order3.Add(borsch); break;
        case 2 : order3.Add(mushroomSoup); break;
        case 3 : order3.Add(greekSalad); break;
        case 4 : order3.Add(tunaSalad); break;
        case 5 : order3.Add(cesarSalad); break;
        case 6 : order3.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order3.Add(riceWithChickenTeriyaki); break;
        case 8 : order3.Add(garlicYeastBuns); break;
        case 9 : order3.Add(whiteBread); break;
        case 10 : order3.Add(blackBread); break;
        case 11 : order3.Add(kompot); break;
        case 12 : order3.Add(cokeZero); break;
        case 13 : order3.Add(sparklingWater); break;
        case 14 : order3.Add(stillgWater); break;
        case 0 : finalOrder3(); break;
    }
}
void order4Case()
{
    switch (orderOption)
    {
        case 1 : order4.Add(borsch); break;
        case 2 : order4.Add(mushroomSoup); break;
        case 3 : order4.Add(greekSalad); break;
        case 4 : order4.Add(tunaSalad); break;
        case 5 : order4.Add(cesarSalad); break;
        case 6 : order4.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order4.Add(riceWithChickenTeriyaki); break;
        case 8 : order4.Add(garlicYeastBuns); break;
        case 9 : order4.Add(whiteBread); break;
        case 10 : order4.Add(blackBread); break;
        case 11 : order4.Add(kompot); break;
        case 12 : order4.Add(cokeZero); break;
        case 13 : order4.Add(sparklingWater); break;
        case 14 : order4.Add(stillgWater); break;
        case 0 : finalOrder4(); break;

    }
}
void order5Case()
{
    switch (orderOption)
    {
        case 1 : order5.Add(borsch); break;
        case 2 : order5.Add(mushroomSoup); break;
        case 3 : order5.Add(greekSalad); break;
        case 4 : order5.Add(tunaSalad); break;
        case 5 : order5.Add(cesarSalad); break;
        case 6 : order5.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order5.Add(riceWithChickenTeriyaki); break;
        case 8 : order5.Add(garlicYeastBuns); break;
        case 9 : order5.Add(whiteBread); break;
        case 10 : order5.Add(blackBread); break;
        case 11 : order5.Add(kompot); break;
        case 12 : order5.Add(cokeZero); break;
        case 13 : order5.Add(sparklingWater); break;
        case 14 : order5.Add(stillgWater); break;
        case 0 : finalOrder5(); break;

    }
}
void order6Case()
{
    switch (orderOption)
    {
        case 1 : order6.Add(borsch); break;
        case 2 : order6.Add(mushroomSoup); break;
        case 3 : order6.Add(greekSalad); break;
        case 4 : order6.Add(tunaSalad); break;
        case 5 : order6.Add(cesarSalad); break;
        case 6 : order6.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order6.Add(riceWithChickenTeriyaki); break;
        case 8 : order6.Add(garlicYeastBuns); break;
        case 9 : order6.Add(whiteBread); break;
        case 10 : order6.Add(blackBread); break;
        case 11 : order6.Add(kompot); break;
        case 12 : order6.Add(cokeZero); break;
        case 13 : order6.Add(sparklingWater); break;
        case 14 : order6.Add(stillgWater); break;
        case 0 : finalOrder6(); break;

    }
}
void order7Case()
{
    switch (orderOption)
    {
        case 1 : order7.Add(borsch); break;
        case 2 : order7.Add(mushroomSoup); break;
        case 3 : order7.Add(greekSalad); break;
        case 4 : order7.Add(tunaSalad); break;
        case 5 : order7.Add(cesarSalad); break;
        case 6 : order7.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order7.Add(riceWithChickenTeriyaki); break;
        case 8 : order7.Add(garlicYeastBuns); break;
        case 9 : order7.Add(whiteBread); break;
        case 10 : order7.Add(blackBread); break;
        case 11 : order7.Add(kompot); break;
        case 12 : order7.Add(cokeZero); break;
        case 13 : order7.Add(sparklingWater); break;
        case 14 : order7.Add(stillgWater); break;
        case 0 : finalOrder7(); break;

    }
}
void order8Case()
{
    switch (orderOption)
    {
        case 1 : order8.Add(borsch); break;
        case 2 : order8.Add(mushroomSoup); break;
        case 3 : order8.Add(greekSalad); break;
        case 4 : order8.Add(tunaSalad); break;
        case 5 : order8.Add(cesarSalad); break;
        case 6 : order8.Add(mashedPotatoesWithKievCutlet); break;
        case 7 : order8.Add(riceWithChickenTeriyaki); break;
        case 8 : order8.Add(garlicYeastBuns); break;
        case 9 : order8.Add(whiteBread); break;
        case 10 : order8.Add(blackBread); break;
        case 11 : order8.Add(kompot); break;
        case 12 : order8.Add(cokeZero); break;
        case 13 : order8.Add(sparklingWater); break;
        case 14 : order8.Add(stillgWater); break;
        case 0 : finalOrder8(); break;
    }
}

void finalOrder1()
{
    foreach (var orderq in order1)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 1;
        order1Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder2()
{
    foreach (var orderq in order2)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 2;
        order2Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder3()
{
    foreach (var orderq in order3)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 3;
        order3Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder4()
{
    foreach (var orderq in order4)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 4;
        order4Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder5()
{
    foreach (var orderq in order5)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 5;
        order5Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder6()
{
    foreach (var orderq in order6)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 6;
        order6Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder7()
{
    foreach (var orderq in order7)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 7;
        order7Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}
void finalOrder8()
{
    foreach (var orderq in order8)
    {
        Console.WriteLine($"{orderq.Name}              {orderq.Price}₴");
    }    
    Console.WriteLine($"That's all?(+)");
    Console.WriteLine($"Switch order status(>)");
    string finalOption = Console.ReadLine();
    if (finalOption == "+")
    {
        switchingOrderStatus = 8;
        order8Status = "new";
        MainMenu();
    }
    if (finalOption == ">")
    {
        SwitchingOrderStatus();
    }
}

void AddingDishToTheOrder()
{
    Console.WriteLine($"To which order# do you want to add the dish?");
    Console.WriteLine($"Order 1");
    Console.WriteLine($"Order 2");
    Console.WriteLine($"Order 3");
    Console.WriteLine($"Order 4");
    Console.WriteLine($"Order 5");
    Console.WriteLine($"Order 6");
    Console.WriteLine($"Order 7");
    Console.WriteLine($"Order 8");
    Console.WriteLine($"0.Exit");
    Console.WriteLine($"Your choice: ");
    int orderNumb = Convert.ToInt32(Console.ReadLine());
    if (orderNumb == 0)
    {
        MainMenu();
    }
    if (orderNumb < 0 || orderNumb > 8)
    {
        Console.WriteLine("Wrong number");
        MainMenu();
    }
    Showmenu();
}

void RemoingDishFromTheOrder()
{
    Console.WriteLine($"Order 1");
    Console.WriteLine($"Order 2");
    Console.WriteLine($"Order 3");
    Console.WriteLine($"Order 4");
    Console.WriteLine($"Order 5");
    Console.WriteLine($"Order 6");
    Console.WriteLine($"Order 7");
    Console.WriteLine($"Order 8");
    Console.WriteLine($"0.Exit");
    Console.WriteLine($"What order# you want to remove dish from");
    Console.WriteLine($"Your choice: ");
    int removeChoice = Convert.ToInt32(Console.ReadLine());
    if (removeChoice == 0)
    {
        MainMenu();
    }
    if (removeChoice < 0 || removeChoice > 8)
    {
        Console.WriteLine($"Wrong number");
        MainMenu();
    }
    if (order1.Count == 0)
    {
        Console.WriteLine("Order is empty");
        MainMenu();
    }
    switch (removeChoice)
    {
        case 1 :
            int deleteDish = 17;
            while (deleteDish != 99)
            {
                foreach (var removeOption in order1)
                {
                    Console.WriteLine($"{removeOption.Name}       {removeOption.Price}");
                }
            
                Console.WriteLine($"Write dish you want to remove: ");
                Console.WriteLine($"99.exit");
                deleteDish = Convert.ToInt32(Console.ReadLine());
                if (deleteDish == 99)
                {
                    MainMenu();
                }
                deleteDish -= 1;
                order1.RemoveAt(deleteDish);
                break;
            }
            break;
    }

}

void ShowingOrderReceipt()
{
    Console.WriteLine($"What order# you need to see the receipt?");
    Console.WriteLine($"0.Exit");
    Console.WriteLine($"Your choice: ");
    int orderChoice = Convert.ToInt32(Console.ReadLine());
    if (orderChoice == 0)
    {
        MainMenu();
    }
    if (orderChoice < 0 || orderChoice > 8)
    {
        Console.WriteLine($"wrong choice");
        MainMenu();
    }

    switch (orderChoice)
    {
        case 1 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №1 | Table {tableChoice1} | Status: {order1Status}");
            Console.WriteLine($"---------------------------------------");
            var groupOrder = order1.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order1.Count}");
            Console.WriteLine($"Cooking time: {order1.Max(order => order.CookingTime)} min");
            break;
        case 2 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №2 | Table {tableChoice2} | Status: {order2Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order2.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order2.Count}");
            Console.WriteLine($"Cooking time: {order2.Max(order => order.CookingTime)} min");
            break;
        case 3 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №3 | Table {tableChoice3} | Status: {order3Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order3.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order3.Count}");
            Console.WriteLine($"Cooking time: {order3.Max(order => order.CookingTime)} min");
            break;
        case 4 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №4 | Table {tableChoice4} | Status: {order4Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order4.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order4.Count}");
            Console.WriteLine($"Cooking time: {order4.Max(order => order.CookingTime)} min");
            break;        
        case 5 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №5 | Table {tableChoice5} | Status: {order5Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order5.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order5.Count}");
            Console.WriteLine($"Cooking time: {order5.Max(order => order.CookingTime)} min");
            break;
        case 6 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №6 | Table {tableChoice6} | Status: {order6Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order6.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order6.Count}");
            Console.WriteLine($"Cooking time: {order6.Max(order => order.CookingTime)} min");
            break;
        case 7 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №7 | Table {tableChoice7} | Status: {order7Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order7.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order7.Count}");
            Console.WriteLine($"Cooking time: {order7.Max(order => order.CookingTime)} min");
            break;
        case 8 : 
            Console.WriteLine($"=============== RECEIPT ===============");
            Console.WriteLine($"Order №8 | Table {tableChoice8} | Status: {order8Status}");
            Console.WriteLine($"---------------------------------------");
            groupOrder = order8.GroupBy(n => n.Name);
            foreach (var order in groupOrder)
            {
                Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
            }
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Dishes count: {order8.Count}");
            Console.WriteLine($"Cooking time: {order8.Max(order => order.CookingTime)} min");
            break;
    }
    MainMenu();
}

void SwitchingOrderStatus()
{
    switch (switchingOrderStatus)
    {
        case 1 :
            order1Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            string statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order1Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 2 :
            order2Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order2Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 3 :
            order3Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order3Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 4 :
            order4Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order4Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 5 :
            order5Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order5Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 6 :
            order6Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order6Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 7 :
            order7Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order7Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
        case 8 :
            order8Status = "new";
            Console.WriteLine($"Switch order status?(+/-)");
            statusChoice = Console.ReadLine();
            if (statusChoice == "-")
            {
                MainMenu();
            }
            if (statusChoice == "+")
            {
                order8Status = "paid";
            }
            Console.WriteLine($"wrong number");
            MainMenu();
            break;
    }
}

void ShowingAllOrders()
{
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №1 | Table {tableChoice1} | Status: {order1Status}");
    Console.WriteLine($"---------------------------------------");
    var groupOrder = order1.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order1.Count}");
    Console.WriteLine($"Cooking time: {order1.Max(order => order.CookingTime)} min");
    
    
    
    Console.WriteLine($"Order №2 | Table {tableChoice2} | Status: {order2Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order2.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order2.Count}");
    Console.WriteLine($"Cooking time: {order2.Max(order => order.CookingTime)} min");

    
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №3 | Table {tableChoice3} | Status: {order3Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order3.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order3.Count}");
    Console.WriteLine($"Cooking time: {order3.Max(order => order.CookingTime)} min");
    
    
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №4 | Table {tableChoice4} | Status: {order4Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order4.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order4.Count}");
    Console.WriteLine($"Cooking time: {order4.Max(order => order.CookingTime)} min");
    
    
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №5 | Table {tableChoice5} | Status: {order5Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order5.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order5.Count}");
    Console.WriteLine($"Cooking time: {order5.Max(order => order.CookingTime)} min");
    
    
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №6 | Table {tableChoice6} | Status: {order6Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order6.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order6.Count}");
    Console.WriteLine($"Cooking time: {order6.Max(order => order.CookingTime)} min");
    
    
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №7 | Table {tableChoice7} | Status: {order7Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order7.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order7.Count}");
    Console.WriteLine($"Cooking time: {order7.Max(order => order.CookingTime)} min");

    
    
    Console.WriteLine($"=============== RECEIPT ===============");
    Console.WriteLine($"Order №8 | Table {tableChoice8} | Status: {order8Status}");
    Console.WriteLine($"---------------------------------------");
    groupOrder = order8.GroupBy(n => n.Name);
    foreach (var order in groupOrder)
    {
        Console.WriteLine($"{order.Key,-35}   \\   x{order.Count(),-4}   \\   {order.First().Price*order.Count(),10}₴");
    }
    Console.WriteLine($"---------------------------------------");
    Console.WriteLine($"Dishes count: {order8.Count}");
    Console.WriteLine($"Cooking time: {order8.Max(order => order.CookingTime)} min");


    
}