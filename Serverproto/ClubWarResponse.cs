using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarResponse : IMessage<ClubWarResponse>, IMessage, IEquatable<ClubWarResponse>, IDeepCloneable<ClubWarResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int WarFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubWar war_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E70", Offset="0x1095E70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B2A280", Offset="0x1B2A280", VA="0x1B2A280")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E60", Offset="0x1095E60")]
		public static MessageParser<ClubWarResponse> Parser
		{
			[Address(RVA="0x1B2A218", Offset="0x1B2A218", VA="0x1B2A218")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E80", Offset="0x1095E80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B2A370", Offset="0x1B2A370", VA="0x1B2A370", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E90", Offset="0x1095E90")]
		public ClubWar War
		{
			[Address(RVA="0x1B2A44C", Offset="0x1B2A44C", VA="0x1B2A44C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B2A454", Offset="0x1B2A454", VA="0x1B2A454")]
			set
			{
			}
		}

		[Address(RVA="0x1B2A908", Offset="0x1B2A908", VA="0x1B2A908")]
		static ClubWarResponse()
		{
		}

		[Address(RVA="0x1B2A3CC", Offset="0x1B2A3CC", VA="0x1B2A3CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D7AC", Offset="0x107D7AC")]
		public ClubWarResponse()
		{
		}

		[Address(RVA="0x1B2A3D4", Offset="0x1B2A3D4", VA="0x1B2A3D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D7BC", Offset="0x107D7BC")]
		public ClubWarResponse(ClubWarResponse other)
		{
		}

		[Address(RVA="0x1B2A6F4", Offset="0x1B2A6F4", VA="0x1B2A6F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D82C", Offset="0x107D82C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B2A45C", Offset="0x1B2A45C", VA="0x1B2A45C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D7CC", Offset="0x107D7CC")]
		public ClubWarResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B2A4BC", Offset="0x1B2A4BC", VA="0x1B2A4BC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D7DC", Offset="0x107D7DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B2A530", Offset="0x1B2A530", VA="0x1B2A530", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D7EC", Offset="0x107D7EC")]
		public bool Equals(ClubWarResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B2A594", Offset="0x1B2A594", VA="0x1B2A594", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D7FC", Offset="0x107D7FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B2A784", Offset="0x1B2A784", VA="0x1B2A784", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D83C", Offset="0x107D83C")]
		public void MergeFrom(ClubWarResponse other)
		{
		}

		[Address(RVA="0x1B2A830", Offset="0x1B2A830", VA="0x1B2A830", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D84C", Offset="0x107D84C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B2A5EC", Offset="0x1B2A5EC", VA="0x1B2A5EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D80C", Offset="0x107D80C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B2A654", Offset="0x1B2A654", VA="0x1B2A654", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D81C", Offset="0x107D81C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FAE8", Offset="0x104FAE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarResponse.<>c <>9;

			[Address(RVA="0x1B2A9E0", Offset="0x1B2A9E0", VA="0x1B2A9E0")]
			static <>c()
			{
			}

			[Address(RVA="0x1B2AA44", Offset="0x1B2AA44", VA="0x1B2AA44")]
			public <>c()
			{
			}

			[Address(RVA="0x1B2AA4C", Offset="0x1B2AA4C", VA="0x1B2AA4C")]
			internal ClubWarResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}