using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LockableFeatureEntry : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56578", Offset="0xF56578", VA="0xF56578", Slot="5")]
			get
			{
				return null;
			}
		}

		public LockableFeature Feature
		{
			[Address(RVA="0xF565A4", Offset="0xF565A4", VA="0xF565A4")]
			get
			{
				return new LockableFeature();
			}
		}

		public string LockedDescriptionKey
		{
			[Address(RVA="0xF565DC", Offset="0xF565DC", VA="0xF565DC")]
			get
			{
				return null;
			}
		}

		public string LockedShortDescriptionKey
		{
			[Address(RVA="0xF565F4", Offset="0xF565F4", VA="0xF565F4")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF565C4", Offset="0xF565C4", VA="0xF565C4")]
			get
			{
				return null;
			}
		}

		public string UnlockRequirement
		{
			[Address(RVA="0xF565AC", Offset="0xF565AC", VA="0xF565AC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5658C", Offset="0xF5658C", VA="0xF5658C")]
		public LockableFeatureEntry __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LockableFeatureEntry();
		}

		[Address(RVA="0xF56580", Offset="0xF56580", VA="0xF56580", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D3640", Offset="0x24D3640", VA="0x24D3640")]
		public static void AddFeature(FlatBufferBuilder builder, LockableFeature feature)
		{
		}

		[Address(RVA="0x24D358C", Offset="0x24D358C", VA="0x24D358C")]
		public static void AddLockedDescriptionKey(FlatBufferBuilder builder, StringOffset lockedDescriptionKeyOffset)
		{
		}

		[Address(RVA="0x24D3550", Offset="0x24D3550", VA="0x24D3550")]
		public static void AddLockedShortDescriptionKey(FlatBufferBuilder builder, StringOffset lockedShortDescriptionKeyOffset)
		{
		}

		[Address(RVA="0x24D35C8", Offset="0x24D35C8", VA="0x24D35C8")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24D3604", Offset="0x24D3604", VA="0x24D3604")]
		public static void AddUnlockRequirement(FlatBufferBuilder builder, StringOffset unlockRequirementOffset)
		{
		}

		[Address(RVA="0x24D34B0", Offset="0x24D34B0", VA="0x24D34B0")]
		public static Offset<LockableFeatureEntry> CreateLockableFeatureEntry(FlatBufferBuilder builder, LockableFeature feature = 0, StringOffset unlock_requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LockableFeatureEntry> Gamedata.LockableFeatureEntry::CreateLockableFeatureEntry(FlatBuffers.FlatBufferBuilder,Gamedata.LockableFeature,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LockableFeatureEntry> CreateLockableFeatureEntry(FlatBuffers.FlatBufferBuilder,Gamedata.LockableFeature,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D367C", Offset="0x24D367C", VA="0x24D367C")]
		public static Offset<LockableFeatureEntry> EndLockableFeatureEntry(FlatBufferBuilder builder)
		{
			return new Offset<LockableFeatureEntry>();
		}

		[Address(RVA="0xF565E4", Offset="0xF565E4", VA="0xF565E4")]
		public ArraySegment<byte>? GetLockedDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF565FC", Offset="0xF565FC", VA="0xF565FC")]
		public ArraySegment<byte>? GetLockedShortDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF565CC", Offset="0xF565CC", VA="0xF565CC")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24D3214", Offset="0x24D3214", VA="0x24D3214")]
		public static LockableFeatureEntry GetRootAsLockableFeatureEntry(FlatBuffers.ByteBuffer _bb)
		{
			return new LockableFeatureEntry();
		}

		[Address(RVA="0x24D3220", Offset="0x24D3220", VA="0x24D3220")]
		public static LockableFeatureEntry GetRootAsLockableFeatureEntry(FlatBuffers.ByteBuffer _bb, LockableFeatureEntry obj)
		{
			return new LockableFeatureEntry();
		}

		[Address(RVA="0xF565B4", Offset="0xF565B4", VA="0xF565B4")]
		public ArraySegment<byte>? GetUnlockRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24D36FC", Offset="0x24D36FC", VA="0x24D36FC")]
		public static void StartLockableFeatureEntry(FlatBufferBuilder builder)
		{
		}
	}
}