using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PromoteClubMemberResponse : IMessage<PromoteClubMemberResponse>, IMessage, IEquatable<PromoteClubMemberResponse>, IDeepCloneable<PromoteClubMemberResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PromoteClubMemberResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095100", Offset="0x1095100")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x1B132B0", Offset="0x1B132B0", VA="0x1B132B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B132B8", Offset="0x1B132B8", VA="0x1B132B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10950E0", Offset="0x10950E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B130E0", Offset="0x1B130E0", VA="0x1B130E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10950D0", Offset="0x10950D0")]
		public static MessageParser<PromoteClubMemberResponse> Parser
		{
			[Address(RVA="0x1B13078", Offset="0x1B13078", VA="0x1B13078")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10950F0", Offset="0x10950F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B131D0", Offset="0x1B131D0", VA="0x1B131D0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B13778", Offset="0x1B13778", VA="0x1B13778")]
		static PromoteClubMemberResponse()
		{
		}

		[Address(RVA="0x1B1322C", Offset="0x1B1322C", VA="0x1B1322C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B8BC", Offset="0x107B8BC")]
		public PromoteClubMemberResponse()
		{
		}

		[Address(RVA="0x1B13234", Offset="0x1B13234", VA="0x1B13234")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B8CC", Offset="0x107B8CC")]
		public PromoteClubMemberResponse(PromoteClubMemberResponse other)
		{
		}

		[Address(RVA="0x1B13558", Offset="0x1B13558", VA="0x1B13558", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B93C", Offset="0x107B93C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B132C0", Offset="0x1B132C0", VA="0x1B132C0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B8DC", Offset="0x107B8DC")]
		public PromoteClubMemberResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B13320", Offset="0x1B13320", VA="0x1B13320", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B8EC", Offset="0x107B8EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B13394", Offset="0x1B13394", VA="0x1B13394", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B8FC", Offset="0x107B8FC")]
		public bool Equals(PromoteClubMemberResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B133F8", Offset="0x1B133F8", VA="0x1B133F8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B90C", Offset="0x107B90C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B135E8", Offset="0x1B135E8", VA="0x1B135E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B94C", Offset="0x107B94C")]
		public void MergeFrom(PromoteClubMemberResponse other)
		{
		}

		[Address(RVA="0x1B1369C", Offset="0x1B1369C", VA="0x1B1369C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B95C", Offset="0x107B95C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B13450", Offset="0x1B13450", VA="0x1B13450", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B91C", Offset="0x107B91C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B134B8", Offset="0x1B134B8", VA="0x1B134B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B92C", Offset="0x107B92C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F808", Offset="0x104F808")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PromoteClubMemberResponse.<>c <>9;

			[Address(RVA="0x2010864", Offset="0x2010864", VA="0x2010864")]
			static <>c()
			{
			}

			[Address(RVA="0x20108C8", Offset="0x20108C8", VA="0x20108C8")]
			public <>c()
			{
			}

			[Address(RVA="0x20108D0", Offset="0x20108D0", VA="0x20108D0")]
			internal PromoteClubMemberResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}