using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventGroup : IMessage<EventGroup>, IMessage, IEquatable<EventGroup>, IDeepCloneable<EventGroup>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventGroup> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong contentId_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int ImageFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string image_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private long sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int ShowcaseItemsFieldNumber = 6;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_showcaseItems_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<ulong> showcaseItems_;

		[FieldOffset(Offset="0x0")]
		public const int MarqueeImageFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string marqueeImage_;

		[FieldOffset(Offset="0x0")]
		public const int DisableTimerFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private bool disableTimer_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097338", Offset="0x1097338")]
		public ulong ContentId
		{
			[Address(RVA="0x1FCD9A0", Offset="0x1FCD9A0", VA="0x1FCD9A0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCD9A8", Offset="0x1FCD9A8", VA="0x1FCD9A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097358", Offset="0x1097358")]
		public string Description
		{
			[Address(RVA="0x1FCDA28", Offset="0x1FCDA28", VA="0x1FCDA28")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCDA30", Offset="0x1FCDA30", VA="0x1FCDA30")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097318", Offset="0x1097318")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCD630", Offset="0x1FCD630", VA="0x1FCD630")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10973A8", Offset="0x10973A8")]
		public bool DisableTimer
		{
			[Address(RVA="0x1FCDBA8", Offset="0x1FCDBA8", VA="0x1FCDBA8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FCDBB0", Offset="0x1FCDBB0", VA="0x1FCDBB0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097368", Offset="0x1097368")]
		public string Image
		{
			[Address(RVA="0x1FCDAA0", Offset="0x1FCDAA0", VA="0x1FCDAA0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCDAA8", Offset="0x1FCDAA8", VA="0x1FCDAA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097398", Offset="0x1097398")]
		public string MarqueeImage
		{
			[Address(RVA="0x1FCDB30", Offset="0x1FCDB30", VA="0x1FCDB30")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCDB38", Offset="0x1FCDB38", VA="0x1FCDB38")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097348", Offset="0x1097348")]
		public string Name
		{
			[Address(RVA="0x1FCD9B0", Offset="0x1FCD9B0", VA="0x1FCD9B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCD9B8", Offset="0x1FCD9B8", VA="0x1FCD9B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097308", Offset="0x1097308")]
		public static MessageParser<EventGroup> Parser
		{
			[Address(RVA="0x1FCD5C8", Offset="0x1FCD5C8", VA="0x1FCD5C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097328", Offset="0x1097328")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCD71C", Offset="0x1FCD71C", VA="0x1FCD71C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097388", Offset="0x1097388")]
		public RepeatedField<ulong> ShowcaseItems
		{
			[Address(RVA="0x1FCDB28", Offset="0x1FCDB28", VA="0x1FCDB28")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097378", Offset="0x1097378")]
		public long SortOrder
		{
			[Address(RVA="0x1FCDB18", Offset="0x1FCDB18", VA="0x1FCDB18")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1FCDB20", Offset="0x1FCDB20", VA="0x1FCDB20")]
			set
			{
			}
		}

		[Address(RVA="0x1FCE9A0", Offset="0x1FCE9A0", VA="0x1FCE9A0")]
		static EventGroup()
		{
		}

		[Address(RVA="0x1FCD778", Offset="0x1FCD778", VA="0x1FCD778")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F95C", Offset="0x107F95C")]
		public EventGroup()
		{
		}

		[Address(RVA="0x1FCD808", Offset="0x1FCD808", VA="0x1FCD808")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F96C", Offset="0x107F96C")]
		public EventGroup(EventGroup other)
		{
		}

		[Address(RVA="0x1FCE350", Offset="0x1FCE350", VA="0x1FCE350", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F9DC", Offset="0x107F9DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCD940", Offset="0x1FCD940", VA="0x1FCD940", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F97C", Offset="0x107F97C")]
		public EventGroup Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCDBBC", Offset="0x1FCDBBC", VA="0x1FCDBBC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F98C", Offset="0x107F98C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCDC30", Offset="0x1FCDC30", VA="0x1FCDC30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F99C", Offset="0x107F99C")]
		public bool Equals(EventGroup other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCDD70", Offset="0x1FCDD70", VA="0x1FCDD70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F9AC", Offset="0x107F9AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCE5F8", Offset="0x1FCE5F8", VA="0x1FCE5F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F9EC", Offset="0x107F9EC")]
		public void MergeFrom(EventGroup other)
		{
		}

		[Address(RVA="0x1FCE75C", Offset="0x1FCE75C", VA="0x1FCE75C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F9FC", Offset="0x107F9FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCDF58", Offset="0x1FCDF58", VA="0x1FCDF58", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F9BC", Offset="0x107F9BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCDFC0", Offset="0x1FCDFC0", VA="0x1FCDFC0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F9CC", Offset="0x107F9CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FDF8", Offset="0x104FDF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventGroup.<>c <>9;

			[Address(RVA="0x1FCEA90", Offset="0x1FCEA90", VA="0x1FCEA90")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCEAF4", Offset="0x1FCEAF4", VA="0x1FCEAF4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCEAFC", Offset="0x1FCEAFC", VA="0x1FCEAFC")]
			internal EventGroup <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}