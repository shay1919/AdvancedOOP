// See https://aka.ms/new-console-template for more information
using AdvancedOOP.Buildings;
using AdvancedOOP.Rooms;

Console.WriteLine("Building simulator:");

//House building1 = new House(new Bathroom(true, true), 80, 60, "Brick", "RT3 7TW", true);


//building1.Bulldoze();
//Console.WriteLine("Building Insured: " + building1.insured);
//Console.WriteLine("Building 1 - Garden Length: " + building1.gardenLength + " Garden Width: " + building1.gardenWidth);

Flat flat1 = new Flat(new Bathroom(true, true), true, "Stone", "B5 4DN", true);
Console.WriteLine($"Flat 1 has a balcony? {flat1.hasBalcony}");

Skyscraper skyscraper1 = new Skyscraper(new Bathroom(true, false), false, 250.3, new Basement(10, 15), "Glass", "E1 8RU", true);
Console.WriteLine($"Skycraper 1 insured? {skyscraper1.insured}");
Console.WriteLine($"Skyscraper 1 has a balcony? {skyscraper1.hasBalcony}");
Console.WriteLine($"Skyscraper 1 basement length and width: {skyscraper1.basement.basementLength}, {skyscraper1.basement.basementWidth}");

House house1 = new House(new Bathroom(true, true), new Kitchen(true, true, true), 10, 20, "Brick", "B45 7AN", true);