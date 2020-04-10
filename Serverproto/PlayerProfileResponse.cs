using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerProfileResponse : IMessage<PlayerProfileResponse>, IMessage, IEquatable<PlayerProfileResponse>, IDeepCloneable<PlayerProfileResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerProfileResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Player player_;

		[FieldOffset(Offset="0x0")]
		public const int StatsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PlayerStat> _repeated_stats_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<PlayerStat> stats_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A660", Offset="0x109A660")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AFCDBC", Offset="0x1AFCDBC", VA="0x1AFCDBC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A650", Offset="0x109A650")]
		public static MessageParser<PlayerProfileResponse> Parser
		{
			[Address(RVA="0x1AFCD54", Offset="0x1AFCD54", VA="0x1AFCD54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A670", Offset="0x109A670")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AFCEA8", Offset="0x1AFCEA8", VA="0x1AFCEA8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A680", Offset="0x109A680")]
		public Serverproto.Player Player
		{
			[Address(RVA="0x1AFD03C", Offset="0x1AFD03C", VA="0x1AFD03C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFD044", Offset="0x1AFD044", VA="0x1AFD044")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A690", Offset="0x109A690")]
		public RepeatedField<PlayerStat> Stats
		{
			[Address(RVA="0x1AFD0AC", Offset="0x1AFD0AC", VA="0x1AFD0AC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AFD714", Offset="0x1AFD714", VA="0x1AFD714")]
		static PlayerProfileResponse()
		{
		}

		[Address(RVA="0x1AFCF04", Offset="0x1AFCF04", VA="0x1AFCF04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10848AC", Offset="0x10848AC")]
		public PlayerProfileResponse()
		{
		}

		[Address(RVA="0x1AFCF74", Offset="0x1AFCF74", VA="0x1AFCF74")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10848BC", Offset="0x10848BC")]
		public PlayerProfileResponse(PlayerProfileResponse other)
		{
		}

		[Address(RVA="0x1AFD3F8", Offset="0x1AFD3F8", VA="0x1AFD3F8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108492C", Offset="0x108492C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AFD04C", Offset="0x1AFD04C", VA="0x1AFD04C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10848CC", Offset="0x10848CC")]
		public PlayerProfileResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1AFD0B4", Offset="0x1AFD0B4", VA="0x1AFD0B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10848DC", Offset="0x10848DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFD128", Offset="0x1AFD128", VA="0x1AFD128", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10848EC", Offset="0x10848EC")]
		public bool Equals(PlayerProfileResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFD1EC", Offset="0x1AFD1EC", VA="0x1AFD1EC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10848FC", Offset="0x10848FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFD4F4", Offset="0x1AFD4F4", VA="0x1AFD4F4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108493C", Offset="0x108493C")]
		public void MergeFrom(PlayerProfileResponse other)
		{
		}

		[Address(RVA="0x1AFD5D4", Offset="0x1AFD5D4", VA="0x1AFD5D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108494C", Offset="0x108494C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AFD274", Offset="0x1AFD274", VA="0x1AFD274", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108490C", Offset="0x108490C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AFD2DC", Offset="0x1AFD2DC", VA="0x1AFD2DC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108491C", Offset="0x108491C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050528", Offset="0x1050528")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerProfileResponse.<>c <>9;

			[Address(RVA="0x1AFD89C", Offset="0x1AFD89C", VA="0x1AFD89C")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFD900", Offset="0x1AFD900", VA="0x1AFD900")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFD908", Offset="0x1AFD908", VA="0x1AFD908")]
			internal PlayerProfileResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}