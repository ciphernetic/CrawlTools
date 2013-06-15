using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawl.Scraper
{
	[Flags]
	public enum Species : long
	{
		Ce = 1,
		DD = 2,
		DE = 4,
		DG = 8,
		DS = 16,
		Dj = 32,
		Dr = 64,
		El = 128,
		Fe = 256,
		GE = 512,
		Gh = 1024,
		Gn = 2048,
		Gr = 4096,
		HD = 8192,
		HE = 16384,
		HO = 32768,
		Ha = 65536,
		Hu = 131072,
		Ke = 262144,
		Ko = 524288,
		LO = 1048576,
		MD = 2097152,
		Mf = 4194304,
		Mi = 8388608,
		Mu = 16777216,
		Na = 33554432,
		OM = 67108864,
		OP = 134217728,
		Og = 268435456,
		SE = 536870912,
		Sp = 1073741824,
		Te = 2147483648,
		Tr = 4294967296,
		Vp = 8589934592,

		Version12 = Ce | DD | DE | DG | DS | Dr | Fe | Gh | HE | HO | Ha | Ko
			| Mf | Mi | Mu | Na | OP | Og | SE | Sp | Te | Tr | Vp,
		Version13 = Ce | DD | DE | DG | DS | Dr | Fe | Gh | HE | HO | Ha | Ko
			| Mf | Mi | Mu | Na | OP | Og | SE | Sp | Te | Tr | Vp | LO | Dj 
			| Gr,
	}
}
