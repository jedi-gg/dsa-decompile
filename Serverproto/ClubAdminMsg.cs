using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubAdminMsg : IMessage<ClubAdminMsg>, IMessage, IEquatable<ClubAdminMsg>, IDeepCloneable<ClubAdminMsg>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubAdminMsg> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MsgLocKeyFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string msgLocKey_;

		[FieldOffset(Offset="0x0")]
		public const int ParamsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<string> _repeated_params_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<string> params_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094650", Offset="0x1094650")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4AFE4", Offset="0x1A4AFE4", VA="0x1A4AFE4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094670", Offset="0x1094670")]
		public string MsgLocKey
		{
			[Address(RVA="0x1A4B2C4", Offset="0x1A4B2C4", VA="0x1A4B2C4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4B2CC", Offset="0x1A4B2CC", VA="0x1A4B2CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094680", Offset="0x1094680")]
		public RepeatedField<string> Params
		{
			[Address(RVA="0x1A4B33C", Offset="0x1A4B33C", VA="0x1A4B33C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094640", Offset="0x1094640")]
		public static MessageParser<ClubAdminMsg> Parser
		{
			[Address(RVA="0x1A3C9C8", Offset="0x1A3C9C8", VA="0x1A3C9C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094660", Offset="0x1094660")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4B0D0", Offset="0x1A4B0D0", VA="0x1A4B0D0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4B9B4", Offset="0x1A4B9B4", VA="0x1A4B9B4")]
		static ClubAdminMsg()
		{
		}

		[Address(RVA="0x1A4B12C", Offset="0x1A4B12C", VA="0x1A4B12C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A15C", Offset="0x107A15C")]
		public ClubAdminMsg()
		{
		}

		[Address(RVA="0x1A4B1AC", Offset="0x1A4B1AC", VA="0x1A4B1AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A16C", Offset="0x107A16C")]
		public ClubAdminMsg(ClubAdminMsg other)
		{
		}

		[Address(RVA="0x1A4B6CC", Offset="0x1A4B6CC", VA="0x1A4B6CC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A1DC", Offset="0x107A1DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4B264", Offset="0x1A4B264", VA="0x1A4B264", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A17C", Offset="0x107A17C")]
		public ClubAdminMsg Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4B344", Offset="0x1A4B344", VA="0x1A4B344", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A18C", Offset="0x107A18C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4B3B8", Offset="0x1A4B3B8", VA="0x1A4B3B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A19C", Offset="0x107A19C")]
		public bool Equals(ClubAdminMsg other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4B47C", Offset="0x1A4B47C", VA="0x1A4B47C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A1AC", Offset="0x107A1AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4B7E4", Offset="0x1A4B7E4", VA="0x1A4B7E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A1EC", Offset="0x107A1EC")]
		public void MergeFrom(ClubAdminMsg other)
		{
		}

		[Address(RVA="0x1A4B8A0", Offset="0x1A4B8A0", VA="0x1A4B8A0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A1FC", Offset="0x107A1FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4B530", Offset="0x1A4B530", VA="0x1A4B530", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A1BC", Offset="0x107A1BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4B598", Offset="0x1A4B598", VA="0x1A4B598", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A1CC", Offset="0x107A1CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F5E8", Offset="0x104F5E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubAdminMsg.<>c <>9;

			[Address(RVA="0x1A4BAA4", Offset="0x1A4BAA4", VA="0x1A4BAA4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4BB08", Offset="0x1A4BB08", VA="0x1A4BB08")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4BB10", Offset="0x1A4BB10", VA="0x1A4BB10")]
			internal ClubAdminMsg <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}