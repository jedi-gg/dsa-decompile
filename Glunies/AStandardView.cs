using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class AStandardView : AView
	{
		public sealed override ViewDepth Depth
		{
			[Address(RVA="0x14F729C", Offset="0x14F729C", VA="0x14F729C", Slot="5")]
			get
			{
				return new ViewDepth();
			}
		}

		[Address(RVA="0x14F72A4", Offset="0x14F72A4", VA="0x14F72A4")]
		protected AStandardView()
		{
		}
	}
}