using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Campaign : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public uint AttemptLimitNum
		{
			[Address(RVA="0xF0AE8C", Offset="0xF0AE8C", VA="0xF0AE8C")]
			get
			{
				return new uint();
			}
		}

		public CampaignAttemptLimit AttemptLimitType
		{
			[Address(RVA="0xF0AE84", Offset="0xF0AE84", VA="0xF0AE84")]
			get
			{
				return new CampaignAttemptLimit();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0ADF8", Offset="0xF0ADF8", VA="0xF0ADF8", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.CampaignType CampaignType
		{
			[Address(RVA="0xF0AE94", Offset="0xF0AE94", VA="0xF0AE94")]
			get
			{
				return new Gamedata.CampaignType();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0AE24", Offset="0xF0AE24", VA="0xF0AE24")]
			get
			{
				return new ulong();
			}
		}

		public int MapsLength
		{
			[Address(RVA="0xF0AE64", Offset="0xF0AE64", VA="0xF0AE64")]
			get
			{
				return new int();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0AE44", Offset="0xF0AE44", VA="0xF0AE44")]
			get
			{
				return null;
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF0AE2C", Offset="0xF0AE2C", VA="0xF0AE2C")]
			get
			{
				return null;
			}
		}

		public string WorldAsset
		{
			[Address(RVA="0xF0AE6C", Offset="0xF0AE6C", VA="0xF0AE6C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0AE0C", Offset="0xF0AE0C", VA="0xF0AE0C")]
		public Campaign __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Campaign();
		}

		[Address(RVA="0xF0AE00", Offset="0xF0AE00", VA="0xF0AE00", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F7B2C", Offset="0x15F7B2C", VA="0x15F7B2C")]
		public static void AddAttemptLimitNum(FlatBufferBuilder builder, uint attemptLimitNum)
		{
		}

		[Address(RVA="0x15F7C94", Offset="0x15F7C94", VA="0x15F7C94")]
		public static void AddAttemptLimitType(FlatBufferBuilder builder, CampaignAttemptLimit attemptLimitType)
		{
		}

		[Address(RVA="0x15F7C58", Offset="0x15F7C58", VA="0x15F7C58")]
		public static void AddCampaignType(FlatBufferBuilder builder, Gamedata.CampaignType campaignType)
		{
		}

		[Address(RVA="0x15F7AF0", Offset="0x15F7AF0", VA="0x15F7AF0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F7BA4", Offset="0x15F7BA4", VA="0x15F7BA4")]
		public static void AddMaps(FlatBufferBuilder builder, VectorOffset mapsOffset)
		{
		}

		[Address(RVA="0x15F7BE0", Offset="0x15F7BE0", VA="0x15F7BE0")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x15F7C1C", Offset="0x15F7C1C", VA="0x15F7C1C")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x15F7B68", Offset="0x15F7B68", VA="0x15F7B68")]
		public static void AddWorldAsset(FlatBufferBuilder builder, StringOffset worldAssetOffset)
		{
		}

		[Address(RVA="0x15F7A10", Offset="0x15F7A10", VA="0x15F7A10")]
		public static Offset<Campaign> CreateCampaign(FlatBufferBuilder builder, ulong id = 0L, StringOffset requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.Campaign> Gamedata.Campaign::CreateCampaign(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.CampaignAttemptLimit,System.UInt32,Gamedata.CampaignType)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.Campaign> CreateCampaign(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.CampaignAttemptLimit,System.UInt32,Gamedata.CampaignType)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F7D80", Offset="0x15F7D80", VA="0x15F7D80")]
		public static VectorOffset CreateMapsVector(FlatBufferBuilder builder, Offset<CampaignMap>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F7CD0", Offset="0x15F7CD0", VA="0x15F7CD0")]
		public static Offset<Campaign> EndCampaign(FlatBufferBuilder builder)
		{
			return new Offset<Campaign>();
		}

		[Address(RVA="0x15F7EB4", Offset="0x15F7EB4", VA="0x15F7EB4")]
		public static void FinishCampaignBuffer(FlatBufferBuilder builder, Offset<Campaign> offset)
		{
		}

		[Address(RVA="0xF0AE4C", Offset="0xF0AE4C", VA="0xF0AE4C")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AE34", Offset="0xF0AE34", VA="0xF0AE34")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x15F7570", Offset="0x15F7570", VA="0x15F7570")]
		public static Campaign GetRootAsCampaign(FlatBuffers.ByteBuffer _bb)
		{
			return new Campaign();
		}

		[Address(RVA="0x15F757C", Offset="0x15F757C", VA="0x15F757C")]
		public static Campaign GetRootAsCampaign(FlatBuffers.ByteBuffer _bb, Campaign obj)
		{
			return new Campaign();
		}

		[Address(RVA="0xF0AE74", Offset="0xF0AE74", VA="0xF0AE74")]
		public ArraySegment<byte>? GetWorldAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AE5C", Offset="0xF0AE5C", VA="0xF0AE5C")]
		public CampaignMap? Maps(int j)
		{
			return null;
		}

		[Address(RVA="0x15F7D50", Offset="0x15F7D50", VA="0x15F7D50")]
		public static void StartCampaign(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F7E78", Offset="0x15F7E78", VA="0x15F7E78")]
		public static void StartMapsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}