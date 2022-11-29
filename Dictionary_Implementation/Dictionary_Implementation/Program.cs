using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace Dictionary_Implementation
{
    public class Program
    {

        // Dictionary Implementation in C#

        static void Main(string[] args)
        {
           // A. Creating a Dictionary and Adding Elements.
           IDictionary<int,string> menu = new Dictionary<int,string>();

            // Adding Elements.
            menu.Add(001, "Hamburger");
            menu.Add(002, "Pizza");
            //menu.Add(003, "Carbonara");
            //menu.Add(004, "Yang Chaow");

            //Traversing each element.
            foreach(KeyValuePair<int,string> item in menu)
            {
                WriteLine("Key: {0}, Value: {1} ", item.Key, item.Value); 
            }

            WriteLine("\n");

            // Initializing using COLLECTION-INITIALIZER Syntax.
            var city = new Dictionary<string, string>()
            {
                {"Manila", "Malate, Tondo, Paco, Intramuros" },
                {"Pasay", "Harrison, Taft Avenue"}
            };

            //Traversing
            foreach(var item in city)
            {
                WriteLine("Key: {0}, Value: {1} ", item.Key,item.Value);
            }

            WriteLine("\n");


            // Accessing Individual Elements.

            WriteLine(menu[001]);
            WriteLine(city["Manila"]);
            // Will throw exception if key does not exists.

            // Other Method 

            // use ContainsKey() to check for an unknown key.
            if (city.ContainsKey("France"))
            {
                WriteLine(city["France"]); // returns nothing...
            }

            // use TryGetValue() to check for an unknown key.
            string result;

            if(city.TryGetValue("France", out result))
            {
                WriteLine(result);// returns nothing...
            }
            WriteLine("\n");

            // using ElementAt() to retrive key-value pair using INDEX.
            for (int i = 0; i < city.Count; i++)
            {
                WriteLine("Key: {0}, Value: {1}",
                    city.ElementAt(i).Key,
                    city.ElementAt(i).Value
                    );
            }
            WriteLine("\n");

            //Updating Dictionary

            //specify key in the indexer.
            // throw KEYNOTFOUNDEXCEPTION if key does not exist.
            city["Manila"] = "Binondo, Tondo II";

            foreach (var item in city)
            {
                WriteLine("Key: {0}, Value: {1} ", item.Key, item.Value);
            }

            WriteLine("\n");

            //Deleting 
            city.Remove("Pasay");
            // city.Clear(); // Clears all element.


        }
    }
}
