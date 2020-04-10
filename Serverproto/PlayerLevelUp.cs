using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerLevelUp : IMessage<PlayerLevelUp>, IMessage, IEquatable<PlayerLevelUp>, IDeepCloneable<PlayerLevelUp>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerLevelUp> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerLevelFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong playerLevel_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10989F0", Offset="0x10989F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AFB9EC", Offset="0x1AFB9EC", VA="0x1AFB9EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A20", Offset="0x1098A20")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1AFBBB8", Offset="0x1AFBBB8", VA="0x1AFBBB8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFBBC0", Offset="0x1AFBBC0", VA="0x1AFBBC0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10989E0", Offset="0x10989E0")]
		public static MessageParser<PlayerLevelUp> Parser
		{
			[Address(RVA="0x1AFB984", Offset="0x1AFB984", VA="0x1AFB984")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A00", Offset="0x1098A00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AFBADC", Offset="0x1AFBADC", VA="0x1AFBADC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A10", Offset="0x1098A10")]
		public ulong PlayerLevel
		{
			[Address(RVA="0x1AFBC28", Offset="0x1AFBC28", VA="0x1AFBC28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AFBC30", Offset="0x1AFBC30", VA="0x1AFBC30")]
			set
			{
			}
		}

		[Address(RVA="0x1AFC198", Offset="0x1AFC198", VA="0x1AFC198")]
		static PlayerLevelUp()
		{
		}

		[Address(RVA="0x1AFBB38", Offset="0x1AFBB38", VA="0x1AFBB38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081BBC", Offset="0x1081BBC")]
		public PlayerLevelUp()
		{
		}

		[Address(RVA="0x1AFBB40", Offset="0x1AFBB40", VA="0x1AFBB40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081BCC", Offset="0x1081BCC")]
		public PlayerLevelUp(PlayerLevelUp other)
		{
		}

		[Address(RVA="0x1AFBF00", Offset="0x1AFBF00", VA="0x1AFBF00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C3C", Offset="0x1081C3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AFBBC8", Offset="0x1AFBBC8", VA="0x1AFBBC8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081BDC", Offset="0x1081BDC")]
		public PlayerLevelUp Clone()
		{
			return null;
		}

		[Address(RVA="0x1AFBC38", Offset="0x1AFBC38", VA="0x1AFBC38", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081BEC", Offset="0x1081BEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFBCAC", Offset="0x1AFBCAC", VA="0x1AFBCAC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081BFC", Offset="0x1081BFC")]
		public bool Equals(PlayerLevelUp other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFBD20", Offset="0x1AFBD20", VA="0x1AFBD20", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C0C", Offset="0x1081C0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFBFD4", Offset="0x1AFBFD4", VA="0x1AFBFD4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C4C", Offset="0x1081C4C")]
		public void MergeFrom(PlayerLevelUp other)
		{
		}

		[Address(RVA="0x1AFC094", Offset="0x1AFC094", VA="0x1AFC094", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C5C", Offset="0x1081C5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AFBDA0", Offset="0x1AFBDA0", VA="0x1AFBDA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C1C", Offset="0x1081C1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AFBE08", Offset="0x1AFBE08", VA="0x1AFBE08", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C2C", Offset="0x1081C2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050118", Offset="0x1050118")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerLevelUp.<>c <>9;

			[Address(RVA="0x1AFC270", Offset="0x1AFC270", VA="0x1AFC270")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFC2D4", Offset="0x1AFC2D4", VA="0x1AFC2D4")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFC2DC", Offset="0x1AFC2DC", VA="0x1AFC2DC")]
			internal PlayerLevelUp <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}