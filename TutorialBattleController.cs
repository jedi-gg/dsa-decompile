using Glunies;
using Il2CppDummyDll;
using System;

public class TutorialBattleController : ILoggable<LogCategory>, IDispatchHandler<DTitleViewAction>, IDispatchHandler
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10545D0", Offset="0x10545D0")]
	[FieldOffset(Offset="0x10")]
	private bool <TitleWasDismissed>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x10545E0", Offset="0x10545E0")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x10545F0", Offset="0x10545F0")]
	[FieldOffset(Offset="0x20")]
	private BattleViewController _battleViewController;

	public LogCategory LogCategory
	{
		[Address(RVA="0x143C1E0", Offset="0x143C1E0", VA="0x143C1E0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public bool TitleWasDismissed
	{
		[Address(RVA="0x143C1E8", Offset="0x143C1E8", VA="0x143C1E8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E778", Offset="0x106E778")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x143C1F0", Offset="0x143C1F0", VA="0x143C1F0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E788", Offset="0x106E788")]
		private set
		{
		}
	}

	[Address(RVA="0x143C2B4", Offset="0x143C2B4", VA="0x143C2B4")]
	public TutorialBattleController()
	{
	}

	[Address(RVA="0x143C26C", Offset="0x143C26C", VA="0x143C26C", Slot="5")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x143C1FC", Offset="0x143C1FC", VA="0x143C1FC")]
	public void Initialize()
	{
	}

	[Address(RVA="0x143C234", Offset="0x143C234", VA="0x143C234")]
	public void Shutdown()
	{
	}
}