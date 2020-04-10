using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct TowerMap : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B3B8", Offset="0xF3B3B8", VA="0xF3B3B8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF3B44C", Offset="0xF3B44C", VA="0xF3B44C")]
			get
			{
				return null;
			}
		}

		public string Image
		{
			[Address(RVA="0xF3B404", Offset="0xF3B404", VA="0xF3B404")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF3B434", Offset="0xF3B434", VA="0xF3B434")]
			get
			{
				return null;
			}
		}

		public int NodesLength
		{
			[Address(RVA="0xF3B3EC", Offset="0xF3B3EC", VA="0xF3B3EC")]
			get
			{
				return new int();
			}
		}

		public ulong ProgressionCompleteLoot
		{
			[Address(RVA="0xF3B3FC", Offset="0xF3B3FC", VA="0xF3B3FC")]
			get
			{
				return new ulong();
			}
		}

		public uint RequiredCompletionCount
		{
			[Address(RVA="0xF3B3F4", Offset="0xF3B3F4", VA="0xF3B3F4")]
			get
			{
				return new uint();
			}
		}

		public string Scene
		{
			[Address(RVA="0xF3B41C", Offset="0xF3B41C", VA="0xF3B41C")]
			get
			{
				return null;
			}
		}

		public int ShowcaseItemsLength
		{
			[Address(RVA="0xF3B46C", Offset="0xF3B46C", VA="0xF3B46C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3B3CC", Offset="0xF3B3CC", VA="0xF3B3CC")]
		public TowerMap __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new TowerMap();
		}

		[Address(RVA="0xF3B3C0", Offset="0xF3B3C0", VA="0xF3B3C0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22EC5E4", Offset="0x22EC5E4", VA="0x22EC5E4")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x22EC698", Offset="0x22EC698", VA="0x22EC698")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x22EC620", Offset="0x22EC620", VA="0x22EC620")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x22EC710", Offset="0x22EC710", VA="0x22EC710")]
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
		}

		[Address(RVA="0x22EC56C", Offset="0x22EC56C", VA="0x22EC56C")]
		public static void AddProgressionCompleteLoot(FlatBufferBuilder builder, ulong progressionCompleteLoot)
		{
		}

		[Address(RVA="0x22EC6D4", Offset="0x22EC6D4", VA="0x22EC6D4")]
		public static void AddRequiredCompletionCount(FlatBufferBuilder builder, uint requiredCompletionCount)
		{
		}

		[Address(RVA="0x22EC65C", Offset="0x22EC65C", VA="0x22EC65C")]
		public static void AddScene(FlatBufferBuilder builder, StringOffset sceneOffset)
		{
		}

		[Address(RVA="0x22EC5A8", Offset="0x22EC5A8", VA="0x22EC5A8")]
		public static void AddShowcaseItems(FlatBufferBuilder builder, VectorOffset showcaseItemsOffset)
		{
		}

		[Address(RVA="0x22EC7FC", Offset="0x22EC7FC", VA="0x22EC7FC")]
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<TowerNode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EC930", Offset="0x22EC930", VA="0x22EC930")]
		public static VectorOffset CreateShowcaseItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EC48C", Offset="0x22EC48C", VA="0x22EC48C")]
		public static Offset<TowerMap> CreateTowerMap(FlatBufferBuilder builder, VectorOffset nodesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.TowerMap> Gamedata.TowerMap::CreateTowerMap(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.UInt32,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.TowerMap> CreateTowerMap(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.UInt32,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22EC74C", Offset="0x22EC74C", VA="0x22EC74C")]
		public static Offset<TowerMap> EndTowerMap(FlatBufferBuilder builder)
		{
			return new Offset<TowerMap>();
		}

		[Address(RVA="0xF3B454", Offset="0xF3B454", VA="0xF3B454")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B40C", Offset="0xF3B40C", VA="0xF3B40C")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B43C", Offset="0xF3B43C", VA="0xF3B43C")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x22EBFA8", Offset="0x22EBFA8", VA="0x22EBFA8")]
		public static TowerMap GetRootAsTowerMap(FlatBuffers.ByteBuffer _bb)
		{
			return new TowerMap();
		}

		[Address(RVA="0x22EBFB4", Offset="0x22EBFB4", VA="0x22EBFB4")]
		public static TowerMap GetRootAsTowerMap(FlatBuffers.ByteBuffer _bb, TowerMap obj)
		{
			return new TowerMap();
		}

		[Address(RVA="0xF3B424", Offset="0xF3B424", VA="0xF3B424")]
		public ArraySegment<byte>? GetSceneBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B474", Offset="0xF3B474", VA="0xF3B474")]
		public ArraySegment<byte>? GetShowcaseItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B3E4", Offset="0xF3B3E4", VA="0xF3B3E4")]
		public TowerNode? Nodes(int j)
		{
			return null;
		}

		[Address(RVA="0xF3B464", Offset="0xF3B464", VA="0xF3B464")]
		public ulong ShowcaseItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x22EC8F4", Offset="0x22EC8F4", VA="0x22EC8F4")]
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22ECA28", Offset="0x22ECA28", VA="0x22ECA28")]
		public static void StartShowcaseItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EC7CC", Offset="0x22EC7CC", VA="0x22EC7CC")]
		public static void StartTowerMap(FlatBufferBuilder builder)
		{
		}
	}
}