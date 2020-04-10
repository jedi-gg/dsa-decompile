using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerRequest : IMessage<PlayerRequest>, IMessage, IEquatable<PlayerRequest>, IDeepCloneable<PlayerRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A200", Offset="0x109A200")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B0EB9C", Offset="0x1B0EB9C", VA="0x1B0EB9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A1F0", Offset="0x109A1F0")]
		public static MessageParser<PlayerRequest> Parser
		{
			[Address(RVA="0x1B0EA64", Offset="0x1B0EA64", VA="0x1B0EA64")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A210", Offset="0x109A210")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B0EC88", Offset="0x1B0EC88", VA="0x1B0EC88", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B0EF9C", Offset="0x1B0EF9C", VA="0x1B0EF9C")]
		static PlayerRequest()
		{
		}

		[Address(RVA="0x1B0ECE4", Offset="0x1B0ECE4", VA="0x1B0ECE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F0C", Offset="0x1083F0C")]
		public PlayerRequest()
		{
		}

		[Address(RVA="0x1B0ECEC", Offset="0x1B0ECEC", VA="0x1B0ECEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F1C", Offset="0x1083F1C")]
		public PlayerRequest(PlayerRequest other)
		{
		}

		[Address(RVA="0x1B0EF00", Offset="0x1B0EF00", VA="0x1B0EF00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F8C", Offset="0x1083F8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B0ED30", Offset="0x1B0ED30", VA="0x1B0ED30", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F2C", Offset="0x1083F2C")]
		public PlayerRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B0ED90", Offset="0x1B0ED90", VA="0x1B0ED90", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F3C", Offset="0x1083F3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B0EE28", Offset="0x1B0EE28", VA="0x1B0EE28", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F4C", Offset="0x1083F4C")]
		public bool Equals(PlayerRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B0EE54", Offset="0x1B0EE54", VA="0x1B0EE54", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F5C", Offset="0x1083F5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B0EF14", Offset="0x1B0EF14", VA="0x1B0EF14", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F9C", Offset="0x1083F9C")]
		public void MergeFrom(PlayerRequest other)
		{
		}

		[Address(RVA="0x1B0EF48", Offset="0x1B0EF48", VA="0x1B0EF48", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083FAC", Offset="0x1083FAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B0EE84", Offset="0x1B0EE84", VA="0x1B0EE84", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F6C", Offset="0x1083F6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B0EEEC", Offset="0x1B0EEEC", VA="0x1B0EEEC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083F7C", Offset="0x1083F7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050448", Offset="0x1050448")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerRequest.<>c <>9;

			[Address(RVA="0x1B0F074", Offset="0x1B0F074", VA="0x1B0F074")]
			static <>c()
			{
			}

			[Address(RVA="0x1B0F0D8", Offset="0x1B0F0D8", VA="0x1B0F0D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B0F0E0", Offset="0x1B0F0E0", VA="0x1B0F0E0")]
			internal PlayerRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}