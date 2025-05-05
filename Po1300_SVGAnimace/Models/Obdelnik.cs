using System.Drawing;

namespace Po1300_SVGAnimace.Models
{
	public class Obdelnik : Ctverec
	{
		public Obdelnik(int pozX, int pozY, Color barva, TypTvaru typTvaru, int stranaA, int stranaB) : base(pozX, pozY, barva, typTvaru, stranaA)
		{
			StranaB = stranaB;
		}
		public int StranaB { get; }
	}
}
