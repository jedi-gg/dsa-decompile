using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeKothRequest : IMessage<HomeKothRequest>, IMessage, IEquatable<HomeKothRequest>, IDeepCloneable<HomeKothRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeKothRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098010", Offset="0x1098010")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D05B5C", Offset="0x1D05B5C", VA="0x1D05B5C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098000", Offset="0x1098000")]
		public static MessageParser<HomeKothRequest> Parser
		{
			[Address(RVA="0x1D05AF4", Offset="0x1D05AF4", VA="0x1D05AF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098020", Offset="0x1098020")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D05C48", Offset="0x1D05C48", VA="0x1D05C48", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D05F5C", Offset="0x1D05F5C", VA="0x1D05F5C")]
		static HomeKothRequest()
		{
		}

		[Address(RVA="0x1D05CA4", Offset="0x1D05CA4", VA="0x1D05CA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F5C", Offset="0x1080F5C")]
		public HomeKothRequest()
		{
		}

		[Address(RVA="0x1D05CAC", Offset="0x1D05CAC", VA="0x1D05CAC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F6C", Offset="0x1080F6C")]
		public HomeKothRequest(HomeKothRequest other)
		{
		}

		[Address(RVA="0x1D05EC0", Offset="0x1D05EC0", VA="0x1D05EC0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080FDC", Offset="0x1080FDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D05CF0", Offset="0x1D05CF0", VA="0x1D05CF0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F7C", Offset="0x1080F7C")]
		public HomeKothRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D05D50", Offset="0x1D05D50", VA="0x1D05D50", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F8C", Offset="0x1080F8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D05DE8", Offset="0x1D05DE8", VA="0x1D05DE8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F9C", Offset="0x1080F9C")]
		public bool Equals(HomeKothRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D05E14", Offset="0x1D05E14", VA="0x1D05E14", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080FAC", Offset="0x1080FAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D05ED4", Offset="0x1D05ED4", VA="0x1D05ED4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080FEC", Offset="0x1080FEC")]
		public void MergeFrom(HomeKothRequest other)
		{
		}

		[Address(RVA="0x1D05F08", Offset="0x1D05F08", VA="0x1D05F08", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080FFC", Offset="0x1080FFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D05E44", Offset="0x1D05E44", VA="0x1D05E44", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080FBC", Offset="0x1080FBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D05EAC", Offset="0x1D05EAC", VA="0x1D05EAC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080FCC", Offset="0x1080FCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FFF8", Offset="0x104FFF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeKothRequest.<>c <>9;

			[Address(RVA="0x1D06034", Offset="0x1D06034", VA="0x1D06034")]
			static <>c()
			{
			}

			[Address(RVA="0x1D06098", Offset="0x1D06098", VA="0x1D06098")]
			public <>c()
			{
			}

			[Address(RVA="0x1D060A0", Offset="0x1D060A0", VA="0x1D060A0")]
			internal HomeKothRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}