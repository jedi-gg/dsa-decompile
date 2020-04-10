using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PassportSeason : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string ActivityBannerImage
		{
			[Address(RVA="0xF570F4", Offset="0xF570F4", VA="0xF570F4")]
			get
			{
				return null;
			}
		}

		public uint BeginTimestamp
		{
			[Address(RVA="0xF57064", Offset="0xF57064", VA="0xF57064")]
			get
			{
				return new uint();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56FF0", Offset="0xF56FF0", VA="0xF56FF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public PassportSeasonCallToAction? CallToAction
		{
			[Address(RVA="0xF57094", Offset="0xF57094", VA="0xF57094")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF5703C", Offset="0xF5703C", VA="0xF5703C")]
			get
			{
				return null;
			}
		}

		public uint EndTimestamp
		{
			[Address(RVA="0xF570E4", Offset="0xF570E4", VA="0xF570E4")]
			get
			{
				return new uint();
			}
		}

		public string HomeShowcaseImage
		{
			[Address(RVA="0xF5711C", Offset="0xF5711C", VA="0xF5711C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5701C", Offset="0xF5701C", VA="0xF5701C")]
			get
			{
				return new ulong();
			}
		}

		public string InactiveSeasonBg
		{
			[Address(RVA="0xF5709C", Offset="0xF5709C", VA="0xF5709C")]
			get
			{
				return null;
			}
		}

		public string InactiveSeasonDesc
		{
			[Address(RVA="0xF570CC", Offset="0xF570CC", VA="0xF570CC")]
			get
			{
				return null;
			}
		}

		public string InactiveSeasonHeading
		{
			[Address(RVA="0xF570B4", Offset="0xF570B4", VA="0xF570B4")]
			get
			{
				return null;
			}
		}

		public int LevelRewardsLength
		{
			[Address(RVA="0xF57114", Offset="0xF57114", VA="0xF57114")]
			get
			{
				return new int();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF57024", Offset="0xF57024", VA="0xF57024")]
			get
			{
				return null;
			}
		}

		public Gamedata.OccasionRef? OccasionRef
		{
			[Address(RVA="0xF570EC", Offset="0xF570EC", VA="0xF570EC")]
			get
			{
				return null;
			}
		}

		public ulong PassportItem
		{
			[Address(RVA="0xF57054", Offset="0xF57054", VA="0xF57054")]
			get
			{
				return new ulong();
			}
		}

		public string PreviewImage
		{
			[Address(RVA="0xF5706C", Offset="0xF5706C", VA="0xF5706C")]
			get
			{
				return null;
			}
		}

		public int WeeksLength
		{
			[Address(RVA="0xF5708C", Offset="0xF5708C", VA="0xF5708C")]
			get
			{
				return new int();
			}
		}

		public ulong XpItem
		{
			[Address(RVA="0xF5705C", Offset="0xF5705C", VA="0xF5705C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF57004", Offset="0xF57004", VA="0xF57004")]
		public PassportSeason __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeason();
		}

		[Address(RVA="0xF56FF8", Offset="0xF56FF8", VA="0xF56FF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D9100", Offset="0x24D9100", VA="0x24D9100")]
		public static void AddActivityBannerImage(FlatBufferBuilder builder, StringOffset activityBannerImageOffset)
		{
		}

		[Address(RVA="0x24D931C", Offset="0x24D931C", VA="0x24D931C")]
		public static void AddBeginTimestamp(FlatBufferBuilder builder, uint beginTimestamp)
		{
		}

		[Address(RVA="0x24D9268", Offset="0x24D9268", VA="0x24D9268")]
		public static void AddCallToAction(FlatBufferBuilder builder, Offset<PassportSeasonCallToAction> callToActionOffset)
		{
		}

		[Address(RVA="0x24D9358", Offset="0x24D9358", VA="0x24D9358")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x24D9178", Offset="0x24D9178", VA="0x24D9178")]
		public static void AddEndTimestamp(FlatBufferBuilder builder, uint endTimestamp)
		{
		}

		[Address(RVA="0x24D9088", Offset="0x24D9088", VA="0x24D9088")]
		public static void AddHomeShowcaseImage(FlatBufferBuilder builder, StringOffset homeShowcaseImageOffset)
		{
		}

		[Address(RVA="0x24D904C", Offset="0x24D904C", VA="0x24D904C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24D922C", Offset="0x24D922C", VA="0x24D922C")]
		public static void AddInactiveSeasonBg(FlatBufferBuilder builder, StringOffset inactiveSeasonBgOffset)
		{
		}

		[Address(RVA="0x24D91B4", Offset="0x24D91B4", VA="0x24D91B4")]
		public static void AddInactiveSeasonDesc(FlatBufferBuilder builder, StringOffset inactiveSeasonDescOffset)
		{
		}

		[Address(RVA="0x24D91F0", Offset="0x24D91F0", VA="0x24D91F0")]
		public static void AddInactiveSeasonHeading(FlatBufferBuilder builder, StringOffset inactiveSeasonHeadingOffset)
		{
		}

		[Address(RVA="0x24D90C4", Offset="0x24D90C4", VA="0x24D90C4")]
		public static void AddLevelRewards(FlatBufferBuilder builder, VectorOffset levelRewardsOffset)
		{
		}

		[Address(RVA="0x24D9394", Offset="0x24D9394", VA="0x24D9394")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24D913C", Offset="0x24D913C", VA="0x24D913C")]
		public static void AddOccasionRef(FlatBufferBuilder builder, Offset<Gamedata.OccasionRef> occasionRefOffset)
		{
		}

		[Address(RVA="0x24D9010", Offset="0x24D9010", VA="0x24D9010")]
		public static void AddPassportItem(FlatBufferBuilder builder, ulong passportItem)
		{
		}

		[Address(RVA="0x24D92E0", Offset="0x24D92E0", VA="0x24D92E0")]
		public static void AddPreviewImage(FlatBufferBuilder builder, StringOffset previewImageOffset)
		{
		}

		[Address(RVA="0x24D92A4", Offset="0x24D92A4", VA="0x24D92A4")]
		public static void AddWeeks(FlatBufferBuilder builder, VectorOffset weeksOffset)
		{
		}

		[Address(RVA="0x24D8FD4", Offset="0x24D8FD4", VA="0x24D8FD4")]
		public static void AddXpItem(FlatBufferBuilder builder, ulong xpItem)
		{
		}

		[Address(RVA="0x24D95B4", Offset="0x24D95B4", VA="0x24D95B4")]
		public static VectorOffset CreateLevelRewardsVector(FlatBufferBuilder builder, Offset<PassportSeasonLevelRewards>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D8E40", Offset="0x24D8E40", VA="0x24D8E40")]
		public static Offset<PassportSeason> CreatePassportSeason(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PassportSeason> Gamedata.PassportSeason::CreatePassportSeason(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,System.UInt64,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.Offset`1<Gamedata.PassportSeasonCallToAction>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt32,FlatBuffers.Offset`1<Gamedata.OccasionRef>,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PassportSeason> CreatePassportSeason(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,System.UInt64,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.Offset<Gamedata.PassportSeasonCallToAction>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt32,FlatBuffers.Offset<Gamedata.OccasionRef>,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D9480", Offset="0x24D9480", VA="0x24D9480")]
		public static VectorOffset CreateWeeksVector(FlatBufferBuilder builder, Offset<PassportSeasonWeek>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D93D0", Offset="0x24D93D0", VA="0x24D93D0")]
		public static Offset<PassportSeason> EndPassportSeason(FlatBufferBuilder builder)
		{
			return new Offset<PassportSeason>();
		}

		[Address(RVA="0x24D96E8", Offset="0x24D96E8", VA="0x24D96E8")]
		public static void FinishPassportSeasonBuffer(FlatBufferBuilder builder, Offset<PassportSeason> offset)
		{
		}

		[Address(RVA="0xF570FC", Offset="0xF570FC", VA="0xF570FC")]
		public ArraySegment<byte>? GetActivityBannerImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF57044", Offset="0xF57044", VA="0xF57044")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF57124", Offset="0xF57124", VA="0xF57124")]
		public ArraySegment<byte>? GetHomeShowcaseImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF570A4", Offset="0xF570A4", VA="0xF570A4")]
		public ArraySegment<byte>? GetInactiveSeasonBgBytes()
		{
			return null;
		}

		[Address(RVA="0xF570D4", Offset="0xF570D4", VA="0xF570D4")]
		public ArraySegment<byte>? GetInactiveSeasonDescBytes()
		{
			return null;
		}

		[Address(RVA="0xF570BC", Offset="0xF570BC", VA="0xF570BC")]
		public ArraySegment<byte>? GetInactiveSeasonHeadingBytes()
		{
			return null;
		}

		[Address(RVA="0xF5702C", Offset="0xF5702C", VA="0xF5702C")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF57074", Offset="0xF57074", VA="0xF57074")]
		public ArraySegment<byte>? GetPreviewImageBytes()
		{
			return null;
		}

		[Address(RVA="0x24D84E8", Offset="0x24D84E8", VA="0x24D84E8")]
		public static PassportSeason GetRootAsPassportSeason(FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeason();
		}

		[Address(RVA="0x24D84F4", Offset="0x24D84F4", VA="0x24D84F4")]
		public static PassportSeason GetRootAsPassportSeason(FlatBuffers.ByteBuffer _bb, PassportSeason obj)
		{
			return new PassportSeason();
		}

		[Address(RVA="0xF5710C", Offset="0xF5710C", VA="0xF5710C")]
		public PassportSeasonLevelRewards? LevelRewards(int j)
		{
			return null;
		}

		[Address(RVA="0x24D96AC", Offset="0x24D96AC", VA="0x24D96AC")]
		public static void StartLevelRewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D9450", Offset="0x24D9450", VA="0x24D9450")]
		public static void StartPassportSeason(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D9578", Offset="0x24D9578", VA="0x24D9578")]
		public static void StartWeeksVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF57084", Offset="0xF57084", VA="0xF57084")]
		public PassportSeasonWeek? Weeks(int j)
		{
			return null;
		}
	}
}