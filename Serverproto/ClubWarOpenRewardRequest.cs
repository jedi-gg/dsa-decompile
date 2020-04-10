using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarOpenRewardRequest : IMessage<ClubWarOpenRewardRequest>, IMessage, IEquatable<ClubWarOpenRewardRequest>, IDeepCloneable<ClubWarOpenRewardRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarOpenRewardRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10962C0", Offset="0x10962C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B26170", Offset="0x1B26170", VA="0x1B26170")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10962E0", Offset="0x10962E0")]
		public string Id
		{
			[Address(RVA="0x1B263D4", Offset="0x1B263D4", VA="0x1B263D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B263DC", Offset="0x1B263DC", VA="0x1B263DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10962B0", Offset="0x10962B0")]
		public static MessageParser<ClubWarOpenRewardRequest> Parser
		{
			[Address(RVA="0x1B26108", Offset="0x1B26108", VA="0x1B26108")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10962D0", Offset="0x10962D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B26260", Offset="0x1B26260", VA="0x1B26260", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B2686C", Offset="0x1B2686C", VA="0x1B2686C")]
		static ClubWarOpenRewardRequest()
		{
		}

		[Address(RVA="0x1B262BC", Offset="0x1B262BC", VA="0x1B262BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E35C", Offset="0x107E35C")]
		public ClubWarOpenRewardRequest()
		{
		}

		[Address(RVA="0x1B26314", Offset="0x1B26314", VA="0x1B26314")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E36C", Offset="0x107E36C")]
		public ClubWarOpenRewardRequest(ClubWarOpenRewardRequest other)
		{
		}

		[Address(RVA="0x1B266C8", Offset="0x1B266C8", VA="0x1B266C8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E3DC", Offset="0x107E3DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B26374", Offset="0x1B26374", VA="0x1B26374", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E37C", Offset="0x107E37C")]
		public ClubWarOpenRewardRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B2644C", Offset="0x1B2644C", VA="0x1B2644C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E38C", Offset="0x107E38C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B264C0", Offset="0x1B264C0", VA="0x1B264C0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E39C", Offset="0x107E39C")]
		public bool Equals(ClubWarOpenRewardRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B26524", Offset="0x1B26524", VA="0x1B26524", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E3AC", Offset="0x107E3AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B2677C", Offset="0x1B2677C", VA="0x1B2677C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E3EC", Offset="0x107E3EC")]
		public void MergeFrom(ClubWarOpenRewardRequest other)
		{
		}

		[Address(RVA="0x1B267E8", Offset="0x1B267E8", VA="0x1B267E8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E3FC", Offset="0x107E3FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B265A8", Offset="0x1B265A8", VA="0x1B265A8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E3BC", Offset="0x107E3BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B26610", Offset="0x1B26610", VA="0x1B26610", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E3CC", Offset="0x107E3CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FBF8", Offset="0x104FBF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarOpenRewardRequest.<>c <>9;

			[Address(RVA="0x1B26944", Offset="0x1B26944", VA="0x1B26944")]
			static <>c()
			{
			}

			[Address(RVA="0x1B269A8", Offset="0x1B269A8", VA="0x1B269A8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B269B0", Offset="0x1B269B0", VA="0x1B269B0")]
			internal ClubWarOpenRewardRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}