using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class PlayerActivityChooseRewardController : APopupController, IDispatchHandler<DPlayerActivityChooseRewardAction>, IDispatchHandler, IDispatchHandler<DPlayerActivityClaimedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105B684", Offset="0x105B684")]
	[FieldOffset(Offset="0x38")]
	private AssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x40")]
	private PlayerActivityChooseRewardController.Context _context;

	[FieldOffset(Offset="0x48")]
	private PlayerActivityChooseRewardView _view;

	[FieldOffset(Offset="0x50")]
	private List<PlayerActivityChooseRewardController.Option> _options;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x1414160", Offset="0x1414160", VA="0x1414160", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14149A8", Offset="0x14149A8", VA="0x14149A8")]
	public PlayerActivityChooseRewardController()
	{
	}

	[Address(RVA="0x141439C", Offset="0x141439C", VA="0x141439C", Slot="14")]
	public void HandleDispatchAction(DPlayerActivityChooseRewardAction action)
	{
	}

	[Address(RVA="0x14144D0", Offset="0x14144D0", VA="0x14144D0", Slot="15")]
	public void HandleDispatchAction(DPlayerActivityClaimedAction action)
	{
	}

	[Address(RVA="0x1414168", Offset="0x1414168", VA="0x1414168", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x14145D0", Offset="0x14145D0", VA="0x14145D0")]
	private void LoadOptions(Action finished)
	{
	}

	[Address(RVA="0x1414360", Offset="0x1414360", VA="0x1414360", Slot="9")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C6FC", Offset="0x104C6FC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PlayerActivityChooseRewardController.<>c <>9;

		[Address(RVA="0x14149B0", Offset="0x14149B0", VA="0x14149B0")]
		static <>c()
		{
		}

		[Address(RVA="0x1414A14", Offset="0x1414A14", VA="0x1414A14")]
		public <>c()
		{
		}

		[Address(RVA="0x1414A1C", Offset="0x1414A1C", VA="0x1414A1C")]
		internal int <LoadOptions>g__InsertionSortOption|6_0(PlayerActivityChooseRewardController.Option x, PlayerActivityChooseRewardController.Option y)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C6AC", Offset="0x104C6AC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerActivityChooseRewardController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1414358", Offset="0x1414358", VA="0x1414358")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1414A78", Offset="0x1414A78", VA="0x1414A78")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x1414B6C", Offset="0x1414B6C", VA="0x1414B6C")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C6BC", Offset="0x104C6BC")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public PlayerActivityChooseRewardController.<>c__DisplayClass2_0 CS$<>8__locals1;

		[Address(RVA="0x1414B64", Offset="0x1414B64", VA="0x1414B64")]
		public <>c__DisplayClass2_1()
		{
		}

		[Address(RVA="0x1414C24", Offset="0x1414C24", VA="0x1414C24")]
		internal void <Initialize>b__2(PlayerActivityChooseRewardView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C6CC", Offset="0x104C6CC")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerActivityRewardChoice rewardChoice;

		[FieldOffset(Offset="0x18")]
		public PlayerActivityChooseRewardController <>4__this;

		[Address(RVA="0x1414998", Offset="0x1414998", VA="0x1414998")]
		public <>c__DisplayClass6_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C6DC", Offset="0x104C6DC")]
	private sealed class <>c__DisplayClass6_1
	{
		[FieldOffset(Offset="0x10")]
		public int boundIndex;

		[FieldOffset(Offset="0x18")]
		public PlayerActivityChooseRewardController.<>c__DisplayClass6_0 CS$<>8__locals1;

		[Address(RVA="0x14149A0", Offset="0x14149A0", VA="0x14149A0")]
		public <>c__DisplayClass6_1()
		{
		}

		[Address(RVA="0x1414C8C", Offset="0x1414C8C", VA="0x1414C8C")]
		internal void <LoadOptions>b__1(Action assetFinished)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C6EC", Offset="0x104C6EC")]
	private sealed class <>c__DisplayClass6_2
	{
		[FieldOffset(Offset="0x10")]
		public Action assetFinished;

		[FieldOffset(Offset="0x18")]
		public PlayerActivityChooseRewardController.<>c__DisplayClass6_1 CS$<>8__locals2;

		[Address(RVA="0x1414DC8", Offset="0x1414DC8", VA="0x1414DC8")]
		public <>c__DisplayClass6_2()
		{
		}

		[Address(RVA="0x1414DD0", Offset="0x1414DD0", VA="0x1414DD0")]
		internal void <LoadOptions>b__2(AssetHandle assetHandle)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly PlayerActivity PlayerActivity;

		[FieldOffset(Offset="0x18")]
		public int? SelectedIndex;

		[Address(RVA="0x132BDA0", Offset="0x132BDA0", VA="0x132BDA0")]
		public Context(PlayerActivity playerActivity, int? selectedIndex = // 
		// Current member / type: System.Void PlayerActivityChooseRewardController/Context::.ctor(Serverproto.PlayerActivity,System.Nullable`1<System.Int32>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Serverproto.PlayerActivity,System.Nullable<System.Int32>)
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

	public class Option
	{
		[FieldOffset(Offset="0x10")]
		public readonly PlayerActivityChooseRewardOption Instance;

		[FieldOffset(Offset="0x18")]
		public readonly int Index;

		[Address(RVA="0x132BDD8", Offset="0x132BDD8", VA="0x132BDD8")]
		public Option(PlayerActivityChooseRewardOption instance, int index)
		{
		}
	}
}