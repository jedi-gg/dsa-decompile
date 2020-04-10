using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubInvitesRequest : IMessage<HomeClubInvitesRequest>, IMessage, IEquatable<HomeClubInvitesRequest>, IDeepCloneable<HomeClubInvitesRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubInvitesRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097CA8", Offset="0x1097CA8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D00A68", Offset="0x1D00A68", VA="0x1D00A68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C98", Offset="0x1097C98")]
		public static MessageParser<HomeClubInvitesRequest> Parser
		{
			[Address(RVA="0x1D00A00", Offset="0x1D00A00", VA="0x1D00A00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097CB8", Offset="0x1097CB8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D00B54", Offset="0x1D00B54", VA="0x1D00B54", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D00E68", Offset="0x1D00E68", VA="0x1D00E68")]
		static HomeClubInvitesRequest()
		{
		}

		[Address(RVA="0x1D00BB0", Offset="0x1D00BB0", VA="0x1D00BB0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10807CC", Offset="0x10807CC")]
		public HomeClubInvitesRequest()
		{
		}

		[Address(RVA="0x1D00BB8", Offset="0x1D00BB8", VA="0x1D00BB8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10807DC", Offset="0x10807DC")]
		public HomeClubInvitesRequest(HomeClubInvitesRequest other)
		{
		}

		[Address(RVA="0x1D00DCC", Offset="0x1D00DCC", VA="0x1D00DCC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108084C", Offset="0x108084C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D00BFC", Offset="0x1D00BFC", VA="0x1D00BFC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10807EC", Offset="0x10807EC")]
		public HomeClubInvitesRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D00C5C", Offset="0x1D00C5C", VA="0x1D00C5C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10807FC", Offset="0x10807FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D00CF4", Offset="0x1D00CF4", VA="0x1D00CF4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108080C", Offset="0x108080C")]
		public bool Equals(HomeClubInvitesRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D00D20", Offset="0x1D00D20", VA="0x1D00D20", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108081C", Offset="0x108081C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D00DE0", Offset="0x1D00DE0", VA="0x1D00DE0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108085C", Offset="0x108085C")]
		public void MergeFrom(HomeClubInvitesRequest other)
		{
		}

		[Address(RVA="0x1D00E14", Offset="0x1D00E14", VA="0x1D00E14", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108086C", Offset="0x108086C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D00D50", Offset="0x1D00D50", VA="0x1D00D50", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108082C", Offset="0x108082C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D00DB8", Offset="0x1D00DB8", VA="0x1D00DB8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108083C", Offset="0x108083C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF48", Offset="0x104FF48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubInvitesRequest.<>c <>9;

			[Address(RVA="0x1D00F40", Offset="0x1D00F40", VA="0x1D00F40")]
			static <>c()
			{
			}

			[Address(RVA="0x1D00FA4", Offset="0x1D00FA4", VA="0x1D00FA4")]
			public <>c()
			{
			}

			[Address(RVA="0x1D00FAC", Offset="0x1D00FAC", VA="0x1D00FAC")]
			internal HomeClubInvitesRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}