using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CancelClubInviteResponse : IMessage<CancelClubInviteResponse>, IMessage, IEquatable<CancelClubInviteResponse>, IDeepCloneable<CancelClubInviteResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CancelClubInviteResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F60", Offset="0x1094F60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F97934", Offset="0x1F97934", VA="0x1F97934")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F50", Offset="0x1094F50")]
		public static MessageParser<CancelClubInviteResponse> Parser
		{
			[Address(RVA="0x1F978CC", Offset="0x1F978CC", VA="0x1F978CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F70", Offset="0x1094F70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F97A24", Offset="0x1F97A24", VA="0x1F97A24", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F97D38", Offset="0x1F97D38", VA="0x1F97D38")]
		static CancelClubInviteResponse()
		{
		}

		[Address(RVA="0x1F97A80", Offset="0x1F97A80", VA="0x1F97A80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B49C", Offset="0x107B49C")]
		public CancelClubInviteResponse()
		{
		}

		[Address(RVA="0x1F97A88", Offset="0x1F97A88", VA="0x1F97A88")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B4AC", Offset="0x107B4AC")]
		public CancelClubInviteResponse(CancelClubInviteResponse other)
		{
		}

		[Address(RVA="0x1F97C9C", Offset="0x1F97C9C", VA="0x1F97C9C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B51C", Offset="0x107B51C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F97ACC", Offset="0x1F97ACC", VA="0x1F97ACC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B4BC", Offset="0x107B4BC")]
		public CancelClubInviteResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F97B2C", Offset="0x1F97B2C", VA="0x1F97B2C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B4CC", Offset="0x107B4CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F97BC4", Offset="0x1F97BC4", VA="0x1F97BC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B4DC", Offset="0x107B4DC")]
		public bool Equals(CancelClubInviteResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F97BF0", Offset="0x1F97BF0", VA="0x1F97BF0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B4EC", Offset="0x107B4EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F97CB0", Offset="0x1F97CB0", VA="0x1F97CB0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B52C", Offset="0x107B52C")]
		public void MergeFrom(CancelClubInviteResponse other)
		{
		}

		[Address(RVA="0x1F97CE4", Offset="0x1F97CE4", VA="0x1F97CE4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B53C", Offset="0x107B53C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F97C20", Offset="0x1F97C20", VA="0x1F97C20", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B4FC", Offset="0x107B4FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F97C88", Offset="0x1F97C88", VA="0x1F97C88", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B50C", Offset="0x107B50C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F7A8", Offset="0x104F7A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CancelClubInviteResponse.<>c <>9;

			[Address(RVA="0x1F97E10", Offset="0x1F97E10", VA="0x1F97E10")]
			static <>c()
			{
			}

			[Address(RVA="0x1F97E74", Offset="0x1F97E74", VA="0x1F97E74")]
			public <>c()
			{
			}

			[Address(RVA="0x1F97E7C", Offset="0x1F97E7C", VA="0x1F97E7C")]
			internal CancelClubInviteResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}