using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SwapSorcererStoneRequest : IMessage<SwapSorcererStoneRequest>, IMessage, IEquatable<SwapSorcererStoneRequest>, IDeepCloneable<SwapSorcererStoneRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SwapSorcererStoneRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int NewSorcererStoneIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong newSorcererStoneId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10992B0", Offset="0x10992B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6B3A4", Offset="0x1B6B3A4", VA="0x1B6B3A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10992E0", Offset="0x10992E0")]
		public ulong NewSorcererStoneId
		{
			[Address(RVA="0x1B6B5E8", Offset="0x1B6B5E8", VA="0x1B6B5E8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B6B5F0", Offset="0x1B6B5F0", VA="0x1B6B5F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10992A0", Offset="0x10992A0")]
		public static MessageParser<SwapSorcererStoneRequest> Parser
		{
			[Address(RVA="0x1B6B33C", Offset="0x1B6B33C", VA="0x1B6B33C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10992C0", Offset="0x10992C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6B494", Offset="0x1B6B494", VA="0x1B6B494", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10992D0", Offset="0x10992D0")]
		public ulong UnitId
		{
			[Address(RVA="0x1B6B5D8", Offset="0x1B6B5D8", VA="0x1B6B5D8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B6B5E0", Offset="0x1B6B5E0", VA="0x1B6B5E0")]
			set
			{
			}
		}

		[Address(RVA="0x1B6BA60", Offset="0x1B6BA60", VA="0x1B6BA60")]
		static SwapSorcererStoneRequest()
		{
		}

		[Address(RVA="0x1B6B4F0", Offset="0x1B6B4F0", VA="0x1B6B4F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D9C", Offset="0x1082D9C")]
		public SwapSorcererStoneRequest()
		{
		}

		[Address(RVA="0x1B6B4F8", Offset="0x1B6B4F8", VA="0x1B6B4F8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082DAC", Offset="0x1082DAC")]
		public SwapSorcererStoneRequest(SwapSorcererStoneRequest other)
		{
		}

		[Address(RVA="0x1B6B89C", Offset="0x1B6B89C", VA="0x1B6B89C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E1C", Offset="0x1082E1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6B578", Offset="0x1B6B578", VA="0x1B6B578", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082DBC", Offset="0x1082DBC")]
		public SwapSorcererStoneRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6B5F8", Offset="0x1B6B5F8", VA="0x1B6B5F8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082DCC", Offset="0x1082DCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6B66C", Offset="0x1B6B66C", VA="0x1B6B66C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082DDC", Offset="0x1082DDC")]
		public bool Equals(SwapSorcererStoneRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6B6B8", Offset="0x1B6B6B8", VA="0x1B6B6B8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082DEC", Offset="0x1082DEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6B970", Offset="0x1B6B970", VA="0x1B6B970", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E2C", Offset="0x1082E2C")]
		public void MergeFrom(SwapSorcererStoneRequest other)
		{
		}

		[Address(RVA="0x1B6B9BC", Offset="0x1B6B9BC", VA="0x1B6B9BC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E3C", Offset="0x1082E3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6B73C", Offset="0x1B6B73C", VA="0x1B6B73C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082DFC", Offset="0x1082DFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6B7A4", Offset="0x1B6B7A4", VA="0x1B6B7A4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E0C", Offset="0x1082E0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10502B8", Offset="0x10502B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SwapSorcererStoneRequest.<>c <>9;

			[Address(RVA="0x1B6BB38", Offset="0x1B6BB38", VA="0x1B6BB38")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6BB9C", Offset="0x1B6BB9C", VA="0x1B6BB9C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6BBA4", Offset="0x1B6BBA4", VA="0x1B6BBA4")]
			internal SwapSorcererStoneRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}