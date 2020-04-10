using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class IosNativeMessageSharing : INativeMessageSharing
	{
		[Address(RVA="0x1526C38", Offset="0x1526C38", VA="0x1526C38")]
		public IosNativeMessageSharing()
		{
		}

		[Address(RVA="0x1526C34", Offset="0x1526C34", VA="0x1526C34", Slot="4")]
		public void ShareText(string message, string subject, string chooserTitle)
		{
		}
	}
}