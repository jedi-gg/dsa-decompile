using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KickClubMemberRequest : IMessage<KickClubMemberRequest>, IMessage, IEquatable<KickClubMemberRequest>, IDeepCloneable<KickClubMemberRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KickClubMemberRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10951A0", Offset="0x10951A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A96DA8", Offset="0x1A96DA8", VA="0x1A96DA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095190", Offset="0x1095190")]
		public static MessageParser<KickClubMemberRequest> Parser
		{
			[Address(RVA="0x1A96D40", Offset="0x1A96D40", VA="0x1A96D40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10951B0", Offset="0x10951B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A96E98", Offset="0x1A96E98", VA="0x1A96E98", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10951C0", Offset="0x10951C0")]
		public string PlayerId
		{
			[Address(RVA="0x1A9700C", Offset="0x1A9700C", VA="0x1A9700C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A97014", Offset="0x1A97014", VA="0x1A97014")]
			set
			{
			}
		}

		[Address(RVA="0x1A974A4", Offset="0x1A974A4", VA="0x1A974A4")]
		static KickClubMemberRequest()
		{
		}

		[Address(RVA="0x1A96EF4", Offset="0x1A96EF4", VA="0x1A96EF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BACC", Offset="0x107BACC")]
		public KickClubMemberRequest()
		{
		}

		[Address(RVA="0x1A96F4C", Offset="0x1A96F4C", VA="0x1A96F4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BADC", Offset="0x107BADC")]
		public KickClubMemberRequest(KickClubMemberRequest other)
		{
		}

		[Address(RVA="0x1A97300", Offset="0x1A97300", VA="0x1A97300", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB4C", Offset="0x107BB4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A96FAC", Offset="0x1A96FAC", VA="0x1A96FAC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BAEC", Offset="0x107BAEC")]
		public KickClubMemberRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A97084", Offset="0x1A97084", VA="0x1A97084", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BAFC", Offset="0x107BAFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A970F8", Offset="0x1A970F8", VA="0x1A970F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB0C", Offset="0x107BB0C")]
		public bool Equals(KickClubMemberRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9715C", Offset="0x1A9715C", VA="0x1A9715C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB1C", Offset="0x107BB1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A973B4", Offset="0x1A973B4", VA="0x1A973B4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB5C", Offset="0x107BB5C")]
		public void MergeFrom(KickClubMemberRequest other)
		{
		}

		[Address(RVA="0x1A97420", Offset="0x1A97420", VA="0x1A97420", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB6C", Offset="0x107BB6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A971E0", Offset="0x1A971E0", VA="0x1A971E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB2C", Offset="0x107BB2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A97248", Offset="0x1A97248", VA="0x1A97248", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB3C", Offset="0x107BB3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F838", Offset="0x104F838")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KickClubMemberRequest.<>c <>9;

			[Address(RVA="0x1A9757C", Offset="0x1A9757C", VA="0x1A9757C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A975E0", Offset="0x1A975E0", VA="0x1A975E0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A975E8", Offset="0x1A975E8", VA="0x1A975E8")]
			internal KickClubMemberRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}