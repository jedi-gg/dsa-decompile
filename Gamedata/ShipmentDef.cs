using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentDef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public bool AllowRefresh
		{
			[Address(RVA="0xF58B24", Offset="0xF58B24", VA="0xF58B24")]
			get
			{
				return new bool();
			}
		}

		public bool AllowVipBuyAll
		{
			[Address(RVA="0xF58B0C", Offset="0xF58B0C", VA="0xF58B0C")]
			get
			{
				return new bool();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58A60", Offset="0xF58A60", VA="0xF58A60", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF58A94", Offset="0xF58A94", VA="0xF58A94")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58A8C", Offset="0xF58A8C", VA="0xF58A8C")]
			get
			{
				return new ulong();
			}
		}

		public int LevelsLength
		{
			[Address(RVA="0xF58ACC", Offset="0xF58ACC", VA="0xF58ACC")]
			get
			{
				return new int();
			}
		}

		public string LockedLocKey
		{
			[Address(RVA="0xF58AEC", Offset="0xF58AEC", VA="0xF58AEC")]
			get
			{
				return null;
			}
		}

		public OccasionRef? Occasion
		{
			[Address(RVA="0xF58B04", Offset="0xF58B04", VA="0xF58B04")]
			get
			{
				return null;
			}
		}

		public int RefreshCostsLength
		{
			[Address(RVA="0xF58ABC", Offset="0xF58ABC", VA="0xF58ABC")]
			get
			{
				return new int();
			}
		}

		public uint RefreshTime
		{
			[Address(RVA="0xF58B1C", Offset="0xF58B1C", VA="0xF58B1C")]
			get
			{
				return new uint();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF58AD4", Offset="0xF58AD4", VA="0xF58AD4")]
			get
			{
				return null;
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF58AAC", Offset="0xF58AAC", VA="0xF58AAC")]
			get
			{
				return new int();
			}
		}

		public bool VipOnly
		{
			[Address(RVA="0xF58B14", Offset="0xF58B14", VA="0xF58B14")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF58A74", Offset="0xF58A74", VA="0xF58A74")]
		public ShipmentDef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentDef();
		}

		[Address(RVA="0xF58A68", Offset="0xF58A68", VA="0xF58A68", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E9040", Offset="0x24E9040", VA="0x24E9040")]
		public static void AddAllowRefresh(FlatBufferBuilder builder, bool allowRefresh)
		{
		}

		[Address(RVA="0x24E90B8", Offset="0x24E90B8", VA="0x24E90B8")]
		public static void AddAllowVipBuyAll(FlatBufferBuilder builder, bool allowVipBuyAll)
		{
		}

		[Address(RVA="0x24E9004", Offset="0x24E9004", VA="0x24E9004")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x24E8E24", Offset="0x24E8E24", VA="0x24E8E24")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E8F50", Offset="0x24E8F50", VA="0x24E8F50")]
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
		}

		[Address(RVA="0x24E8ED8", Offset="0x24E8ED8", VA="0x24E8ED8")]
		public static void AddLockedLocKey(FlatBufferBuilder builder, StringOffset lockedLocKeyOffset)
		{
		}

		[Address(RVA="0x24E8E9C", Offset="0x24E8E9C", VA="0x24E8E9C")]
		public static void AddOccasion(FlatBufferBuilder builder, Offset<OccasionRef> occasionOffset)
		{
		}

		[Address(RVA="0x24E8F8C", Offset="0x24E8F8C", VA="0x24E8F8C")]
		public static void AddRefreshCosts(FlatBufferBuilder builder, VectorOffset refreshCostsOffset)
		{
		}

		[Address(RVA="0x24E8E60", Offset="0x24E8E60", VA="0x24E8E60")]
		public static void AddRefreshTime(FlatBufferBuilder builder, uint refreshTime)
		{
		}

		[Address(RVA="0x24E8F14", Offset="0x24E8F14", VA="0x24E8F14")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x24E8FC8", Offset="0x24E8FC8", VA="0x24E8FC8")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x24E907C", Offset="0x24E907C", VA="0x24E907C")]
		public static void AddVipOnly(FlatBufferBuilder builder, bool vipOnly)
		{
		}

		[Address(RVA="0x24E92D8", Offset="0x24E92D8", VA="0x24E92D8")]
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<ShipmentLevel>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E91A4", Offset="0x24E91A4", VA="0x24E91A4")]
		public static VectorOffset CreateRefreshCostsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E8CE4", Offset="0x24E8CE4", VA="0x24E8CE4")]
		public static Offset<ShipmentDef> CreateShipmentDef(FlatBufferBuilder builder, ulong id = 0L, StringOffset iconOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ShipmentDef> Gamedata.ShipmentDef::CreateShipmentDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.OccasionRef>,System.Boolean,System.Boolean,System.UInt32,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ShipmentDef> CreateShipmentDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.OccasionRef>,System.Boolean,System.Boolean,System.UInt32,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E90F4", Offset="0x24E90F4", VA="0x24E90F4")]
		public static Offset<ShipmentDef> EndShipmentDef(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentDef>();
		}

		[Address(RVA="0x24E940C", Offset="0x24E940C", VA="0x24E940C")]
		public static void FinishShipmentDefBuffer(FlatBufferBuilder builder, Offset<ShipmentDef> offset)
		{
		}

		[Address(RVA="0xF58A9C", Offset="0xF58A9C", VA="0xF58A9C")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF58AF4", Offset="0xF58AF4", VA="0xF58AF4")]
		public ArraySegment<byte>? GetLockedLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF58ADC", Offset="0xF58ADC", VA="0xF58ADC")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24E8584", Offset="0x24E8584", VA="0x24E8584")]
		public static ShipmentDef GetRootAsShipmentDef(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentDef();
		}

		[Address(RVA="0x24E8590", Offset="0x24E8590", VA="0x24E8590")]
		public static ShipmentDef GetRootAsShipmentDef(FlatBuffers.ByteBuffer _bb, ShipmentDef obj)
		{
			return new ShipmentDef();
		}

		[Address(RVA="0xF58AC4", Offset="0xF58AC4", VA="0xF58AC4")]
		public ShipmentLevel? Levels(int j)
		{
			return null;
		}

		[Address(RVA="0xF58AB4", Offset="0xF58AB4", VA="0xF58AB4")]
		public ItemCount? RefreshCosts(int j)
		{
			return null;
		}

		[Address(RVA="0x24E93D0", Offset="0x24E93D0", VA="0x24E93D0")]
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E929C", Offset="0x24E929C", VA="0x24E929C")]
		public static void StartRefreshCostsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E9174", Offset="0x24E9174", VA="0x24E9174")]
		public static void StartShipmentDef(FlatBufferBuilder builder)
		{
		}
	}
}