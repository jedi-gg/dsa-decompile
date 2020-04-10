using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct EnergyConstants : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int AdRewardedCap
		{
			[Address(RVA="0xF5A054", Offset="0xF5A054", VA="0xF5A054")]
			get
			{
				return new int();
			}
		}

		public uint BonusGeneratedAmount
		{
			[Address(RVA="0xF5A05C", Offset="0xF5A05C", VA="0xF5A05C")]
			get
			{
				return new uint();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59F78", Offset="0xF59F78", VA="0xF59F78", Slot="5")]
			get
			{
				return null;
			}
		}

		public string DailyGiftDescKey
		{
			[Address(RVA="0xF5A03C", Offset="0xF5A03C", VA="0xF5A03C")]
			get
			{
				return null;
			}
		}

		public uint DailyGiftExpireSeconds
		{
			[Address(RVA="0xF5A00C", Offset="0xF5A00C", VA="0xF5A00C")]
			get
			{
				return new uint();
			}
		}

		public int DailyGiftSecondsFromDayStartLength
		{
			[Address(RVA="0xF59FF4", Offset="0xF59FF4", VA="0xF59FF4")]
			get
			{
				return new int();
			}
		}

		public string DailyGiftTitleKey
		{
			[Address(RVA="0xF5A024", Offset="0xF5A024", VA="0xF5A024")]
			get
			{
				return null;
			}
		}

		public uint GeneratedAmount
		{
			[Address(RVA="0xF59FBC", Offset="0xF59FBC", VA="0xF59FBC")]
			get
			{
				return new uint();
			}
		}

		public uint GeneratedFrequencySeconds
		{
			[Address(RVA="0xF59FB4", Offset="0xF59FB4", VA="0xF59FB4")]
			get
			{
				return new uint();
			}
		}

		public uint GlobalCap
		{
			[Address(RVA="0xF59FAC", Offset="0xF59FAC", VA="0xF59FAC")]
			get
			{
				return new uint();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF59FA4", Offset="0xF59FA4", VA="0xF59FA4")]
			get
			{
				return new ulong();
			}
		}

		public int LevelConstantsLength
		{
			[Address(RVA="0xF5A01C", Offset="0xF5A01C", VA="0xF5A01C")]
			get
			{
				return new int();
			}
		}

		public int MaxDailyBonusGenerateCap
		{
			[Address(RVA="0xF5A06C", Offset="0xF5A06C", VA="0xF5A06C")]
			get
			{
				return new int();
			}
		}

		public int RefreshCostAmountLength
		{
			[Address(RVA="0xF59FD4", Offset="0xF59FD4", VA="0xF59FD4")]
			get
			{
				return new int();
			}
		}

		public ulong RefreshCostItemId
		{
			[Address(RVA="0xF59FC4", Offset="0xF59FC4", VA="0xF59FC4")]
			get
			{
				return new ulong();
			}
		}

		public uint TimesToApplyGeneratedBonus
		{
			[Address(RVA="0xF5A064", Offset="0xF5A064", VA="0xF5A064")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF59F8C", Offset="0xF59F8C", VA="0xF59F8C")]
		public EnergyConstants __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new EnergyConstants();
		}

		[Address(RVA="0xF59F80", Offset="0xF59F80", VA="0xF59F80", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2510B2C", Offset="0x2510B2C", VA="0x2510B2C")]
		public static void AddAdRewardedCap(FlatBufferBuilder builder, int adRewardedCap)
		{
		}

		[Address(RVA="0x2510AF0", Offset="0x2510AF0", VA="0x2510AF0")]
		public static void AddBonusGeneratedAmount(FlatBufferBuilder builder, uint bonusGeneratedAmount)
		{
		}

		[Address(RVA="0x2510B68", Offset="0x2510B68", VA="0x2510B68")]
		public static void AddDailyGiftDescKey(FlatBufferBuilder builder, StringOffset dailyGiftDescKeyOffset)
		{
		}

		[Address(RVA="0x2510C1C", Offset="0x2510C1C", VA="0x2510C1C")]
		public static void AddDailyGiftExpireSeconds(FlatBufferBuilder builder, uint dailyGiftExpireSeconds)
		{
		}

		[Address(RVA="0x2510C58", Offset="0x2510C58", VA="0x2510C58")]
		public static void AddDailyGiftSecondsFromDayStart(FlatBufferBuilder builder, VectorOffset dailyGiftSecondsFromDayStartOffset)
		{
		}

		[Address(RVA="0x2510BA4", Offset="0x2510BA4", VA="0x2510BA4")]
		public static void AddDailyGiftTitleKey(FlatBufferBuilder builder, StringOffset dailyGiftTitleKeyOffset)
		{
		}

		[Address(RVA="0x2510CD0", Offset="0x2510CD0", VA="0x2510CD0")]
		public static void AddGeneratedAmount(FlatBufferBuilder builder, uint generatedAmount)
		{
		}

		[Address(RVA="0x2510D0C", Offset="0x2510D0C", VA="0x2510D0C")]
		public static void AddGeneratedFrequencySeconds(FlatBufferBuilder builder, uint generatedFrequencySeconds)
		{
		}

		[Address(RVA="0x2510D48", Offset="0x2510D48", VA="0x2510D48")]
		public static void AddGlobalCap(FlatBufferBuilder builder, uint globalCap)
		{
		}

		[Address(RVA="0x2510A3C", Offset="0x2510A3C", VA="0x2510A3C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2510BE0", Offset="0x2510BE0", VA="0x2510BE0")]
		public static void AddLevelConstants(FlatBufferBuilder builder, VectorOffset levelConstantsOffset)
		{
		}

		[Address(RVA="0x2510A78", Offset="0x2510A78", VA="0x2510A78")]
		public static void AddMaxDailyBonusGenerateCap(FlatBufferBuilder builder, int maxDailyBonusGenerateCap)
		{
		}

		[Address(RVA="0x2510C94", Offset="0x2510C94", VA="0x2510C94")]
		public static void AddRefreshCostAmount(FlatBufferBuilder builder, VectorOffset refreshCostAmountOffset)
		{
		}

		[Address(RVA="0x2510A00", Offset="0x2510A00", VA="0x2510A00")]
		public static void AddRefreshCostItemId(FlatBufferBuilder builder, ulong refreshCostItemId)
		{
		}

		[Address(RVA="0x2510AB4", Offset="0x2510AB4", VA="0x2510AB4")]
		public static void AddTimesToApplyGeneratedBonus(FlatBufferBuilder builder, uint timesToApplyGeneratedBonus)
		{
		}

		[Address(RVA="0x2510F68", Offset="0x2510F68", VA="0x2510F68")]
		public static VectorOffset CreateDailyGiftSecondsFromDayStartVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x25108A8", Offset="0x25108A8", VA="0x25108A8")]
		public static Offset<EnergyConstants> CreateEnergyConstants(FlatBufferBuilder builder, ulong id = 0L, uint global_cap = 0, uint generated_frequency_seconds = 0, uint generated_amount = 0, ulong refresh_cost_item_id = 0L, VectorOffset refresh_cost_amountOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.EnergyConstants> Gamedata.EnergyConstants::CreateEnergyConstants(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,System.UInt32,System.UInt32,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,System.UInt32,System.UInt32,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.EnergyConstants> CreateEnergyConstants(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,System.UInt32,System.UInt32,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,System.UInt32,System.UInt32,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x251109C", Offset="0x251109C", VA="0x251109C")]
		public static VectorOffset CreateLevelConstantsVector(FlatBufferBuilder builder, Offset<PlayerLevelEnergyConstants>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2510E34", Offset="0x2510E34", VA="0x2510E34")]
		public static VectorOffset CreateRefreshCostAmountVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0xF59FEC", Offset="0xF59FEC", VA="0xF59FEC")]
		public uint DailyGiftSecondsFromDayStart(int j)
		{
			return new uint();
		}

		[Address(RVA="0x2510D84", Offset="0x2510D84", VA="0x2510D84")]
		public static Offset<EnergyConstants> EndEnergyConstants(FlatBufferBuilder builder)
		{
			return new Offset<EnergyConstants>();
		}

		[Address(RVA="0x25111D0", Offset="0x25111D0", VA="0x25111D0")]
		public static void FinishEnergyConstantsBuffer(FlatBufferBuilder builder, Offset<EnergyConstants> offset)
		{
		}

		[Address(RVA="0xF5A044", Offset="0xF5A044", VA="0xF5A044")]
		public ArraySegment<byte>? GetDailyGiftDescKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF59FFC", Offset="0xF59FFC", VA="0xF59FFC")]
		public ArraySegment<byte>? GetDailyGiftSecondsFromDayStartBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A02C", Offset="0xF5A02C", VA="0xF5A02C")]
		public ArraySegment<byte>? GetDailyGiftTitleKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF59FDC", Offset="0xF59FDC", VA="0xF59FDC")]
		public ArraySegment<byte>? GetRefreshCostAmountBytes()
		{
			return null;
		}

		[Address(RVA="0x2510040", Offset="0x2510040", VA="0x2510040")]
		public static EnergyConstants GetRootAsEnergyConstants(FlatBuffers.ByteBuffer _bb)
		{
			return new EnergyConstants();
		}

		[Address(RVA="0x251004C", Offset="0x251004C", VA="0x251004C")]
		public static EnergyConstants GetRootAsEnergyConstants(FlatBuffers.ByteBuffer _bb, EnergyConstants obj)
		{
			return new EnergyConstants();
		}

		[Address(RVA="0xF5A014", Offset="0xF5A014", VA="0xF5A014")]
		public PlayerLevelEnergyConstants? LevelConstants(int j)
		{
			return null;
		}

		[Address(RVA="0xF59FCC", Offset="0xF59FCC", VA="0xF59FCC")]
		public uint RefreshCostAmount(int j)
		{
			return new uint();
		}

		[Address(RVA="0x2511060", Offset="0x2511060", VA="0x2511060")]
		public static void StartDailyGiftSecondsFromDayStartVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2510E04", Offset="0x2510E04", VA="0x2510E04")]
		public static void StartEnergyConstants(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2511194", Offset="0x2511194", VA="0x2511194")]
		public static void StartLevelConstantsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2510F2C", Offset="0x2510F2C", VA="0x2510F2C")]
		public static void StartRefreshCostAmountVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}