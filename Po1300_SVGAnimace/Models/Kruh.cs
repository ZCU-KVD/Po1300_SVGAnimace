using System.Drawing;

namespace Po1300_SVGAnimace.Models
{
	public class Kruh : Obrazec
	{
		public Kruh(int pozX, int pozY, Color barva, TypTvaru typTvaru, int polomer) : base(pozX, pozY, barva, typTvaru)
		{
			Polomer = polomer;
		}
		public int Polomer { get;  }
	}
}
