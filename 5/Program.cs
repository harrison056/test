
string s = "Hello, World!";

Console.WriteLine(new string((new Stack<char>(s)).ToArray()));
