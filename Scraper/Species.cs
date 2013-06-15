using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crawl.Scraper
{
	public class Species
	{
		/// <summary>
		/// Full name.
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// Abbreviation.
		/// </summary>
		public string ShortName { get; private set; }
		/// <summary>
		/// First playable version.
		/// </summary>
		public Version FirstVersion { get; private set; }
		/// <summary>
		/// Still playable.
		/// </summary>
		public bool Active { get; private set; }

		/// <summary>
		/// Base constructor.
		/// </summary>
		/// <param name="name">Full name.</param>
		/// <param name="shortName">Abbreviation.</param>
		/// <param name="firstVersion">First playable version.</param>
		/// <param name="active">Still playable.</param>
		public Species(string name, string shortName, Version firstVersion,
			bool active)
		{
			Name = name;
			ShortName = shortName;
			FirstVersion = firstVersion;
			Active = active;
		}

		/// <summary>
		/// Constructor with string version.
		/// </summary>
		/// <param name="name">Full name.</param>
		/// <param name="shortName">Abbreviation.</param>
		/// <param name="firstVersion">First playable version.</param>
		/// <param name="active">Still playable.</param>
		public Species(string name, string shortName, string firstVersion,
			bool active)
			: this(name, shortName, new Version(firstVersion), active)
		{
		}

		/// <summary>
		/// Constructor with default version of 0.0.0.
		/// </summary>
		/// <param name="name">Full name.</param>
		/// <param name="shortName">Abbreviation.</param>
		/// <param name="active">Still playable.</param>
		public Species(string name, string shortName, bool active)
			: this(name, shortName, new Version("0.1.0"), active)
		{
		}
	}
}
