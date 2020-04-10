using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct AppRatingData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public sbyte Battle
		{
			[Address(RVA="0xF09E4C", Offset="0xF09E4C", VA="0xF09E4C")]
			get
			{
				return new sbyte();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09E08", Offset="0xF09E08", VA="0xF09E08", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Campaign
		{
			[Address(RVA="0xF09E34", Offset="0xF09E34", VA="0xF09E34")]
			get
			{
				return new ulong();
			}
		}

		public string GooglePlayUrl
		{
			[Address(RVA="0xF09E54", Offset="0xF09E54", VA="0xF09E54")]
			get
			{
				return null;
			}
		}

		public sbyte Map
		{
			[Address(RVA="0xF09E3C", Offset="0xF09E3C", VA="0xF09E3C")]
			get
			{
				return new sbyte();
			}
		}

		public sbyte Node
		{
			[Address(RVA="0xF09E44", Offset="0xF09E44", VA="0xF09E44")]
			get
			{
				return new sbyte();
			}
		}

		[Address(RVA="0xF09E1C", Offset="0xF09E1C", VA="0xF09E1C")]
		public AppRatingData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new AppRatingData();
		}

		[Address(RVA="0xF09E10", Offset="0xF09E10", VA="0xF09E10", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EEAB4", Offset="0x15EEAB4", VA="0x15EEAB4")]
		public static void AddBattle(FlatBufferBuilder builder, sbyte battle)
		{
		}

		[Address(RVA="0x15EEA3C", Offset="0x15EEA3C", VA="0x15EEA3C")]
		public static void AddCampaign(FlatBufferBuilder builder, ulong campaign)
		{
		}

		[Address(RVA="0x15EEA78", Offset="0x15EEA78", VA="0x15EEA78")]
		public static void AddGooglePlayUrl(FlatBufferBuilder builder, StringOffset googlePlayUrlOffset)
		{
		}

		[Address(RVA="0x15EEB2C", Offset="0x15EEB2C", VA="0x15EEB2C")]
		public static void AddMap(FlatBufferBuilder builder, sbyte map)
		{
		}

		[Address(RVA="0x15EEAF0", Offset="0x15EEAF0", VA="0x15EEAF0")]
		public static void AddNode(FlatBufferBuilder builder, sbyte node)
		{
		}

		[Address(RVA="0x15EE99C", Offset="0x15EE99C", VA="0x15EE99C")]
		public static Offset<AppRatingData> CreateAppRatingData(FlatBufferBuilder builder, ulong campaign = 0L, sbyte map = 0, sbyte node = 0, sbyte battle = 0, StringOffset google_play_urlOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.AppRatingData> Gamedata.AppRatingData::CreateAppRatingData(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,System.SByte,System.SByte,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.AppRatingData> CreateAppRatingData(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,System.SByte,System.SByte,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EEB68", Offset="0x15EEB68", VA="0x15EEB68")]
		public static Offset<AppRatingData> EndAppRatingData(FlatBufferBuilder builder)
		{
			return new Offset<AppRatingData>();
		}

		[Address(RVA="0xF09E5C", Offset="0xF09E5C", VA="0xF09E5C")]
		public ArraySegment<byte>? GetGooglePlayUrlBytes()
		{
			return null;
		}

		[Address(RVA="0x15EE6CC", Offset="0x15EE6CC", VA="0x15EE6CC")]
		public static AppRatingData GetRootAsAppRatingData(FlatBuffers.ByteBuffer _bb)
		{
			return new AppRatingData();
		}

		[Address(RVA="0x15EE6D8", Offset="0x15EE6D8", VA="0x15EE6D8")]
		public static AppRatingData GetRootAsAppRatingData(FlatBuffers.ByteBuffer _bb, AppRatingData obj)
		{
			return new AppRatingData();
		}

		[Address(RVA="0x15EEBE8", Offset="0x15EEBE8", VA="0x15EEBE8")]
		public static void StartAppRatingData(FlatBufferBuilder builder)
		{
		}
	}
}