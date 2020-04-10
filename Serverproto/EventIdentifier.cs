using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventIdentifier : IMessage<EventIdentifier>, IMessage, IEquatable<EventIdentifier>, IDeepCloneable<EventIdentifier>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventIdentifier> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EventContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong eventContentId_;

		[FieldOffset(Offset="0x0")]
		public const int TierIndexFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong tierIndex_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096AF0", Offset="0x1096AF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCEBBC", Offset="0x1FCEBBC", VA="0x1FCEBBC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B10", Offset="0x1096B10")]
		public ulong EventContentId
		{
			[Address(RVA="0x1FCED88", Offset="0x1FCED88", VA="0x1FCED88")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCED90", Offset="0x1FCED90", VA="0x1FCED90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096AE0", Offset="0x1096AE0")]
		public static MessageParser<EventIdentifier> Parser
		{
			[Address(RVA="0x1FCEB54", Offset="0x1FCEB54", VA="0x1FCEB54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B00", Offset="0x1096B00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCECAC", Offset="0x1FCECAC", VA="0x1FCECAC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B20", Offset="0x1096B20")]
		public ulong TierIndex
		{
			[Address(RVA="0x1FCED98", Offset="0x1FCED98", VA="0x1FCED98")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCEDA0", Offset="0x1FCEDA0", VA="0x1FCEDA0")]
			set
			{
			}
		}

		[Address(RVA="0x1FCF1C4", Offset="0x1FCF1C4", VA="0x1FCF1C4")]
		static EventIdentifier()
		{
		}

		[Address(RVA="0x1FCC51C", Offset="0x1FCC51C", VA="0x1FCC51C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EFBC", Offset="0x107EFBC")]
		public EventIdentifier()
		{
		}

		[Address(RVA="0x1FCED08", Offset="0x1FCED08", VA="0x1FCED08")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EFCC", Offset="0x107EFCC")]
		public EventIdentifier(EventIdentifier other)
		{
		}

		[Address(RVA="0x1FCF04C", Offset="0x1FCF04C", VA="0x1FCF04C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F03C", Offset="0x107F03C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCBC34", Offset="0x1FCBC34", VA="0x1FCBC34", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EFDC", Offset="0x107EFDC")]
		public EventIdentifier Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCEDA8", Offset="0x1FCEDA8", VA="0x1FCEDA8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EFEC", Offset="0x107EFEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCEE1C", Offset="0x1FCEE1C", VA="0x1FCEE1C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EFFC", Offset="0x107EFFC")]
		public bool Equals(EventIdentifier other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCEE68", Offset="0x1FCEE68", VA="0x1FCEE68", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F00C", Offset="0x107F00C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCC524", Offset="0x1FCC524", VA="0x1FCC524", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F04C", Offset="0x107F04C")]
		public void MergeFrom(EventIdentifier other)
		{
		}

		[Address(RVA="0x1FCF120", Offset="0x1FCF120", VA="0x1FCF120", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F05C", Offset="0x107F05C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCEEEC", Offset="0x1FCEEEC", VA="0x1FCEEEC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F01C", Offset="0x107F01C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCEF54", Offset="0x1FCEF54", VA="0x1FCEF54", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F02C", Offset="0x107F02C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD18", Offset="0x104FD18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventIdentifier.<>c <>9;

			[Address(RVA="0x1FCF29C", Offset="0x1FCF29C", VA="0x1FCF29C")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCF300", Offset="0x1FCF300", VA="0x1FCF300")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCF308", Offset="0x1FCF308", VA="0x1FCF308")]
			internal EventIdentifier <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}