using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerBattleStartResponse : IMessage<TowerBattleStartResponse>, IMessage, IEquatable<TowerBattleStartResponse>, IDeepCloneable<TowerBattleStartResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerBattleStartResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F40", Offset="0x1092F40")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1B70E18", Offset="0x1B70E18", VA="0x1B70E18")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B70E20", Offset="0x1B70E20", VA="0x1B70E20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F20", Offset="0x1092F20")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B70B7C", Offset="0x1B70B7C", VA="0x1B70B7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F10", Offset="0x1092F10")]
		public static MessageParser<TowerBattleStartResponse> Parser
		{
			[Address(RVA="0x1B70B14", Offset="0x1B70B14", VA="0x1B70B14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F30", Offset="0x1092F30")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B70C6C", Offset="0x1B70C6C", VA="0x1B70C6C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F50", Offset="0x1092F50")]
		public ulong PlayerId
		{
			[Address(RVA="0x1B70E90", Offset="0x1B70E90", VA="0x1B70E90")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B70E98", Offset="0x1B70E98", VA="0x1B70E98")]
			set
			{
			}
		}

		[Address(RVA="0x1B71420", Offset="0x1B71420", VA="0x1B71420")]
		static TowerBattleStartResponse()
		{
		}

		[Address(RVA="0x1B70CC8", Offset="0x1B70CC8", VA="0x1B70CC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D3C", Offset="0x1077D3C")]
		public TowerBattleStartResponse()
		{
		}

		[Address(RVA="0x1B70D3C", Offset="0x1B70D3C", VA="0x1B70D3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D4C", Offset="0x1077D4C")]
		public TowerBattleStartResponse(TowerBattleStartResponse other)
		{
		}

		[Address(RVA="0x1B71204", Offset="0x1B71204", VA="0x1B71204", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077DBC", Offset="0x1077DBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B70DB8", Offset="0x1B70DB8", VA="0x1B70DB8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D5C", Offset="0x1077D5C")]
		public TowerBattleStartResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B70EA0", Offset="0x1B70EA0", VA="0x1B70EA0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D6C", Offset="0x1077D6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B70F14", Offset="0x1B70F14", VA="0x1B70F14", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D7C", Offset="0x1077D7C")]
		public bool Equals(TowerBattleStartResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B70FE0", Offset="0x1B70FE0", VA="0x1B70FE0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D8C", Offset="0x1077D8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B712FC", Offset="0x1B712FC", VA="0x1B712FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077DCC", Offset="0x1077DCC")]
		public void MergeFrom(TowerBattleStartResponse other)
		{
		}

		[Address(RVA="0x1B71374", Offset="0x1B71374", VA="0x1B71374", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077DDC", Offset="0x1077DDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B7108C", Offset="0x1B7108C", VA="0x1B7108C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D9C", Offset="0x1077D9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B710F4", Offset="0x1B710F4", VA="0x1B710F4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077DAC", Offset="0x1077DAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F268", Offset="0x104F268")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerBattleStartResponse.<>c <>9;

			[Address(RVA="0x1B714F8", Offset="0x1B714F8", VA="0x1B714F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1B7155C", Offset="0x1B7155C", VA="0x1B7155C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B71564", Offset="0x1B71564", VA="0x1B71564")]
			internal TowerBattleStartResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}