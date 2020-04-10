using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshClubDungeonRequest : IMessage<RefreshClubDungeonRequest>, IMessage, IEquatable<RefreshClubDungeonRequest>, IDeepCloneable<RefreshClubDungeonRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshClubDungeonRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095950", Offset="0x1095950")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201D510", Offset="0x201D510", VA="0x201D510")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095940", Offset="0x1095940")]
		public static MessageParser<RefreshClubDungeonRequest> Parser
		{
			[Address(RVA="0x201D4A8", Offset="0x201D4A8", VA="0x201D4A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095960", Offset="0x1095960")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201D600", Offset="0x201D600", VA="0x201D600", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x201D914", Offset="0x201D914", VA="0x201D914")]
		static RefreshClubDungeonRequest()
		{
		}

		[Address(RVA="0x201D65C", Offset="0x201D65C", VA="0x201D65C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CCAC", Offset="0x107CCAC")]
		public RefreshClubDungeonRequest()
		{
		}

		[Address(RVA="0x201D664", Offset="0x201D664", VA="0x201D664")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CCBC", Offset="0x107CCBC")]
		public RefreshClubDungeonRequest(RefreshClubDungeonRequest other)
		{
		}

		[Address(RVA="0x201D878", Offset="0x201D878", VA="0x201D878", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD2C", Offset="0x107CD2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201D6A8", Offset="0x201D6A8", VA="0x201D6A8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CCCC", Offset="0x107CCCC")]
		public RefreshClubDungeonRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x201D708", Offset="0x201D708", VA="0x201D708", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CCDC", Offset="0x107CCDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201D7A0", Offset="0x201D7A0", VA="0x201D7A0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CCEC", Offset="0x107CCEC")]
		public bool Equals(RefreshClubDungeonRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x201D7CC", Offset="0x201D7CC", VA="0x201D7CC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CCFC", Offset="0x107CCFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201D88C", Offset="0x201D88C", VA="0x201D88C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD3C", Offset="0x107CD3C")]
		public void MergeFrom(RefreshClubDungeonRequest other)
		{
		}

		[Address(RVA="0x201D8C0", Offset="0x201D8C0", VA="0x201D8C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD4C", Offset="0x107CD4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201D7FC", Offset="0x201D7FC", VA="0x201D7FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD0C", Offset="0x107CD0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201D864", Offset="0x201D864", VA="0x201D864", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD1C", Offset="0x107CD1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F9D8", Offset="0x104F9D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshClubDungeonRequest.<>c <>9;

			[Address(RVA="0x201D9EC", Offset="0x201D9EC", VA="0x201D9EC")]
			static <>c()
			{
			}

			[Address(RVA="0x201DA50", Offset="0x201DA50", VA="0x201DA50")]
			public <>c()
			{
			}

			[Address(RVA="0x201DA58", Offset="0x201DA58", VA="0x201DA58")]
			internal RefreshClubDungeonRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}