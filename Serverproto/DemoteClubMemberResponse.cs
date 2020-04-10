using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DemoteClubMemberResponse : IMessage<DemoteClubMemberResponse>, IMessage, IEquatable<DemoteClubMemberResponse>, IDeepCloneable<DemoteClubMemberResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DemoteClubMemberResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095180", Offset="0x1095180")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x1FB96A0", Offset="0x1FB96A0", VA="0x1FB96A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FB96A8", Offset="0x1FB96A8", VA="0x1FB96A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095160", Offset="0x1095160")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FB94D0", Offset="0x1FB94D0", VA="0x1FB94D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095150", Offset="0x1095150")]
		public static MessageParser<DemoteClubMemberResponse> Parser
		{
			[Address(RVA="0x1FB9468", Offset="0x1FB9468", VA="0x1FB9468")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095170", Offset="0x1095170")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FB95C0", Offset="0x1FB95C0", VA="0x1FB95C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FB9B68", Offset="0x1FB9B68", VA="0x1FB9B68")]
		static DemoteClubMemberResponse()
		{
		}

		[Address(RVA="0x1FB961C", Offset="0x1FB961C", VA="0x1FB961C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA1C", Offset="0x107BA1C")]
		public DemoteClubMemberResponse()
		{
		}

		[Address(RVA="0x1FB9624", Offset="0x1FB9624", VA="0x1FB9624")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA2C", Offset="0x107BA2C")]
		public DemoteClubMemberResponse(DemoteClubMemberResponse other)
		{
		}

		[Address(RVA="0x1FB9948", Offset="0x1FB9948", VA="0x1FB9948", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA9C", Offset="0x107BA9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FB96B0", Offset="0x1FB96B0", VA="0x1FB96B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA3C", Offset="0x107BA3C")]
		public DemoteClubMemberResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FB9710", Offset="0x1FB9710", VA="0x1FB9710", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA4C", Offset="0x107BA4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FB9784", Offset="0x1FB9784", VA="0x1FB9784", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA5C", Offset="0x107BA5C")]
		public bool Equals(DemoteClubMemberResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FB97E8", Offset="0x1FB97E8", VA="0x1FB97E8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA6C", Offset="0x107BA6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FB99D8", Offset="0x1FB99D8", VA="0x1FB99D8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BAAC", Offset="0x107BAAC")]
		public void MergeFrom(DemoteClubMemberResponse other)
		{
		}

		[Address(RVA="0x1FB9A8C", Offset="0x1FB9A8C", VA="0x1FB9A8C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BABC", Offset="0x107BABC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FB9840", Offset="0x1FB9840", VA="0x1FB9840", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA7C", Offset="0x107BA7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FB98A8", Offset="0x1FB98A8", VA="0x1FB98A8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BA8C", Offset="0x107BA8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F828", Offset="0x104F828")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DemoteClubMemberResponse.<>c <>9;

			[Address(RVA="0x1FB9C40", Offset="0x1FB9C40", VA="0x1FB9C40")]
			static <>c()
			{
			}

			[Address(RVA="0x1FB9CA4", Offset="0x1FB9CA4", VA="0x1FB9CA4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FB9CAC", Offset="0x1FB9CAC", VA="0x1FB9CAC")]
			internal DemoteClubMemberResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}