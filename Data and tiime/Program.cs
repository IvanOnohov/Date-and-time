using System.Globalization;

DateOnly now = DateOnly.Parse("2024, 11, 12");
Console.WriteLine(now);
var d = DateOnly.Parse("2024, 11, 12");
Console.WriteLine(d);
bool s = DateOnly.TryParse("2024, 11, 12", out DateOnly now2);
Console.WriteLine(s);
string DateString = "15/10/2024";
string format = "dd/MM/yyyy";
DateOnly date2 = DateOnly.ParseExact( DateString, format);
Console.WriteLine(date2);
string DateString2 = "15-10-2024";
string[] formats = {"dd-MM-yyyy","dd/MM/yyyy" };
Console.WriteLine(DateOnly.TryParseExact(DateString2, formats, out DateOnly now3));
