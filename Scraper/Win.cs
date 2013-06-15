using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawl.Scraper
{
	public class Win
	{
		public int Score { get; set; }
		public string Character { get; set; }
		public int Turns { get; set; }
		public TimeSpan Duration { get; set; }
		public string God { get; set; }
		public int NumberOfRunes { get; set; }
		public DateTime CompleteDate { get; set; }
		public string Version { get; set; }

		public Win()
		{
		}

		public Win(int score, string character, int turns, //TimeSpan duration,
			string god, int numberOfRunes, //DateTime completeDate,
			string version)
		{
			Score = score;
			Character = character;
			Turns = turns;
			//Duration = duration;
			God = god;
			NumberOfRunes = numberOfRunes;
			//CompleteDate = completeDate;
			Version = version;
		}
	}
}
