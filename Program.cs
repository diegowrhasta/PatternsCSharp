// See https://aka.ms/new-console-template for more information

var list = new List<string>();
var hello =
    "The last question was asked for the first time, half in jest, on May 21, 2061, at a time when humanity first stepped " +
    "into the light. The question came about as a result of a five dollar bet over highballs, and it happened this way: " +
    "Alexander Adell and Bertram Lupov were two of the faithful attendants of Multivac. As well as any human";
list.Add(hello);
list.Add("brother");
Console.WriteLine(string.Join(",", list));