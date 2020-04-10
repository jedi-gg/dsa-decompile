using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SeekerPointAt : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public RectTransformAlignment? Anchor
		{
			[Address(RVA="0xF589FC", Offset="0xF589FC", VA="0xF589FC")]
			get
			{
				return null;
			}
		}

		public string Animation
		{
			[Address(RVA="0xF589B4", Offset="0xF589B4", VA="0xF589B4")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58980", Offset="0xF58980", VA="0xF58980", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool Enabled
		{
			[Address(RVA="0xF589AC", Offset="0xF589AC", VA="0xF589AC")]
			get
			{
				return new bool();
			}
		}

		public RectTransformAlignment? Pivot
		{
			[Address(RVA="0xF58A04", Offset="0xF58A04", VA="0xF58A04")]
			get
			{
				return null;
			}
		}

		public string PointAtId
		{
			[Address(RVA="0xF589E4", Offset="0xF589E4", VA="0xF589E4")]
			get
			{
				return null;
			}
		}

		public string PointAtView
		{
			[Address(RVA="0xF589CC", Offset="0xF589CC", VA="0xF589CC")]
			get
			{
				return null;
			}
		}

		public RectTransformOffset? PositionOffset
		{
			[Address(RVA="0xF58A0C", Offset="0xF58A0C", VA="0xF58A0C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF58994", Offset="0xF58994", VA="0xF58994")]
		public SeekerPointAt __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SeekerPointAt();
		}

		[Address(RVA="0xF58988", Offset="0xF58988", VA="0xF58988", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E83A0", Offset="0x24E83A0", VA="0x24E83A0")]
		public static void AddAnchor(FlatBufferBuilder builder, Offset<RectTransformAlignment> anchorOffset)
		{
		}

		[Address(RVA="0x24E8454", Offset="0x24E8454", VA="0x24E8454")]
		public static void AddAnimation(FlatBufferBuilder builder, StringOffset animationOffset)
		{
		}

		[Address(RVA="0x24E8490", Offset="0x24E8490", VA="0x24E8490")]
		public static void AddEnabled(FlatBufferBuilder builder, bool enabled)
		{
		}

		[Address(RVA="0x24E8364", Offset="0x24E8364", VA="0x24E8364")]
		public static void AddPivot(FlatBufferBuilder builder, Offset<RectTransformAlignment> pivotOffset)
		{
		}

		[Address(RVA="0x24E83DC", Offset="0x24E83DC", VA="0x24E83DC")]
		public static void AddPointAtId(FlatBufferBuilder builder, StringOffset pointAtIdOffset)
		{
		}

		[Address(RVA="0x24E8418", Offset="0x24E8418", VA="0x24E8418")]
		public static void AddPointAtView(FlatBufferBuilder builder, StringOffset pointAtViewOffset)
		{
		}

		[Address(RVA="0x24E8328", Offset="0x24E8328", VA="0x24E8328")]
		public static void AddPositionOffset(FlatBufferBuilder builder, Offset<RectTransformOffset> positionOffsetOffset)
		{
		}

		[Address(RVA="0x24E8260", Offset="0x24E8260", VA="0x24E8260")]
		public static Offset<SeekerPointAt> CreateSeekerPointAt(FlatBufferBuilder builder, bool enabled = false, StringOffset animationOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SeekerPointAt> Gamedata.SeekerPointAt::CreateSeekerPointAt(FlatBuffers.FlatBufferBuilder,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.RectTransformAlignment>,FlatBuffers.Offset`1<Gamedata.RectTransformAlignment>,FlatBuffers.Offset`1<Gamedata.RectTransformOffset>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SeekerPointAt> CreateSeekerPointAt(FlatBuffers.FlatBufferBuilder,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.RectTransformAlignment>,FlatBuffers.Offset<Gamedata.RectTransformAlignment>,FlatBuffers.Offset<Gamedata.RectTransformOffset>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E84CC", Offset="0x24E84CC", VA="0x24E84CC")]
		public static Offset<SeekerPointAt> EndSeekerPointAt(FlatBufferBuilder builder)
		{
			return new Offset<SeekerPointAt>();
		}

		[Address(RVA="0xF589BC", Offset="0xF589BC", VA="0xF589BC")]
		public ArraySegment<byte>? GetAnimationBytes()
		{
			return null;
		}

		[Address(RVA="0xF589EC", Offset="0xF589EC", VA="0xF589EC")]
		public ArraySegment<byte>? GetPointAtIdBytes()
		{
			return null;
		}

		[Address(RVA="0xF589D4", Offset="0xF589D4", VA="0xF589D4")]
		public ArraySegment<byte>? GetPointAtViewBytes()
		{
			return null;
		}

		[Address(RVA="0x24E7E1C", Offset="0x24E7E1C", VA="0x24E7E1C")]
		public static SeekerPointAt GetRootAsSeekerPointAt(FlatBuffers.ByteBuffer _bb)
		{
			return new SeekerPointAt();
		}

		[Address(RVA="0x24E7E28", Offset="0x24E7E28", VA="0x24E7E28")]
		public static SeekerPointAt GetRootAsSeekerPointAt(FlatBuffers.ByteBuffer _bb, SeekerPointAt obj)
		{
			return new SeekerPointAt();
		}

		[Address(RVA="0x24E854C", Offset="0x24E854C", VA="0x24E854C")]
		public static void StartSeekerPointAt(FlatBufferBuilder builder)
		{
		}
	}
}