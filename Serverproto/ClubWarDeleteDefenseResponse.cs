using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarDeleteDefenseResponse : IMessage<ClubWarDeleteDefenseResponse>, IMessage, IEquatable<ClubWarDeleteDefenseResponse>, IDeepCloneable<ClubWarDeleteDefenseResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarDeleteDefenseResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096100", Offset="0x1096100")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B22BA8", Offset="0x1B22BA8", VA="0x1B22BA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10960F0", Offset="0x10960F0")]
		public static MessageParser<ClubWarDeleteDefenseResponse> Parser
		{
			[Address(RVA="0x1B22B40", Offset="0x1B22B40", VA="0x1B22B40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096110", Offset="0x1096110")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B22C98", Offset="0x1B22C98", VA="0x1B22C98", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B22FAC", Offset="0x1B22FAC", VA="0x1B22FAC")]
		static ClubWarDeleteDefenseResponse()
		{
		}

		[Address(RVA="0x1B22CF4", Offset="0x1B22CF4", VA="0x1B22CF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE8C", Offset="0x107DE8C")]
		public ClubWarDeleteDefenseResponse()
		{
		}

		[Address(RVA="0x1B22CFC", Offset="0x1B22CFC", VA="0x1B22CFC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE9C", Offset="0x107DE9C")]
		public ClubWarDeleteDefenseResponse(ClubWarDeleteDefenseResponse other)
		{
		}

		[Address(RVA="0x1B22F10", Offset="0x1B22F10", VA="0x1B22F10", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF0C", Offset="0x107DF0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B22D40", Offset="0x1B22D40", VA="0x1B22D40", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DEAC", Offset="0x107DEAC")]
		public ClubWarDeleteDefenseResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B22DA0", Offset="0x1B22DA0", VA="0x1B22DA0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DEBC", Offset="0x107DEBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B22E38", Offset="0x1B22E38", VA="0x1B22E38", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DECC", Offset="0x107DECC")]
		public bool Equals(ClubWarDeleteDefenseResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B22E64", Offset="0x1B22E64", VA="0x1B22E64", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DEDC", Offset="0x107DEDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B22F24", Offset="0x1B22F24", VA="0x1B22F24", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF1C", Offset="0x107DF1C")]
		public void MergeFrom(ClubWarDeleteDefenseResponse other)
		{
		}

		[Address(RVA="0x1B22F58", Offset="0x1B22F58", VA="0x1B22F58", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF2C", Offset="0x107DF2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B22E94", Offset="0x1B22E94", VA="0x1B22E94", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DEEC", Offset="0x107DEEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B22EFC", Offset="0x1B22EFC", VA="0x1B22EFC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DEFC", Offset="0x107DEFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB88", Offset="0x104FB88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarDeleteDefenseResponse.<>c <>9;

			[Address(RVA="0x1B23084", Offset="0x1B23084", VA="0x1B23084")]
			static <>c()
			{
			}

			[Address(RVA="0x1B230E8", Offset="0x1B230E8", VA="0x1B230E8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B230F0", Offset="0x1B230F0", VA="0x1B230F0")]
			internal ClubWarDeleteDefenseResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}