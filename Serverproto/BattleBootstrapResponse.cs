using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleBootstrapResponse : IMessage<BattleBootstrapResponse>, IMessage, IEquatable<BattleBootstrapResponse>, IDeepCloneable<BattleBootstrapResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleBootstrapResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092920", Offset="0x1092920")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E71624", Offset="0x1E71624", VA="0x1E71624")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092910", Offset="0x1092910")]
		public static MessageParser<BattleBootstrapResponse> Parser
		{
			[Address(RVA="0x1E715BC", Offset="0x1E715BC", VA="0x1E715BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092930", Offset="0x1092930")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E71714", Offset="0x1E71714", VA="0x1E71714", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1E71A28", Offset="0x1E71A28", VA="0x1E71A28")]
		static BattleBootstrapResponse()
		{
		}

		[Address(RVA="0x1E71770", Offset="0x1E71770", VA="0x1E71770")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107702C", Offset="0x107702C")]
		public BattleBootstrapResponse()
		{
		}

		[Address(RVA="0x1E71778", Offset="0x1E71778", VA="0x1E71778")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107703C", Offset="0x107703C")]
		public BattleBootstrapResponse(BattleBootstrapResponse other)
		{
		}

		[Address(RVA="0x1E7198C", Offset="0x1E7198C", VA="0x1E7198C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10770AC", Offset="0x10770AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E717BC", Offset="0x1E717BC", VA="0x1E717BC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107704C", Offset="0x107704C")]
		public BattleBootstrapResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1E7181C", Offset="0x1E7181C", VA="0x1E7181C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107705C", Offset="0x107705C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E718B4", Offset="0x1E718B4", VA="0x1E718B4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107706C", Offset="0x107706C")]
		public bool Equals(BattleBootstrapResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1E718E0", Offset="0x1E718E0", VA="0x1E718E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107707C", Offset="0x107707C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E719A0", Offset="0x1E719A0", VA="0x1E719A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10770BC", Offset="0x10770BC")]
		public void MergeFrom(BattleBootstrapResponse other)
		{
		}

		[Address(RVA="0x1E719D4", Offset="0x1E719D4", VA="0x1E719D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10770CC", Offset="0x10770CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E71910", Offset="0x1E71910", VA="0x1E71910", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107708C", Offset="0x107708C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E71978", Offset="0x1E71978", VA="0x1E71978", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107709C", Offset="0x107709C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F138", Offset="0x104F138")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleBootstrapResponse.<>c <>9;

			[Address(RVA="0x1E71B00", Offset="0x1E71B00", VA="0x1E71B00")]
			static <>c()
			{
			}

			[Address(RVA="0x1E71B64", Offset="0x1E71B64", VA="0x1E71B64")]
			public <>c()
			{
			}

			[Address(RVA="0x1E71B6C", Offset="0x1E71B6C", VA="0x1E71B6C")]
			internal BattleBootstrapResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}