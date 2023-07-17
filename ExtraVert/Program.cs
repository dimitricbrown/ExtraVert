// See https://aka.ms/new-console-template for more information
using ExtraVert;
using System.IO.Compression;

List<Plant> plants = new List<Plant>()
{
    new Plant()
    {
        Species  = "Rose",
        LightNeeds = 4,
        AskingPrice = 15,
        City = "Memphis",
        ZIP = 38125,
        Sold = false,
    },
    new Plant()
    {
        Species  = "Daisy",
        LightNeeds = 3,
        AskingPrice = 15,
        City = "Memphis",
        ZIP = 38125,
        Sold = false,
    },
    new Plant()
    {
        Species  = "Sunflower",
        LightNeeds = 5,
        AskingPrice = 15,
        City = "Memphis",
        ZIP = 38125,
        Sold = false,
    },
    new Plant()
    {
        Species  = "Tulip",
        LightNeeds = 3,
        AskingPrice = 15,
        City = "Memphis",
        ZIP = 38125,
        Sold = false,
    },
    new Plant()
    {
        Species  = "Lily",
        LightNeeds = 2,
        AskingPrice = 15,
        City = "Memphis",
        ZIP = 38125,
        Sold = true,
    }
};

foreach(var plant in plants)
{
    Console.WriteLine($"{plants.IndexOf(plant) + 1}. {plant.Species}");
}
