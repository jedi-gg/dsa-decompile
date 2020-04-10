using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

public class PassportSeasonGameState : AGameState, IDispatchHandler<DTabViewIndexSelectedAction>, IDispatchHandler, IDispatchHandler<DPassportSeasonControllerInitialized>
{
	[Attribute(Name="InjectAttribute", RVA="0x105AD2C", Offset="0x105AD2C")]
	[FieldOffset(Offset="0x30")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x105AD3C", Offset="0x105AD3C")]
	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105AD4C", Offset="0x105AD4C")]
	[FieldOffset(Offset="0x40")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x105AD5C", Offset="0x105AD5C")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x50")]
	private PassportSeasonTabViewController _tabViewController;

	[FieldOffset(Offset="0x58")]
	private bool _dispatchedVgpAction;

	[Address(RVA="0x13FC1AC", Offset="0x13FC1AC", VA="0x13FC1AC")]
	public PassportSeasonGameState()
	{
	}

	[Address(RVA="0x13FB7B0", Offset="0x13FB7B0", VA="0x13FB7B0", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x13FBDCC", Offset="0x13FBDCC", VA="0x13FBDCC", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x13FBEA4", Offset="0x13FBEA4", VA="0x13FBEA4", Slot="12")]
	public void HandleDispatchAction(DTabViewIndexSelectedAction action)
	{
	}

	[Address(RVA="0x13FC104", Offset="0x13FC104", VA="0x13FC104", Slot="13")]
	public void HandleDispatchAction(DPassportSeasonControllerInitialized action)
	{
	}

	[Address(RVA="0x13FBF48", Offset="0x13FBF48", VA="0x13FBF48")]
	private void LoadTab(PassportSeasonGameState.Tab tab, PassportSeasonGameState.AContext context = // 
	// Current member / type: System.Void PassportSeasonGameState::LoadTab(PassportSeasonGameState/Tab,PassportSeasonGameState/AContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void LoadTab(PassportSeasonGameState/Tab,PassportSeasonGameState/AContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x13FBD0C", Offset="0x13FBD0C", VA="0x13FBD0C")]
	private void ShowHud()
	{
	}

	[Address(RVA="0x13FBE54", Offset="0x13FBE54", VA="0x13FBE54", Slot="11")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C4DC", Offset="0x104C4DC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonGameState.AContext gameStateContext;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonGameState <>4__this;

		[Address(RVA="0x13FBDC4", Offset="0x13FBDC4", VA="0x13FBDC4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x13FC1B4", Offset="0x13FC1B4", VA="0x13FC1B4")]
		internal void <Entering>b__0()
		{
		}
	}

	public abstract class AContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public ulong RewardIdHighlight;

		public abstract PassportSeasonGameState.Tab Tab
		{
			get;
		}

		[Address(RVA="0x13FC218", Offset="0x13FC218", VA="0x13FC218")]
		protected AContext()
		{
		}
	}

	public class ActivitiesContext : PassportSeasonGameState.AContext
	{
		[FieldOffset(Offset="0x28")]
		public ulong SelectedActivityId;

		public override PassportSeasonGameState.Tab Tab
		{
			[Address(RVA="0x13FC220", Offset="0x13FC220", VA="0x13FC220", Slot="4")]
			get
			{
				return new PassportSeasonGameState.Tab();
			}
		}

		[Address(RVA="0x13FC228", Offset="0x13FC228", VA="0x13FC228")]
		public ActivitiesContext()
		{
		}

		[Address(RVA="0x13FC230", Offset="0x13FC230", VA="0x13FC230")]
		public ActivitiesContext(ulong selectedActivityId)
		{
		}
	}

	public class LevelsContext : PassportSeasonGameState.AContext
	{
		public override PassportSeasonGameState.Tab Tab
		{
			[Address(RVA="0x13FC25C", Offset="0x13FC25C", VA="0x13FC25C", Slot="4")]
			get
			{
				return new PassportSeasonGameState.Tab();
			}
		}

		[Address(RVA="0x13FC264", Offset="0x13FC264", VA="0x13FC264")]
		public LevelsContext()
		{
		}
	}

	public enum Tab
	{
		[FieldOffset(Offset="0x0")]
		Levels,
		[FieldOffset(Offset="0x0")]
		Activities
	}
}