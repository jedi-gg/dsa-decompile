using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RequestClubSupportResponse : IMessage<RequestClubSupportResponse>, IMessage, IEquatable<RequestClubSupportResponse>, IDeepCloneable<RequestClubSupportResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RequestClubSupportResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SupportRequestFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubSupportRequest supportRequest_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095470", Offset="0x1095470")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2025FF8", Offset="0x2025FF8", VA="0x2025FF8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095460", Offset="0x1095460")]
		public static MessageParser<RequestClubSupportResponse> Parser
		{
			[Address(RVA="0x2025F90", Offset="0x2025F90", VA="0x2025F90")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095480", Offset="0x1095480")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20260E8", Offset="0x20260E8", VA="0x20260E8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095490", Offset="0x1095490")]
		public ClubSupportRequest SupportRequest
		{
			[Address(RVA="0x20261C8", Offset="0x20261C8", VA="0x20261C8")]
			get
			{
				return null;
			}
			[Address(RVA="0x20261D0", Offset="0x20261D0", VA="0x20261D0")]
			set
			{
			}
		}

		[Address(RVA="0x2026690", Offset="0x2026690", VA="0x2026690")]
		static RequestClubSupportResponse()
		{
		}

		[Address(RVA="0x2026144", Offset="0x2026144", VA="0x2026144")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C25C", Offset="0x107C25C")]
		public RequestClubSupportResponse()
		{
		}

		[Address(RVA="0x202614C", Offset="0x202614C", VA="0x202614C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C26C", Offset="0x107C26C")]
		public RequestClubSupportResponse(RequestClubSupportResponse other)
		{
		}

		[Address(RVA="0x2026470", Offset="0x2026470", VA="0x2026470", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C2DC", Offset="0x107C2DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x20261D8", Offset="0x20261D8", VA="0x20261D8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C27C", Offset="0x107C27C")]
		public RequestClubSupportResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x2026238", Offset="0x2026238", VA="0x2026238", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C28C", Offset="0x107C28C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x20262AC", Offset="0x20262AC", VA="0x20262AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C29C", Offset="0x107C29C")]
		public bool Equals(RequestClubSupportResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2026310", Offset="0x2026310", VA="0x2026310", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C2AC", Offset="0x107C2AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2026500", Offset="0x2026500", VA="0x2026500", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C2EC", Offset="0x107C2EC")]
		public void MergeFrom(RequestClubSupportResponse other)
		{
		}

		[Address(RVA="0x20265B4", Offset="0x20265B4", VA="0x20265B4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C2FC", Offset="0x107C2FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2026368", Offset="0x2026368", VA="0x2026368", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C2BC", Offset="0x107C2BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x20263D0", Offset="0x20263D0", VA="0x20263D0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C2CC", Offset="0x107C2CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F8E8", Offset="0x104F8E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RequestClubSupportResponse.<>c <>9;

			[Address(RVA="0x1BC921C", Offset="0x1BC921C", VA="0x1BC921C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BC9280", Offset="0x1BC9280", VA="0x1BC9280")]
			public <>c()
			{
			}

			[Address(RVA="0x1BC9288", Offset="0x1BC9288", VA="0x1BC9288")]
			internal RequestClubSupportResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}