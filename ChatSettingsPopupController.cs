using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ChatSettingsPopupController : APopupController, IDispatchHandler<DPlayerListItemClickedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1055D68", Offset="0x1055D68")]
	[FieldOffset(Offset="0x38")]
	private ChatService _chatService;

	[Attribute(Name="InjectAttribute", RVA="0x1055D78", Offset="0x1055D78")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055D88", Offset="0x1055D88")]
	[FieldOffset(Offset="0x48")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x50")]
	private ChatSettingsPopupView _view;

	[FieldOffset(Offset="0x58")]
	private List<PlayerListItemData> _blockedUsers;

	[Address(RVA="0x11A1548", Offset="0x11A1548", VA="0x11A1548")]
	public ChatSettingsPopupController()
	{
	}

	[Address(RVA="0x11A1550", Offset="0x11A1550", VA="0x11A1550")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EAEC", Offset="0x106EAEC")]
	private void <HandleDispatchAction>b__2_1(long errorCode)
	{
	}

	[Address(RVA="0x11A0DA0", Offset="0x11A0DA0", VA="0x11A0DA0", Slot="14")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x11A0BB8", Offset="0x11A0BB8", VA="0x11A0BB8", Slot="8")]
	public override void Initialize(ITransitionContext context, Action initCompleted)
	{
	}

	[Address(RVA="0x11A0FF0", Offset="0x11A0FF0", VA="0x11A0FF0")]
	private void PopulateBlockList(GetBlockedChatUsersResponse response)
	{
	}

	[Address(RVA="0x11A0D94", Offset="0x11A0D94", VA="0x11A0D94", Slot="9")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B58C", Offset="0x104B58C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ChatSettingsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action initCompleted;

		[FieldOffset(Offset="0x20")]
		public Action<long> <>9__4;

		[Address(RVA="0x11A0D8C", Offset="0x11A0D8C", VA="0x11A0D8C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11A1610", Offset="0x11A1610", VA="0x11A1610")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x11A18DC", Offset="0x11A18DC", VA="0x11A18DC")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x11A19D0", Offset="0x11A19D0", VA="0x11A19D0")]
		internal void <Initialize>b__2()
		{
		}

		[Address(RVA="0x11A17B4", Offset="0x11A17B4", VA="0x11A17B4")]
		internal void <Initialize>b__4(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B59C", Offset="0x104B59C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ChatSettingsPopupController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x11A17AC", Offset="0x11A17AC", VA="0x11A17AC")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x11A1A50", Offset="0x11A1A50", VA="0x11A1A50")]
		internal void <Initialize>b__3(GetBlockedChatUsersResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B5AC", Offset="0x104B5AC")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ChatSettingsPopupController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x11A19C8", Offset="0x11A19C8", VA="0x11A19C8")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x11A1ABC", Offset="0x11A1ABC", VA="0x11A1ABC")]
		internal void <Initialize>b__5(ChatSettingsPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B5BC", Offset="0x104B5BC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public UnblockChatUserRequest request;

		[FieldOffset(Offset="0x18")]
		public ChatSettingsPopupController <>4__this;

		[Address(RVA="0x11A0FE8", Offset="0x11A0FE8", VA="0x11A0FE8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x11A1B20", Offset="0x11A1B20", VA="0x11A1B20")]
		internal void <HandleDispatchAction>b__0(UnblockChatUserResponse response)
		{
		}
	}
}