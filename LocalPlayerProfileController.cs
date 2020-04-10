using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class LocalPlayerProfileController : APlayerProfileController
{
	[Attribute(Name="InjectAttribute", RVA="0x105B9A0", Offset="0x105B9A0")]
	[FieldOffset(Offset="0x90")]
	private PlayerDomainController _playerDC;

	[Address(RVA="0x11D9914", Offset="0x11D9914", VA="0x11D9914")]
	public LocalPlayerProfileController()
	{
	}

	[Address(RVA="0x11D95E8", Offset="0x11D95E8", VA="0x11D95E8", Slot="14")]
	public override void HandleDispatchAction(DPlayerProfileAction action)
	{
	}

	[Address(RVA="0x11D98B4", Offset="0x11D98B4", VA="0x11D98B4", Slot="16")]
	protected override void InitializeView()
	{
	}

	[Address(RVA="0x11D96E0", Offset="0x11D96E0", VA="0x11D96E0", Slot="15")]
	protected override void LoadProfileInfo(Action<Player, List<PlayerStat>> success, Action<long> failure)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C77C", Offset="0x104C77C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public Action<Player, List<PlayerStat>> success;

		[FieldOffset(Offset="0x18")]
		public LocalPlayerProfileController <>4__this;

		[Address(RVA="0x11D98AC", Offset="0x11D98AC", VA="0x11D98AC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x11D991C", Offset="0x11D991C", VA="0x11D991C")]
		internal void <LoadProfileInfo>b__0(PlayerProfileResponse response)
		{
		}
	}
}