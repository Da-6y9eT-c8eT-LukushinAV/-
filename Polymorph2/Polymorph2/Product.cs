using System;
using System.Collections.Generic;
using System.Globalization;


public abstract class Product
{
    public string Name { get; set; }
    public virtual decimal Price { get; set; }

    protected Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public abstract string GetInformation();


}
public class Toy : Product
{
    public string AgeGroup { get; set; }
    public override decimal Price
    {
        get
        {
            decimal additionalDiscount = 5;
            return base.Price * (1 - additionalDiscount / 100);
        }
    }
    public Toy(string name, decimal price, string ageGroup)
        : base(name, price)
    {
        AgeGroup = ageGroup;
    }

    public override string GetInformation()
    {
        return $"Toy: {Name}, Price: {Price}$, Age Group: {AgeGroup}";
    }
}
public class Meat : Product
{
    public string MeatType { get; set; }
    public override decimal Price
    {
        get
        {
            decimal additionalDiscount = 10;
            return base.Price * (1 - additionalDiscount / 100);
        }
    }
    public Meat(string name, decimal price, string meatType)
        : base(name, price)
    {
        MeatType = meatType;
    }

    public override string GetInformation()
    {
        return $"Meat: {Name}, Price: {Price}$, Type: {MeatType}";
    }
}
public class Drinks : Product
{
    public bool IsAlcoholic { get; set; }
    public override decimal Price
    {
        get
        {
            decimal additionalDiscount = 3;
            return base.Price * (1 - additionalDiscount / 100);
        }
    }
    public Drinks(string name, decimal price, bool isAlcoholic)
        : base(name, price)
    {
        IsAlcoholic = isAlcoholic;
    }

    public override string GetInformation()
    {
        return $"Drink: {Name}, Price: {Price}$, Alcoholic: {IsAlcoholic}";
    }
}
public class Electronics : Product
{
    public string WarrantyPeriod { get; set; }
    public override decimal Price
    {
        get
        {
            decimal additionalDiscount = 15;
            return base.Price * (1 - additionalDiscount / 100);
        }
    }
    public Electronics(string name, decimal price, string warrantyPeriod)
        : base(name, price)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override string GetInformation()
    {
        return $"Electronics: {Name}, Price: {Price}$, Warranty: {WarrantyPeriod}";
    }
}
public class Clothes : Product
{
    public string Size { get; set; }
    public string Color { get; set; }

    // Переопределение свойства Price для применения дополнительной скидки
    public override decimal Price
    {
        get
        {
            decimal additionalDiscount = 10; // Скидка 10%
            return base.Price * (1 - additionalDiscount / 100);
        }
    }

    // Конструктор класса Clothes
    public Clothes(string name, decimal price, string size, string color)
        : base(name, price)
    {
        Size = size;
        Color = color;
    }

    // Переопределение метода GetInformation для вывода информации о товаре
    public override string GetInformation()
    {
        return $"Clothes: {Name}, Price: {Price:F2} $, Size: {Size}, Color: {Color}";
    }
}