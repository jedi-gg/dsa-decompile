using Glunies;
using Il2CppDummyDll;
using System;

public class ProfanityFilter : AProfanityFilter, ILoggable<LogCategory>, IDispatchHandler<DGamedataDomainLoadedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105D5D8", Offset="0x105D5D8")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105D5E8", Offset="0x105D5E8")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	public LogCategory LogCategory
	{
		[Address(RVA="0x127E65C", Offset="0x127E65C", VA="0x127E65C", Slot="5")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x127EA38", Offset="0x127EA38", VA="0x127EA38")]
	public ProfanityFilter()
	{
	}

	[Address(RVA="0x127E6D4", Offset="0x127E6D4", VA="0x127E6D4", Slot="6")]
	public void HandleDispatchAction(DGamedataDomainLoadedAction action)
	{
	}

	[Address(RVA="0x127E664", Offset="0x127E664", VA="0x127E664")]
	public void Initialize()
	{
	}

	[Address(RVA="0x127E6D8", Offset="0x127E6D8", VA="0x127E6D8")]
	private void LoadWordLists()
	{
	}

	[Address(RVA="0x127E69C", Offset="0x127E69C", VA="0x127E69C")]
	public void Shutdown()
	{
	}
}