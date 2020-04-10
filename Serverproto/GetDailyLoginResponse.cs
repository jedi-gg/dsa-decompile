using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetDailyLoginResponse : IMessage<GetDailyLoginResponse>, IMessage, IEquatable<GetDailyLoginResponse>, IDeepCloneable<GetDailyLoginResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetDailyLoginResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DataFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private DailyLogin data_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ACB0", Offset="0x109ACB0")]
		public DailyLogin Data
		{
			[Address(RVA="0x1BA9400", Offset="0x1BA9400", VA="0x1BA9400")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BA9408", Offset="0x1BA9408", VA="0x1BA9408")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC90", Offset="0x109AC90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA9230", Offset="0x1BA9230", VA="0x1BA9230")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC80", Offset="0x109AC80")]
		public static MessageParser<GetDailyLoginResponse> Parser
		{
			[Address(RVA="0x1BA91C8", Offset="0x1BA91C8", VA="0x1BA91C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ACA0", Offset="0x109ACA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA9320", Offset="0x1BA9320", VA="0x1BA9320", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA98C8", Offset="0x1BA98C8", VA="0x1BA98C8")]
		static GetDailyLoginResponse()
		{
		}

		[Address(RVA="0x1BA937C", Offset="0x1BA937C", VA="0x1BA937C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108587C", Offset="0x108587C")]
		public GetDailyLoginResponse()
		{
		}

		[Address(RVA="0x1BA9384", Offset="0x1BA9384", VA="0x1BA9384")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108588C", Offset="0x108588C")]
		public GetDailyLoginResponse(GetDailyLoginResponse other)
		{
		}

		[Address(RVA="0x1BA96A8", Offset="0x1BA96A8", VA="0x1BA96A8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10858FC", Offset="0x10858FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA9410", Offset="0x1BA9410", VA="0x1BA9410", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108589C", Offset="0x108589C")]
		public GetDailyLoginResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA9470", Offset="0x1BA9470", VA="0x1BA9470", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10858AC", Offset="0x10858AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA94E4", Offset="0x1BA94E4", VA="0x1BA94E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10858BC", Offset="0x10858BC")]
		public bool Equals(GetDailyLoginResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA9548", Offset="0x1BA9548", VA="0x1BA9548", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10858CC", Offset="0x10858CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA9738", Offset="0x1BA9738", VA="0x1BA9738", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108590C", Offset="0x108590C")]
		public void MergeFrom(GetDailyLoginResponse other)
		{
		}

		[Address(RVA="0x1BA97EC", Offset="0x1BA97EC", VA="0x1BA97EC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108591C", Offset="0x108591C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA95A0", Offset="0x1BA95A0", VA="0x1BA95A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10858DC", Offset="0x10858DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA9608", Offset="0x1BA9608", VA="0x1BA9608", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10858EC", Offset="0x10858EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050698", Offset="0x1050698")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetDailyLoginResponse.<>c <>9;

			[Address(RVA="0x1BA99A0", Offset="0x1BA99A0", VA="0x1BA99A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA9A04", Offset="0x1BA9A04", VA="0x1BA9A04")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA9A0C", Offset="0x1BA9A0C", VA="0x1BA9A0C")]
			internal GetDailyLoginResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}