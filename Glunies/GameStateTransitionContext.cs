using Il2CppDummyDll;
using System;
using System.Collections.ObjectModel;

namespace Glunies
{
	public class GameStateTransitionContext : ITransitionContext
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106412C", Offset="0x106412C")]
		[FieldOffset(Offset="0x10")]
		private ReadOnlyCollection<DPopupHistory> <PopupHistory>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106413C", Offset="0x106413C")]
		[FieldOffset(Offset="0x18")]
		private ScrimOptions <ScrimOptions>k__BackingField;

		public ReadOnlyCollection<DPopupHistory> PopupHistory
		{
			[Address(RVA="0x14276D4", Offset="0x14276D4", VA="0x14276D4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A314", Offset="0x108A314")]
			get
			{
				return null;
			}
			[Address(RVA="0x14276DC", Offset="0x14276DC", VA="0x14276DC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A324", Offset="0x108A324")]
			set
			{
			}
		}

		public ScrimOptions ScrimOptions
		{
			[Address(RVA="0x14276E4", Offset="0x14276E4", VA="0x14276E4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A334", Offset="0x108A334")]
			get
			{
				return new ScrimOptions();
			}
			[Address(RVA="0x14276EC", Offset="0x14276EC", VA="0x14276EC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A344", Offset="0x108A344")]
			set
			{
			}
		}

		[Address(RVA="0x14276F4", Offset="0x14276F4", VA="0x14276F4")]
		public GameStateTransitionContext()
		{
		}
	}
}