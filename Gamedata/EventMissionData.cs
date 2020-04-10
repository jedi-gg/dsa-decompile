using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct EventMissionData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BannerImage
		{
			[Address(RVA="0xF5A2A4", Offset="0xF5A2A4", VA="0xF5A2A4")]
			get
			{
				return null;
			}
		}

		public string BannerText
		{
			[Address(RVA="0xF5A2BC", Offset="0xF5A2BC", VA="0xF5A2BC")]
			get
			{
				return null;
			}
		}

		public uint BattleCooldownSeconds
		{
			[Address(RVA="0xF5A26C", Offset="0xF5A26C", VA="0xF5A26C")]
			get
			{
				return new uint();
			}
		}

		public uint BattleLimit
		{
			[Address(RVA="0xF5A24C", Offset="0xF5A24C", VA="0xF5A24C")]
			get
			{
				return new uint();
			}
		}

		public int BattleLimitRefreshCostLength
		{
			[Address(RVA="0xF5A25C", Offset="0xF5A25C", VA="0xF5A25C")]
			get
			{
				return new int();
			}
		}

		public uint BattleLimitResetFrequencySeconds
		{
			[Address(RVA="0xF5A264", Offset="0xF5A264", VA="0xF5A264")]
			get
			{
				return new uint();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A1D0", Offset="0xF5A1D0", VA="0xF5A1D0", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Description
		{
			[Address(RVA="0xF5A214", Offset="0xF5A214", VA="0xF5A214")]
			get
			{
				return null;
			}
		}

		public string Image
		{
			[Address(RVA="0xF5A22C", Offset="0xF5A22C", VA="0xF5A22C")]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[Address(RVA="0xF5A1FC", Offset="0xF5A1FC", VA="0xF5A1FC")]
			get
			{
				return null;
			}
		}

		public string PreviewText
		{
			[Address(RVA="0xF5A284", Offset="0xF5A284", VA="0xF5A284")]
			get
			{
				return null;
			}
		}

		public bool RequirePreviousTierCompletion
		{
			[Address(RVA="0xF5A29C", Offset="0xF5A29C", VA="0xF5A29C")]
			get
			{
				return new bool();
			}
		}

		public int ShowcaseItemsLength
		{
			[Address(RVA="0xF5A2DC", Offset="0xF5A2DC", VA="0xF5A2DC")]
			get
			{
				return new int();
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF5A244", Offset="0xF5A244", VA="0xF5A244")]
			get
			{
				return new int();
			}
		}

		public int TiersLength
		{
			[Address(RVA="0xF5A27C", Offset="0xF5A27C", VA="0xF5A27C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5A1E4", Offset="0xF5A1E4", VA="0xF5A1E4")]
		public EventMissionData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new EventMissionData();
		}

		[Address(RVA="0xF5A1D8", Offset="0xF5A1D8", VA="0xF5A1D8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25122B4", Offset="0x25122B4", VA="0x25122B4")]
		public static void AddBannerImage(FlatBufferBuilder builder, StringOffset bannerImageOffset)
		{
		}

		[Address(RVA="0x2512278", Offset="0x2512278", VA="0x2512278")]
		public static void AddBannerText(FlatBufferBuilder builder, StringOffset bannerTextOffset)
		{
		}

		[Address(RVA="0x2512368", Offset="0x2512368", VA="0x2512368")]
		public static void AddBattleCooldownSeconds(FlatBufferBuilder builder, uint battleCooldownSeconds)
		{
		}

		[Address(RVA="0x251241C", Offset="0x251241C", VA="0x251241C")]
		public static void AddBattleLimit(FlatBufferBuilder builder, uint battleLimit)
		{
		}

		[Address(RVA="0x25123E0", Offset="0x25123E0", VA="0x25123E0")]
		public static void AddBattleLimitRefreshCost(FlatBufferBuilder builder, VectorOffset battleLimitRefreshCostOffset)
		{
		}

		[Address(RVA="0x25123A4", Offset="0x25123A4", VA="0x25123A4")]
		public static void AddBattleLimitResetFrequencySeconds(FlatBufferBuilder builder, uint battleLimitResetFrequencySeconds)
		{
		}

		[Address(RVA="0x25124D0", Offset="0x25124D0", VA="0x25124D0")]
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
		}

		[Address(RVA="0x2512494", Offset="0x2512494", VA="0x2512494")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x251250C", Offset="0x251250C", VA="0x251250C")]
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
		}

		[Address(RVA="0x25122F0", Offset="0x25122F0", VA="0x25122F0")]
		public static void AddPreviewText(FlatBufferBuilder builder, StringOffset previewTextOffset)
		{
		}

		[Address(RVA="0x2512548", Offset="0x2512548", VA="0x2512548")]
		public static void AddRequirePreviousTierCompletion(FlatBufferBuilder builder, bool requirePreviousTierCompletion)
		{
		}

		[Address(RVA="0x251223C", Offset="0x251223C", VA="0x251223C")]
		public static void AddShowcaseItems(FlatBufferBuilder builder, VectorOffset showcaseItemsOffset)
		{
		}

		[Address(RVA="0x2512458", Offset="0x2512458", VA="0x2512458")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x251232C", Offset="0x251232C", VA="0x251232C")]
		public static void AddTiers(FlatBufferBuilder builder, VectorOffset tiersOffset)
		{
		}

		[Address(RVA="0xF5A254", Offset="0xF5A254", VA="0xF5A254")]
		public ItemCount? BattleLimitRefreshCost(int j)
		{
			return null;
		}

		[Address(RVA="0x2512634", Offset="0x2512634", VA="0x2512634")]
		public static VectorOffset CreateBattleLimitRefreshCostVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x25120EC", Offset="0x25120EC", VA="0x25120EC")]
		public static Offset<EventMissionData> CreateEventMissionData(FlatBufferBuilder builder, StringOffset nameOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.EventMissionData> Gamedata.EventMissionData::CreateEventMissionData(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,System.UInt32,FlatBuffers.VectorOffset,System.UInt32,System.UInt32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.EventMissionData> CreateEventMissionData(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,System.UInt32,FlatBuffers.VectorOffset,System.UInt32,System.UInt32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x251289C", Offset="0x251289C", VA="0x251289C")]
		public static VectorOffset CreateShowcaseItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2512768", Offset="0x2512768", VA="0x2512768")]
		public static VectorOffset CreateTiersVector(FlatBufferBuilder builder, Offset<BattleNode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2512584", Offset="0x2512584", VA="0x2512584")]
		public static Offset<EventMissionData> EndEventMissionData(FlatBufferBuilder builder)
		{
			return new Offset<EventMissionData>();
		}

		[Address(RVA="0xF5A2AC", Offset="0xF5A2AC", VA="0xF5A2AC")]
		public ArraySegment<byte>? GetBannerImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A2C4", Offset="0xF5A2C4", VA="0xF5A2C4")]
		public ArraySegment<byte>? GetBannerTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A21C", Offset="0xF5A21C", VA="0xF5A21C")]
		public ArraySegment<byte>? GetDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A234", Offset="0xF5A234", VA="0xF5A234")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A204", Offset="0xF5A204", VA="0xF5A204")]
		public ArraySegment<byte>? GetNameBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A28C", Offset="0xF5A28C", VA="0xF5A28C")]
		public ArraySegment<byte>? GetPreviewTextBytes()
		{
			return null;
		}

		[Address(RVA="0x2511914", Offset="0x2511914", VA="0x2511914")]
		public static EventMissionData GetRootAsEventMissionData(FlatBuffers.ByteBuffer _bb)
		{
			return new EventMissionData();
		}

		[Address(RVA="0x2511920", Offset="0x2511920", VA="0x2511920")]
		public static EventMissionData GetRootAsEventMissionData(FlatBuffers.ByteBuffer _bb, EventMissionData obj)
		{
			return new EventMissionData();
		}

		[Address(RVA="0xF5A2E4", Offset="0xF5A2E4", VA="0xF5A2E4")]
		public ArraySegment<byte>? GetShowcaseItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A2D4", Offset="0xF5A2D4", VA="0xF5A2D4")]
		public ulong ShowcaseItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x251272C", Offset="0x251272C", VA="0x251272C")]
		public static void StartBattleLimitRefreshCostVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2512604", Offset="0x2512604", VA="0x2512604")]
		public static void StartEventMissionData(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2512994", Offset="0x2512994", VA="0x2512994")]
		public static void StartShowcaseItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2512860", Offset="0x2512860", VA="0x2512860")]
		public static void StartTiersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF5A274", Offset="0xF5A274", VA="0xF5A274")]
		public BattleNode? Tiers(int j)
		{
			return null;
		}
	}
}