using ContossoPizza.Data;
using ContossoPizza.Models;

using ContossoPizzaDbContext context = new ContossoPizzaDbContext();

foreach (Product p in context.Products)
{
    Console.WriteLine($"Id: {p.Id} Name: {p.Name}");
}