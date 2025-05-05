using System.Drawing;

namespace Po1300_SVGAnimace.Models
{
	public abstract class Obrazec
	{
		public Obrazec(int pozX, int pozY, Color barva, TypTvaru typTvaru)
		{
			PozX = pozX;
			PozY = pozY;
			Barva = barva;
			TypTvaru = typTvaru;
		}

		public int PozX { get; private set; }
		public int PozY { get; private set; }
		public Color Barva { get; }
		public TypTvaru TypTvaru { get; }

	}
}
