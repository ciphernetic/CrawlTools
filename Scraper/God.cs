using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawl.Scraper
{
	[Flags]
	public enum God
	{
		NoGod = 1,
		Makhleb = 2,
		Trog = 4,
		Okawaru = 8,
		Beogh = 16,
		SifMuna = 32,
		NemelexXobeh = 64,
		TheShiningOne = 128,
		Vehumet = 256,
		Kikubaaqudgha = 512,
		Jiyva = 1024,
		Ashenzari = 2048,
		Xom = 4096,
		Lugonu = 8192,
		Zin = 16384,
		Cheibriados = 32768,
		Elyvilon = 65536,
		Yredelemnul = 131072,

		All = NoGod | Makhleb | Trog | Okawaru | Beogh | SifMuna | NemelexXobeh
			| TheShiningOne | Vehumet | Kikubaaqudgha | Jiyva | Ashenzari | Xom
			| Lugonu | Zin | Cheibriados | Elyvilon | Yredelemnul
	}
}
