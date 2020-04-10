using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class EditorNativeMessageSharing : INativeMessageSharing
	{
		[Address(RVA="0x1421F4C", Offset="0x1421F4C", VA="0x1421F4C")]
		public EditorNativeMessageSharing()
		{
		}

		[Address(RVA="0x1421EB8", Offset="0x1421EB8", VA="0x1421EB8", Slot="4")]
		public void ShareText(string message, string subject, string chooserTitle)
		{
		}
	}
}