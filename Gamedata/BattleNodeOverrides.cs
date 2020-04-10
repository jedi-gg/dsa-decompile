using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleNodeOverrides : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A9C8", Offset="0xF0A9C8", VA="0xF0A9C8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int CampaignOverridesLength
		{
			[Address(RVA="0xF0AA54", Offset="0xF0AA54", VA="0xF0AA54")]
			get
			{
				return new int();
			}
		}

		public int ClubDungeonOverridesLength
		{
			[Address(RVA="0xF0AA64", Offset="0xF0AA64", VA="0xF0AA64")]
			get
			{
				return new int();
			}
		}

		public string DescriptionImage
		{
			[Address(RVA="0xF0AA34", Offset="0xF0AA34", VA="0xF0AA34")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF0AA1C", Offset="0xF0AA1C", VA="0xF0AA1C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A9F4", Offset="0xF0A9F4", VA="0xF0A9F4")]
			get
			{
				return new ulong();
			}
		}

		public OccasionRef? Occasion
		{
			[Address(RVA="0xF0A9FC", Offset="0xF0A9FC", VA="0xF0A9FC")]
			get
			{
				return null;
			}
		}

		public string TitleKey
		{
			[Address(RVA="0xF0AA04", Offset="0xF0AA04", VA="0xF0AA04")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0A9DC", Offset="0xF0A9DC", VA="0xF0A9DC")]
		public BattleNodeOverrides __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleNodeOverrides();
		}

		[Address(RVA="0xF0A9D0", Offset="0xF0A9D0", VA="0xF0A9D0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F50F8", Offset="0x15F50F8", VA="0x15F50F8")]
		public static void AddCampaignOverrides(FlatBufferBuilder builder, VectorOffset campaignOverridesOffset)
		{
		}

		[Address(RVA="0x15F50BC", Offset="0x15F50BC", VA="0x15F50BC")]
		public static void AddClubDungeonOverrides(FlatBufferBuilder builder, VectorOffset clubDungeonOverridesOffset)
		{
		}

		[Address(RVA="0x15F5134", Offset="0x15F5134", VA="0x15F5134")]
		public static void AddDescriptionImage(FlatBufferBuilder builder, StringOffset descriptionImageOffset)
		{
		}

		[Address(RVA="0x15F5170", Offset="0x15F5170", VA="0x15F5170")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x15F5080", Offset="0x15F5080", VA="0x15F5080")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F51E8", Offset="0x15F51E8", VA="0x15F51E8")]
		public static void AddOccasion(FlatBufferBuilder builder, Offset<OccasionRef> occasionOffset)
		{
		}

		[Address(RVA="0x15F51AC", Offset="0x15F51AC", VA="0x15F51AC")]
		public static void AddTitleKey(FlatBufferBuilder builder, StringOffset titleKeyOffset)
		{
		}

		[Address(RVA="0xF0AA4C", Offset="0xF0AA4C", VA="0xF0AA4C")]
		public BattleNodeOverride? CampaignOverrides(int j)
		{
			return null;
		}

		[Address(RVA="0xF0AA5C", Offset="0xF0AA5C", VA="0xF0AA5C")]
		public BattleNodeOverride? ClubDungeonOverrides(int j)
		{
			return null;
		}

		[Address(RVA="0x15F4FB8", Offset="0x15F4FB8", VA="0x15F4FB8")]
		public static Offset<BattleNodeOverrides> CreateBattleNodeOverrides(FlatBufferBuilder builder, ulong id = 0L, Offset<OccasionRef> occasionOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleNodeOverrides> Gamedata.BattleNodeOverrides::CreateBattleNodeOverrides(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.OccasionRef>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleNodeOverrides> CreateBattleNodeOverrides(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.OccasionRef>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F52D4", Offset="0x15F52D4", VA="0x15F52D4")]
		public static VectorOffset CreateCampaignOverridesVector(FlatBufferBuilder builder, Offset<BattleNodeOverride>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F5408", Offset="0x15F5408", VA="0x15F5408")]
		public static VectorOffset CreateClubDungeonOverridesVector(FlatBufferBuilder builder, Offset<BattleNodeOverride>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F5224", Offset="0x15F5224", VA="0x15F5224")]
		public static Offset<BattleNodeOverrides> EndBattleNodeOverrides(FlatBufferBuilder builder)
		{
			return new Offset<BattleNodeOverrides>();
		}

		[Address(RVA="0x15F553C", Offset="0x15F553C", VA="0x15F553C")]
		public static void FinishBattleNodeOverridesBuffer(FlatBufferBuilder builder, Offset<BattleNodeOverrides> offset)
		{
		}

		[Address(RVA="0xF0AA3C", Offset="0xF0AA3C", VA="0xF0AA3C")]
		public ArraySegment<byte>? GetDescriptionImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AA24", Offset="0xF0AA24", VA="0xF0AA24")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x15F4A90", Offset="0x15F4A90", VA="0x15F4A90")]
		public static BattleNodeOverrides GetRootAsBattleNodeOverrides(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleNodeOverrides();
		}

		[Address(RVA="0x15F4A9C", Offset="0x15F4A9C", VA="0x15F4A9C")]
		public static BattleNodeOverrides GetRootAsBattleNodeOverrides(FlatBuffers.ByteBuffer _bb, BattleNodeOverrides obj)
		{
			return new BattleNodeOverrides();
		}

		[Address(RVA="0xF0AA0C", Offset="0xF0AA0C", VA="0xF0AA0C")]
		public ArraySegment<byte>? GetTitleKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x15F52A4", Offset="0x15F52A4", VA="0x15F52A4")]
		public static void StartBattleNodeOverrides(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F53CC", Offset="0x15F53CC", VA="0x15F53CC")]
		public static void StartCampaignOverridesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x15F5500", Offset="0x15F5500", VA="0x15F5500")]
		public static void StartClubDungeonOverridesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}