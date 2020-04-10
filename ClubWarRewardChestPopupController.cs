using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubWarRewardChestPopupController : APopupController
{
	[Address(RVA="0x14D7B80", Offset="0x14D7B80", VA="0x14D7B80")]
	public ClubWarRewardChestPopupController()
	{
	}

	[Address(RVA="0x14D797C", Offset="0x14D797C", VA="0x14D797C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB2C", Offset="0x104BB2C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarRewardChestPopupController.Context chestContext;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14D7B78", Offset="0x14D7B78", VA="0x14D7B78")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14D7B88", Offset="0x14D7B88", VA="0x14D7B88")]
		internal void <Initialize>b__0(ClubWarRewardChestPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ClubWarReward Chest;

		[Address(RVA="0x14D7E74", Offset="0x14D7E74", VA="0x14D7E74")]
		public Context(ClubWarReward chest)
		{
		}
	}
}