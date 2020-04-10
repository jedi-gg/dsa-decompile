using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonNode : IMessage<ClubDungeonNode>, IMessage, IEquatable<ClubDungeonNode>, IDeepCloneable<ClubDungeonNode>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonNode> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleDataFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleNode battleData_;

		[FieldOffset(Offset="0x0")]
		public const int NodeTypeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong nodeType_;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095680", Offset="0x1095680")]
		public BattleNode BattleData
		{
			[Address(RVA="0x1FF1774", Offset="0x1FF1774", VA="0x1FF1774")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF177C", Offset="0x1FF177C", VA="0x1FF177C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095660", Offset="0x1095660")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF1530", Offset="0x1FF1530", VA="0x1FF1530")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10956A0", Offset="0x10956A0")]
		public ulong Id
		{
			[Address(RVA="0x1FF17F4", Offset="0x1FF17F4", VA="0x1FF17F4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF17FC", Offset="0x1FF17FC", VA="0x1FF17FC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095690", Offset="0x1095690")]
		public ulong NodeType
		{
			[Address(RVA="0x1FF17E4", Offset="0x1FF17E4", VA="0x1FF17E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF17EC", Offset="0x1FF17EC", VA="0x1FF17EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095650", Offset="0x1095650")]
		public static MessageParser<ClubDungeonNode> Parser
		{
			[Address(RVA="0x1FF14C8", Offset="0x1FF14C8", VA="0x1FF14C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095670", Offset="0x1095670")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF1684", Offset="0x1FF1684", VA="0x1FF1684", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FF1E60", Offset="0x1FF1E60", VA="0x1FF1E60")]
		static ClubDungeonNode()
		{
		}

		[Address(RVA="0x1FF16E0", Offset="0x1FF16E0", VA="0x1FF16E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C72C", Offset="0x107C72C")]
		public ClubDungeonNode()
		{
		}

		[Address(RVA="0x1FF16E8", Offset="0x1FF16E8", VA="0x1FF16E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C73C", Offset="0x107C73C")]
		public ClubDungeonNode(ClubDungeonNode other)
		{
		}

		[Address(RVA="0x1FF1B50", Offset="0x1FF1B50", VA="0x1FF1B50", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C7AC", Offset="0x107C7AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF1784", Offset="0x1FF1784", VA="0x1FF1784", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C74C", Offset="0x107C74C")]
		public ClubDungeonNode Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF1804", Offset="0x1FF1804", VA="0x1FF1804", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C75C", Offset="0x107C75C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF1878", Offset="0x1FF1878", VA="0x1FF1878", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C76C", Offset="0x107C76C")]
		public bool Equals(ClubDungeonNode other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF18FC", Offset="0x1FF18FC", VA="0x1FF18FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C77C", Offset="0x107C77C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF1C60", Offset="0x1FF1C60", VA="0x1FF1C60", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C7BC", Offset="0x107C7BC")]
		public void MergeFrom(ClubDungeonNode other)
		{
		}

		[Address(RVA="0x1FF1D2C", Offset="0x1FF1D2C", VA="0x1FF1D2C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C7CC", Offset="0x107C7CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF1998", Offset="0x1FF1998", VA="0x1FF1998", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C78C", Offset="0x107C78C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF1A00", Offset="0x1FF1A00", VA="0x1FF1A00", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C79C", Offset="0x107C79C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F958", Offset="0x104F958")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonNode.<>c <>9;

			[Address(RVA="0x1FF1F38", Offset="0x1FF1F38", VA="0x1FF1F38")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF1F9C", Offset="0x1FF1F9C", VA="0x1FF1F9C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF1FA4", Offset="0x1FF1FA4", VA="0x1FF1FA4")]
			internal ClubDungeonNode <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}