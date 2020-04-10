using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct InboxMessage : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int AttachmentsLength
		{
			[Address(RVA="0xF5A864", Offset="0xF5A864", VA="0xF5A864")]
			get
			{
				return new int();
			}
		}

		public string BodyKey
		{
			[Address(RVA="0xF5A844", Offset="0xF5A844", VA="0xF5A844")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A7E0", Offset="0xF5A7E0", VA="0xF5A7E0", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF5A874", Offset="0xF5A874", VA="0xF5A874")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF5A87C", Offset="0xF5A87C", VA="0xF5A87C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5A80C", Offset="0xF5A80C", VA="0xF5A80C")]
			get
			{
				return new ulong();
			}
		}

		public bool IsInAdminTool
		{
			[Address(RVA="0xF5A894", Offset="0xF5A894", VA="0xF5A894")]
			get
			{
				return new bool();
			}
		}

		public uint LifespanSeconds
		{
			[Address(RVA="0xF5A86C", Offset="0xF5A86C", VA="0xF5A86C")]
			get
			{
				return new uint();
			}
		}

		public OccasionRef? Occasion
		{
			[Address(RVA="0xF5A8B4", Offset="0xF5A8B4", VA="0xF5A8B4")]
			get
			{
				return null;
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF5A89C", Offset="0xF5A89C", VA="0xF5A89C")]
			get
			{
				return null;
			}
		}

		public bool RequirementTriggeredMessage
		{
			[Address(RVA="0xF5A8C4", Offset="0xF5A8C4", VA="0xF5A8C4")]
			get
			{
				return new bool();
			}
		}

		public bool ScheduledMessage
		{
			[Address(RVA="0xF5A8BC", Offset="0xF5A8BC", VA="0xF5A8BC")]
			get
			{
				return new bool();
			}
		}

		public string SenderKey
		{
			[Address(RVA="0xF5A814", Offset="0xF5A814", VA="0xF5A814")]
			get
			{
				return null;
			}
		}

		public string SubjectKey
		{
			[Address(RVA="0xF5A82C", Offset="0xF5A82C", VA="0xF5A82C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5A7F4", Offset="0xF5A7F4", VA="0xF5A7F4")]
		public InboxMessage __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new InboxMessage();
		}

		[Address(RVA="0xF5A7E8", Offset="0xF5A7E8", VA="0xF5A7E8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25164D4", Offset="0x25164D4", VA="0x25164D4")]
		public static void AddAttachments(FlatBufferBuilder builder, VectorOffset attachmentsOffset)
		{
		}

		[Address(RVA="0x2516510", Offset="0x2516510", VA="0x2516510")]
		public static void AddBodyKey(FlatBufferBuilder builder, StringOffset bodyKeyOffset)
		{
		}

		[Address(RVA="0x25165C4", Offset="0x25165C4", VA="0x25165C4")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x251645C", Offset="0x251645C", VA="0x251645C")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x25163A8", Offset="0x25163A8", VA="0x25163A8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2516678", Offset="0x2516678", VA="0x2516678")]
		public static void AddIsInAdminTool(FlatBufferBuilder builder, bool isInAdminTool)
		{
		}

		[Address(RVA="0x2516498", Offset="0x2516498", VA="0x2516498")]
		public static void AddLifespanSeconds(FlatBufferBuilder builder, uint lifespanSeconds)
		{
		}

		[Address(RVA="0x25163E4", Offset="0x25163E4", VA="0x25163E4")]
		public static void AddOccasion(FlatBufferBuilder builder, Offset<OccasionRef> occasionOffset)
		{
		}

		[Address(RVA="0x2516420", Offset="0x2516420", VA="0x2516420")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x2516600", Offset="0x2516600", VA="0x2516600")]
		public static void AddRequirementTriggeredMessage(FlatBufferBuilder builder, bool requirementTriggeredMessage)
		{
		}

		[Address(RVA="0x251663C", Offset="0x251663C", VA="0x251663C")]
		public static void AddScheduledMessage(FlatBufferBuilder builder, bool scheduledMessage)
		{
		}

		[Address(RVA="0x2516588", Offset="0x2516588", VA="0x2516588")]
		public static void AddSenderKey(FlatBufferBuilder builder, StringOffset senderKeyOffset)
		{
		}

		[Address(RVA="0x251654C", Offset="0x251654C", VA="0x251654C")]
		public static void AddSubjectKey(FlatBufferBuilder builder, StringOffset subjectKeyOffset)
		{
		}

		[Address(RVA="0xF5A85C", Offset="0xF5A85C", VA="0xF5A85C")]
		public InboxMessageAttachment? Attachments(int j)
		{
			return null;
		}

		[Address(RVA="0x2516764", Offset="0x2516764", VA="0x2516764")]
		public static VectorOffset CreateAttachmentsVector(FlatBufferBuilder builder, Offset<InboxMessageAttachment>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x251625C", Offset="0x251625C", VA="0x251625C")]
		public static Offset<InboxMessage> CreateInboxMessage(FlatBufferBuilder builder, ulong id = 0L, StringOffset sender_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.InboxMessage> Gamedata.InboxMessage::CreateInboxMessage(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt32,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.OccasionRef>,System.Boolean,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.InboxMessage> CreateInboxMessage(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt32,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.OccasionRef>,System.Boolean,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x25166B4", Offset="0x25166B4", VA="0x25166B4")]
		public static Offset<InboxMessage> EndInboxMessage(FlatBufferBuilder builder)
		{
			return new Offset<InboxMessage>();
		}

		[Address(RVA="0x2516898", Offset="0x2516898", VA="0x2516898")]
		public static void FinishInboxMessageBuffer(FlatBufferBuilder builder, Offset<InboxMessage> offset)
		{
		}

		[Address(RVA="0xF5A84C", Offset="0xF5A84C", VA="0xF5A84C")]
		public ArraySegment<byte>? GetBodyKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A884", Offset="0xF5A884", VA="0xF5A884")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A8A4", Offset="0xF5A8A4", VA="0xF5A8A4")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x2515B78", Offset="0x2515B78", VA="0x2515B78")]
		public static InboxMessage GetRootAsInboxMessage(FlatBuffers.ByteBuffer _bb)
		{
			return new InboxMessage();
		}

		[Address(RVA="0x2515B84", Offset="0x2515B84", VA="0x2515B84")]
		public static InboxMessage GetRootAsInboxMessage(FlatBuffers.ByteBuffer _bb, InboxMessage obj)
		{
			return new InboxMessage();
		}

		[Address(RVA="0xF5A81C", Offset="0xF5A81C", VA="0xF5A81C")]
		public ArraySegment<byte>? GetSenderKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A834", Offset="0xF5A834", VA="0xF5A834")]
		public ArraySegment<byte>? GetSubjectKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x251685C", Offset="0x251685C", VA="0x251685C")]
		public static void StartAttachmentsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2516734", Offset="0x2516734", VA="0x2516734")]
		public static void StartInboxMessage(FlatBufferBuilder builder)
		{
		}
	}
}