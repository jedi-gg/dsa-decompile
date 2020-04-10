using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerNode : IMessage<TowerNode>, IMessage, IEquatable<TowerNode>, IDeepCloneable<TowerNode>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerNode> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong id_;

		[FieldOffset(Offset="0x0")]
		public const int BattleDataFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private BattleNode battleData_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CDC8", Offset="0x109CDC8")]
		public BattleNode BattleData
		{
			[Address(RVA="0x1B737E8", Offset="0x1B737E8", VA="0x1B737E8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B737F0", Offset="0x1B737F0", VA="0x1B737F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD98", Offset="0x109CD98")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B73620", Offset="0x1B73620", VA="0x1B73620")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CDB8", Offset="0x109CDB8")]
		public ulong Id
		{
			[Address(RVA="0x1B73858", Offset="0x1B73858", VA="0x1B73858")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B73860", Offset="0x1B73860", VA="0x1B73860")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD88", Offset="0x109CD88")]
		public static MessageParser<TowerNode> Parser
		{
			[Address(RVA="0x1B6D270", Offset="0x1B6D270", VA="0x1B6D270")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CDA8", Offset="0x109CDA8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B7370C", Offset="0x1B7370C", VA="0x1B7370C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B73DC8", Offset="0x1B73DC8", VA="0x1B73DC8")]
		static TowerNode()
		{
		}

		[Address(RVA="0x1B73768", Offset="0x1B73768", VA="0x1B73768")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10895AC", Offset="0x10895AC")]
		public TowerNode()
		{
		}

		[Address(RVA="0x1B73770", Offset="0x1B73770", VA="0x1B73770")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10895BC", Offset="0x10895BC")]
		public TowerNode(TowerNode other)
		{
		}

		[Address(RVA="0x1B73B30", Offset="0x1B73B30", VA="0x1B73B30", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108962C", Offset="0x108962C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B737F8", Offset="0x1B737F8", VA="0x1B737F8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10895CC", Offset="0x10895CC")]
		public TowerNode Clone()
		{
			return null;
		}

		[Address(RVA="0x1B73868", Offset="0x1B73868", VA="0x1B73868", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10895DC", Offset="0x10895DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B738DC", Offset="0x1B738DC", VA="0x1B738DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10895EC", Offset="0x10895EC")]
		public bool Equals(TowerNode other)
		{
			return new bool();
		}

		[Address(RVA="0x1B73950", Offset="0x1B73950", VA="0x1B73950", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10895FC", Offset="0x10895FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B73C04", Offset="0x1B73C04", VA="0x1B73C04", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108963C", Offset="0x108963C")]
		public void MergeFrom(TowerNode other)
		{
		}

		[Address(RVA="0x1B73CC4", Offset="0x1B73CC4", VA="0x1B73CC4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108964C", Offset="0x108964C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B739D0", Offset="0x1B739D0", VA="0x1B739D0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108960C", Offset="0x108960C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B73A38", Offset="0x1B73A38", VA="0x1B73A38", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108961C", Offset="0x108961C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C38", Offset="0x1050C38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerNode.<>c <>9;

			[Address(RVA="0x1B73EA0", Offset="0x1B73EA0", VA="0x1B73EA0")]
			static <>c()
			{
			}

			[Address(RVA="0x1B73F04", Offset="0x1B73F04", VA="0x1B73F04")]
			public <>c()
			{
			}

			[Address(RVA="0x1B73F0C", Offset="0x1B73F0C", VA="0x1B73F0C")]
			internal TowerNode <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}