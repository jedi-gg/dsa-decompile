using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomePlayerActivityRequest : IMessage<HomePlayerActivityRequest>, IMessage, IEquatable<HomePlayerActivityRequest>, IDeepCloneable<HomePlayerActivityRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomePlayerActivityRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E50", Offset="0x1097E50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D06B54", Offset="0x1D06B54", VA="0x1D06B54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E40", Offset="0x1097E40")]
		public static MessageParser<HomePlayerActivityRequest> Parser
		{
			[Address(RVA="0x1D06AEC", Offset="0x1D06AEC", VA="0x1D06AEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E60", Offset="0x1097E60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D06C40", Offset="0x1D06C40", VA="0x1D06C40", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D06F54", Offset="0x1D06F54", VA="0x1D06F54")]
		static HomePlayerActivityRequest()
		{
		}

		[Address(RVA="0x1D06C9C", Offset="0x1D06C9C", VA="0x1D06C9C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080BEC", Offset="0x1080BEC")]
		public HomePlayerActivityRequest()
		{
		}

		[Address(RVA="0x1D06CA4", Offset="0x1D06CA4", VA="0x1D06CA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080BFC", Offset="0x1080BFC")]
		public HomePlayerActivityRequest(HomePlayerActivityRequest other)
		{
		}

		[Address(RVA="0x1D06EB8", Offset="0x1D06EB8", VA="0x1D06EB8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C6C", Offset="0x1080C6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D06CE8", Offset="0x1D06CE8", VA="0x1D06CE8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C0C", Offset="0x1080C0C")]
		public HomePlayerActivityRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D06D48", Offset="0x1D06D48", VA="0x1D06D48", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C1C", Offset="0x1080C1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D06DE0", Offset="0x1D06DE0", VA="0x1D06DE0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C2C", Offset="0x1080C2C")]
		public bool Equals(HomePlayerActivityRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D06E0C", Offset="0x1D06E0C", VA="0x1D06E0C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C3C", Offset="0x1080C3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D06ECC", Offset="0x1D06ECC", VA="0x1D06ECC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C7C", Offset="0x1080C7C")]
		public void MergeFrom(HomePlayerActivityRequest other)
		{
		}

		[Address(RVA="0x1D06F00", Offset="0x1D06F00", VA="0x1D06F00", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C8C", Offset="0x1080C8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D06E3C", Offset="0x1D06E3C", VA="0x1D06E3C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C4C", Offset="0x1080C4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D06EA4", Offset="0x1D06EA4", VA="0x1D06EA4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080C5C", Offset="0x1080C5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FFA8", Offset="0x104FFA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomePlayerActivityRequest.<>c <>9;

			[Address(RVA="0x1D0702C", Offset="0x1D0702C", VA="0x1D0702C")]
			static <>c()
			{
			}

			[Address(RVA="0x1D07090", Offset="0x1D07090", VA="0x1D07090")]
			public <>c()
			{
			}

			[Address(RVA="0x1D07098", Offset="0x1D07098", VA="0x1D07098")]
			internal HomePlayerActivityRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}