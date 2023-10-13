//Your code goes here
// Your subscription will expire soon. Renew now!
// Your subscription expires in_days. //Renew now and save 10%!
// Your subscription expires within a day // Renew and save 20%!
// Your subscription has expired.


Random random = new Random();

int daysUntilExpiration = random.Next(1, 12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}

else if (daysUntilExpiration <= 5) 
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon, Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}