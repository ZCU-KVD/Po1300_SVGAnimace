using Po1300_SVGAnimace.Models;
using System.Drawing;

namespace Po1300_SVGAnimace.Pages
{
	public partial class SVG1
	{
		public SVG1()
		{
			// Initialize the SVG dimensions
			SVGWidth = 1200;
			SVGHeight = 600;

			MinRozmer = 10; // Minimum size for the shapes
			MaxRozmer = 70; // Maximum size for the shapes
		}

		#region Vlastnosti
		private int SVGWidth { get; set; }
		private int SVGHeight { get; set; }
		private int MinRozmer { get; set; } 
		private int MaxRozmer { get; set; } 
		private List<Obrazec> SVGObrazceList { get; set; } = new List<Obrazec>();
		private Random rnd = new Random();
		private int TypTvaruCount => Enum.GetValues(typeof(Models.TypTvaru)).Length; // Get the number of shape types
		#endregion

		#region Metody
		private void PridatObrazec()
		{
			Models.TypTvaru typTvaru = (Models.TypTvaru)rnd.Next(0, TypTvaruCount);
			int stranaA = rnd.Next(MinRozmer, MaxRozmer);
			int stranaB = rnd.Next(MinRozmer, MaxRozmer);
			int pozX = rnd.Next(0, SVGWidth - stranaA);
			Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
			Obrazec? obrazec = typTvaru switch
			{
				TypTvaru.Ctverec => new Ctverec(pozX, rnd.Next(SVGHeight - stranaA), color, typTvaru, stranaA),
				TypTvaru.Obdelnik => new Obdelnik(pozX, rnd.Next(SVGHeight - stranaB), color, typTvaru, stranaA, stranaB),
				TypTvaru.Kruh => new Kruh(pozX, rnd.Next(SVGHeight - stranaA), color, typTvaru, polomer: stranaA / 2),
				_ => null
			};
			if (obrazec != null)
			{
				SVGObrazceList.Add(obrazec);
			}
		}
		#endregion

	}
}
