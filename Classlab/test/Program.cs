using System.Collections;

Hashtable openWith = new Hashtable();

// Add some elements to the hash table. There are no
// duplicate keys, but some of the values are duplicates.
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

Console.WriteLine(openWith.Contains("bpm"));
Console.WriteLine(openWith.ContainsKey("txt"));
Console.WriteLine(openWith.ContainsValue("txt"));
Console.WriteLine(openWith["txt"].Equals("notepad.exe"));

