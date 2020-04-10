using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class FetchPlayerJob : IJob
{
	[Attribute(Name="InjectAttribute", RVA="0x105B474", Offset="0x105B474")]
	[FieldOffset(Offset="0x10")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105B484", Offset="0x105B484")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x12C7B6C", Offset="0x12C7B6C", VA="0x12C7B6C")]
	public FetchPlayerJob()
	{
	}

	[Address(RVA="0x12C793C", Offset="0x12C793C", VA="0x12C793C", Slot="4")]
	public void Execute(Action executed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C61C", Offset="0x104C61C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static FetchPlayerJob.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__0_2;

		[Address(RVA="0x12C7B74", Offset="0x12C7B74", VA="0x12C7B74")]
		static <>c()
		{
		}

		[Address(RVA="0x12C7BD8", Offset="0x12C7BD8", VA="0x12C7BD8")]
		public <>c()
		{
		}

		[Address(RVA="0x12C7BE0", Offset="0x12C7BE0", VA="0x12C7BE0")]
		internal bool <Execute>b__0_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C60C", Offset="0x104C60C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public FetchPlayerJob <>4__this;

		[Address(RVA="0x12C7B64", Offset="0x12C7B64", VA="0x12C7B64")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12C7BE8", Offset="0x12C7BE8", VA="0x12C7BE8")]
		internal void <Execute>b__0(PlayerResponse response)
		{
		}

		[Address(RVA="0x12C7BFC", Offset="0x12C7BFC", VA="0x12C7BFC")]
		internal void <Execute>b__1(long errorCode)
		{
		}
	}
}