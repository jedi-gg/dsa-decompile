using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubActivitiesRequest : IMessage<ClubActivitiesRequest>, IMessage, IEquatable<ClubActivitiesRequest>, IDeepCloneable<ClubActivitiesRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubActivitiesRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095AB0", Offset="0x1095AB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4735C", Offset="0x1A4735C", VA="0x1A4735C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095AA0", Offset="0x1095AA0")]
		public static MessageParser<ClubActivitiesRequest> Parser
		{
			[Address(RVA="0x1A472F4", Offset="0x1A472F4", VA="0x1A472F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095AC0", Offset="0x1095AC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4744C", Offset="0x1A4744C", VA="0x1A4744C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A47760", Offset="0x1A47760", VA="0x1A47760")]
		static ClubActivitiesRequest()
		{
		}

		[Address(RVA="0x1A474A8", Offset="0x1A474A8", VA="0x1A474A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D0CC", Offset="0x107D0CC")]
		public ClubActivitiesRequest()
		{
		}

		[Address(RVA="0x1A474B0", Offset="0x1A474B0", VA="0x1A474B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D0DC", Offset="0x107D0DC")]
		public ClubActivitiesRequest(ClubActivitiesRequest other)
		{
		}

		[Address(RVA="0x1A476C4", Offset="0x1A476C4", VA="0x1A476C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D14C", Offset="0x107D14C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A474F4", Offset="0x1A474F4", VA="0x1A474F4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D0EC", Offset="0x107D0EC")]
		public ClubActivitiesRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A47554", Offset="0x1A47554", VA="0x1A47554", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D0FC", Offset="0x107D0FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A475EC", Offset="0x1A475EC", VA="0x1A475EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D10C", Offset="0x107D10C")]
		public bool Equals(ClubActivitiesRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A47618", Offset="0x1A47618", VA="0x1A47618", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D11C", Offset="0x107D11C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A476D8", Offset="0x1A476D8", VA="0x1A476D8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D15C", Offset="0x107D15C")]
		public void MergeFrom(ClubActivitiesRequest other)
		{
		}

		[Address(RVA="0x1A4770C", Offset="0x1A4770C", VA="0x1A4770C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D16C", Offset="0x107D16C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A47648", Offset="0x1A47648", VA="0x1A47648", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D12C", Offset="0x107D12C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A476B0", Offset="0x1A476B0", VA="0x1A476B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D13C", Offset="0x107D13C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA38", Offset="0x104FA38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubActivitiesRequest.<>c <>9;

			[Address(RVA="0x1A47838", Offset="0x1A47838", VA="0x1A47838")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4789C", Offset="0x1A4789C", VA="0x1A4789C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A478A4", Offset="0x1A478A4", VA="0x1A478A4")]
			internal ClubActivitiesRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}