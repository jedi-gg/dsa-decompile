using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerActivityChooseRewardView : APopupView
{
	private PlayerActivityChooseRewardView.SerializedFields Fields
	{
		[Address(RVA="0x132C68C", Offset="0x132C68C", VA="0x132C68C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x132C854", Offset="0x132C854", VA="0x132C854")]
	public PlayerActivityChooseRewardView()
	{
	}

	[Address(RVA="0x132C114", Offset="0x132C114", VA="0x132C114")]
	public void SetOptions(IReadOnlyList<PlayerActivityChooseRewardController.Option> options)
	{
	}

	[Address(RVA="0x132C76C", Offset="0x132C76C", VA="0x132C76C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x132C7E4", Offset="0x132C7E4", VA="0x132C7E4", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C70C", Offset="0x104C70C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerActivityChooseRewardController.Option option;

		[FieldOffset(Offset="0x18")]
		public PlayerActivityChooseRewardView <>4__this;

		[Address(RVA="0x132C684", Offset="0x132C684", VA="0x132C684")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x132C85C", Offset="0x132C85C", VA="0x132C85C")]
		internal void <SetOptions>b__0()
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public LayoutGroup OptionsLayoutGroup;

		[FieldOffset(Offset="0x38")]
		public PlayerActivityChooseRewardOptionContainer OptionContainerTemplate;

		[FieldOffset(Offset="0x40")]
		public UiLabel HeadingLabel;

		[Address(RVA="0x132C8F4", Offset="0x132C8F4", VA="0x132C8F4")]
		public SerializedFields()
		{
		}
	}
}