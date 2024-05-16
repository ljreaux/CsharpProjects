// int monsterHealth = 10;
// int playerHealth = 10;
// Random roll = new Random();

// while (monsterHealth > 0 && playerHealth > 0)
// {
//     int playerAttack = roll.Next(1, 11);
//     int monsterAttack = roll.Next(1, 11);

//     monsterHealth -= playerAttack;
//     Console.WriteLine(
//         $"Monster was damaged and lost {playerAttack} health and now has {monsterHealth}."
//     );
//     if (monsterHealth > 0)
//     {
//         playerHealth -= monsterAttack;
//         Console.WriteLine(
//             $"Hero was damaged and lost {monsterAttack} health and now has {playerHealth}."
//         );
//     }
// }

// Console.WriteLine(playerHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
// string? readResult;
// int number = 0;
// bool validEntry = false;
// bool validNumber = false;
// Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         validNumber = int.TryParse(readResult, out number);
//         if (validNumber)
//         {
//             if (number < 5 || number > 10)
//             {
//                 Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10");
//             }
//             else
//             {
//                 Console.WriteLine($"Your input value ({number}) has been accepted.");
//                 validEntry = true;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         }
//     }
// } while (validEntry == false);
// string? readResult;
// string[] rolesArr = { "administrator", "manager", "user" };
// bool validEntry = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         string role = readResult.Trim().ToLower();
//         bool isValidRole = false;

//         foreach (string validRole in rolesArr)
//         {
//             if (validRole == role)
//                 isValidRole = true;
//         }

//         if (isValidRole)
//         {
//             Console.WriteLine(
//                 $"Your input value ({char.ToUpper(role[0]) + role.Substring(1)}) has been accepted."
//             );
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine(
//                 $"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User) Administrator"
//             );
//         }
//     }
// } while (validEntry == false);

string[] myStrings = new string[2]
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};
int periodLocation = -1;

foreach (string str in myStrings)
{
    periodLocation = str.IndexOf(".");
    Console.WriteLine(periodLocation);
    while (periodLocation != -1)
    {
        string currentSubstring = str;
        Console.WriteLine(currentSubstring);
        Console.WriteLine(currentSubstring.IndexOf("."));
        periodLocation = currentSubstring.IndexOf(".");
        currentSubstring = str.Substring(periodLocation + 1);
    }
}
