using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarClubDefensesResponse : IMessage<ClubWarClubDefensesResponse>, IMessage, IEquatable<ClubWarClubDefensesResponse>, IDeepCloneable<ClubWarClubDefensesResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarClubDefensesResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefensesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubWarSquad> _repeated_defenses_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubWarSquad> defenses_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10962A0", Offset="0x10962A0")]
		public RepeatedField<ClubWarSquad> Defenses
		{
			[Address(RVA="0x1B2039C", Offset="0x1B2039C", VA="0x1B2039C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096280", Offset="0x1096280")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B200E8", Offset="0x1B200E8", VA="0x1B200E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096270", Offset="0x1096270")]
		public static MessageParser<ClubWarClubDefensesResponse> Parser
		{
			[Address(RVA="0x1B20080", Offset="0x1B20080", VA="0x1B20080")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096290", Offset="0x1096290")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B201D8", Offset="0x1B201D8", VA="0x1B201D8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B20884", Offset="0x1B20884", VA="0x1B20884")]
		static ClubWarClubDefensesResponse()
		{
		}

		[Address(RVA="0x1B20234", Offset="0x1B20234", VA="0x1B20234")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E2AC", Offset="0x107E2AC")]
		public ClubWarClubDefensesResponse()
		{
		}

		[Address(RVA="0x1B202A4", Offset="0x1B202A4", VA="0x1B202A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E2BC", Offset="0x107E2BC")]
		public ClubWarClubDefensesResponse(ClubWarClubDefensesResponse other)
		{
		}

		[Address(RVA="0x1B20654", Offset="0x1B20654", VA="0x1B20654", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E32C", Offset="0x107E32C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B2033C", Offset="0x1B2033C", VA="0x1B2033C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E2CC", Offset="0x107E2CC")]
		public ClubWarClubDefensesResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B203A4", Offset="0x1B203A4", VA="0x1B203A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E2DC", Offset="0x107E2DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B20418", Offset="0x1B20418", VA="0x1B20418", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E2EC", Offset="0x107E2EC")]
		public bool Equals(ClubWarClubDefensesResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B204C8", Offset="0x1B204C8", VA="0x1B204C8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E2FC", Offset="0x107E2FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B20710", Offset="0x1B20710", VA="0x1B20710", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E33C", Offset="0x107E33C")]
		public void MergeFrom(ClubWarClubDefensesResponse other)
		{
		}

		[Address(RVA="0x1B207A0", Offset="0x1B207A0", VA="0x1B207A0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E34C", Offset="0x107E34C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B20528", Offset="0x1B20528", VA="0x1B20528", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E30C", Offset="0x107E30C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B20590", Offset="0x1B20590", VA="0x1B20590", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E31C", Offset="0x107E31C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FBE8", Offset="0x104FBE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarClubDefensesResponse.<>c <>9;

			[Address(RVA="0x1B209A8", Offset="0x1B209A8", VA="0x1B209A8")]
			static <>c()
			{
			}

			[Address(RVA="0x1B20A0C", Offset="0x1B20A0C", VA="0x1B20A0C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B20A14", Offset="0x1B20A14", VA="0x1B20A14")]
			internal ClubWarClubDefensesResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}