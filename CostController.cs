using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.Events;

public class CostController : IAssetDependentLifecycleObject
{
	[Attribute(Name="InjectAttribute", RVA="0x105DBD0", Offset="0x105DBD0")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105DBE0", Offset="0x105DBE0")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105DBF0", Offset="0x105DBF0")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105DC00", Offset="0x105DC00")]
	[FieldOffset(Offset="0x28")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105DC10", Offset="0x105DC10")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Address(RVA="0x154DCA4", Offset="0x154DCA4", VA="0x154DCA4")]
	public CostController()
	{
	}

	[Address(RVA="0x154D9E8", Offset="0x154D9E8", VA="0x154D9E8")]
	private string GetInsufficientCurrencyMessage(ulong costItemId)
	{
		return null;
	}

	[Address(RVA="0x154D610", Offset="0x154D610", VA="0x154D610")]
	private void HandleButtonClick(CostButton button, UnityAction clickAction, UnityAction insufficientFundsShown)
	{
	}

	[Address(RVA="0x154CCE8", Offset="0x154CCE8", VA="0x154CCE8", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x154CDB8", Offset="0x154CDB8", VA="0x154CDB8", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x154D6B4", Offset="0x154D6B4", VA="0x154D6B4")]
	private bool PromptForEnergyRefresh(ulong costItemId)
	{
		return new bool();
	}

	[Address(RVA="0x154CE80", Offset="0x154CE80", VA="0x154CE80")]
	public void Register(CostButton costButton, UnityAction clickAction, UnityAction insufficientFundsShown = // 
	// Current member / type: System.Void CostController::Register(CostButton,UnityEngine.Events.UnityAction,UnityEngine.Events.UnityAction)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Register(CostButton,UnityEngine.Events.UnityAction,UnityEngine.Events.UnityAction)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x154CDBC", Offset="0x154CDBC", VA="0x154CDBC", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x154CDC0", Offset="0x154CDC0", VA="0x154CDC0")]
	private void ReleaseDialogManagerAssets()
	{
	}

	[Address(RVA="0x154D1E4", Offset="0x154D1E4", VA="0x154D1E4")]
	public bool ShowInsufficientEntryCost(BattleNode? battleNode, uint numBattles)
	{
		return new bool();
	}

	[Address(RVA="0x154D578", Offset="0x154D578", VA="0x154D578")]
	public bool ShowInsufficientEntryCost(DCampaignAddress campaignAddress, uint numBattles)
	{
		return new bool();
	}

	[Address(RVA="0x154D2B8", Offset="0x154D2B8", VA="0x154D2B8")]
	private bool ShowInsufficientFundsMessage(ulong costItemId, ulong costAmount)
	{
		return new bool();
	}

	[Address(RVA="0x154CD58", Offset="0x154CD58", VA="0x154CD58", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x154CE20", Offset="0x154CE20", VA="0x154CE20")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x154D138", Offset="0x154D138", VA="0x154D138")]
	public void Unregister(CostButton costButton)
	{
	}

	[Address(RVA="0x154DB14", Offset="0x154DB14", VA="0x154DB14")]
	private void Upsell(ulong itemId)
	{
	}

	[Address(RVA="0x154D844", Offset="0x154D844", VA="0x154D844")]
	private void UpsellEnergy(ulong itemId)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF4C", Offset="0x104CF4C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public CostController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong costItemId;

		[Address(RVA="0x154D6AC", Offset="0x154D6AC", VA="0x154D6AC")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x154DCAC", Offset="0x154DCAC", VA="0x154DCAC")]
		internal void <ShowInsufficientFundsMessage>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF5C", Offset="0x104CF5C")]
	private sealed class <>c__DisplayClass10_1
	{
		[FieldOffset(Offset="0x10")]
		public InventoryItem? costItem;

		[FieldOffset(Offset="0x28")]
		public CostController.<>c__DisplayClass10_0 CS$<>8__locals1;

		[Address(RVA="0x154DFA0", Offset="0x154DFA0", VA="0x154DFA0")]
		public <>c__DisplayClass10_1()
		{
		}

		[Address(RVA="0x154DFA8", Offset="0x154DFA8", VA="0x154DFA8")]
		internal void <ShowInsufficientFundsMessage>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF3C", Offset="0x104CF3C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public CostController <>4__this;

		[FieldOffset(Offset="0x18")]
		public CostButton costButton;

		[FieldOffset(Offset="0x20")]
		public UnityAction clickAction;

		[FieldOffset(Offset="0x28")]
		public UnityAction insufficientFundsShown;

		[Address(RVA="0x154D130", Offset="0x154D130", VA="0x154D130")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x154E0BC", Offset="0x154E0BC", VA="0x154E0BC")]
		internal void <Register>b__0()
		{
		}
	}
}