using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class ClubDungeonMapListItem : WrappedScrollRectListItem, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x28")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _mapAssetRegistry;

	[FieldOffset(Offset="0x38")]
	private ClubDungeonMapWidget _mapWidget;

	public LogCategory LogCategory
	{
		[Address(RVA="0x11B1578", Offset="0x11B1578", VA="0x11B1578", Slot="7")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x11B1A50", Offset="0x11B1A50", VA="0x11B1A50")]
	public ClubDungeonMapListItem()
	{
	}

	[Address(RVA="0x11B1580", Offset="0x11B1580", VA="0x11B1580")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11B1670", Offset="0x11B1670", VA="0x11B1670")]
	public void SetMap(Camera worldCamera, DClubDungeonNodeVisuals nodeVisuals, ClubDungeonContext dungeonContext, Action finished = // 
	// Current member / type: System.Void ClubDungeonMapListItem::SetMap(UnityEngine.Camera,DClubDungeonNodeVisuals,ClubDungeonContext,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SetMap(UnityEngine.Camera,DClubDungeonNodeVisuals,ClubDungeonContext,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x11B15C0", Offset="0x11B15C0", VA="0x11B15C0", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11B18E8", Offset="0x11B18E8", VA="0x11B18E8")]
	private void Update()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B8FC", Offset="0x104B8FC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public int mapIndex;

		[FieldOffset(Offset="0x18")]
		public ClubDungeonMapListItem <>4__this;

		[FieldOffset(Offset="0x20")]
		public Camera worldCamera;

		[FieldOffset(Offset="0x28")]
		public DClubDungeonNodeVisuals nodeVisuals;

		[FieldOffset(Offset="0x58")]
		public ClubDungeonContext dungeonContext;

		[FieldOffset(Offset="0x60")]
		public ClubDungeonMap map;

		[FieldOffset(Offset="0x68")]
		public Action finished;

		[Address(RVA="0x11B18E0", Offset="0x11B18E0", VA="0x11B18E0")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x11B1A58", Offset="0x11B1A58", VA="0x11B1A58")]
		internal void <SetMap>b__0(AssetHandle handle)
		{
		}
	}
}