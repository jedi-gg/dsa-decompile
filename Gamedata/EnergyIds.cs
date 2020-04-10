using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct EnergyIds : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A148", Offset="0xF5A148", VA="0xF5A148", Slot="5")]
			get
			{
				return null;
			}
		}

		public EnergyIdMapping? GrandCampaign
		{
			[Address(RVA="0xF5A17C", Offset="0xF5A17C", VA="0xF5A17C")]
			get
			{
				return null;
			}
		}

		public EnergyIdMapping? Pve
		{
			[Address(RVA="0xF5A174", Offset="0xF5A174", VA="0xF5A174")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5A15C", Offset="0xF5A15C", VA="0xF5A15C")]
		public EnergyIds __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new EnergyIds();
		}

		[Address(RVA="0xF5A150", Offset="0xF5A150", VA="0xF5A150", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25117E4", Offset="0x25117E4", VA="0x25117E4")]
		public static void AddGrandCampaign(FlatBufferBuilder builder, Offset<EnergyIdMapping> grandCampaignOffset)
		{
		}

		[Address(RVA="0x2511820", Offset="0x2511820", VA="0x2511820")]
		public static void AddPve(FlatBufferBuilder builder, Offset<EnergyIdMapping> pveOffset)
		{
		}

		[Address(RVA="0x251177C", Offset="0x251177C", VA="0x251177C")]
		public static Offset<EnergyIds> CreateEnergyIds(FlatBufferBuilder builder, Offset<EnergyIdMapping> pveOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.EnergyIds> Gamedata.EnergyIds::CreateEnergyIds(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset`1<Gamedata.EnergyIdMapping>,FlatBuffers.Offset`1<Gamedata.EnergyIdMapping>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.EnergyIds> CreateEnergyIds(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset<Gamedata.EnergyIdMapping>,FlatBuffers.Offset<Gamedata.EnergyIdMapping>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x251185C", Offset="0x251185C", VA="0x251185C")]
		public static Offset<EnergyIds> EndEnergyIds(FlatBufferBuilder builder)
		{
			return new Offset<EnergyIds>();
		}

		[Address(RVA="0x2511550", Offset="0x2511550", VA="0x2511550")]
		public static EnergyIds GetRootAsEnergyIds(FlatBuffers.ByteBuffer _bb)
		{
			return new EnergyIds();
		}

		[Address(RVA="0x251155C", Offset="0x251155C", VA="0x251155C")]
		public static EnergyIds GetRootAsEnergyIds(FlatBuffers.ByteBuffer _bb, EnergyIds obj)
		{
			return new EnergyIds();
		}

		[Address(RVA="0x25118DC", Offset="0x25118DC", VA="0x25118DC")]
		public static void StartEnergyIds(FlatBufferBuilder builder)
		{
		}
	}
}