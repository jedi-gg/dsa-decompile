using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FindClubsResponse : IMessage<FindClubsResponse>, IMessage, IEquatable<FindClubsResponse>, IDeepCloneable<FindClubsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FindClubsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Club> _repeated_clubs_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Club> clubs_;

		[FieldOffset(Offset="0x0")]
		public const int HasNextPageFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool hasNextPage_;

		[FieldOffset(Offset="0x0")]
		public const int OffsetFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong offset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E30", Offset="0x1094E30")]
		public RepeatedField<Club> Clubs
		{
			[Address(RVA="0x1B9C1B4", Offset="0x1B9C1B4", VA="0x1B9C1B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E10", Offset="0x1094E10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9BEF0", Offset="0x1B9BEF0", VA="0x1B9BEF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E40", Offset="0x1094E40")]
		public bool HasNextPage
		{
			[Address(RVA="0x1B9C1BC", Offset="0x1B9C1BC", VA="0x1B9C1BC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B9C1C4", Offset="0x1B9C1C4", VA="0x1B9C1C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E50", Offset="0x1094E50")]
		public ulong Offset
		{
			[Address(RVA="0x1B9C1D0", Offset="0x1B9C1D0", VA="0x1B9C1D0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9C1D8", Offset="0x1B9C1D8", VA="0x1B9C1D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E00", Offset="0x1094E00")]
		public static MessageParser<FindClubsResponse> Parser
		{
			[Address(RVA="0x1B9BE88", Offset="0x1B9BE88", VA="0x1B9BE88")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E20", Offset="0x1094E20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9BFE0", Offset="0x1B9BFE0", VA="0x1B9BFE0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B9C8A4", Offset="0x1B9C8A4", VA="0x1B9C8A4")]
		static FindClubsResponse()
		{
		}

		[Address(RVA="0x1B9C03C", Offset="0x1B9C03C", VA="0x1B9C03C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B1DC", Offset="0x107B1DC")]
		public FindClubsResponse()
		{
		}

		[Address(RVA="0x1B9C0AC", Offset="0x1B9C0AC", VA="0x1B9C0AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B1EC", Offset="0x107B1EC")]
		public FindClubsResponse(FindClubsResponse other)
		{
		}

		[Address(RVA="0x1B9C5BC", Offset="0x1B9C5BC", VA="0x1B9C5BC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B25C", Offset="0x107B25C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9C154", Offset="0x1B9C154", VA="0x1B9C154", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B1FC", Offset="0x107B1FC")]
		public FindClubsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9C1E0", Offset="0x1B9C1E0", VA="0x1B9C1E0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B20C", Offset="0x107B20C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9C254", Offset="0x1B9C254", VA="0x1B9C254", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B21C", Offset="0x107B21C")]
		public bool Equals(FindClubsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9C334", Offset="0x1B9C334", VA="0x1B9C334", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B22C", Offset="0x107B22C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9C6BC", Offset="0x1B9C6BC", VA="0x1B9C6BC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B26C", Offset="0x107B26C")]
		public void MergeFrom(FindClubsResponse other)
		{
		}

		[Address(RVA="0x1B9C764", Offset="0x1B9C764", VA="0x1B9C764", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B27C", Offset="0x107B27C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9C3DC", Offset="0x1B9C3DC", VA="0x1B9C3DC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B23C", Offset="0x107B23C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9C444", Offset="0x1B9C444", VA="0x1B9C444", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B24C", Offset="0x107B24C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F768", Offset="0x104F768")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FindClubsResponse.<>c <>9;

			[Address(RVA="0x1B9C9C8", Offset="0x1B9C9C8", VA="0x1B9C9C8")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9CA2C", Offset="0x1B9CA2C", VA="0x1B9CA2C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9CA34", Offset="0x1B9CA34", VA="0x1B9CA34")]
			internal FindClubsResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}