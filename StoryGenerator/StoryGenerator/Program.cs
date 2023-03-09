/*
 * The main purpose of this gibberish from YT is to make a validation example written below...
*/
//Get the input from the user
string noun;
string adj;
string noun2;
string verb;
//Ask for a noun
while (true) 
{
    try
    {
        Console.WriteLine("Please provide a noun: ");
        noun = Console.ReadLine();
        if (noun.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("there was an error: " + e); }
}
//Ask for an adjective
while (true)
{
    try
    {
        Console.WriteLine("Please provide an adjective: ");
        adj = Console.ReadLine();
        if (adj.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("there was an error: " + e); }
}
//Ask for a second noun
while (true)
{
    try
    {
        Console.WriteLine("Please provide a second noun: ");
        noun2 = Console.ReadLine();
        if (noun2.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("there was an error: " + e); }
}
//Ask for a verb
while (true)
{
    try
    {
        Console.WriteLine("Please provide a verb: ");
        verb = Console.ReadLine(); ;
        if (verb.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("there was an error: " + e); }
}

string story = "Russkij "+ noun + " Sakartvele nepraėjo. Kartvelai apgynė laisvę nuo furherio Pu tvarkos ir \"įstatymų\". Rusijos "+ adj + " reicho šestiorkoms nepadėjo nei banditiška "+ noun2 + " , nei dujos, nei vandens patrankos. " +
    " Pabrukę uodegas atsiėmė užsienio agentų \"įstatymą\", kartvelų taikliai pavadintą "+ verb + " įstatymu.";
Console.WriteLine("hewre is a final story...");
Console.WriteLine(story);