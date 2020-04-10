using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;

public class InventoryItemBuyController : APopupController, IDispatchHandler<DInventoryItemBuyViewAction>, IDispatchHandler, IDispatchHandler<DUnitGearUsedByAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1059854", Offset="0x1059854")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1059864", Offset="0x1059864")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1059874", Offset="0x1059874")]
	[FieldOffset(Offset="0x48")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1059884", Offset="0x1059884")]
	[FieldOffset(Offset="0x50")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0x58")]
	private InventoryItemBuyController.Context _context;

	[FieldOffset(Offset="0x60")]
	private InventoryItemBuyView _view;

	[FieldOffset(Offset="0x68")]
	private InventoryItem _item;

	[Address(RVA="0x136CE44", Offset="0x136CE44", VA="0x136CE44")]
	public InventoryItemBuyController()
	{
	}

	[Address(RVA="0x136C930", Offset="0x136C930", VA="0x136C930")]
	private void BuyItem()
	{
	}

	[Address(RVA="0x136CAA8", Offset="0x136CAA8", VA="0x136CAA8")]
	private bool CheckShardShop()
	{
		return new bool();
	}

	[Address(RVA="0x136C740", Offset="0x136C740", VA="0x136C740", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x136C748", Offset="0x136C748", VA="0x136C748", Slot="14")]
	public void HandleDispatchAction(DInventoryItemBuyViewAction action)
	{
	}

	[Address(RVA="0x136C9DC", Offset="0x136C9DC", VA="0x136C9DC", Slot="15")]
	public void HandleDispatchAction(DUnitGearUsedByAction action)
	{
	}

	[Address(RVA="0x136C3A4", Offset="0x136C3A4", VA="0x136C3A4", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C22C", Offset="0x104C22C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public InventoryItemBuyController <>4__this;

		[FieldOffset(Offset="0x18")]
		public InventoryItem? item;

		[FieldOffset(Offset="0x30")]
		public InventoryItem? costItem;

		[FieldOffset(Offset="0x48")]
		public Action completed;

		[Address(RVA="0x136C738", Offset="0x136C738", VA="0x136C738")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x136CE4C", Offset="0x136CE4C", VA="0x136CE4C")]
		internal void <Initialize>b__0(InventoryItemBuyView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong ItemId;

		[FieldOffset(Offset="0x18")]
		public readonly ulong ItemCount;

		[FieldOffset(Offset="0x20")]
		public readonly ulong CostItemId;

		[FieldOffset(Offset="0x28")]
		public readonly ulong CostCount;

		[FieldOffset(Offset="0x30")]
		public readonly object BuyContext;

		[Address(RVA="0x136D608", Offset="0x136D608", VA="0x136D608")]
		public Context(ulong itemId, ulong itemCount, ulong costItemId, ulong costCount, object buyContext = // 
		// Current member / type: System.Void InventoryItemBuyController/Context::.ctor(System.UInt64,System.UInt64,System.UInt64,System.UInt64,System.Object)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.UInt64,System.UInt64,System.UInt64,System.UInt64,System.Object)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}
}