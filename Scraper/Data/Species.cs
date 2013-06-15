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
					{"Hu", new C.Species("Human", "Hu")},
					{"El", new C.Species("Elf", "El","0.1.0","0.2.7", false)},
					{"HE", new C.Species("High Elf", "HE")},
					{"GE", new C.Species("Grey Elf", "GE","0.1.0","0.4.5", false)},
					{"DE", new C.Species("Deep Elf", "DE")},
					{"SE", new C.Species("Sludge Elf", "SE","0.1.0","0.12.2", false)},
					{"HD", new C.Species("Hill Dwarf", "HD","0.1.0","0.2.7", false)},
					{"MD", new C.Species("Mountain Dwarf", "MD","0.1.0","0.9.2", false)},
					{"DD", new C.Species("Deep Dwarf", "DD")},
					{"HO", new C.Species("Hill Orc", "HO")},
					{"Mf", new C.Species("Merfolk", "Mf")},
					{"Ha", new C.Species("Halfling", "Ha")},
					{"Ko", new C.Species("Kobold", "Ko")},
					{"Sp", new C.Species("Spriggan", "Sp")},
					{"Na", new C.Species("Naga", "Na")},
					{"Gn", new C.Species("Gnome", "Gn","0.1.0","0.4.5", false)},
					{"Ce", new C.Species("Centaur", "Ce")},
					{"Og", new C.Species("Ogre", "Og")},
					{"OM", new C.Species("Ogre-Mage", "OM","0.1.0","0.4.5", false)},
					{"Tr", new C.Species("Troll", "Tr")},
					{"Mi", new C.Species("Minotaur", "Mi")},
					{"Te", new C.Species("Tengu", "Te")},
					{"Dr", new C.Species("Draconian", "Dr")},
					{"Dg", new C.Species("Demigod", "Dg")},
					{"Ds", new C.Species("Demonspawn", "Ds")},
					{"Mu", new C.Species("Mummy", "Mu")},
					{"Gh", new C.Species("Ghoul", "Gh")},
					{"Vp", new C.Species("Vampire", "Vp", "0.4.5")},
					{"Fe", new C.Species("Felid", "Fe", "0.8.0")},
					{"Op", new C.Species("Octopode", "Op", "0.10.0")},
					{"LO", new C.Species("Lava Orc", "LO", "0.13.0")},
					{"Dj", new C.Species("Djinni", "Dj", "0.13.0")},
					{"Gr", new C.Species("Gargoyle", "Gr", "0.13.0")}
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
