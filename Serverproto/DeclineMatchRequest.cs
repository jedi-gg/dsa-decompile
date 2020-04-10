using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DeclineMatchRequest : IMessage<DeclineMatchRequest>, IMessage, IEquatable<DeclineMatchRequest>, IDeepCloneable<DeclineMatchRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DeclineMatchRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleInvite invite_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092398", Offset="0x1092398")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF8F80", Offset="0x1EF8F80", VA="0x1EF8F80")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10923B8", Offset="0x10923B8")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1EF9150", Offset="0x1EF9150", VA="0x1EF9150")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF9158", Offset="0x1EF9158", VA="0x1EF9158")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092388", Offset="0x1092388")]
		public static MessageParser<DeclineMatchRequest> Parser
		{
			[Address(RVA="0x1EF8F18", Offset="0x1EF8F18", VA="0x1EF8F18")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10923A8", Offset="0x10923A8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF9070", Offset="0x1EF9070", VA="0x1EF9070", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF9618", Offset="0x1EF9618", VA="0x1EF9618")]
		static DeclineMatchRequest()
		{
		}

		[Address(RVA="0x1EF90CC", Offset="0x1EF90CC", VA="0x1EF90CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107673C", Offset="0x107673C")]
		public DeclineMatchRequest()
		{
		}

		[Address(RVA="0x1EF90D4", Offset="0x1EF90D4", VA="0x1EF90D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107674C", Offset="0x107674C")]
		public DeclineMatchRequest(DeclineMatchRequest other)
		{
		}

		[Address(RVA="0x1EF93F8", Offset="0x1EF93F8", VA="0x1EF93F8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10767BC", Offset="0x10767BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF9160", Offset="0x1EF9160", VA="0x1EF9160", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107675C", Offset="0x107675C")]
		public DeclineMatchRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF91C0", Offset="0x1EF91C0", VA="0x1EF91C0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107676C", Offset="0x107676C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF9234", Offset="0x1EF9234", VA="0x1EF9234", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107677C", Offset="0x107677C")]
		public bool Equals(DeclineMatchRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF9298", Offset="0x1EF9298", VA="0x1EF9298", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107678C", Offset="0x107678C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF9488", Offset="0x1EF9488", VA="0x1EF9488", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10767CC", Offset="0x10767CC")]
		public void MergeFrom(DeclineMatchRequest other)
		{
		}

		[Address(RVA="0x1EF953C", Offset="0x1EF953C", VA="0x1EF953C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10767DC", Offset="0x10767DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF92F0", Offset="0x1EF92F0", VA="0x1EF92F0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107679C", Offset="0x107679C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF9358", Offset="0x1EF9358", VA="0x1EF9358", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10767AC", Offset="0x10767AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F068", Offset="0x104F068")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DeclineMatchRequest.<>c <>9;

			[Address(RVA="0x1EF96F0", Offset="0x1EF96F0", VA="0x1EF96F0")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF9754", Offset="0x1EF9754", VA="0x1EF9754")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF975C", Offset="0x1EF975C", VA="0x1EF975C")]
			internal DeclineMatchRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}