using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ContextualMessageGroup : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string AutoCompleteRequirement
		{
			[Address(RVA="0xF5998C", Offset="0xF5998C", VA="0xF5998C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59940", Offset="0xF59940", VA="0xF59940", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong DisplayConditionContentId
		{
			[Address(RVA="0xF599AC", Offset="0xF599AC", VA="0xF599AC")]
			get
			{
				return new ulong();
			}
		}

		public ContextualMessageDisplayConditionType DisplayConditionType
		{
			[Address(RVA="0xF599A4", Offset="0xF599A4", VA="0xF599A4")]
			get
			{
				return new ContextualMessageDisplayConditionType();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5996C", Offset="0xF5996C", VA="0xF5996C")]
			get
			{
				return new ulong();
			}
		}

		public int MessagesLength
		{
			[Address(RVA="0xF599C4", Offset="0xF599C4", VA="0xF599C4")]
			get
			{
				return new int();
			}
		}

		public int Priority
		{
			[Address(RVA="0xF599B4", Offset="0xF599B4", VA="0xF599B4")]
			get
			{
				return new int();
			}
		}

		public bool ResetsUntilAutoCompleted
		{
			[Address(RVA="0xF599CC", Offset="0xF599CC", VA="0xF599CC")]
			get
			{
				return new bool();
			}
		}

		public string UnlockRequirement
		{
			[Address(RVA="0xF59974", Offset="0xF59974", VA="0xF59974")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF59954", Offset="0xF59954", VA="0xF59954")]
		public ContextualMessageGroup __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ContextualMessageGroup();
		}

		[Address(RVA="0xF59948", Offset="0xF59948", VA="0xF59948", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250CA40", Offset="0x250CA40", VA="0x250CA40")]
		public static void AddAutoCompleteRequirement(FlatBufferBuilder builder, StringOffset autoCompleteRequirementOffset)
		{
		}

		[Address(RVA="0x250C950", Offset="0x250C950", VA="0x250C950")]
		public static void AddDisplayConditionContentId(FlatBufferBuilder builder, ulong displayConditionContentId)
		{
		}

		[Address(RVA="0x250CAF4", Offset="0x250CAF4", VA="0x250CAF4")]
		public static void AddDisplayConditionType(FlatBufferBuilder builder, ContextualMessageDisplayConditionType displayConditionType)
		{
		}

		[Address(RVA="0x250C98C", Offset="0x250C98C", VA="0x250C98C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x250C9C8", Offset="0x250C9C8", VA="0x250C9C8")]
		public static void AddMessages(FlatBufferBuilder builder, VectorOffset messagesOffset)
		{
		}

		[Address(RVA="0x250CA04", Offset="0x250CA04", VA="0x250CA04")]
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
		}

		[Address(RVA="0x250CAB8", Offset="0x250CAB8", VA="0x250CAB8")]
		public static void AddResetsUntilAutoCompleted(FlatBufferBuilder builder, bool resetsUntilAutoCompleted)
		{
		}

		[Address(RVA="0x250CA7C", Offset="0x250CA7C", VA="0x250CA7C")]
		public static void AddUnlockRequirement(FlatBufferBuilder builder, StringOffset unlockRequirementOffset)
		{
		}

		[Address(RVA="0x250C870", Offset="0x250C870", VA="0x250C870")]
		public static Offset<ContextualMessageGroup> CreateContextualMessageGroup(FlatBufferBuilder builder, ulong id = 0L, StringOffset unlock_requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ContextualMessageGroup> Gamedata.ContextualMessageGroup::CreateContextualMessageGroup(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.ContextualMessageDisplayConditionType,System.UInt64,System.Int32,FlatBuffers.VectorOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ContextualMessageGroup> CreateContextualMessageGroup(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.ContextualMessageDisplayConditionType,System.UInt64,System.Int32,FlatBuffers.VectorOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250CBE0", Offset="0x250CBE0", VA="0x250CBE0")]
		public static VectorOffset CreateMessagesVector(FlatBufferBuilder builder, Offset<ContextualMessage>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x250CB30", Offset="0x250CB30", VA="0x250CB30")]
		public static Offset<ContextualMessageGroup> EndContextualMessageGroup(FlatBufferBuilder builder)
		{
			return new Offset<ContextualMessageGroup>();
		}

		[Address(RVA="0x250CD14", Offset="0x250CD14", VA="0x250CD14")]
		public static void FinishContextualMessageGroupBuffer(FlatBufferBuilder builder, Offset<ContextualMessageGroup> offset)
		{
		}

		[Address(RVA="0xF59994", Offset="0xF59994", VA="0xF59994")]
		public ArraySegment<byte>? GetAutoCompleteRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x250C3D8", Offset="0x250C3D8", VA="0x250C3D8")]
		public static ContextualMessageGroup GetRootAsContextualMessageGroup(FlatBuffers.ByteBuffer _bb)
		{
			return new ContextualMessageGroup();
		}

		[Address(RVA="0x250C3E4", Offset="0x250C3E4", VA="0x250C3E4")]
		public static ContextualMessageGroup GetRootAsContextualMessageGroup(FlatBuffers.ByteBuffer _bb, ContextualMessageGroup obj)
		{
			return new ContextualMessageGroup();
		}

		[Address(RVA="0xF5997C", Offset="0xF5997C", VA="0xF5997C")]
		public ArraySegment<byte>? GetUnlockRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0xF599BC", Offset="0xF599BC", VA="0xF599BC")]
		public ContextualMessage? Messages(int j)
		{
			return null;
		}

		[Address(RVA="0x250CBB0", Offset="0x250CBB0", VA="0x250CBB0")]
		public static void StartContextualMessageGroup(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x250CCD8", Offset="0x250CCD8", VA="0x250CCD8")]
		public static void StartMessagesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}