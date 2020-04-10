using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class AndroidNativeMessageSharing : INativeMessageSharing
	{
		[Address(RVA="0x14FA5F4", Offset="0x14FA5F4", VA="0x14FA5F4")]
		public AndroidNativeMessageSharing()
		{
		}

		[Address(RVA="0x14F9B2C", Offset="0x14F9B2C", VA="0x14F9B2C", Slot="4")]
		public void ShareText(string message, string subject, string chooserTitle)
		{
		}
	}
}