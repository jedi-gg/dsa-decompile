using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct EmoteSubData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59EE0", Offset="0xF59EE0", VA="0xF59EE0", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Prefab
		{
			[Address(RVA="0xF59F0C", Offset="0xF59F0C", VA="0xF59F0C")]
			get
			{
				return null;
			}
		}

		public bool ShowInInventory
		{
			[Address(RVA="0xF59F24", Offset="0xF59F24", VA="0xF59F24")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF59EF4", Offset="0xF59EF4", VA="0xF59EF4")]
		public EmoteSubData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new EmoteSubData();
		}

		[Address(RVA="0xF59EE8", Offset="0xF59EE8", VA="0xF59EE8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250FF10", Offset="0x250FF10", VA="0x250FF10")]
		public static void AddPrefab(FlatBufferBuilder builder, StringOffset prefabOffset)
		{
		}

		[Address(RVA="0x250FF4C", Offset="0x250FF4C", VA="0x250FF4C")]
		public static void AddShowInInventory(FlatBufferBuilder builder, bool showInInventory)
		{
		}

		[Address(RVA="0x250FEA8", Offset="0x250FEA8", VA="0x250FEA8")]
		public static Offset<EmoteSubData> CreateEmoteSubData(FlatBufferBuilder builder, StringOffset prefabOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.EmoteSubData> Gamedata.EmoteSubData::CreateEmoteSubData(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.EmoteSubData> CreateEmoteSubData(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250FF88", Offset="0x250FF88", VA="0x250FF88")]
		public static Offset<EmoteSubData> EndEmoteSubData(FlatBufferBuilder builder)
		{
			return new Offset<EmoteSubData>();
		}

		[Address(RVA="0xF59F14", Offset="0xF59F14", VA="0xF59F14")]
		public ArraySegment<byte>? GetPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x250FD18", Offset="0x250FD18", VA="0x250FD18")]
		public static EmoteSubData GetRootAsEmoteSubData(FlatBuffers.ByteBuffer _bb)
		{
			return new EmoteSubData();
		}

		[Address(RVA="0x250FD24", Offset="0x250FD24", VA="0x250FD24")]
		public static EmoteSubData GetRootAsEmoteSubData(FlatBuffers.ByteBuffer _bb, EmoteSubData obj)
		{
			return new EmoteSubData();
		}

		[Address(RVA="0x2510008", Offset="0x2510008", VA="0x2510008")]
		public static void StartEmoteSubData(FlatBufferBuilder builder)
		{
		}
	}
}