using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RegisterBattleServerRequest : IMessage<RegisterBattleServerRequest>, IMessage, IEquatable<RegisterBattleServerRequest>, IDeepCloneable<RegisterBattleServerRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RegisterBattleServerRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AddrFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string addr_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092970", Offset="0x1092970")]
		public string Addr
		{
			[Address(RVA="0x202292C", Offset="0x202292C", VA="0x202292C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2022934", Offset="0x2022934", VA="0x2022934")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092950", Offset="0x1092950")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20226C8", Offset="0x20226C8", VA="0x20226C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092940", Offset="0x1092940")]
		public static MessageParser<RegisterBattleServerRequest> Parser
		{
			[Address(RVA="0x2022660", Offset="0x2022660", VA="0x2022660")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092960", Offset="0x1092960")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20227B8", Offset="0x20227B8", VA="0x20227B8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2022DC4", Offset="0x2022DC4", VA="0x2022DC4")]
		static RegisterBattleServerRequest()
		{
		}

		[Address(RVA="0x2022814", Offset="0x2022814", VA="0x2022814")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10770DC", Offset="0x10770DC")]
		public RegisterBattleServerRequest()
		{
		}

		[Address(RVA="0x202286C", Offset="0x202286C", VA="0x202286C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10770EC", Offset="0x10770EC")]
		public RegisterBattleServerRequest(RegisterBattleServerRequest other)
		{
		}

		[Address(RVA="0x2022C20", Offset="0x2022C20", VA="0x2022C20", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107715C", Offset="0x107715C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x20228CC", Offset="0x20228CC", VA="0x20228CC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10770FC", Offset="0x10770FC")]
		public RegisterBattleServerRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x20229A4", Offset="0x20229A4", VA="0x20229A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107710C", Offset="0x107710C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2022A18", Offset="0x2022A18", VA="0x2022A18", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107711C", Offset="0x107711C")]
		public bool Equals(RegisterBattleServerRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2022A7C", Offset="0x2022A7C", VA="0x2022A7C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107712C", Offset="0x107712C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2022CD4", Offset="0x2022CD4", VA="0x2022CD4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107716C", Offset="0x107716C")]
		public void MergeFrom(RegisterBattleServerRequest other)
		{
		}

		[Address(RVA="0x2022D40", Offset="0x2022D40", VA="0x2022D40", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107717C", Offset="0x107717C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2022B00", Offset="0x2022B00", VA="0x2022B00", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107713C", Offset="0x107713C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2022B68", Offset="0x2022B68", VA="0x2022B68", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107714C", Offset="0x107714C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F148", Offset="0x104F148")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RegisterBattleServerRequest.<>c <>9;

			[Address(RVA="0x2022E9C", Offset="0x2022E9C", VA="0x2022E9C")]
			static <>c()
			{
			}

			[Address(RVA="0x2022F00", Offset="0x2022F00", VA="0x2022F00")]
			public <>c()
			{
			}

			[Address(RVA="0x2022F08", Offset="0x2022F08", VA="0x2022F08")]
			internal RegisterBattleServerRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}