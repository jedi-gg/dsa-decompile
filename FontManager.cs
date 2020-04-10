using Glunies;
using Il2CppDummyDll;
using System;
using TMPro;

public class FontManager : ILoggable<LogCategory>, IAssetDependentLifecycleObject
{
	[FieldOffset(Offset="0x0")]
	private static FontManager s_instance;

	[Attribute(Name="InjectAttribute", RVA="0x105D478", Offset="0x105D478")]
	[FieldOffset(Offset="0x10")]
	private SingleAssetRegistry _fontMappingAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105D488", Offset="0x105D488")]
	[FieldOffset(Offset="0x18")]
	private SingleAssetRegistry _resourcesFontMappingAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105D498", Offset="0x105D498")]
	[FieldOffset(Offset="0x20")]
	private GameLanguageManager _gameLanguageManager;

	[FieldOffset(Offset="0x28")]
	private FontMapping _fontMapping;

	[FieldOffset(Offset="0x30")]
	private FontMapping _resourcesFontMapping;

	public static FontManager Instance
	{
		[Address(RVA="0x12CA588", Offset="0x12CA588", VA="0x12CA588")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x12CA5D8", Offset="0x12CA5D8", VA="0x12CA5D8", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12CA5E0", Offset="0x12CA5E0", VA="0x12CA5E0")]
	public FontManager()
	{
	}

	[Address(RVA="0x12CA8E4", Offset="0x12CA8E4", VA="0x12CA8E4")]
	public TMP_FontAsset GetPrimaryFontAsset()
	{
		return null;
	}

	[Address(RVA="0x12CA640", Offset="0x12CA640", VA="0x12CA640", Slot="5")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x12CA644", Offset="0x12CA644", VA="0x12CA644", Slot="7")]
	public void LoadAssets(Action loadAssetsFinished)
	{
	}

	[Address(RVA="0x12CA7E4", Offset="0x12CA7E4", VA="0x12CA7E4")]
	public void LoadResourceAssets(Action loadAssetsFinished)
	{
	}

	[Address(RVA="0x12CA7B0", Offset="0x12CA7B0", VA="0x12CA7B0", Slot="8")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x12CA734", Offset="0x12CA734", VA="0x12CA734", Slot="6")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE2C", Offset="0x104CE2C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public FontManager <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action loadAssetsFinished;

		[Address(RVA="0x12CA8D4", Offset="0x12CA8D4", VA="0x12CA8D4")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x12CAB28", Offset="0x12CAB28", VA="0x12CAB28")]
		internal void <LoadResourceAssets>b__0(AssetHandle handle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE3C", Offset="0x104CE3C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public FontManager <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action loadAssetsFinished;

		[Address(RVA="0x12CA8DC", Offset="0x12CA8DC", VA="0x12CA8DC")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x12CAC4C", Offset="0x12CAC4C", VA="0x12CAC4C")]
		internal void <LoadAssets>b__0(AssetHandle handle)
		{
		}
	}
}