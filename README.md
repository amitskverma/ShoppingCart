# ShoppingCart
using C# Basics for Shopping App 

*cmd*

```dotnet new console```

#syntax for declare data type

type variableName [= value];

- **type** refers to the kind of data that the variable will hold, such as an integer, floating-point number, string, or class name.
- **variableName** is the identifier given to the variable so that developers can reference it later in the program.
- **value** is the actual data assigned to the variable.
- Square brackets around a value indicate that assigning an initial value is optional.


```
byte categoryId = 1;
Console.WriteLine(categoryId);
int quantityAvailable = 10;

Console.WriteLine(quantityAvailable); 
Console.WriteLine("Quantity Available: " + quantityAvailable);
Console.WriteLine("Quantity Available: {0}", quantityAvailable);
Console.WriteLine($"Quantity Available: {quantityAvailable}");
```
#
Data-type
```
float productPrice = 5999.99F;
Console.WriteLine("Product Price = {0}", productPrice);
double amountToPay = 27968.50;
Console.WriteLine("Payment Amount = {0}", amountToPay);
decimal creditBalance = 2980912.97M;
Console.WriteLine("Credit Balance = {0}", creditBalance);


int? quantityAvailable1 = null ;
Console.WriteLine(quantityAvailable1);
```

#
Loop + String Array print
```
string [] cour ={
"Programming", "Networking", "Database", "Web Development"};
Array.Sort(cour);
//Console.WriteLine(cour[0]);
for (int i = 0; i < cour.Length; i++)
{
    Console.Write(cour[i]);
    if (i < cour.Length - 1)
    {
        Console.WriteLine(',');
    }
}
```
# 
Switch Case
```
int day = 2;
            string dayString;
            switch (day)
            {
                case 1: 
                    dayString = "Sunday";
                    break;
                case 2:
                    dayString = "Monday";
                    break;
                case 3:
                    dayString = "Tuesday";
                    break;
                case 4:
                    dayString = "Wednesday";
                    break;
                case 5:
                    dayString = "Thursday";
                    break;
                case 6:
                    dayString = "Friday";
                    break;
                case 7:
                    dayString = "Saturday";
                    break;
                default:
                    dayString = "Invalid day";
                    break;
            }
            Console.WriteLine(dayString);
```
#
*3D ARRAY
#
```
int[,,] arr = new int[2, 2, 3]{ {{1, 2, 3}, {4, 5, 6}},{{7, 8, 9}, {10, 11, 12}} };

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write(arr[i, j, k] + " ");
           }Console.WriteLine();
           }
        
    Console.WriteLine();
}
```