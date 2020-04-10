using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct HomeShowcase : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A698", Offset="0xF5A698", VA="0xF5A698", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF5A6FC", Offset="0xF5A6FC", VA="0xF5A6FC")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF5A704", Offset="0xF5A704", VA="0xF5A704")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5A6C4", Offset="0xF5A6C4", VA="0xF5A6C4")]
			get
			{
				return new ulong();
			}
		}

		public string Image
		{
			[Address(RVA="0xF5A6CC", Offset="0xF5A6CC", VA="0xF5A6CC")]
			get
			{
				return null;
			}
		}

		public string ImageMaterial
		{
			[Address(RVA="0xF5A77C", Offset="0xF5A77C", VA="0xF5A77C")]
			get
			{
				return null;
			}
		}

		public int OccasionsLength
		{
			[Address(RVA="0xF5A724", Offset="0xF5A724", VA="0xF5A724")]
			get
			{
				return new int();
			}
		}

		public int Priority
		{
			[Address(RVA="0xF5A74C", Offset="0xF5A74C", VA="0xF5A74C")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF5A734", Offset="0xF5A734", VA="0xF5A734")]
			get
			{
				return null;
			}
		}

		public bool ShowTimer
		{
			[Address(RVA="0xF5A72C", Offset="0xF5A72C", VA="0xF5A72C")]
			get
			{
				return new bool();
			}
		}

		public int StoreItemGrantHighlightsLength
		{
			[Address(RVA="0xF5A764", Offset="0xF5A764", VA="0xF5A764")]
			get
			{
				return new int();
			}
		}

		public ulong StoreItemReference
		{
			[Address(RVA="0xF5A754", Offset="0xF5A754", VA="0xF5A754")]
			get
			{
				return new ulong();
			}
		}

		public string Text
		{
			[Address(RVA="0xF5A6E4", Offset="0xF5A6E4", VA="0xF5A6E4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5A6AC", Offset="0xF5A6AC", VA="0xF5A6AC")]
		public HomeShowcase __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new HomeShowcase();
		}

		[Address(RVA="0xF5A6A0", Offset="0xF5A6A0", VA="0xF5A6A0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25157AC", Offset="0x25157AC", VA="0x25157AC")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x25156F8", Offset="0x25156F8", VA="0x25156F8")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x2515590", Offset="0x2515590", VA="0x2515590")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2515770", Offset="0x2515770", VA="0x2515770")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x25155CC", Offset="0x25155CC", VA="0x25155CC")]
		public static void AddImageMaterial(FlatBufferBuilder builder, StringOffset imageMaterialOffset)
		{
		}

		[Address(RVA="0x25156BC", Offset="0x25156BC", VA="0x25156BC")]
		public static void AddOccasions(FlatBufferBuilder builder, VectorOffset occasionsOffset)
		{
		}

		[Address(RVA="0x2515644", Offset="0x2515644", VA="0x2515644")]
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
		}

		[Address(RVA="0x2515680", Offset="0x2515680", VA="0x2515680")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x25157E8", Offset="0x25157E8", VA="0x25157E8")]
		public static void AddShowTimer(FlatBufferBuilder builder, bool showTimer)
		{
		}

		[Address(RVA="0x2515608", Offset="0x2515608", VA="0x2515608")]
		public static void AddStoreItemGrantHighlights(FlatBufferBuilder builder, VectorOffset storeItemGrantHighlightsOffset)
		{
		}

		[Address(RVA="0x2515554", Offset="0x2515554", VA="0x2515554")]
		public static void AddStoreItemReference(FlatBufferBuilder builder, ulong storeItemReference)
		{
		}

		[Address(RVA="0x2515734", Offset="0x2515734", VA="0x2515734")]
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
		}

		[Address(RVA="0x251542C", Offset="0x251542C", VA="0x251542C")]
		public static Offset<HomeShowcase> CreateHomeShowcase(FlatBufferBuilder builder, ulong id = 0L, StringOffset imageOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.HomeShowcase> Gamedata.HomeShowcase::CreateHomeShowcase(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.Boolean,FlatBuffers.StringOffset,System.Int32,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.HomeShowcase> CreateHomeShowcase(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.Boolean,FlatBuffers.StringOffset,System.Int32,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x25158D4", Offset="0x25158D4", VA="0x25158D4")]
		public static VectorOffset CreateOccasionsVector(FlatBufferBuilder builder, Offset<OccasionRef>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2515A08", Offset="0x2515A08", VA="0x2515A08")]
		public static VectorOffset CreateStoreItemGrantHighlightsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2515824", Offset="0x2515824", VA="0x2515824")]
		public static Offset<HomeShowcase> EndHomeShowcase(FlatBufferBuilder builder)
		{
			return new Offset<HomeShowcase>();
		}

		[Address(RVA="0x2515B3C", Offset="0x2515B3C", VA="0x2515B3C")]
		public static void FinishHomeShowcaseBuffer(FlatBufferBuilder builder, Offset<HomeShowcase> offset)
		{
		}

		[Address(RVA="0xF5A70C", Offset="0xF5A70C", VA="0xF5A70C")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A6D4", Offset="0xF5A6D4", VA="0xF5A6D4")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A784", Offset="0xF5A784", VA="0xF5A784")]
		public ArraySegment<byte>? GetImageMaterialBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A73C", Offset="0xF5A73C", VA="0xF5A73C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x2514D94", Offset="0x2514D94", VA="0x2514D94")]
		public static HomeShowcase GetRootAsHomeShowcase(FlatBuffers.ByteBuffer _bb)
		{
			return new HomeShowcase();
		}

		[Address(RVA="0x2514DA0", Offset="0x2514DA0", VA="0x2514DA0")]
		public static HomeShowcase GetRootAsHomeShowcase(FlatBuffers.ByteBuffer _bb, HomeShowcase obj)
		{
			return new HomeShowcase();
		}

		[Address(RVA="0xF5A76C", Offset="0xF5A76C", VA="0xF5A76C")]
		public ArraySegment<byte>? GetStoreItemGrantHighlightsBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A6EC", Offset="0xF5A6EC", VA="0xF5A6EC")]
		public ArraySegment<byte>? GetTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A71C", Offset="0xF5A71C", VA="0xF5A71C")]
		public OccasionRef? Occasions(int j)
		{
			return null;
		}

		[Address(RVA="0x25158A4", Offset="0x25158A4", VA="0x25158A4")]
		public static void StartHomeShowcase(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x25159CC", Offset="0x25159CC", VA="0x25159CC")]
		public static void StartOccasionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2515B00", Offset="0x2515B00", VA="0x2515B00")]
		public static void StartStoreItemGrantHighlightsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF5A75C", Offset="0xF5A75C", VA="0xF5A75C")]
		public ulong StoreItemGrantHighlights(int j)
		{
			return new ulong();
		}
	}
}