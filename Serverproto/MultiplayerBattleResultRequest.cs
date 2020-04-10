using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MultiplayerBattleResultRequest : IMessage<MultiplayerBattleResultRequest>, IMessage, IEquatable<MultiplayerBattleResultRequest>, IDeepCloneable<MultiplayerBattleResultRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MultiplayerBattleResultRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string battleId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A90", Offset="0x1092A90")]
		public string BattleId
		{
			[Address(RVA="0x1A24080", Offset="0x1A24080", VA="0x1A24080")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A24088", Offset="0x1A24088", VA="0x1A24088")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A70", Offset="0x1092A70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A23E1C", Offset="0x1A23E1C", VA="0x1A23E1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A60", Offset="0x1092A60")]
		public static MessageParser<MultiplayerBattleResultRequest> Parser
		{
			[Address(RVA="0x1A23DB4", Offset="0x1A23DB4", VA="0x1A23DB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A80", Offset="0x1092A80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A23F0C", Offset="0x1A23F0C", VA="0x1A23F0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A24518", Offset="0x1A24518", VA="0x1A24518")]
		static MultiplayerBattleResultRequest()
		{
		}

		[Address(RVA="0x1A23F68", Offset="0x1A23F68", VA="0x1A23F68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107739C", Offset="0x107739C")]
		public MultiplayerBattleResultRequest()
		{
		}

		[Address(RVA="0x1A23FC0", Offset="0x1A23FC0", VA="0x1A23FC0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10773AC", Offset="0x10773AC")]
		public MultiplayerBattleResultRequest(MultiplayerBattleResultRequest other)
		{
		}

		[Address(RVA="0x1A24374", Offset="0x1A24374", VA="0x1A24374", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107741C", Offset="0x107741C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A24020", Offset="0x1A24020", VA="0x1A24020", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10773BC", Offset="0x10773BC")]
		public MultiplayerBattleResultRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A240F8", Offset="0x1A240F8", VA="0x1A240F8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10773CC", Offset="0x10773CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A2416C", Offset="0x1A2416C", VA="0x1A2416C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10773DC", Offset="0x10773DC")]
		public bool Equals(MultiplayerBattleResultRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A241D0", Offset="0x1A241D0", VA="0x1A241D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10773EC", Offset="0x10773EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A24428", Offset="0x1A24428", VA="0x1A24428", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107742C", Offset="0x107742C")]
		public void MergeFrom(MultiplayerBattleResultRequest other)
		{
		}

		[Address(RVA="0x1A24494", Offset="0x1A24494", VA="0x1A24494", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107743C", Offset="0x107743C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A24254", Offset="0x1A24254", VA="0x1A24254", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10773FC", Offset="0x10773FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A242BC", Offset="0x1A242BC", VA="0x1A242BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107740C", Offset="0x107740C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F188", Offset="0x104F188")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MultiplayerBattleResultRequest.<>c <>9;

			[Address(RVA="0x1A245F0", Offset="0x1A245F0", VA="0x1A245F0")]
			static <>c()
			{
			}

			[Address(RVA="0x1A24654", Offset="0x1A24654", VA="0x1A24654")]
			public <>c()
			{
			}

			[Address(RVA="0x1A2465C", Offset="0x1A2465C", VA="0x1A2465C")]
			internal MultiplayerBattleResultRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}