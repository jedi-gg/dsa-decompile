using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ContextualMessage : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BodyText
		{
			[Address(RVA="0xF59884", Offset="0xF59884", VA="0xF59884")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59828", Offset="0xF59828", VA="0xF59828", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF598B4", Offset="0xF598B4", VA="0xF598B4")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF598BC", Offset="0xF598BC", VA="0xF598BC")]
			get
			{
				return null;
			}
		}

		public string PointAtId
		{
			[Address(RVA="0xF5989C", Offset="0xF5989C", VA="0xF5989C")]
			get
			{
				return null;
			}
		}

		public bool PointAtTapAnywhere
		{
			[Address(RVA="0xF598D4", Offset="0xF598D4", VA="0xF598D4")]
			get
			{
				return new bool();
			}
		}

		public SeekerPointAt? SeekerData
		{
			[Address(RVA="0xF598EC", Offset="0xF598EC", VA="0xF598EC")]
			get
			{
				return null;
			}
		}

		public string TitleText
		{
			[Address(RVA="0xF5986C", Offset="0xF5986C", VA="0xF5986C")]
			get
			{
				return null;
			}
		}

		public ContextualMessageType Type
		{
			[Address(RVA="0xF59854", Offset="0xF59854", VA="0xF59854")]
			get
			{
				return new ContextualMessageType();
			}
		}

		public int ViewHiddenTriggersLength
		{
			[Address(RVA="0xF598E4", Offset="0xF598E4", VA="0xF598E4")]
			get
			{
				return new int();
			}
		}

		public int ViewTriggersLength
		{
			[Address(RVA="0xF59864", Offset="0xF59864", VA="0xF59864")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5983C", Offset="0xF5983C", VA="0xF5983C")]
		public ContextualMessage __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ContextualMessage();
		}

		[Address(RVA="0xF59830", Offset="0xF59830", VA="0xF59830", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250BF50", Offset="0x250BF50", VA="0x250BF50")]
		public static void AddBodyText(FlatBufferBuilder builder, StringOffset bodyTextOffset)
		{
		}

		[Address(RVA="0x250C004", Offset="0x250C004", VA="0x250C004")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x250BED8", Offset="0x250BED8", VA="0x250BED8")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x250BF14", Offset="0x250BF14", VA="0x250BF14")]
		public static void AddPointAtId(FlatBufferBuilder builder, StringOffset pointAtIdOffset)
		{
		}

		[Address(RVA="0x250C040", Offset="0x250C040", VA="0x250C040")]
		public static void AddPointAtTapAnywhere(FlatBufferBuilder builder, bool pointAtTapAnywhere)
		{
		}

		[Address(RVA="0x250BE60", Offset="0x250BE60", VA="0x250BE60")]
		public static void AddSeekerData(FlatBufferBuilder builder, Offset<SeekerPointAt> seekerDataOffset)
		{
		}

		[Address(RVA="0x250BF8C", Offset="0x250BF8C", VA="0x250BF8C")]
		public static void AddTitleText(FlatBufferBuilder builder, StringOffset titleTextOffset)
		{
		}

		[Address(RVA="0x250C07C", Offset="0x250C07C", VA="0x250C07C")]
		public static void AddType(FlatBufferBuilder builder, ContextualMessageType type)
		{
		}

		[Address(RVA="0x250BE9C", Offset="0x250BE9C", VA="0x250BE9C")]
		public static void AddViewHiddenTriggers(FlatBufferBuilder builder, VectorOffset viewHiddenTriggersOffset)
		{
		}

		[Address(RVA="0x250BFC8", Offset="0x250BFC8", VA="0x250BFC8")]
		public static void AddViewTriggers(FlatBufferBuilder builder, VectorOffset viewTriggersOffset)
		{
		}

		[Address(RVA="0x250BD5C", Offset="0x250BD5C", VA="0x250BD5C")]
		public static Offset<ContextualMessage> CreateContextualMessage(FlatBufferBuilder builder, ContextualMessageType type = 0, VectorOffset view_triggersOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ContextualMessage> Gamedata.ContextualMessage::CreateContextualMessage(FlatBuffers.FlatBufferBuilder,Gamedata.ContextualMessageType,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,FlatBuffers.Offset`1<Gamedata.SeekerPointAt>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ContextualMessage> CreateContextualMessage(FlatBuffers.FlatBufferBuilder,Gamedata.ContextualMessageType,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,FlatBuffers.Offset<Gamedata.SeekerPointAt>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250C29C", Offset="0x250C29C", VA="0x250C29C")]
		public static VectorOffset CreateViewHiddenTriggersVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x250C168", Offset="0x250C168", VA="0x250C168")]
		public static VectorOffset CreateViewTriggersVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x250C0B8", Offset="0x250C0B8", VA="0x250C0B8")]
		public static Offset<ContextualMessage> EndContextualMessage(FlatBufferBuilder builder)
		{
			return new Offset<ContextualMessage>();
		}

		[Address(RVA="0xF5988C", Offset="0xF5988C", VA="0xF5988C")]
		public ArraySegment<byte>? GetBodyTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF598C4", Offset="0xF598C4", VA="0xF598C4")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF598A4", Offset="0xF598A4", VA="0xF598A4")]
		public ArraySegment<byte>? GetPointAtIdBytes()
		{
			return null;
		}

		[Address(RVA="0x250B7D4", Offset="0x250B7D4", VA="0x250B7D4")]
		public static ContextualMessage GetRootAsContextualMessage(FlatBuffers.ByteBuffer _bb)
		{
			return new ContextualMessage();
		}

		[Address(RVA="0x250B7E0", Offset="0x250B7E0", VA="0x250B7E0")]
		public static ContextualMessage GetRootAsContextualMessage(FlatBuffers.ByteBuffer _bb, ContextualMessage obj)
		{
			return new ContextualMessage();
		}

		[Address(RVA="0xF59874", Offset="0xF59874", VA="0xF59874")]
		public ArraySegment<byte>? GetTitleTextBytes()
		{
			return null;
		}

		[Address(RVA="0x250C138", Offset="0x250C138", VA="0x250C138")]
		public static void StartContextualMessage(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x250C394", Offset="0x250C394", VA="0x250C394")]
		public static void StartViewHiddenTriggersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x250C260", Offset="0x250C260", VA="0x250C260")]
		public static void StartViewTriggersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF598DC", Offset="0xF598DC", VA="0xF598DC")]
		public string ViewHiddenTriggers(int j)
		{
			return null;
		}

		[Address(RVA="0xF5985C", Offset="0xF5985C", VA="0xF5985C")]
		public string ViewTriggers(int j)
		{
			return null;
		}
	}
}