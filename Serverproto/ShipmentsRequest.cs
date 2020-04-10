using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ShipmentsRequest : IMessage<ShipmentsRequest>, IMessage, IEquatable<ShipmentsRequest>, IDeepCloneable<ShipmentsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ShipmentsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C6D0", Offset="0x109C6D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD5198", Offset="0x1BD5198", VA="0x1BD5198")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C6C0", Offset="0x109C6C0")]
		public static MessageParser<ShipmentsRequest> Parser
		{
			[Address(RVA="0x1BD5130", Offset="0x1BD5130", VA="0x1BD5130")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C6E0", Offset="0x109C6E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD5288", Offset="0x1BD5288", VA="0x1BD5288", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BD559C", Offset="0x1BD559C", VA="0x1BD559C")]
		static ShipmentsRequest()
		{
		}

		[Address(RVA="0x1BD52E4", Offset="0x1BD52E4", VA="0x1BD52E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108873C", Offset="0x108873C")]
		public ShipmentsRequest()
		{
		}

		[Address(RVA="0x1BD52EC", Offset="0x1BD52EC", VA="0x1BD52EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108874C", Offset="0x108874C")]
		public ShipmentsRequest(ShipmentsRequest other)
		{
		}

		[Address(RVA="0x1BD5500", Offset="0x1BD5500", VA="0x1BD5500", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10887BC", Offset="0x10887BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD5330", Offset="0x1BD5330", VA="0x1BD5330", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108875C", Offset="0x108875C")]
		public ShipmentsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD5390", Offset="0x1BD5390", VA="0x1BD5390", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108876C", Offset="0x108876C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD5428", Offset="0x1BD5428", VA="0x1BD5428", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108877C", Offset="0x108877C")]
		public bool Equals(ShipmentsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD5454", Offset="0x1BD5454", VA="0x1BD5454", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108878C", Offset="0x108878C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD5514", Offset="0x1BD5514", VA="0x1BD5514", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10887CC", Offset="0x10887CC")]
		public void MergeFrom(ShipmentsRequest other)
		{
		}

		[Address(RVA="0x1BD5548", Offset="0x1BD5548", VA="0x1BD5548", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10887DC", Offset="0x10887DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD5484", Offset="0x1BD5484", VA="0x1BD5484", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108879C", Offset="0x108879C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD54EC", Offset="0x1BD54EC", VA="0x1BD54EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10887AC", Offset="0x10887AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050AE8", Offset="0x1050AE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ShipmentsRequest.<>c <>9;

			[Address(RVA="0x1BD5674", Offset="0x1BD5674", VA="0x1BD5674")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD56D8", Offset="0x1BD56D8", VA="0x1BD56D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD56E0", Offset="0x1BD56E0", VA="0x1BD56E0")]
			internal ShipmentsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}