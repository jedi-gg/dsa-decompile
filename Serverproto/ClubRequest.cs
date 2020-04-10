using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubRequest : IMessage<ClubRequest>, IMessage, IEquatable<ClubRequest>, IDeepCloneable<ClubRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094CB0", Offset="0x1094CB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x200E864", Offset="0x200E864", VA="0x200E864")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094CD0", Offset="0x1094CD0")]
		public string Id
		{
			[Address(RVA="0x200EAC4", Offset="0x200EAC4", VA="0x200EAC4")]
			get
			{
				return null;
			}
			[Address(RVA="0x200EACC", Offset="0x200EACC", VA="0x200EACC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094CA0", Offset="0x1094CA0")]
		public static MessageParser<ClubRequest> Parser
		{
			[Address(RVA="0x200E794", Offset="0x200E794", VA="0x200E794")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094CC0", Offset="0x1094CC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x200E950", Offset="0x200E950", VA="0x200E950", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x200EF5C", Offset="0x200EF5C", VA="0x200EF5C")]
		static ClubRequest()
		{
		}

		[Address(RVA="0x200E9AC", Offset="0x200E9AC", VA="0x200E9AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE6C", Offset="0x107AE6C")]
		public ClubRequest()
		{
		}

		[Address(RVA="0x200EA04", Offset="0x200EA04", VA="0x200EA04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE7C", Offset="0x107AE7C")]
		public ClubRequest(ClubRequest other)
		{
		}

		[Address(RVA="0x200EDB8", Offset="0x200EDB8", VA="0x200EDB8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AEEC", Offset="0x107AEEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x200EA64", Offset="0x200EA64", VA="0x200EA64", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE8C", Offset="0x107AE8C")]
		public ClubRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x200EB3C", Offset="0x200EB3C", VA="0x200EB3C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE9C", Offset="0x107AE9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x200EBB0", Offset="0x200EBB0", VA="0x200EBB0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AEAC", Offset="0x107AEAC")]
		public bool Equals(ClubRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x200EC14", Offset="0x200EC14", VA="0x200EC14", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AEBC", Offset="0x107AEBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x200EE6C", Offset="0x200EE6C", VA="0x200EE6C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AEFC", Offset="0x107AEFC")]
		public void MergeFrom(ClubRequest other)
		{
		}

		[Address(RVA="0x200EED8", Offset="0x200EED8", VA="0x200EED8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF0C", Offset="0x107AF0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x200EC98", Offset="0x200EC98", VA="0x200EC98", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AECC", Offset="0x107AECC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x200ED00", Offset="0x200ED00", VA="0x200ED00", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AEDC", Offset="0x107AEDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F718", Offset="0x104F718")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubRequest.<>c <>9;

			[Address(RVA="0x200F034", Offset="0x200F034", VA="0x200F034")]
			static <>c()
			{
			}

			[Address(RVA="0x200F098", Offset="0x200F098", VA="0x200F098")]
			public <>c()
			{
			}

			[Address(RVA="0x200F0A0", Offset="0x200F0A0", VA="0x200F0A0")]
			internal ClubRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}