using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class Tower : IMessage<Tower>, IMessage, IEquatable<Tower>, IDeepCloneable<Tower>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Tower> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NodesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<TowerNode> _repeated_nodes_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<TowerNode> nodes_;

		[FieldOffset(Offset="0x0")]
		public const int DefIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong defId_;

		[FieldOffset(Offset="0x0")]
		public const int MapsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<TowerMap> _repeated_maps_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<TowerMap> maps_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private long sortOrder_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC98", Offset="0x109CC98")]
		public ulong DefId
		{
			[Address(RVA="0x1B6C888", Offset="0x1B6C888", VA="0x1B6C888")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B6C890", Offset="0x1B6C890", VA="0x1B6C890")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC68", Offset="0x109CC68")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6C508", Offset="0x1B6C508", VA="0x1B6C508")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CCA8", Offset="0x109CCA8")]
		public RepeatedField<TowerMap> Maps
		{
			[Address(RVA="0x1B6C898", Offset="0x1B6C898", VA="0x1B6C898")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC88", Offset="0x109CC88")]
		public RepeatedField<TowerNode> Nodes
		{
			[Address(RVA="0x1B6C880", Offset="0x1B6C880", VA="0x1B6C880")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC58", Offset="0x109CC58")]
		public static MessageParser<Tower> Parser
		{
			[Address(RVA="0x1B6C4A0", Offset="0x1B6C4A0", VA="0x1B6C4A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC78", Offset="0x109CC78")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6C65C", Offset="0x1B6C65C", VA="0x1B6C65C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CCB8", Offset="0x109CCB8")]
		public long SortOrder
		{
			[Address(RVA="0x1B6C8A0", Offset="0x1B6C8A0", VA="0x1B6C8A0")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1B6C8A8", Offset="0x1B6C8A8", VA="0x1B6C8A8")]
			set
			{
			}
		}

		[Address(RVA="0x1B6D108", Offset="0x1B6D108", VA="0x1B6D108")]
		static Tower()
		{
		}

		[Address(RVA="0x1B6C6B8", Offset="0x1B6C6B8", VA="0x1B6C6B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108944C", Offset="0x108944C")]
		public Tower()
		{
		}

		[Address(RVA="0x1B6C750", Offset="0x1B6C750", VA="0x1B6C750")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108945C", Offset="0x108945C")]
		public Tower(Tower other)
		{
		}

		[Address(RVA="0x1B6CD28", Offset="0x1B6CD28", VA="0x1B6CD28", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10894CC", Offset="0x10894CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6C820", Offset="0x1B6C820", VA="0x1B6C820", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108946C", Offset="0x108946C")]
		public Tower Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6C8B0", Offset="0x1B6C8B0", VA="0x1B6C8B0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108947C", Offset="0x108947C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6C924", Offset="0x1B6C924", VA="0x1B6C924", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108948C", Offset="0x108948C")]
		public bool Equals(Tower other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6CA24", Offset="0x1B6CA24", VA="0x1B6CA24", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108949C", Offset="0x108949C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6CEA8", Offset="0x1B6CEA8", VA="0x1B6CEA8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10894DC", Offset="0x10894DC")]
		public void MergeFrom(Tower other)
		{
		}

		[Address(RVA="0x1B6CF7C", Offset="0x1B6CF7C", VA="0x1B6CF7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10894EC", Offset="0x10894EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6CAF0", Offset="0x1B6CAF0", VA="0x1B6CAF0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10894AC", Offset="0x10894AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6CB58", Offset="0x1B6CB58", VA="0x1B6CB58", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10894BC", Offset="0x10894BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C18", Offset="0x1050C18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Tower.<>c <>9;

			[Address(RVA="0x1B6D340", Offset="0x1B6D340", VA="0x1B6D340")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6D3A4", Offset="0x1B6D3A4", VA="0x1B6D3A4")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6D3AC", Offset="0x1B6D3AC", VA="0x1B6D3AC")]
			internal Tower <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}