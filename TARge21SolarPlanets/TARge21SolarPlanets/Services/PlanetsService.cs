
namespace TARge21SolarPlanets.Services
{
	internal static class PlanetsService
	{
		private static List<Planet> planets = new()
		{
			new()
			{
				Name= " Mercury",
				Subtitle= " The smallest planet",
				HeroImage = "mercury.png",
				Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. It is named after the Roman god Mercurius (Mercury), god of commerce, messenger of the gods, and mediator between gods and mortals, corresponding to the Greek god Hermes (Ἑρμῆς).",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
				{
					"https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg",
				},

			},


			new()
			{
				Name= " Venus",
				Subtitle= " The pressure cooker",
				HeroImage = "venus.png",
				Description = "Venus is the second planet from the Sun. It is sometimes called Earth's \"sister\" or \"twin\" planet as it is almost as large and has a similar composition. As an interior planet to Earth, Venus (like Mercury) appears in Earth's sky never far from the Sun, either as morning star or evening star. ",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
				},

			},


			new()
			{
				Name= " Earth",
				Subtitle= " The cradle of Life",
				HeroImage = "earth.png",
				Description = "Earth is the third planet from the Sun and the only place known in the universe where life has originated and found habitability. While Earth may not contain the largest volumes of water in the Solar System, only Earth sustains liquid surface water, extending over 70.8% of the Earth with its ocean, making Earth an ocean world. Earth's polar regions currently retain most of all other water with large sheets of ice covering ocean and land, dwarfing Earth's groundwater, lakes, rivers and atmospheric water.",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
					"https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
					"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				},

			},

			new()
			{
				Name= " Mars",
				Subtitle= " The iron Planet",
				HeroImage = "mars.png",
				Description = "​Mars is the fourth planet from the Sun – a dusty, cold, desert world with a very thin atmosphere. Mars is also a dynamic planet with seasons, polar ice caps, canyons, extinct volcanoes, and evidence that it was even more active in the past. Mars is one of the most explored bodies in our solar system, and it's the only planet where we've sent rovers to roam the alien landscape.",
				AccentColorStart = Color.FromArgb("#a23036"),
				AccentColorEnd = Color.FromArgb("#eb3333"),
				Images = new()
				{
					"https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
					"https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
					"https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
				},

			},

			new()
			{
				Name= " Jupiter",
				Subtitle= " The gas giant",
				HeroImage = "jupiter.png",
				Description = "Jupiter has a long history of surprising scientists – all the way back to 1610 when Galileo Galilei found the first moons beyond Earth. That discovery changed the way we see the universe. Fifth in line from the Sun, Jupiter is, by far, the largest planet in the solar system – more than twice as massive as all the other planets combined.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
				},

			},

