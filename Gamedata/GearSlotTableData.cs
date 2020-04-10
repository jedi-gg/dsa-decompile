using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct GearSlotTableData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public GearSlotTableStat? Accuracy
		{
			[Address(RVA="0xF5A444", Offset="0xF5A444", VA="0xF5A444")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? AttackSpeed
		{
			[Address(RVA="0xF5A424", Offset="0xF5A424", VA="0xF5A424")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A3C8", Offset="0xF5A3C8", VA="0xF5A3C8", Slot="5")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? CritChance
		{
			[Address(RVA="0xF5A414", Offset="0xF5A414", VA="0xF5A414")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? CritPower
		{
			[Address(RVA="0xF5A41C", Offset="0xF5A41C", VA="0xF5A41C")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Defense
		{
			[Address(RVA="0xF5A3FC", Offset="0xF5A3FC", VA="0xF5A3FC")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Evasion
		{
			[Address(RVA="0xF5A44C", Offset="0xF5A44C", VA="0xF5A44C")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Health
		{
			[Address(RVA="0xF5A404", Offset="0xF5A404", VA="0xF5A404")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Offense
		{
			[Address(RVA="0xF5A3F4", Offset="0xF5A3F4", VA="0xF5A3F4")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Potency
		{
			[Address(RVA="0xF5A434", Offset="0xF5A434", VA="0xF5A434")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Recovery
		{
			[Address(RVA="0xF5A40C", Offset="0xF5A40C", VA="0xF5A40C")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Speed
		{
			[Address(RVA="0xF5A42C", Offset="0xF5A42C", VA="0xF5A42C")]
			get
			{
				return null;
			}
		}

		public GearSlotTableStat? Tenacity
		{
			[Address(RVA="0xF5A43C", Offset="0xF5A43C", VA="0xF5A43C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5A3DC", Offset="0xF5A3DC", VA="0xF5A3DC")]
		public GearSlotTableData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTableData();
		}

		[Address(RVA="0xF5A3D0", Offset="0xF5A3D0", VA="0xF5A3D0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25137F0", Offset="0x25137F0", VA="0x25137F0")]
		public static void AddAccuracy(FlatBufferBuilder builder, Offset<GearSlotTableStat> accuracyOffset)
		{
		}

		[Address(RVA="0x25138E0", Offset="0x25138E0", VA="0x25138E0")]
		public static void AddAttackSpeed(FlatBufferBuilder builder, Offset<GearSlotTableStat> attackSpeedOffset)
		{
		}

		[Address(RVA="0x2513958", Offset="0x2513958", VA="0x2513958")]
		public static void AddCritChance(FlatBufferBuilder builder, Offset<GearSlotTableStat> critChanceOffset)
		{
		}

		[Address(RVA="0x251391C", Offset="0x251391C", VA="0x251391C")]
		public static void AddCritPower(FlatBufferBuilder builder, Offset<GearSlotTableStat> critPowerOffset)
		{
		}

		[Address(RVA="0x2513A0C", Offset="0x2513A0C", VA="0x2513A0C")]
		public static void AddDefense(FlatBufferBuilder builder, Offset<GearSlotTableStat> defenseOffset)
		{
		}

		[Address(RVA="0x25137B4", Offset="0x25137B4", VA="0x25137B4")]
		public static void AddEvasion(FlatBufferBuilder builder, Offset<GearSlotTableStat> evasionOffset)
		{
		}

		[Address(RVA="0x25139D0", Offset="0x25139D0", VA="0x25139D0")]
		public static void AddHealth(FlatBufferBuilder builder, Offset<GearSlotTableStat> healthOffset)
		{
		}

		[Address(RVA="0x2513A48", Offset="0x2513A48", VA="0x2513A48")]
		public static void AddOffense(FlatBufferBuilder builder, Offset<GearSlotTableStat> offenseOffset)
		{
		}

		[Address(RVA="0x2513868", Offset="0x2513868", VA="0x2513868")]
		public static void AddPotency(FlatBufferBuilder builder, Offset<GearSlotTableStat> potencyOffset)
		{
		}

		[Address(RVA="0x2513994", Offset="0x2513994", VA="0x2513994")]
		public static void AddRecovery(FlatBufferBuilder builder, Offset<GearSlotTableStat> recoveryOffset)
		{
		}

		[Address(RVA="0x25138A4", Offset="0x25138A4", VA="0x25138A4")]
		public static void AddSpeed(FlatBufferBuilder builder, Offset<GearSlotTableStat> speedOffset)
		{
		}

		[Address(RVA="0x251382C", Offset="0x251382C", VA="0x251382C")]
		public static void AddTenacity(FlatBufferBuilder builder, Offset<GearSlotTableStat> tenacityOffset)
		{
		}

		[Address(RVA="0x251368C", Offset="0x251368C", VA="0x251368C")]
		public static Offset<GearSlotTableData> CreateGearSlotTableData(FlatBufferBuilder builder, Offset<GearSlotTableStat> offenseOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.GearSlotTableData> Gamedata.GearSlotTableData::CreateGearSlotTableData(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>,FlatBuffers.Offset`1<Gamedata.GearSlotTableStat>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.GearSlotTableData> CreateGearSlotTableData(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>,FlatBuffers.Offset<Gamedata.GearSlotTableStat>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2513A84", Offset="0x2513A84", VA="0x2513A84")]
		public static Offset<GearSlotTableData> EndGearSlotTableData(FlatBufferBuilder builder)
		{
			return new Offset<GearSlotTableData>();
		}

		[Address(RVA="0x2512DA8", Offset="0x2512DA8", VA="0x2512DA8")]
		public static GearSlotTableData GetRootAsGearSlotTableData(FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTableData();
		}

		[Address(RVA="0x2512DB4", Offset="0x2512DB4", VA="0x2512DB4")]
		public static GearSlotTableData GetRootAsGearSlotTableData(FlatBuffers.ByteBuffer _bb, GearSlotTableData obj)
		{
			return new GearSlotTableData();
		}

		[Address(RVA="0x2513B04", Offset="0x2513B04", VA="0x2513B04")]
		public static void StartGearSlotTableData(FlatBufferBuilder builder)
		{
		}
	}
}