using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonStatusRequest : IMessage<ClubDungeonStatusRequest>, IMessage, IEquatable<ClubDungeonStatusRequest>, IDeepCloneable<ClubDungeonStatusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonStatusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10958E0", Offset="0x10958E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF6070", Offset="0x1FF6070", VA="0x1FF6070")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10958D0", Offset="0x10958D0")]
		public static MessageParser<ClubDungeonStatusRequest> Parser
		{
			[Address(RVA="0x1FF6008", Offset="0x1FF6008", VA="0x1FF6008")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10958F0", Offset="0x10958F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF615C", Offset="0x1FF615C", VA="0x1FF615C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FF6470", Offset="0x1FF6470", VA="0x1FF6470")]
		static ClubDungeonStatusRequest()
		{
		}

		[Address(RVA="0x1FF61B8", Offset="0x1FF61B8", VA="0x1FF61B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB4C", Offset="0x107CB4C")]
		public ClubDungeonStatusRequest()
		{
		}

		[Address(RVA="0x1FF61C0", Offset="0x1FF61C0", VA="0x1FF61C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB5C", Offset="0x107CB5C")]
		public ClubDungeonStatusRequest(ClubDungeonStatusRequest other)
		{
		}

		[Address(RVA="0x1FF63D4", Offset="0x1FF63D4", VA="0x1FF63D4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CBCC", Offset="0x107CBCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF6204", Offset="0x1FF6204", VA="0x1FF6204", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB6C", Offset="0x107CB6C")]
		public ClubDungeonStatusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF6264", Offset="0x1FF6264", VA="0x1FF6264", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB7C", Offset="0x107CB7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF62FC", Offset="0x1FF62FC", VA="0x1FF62FC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB8C", Offset="0x107CB8C")]
		public bool Equals(ClubDungeonStatusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF6328", Offset="0x1FF6328", VA="0x1FF6328", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB9C", Offset="0x107CB9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF63E8", Offset="0x1FF63E8", VA="0x1FF63E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CBDC", Offset="0x107CBDC")]
		public void MergeFrom(ClubDungeonStatusRequest other)
		{
		}

		[Address(RVA="0x1FF641C", Offset="0x1FF641C", VA="0x1FF641C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CBEC", Offset="0x107CBEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF6358", Offset="0x1FF6358", VA="0x1FF6358", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CBAC", Offset="0x107CBAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF63C0", Offset="0x1FF63C0", VA="0x1FF63C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CBBC", Offset="0x107CBBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F9B8", Offset="0x104F9B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonStatusRequest.<>c <>9;

			[Address(RVA="0x1FF6548", Offset="0x1FF6548", VA="0x1FF6548")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF65AC", Offset="0x1FF65AC", VA="0x1FF65AC")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF65B4", Offset="0x1FF65B4", VA="0x1FF65B4")]
			internal ClubDungeonStatusRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}