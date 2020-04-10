using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerResponse : IMessage<PlayerResponse>, IMessage, IEquatable<PlayerResponse>, IDeepCloneable<PlayerResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Player player_;

		[FieldOffset(Offset="0x0")]
		public const int SyncTimeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong syncTime_;

		[FieldOffset(Offset="0x0")]
		public const int TotalSpendFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private float totalSpend_;

		[FieldOffset(Offset="0x0")]
		public const int ChatHistoryFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ChatMessage> _repeated_chatHistory_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ChatMessage> chatHistory_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A280", Offset="0x109A280")]
		public RepeatedField<ChatMessage> ChatHistory
		{
			[Address(RVA="0x1B0F45C", Offset="0x1B0F45C", VA="0x1B0F45C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A230", Offset="0x109A230")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B0F13C", Offset="0x1B0F13C", VA="0x1B0F13C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A220", Offset="0x109A220")]
		public static MessageParser<PlayerResponse> Parser
		{
			[Address(RVA="0x1B0EACC", Offset="0x1B0EACC", VA="0x1B0EACC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A240", Offset="0x109A240")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B0F228", Offset="0x1B0F228", VA="0x1B0F228", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A250", Offset="0x109A250")]
		public Serverproto.Player Player
		{
			[Address(RVA="0x1B0F3CC", Offset="0x1B0F3CC", VA="0x1B0F3CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B0F3D4", Offset="0x1B0F3D4", VA="0x1B0F3D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A260", Offset="0x109A260")]
		public ulong SyncTime
		{
			[Address(RVA="0x1B0F43C", Offset="0x1B0F43C", VA="0x1B0F43C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B0F444", Offset="0x1B0F444", VA="0x1B0F444")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A270", Offset="0x109A270")]
		public float TotalSpend
		{
			[Address(RVA="0x1B0F44C", Offset="0x1B0F44C", VA="0x1B0F44C")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1B0F454", Offset="0x1B0F454", VA="0x1B0F454")]
			set
			{
			}
		}

		[Address(RVA="0x1B0FD70", Offset="0x1B0FD70", VA="0x1B0FD70")]
		static PlayerResponse()
		{
		}

		[Address(RVA="0x1B0F284", Offset="0x1B0F284", VA="0x1B0F284")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083FBC", Offset="0x1083FBC")]
		public PlayerResponse()
		{
		}

		[Address(RVA="0x1B0F2F4", Offset="0x1B0F2F4", VA="0x1B0F2F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083FCC", Offset="0x1083FCC")]
		public PlayerResponse(PlayerResponse other)
		{
		}

		[Address(RVA="0x1B0F98C", Offset="0x1B0F98C", VA="0x1B0F98C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108403C", Offset="0x108403C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B0F3DC", Offset="0x1B0F3DC", VA="0x1B0F3DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083FDC", Offset="0x1083FDC")]
		public PlayerResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B0F464", Offset="0x1B0F464", VA="0x1B0F464", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083FEC", Offset="0x1083FEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B0F4D8", Offset="0x1B0F4D8", VA="0x1B0F4D8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083FFC", Offset="0x1083FFC")]
		public bool Equals(PlayerResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B0F610", Offset="0x1B0F610", VA="0x1B0F610", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108400C", Offset="0x108400C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B0FADC", Offset="0x1B0FADC", VA="0x1B0FADC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108404C", Offset="0x108404C")]
		public void MergeFrom(PlayerResponse other)
		{
		}

		[Address(RVA="0x1B0FBD8", Offset="0x1B0FBD8", VA="0x1B0FBD8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108405C", Offset="0x108405C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B0F748", Offset="0x1B0F748", VA="0x1B0F748", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108401C", Offset="0x108401C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B0F7B0", Offset="0x1B0F7B0", VA="0x1B0F7B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108402C", Offset="0x108402C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050458", Offset="0x1050458")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerResponse.<>c <>9;

			[Address(RVA="0x1B0FE94", Offset="0x1B0FE94", VA="0x1B0FE94")]
			static <>c()
			{
			}

			[Address(RVA="0x1B0FEF8", Offset="0x1B0FEF8", VA="0x1B0FEF8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B0FF00", Offset="0x1B0FF00", VA="0x1B0FF00")]
			internal PlayerResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}