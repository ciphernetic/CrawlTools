using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crawl.Scraper
{
	public class Version : IComparable<Version>
	{
		private string mVersion;

		internal int Major { get; set; }
		internal int Minor { get; set; }
		internal int Revision { get; set; }

		public Version(string version)
		{
			mVersion = version;
			string[] parts = version.Replace('-', '.').Split('.');
			Major = int.Parse(parts[0]);
			Minor = int.Parse(parts[1]);
			int rev = 0;

			if(int.TryParse(parts[2], out rev))
			{
				Revision = rev;
			}
			else
			{
				Revision = 0;
			}
		}

		public override string ToString()
		{
			return mVersion;
		}

		public int CompareTo(Version other)
		{
			if(this.Major == other.Major)
			{
				if(this.Minor == other.Minor)
				{
					if(this.Revision > other.Revision)
					{
						return -1;
					}
					else if(this.Revision < other.Revision)
					{
						return 1;
					}
				}
				else if(this.Minor > other.Minor)
				{
					return -1;
				}
				else
				{
					return 1;
				}
			}
			else if(this.Major > other.Major)
			{
				return -1;
			}
			else
			{
				return 1;
			}

			return 0;
		}
	}
}
