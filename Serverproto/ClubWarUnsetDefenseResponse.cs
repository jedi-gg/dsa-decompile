using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarUnsetDefenseResponse : IMessage<ClubWarUnsetDefenseResponse>, IMessage, IEquatable<ClubWarUnsetDefenseResponse>, IDeepCloneable<ClubWarUnsetDefenseResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarUnsetDefenseResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096220", Offset="0x1096220")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE899C", Offset="0x1EE899C", VA="0x1EE899C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096210", Offset="0x1096210")]
		public static MessageParser<ClubWarUnsetDefenseResponse> Parser
		{
			[Address(RVA="0x1EE8934", Offset="0x1EE8934", VA="0x1EE8934")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096230", Offset="0x1096230")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE8A8C", Offset="0x1EE8A8C", VA="0x1EE8A8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE8DA0", Offset="0x1EE8DA0", VA="0x1EE8DA0")]
		static ClubWarUnsetDefenseResponse()
		{
		}

		[Address(RVA="0x1EE8AE8", Offset="0x1EE8AE8", VA="0x1EE8AE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E14C", Offset="0x107E14C")]
		public ClubWarUnsetDefenseResponse()
		{
		}

		[Address(RVA="0x1EE8AF0", Offset="0x1EE8AF0", VA="0x1EE8AF0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E15C", Offset="0x107E15C")]
		public ClubWarUnsetDefenseResponse(ClubWarUnsetDefenseResponse other)
		{
		}

		[Address(RVA="0x1EE8D04", Offset="0x1EE8D04", VA="0x1EE8D04", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E1CC", Offset="0x107E1CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE8B34", Offset="0x1EE8B34", VA="0x1EE8B34", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E16C", Offset="0x107E16C")]
		public ClubWarUnsetDefenseResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE8B94", Offset="0x1EE8B94", VA="0x1EE8B94", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E17C", Offset="0x107E17C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE8C2C", Offset="0x1EE8C2C", VA="0x1EE8C2C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E18C", Offset="0x107E18C")]
		public bool Equals(ClubWarUnsetDefenseResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE8C58", Offset="0x1EE8C58", VA="0x1EE8C58", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E19C", Offset="0x107E19C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE8D18", Offset="0x1EE8D18", VA="0x1EE8D18", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E1DC", Offset="0x107E1DC")]
		public void MergeFrom(ClubWarUnsetDefenseResponse other)
		{
		}

		[Address(RVA="0x1EE8D4C", Offset="0x1EE8D4C", VA="0x1EE8D4C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E1EC", Offset="0x107E1EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE8C88", Offset="0x1EE8C88", VA="0x1EE8C88", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E1AC", Offset="0x107E1AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE8CF0", Offset="0x1EE8CF0", VA="0x1EE8CF0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E1BC", Offset="0x107E1BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FBC8", Offset="0x104FBC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarUnsetDefenseResponse.<>c <>9;

			[Address(RVA="0x1EE8E78", Offset="0x1EE8E78", VA="0x1EE8E78")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE8EDC", Offset="0x1EE8EDC", VA="0x1EE8EDC")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE8EE4", Offset="0x1EE8EE4", VA="0x1EE8EE4")]
			internal ClubWarUnsetDefenseResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}