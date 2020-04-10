using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RegisterBattleServerResponse : IMessage<RegisterBattleServerResponse>, IMessage, IEquatable<RegisterBattleServerResponse>, IDeepCloneable<RegisterBattleServerResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RegisterBattleServerResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092990", Offset="0x1092990")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2022FC8", Offset="0x2022FC8", VA="0x2022FC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092980", Offset="0x1092980")]
		public static MessageParser<RegisterBattleServerResponse> Parser
		{
			[Address(RVA="0x2022F60", Offset="0x2022F60", VA="0x2022F60")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10929A0", Offset="0x10929A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20230B8", Offset="0x20230B8", VA="0x20230B8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x20233CC", Offset="0x20233CC", VA="0x20233CC")]
		static RegisterBattleServerResponse()
		{
		}

		[Address(RVA="0x2023114", Offset="0x2023114", VA="0x2023114")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107718C", Offset="0x107718C")]
		public RegisterBattleServerResponse()
		{
		}

		[Address(RVA="0x202311C", Offset="0x202311C", VA="0x202311C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107719C", Offset="0x107719C")]
		public RegisterBattleServerResponse(RegisterBattleServerResponse other)
		{
		}

		[Address(RVA="0x2023330", Offset="0x2023330", VA="0x2023330", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107720C", Offset="0x107720C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2023160", Offset="0x2023160", VA="0x2023160", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10771AC", Offset="0x10771AC")]
		public RegisterBattleServerResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x20231C0", Offset="0x20231C0", VA="0x20231C0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10771BC", Offset="0x10771BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2023258", Offset="0x2023258", VA="0x2023258", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10771CC", Offset="0x10771CC")]
		public bool Equals(RegisterBattleServerResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2023284", Offset="0x2023284", VA="0x2023284", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10771DC", Offset="0x10771DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2023344", Offset="0x2023344", VA="0x2023344", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107721C", Offset="0x107721C")]
		public void MergeFrom(RegisterBattleServerResponse other)
		{
		}

		[Address(RVA="0x2023378", Offset="0x2023378", VA="0x2023378", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107722C", Offset="0x107722C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x20232B4", Offset="0x20232B4", VA="0x20232B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10771EC", Offset="0x10771EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x202331C", Offset="0x202331C", VA="0x202331C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10771FC", Offset="0x10771FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F158", Offset="0x104F158")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RegisterBattleServerResponse.<>c <>9;

			[Address(RVA="0x20234A4", Offset="0x20234A4", VA="0x20234A4")]
			static <>c()
			{
			}

			[Address(RVA="0x2023508", Offset="0x2023508", VA="0x2023508")]
			public <>c()
			{
			}

			[Address(RVA="0x2023510", Offset="0x2023510", VA="0x2023510")]
			internal RegisterBattleServerResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}