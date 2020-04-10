using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RequestClubItemResponse : IMessage<RequestClubItemResponse>, IMessage, IEquatable<RequestClubItemResponse>, IDeepCloneable<RequestClubItemResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RequestClubItemResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RequestFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubItemRequest request_;

		[FieldOffset(Offset="0x0")]
		public const int NextClubItemRequestTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong nextClubItemRequestTimestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095270", Offset="0x1095270")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2024E9C", Offset="0x2024E9C", VA="0x2024E9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10952A0", Offset="0x10952A0")]
		public ulong NextClubItemRequestTimestamp
		{
			[Address(RVA="0x20250E4", Offset="0x20250E4", VA="0x20250E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x20250EC", Offset="0x20250EC", VA="0x20250EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095260", Offset="0x1095260")]
		public static MessageParser<RequestClubItemResponse> Parser
		{
			[Address(RVA="0x2024E34", Offset="0x2024E34", VA="0x2024E34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095280", Offset="0x1095280")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2024F8C", Offset="0x2024F8C", VA="0x2024F8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095290", Offset="0x1095290")]
		public ClubItemRequest Request
		{
			[Address(RVA="0x2025074", Offset="0x2025074", VA="0x2025074")]
			get
			{
				return null;
			}
			[Address(RVA="0x202507C", Offset="0x202507C", VA="0x202507C")]
			set
			{
			}
		}

		[Address(RVA="0x2025654", Offset="0x2025654", VA="0x2025654")]
		static RequestClubItemResponse()
		{
		}

		[Address(RVA="0x2024FE8", Offset="0x2024FE8", VA="0x2024FE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BCDC", Offset="0x107BCDC")]
		public RequestClubItemResponse()
		{
		}

		[Address(RVA="0x2024FF0", Offset="0x2024FF0", VA="0x2024FF0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BCEC", Offset="0x107BCEC")]
		public RequestClubItemResponse(RequestClubItemResponse other)
		{
		}

		[Address(RVA="0x20253BC", Offset="0x20253BC", VA="0x20253BC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD5C", Offset="0x107BD5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2025084", Offset="0x2025084", VA="0x2025084", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BCFC", Offset="0x107BCFC")]
		public RequestClubItemResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x20250F4", Offset="0x20250F4", VA="0x20250F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD0C", Offset="0x107BD0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2025168", Offset="0x2025168", VA="0x2025168", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD1C", Offset="0x107BD1C")]
		public bool Equals(RequestClubItemResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x20251DC", Offset="0x20251DC", VA="0x20251DC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD2C", Offset="0x107BD2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2025490", Offset="0x2025490", VA="0x2025490", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD6C", Offset="0x107BD6C")]
		public void MergeFrom(RequestClubItemResponse other)
		{
		}

		[Address(RVA="0x2025550", Offset="0x2025550", VA="0x2025550", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD7C", Offset="0x107BD7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x202525C", Offset="0x202525C", VA="0x202525C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD3C", Offset="0x107BD3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x20252C4", Offset="0x20252C4", VA="0x20252C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD4C", Offset="0x107BD4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F868", Offset="0x104F868")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RequestClubItemResponse.<>c <>9;

			[Address(RVA="0x202572C", Offset="0x202572C", VA="0x202572C")]
			static <>c()
			{
			}

			[Address(RVA="0x2025790", Offset="0x2025790", VA="0x2025790")]
			public <>c()
			{
			}

			[Address(RVA="0x2025798", Offset="0x2025798", VA="0x2025798")]
			internal RequestClubItemResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}