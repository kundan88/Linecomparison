
//UC1
Console.WriteLine(   );
Console.WriteLine("Welcome to the Line comparison");
Console.WriteLine("enter x1 value : ");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter x2 value : ");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter y1 value : ");
var y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter y2 value : ");
var y2 = Convert.ToDouble(Console.ReadLine());

var a = Math.Pow(x2 - x1,2);
var b = Math.Pow(y2 - y1, 2);
var distance = Math.Sqrt(a + b);
Console.WriteLine("Distance of 2 point is : " + distance);
