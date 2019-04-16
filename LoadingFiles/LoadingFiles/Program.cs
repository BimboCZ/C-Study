using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

/*
Načtení souborů z disku a jejich přetřídění		
		
Ćíl:	Vytvořit konzolovou aplikaci, která načte názvy souborů v adresáři, seřadí je abecedně vzestupně podle názvu a názvy souborů vypíše na konzoli.	
		
Rozšíření cíle:		
	 umožní řadit dle:	
	-	počtu znaků v názvu souboru
	-	data vytvoření
	-	data poslední změny
	-	velikosti souboru
	-	přípony
	umožní řadit vzestupně i sestupně	
	načíst soubory i z podaresářů	
	vypisovat attributy souboru (je ke čtení, verze souboru a podobně)	
		
Vstupy uživatele:		
	cesta k adresáři	
	způsob řazení	
		
Zadání úkolu:		
	vytvoř konzolovou aplikaci	
	vytvoř metodu pro načtení souborů z adresáře do seznamu	
	vytvoř metodu pro výpis souborů ze seznamu	
		
Možné postupy:		
	a) 	načíst soubory do vhodné kolekce, která umožní setřídění souborů
	b)	využít LinkQ
		
Komentář:		
	vhodně zvolit objekt pro uložení seznamu	
		
Související objekty:		
	Dictionary<>	
	DirectoryInfo	
	FileAttribute	
	FileInfo	
	List<>,	
	SortedList<>	
		
Související metody:		
	EnumerateFiles	
	GetEnumerator, MoveNext	
	Sort	
*/

namespace LoadingFiles
{
 
 class Program
 {
  public static string path = @"";

  static void Main(string[] args)
  {
   Console.Write("Zadej cestu: ");
   path = Console.ReadLine();

   Dictionary<int, string> FileDir = new Dictionary<int, string>(); 

   try
   {
    string[] dirs = Directory.GetDirectories(path);
    foreach (string dir in dirs)
    {
     Console.WriteLine(dir);
    }
   }
   catch (Exception e)
   {
    Console.WriteLine("The process failed: {0}", e.ToString());
   }
   Console.ReadKey();
  }
 }
}
