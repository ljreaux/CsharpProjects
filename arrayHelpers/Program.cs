// string[] pallets = { "B14", "A11", "B12", "A13" };

// // Console.WriteLine("Sorted...");
// // Array.Sort(pallets);
// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// // Console.WriteLine("");
// // Console.WriteLine("Reversed...");
// // Array.Reverse(pallets);
// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }
// string pangram = "The quick brown fox jumps over the lazy dog";
// string result = "";
// string[] words = pangram.Split(' ');

// for (int i = 0; i < words.Length; i++)
// {
//     string word = words[i];
//     char[] currentWord = word.ToCharArray();
//     Array.Reverse(currentWord);
//     string reversedWord = new string(currentWord);
//     words[i] = reversedWord;
// }

// result = String.Join(" ", words);

// Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

foreach (string order in orders)
{
    string displayString;
    if (order.Length == 4)
    {
        displayString = order;
    }
    else
    {
        displayString = $"{order}\t- Error";
    }
    Console.WriteLine(displayString);
}
