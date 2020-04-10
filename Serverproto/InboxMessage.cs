using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMessage : IMessage<InboxMessage>, IMessage, IEquatable<InboxMessage>, IDeepCloneable<InboxMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int SentTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong sentTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ExpiryTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong expiryTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int BodyKeyFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string bodyKey_;

		[FieldOffset(Offset="0x0")]
		public const int SenderKeyFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string senderKey_;

		[FieldOffset(Offset="0x0")]
		public const int SubjectKeyFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string subjectKey_;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private InboxMessageStatus status_;

		[FieldOffset(Offset="0x0")]
		public const int AttachmentsFieldNumber = 8;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<InventoryItem> _repeated_attachments_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<InventoryItem> attachments_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkLocationFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong deepLinkLocation_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkSublocationFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private string deepLinkSublocation_;

		[FieldOffset(Offset="0x0")]
		public const int TemplateIdFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private ulong templateId_;

		[FieldOffset(Offset="0x0")]
		public const int AdditionalParametersFieldNumber = 12;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<string> _repeated_additionalParameters_codec;

		[FieldOffset(Offset="0x70")]
		private readonly RepeatedField<string> additionalParameters_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A960", Offset="0x109A960")]
		public RepeatedField<string> AdditionalParameters
		{
			[Address(RVA="0x18DEB38", Offset="0x18DEB38", VA="0x18DEB38")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A920", Offset="0x109A920")]
		public RepeatedField<InventoryItem> Attachments
		{
			[Address(RVA="0x18DEA98", Offset="0x18DEA98", VA="0x18DEA98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A8E0", Offset="0x109A8E0")]
		public string BodyKey
		{
			[Address(RVA="0x18DE920", Offset="0x18DE920", VA="0x18DE920")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DE928", Offset="0x18DE928", VA="0x18DE928")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A930", Offset="0x109A930")]
		public ulong DeepLinkLocation
		{
			[Address(RVA="0x18DEAA0", Offset="0x18DEAA0", VA="0x18DEAA0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18DEAA8", Offset="0x18DEAA8", VA="0x18DEAA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A940", Offset="0x109A940")]
		public string DeepLinkSublocation
		{
			[Address(RVA="0x18DEAB0", Offset="0x18DEAB0", VA="0x18DEAB0")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DEAB8", Offset="0x18DEAB8", VA="0x18DEAB8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A890", Offset="0x109A890")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DE47C", Offset="0x18DE47C", VA="0x18DE47C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A8D0", Offset="0x109A8D0")]
		public ulong ExpiryTimestamp
		{
			[Address(RVA="0x18DE910", Offset="0x18DE910", VA="0x18DE910")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18DE918", Offset="0x18DE918", VA="0x18DE918")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A8B0", Offset="0x109A8B0")]
		public string Id
		{
			[Address(RVA="0x18DE888", Offset="0x18DE888", VA="0x18DE888")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DE890", Offset="0x18DE890", VA="0x18DE890")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A880", Offset="0x109A880")]
		public static MessageParser<InboxMessage> Parser
		{
			[Address(RVA="0x18DE414", Offset="0x18DE414", VA="0x18DE414")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A8A0", Offset="0x109A8A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DE56C", Offset="0x18DE56C", VA="0x18DE56C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A8F0", Offset="0x109A8F0")]
		public string SenderKey
		{
			[Address(RVA="0x18DE998", Offset="0x18DE998", VA="0x18DE998")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DE9A0", Offset="0x18DE9A0", VA="0x18DE9A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A8C0", Offset="0x109A8C0")]
		public ulong SentTimestamp
		{
			[Address(RVA="0x18DE900", Offset="0x18DE900", VA="0x18DE900")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18DE908", Offset="0x18DE908", VA="0x18DE908")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A910", Offset="0x109A910")]
		public InboxMessageStatus Status
		{
			[Address(RVA="0x18DEA88", Offset="0x18DEA88", VA="0x18DEA88")]
			get
			{
				return new InboxMessageStatus();
			}
			[Address(RVA="0x18DEA90", Offset="0x18DEA90", VA="0x18DEA90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A900", Offset="0x109A900")]
		public string SubjectKey
		{
			[Address(RVA="0x18DEA10", Offset="0x18DEA10", VA="0x18DEA10")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DEA18", Offset="0x18DEA18", VA="0x18DEA18")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A950", Offset="0x109A950")]
		public ulong TemplateId
		{
			[Address(RVA="0x18DEB28", Offset="0x18DEB28", VA="0x18DEB28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18DEB30", Offset="0x18DEB30", VA="0x18DEB30")]
			set
			{
			}
		}

		[Address(RVA="0x18DFE0C", Offset="0x18DFE0C", VA="0x18DFE0C")]
		static InboxMessage()
		{
		}

		[Address(RVA="0x18DE5C8", Offset="0x18DE5C8", VA="0x18DE5C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E2C", Offset="0x1084E2C")]
		public InboxMessage()
		{
		}

		[Address(RVA="0x18DE688", Offset="0x18DE688", VA="0x18DE688")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E3C", Offset="0x1084E3C")]
		public InboxMessage(InboxMessage other)
		{
		}

		[Address(RVA="0x18DF538", Offset="0x18DF538", VA="0x18DF538", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084EAC", Offset="0x1084EAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DE828", Offset="0x18DE828", VA="0x18DE828", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E4C", Offset="0x1084E4C")]
		public InboxMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x18DEB40", Offset="0x18DEB40", VA="0x18DEB40", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E5C", Offset="0x1084E5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DEBB4", Offset="0x18DEBB4", VA="0x18DEBB4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E6C", Offset="0x1084E6C")]
		public bool Equals(InboxMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x18DED48", Offset="0x18DED48", VA="0x18DED48", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E7C", Offset="0x1084E7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DF934", Offset="0x18DF934", VA="0x18DF934", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084EBC", Offset="0x1084EBC")]
		public void MergeFrom(InboxMessage other)
		{
		}

		[Address(RVA="0x18DFB08", Offset="0x18DFB08", VA="0x18DFB08", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084ECC", Offset="0x1084ECC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DEFC8", Offset="0x18DEFC8", VA="0x18DEFC8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E8C", Offset="0x1084E8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DF030", Offset="0x18DF030", VA="0x18DF030", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E9C", Offset="0x1084E9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10505A8", Offset="0x10505A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMessage.<>c <>9;

			[Address(RVA="0x18DFF48", Offset="0x18DFF48", VA="0x18DFF48")]
			static <>c()
			{
			}

			[Address(RVA="0x18DFFAC", Offset="0x18DFFAC", VA="0x18DFFAC")]
			public <>c()
			{
			}

			[Address(RVA="0x18DFFB4", Offset="0x18DFFB4", VA="0x18DFFB4")]
			internal InboxMessage <.cctor>b__80_0()
			{
				return null;
			}
		}
	}
}