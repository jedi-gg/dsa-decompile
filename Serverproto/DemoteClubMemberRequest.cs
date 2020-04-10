using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DemoteClubMemberRequest : IMessage<DemoteClubMemberRequest>, IMessage, IEquatable<DemoteClubMemberRequest>, IDeepCloneable<DemoteClubMemberRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DemoteClubMemberRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095120", Offset="0x1095120")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF9E2C", Offset="0x1EF9E2C", VA="0x1EF9E2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095110", Offset="0x1095110")]
		public static MessageParser<DemoteClubMemberRequest> Parser
		{
			[Address(RVA="0x1EF9DC4", Offset="0x1EF9DC4", VA="0x1EF9DC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095130", Offset="0x1095130")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF9F1C", Offset="0x1EF9F1C", VA="0x1EF9F1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095140", Offset="0x1095140")]
		public string PlayerId
		{
			[Address(RVA="0x1EFA090", Offset="0x1EFA090", VA="0x1EFA090")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EFA098", Offset="0x1EFA098", VA="0x1EFA098")]
			set
			{
			}
		}

		[Address(RVA="0x1EFA528", Offset="0x1EFA528", VA="0x1EFA528")]
		static DemoteClubMemberRequest()
		{
		}

		[Address(RVA="0x1EF9F78", Offset="0x1EF9F78", VA="0x1EF9F78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B96C", Offset="0x107B96C")]
		public DemoteClubMemberRequest()
		{
		}

		[Address(RVA="0x1EF9FD0", Offset="0x1EF9FD0", VA="0x1EF9FD0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B97C", Offset="0x107B97C")]
		public DemoteClubMemberRequest(DemoteClubMemberRequest other)
		{
		}

		[Address(RVA="0x1EFA384", Offset="0x1EFA384", VA="0x1EFA384", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B9EC", Offset="0x107B9EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EFA030", Offset="0x1EFA030", VA="0x1EFA030", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B98C", Offset="0x107B98C")]
		public DemoteClubMemberRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EFA108", Offset="0x1EFA108", VA="0x1EFA108", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B99C", Offset="0x107B99C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EFA17C", Offset="0x1EFA17C", VA="0x1EFA17C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B9AC", Offset="0x107B9AC")]
		public bool Equals(DemoteClubMemberRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EFA1E0", Offset="0x1EFA1E0", VA="0x1EFA1E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B9BC", Offset="0x107B9BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EFA438", Offset="0x1EFA438", VA="0x1EFA438", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B9FC", Offset="0x107B9FC")]
		public void MergeFrom(DemoteClubMemberRequest other)
		{
		}

		[Address(RVA="0x1EFA4A4", Offset="0x1EFA4A4", VA="0x1EFA4A4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA0C", Offset="0x107BA0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EFA264", Offset="0x1EFA264", VA="0x1EFA264", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B9CC", Offset="0x107B9CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EFA2CC", Offset="0x1EFA2CC", VA="0x1EFA2CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B9DC", Offset="0x107B9DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F818", Offset="0x104F818")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DemoteClubMemberRequest.<>c <>9;

			[Address(RVA="0x1FB93A0", Offset="0x1FB93A0", VA="0x1FB93A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FB9404", Offset="0x1FB9404", VA="0x1FB9404")]
			public <>c()
			{
			}

			[Address(RVA="0x1FB940C", Offset="0x1FB940C", VA="0x1FB940C")]
			internal DemoteClubMemberRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}