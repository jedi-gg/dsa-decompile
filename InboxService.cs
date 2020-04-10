using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class InboxService
{
	[Attribute(Name="InjectAttribute", RVA="0x10591B8", Offset="0x10591B8")]
	[FieldOffset(Offset="0x10")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x10591C8", Offset="0x10591C8")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x10591D8", Offset="0x10591D8")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10591E8", Offset="0x10591E8")]
	[FieldOffset(Offset="0x28")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x10591F8", Offset="0x10591F8")]
	[FieldOffset(Offset="0x30")]
	private HttpService _httpService;

	[Attribute(Name="InjectAttribute", RVA="0x1059208", Offset="0x1059208")]
	[FieldOffset(Offset="0x38")]
	private GameLanguageManager _gameLanguageManager;

	[FieldOffset(Offset="0x40")]
	private IReadOnlyList<InboxMessage> _messages;

	[Address(RVA="0x1181624", Offset="0x1181624", VA="0x1181624")]
	public InboxService()
	{
	}

	[Address(RVA="0x1181994", Offset="0x1181994", VA="0x1181994")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FEA4", Offset="0x106FEA4")]
	private void <FetchInboxMessages>b__3_0(InboxMessagesResponse response)
	{
	}

	[Address(RVA="0x1181A48", Offset="0x1181A48", VA="0x1181A48")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FEB4", Offset="0x106FEB4")]
	private void <FetchInboxMessages>b__3_1(long errorCode)
	{
	}

	[Address(RVA="0x11818F0", Offset="0x11818F0", VA="0x11818F0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE94", Offset="0x106FE94")]
	private void <FetchUnreadMessageCount>b__2_0(InboxUnreadCountResponse response)
	{
	}

	[Address(RVA="0x118162C", Offset="0x118162C", VA="0x118162C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE74", Offset="0x106FE74")]
	private void <FetchUnreadNewsletterMessageCount>b__0_0(Dictionary<string, string> data)
	{
	}

	[Address(RVA="0x11817F4", Offset="0x11817F4", VA="0x11817F4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE84", Offset="0x106FE84")]
	private void <FetchUnreadNewsletterMessageCount>b__0_1(long errorCode, byte[] data)
	{
	}

	[Address(RVA="0x1181B44", Offset="0x1181B44", VA="0x1181B44")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FEC4", Offset="0x106FEC4")]
	private void <MarkAllAsRead>b__5_0(InboxMarkAllAsReadResponse response)
	{
	}

	[Address(RVA="0x117F134", Offset="0x117F134", VA="0x117F134")]
	public void ClaimAttachments(string messageId, ulong templateId, Func<bool> silence)
	{
	}

	[Address(RVA="0x117F7A4", Offset="0x117F7A4", VA="0x117F7A4")]
	public void DeleteMessage(string messageId, Func<bool> silence)
	{
	}

	[Address(RVA="0x1181068", Offset="0x1181068", VA="0x1181068")]
	public void FetchInboxMessages(Func<bool> silence)
	{
	}

	[Address(RVA="0x1180E78", Offset="0x1180E78", VA="0x1180E78")]
	public void FetchUnreadMessageCount(Func<bool> silence)
	{
	}

	[Address(RVA="0x11713DC", Offset="0x11713DC", VA="0x11713DC")]
	public void FetchUnreadNewsletterMessageCount()
	{
	}

	[Address(RVA="0x1181424", Offset="0x1181424", VA="0x1181424")]
	public void MarkAllAsRead(Func<bool> silence)
	{
	}

	[Address(RVA="0x1181208", Offset="0x1181208", VA="0x1181208")]
	public void MarkAsRead(string messageId, Func<bool> silence)
	{
	}

	[Address(RVA="0x1180D98", Offset="0x1180D98", VA="0x1180D98")]
	public void ResetUnreadNewsletterMessageCount()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C0DC", Offset="0x104C0DC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static InboxService.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__2_1;

		[FieldOffset(Offset="0x10")]
		public static Func<bool> <>9__2_2;

		[FieldOffset(Offset="0x18")]
		public static Func<bool> <>9__3_2;

		[FieldOffset(Offset="0x20")]
		public static Func<bool> <>9__4_2;

		[FieldOffset(Offset="0x28")]
		public static Action<long> <>9__5_1;

		[FieldOffset(Offset="0x30")]
		public static Func<bool> <>9__5_2;

		[FieldOffset(Offset="0x38")]
		public static Func<bool> <>9__6_2;

		[FieldOffset(Offset="0x40")]
		public static Func<bool> <>9__7_2;

		[Address(RVA="0x1181BCC", Offset="0x1181BCC", VA="0x1181BCC")]
		static <>c()
		{
		}

		[Address(RVA="0x1181C30", Offset="0x1181C30", VA="0x1181C30")]
		public <>c()
		{
		}

		[Address(RVA="0x1181DB8", Offset="0x1181DB8", VA="0x1181DB8")]
		internal bool <ClaimAttachments>b__6_2()
		{
			return new bool();
		}

		[Address(RVA="0x1181DC0", Offset="0x1181DC0", VA="0x1181DC0")]
		internal bool <DeleteMessage>b__7_2()
		{
			return new bool();
		}

		[Address(RVA="0x1181CF0", Offset="0x1181CF0", VA="0x1181CF0")]
		internal bool <FetchInboxMessages>b__3_2()
		{
			return new bool();
		}

		[Address(RVA="0x1181C38", Offset="0x1181C38", VA="0x1181C38")]
		internal void <FetchUnreadMessageCount>b__2_1(long errorCode)
		{
		}

		[Address(RVA="0x1181CE8", Offset="0x1181CE8", VA="0x1181CE8")]
		internal bool <FetchUnreadMessageCount>b__2_2()
		{
			return new bool();
		}

		[Address(RVA="0x1181D00", Offset="0x1181D00", VA="0x1181D00")]
		internal void <MarkAllAsRead>b__5_1(long errorCode)
		{
		}

		[Address(RVA="0x1181DB0", Offset="0x1181DB0", VA="0x1181DB0")]
		internal bool <MarkAllAsRead>b__5_2()
		{
			return new bool();
		}

		[Address(RVA="0x1181CF8", Offset="0x1181CF8", VA="0x1181CF8")]
		internal bool <MarkAsRead>b__4_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C0EC", Offset="0x104C0EC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public InboxService <>4__this;

		[FieldOffset(Offset="0x18")]
		public string messageId;

		[Address(RVA="0x118141C", Offset="0x118141C", VA="0x118141C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1181DC8", Offset="0x1181DC8", VA="0x1181DC8")]
		internal void <MarkAsRead>b__0(InboxMarkAsReadResponse response)
		{
		}

		[Address(RVA="0x1181E64", Offset="0x1181E64", VA="0x1181E64")]
		internal void <MarkAsRead>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C0FC", Offset="0x104C0FC")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public InboxService <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong templateId;

		[FieldOffset(Offset="0x20")]
		public string messageId;

		[Address(RVA="0x1181614", Offset="0x1181614", VA="0x1181614")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1181F78", Offset="0x1181F78", VA="0x1181F78")]
		internal void <ClaimAttachments>b__0(InboxMarkAsClaimedResponse response)
		{
		}

		[Address(RVA="0x1182144", Offset="0x1182144", VA="0x1182144")]
		internal void <ClaimAttachments>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C10C", Offset="0x104C10C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public InboxService <>4__this;

		[FieldOffset(Offset="0x18")]
		public string messageId;

		[Address(RVA="0x118161C", Offset="0x118161C", VA="0x118161C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x1182258", Offset="0x1182258", VA="0x1182258")]
		internal void <DeleteMessage>b__0(InboxMarkAsDeletedResponse response)
		{
		}

		[Address(RVA="0x11822F4", Offset="0x11822F4", VA="0x11822F4")]
		internal void <DeleteMessage>b__1(long errorCode)
		{
		}
	}
}