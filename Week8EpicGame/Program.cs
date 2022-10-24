﻿string folderPath = @"G:\ProgeJaVeeb\New folder\data8\";
string heroFile = "heros.txt";
string villainFile = "villains.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));


string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
//string[] heros = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "banana", "sword", "Lego brick" };



string hero = GetRandomValueFromArray(heros);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon); 
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;   
}
