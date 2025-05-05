using System.Drawing;

namespace Po1300_SVGAnimace.Models
{
	public class Ctverec : Obrazec
	{
		public Ctverec(int pozX, int pozY, Color barva, TypTvaru typTvaru, int stranaA) : base(pozX, pozY, barva, typTvaru)
		{
			StranaA = stranaA;
		}
		public int StranaA { get; }
	}
}
