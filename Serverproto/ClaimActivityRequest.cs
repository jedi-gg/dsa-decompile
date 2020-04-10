using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimActivityRequest : IMessage<ClaimActivityRequest>, IMessage, IEquatable<ClaimActivityRequest>, IDeepCloneable<ClaimActivityRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimActivityRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int RewardChoiceFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong rewardChoice_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A3B0", Offset="0x109A3B0")]
		public ulong DefinitionId
		{
			[Address(RVA="0x1A3F558", Offset="0x1A3F558", VA="0x1A3F558")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A3F560", Offset="0x1A3F560", VA="0x1A3F560")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A390", Offset="0x109A390")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3F324", Offset="0x1A3F324", VA="0x1A3F324")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A380", Offset="0x109A380")]
		public static MessageParser<ClaimActivityRequest> Parser
		{
			[Address(RVA="0x1A3F2BC", Offset="0x1A3F2BC", VA="0x1A3F2BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A3A0", Offset="0x109A3A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3F414", Offset="0x1A3F414", VA="0x1A3F414", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A3C0", Offset="0x109A3C0")]
		public ulong RewardChoice
		{
			[Address(RVA="0x1A3F568", Offset="0x1A3F568", VA="0x1A3F568")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A3F570", Offset="0x1A3F570", VA="0x1A3F570")]
			set
			{
			}
		}

		[Address(RVA="0x1A3F9E0", Offset="0x1A3F9E0", VA="0x1A3F9E0")]
		static ClaimActivityRequest()
		{
		}

		[Address(RVA="0x1A3F470", Offset="0x1A3F470", VA="0x1A3F470")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108427C", Offset="0x108427C")]
		public ClaimActivityRequest()
		{
		}

		[Address(RVA="0x1A3F478", Offset="0x1A3F478", VA="0x1A3F478")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108428C", Offset="0x108428C")]
		public ClaimActivityRequest(ClaimActivityRequest other)
		{
		}

		[Address(RVA="0x1A3F81C", Offset="0x1A3F81C", VA="0x1A3F81C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10842FC", Offset="0x10842FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3F4F8", Offset="0x1A3F4F8", VA="0x1A3F4F8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108429C", Offset="0x108429C")]
		public ClaimActivityRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3F578", Offset="0x1A3F578", VA="0x1A3F578", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10842AC", Offset="0x10842AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3F5EC", Offset="0x1A3F5EC", VA="0x1A3F5EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10842BC", Offset="0x10842BC")]
		public bool Equals(ClaimActivityRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3F638", Offset="0x1A3F638", VA="0x1A3F638", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10842CC", Offset="0x10842CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A3F8F0", Offset="0x1A3F8F0", VA="0x1A3F8F0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108430C", Offset="0x108430C")]
		public void MergeFrom(ClaimActivityRequest other)
		{
		}

		[Address(RVA="0x1A3F93C", Offset="0x1A3F93C", VA="0x1A3F93C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108431C", Offset="0x108431C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3F6BC", Offset="0x1A3F6BC", VA="0x1A3F6BC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10842DC", Offset="0x10842DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A3F724", Offset="0x1A3F724", VA="0x1A3F724", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10842EC", Offset="0x10842EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050498", Offset="0x1050498")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimActivityRequest.<>c <>9;

			[Address(RVA="0x1A3FAB8", Offset="0x1A3FAB8", VA="0x1A3FAB8")]
			static <>c()
			{
			}

			[Address(RVA="0x1A3FB1C", Offset="0x1A3FB1C", VA="0x1A3FB1C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A3FB24", Offset="0x1A3FB24", VA="0x1A3FB24")]
			internal ClaimActivityRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}