			new()
			{
				Name= " Saturn",
				Subtitle= " The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second-largest planet in our solar system. Adorned with thousands of beautiful ringlets, Saturn is unique among the planets. It is not the only planet to have rings – made of chunks of ice and rock – but none are as spectacular or as complicated as Saturn's.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
				},

			},

			new()
			{
				Name= " Uranus",
				Subtitle= " The Herschel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is the seventh planet from the Sun, and has the third-largest diameter in our solar system. It was the first planet found with the aid of a telescope, Uranus was discovered in 1781 by astronomer William Herschel, although he originally thought it was either a comet or a star.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
				},

			},

			new()
			{
				Name= " Neptune",
				Subtitle= " The god of the sea",
				HeroImage = "neptune.png",
				Description = "Dark, cold, and whipped by supersonic winds, ice giant Neptune is the eighth and most distant planet in our solar system. More than 30 times as far from the Sun as Earth, Neptune is the only planet in our solar system not visible to the naked eye and the first predicted by mathematics before its discovery. In 2011 Neptune completed its first 165-year orbit since its discovery in 1846.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
				},

			},

			//kääbusplaneedid

			new()
			{
				Name= " Pluto",
				Subtitle= " The reclassified",
				HeroImage = "pluto.png",
				Description = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. There may be millions of these icy objects, collectively referred to as Kuiper Belt objects (KBOs) or trans-Neptunian objects (TNOs), in this distant region of our solar system.",
				AccentColorStart = Color.FromArgb("#F5D57A"),
				AccentColorEnd = Color.FromArgb("#7F4B2C"),
				Images = new()
				{
					"https://cdn.images.express.co.uk/img/dynamic/galleries/x701/183998.jpg",
					"https://s-i.huffpost.com/gen/3208734/images/o-PLUTO-facebook.jpg"
				},

			},

			new()
			{
				Name= " Ceres",
				Subtitle= " The cereal killer",
				HeroImage = "ceres.png",
				Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. And when NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to receive a visit from a spacecraft.\r\n\r\nCalled an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006. Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive.",
				AccentColorStart = Color.FromArgb("#908179"),
				AccentColorEnd = Color.FromArgb("#908580"),
				Images = new()
				{
					"https://www.universetoday.com/wp-content/uploads/2016/07/PIA20182.jpg",
					"https://1734811051.rsc.cdn77.org/data/images/full/369924/ceres-nasa-findings.jpg"
				},

			},

			new()
			{
				Name= " Haumea",
				Subtitle= " The egg!",
				HeroImage = "haumea.png",
				Description = "Originally designated 2003 EL61 (and nicknamed Santa by one discovery team), Haumea is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. The other known dwarf planets in the Kuiper Belt are Pluto, Eris, and Makemake (dwarf planet Ceres is located in the main asteroid belt between Mars and Jupiter).\r\n\r\nHaumea is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, making this dwarf planet look like a football.",
				AccentColorStart = Color.FromArgb("#4A8DC6"),
				AccentColorEnd = Color.FromArgb("#2D638F"),
				Images = new()
				{
					"https://solarstory.net/img/articles/big/artists-impression-of-the-dwarf-planet-haumea.jpg",
					"https://daily.jstor.org/wp-content/uploads/2016/10/Haumea_1050x700.jpg"
				},

			},

			new()
			{
				Name= " Makemake",
				Subtitle= " The creation",
				HeroImage = "makemake.png",
				Description = "Along with fellow dwarf planets Pluto, Eris, and Haumea, Makemake is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. Slightly smaller than Pluto, Makemake is the second-brightest object in the Kuiper Belt as seen from Earth (while Pluto is the brightest). It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.\r\n\r\nMakemake holds an important place in the history of solar system studies because it – along with Eris – was one of the objects whose discovery prompted the International Astronomical Union to reconsider the definition of a planet and to create the new group of dwarf planets.",
				AccentColorStart = Color.FromArgb("#E0A87A"),
				AccentColorEnd = Color.FromArgb("#AA8464"),
				Images = new()
				{
					"https://www.renderhub.com/3dstudio/dwarf-planet-makemake/dwarf-planet-makemake-01.jpg",
					"https://scitechdaily.com/images/artist%E2%80%99s-impression-shows-the-surface-of-the-distant-dwarf-planet-Makemake.jpg"
				},

			},

			new()
			{
				Name= " Eris",
				Subtitle= " The discourser",
				HeroImage = "eris.png",
				Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.\r\n\r\nAt first, Eris appeared to be larger than Pluto. This triggered a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets.",
				AccentColorStart = Color.FromArgb("#FCDE83"),
				AccentColorEnd = Color.FromArgb("#318377"),
				Images = new()
				{
					"https://solarstory.net/img/articles/big/artists-impression-of-the-dwarf-planet-eris.jpg",
					"https://ak8.picdn.net/shutterstock/videos/1016925148/thumb/1.jpg"
				},

			},

		};

		public static List<Planet> GetFeaturedPlanets()
		{
			var random = new Random();
			var randomizedPlanets = planets.OrderBy(item => random.Next());

			return randomizedPlanets.Take(2).ToList();
		}

		public static List<Planet> GetAllPlanets()
			=> planets;
	}
}
