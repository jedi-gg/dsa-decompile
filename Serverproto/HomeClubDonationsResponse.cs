using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubDonationsResponse : IMessage<HomeClubDonationsResponse>, IMessage, IEquatable<HomeClubDonationsResponse>, IDeepCloneable<HomeClubDonationsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubDonationsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemRequestsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubItemRequest> _repeated_itemRequests_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubItemRequest> itemRequests_;

		[FieldOffset(Offset="0x0")]
		public const int NextItemRequestTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong nextItemRequestTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ItemDonationsRemainingFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private uint itemDonationsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int ItemDonationsResetTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong itemDonationsResetTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int SupportRequestsFieldNumber = 5;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ClubSupportRequest> _repeated_supportRequests_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<ClubSupportRequest> supportRequests_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C28", Offset="0x1097C28")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1CFE55C", Offset="0x1CFE55C", VA="0x1CFE55C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C68", Offset="0x1097C68")]
		public uint ItemDonationsRemaining
		{
			[Address(RVA="0x1CFE88C", Offset="0x1CFE88C", VA="0x1CFE88C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1CFE894", Offset="0x1CFE894", VA="0x1CFE894")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C78", Offset="0x1097C78")]
		public ulong ItemDonationsResetTimestamp
		{
			[Address(RVA="0x1CFE89C", Offset="0x1CFE89C", VA="0x1CFE89C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1CFE8A4", Offset="0x1CFE8A4", VA="0x1CFE8A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C48", Offset="0x1097C48")]
		public RepeatedField<ClubItemRequest> ItemRequests
		{
			[Address(RVA="0x1CFE874", Offset="0x1CFE874", VA="0x1CFE874")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C58", Offset="0x1097C58")]
		public ulong NextItemRequestTimestamp
		{
			[Address(RVA="0x1CFE87C", Offset="0x1CFE87C", VA="0x1CFE87C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1CFE884", Offset="0x1CFE884", VA="0x1CFE884")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C18", Offset="0x1097C18")]
		public static MessageParser<HomeClubDonationsResponse> Parser
		{
			[Address(RVA="0x1CFE4F4", Offset="0x1CFE4F4", VA="0x1CFE4F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C38", Offset="0x1097C38")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1CFE648", Offset="0x1CFE648", VA="0x1CFE648", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C88", Offset="0x1097C88")]
		public RepeatedField<ClubSupportRequest> SupportRequests
		{
			[Address(RVA="0x1CFE8AC", Offset="0x1CFE8AC", VA="0x1CFE8AC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1CFF208", Offset="0x1CFF208", VA="0x1CFF208")]
		static HomeClubDonationsResponse()
		{
		}

		[Address(RVA="0x1CFE6A4", Offset="0x1CFE6A4", VA="0x1CFE6A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108071C", Offset="0x108071C")]
		public HomeClubDonationsResponse()
		{
		}

		[Address(RVA="0x1CFE73C", Offset="0x1CFE73C", VA="0x1CFE73C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108072C", Offset="0x108072C")]
		public HomeClubDonationsResponse(HomeClubDonationsResponse other)
		{
		}

		[Address(RVA="0x1CFEDB4", Offset="0x1CFEDB4", VA="0x1CFEDB4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108079C", Offset="0x108079C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1CFE814", Offset="0x1CFE814", VA="0x1CFE814", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108073C", Offset="0x108073C")]
		public HomeClubDonationsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1CFE8B4", Offset="0x1CFE8B4", VA="0x1CFE8B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108074C", Offset="0x108074C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFE928", Offset="0x1CFE928", VA="0x1CFE928", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108075C", Offset="0x108075C")]
		public bool Equals(HomeClubDonationsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFEA38", Offset="0x1CFEA38", VA="0x1CFEA38", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108076C", Offset="0x108076C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1CFEF74", Offset="0x1CFEF74", VA="0x1CFEF74", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10807AC", Offset="0x10807AC")]
		public void MergeFrom(HomeClubDonationsResponse other)
		{
		}

		[Address(RVA="0x1CFF054", Offset="0x1CFF054", VA="0x1CFF054", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10807BC", Offset="0x10807BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1CFEB24", Offset="0x1CFEB24", VA="0x1CFEB24", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108077C", Offset="0x108077C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1CFEB8C", Offset="0x1CFEB8C", VA="0x1CFEB8C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108078C", Offset="0x108078C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF38", Offset="0x104FF38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubDonationsResponse.<>c <>9;

			[Address(RVA="0x1CFF378", Offset="0x1CFF378", VA="0x1CFF378")]
			static <>c()
			{
			}

			[Address(RVA="0x1CFF3DC", Offset="0x1CFF3DC", VA="0x1CFF3DC")]
			public <>c()
			{
			}

			[Address(RVA="0x1CFF3E4", Offset="0x1CFF3E4", VA="0x1CFF3E4")]
			internal HomeClubDonationsResponse <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}