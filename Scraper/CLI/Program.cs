using System;

using Crawl.Scraper;

namespace Crawl.Scraper.CLI
{
	class Program
	{
		static void Main(string[] args)
		{
			PlayerStats player = new PlayerStats("elliptic");
			Console.WriteLine("{0} is a polytheist - {1}", player.PlayerName,
				player.IsPolytheist());
		}
	}
}
