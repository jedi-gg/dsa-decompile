using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class ATabView : AView
	{
		public override ViewDepth Depth
		{
			[Address(RVA="0x14F72A8", Offset="0x14F72A8", VA="0x14F72A8", Slot="5")]
			get
			{
				return new ViewDepth();
			}
		}

		private ATabView.SerializedFields Fields
		{
			[Address(RVA="0x14F72DC", Offset="0x14F72DC", VA="0x14F72DC")]
			get
			{
				return null;
			}
		}

		public UiTabGroup TabGroup
		{
			[Address(RVA="0x14F72B0", Offset="0x14F72B0", VA="0x14F72B0")]
			get
			{
				return null;
			}
		}

		protected override bool WillHandleBackButton
		{
			[Address(RVA="0x14F74EC", Offset="0x14F74EC", VA="0x14F74EC", Slot="19")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x14F74F4", Offset="0x14F74F4", VA="0x14F74F4")]
		protected ATabView()
		{
		}

		[Address(RVA="0x14F74E8", Offset="0x14F74E8", VA="0x14F74E8", Slot="21")]
		protected virtual void InitializedTabs(int selectedTab)
		{
		}

		[Address(RVA="0x14F73BC", Offset="0x14F73BC", VA="0x14F73BC")]
		public void InitializeTabs(int initialSelectedTab)
		{
		}

		[Address(RVA="0x14F7488", Offset="0x14F7488", VA="0x14F7488", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x14F748C", Offset="0x14F748C", VA="0x14F748C", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			public UiTabGroup TabGroup;

			[Address(RVA="0x14F74F8", Offset="0x14F74F8", VA="0x14F74F8")]
			public SerializedFields()
			{
			}
		}
	}
}