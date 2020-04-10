using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class APopupView : AView
	{
		public sealed override ViewDepth Depth
		{
			[Address(RVA="0x14F6F58", Offset="0x14F6F58", VA="0x14F6F58", Slot="5")]
			get
			{
				return new ViewDepth();
			}
		}

		private PopupViewSerializedFields Fields
		{
			[Address(RVA="0x14F6F64", Offset="0x14F6F64", VA="0x14F6F64")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14EC260", Offset="0x14EC260", VA="0x14EC260")]
		protected APopupView()
		{
		}

		[Address(RVA="0x14F71B0", Offset="0x14F71B0", VA="0x14F71B0", Slot="21")]
		protected virtual void ClosePopupView()
		{
		}

		[Address(RVA="0x14EBF3C", Offset="0x14EBF3C", VA="0x14EBF3C", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x14F7044", Offset="0x14F7044", VA="0x14F7044", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}
	}
}