using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubActivity : IMessage<ClubActivity>, IMessage, IEquatable<ClubActivity>, IDeepCloneable<ClubActivity>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubActivity> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkLocationFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong deepLinkLocation_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkSublocationFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string deepLinkSublocation_;

		[FieldOffset(Offset="0x0")]
		public const int TiersFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubActivityTier> _repeated_tiers_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ClubActivityTier> tiers_;

		[FieldOffset(Offset="0x0")]
		public const int PlayersFieldNumber = 5;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ClubActivityPlayer> _repeated_players_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<ClubActivityPlayer> players_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094AF0", Offset="0x1094AF0")]
		public ulong DeepLinkLocation
		{
			[Address(RVA="0x1A487DC", Offset="0x1A487DC", VA="0x1A487DC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A487E4", Offset="0x1A487E4", VA="0x1A487E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B00", Offset="0x1094B00")]
		public string DeepLinkSublocation
		{
			[Address(RVA="0x1A487EC", Offset="0x1A487EC", VA="0x1A487EC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A487F4", Offset="0x1A487F4", VA="0x1A487F4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094AC0", Offset="0x1094AC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A48460", Offset="0x1A48460", VA="0x1A48460")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094AB0", Offset="0x1094AB0")]
		public static MessageParser<ClubActivity> Parser
		{
			[Address(RVA="0x1A48334", Offset="0x1A48334", VA="0x1A48334")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094AD0", Offset="0x1094AD0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A48550", Offset="0x1A48550", VA="0x1A48550", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B20", Offset="0x1094B20")]
		public RepeatedField<ClubActivityPlayer> Players
		{
			[Address(RVA="0x1A4886C", Offset="0x1A4886C", VA="0x1A4886C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094AE0", Offset="0x1094AE0")]
		public ulong SortOrder
		{
			[Address(RVA="0x1A487CC", Offset="0x1A487CC", VA="0x1A487CC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A487D4", Offset="0x1A487D4", VA="0x1A487D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B10", Offset="0x1094B10")]
		public RepeatedField<ClubActivityTier> Tiers
		{
			[Address(RVA="0x1A48864", Offset="0x1A48864", VA="0x1A48864")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4922C", Offset="0x1A4922C", VA="0x1A4922C")]
		static ClubActivity()
		{
		}

		[Address(RVA="0x1A485AC", Offset="0x1A485AC", VA="0x1A485AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AAFC", Offset="0x107AAFC")]
		public ClubActivity()
		{
		}

		[Address(RVA="0x1A48654", Offset="0x1A48654", VA="0x1A48654")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB0C", Offset="0x107AB0C")]
		public ClubActivity(ClubActivity other)
		{
		}

		[Address(RVA="0x1A48DA0", Offset="0x1A48DA0", VA="0x1A48DA0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB7C", Offset="0x107AB7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4876C", Offset="0x1A4876C", VA="0x1A4876C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB1C", Offset="0x107AB1C")]
		public ClubActivity Clone()
		{
			return null;
		}

		[Address(RVA="0x1A48874", Offset="0x1A48874", VA="0x1A48874", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB2C", Offset="0x107AB2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A488E8", Offset="0x1A488E8", VA="0x1A488E8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB3C", Offset="0x107AB3C")]
		public bool Equals(ClubActivity other)
		{
			return new bool();
		}

		[Address(RVA="0x1A489FC", Offset="0x1A489FC", VA="0x1A489FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB4C", Offset="0x107AB4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A48F70", Offset="0x1A48F70", VA="0x1A48F70", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB8C", Offset="0x107AB8C")]
		public void MergeFrom(ClubActivity other)
		{
		}

		[Address(RVA="0x1A49070", Offset="0x1A49070", VA="0x1A49070", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB9C", Offset="0x107AB9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A48B10", Offset="0x1A48B10", VA="0x1A48B10", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB5C", Offset="0x107AB5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A48B78", Offset="0x1A48B78", VA="0x1A48B78", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AB6C", Offset="0x107AB6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F6C8", Offset="0x104F6C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubActivity.<>c <>9;

			[Address(RVA="0x1A49464", Offset="0x1A49464", VA="0x1A49464")]
			static <>c()
			{
			}

			[Address(RVA="0x1A494C8", Offset="0x1A494C8", VA="0x1A494C8")]
			public <>c()
			{
			}

			[Address(RVA="0x1A494D0", Offset="0x1A494D0", VA="0x1A494D0")]
			internal ClubActivity <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}