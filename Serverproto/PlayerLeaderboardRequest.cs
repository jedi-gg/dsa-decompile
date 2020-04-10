using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerLeaderboardRequest : IMessage<PlayerLeaderboardRequest>, IMessage, IEquatable<PlayerLeaderboardRequest>, IDeepCloneable<PlayerLeaderboardRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerLeaderboardRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerLeaderboardType type_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099530", Offset="0x1099530")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AFA72C", Offset="0x1AFA72C", VA="0x1AFA72C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099520", Offset="0x1099520")]
		public static MessageParser<PlayerLeaderboardRequest> Parser
		{
			[Address(RVA="0x1AFA6C4", Offset="0x1AFA6C4", VA="0x1AFA6C4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099540", Offset="0x1099540")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AFA81C", Offset="0x1AFA81C", VA="0x1AFA81C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099550", Offset="0x1099550")]
		public PlayerLeaderboardType Type
		{
			[Address(RVA="0x1AFA944", Offset="0x1AFA944", VA="0x1AFA944")]
			get
			{
				return new PlayerLeaderboardType();
			}
			[Address(RVA="0x1AFA94C", Offset="0x1AFA94C", VA="0x1AFA94C")]
			set
			{
			}
		}

		[Address(RVA="0x1AFACC0", Offset="0x1AFACC0", VA="0x1AFACC0")]
		static PlayerLeaderboardRequest()
		{
		}

		[Address(RVA="0x1AFA878", Offset="0x1AFA878", VA="0x1AFA878")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108331C", Offset="0x108331C")]
		public PlayerLeaderboardRequest()
		{
		}

		[Address(RVA="0x1AFA880", Offset="0x1AFA880", VA="0x1AFA880")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108332C", Offset="0x108332C")]
		public PlayerLeaderboardRequest(PlayerLeaderboardRequest other)
		{
		}

		[Address(RVA="0x1AFAB74", Offset="0x1AFAB74", VA="0x1AFAB74", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108339C", Offset="0x108339C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AFA8E4", Offset="0x1AFA8E4", VA="0x1AFA8E4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108333C", Offset="0x108333C")]
		public PlayerLeaderboardRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1AFA954", Offset="0x1AFA954", VA="0x1AFA954", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108334C", Offset="0x108334C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFA9C8", Offset="0x1AFA9C8", VA="0x1AFA9C8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108335C", Offset="0x108335C")]
		public bool Equals(PlayerLeaderboardRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFAA04", Offset="0x1AFAA04", VA="0x1AFAA04", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108336C", Offset="0x108336C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFAC04", Offset="0x1AFAC04", VA="0x1AFAC04", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10833AC", Offset="0x10833AC")]
		public void MergeFrom(PlayerLeaderboardRequest other)
		{
		}

		[Address(RVA="0x1AFAC44", Offset="0x1AFAC44", VA="0x1AFAC44", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10833BC", Offset="0x10833BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AFAA6C", Offset="0x1AFAA6C", VA="0x1AFAA6C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108337C", Offset="0x108337C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AFAAD4", Offset="0x1AFAAD4", VA="0x1AFAAD4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108338C", Offset="0x108338C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050338", Offset="0x1050338")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerLeaderboardRequest.<>c <>9;

			[Address(RVA="0x1AFAD98", Offset="0x1AFAD98", VA="0x1AFAD98")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFADFC", Offset="0x1AFADFC", VA="0x1AFADFC")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFAE04", Offset="0x1AFAE04", VA="0x1AFAE04")]
			internal PlayerLeaderboardRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}