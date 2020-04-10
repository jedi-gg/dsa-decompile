using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PinPageItemDetailsController : APopupController, IDispatchHandler<DPinPageItemDetailsViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B3F4", Offset="0x105B3F4")]
	[FieldOffset(Offset="0x38")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105B404", Offset="0x105B404")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B414", Offset="0x105B414")]
	[FieldOffset(Offset="0x48")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x50")]
	private PinPageItemDetailsController.Context _context;

	[FieldOffset(Offset="0x58")]
	private PinPageItemDetailsView _view;

	[Address(RVA="0x1411A8C", Offset="0x1411A8C", VA="0x1411A8C")]
	public PinPageItemDetailsController()
	{
	}

	[Address(RVA="0x14115F8", Offset="0x14115F8", VA="0x14115F8", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x1411600", Offset="0x1411600", VA="0x1411600", Slot="14")]
	public void HandleDispatchAction(DPinPageItemDetailsViewAction action)
	{
	}

	[Address(RVA="0x14114A0", Offset="0x14114A0", VA="0x14114A0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x14116F8", Offset="0x14116F8", VA="0x14116F8")]
	private void SetProfileIcon()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C5FC", Offset="0x104C5FC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PinPageItemDetailsController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__3_1;

		[Address(RVA="0x1411A94", Offset="0x1411A94", VA="0x1411A94")]
		static <>c()
		{
		}

		[Address(RVA="0x1411AF8", Offset="0x1411AF8", VA="0x1411AF8")]
		public <>c()
		{
		}

		[Address(RVA="0x1411B00", Offset="0x1411B00", VA="0x1411B00")]
		internal void <SetProfileIcon>b__3_1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C5DC", Offset="0x104C5DC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PinPageItemDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14115F0", Offset="0x14115F0", VA="0x14115F0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1411BBC", Offset="0x1411BBC", VA="0x1411BBC")]
		internal void <Initialize>b__0(PinPageItemDetailsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C5EC", Offset="0x104C5EC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public PinPageItemDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public UpdatePlayerProfileRequest request;

		[Address(RVA="0x1411A84", Offset="0x1411A84", VA="0x1411A84")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x14120F8", Offset="0x14120F8", VA="0x14120F8")]
		internal void <SetProfileIcon>b__0(UpdatePlayerProfileResponse response)
		{
		}

		[Address(RVA="0x14122C8", Offset="0x14122C8", VA="0x14122C8")]
		internal void <SetProfileIcon>b__2()
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly PinPageItemData Data;

		[Address(RVA="0x140BDD0", Offset="0x140BDD0", VA="0x140BDD0")]
		public Context(PinPageItemData data)
		{
		}
	}
}