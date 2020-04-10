using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InfoEvent : IMessage<InfoEvent>, IMessage, IEquatable<InfoEvent>, IDeepCloneable<InfoEvent>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InfoEvent> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong contentId_;

		[FieldOffset(Offset="0x0")]
		public const int EventGroupIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong eventGroupId_;

		[FieldOffset(Offset="0x0")]
		public const int BeginTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong beginTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int EndTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong endTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int ImageFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string image_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private long sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int PreviewTextFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private string previewText_;

		[FieldOffset(Offset="0x0")]
		public const int BannerImageFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private string bannerImage_;

		[FieldOffset(Offset="0x0")]
		public const int BannerTextFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private string bannerText_;

		[FieldOffset(Offset="0x0")]
		public const int ShowcaseItemsFieldNumber = 12;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_showcaseItems_codec;

		[FieldOffset(Offset="0x70")]
		private readonly RepeatedField<ulong> showcaseItems_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkLocationFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private ulong deepLinkLocation_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkSublocationFieldNumber = 14;

		[FieldOffset(Offset="0x80")]
		private string deepLinkSublocation_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097178", Offset="0x1097178")]
		public string BannerImage
		{
			[Address(RVA="0x18E2468", Offset="0x18E2468", VA="0x18E2468")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E2470", Offset="0x18E2470", VA="0x18E2470")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097188", Offset="0x1097188")]
		public string BannerText
		{
			[Address(RVA="0x18E24E0", Offset="0x18E24E0", VA="0x18E24E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E24E8", Offset="0x18E24E8", VA="0x18E24E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097108", Offset="0x1097108")]
		public ulong BeginTimestamp
		{
			[Address(RVA="0x18E2258", Offset="0x18E2258", VA="0x18E2258")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E2260", Offset="0x18E2260", VA="0x18E2260")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10970E8", Offset="0x10970E8")]
		public ulong ContentId
		{
			[Address(RVA="0x18E2238", Offset="0x18E2238", VA="0x18E2238")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E2240", Offset="0x18E2240", VA="0x18E2240")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10971A8", Offset="0x10971A8")]
		public ulong DeepLinkLocation
		{
			[Address(RVA="0x18E2560", Offset="0x18E2560", VA="0x18E2560")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E2568", Offset="0x18E2568", VA="0x18E2568")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10971B8", Offset="0x10971B8")]
		public string DeepLinkSublocation
		{
			[Address(RVA="0x18E2570", Offset="0x18E2570", VA="0x18E2570")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E2578", Offset="0x18E2578", VA="0x18E2578")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097138", Offset="0x1097138")]
		public string Description
		{
			[Address(RVA="0x18E22F0", Offset="0x18E22F0", VA="0x18E22F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E22F8", Offset="0x18E22F8", VA="0x18E22F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10970C8", Offset="0x10970C8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E1E10", Offset="0x18E1E10", VA="0x18E1E10")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097118", Offset="0x1097118")]
		public ulong EndTimestamp
		{
			[Address(RVA="0x18E2268", Offset="0x18E2268", VA="0x18E2268")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E2270", Offset="0x18E2270", VA="0x18E2270")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10970F8", Offset="0x10970F8")]
		public ulong EventGroupId
		{
			[Address(RVA="0x18E2248", Offset="0x18E2248", VA="0x18E2248")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E2250", Offset="0x18E2250", VA="0x18E2250")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097148", Offset="0x1097148")]
		public string Image
		{
			[Address(RVA="0x18E2368", Offset="0x18E2368", VA="0x18E2368")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E2370", Offset="0x18E2370", VA="0x18E2370")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097128", Offset="0x1097128")]
		public string Name
		{
			[Address(RVA="0x18E2278", Offset="0x18E2278", VA="0x18E2278")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E2280", Offset="0x18E2280", VA="0x18E2280")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10970B8", Offset="0x10970B8")]
		public static MessageParser<InfoEvent> Parser
		{
			[Address(RVA="0x18E1DA8", Offset="0x18E1DA8", VA="0x18E1DA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10970D8", Offset="0x10970D8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E1F00", Offset="0x18E1F00", VA="0x18E1F00", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097168", Offset="0x1097168")]
		public string PreviewText
		{
			[Address(RVA="0x18E23F0", Offset="0x18E23F0", VA="0x18E23F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E23F8", Offset="0x18E23F8", VA="0x18E23F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097198", Offset="0x1097198")]
		public RepeatedField<ulong> ShowcaseItems
		{
			[Address(RVA="0x18E2558", Offset="0x18E2558", VA="0x18E2558")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097158", Offset="0x1097158")]
		public long SortOrder
		{
			[Address(RVA="0x18E23E0", Offset="0x18E23E0", VA="0x18E23E0")]
			get
			{
				return new long();
			}
			[Address(RVA="0x18E23E8", Offset="0x18E23E8", VA="0x18E23E8")]
			set
			{
			}
		}

		[Address(RVA="0x18E3B34", Offset="0x18E3B34", VA="0x18E3B34")]
		static InfoEvent()
		{
		}

		[Address(RVA="0x18E1F5C", Offset="0x18E1F5C", VA="0x18E1F5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F69C", Offset="0x107F69C")]
		public InfoEvent()
		{
		}

		[Address(RVA="0x18E1FF8", Offset="0x18E1FF8", VA="0x18E1FF8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F6AC", Offset="0x107F6AC")]
		public InfoEvent(InfoEvent other)
		{
		}

		[Address(RVA="0x18E3144", Offset="0x18E3144", VA="0x18E3144", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F71C", Offset="0x107F71C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E21D8", Offset="0x18E21D8", VA="0x18E21D8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F6BC", Offset="0x107F6BC")]
		public InfoEvent Clone()
		{
			return null;
		}

		[Address(RVA="0x18E25E8", Offset="0x18E25E8", VA="0x18E25E8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F6CC", Offset="0x107F6CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E265C", Offset="0x18E265C", VA="0x18E265C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F6DC", Offset="0x107F6DC")]
		public bool Equals(InfoEvent other)
		{
			return new bool();
		}

		[Address(RVA="0x18E27FC", Offset="0x18E27FC", VA="0x18E27FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F6EC", Offset="0x107F6EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E35D0", Offset="0x18E35D0", VA="0x18E35D0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F72C", Offset="0x107F72C")]
		public void MergeFrom(InfoEvent other)
		{
		}

		[Address(RVA="0x18E37DC", Offset="0x18E37DC", VA="0x18E37DC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F73C", Offset="0x107F73C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E2AF8", Offset="0x18E2AF8", VA="0x18E2AF8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F6FC", Offset="0x107F6FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E2B60", Offset="0x18E2B60", VA="0x18E2B60", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F70C", Offset="0x107F70C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FDB8", Offset="0x104FDB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InfoEvent.<>c <>9;

			[Address(RVA="0x18E3C24", Offset="0x18E3C24", VA="0x18E3C24")]
			static <>c()
			{
			}

			[Address(RVA="0x18E3C88", Offset="0x18E3C88", VA="0x18E3C88")]
			public <>c()
			{
			}

			[Address(RVA="0x18E3C90", Offset="0x18E3C90", VA="0x18E3C90")]
			internal InfoEvent <.cctor>b__90_0()
			{
				return null;
			}
		}
	}
}