using branch_tests;
TextoQualquer text = new TextoQualquer();

Console.WriteLine($"Escreva um texto qualquer: ");
string texto_qualquer = Console.ReadLine().ToLower();
text.Texto = texto_qualquer;