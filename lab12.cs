string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
Console.WriteLine(s1.Replace(s2, ""));
try
{
    int index = s1.IndexOf(s2);
    Console.WriteLine(s1.Remove(index, s2.Length));
}
catch
{
    Console.WriteLine(s1);
}
