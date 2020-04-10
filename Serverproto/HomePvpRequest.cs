using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomePvpRequest : IMessage<HomePvpRequest>, IMessage, IEquatable<HomePvpRequest>, IDeepCloneable<HomePvpRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomePvpRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098160", Offset="0x1098160")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D07B48", Offset="0x1D07B48", VA="0x1D07B48")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098150", Offset="0x1098150")]
		public static MessageParser<HomePvpRequest> Parser
		{
			[Address(RVA="0x1D07AE0", Offset="0x1D07AE0", VA="0x1D07AE0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098170", Offset="0x1098170")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D07C34", Offset="0x1D07C34", VA="0x1D07C34", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D07F48", Offset="0x1D07F48", VA="0x1D07F48")]
		static HomePvpRequest()
		{
		}

		[Address(RVA="0x1D07C90", Offset="0x1D07C90", VA="0x1D07C90")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108121C", Offset="0x108121C")]
		public HomePvpRequest()
		{
		}

		[Address(RVA="0x1D07C98", Offset="0x1D07C98", VA="0x1D07C98")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108122C", Offset="0x108122C")]
		public HomePvpRequest(HomePvpRequest other)
		{
		}

		[Address(RVA="0x1D07EAC", Offset="0x1D07EAC", VA="0x1D07EAC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108129C", Offset="0x108129C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D07CDC", Offset="0x1D07CDC", VA="0x1D07CDC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108123C", Offset="0x108123C")]
		public HomePvpRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D07D3C", Offset="0x1D07D3C", VA="0x1D07D3C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108124C", Offset="0x108124C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D07DD4", Offset="0x1D07DD4", VA="0x1D07DD4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108125C", Offset="0x108125C")]
		public bool Equals(HomePvpRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D07E00", Offset="0x1D07E00", VA="0x1D07E00", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108126C", Offset="0x108126C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D07EC0", Offset="0x1D07EC0", VA="0x1D07EC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10812AC", Offset="0x10812AC")]
		public void MergeFrom(HomePvpRequest other)
		{
		}

		[Address(RVA="0x1D07EF4", Offset="0x1D07EF4", VA="0x1D07EF4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10812BC", Offset="0x10812BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D07E30", Offset="0x1D07E30", VA="0x1D07E30", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108127C", Offset="0x108127C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D07E98", Offset="0x1D07E98", VA="0x1D07E98", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108128C", Offset="0x108128C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050038", Offset="0x1050038")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomePvpRequest.<>c <>9;

			[Address(RVA="0x1D08020", Offset="0x1D08020", VA="0x1D08020")]
			static <>c()
			{
			}

			[Address(RVA="0x1D08084", Offset="0x1D08084", VA="0x1D08084")]
			public <>c()
			{
			}

			[Address(RVA="0x1D0808C", Offset="0x1D0808C", VA="0x1D0808C")]
			internal HomePvpRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}