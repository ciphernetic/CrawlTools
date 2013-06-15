using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C = Crawl.Scraper;

namespace Crawl.Scraper.Data
{
	public static class Species
	{
		/// <summary>
		/// Dictionary of all species keyed on abbreviation.
		/// </summary>
		/// <returns>Dictionary of species info.</returns>
		public static Dictionary<string, C.Species> GetSpecies()
		{
			return new Dictionary<string, C.Species>()
				{
					{"Hu", new C.Species("Human", "Hu", true)},
					{"El", new C.Species("Elf", "El", false)},
					{"HE", new C.Species("High Elf", "HE", true)},
					{"GE", new C.Species("Grey Elf", "GE", false)},
					{"DE", new C.Species("Deep Elf", "DE", true)},
					{"SE", new C.Species("Sludge Elf", "SE", false)},
					{"HD", new C.Species("Hill Dwarf", "HD", false)},
					{"MD", new C.Species("Mountain Dwarf", "MD", false)},
					{"DD", new C.Species("Deep Dwarf", "DD", true)},
					{"HO", new C.Species("Hill Orc", "HO", true)},
					{"Mf", new C.Species("Merfolk", "Mf", true)},
					{"Ha", new C.Species("Halfling", "Ha", true)},
					{"Ko", new C.Species("Kobold", "Ko", true)},
					{"Sp", new C.Species("Spriggan", "Sp", true)},
					{"Na", new C.Species("Naga", "Na", true)},
					{"Gn", new C.Species("Gnome", "Gn", false)},
					{"Ce", new C.Species("Centaur", "Ce", true)},
					{"Og", new C.Species("Ogre", "Og", true)},
					{"OM", new C.Species("Ogre-Mage", "OM", false)},
					{"Tr", new C.Species("Troll", "Tr", true)},
					{"Mi", new C.Species("Minotaur", "Mi", true)},
					{"Te", new C.Species("Tengu", "Te", true)},
					{"Dr", new C.Species("Draconian", "Dr", true)},
					{"Dg", new C.Species("Demigod", "Dg", true)},
					{"Ds", new C.Species("Demonspawn", "Ds", true)},
					{"Mu", new C.Species("Mummy", "Mu", true)},
					{"Gh", new C.Species("Ghoul", "Gh", true)},
					{"Vp", new C.Species("Vampire", "Vp", "0.4.5", true)},
					{"Fe", new C.Species("Felid", "Fe", "0.8.0", true)},
					{"Op", new C.Species("Octopode", "Op", "0.10.0", true)},
					{"LO", new C.Species("Lava Orc", "LO", "0.13.0", true)},
					{"Dj", new C.Species("Djinni", "Dj", "0.13.0", true)},
					{"Gr", new C.Species("Gargoyle", "Gr", "0.13.0", true)}
				};
		}

		/// <summary>
		/// Dictionary to map old abbreviations to new ones.
		/// </summary>
		/// <returns>Dictionary of abbreviations maps.</returns>
		public static Dictionary<string, string> SpeciesMap()
		{
			return new Dictionary<string, string>()
				{
					{"Ke", "Te"},
					{"DG", "Dg"},
					{"DS", "Ds"}
				};
		}
	}
}
