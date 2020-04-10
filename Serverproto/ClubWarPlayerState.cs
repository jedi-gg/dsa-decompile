using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarPlayerState : IMessage<ClubWarPlayerState>, IMessage, IEquatable<ClubWarPlayerState>, IDeepCloneable<ClubWarPlayerState>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarPlayerState> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UsedAttackUnitIdsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_usedAttackUnitIds_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> usedAttackUnitIds_;

		[FieldOffset(Offset="0x0")]
		public const int UsedAttackSpellIdsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_usedAttackSpellIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> usedAttackSpellIds_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095DF0", Offset="0x1095DF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B28554", Offset="0x1B28554", VA="0x1B28554")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095DE0", Offset="0x1095DE0")]
		public static MessageParser<ClubWarPlayerState> Parser
		{
			[Address(RVA="0x1B284EC", Offset="0x1B284EC", VA="0x1B284EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E00", Offset="0x1095E00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B28644", Offset="0x1B28644", VA="0x1B28644", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E20", Offset="0x1095E20")]
		public RepeatedField<ulong> UsedAttackSpellIds
		{
			[Address(RVA="0x1B28760", Offset="0x1B28760", VA="0x1B28760")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E10", Offset="0x1095E10")]
		public RepeatedField<ulong> UsedAttackUnitIds
		{
			[Address(RVA="0x1B28758", Offset="0x1B28758", VA="0x1B28758")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B28CD8", Offset="0x1B28CD8", VA="0x1B28CD8")]
		static ClubWarPlayerState()
		{
		}

		[Address(RVA="0x1B18AEC", Offset="0x1B18AEC", VA="0x1B18AEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D64C", Offset="0x107D64C")]
		public ClubWarPlayerState()
		{
		}

		[Address(RVA="0x1B286A0", Offset="0x1B286A0", VA="0x1B286A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D65C", Offset="0x107D65C")]
		public ClubWarPlayerState(ClubWarPlayerState other)
		{
		}

		[Address(RVA="0x1B28AB4", Offset="0x1B28AB4", VA="0x1B28AB4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D6CC", Offset="0x107D6CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B17DB0", Offset="0x1B17DB0", VA="0x1B17DB0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D66C", Offset="0x107D66C")]
		public ClubWarPlayerState Clone()
		{
			return null;
		}

		[Address(RVA="0x1B28768", Offset="0x1B28768", VA="0x1B28768", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D67C", Offset="0x107D67C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B287DC", Offset="0x1B287DC", VA="0x1B287DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D68C", Offset="0x107D68C")]
		public bool Equals(ClubWarPlayerState other)
		{
			return new bool();
		}

		[Address(RVA="0x1B288C0", Offset="0x1B288C0", VA="0x1B288C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D69C", Offset="0x107D69C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B18B7C", Offset="0x1B18B7C", VA="0x1B18B7C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D6DC", Offset="0x107D6DC")]
		public void MergeFrom(ClubWarPlayerState other)
		{
		}

		[Address(RVA="0x1B28BA8", Offset="0x1B28BA8", VA="0x1B28BA8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D6EC", Offset="0x107D6EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B2894C", Offset="0x1B2894C", VA="0x1B2894C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D6AC", Offset="0x107D6AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B289B4", Offset="0x1B289B4", VA="0x1B289B4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D6BC", Offset="0x107D6BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FAC8", Offset="0x104FAC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarPlayerState.<>c <>9;

			[Address(RVA="0x1B28DE0", Offset="0x1B28DE0", VA="0x1B28DE0")]
			static <>c()
			{
			}

			[Address(RVA="0x1B28E44", Offset="0x1B28E44", VA="0x1B28E44")]
			public <>c()
			{
			}

			[Address(RVA="0x1B28E4C", Offset="0x1B28E4C", VA="0x1B28E4C")]
			internal ClubWarPlayerState <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}