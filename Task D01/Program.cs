// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello in Islam's Carpet Cleaning Service");
Console.WriteLine("Charges:\r\n        $25 per small\r\n        $35 per large\r\n");
Console.Write("Enter The Small Charges : ");
int smallCharges = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter The Big Charges : ");
int bigCharges = Convert.ToInt32(Console.ReadLine());
int cost = (smallCharges * 25) + (bigCharges * 35);
double tax = cost * 0.06;
double totalEstimate = cost + tax;
Console.WriteLine("Price per small room: $25");
Console.WriteLine("Price per large room: $35");
Console.WriteLine("Cost $" + cost);
Console.WriteLine("Tax : $"+tax);
Console.WriteLine("==================================");
Console.WriteLine("Total estimate : $"+totalEstimate);
Console.WriteLine("This estimate is valid for 30 days");

