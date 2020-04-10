using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SwapSorcererStoneResponse : IMessage<SwapSorcererStoneResponse>, IMessage, IEquatable<SwapSorcererStoneResponse>, IDeepCloneable<SwapSorcererStoneResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SwapSorcererStoneResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099300", Offset="0x1099300")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6BC68", Offset="0x1B6BC68", VA="0x1B6BC68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099320", Offset="0x1099320")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1B6BE38", Offset="0x1B6BE38", VA="0x1B6BE38")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6BE40", Offset="0x1B6BE40", VA="0x1B6BE40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10992F0", Offset="0x10992F0")]
		public static MessageParser<SwapSorcererStoneResponse> Parser
		{
			[Address(RVA="0x1B6BC00", Offset="0x1B6BC00", VA="0x1B6BC00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099310", Offset="0x1099310")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6BD58", Offset="0x1B6BD58", VA="0x1B6BD58", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B6C300", Offset="0x1B6C300", VA="0x1B6C300")]
		static SwapSorcererStoneResponse()
		{
		}

		[Address(RVA="0x1B6BDB4", Offset="0x1B6BDB4", VA="0x1B6BDB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E4C", Offset="0x1082E4C")]
		public SwapSorcererStoneResponse()
		{
		}

		[Address(RVA="0x1B6BDBC", Offset="0x1B6BDBC", VA="0x1B6BDBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E5C", Offset="0x1082E5C")]
		public SwapSorcererStoneResponse(SwapSorcererStoneResponse other)
		{
		}

		[Address(RVA="0x1B6C0E0", Offset="0x1B6C0E0", VA="0x1B6C0E0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082ECC", Offset="0x1082ECC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6BE48", Offset="0x1B6BE48", VA="0x1B6BE48", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E6C", Offset="0x1082E6C")]
		public SwapSorcererStoneResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6BEA8", Offset="0x1B6BEA8", VA="0x1B6BEA8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E7C", Offset="0x1082E7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6BF1C", Offset="0x1B6BF1C", VA="0x1B6BF1C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E8C", Offset="0x1082E8C")]
		public bool Equals(SwapSorcererStoneResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6BF80", Offset="0x1B6BF80", VA="0x1B6BF80", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082E9C", Offset="0x1082E9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6C170", Offset="0x1B6C170", VA="0x1B6C170", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082EDC", Offset="0x1082EDC")]
		public void MergeFrom(SwapSorcererStoneResponse other)
		{
		}

		[Address(RVA="0x1B6C224", Offset="0x1B6C224", VA="0x1B6C224", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082EEC", Offset="0x1082EEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6BFD8", Offset="0x1B6BFD8", VA="0x1B6BFD8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082EAC", Offset="0x1082EAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6C040", Offset="0x1B6C040", VA="0x1B6C040", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082EBC", Offset="0x1082EBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10502C8", Offset="0x10502C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SwapSorcererStoneResponse.<>c <>9;

			[Address(RVA="0x1B6C3D8", Offset="0x1B6C3D8", VA="0x1B6C3D8")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6C43C", Offset="0x1B6C43C", VA="0x1B6C43C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6C444", Offset="0x1B6C444", VA="0x1B6C444")]
			internal SwapSorcererStoneResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}