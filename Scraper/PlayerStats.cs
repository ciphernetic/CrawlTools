using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using HtmlAgilityPack;

namespace Crawl.Scraper
{
	public class PlayerStats
	{
		private const string BASE_URL = @"http://crawl.akrasiac.org/scoring/players/{0}.html";

		public string PlayerName { get; private set; }
		public List<Win> Wins { get; private set; }

		HtmlDocument page;

		/// <summary>
		/// Base constructor.
		/// </summary>
		/// <param name="playerName"></param>
		public PlayerStats(string playerName)
		{
			PlayerName = playerName;
			Wins = new List<Win>();

			page = LoadPage();
			ReadWins(page);
		}

		/// <summary>
		/// Loads page.
		/// </summary>
		/// <returns>Returns loaded page.</returns>
		private HtmlDocument LoadPage()
		{
			HtmlWeb web = new HtmlWeb();
			return web.Load(string.Format(CultureInfo.InvariantCulture,
				BASE_URL, PlayerName));
		}

		/// <summary>
		/// Parses the wins tables.
		/// </summary>
		/// <param name="doc">Page to parse.</param>
		private void ReadWins(HtmlDocument doc)
		{
			foreach(HtmlNode win in doc.DocumentNode
				.SelectNodes("//h3[text()='Wins']/../table/tr[contains(concat(' ', @class, ' '), ' win ')]"))
			{
				Win w = new Win();
				w.Score = int.Parse(win.ChildNodes[1].InnerText,
					NumberStyles.AllowThousands);
				w.Character = win.ChildNodes[2].InnerText;
				w.Turns = int.Parse(win.ChildNodes[5].InnerText,
					NumberStyles.AllowThousands);
				w.God = win.ChildNodes[7].InnerText;
				w.NumberOfRunes = Convert.ToInt32
					(win.ChildNodes[8].InnerText.Trim() == string.Empty // old games runes were inventory items, sometimes people forgot to pick them up...elliptic.
						? "0"
						: win.ChildNodes[8].InnerText);
				w.Version = win.ChildNodes[10].InnerText;

				Wins.Add(w);
			}
		}
	}
}
