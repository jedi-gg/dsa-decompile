using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LockableFeatures : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56658", Offset="0xF56658", VA="0xF56658", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF56684", Offset="0xF56684", VA="0xF56684")]
			get
			{
				return new ulong();
			}
		}

		public int LockableFeaturesListLength
		{
			[Address(RVA="0xF56694", Offset="0xF56694", VA="0xF56694")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5666C", Offset="0xF5666C", VA="0xF5666C")]
		public LockableFeatures __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LockableFeatures();
		}

		[Address(RVA="0xF56660", Offset="0xF56660", VA="0xF56660", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D39E4", Offset="0x24D39E4", VA="0x24D39E4")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24D3A20", Offset="0x24D3A20", VA="0x24D3A20")]
		public static void AddLockableFeaturesList(FlatBufferBuilder builder, VectorOffset lockableFeaturesListOffset)
		{
		}

		[Address(RVA="0x24D397C", Offset="0x24D397C", VA="0x24D397C")]
		public static Offset<LockableFeatures> CreateLockableFeatures(FlatBufferBuilder builder, ulong id = 0L, VectorOffset lockable_features_listOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LockableFeatures> Gamedata.LockableFeatures::CreateLockableFeatures(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LockableFeatures> CreateLockableFeatures(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D3B0C", Offset="0x24D3B0C", VA="0x24D3B0C")]
		public static VectorOffset CreateLockableFeaturesListVector(FlatBufferBuilder builder, Offset<LockableFeatureEntry>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D3A5C", Offset="0x24D3A5C", VA="0x24D3A5C")]
		public static Offset<LockableFeatures> EndLockableFeatures(FlatBufferBuilder builder)
		{
			return new Offset<LockableFeatures>();
		}

		[Address(RVA="0x24D3C40", Offset="0x24D3C40", VA="0x24D3C40")]
		public static void FinishLockableFeaturesBuffer(FlatBufferBuilder builder, Offset<LockableFeatures> offset)
		{
		}

		[Address(RVA="0x24D3734", Offset="0x24D3734", VA="0x24D3734")]
		public static LockableFeatures GetRootAsLockableFeatures(FlatBuffers.ByteBuffer _bb)
		{
			return new LockableFeatures();
		}

		[Address(RVA="0x24D3740", Offset="0x24D3740", VA="0x24D3740")]
		public static LockableFeatures GetRootAsLockableFeatures(FlatBuffers.ByteBuffer _bb, LockableFeatures obj)
		{
			return new LockableFeatures();
		}

		[Address(RVA="0xF5668C", Offset="0xF5668C", VA="0xF5668C")]
		public LockableFeatureEntry? LockableFeaturesList(int j)
		{
			return null;
		}

		[Address(RVA="0x24D3ADC", Offset="0x24D3ADC", VA="0x24D3ADC")]
		public static void StartLockableFeatures(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D3C04", Offset="0x24D3C04", VA="0x24D3C04")]
		public static void StartLockableFeaturesListVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}