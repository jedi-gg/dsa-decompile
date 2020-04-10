using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarSetNodeTargetRequest : IMessage<ClubWarSetNodeTargetRequest>, IMessage, IEquatable<ClubWarSetNodeTargetRequest>, IDeepCloneable<ClubWarSetNodeTargetRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarSetNodeTargetRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GdNodeIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string gdNodeId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096480", Offset="0x1096480")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE4F68", Offset="0x1EE4F68", VA="0x1EE4F68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10964A0", Offset="0x10964A0")]
		public string GdNodeId
		{
			[Address(RVA="0x1EE51CC", Offset="0x1EE51CC", VA="0x1EE51CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE51D4", Offset="0x1EE51D4", VA="0x1EE51D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096470", Offset="0x1096470")]
		public static MessageParser<ClubWarSetNodeTargetRequest> Parser
		{
			[Address(RVA="0x1EE4F00", Offset="0x1EE4F00", VA="0x1EE4F00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096490", Offset="0x1096490")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE5058", Offset="0x1EE5058", VA="0x1EE5058", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE5664", Offset="0x1EE5664", VA="0x1EE5664")]
		static ClubWarSetNodeTargetRequest()
		{
		}

		[Address(RVA="0x1EE50B4", Offset="0x1EE50B4", VA="0x1EE50B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E6CC", Offset="0x107E6CC")]
		public ClubWarSetNodeTargetRequest()
		{
		}

		[Address(RVA="0x1EE510C", Offset="0x1EE510C", VA="0x1EE510C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E6DC", Offset="0x107E6DC")]
		public ClubWarSetNodeTargetRequest(ClubWarSetNodeTargetRequest other)
		{
		}

		[Address(RVA="0x1EE54C0", Offset="0x1EE54C0", VA="0x1EE54C0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E74C", Offset="0x107E74C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE516C", Offset="0x1EE516C", VA="0x1EE516C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E6EC", Offset="0x107E6EC")]
		public ClubWarSetNodeTargetRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE5244", Offset="0x1EE5244", VA="0x1EE5244", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E6FC", Offset="0x107E6FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE52B8", Offset="0x1EE52B8", VA="0x1EE52B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E70C", Offset="0x107E70C")]
		public bool Equals(ClubWarSetNodeTargetRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE531C", Offset="0x1EE531C", VA="0x1EE531C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E71C", Offset="0x107E71C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE5574", Offset="0x1EE5574", VA="0x1EE5574", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E75C", Offset="0x107E75C")]
		public void MergeFrom(ClubWarSetNodeTargetRequest other)
		{
		}

		[Address(RVA="0x1EE55E0", Offset="0x1EE55E0", VA="0x1EE55E0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E76C", Offset="0x107E76C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE53A0", Offset="0x1EE53A0", VA="0x1EE53A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E72C", Offset="0x107E72C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE5408", Offset="0x1EE5408", VA="0x1EE5408", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E73C", Offset="0x107E73C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC48", Offset="0x104FC48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarSetNodeTargetRequest.<>c <>9;

			[Address(RVA="0x1EE573C", Offset="0x1EE573C", VA="0x1EE573C")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE57A0", Offset="0x1EE57A0", VA="0x1EE57A0")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE57A8", Offset="0x1EE57A8", VA="0x1EE57A8")]
			internal ClubWarSetNodeTargetRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}