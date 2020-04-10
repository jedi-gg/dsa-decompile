using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SetPlayerSquadSelectionRequest : IMessage<SetPlayerSquadSelectionRequest>, IMessage, IEquatable<SetPlayerSquadSelectionRequest>, IDeepCloneable<SetPlayerSquadSelectionRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SetPlayerSquadSelectionRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SquadSelectionFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerSquadSelection squadSelection_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A320", Offset="0x109A320")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD081C", Offset="0x1BD081C", VA="0x1BD081C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A310", Offset="0x109A310")]
		public static MessageParser<SetPlayerSquadSelectionRequest> Parser
		{
			[Address(RVA="0x1BD07B4", Offset="0x1BD07B4", VA="0x1BD07B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A330", Offset="0x109A330")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD090C", Offset="0x1BD090C", VA="0x1BD090C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A340", Offset="0x109A340")]
		public PlayerSquadSelection SquadSelection
		{
			[Address(RVA="0x1BD09EC", Offset="0x1BD09EC", VA="0x1BD09EC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD09F4", Offset="0x1BD09F4", VA="0x1BD09F4")]
			set
			{
			}
		}

		[Address(RVA="0x1BD0EB4", Offset="0x1BD0EB4", VA="0x1BD0EB4")]
		static SetPlayerSquadSelectionRequest()
		{
		}

		[Address(RVA="0x1BD0968", Offset="0x1BD0968", VA="0x1BD0968")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108411C", Offset="0x108411C")]
		public SetPlayerSquadSelectionRequest()
		{
		}

		[Address(RVA="0x1BD0970", Offset="0x1BD0970", VA="0x1BD0970")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108412C", Offset="0x108412C")]
		public SetPlayerSquadSelectionRequest(SetPlayerSquadSelectionRequest other)
		{
		}

		[Address(RVA="0x1BD0C94", Offset="0x1BD0C94", VA="0x1BD0C94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108419C", Offset="0x108419C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD09FC", Offset="0x1BD09FC", VA="0x1BD09FC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108413C", Offset="0x108413C")]
		public SetPlayerSquadSelectionRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD0A5C", Offset="0x1BD0A5C", VA="0x1BD0A5C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108414C", Offset="0x108414C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD0AD0", Offset="0x1BD0AD0", VA="0x1BD0AD0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108415C", Offset="0x108415C")]
		public bool Equals(SetPlayerSquadSelectionRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD0B34", Offset="0x1BD0B34", VA="0x1BD0B34", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108416C", Offset="0x108416C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD0D24", Offset="0x1BD0D24", VA="0x1BD0D24", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10841AC", Offset="0x10841AC")]
		public void MergeFrom(SetPlayerSquadSelectionRequest other)
		{
		}

		[Address(RVA="0x1BD0DD8", Offset="0x1BD0DD8", VA="0x1BD0DD8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10841BC", Offset="0x10841BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD0B8C", Offset="0x1BD0B8C", VA="0x1BD0B8C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108417C", Offset="0x108417C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD0BF4", Offset="0x1BD0BF4", VA="0x1BD0BF4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108418C", Offset="0x108418C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050478", Offset="0x1050478")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SetPlayerSquadSelectionRequest.<>c <>9;

			[Address(RVA="0x1BD0F8C", Offset="0x1BD0F8C", VA="0x1BD0F8C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD0FF0", Offset="0x1BD0FF0", VA="0x1BD0FF0")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD0FF8", Offset="0x1BD0FF8", VA="0x1BD0FF8")]
			internal SetPlayerSquadSelectionRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}