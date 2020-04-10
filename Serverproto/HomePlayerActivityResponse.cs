using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomePlayerActivityResponse : IMessage<HomePlayerActivityResponse>, IMessage, IEquatable<HomePlayerActivityResponse>, IDeepCloneable<HomePlayerActivityResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomePlayerActivityResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StarCountFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private uint starCount_;

		[FieldOffset(Offset="0x0")]
		public const int StarTotalFieldNumber = 2;

		[FieldOffset(Offset="0x1C")]
		private uint starTotal_;

		[FieldOffset(Offset="0x0")]
		public const int IsClaimedFieldNumber = 3;

		[FieldOffset(Offset="0x20")]
		private bool isClaimed_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E80", Offset="0x1097E80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D0715C", Offset="0x1D0715C", VA="0x1D0715C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097EC0", Offset="0x1097EC0")]
		public bool IsClaimed
		{
			[Address(RVA="0x1D073C8", Offset="0x1D073C8", VA="0x1D073C8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1D073D0", Offset="0x1D073D0", VA="0x1D073D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E70", Offset="0x1097E70")]
		public static MessageParser<HomePlayerActivityResponse> Parser
		{
			[Address(RVA="0x1D070F4", Offset="0x1D070F4", VA="0x1D070F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E90", Offset="0x1097E90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D07248", Offset="0x1D07248", VA="0x1D07248", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097EA0", Offset="0x1097EA0")]
		public uint StarCount
		{
			[Address(RVA="0x1D073A8", Offset="0x1D073A8", VA="0x1D073A8")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D073B0", Offset="0x1D073B0", VA="0x1D073B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097EB0", Offset="0x1097EB0")]
		public uint StarTotal
		{
			[Address(RVA="0x1D073B8", Offset="0x1D073B8", VA="0x1D073B8")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D073C0", Offset="0x1D073C0", VA="0x1D073C0")]
			set
			{
			}
		}

		[Address(RVA="0x1D07940", Offset="0x1D07940", VA="0x1D07940")]
		static HomePlayerActivityResponse()
		{
		}

		[Address(RVA="0x1D072A4", Offset="0x1D072A4", VA="0x1D072A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C9C", Offset="0x1080C9C")]
		public HomePlayerActivityResponse()
		{
		}

		[Address(RVA="0x1D072AC", Offset="0x1D072AC", VA="0x1D072AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080CAC", Offset="0x1080CAC")]
		public HomePlayerActivityResponse(HomePlayerActivityResponse other)
		{
		}

		[Address(RVA="0x1D07720", Offset="0x1D07720", VA="0x1D07720", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D1C", Offset="0x1080D1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D07348", Offset="0x1D07348", VA="0x1D07348", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080CBC", Offset="0x1080CBC")]
		public HomePlayerActivityResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D073DC", Offset="0x1D073DC", VA="0x1D073DC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080CCC", Offset="0x1080CCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D07450", Offset="0x1D07450", VA="0x1D07450", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080CDC", Offset="0x1080CDC")]
		public bool Equals(HomePlayerActivityResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D074BC", Offset="0x1D074BC", VA="0x1D074BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080CEC", Offset="0x1080CEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D0780C", Offset="0x1D0780C", VA="0x1D0780C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D2C", Offset="0x1080D2C")]
		public void MergeFrom(HomePlayerActivityResponse other)
		{
		}

		[Address(RVA="0x1D07864", Offset="0x1D07864", VA="0x1D07864", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D3C", Offset="0x1080D3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D07564", Offset="0x1D07564", VA="0x1D07564", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080CFC", Offset="0x1080CFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D075CC", Offset="0x1D075CC", VA="0x1D075CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D0C", Offset="0x1080D0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FFB8", Offset="0x104FFB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomePlayerActivityResponse.<>c <>9;

			[Address(RVA="0x1D07A18", Offset="0x1D07A18", VA="0x1D07A18")]
			static <>c()
			{
			}

			[Address(RVA="0x1D07A7C", Offset="0x1D07A7C", VA="0x1D07A7C")]
			public <>c()
			{
			}

			[Address(RVA="0x1D07A84", Offset="0x1D07A84", VA="0x1D07A84")]
			internal HomePlayerActivityResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}