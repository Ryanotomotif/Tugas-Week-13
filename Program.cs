using System;
using System.Collections.Generic;
using System.Linq;

namespace Tugas_Week_13
{
	class Program
	{
		static void Main(string[] args)
		{
			int pilihanmenu = 0;
			int counter = 0;
			int jumlahScroll = 0;
			int queuePosition = 0;
			List<string> newscroll = new List<string>();
			List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
			while (true)
			{
				Console.Write("1. My Scroll List \n2. Add Scroll \n3. Search Scroll \n4. Remove Scroll\n");
				Console.Write("Choose what to do : ");
				pilihanmenu = Convert.ToInt32(Console.ReadLine());
				if (pilihanmenu == 1)
				{
					Console.WriteLine();
					counter = 0;
					Console.WriteLine("Scroll to learn list : ");
					foreach (string scroll in scrolls)
					{
						counter++;
						Console.WriteLine($"Scroll {counter} : {scroll}");
					}
					Console.WriteLine();
				}
				else if (pilihanmenu == 2)
				{
					Console.WriteLine();
					Console.Write("How many scroll to add : ");
					jumlahScroll = Convert.ToInt32(Console.ReadLine());
					Console.Write("In what number of Queue : ");
					queuePosition = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i < jumlahScroll; i++)
					{
						Console.WriteLine($"Scroll {i + 1} Name : ");
						newscroll.Add(Console.ReadLine());
					}
					if (queuePosition < 1)
					{
						queuePosition = 0;
					}
					else if (queuePosition > scrolls.Count())
					{
						queuePosition = scrolls.Count();
					}
					counter = -1;
					foreach (string scroll in newscroll)
					{
						scrolls.Insert(queuePosition + counter, scroll);
						counter++;
					}
					newscroll.Clear();
					Console.WriteLine("Add scroll success, check your list");
					Console.WriteLine();
				}
				else if (pilihanmenu == 3)
				{
					Console.Write("Insert scroll name : ");
					string cari = Console.ReadLine();
					if (scrolls.Find(x => x.Contains(cari)) != cari)
					{
						Console.WriteLine("Scroll not found");
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine($"\nScroll \"{cari}\" found. Queue number : {scrolls.IndexOf(cari) + 1}",
						scrolls.Find(x => x.Contains(cari)));
						Console.WriteLine();
					}
				}
				else if (pilihanmenu == 4)
				{
					Console.WriteLine();
					Console.Write("Remove from list by scroll name? Y/N ");
					string key = Console.ReadLine();
					switch (key)
					{
						case "Y":
							Console.Write("input name of scroll u want to remove : ");
							scrolls.Remove(Console.ReadLine());
							Console.WriteLine("Remove success, check your list");
							Console.WriteLine();
							break;

						case "N":
							Console.Write("input scroll queue u want to remove : ");
							counter = Convert.ToInt32(Console.ReadLine());
							while (scrolls.Count < counter)
							{
								Console.WriteLine("Queue not found!!!");
								Console.Write("input scroll queue u want to remove : ");
								counter = Convert.ToInt32(Console.ReadLine());
							}
							scrolls.RemoveAt(counter - 1);
							Console.WriteLine("Remove success, check your list");
							Console.WriteLine();
							break;
					}
				}
			}
		}
	}
}