Console.WriteLine("---ImitandoDry---");

Console.WriteLine(" escreva uma frase...: ");
String frase = Console.ReadLine()!;

String fraseEmBaleies = frase
.Replace ("a", "aaa")
.Replace ("A", "AAA")
.Replace ("e", "eee")
.Replace ("E", "EEE")
.Replace ("i", "iii")
.Replace ("I", "III")
.Replace ("o", "ooo")
.Replace ("O", "OOO")
.Replace ("u", "uuu")
.Replace ("U", "UUU");

Console.WriteLine($"\nEm Baleies:\n\n{fraseEmBaleies}");