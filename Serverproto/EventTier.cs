using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventTier : IMessage<EventTier>, IMessage, IEquatable<EventTier>, IDeepCloneable<EventTier>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventTier> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private EventIdentifier id_;

		[FieldOffset(Offset="0x0")]
		public const int BattleNodeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.BattleNode battleNode_;

		[FieldOffset(Offset="0x0")]
		public const int RulesetFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private uint ruleset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097208", Offset="0x1097208")]
		public Serverproto.BattleNode BattleNode
		{
			[Address(RVA="0x1B9957C", Offset="0x1B9957C", VA="0x1B9957C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B99584", Offset="0x1B99584", VA="0x1B99584")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10971D8", Offset="0x10971D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B99380", Offset="0x1B99380", VA="0x1B99380")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10971F8", Offset="0x10971F8")]
		public EventIdentifier Id
		{
			[Address(RVA="0x1B9956C", Offset="0x1B9956C", VA="0x1B9956C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B99574", Offset="0x1B99574", VA="0x1B99574")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10971C8", Offset="0x10971C8")]
		public static MessageParser<EventTier> Parser
		{
			[Address(RVA="0x1B99318", Offset="0x1B99318", VA="0x1B99318")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10971E8", Offset="0x10971E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B99470", Offset="0x1B99470", VA="0x1B99470", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097218", Offset="0x1097218")]
		public uint Ruleset
		{
			[Address(RVA="0x1B995EC", Offset="0x1B995EC", VA="0x1B995EC")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1B995F4", Offset="0x1B995F4", VA="0x1B995F4")]
			set
			{
			}
		}

		[Address(RVA="0x1B99CAC", Offset="0x1B99CAC", VA="0x1B99CAC")]
		static EventTier()
		{
		}

		[Address(RVA="0x1B994CC", Offset="0x1B994CC", VA="0x1B994CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F74C", Offset="0x107F74C")]
		public EventTier()
		{
		}

		[Address(RVA="0x1B994D4", Offset="0x1B994D4", VA="0x1B994D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F75C", Offset="0x107F75C")]
		public EventTier(EventTier other)
		{
		}

		[Address(RVA="0x1B99948", Offset="0x1B99948", VA="0x1B99948", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F7CC", Offset="0x107F7CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9958C", Offset="0x1B9958C", VA="0x1B9958C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F76C", Offset="0x107F76C")]
		public EventTier Clone()
		{
			return null;
		}

		[Address(RVA="0x1B995FC", Offset="0x1B995FC", VA="0x1B995FC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F77C", Offset="0x107F77C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B99670", Offset="0x1B99670", VA="0x1B99670", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F78C", Offset="0x107F78C")]
		public bool Equals(EventTier other)
		{
			return new bool();
		}

		[Address(RVA="0x1B996F8", Offset="0x1B996F8", VA="0x1B996F8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F79C", Offset="0x107F79C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B99A58", Offset="0x1B99A58", VA="0x1B99A58", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F7DC", Offset="0x107F7DC")]
		public void MergeFrom(EventTier other)
		{
		}

		[Address(RVA="0x1B99B68", Offset="0x1B99B68", VA="0x1B99B68", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F7EC", Offset="0x107F7EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B99790", Offset="0x1B99790", VA="0x1B99790", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F7AC", Offset="0x107F7AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B997F8", Offset="0x1B997F8", VA="0x1B997F8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F7BC", Offset="0x107F7BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FDC8", Offset="0x104FDC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventTier.<>c <>9;

			[Address(RVA="0x1B99D84", Offset="0x1B99D84", VA="0x1B99D84")]
			static <>c()
			{
			}

			[Address(RVA="0x1B99DE8", Offset="0x1B99DE8", VA="0x1B99DE8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B99DF0", Offset="0x1B99DF0", VA="0x1B99DF0")]
			internal EventTier <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}