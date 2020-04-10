using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MetadataRequest : IMessage<MetadataRequest>, IMessage, IEquatable<MetadataRequest>, IDeepCloneable<MetadataRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MetadataRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DeviceInfoFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.DeviceInfo deviceInfo_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10919C0", Offset="0x10919C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1FBDC", Offset="0x1A1FBDC", VA="0x1A1FBDC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10919E0", Offset="0x10919E0")]
		public Serverproto.DeviceInfo DeviceInfo
		{
			[Address(RVA="0x1A1FDAC", Offset="0x1A1FDAC", VA="0x1A1FDAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1FDB4", Offset="0x1A1FDB4", VA="0x1A1FDB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10919B0", Offset="0x10919B0")]
		public static MessageParser<MetadataRequest> Parser
		{
			[Address(RVA="0x1A1FB74", Offset="0x1A1FB74", VA="0x1A1FB74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10919D0", Offset="0x10919D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1FCCC", Offset="0x1A1FCCC", VA="0x1A1FCCC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A20274", Offset="0x1A20274", VA="0x1A20274")]
		static MetadataRequest()
		{
		}

		[Address(RVA="0x1A1FD28", Offset="0x1A1FD28", VA="0x1A1FD28")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107576C", Offset="0x107576C")]
		public MetadataRequest()
		{
		}

		[Address(RVA="0x1A1FD30", Offset="0x1A1FD30", VA="0x1A1FD30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107577C", Offset="0x107577C")]
		public MetadataRequest(MetadataRequest other)
		{
		}

		[Address(RVA="0x1A20054", Offset="0x1A20054", VA="0x1A20054", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10757EC", Offset="0x10757EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1FDBC", Offset="0x1A1FDBC", VA="0x1A1FDBC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107578C", Offset="0x107578C")]
		public MetadataRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1FE1C", Offset="0x1A1FE1C", VA="0x1A1FE1C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107579C", Offset="0x107579C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1FE90", Offset="0x1A1FE90", VA="0x1A1FE90", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10757AC", Offset="0x10757AC")]
		public bool Equals(MetadataRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1FEF4", Offset="0x1A1FEF4", VA="0x1A1FEF4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10757BC", Offset="0x10757BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A200E4", Offset="0x1A200E4", VA="0x1A200E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10757FC", Offset="0x10757FC")]
		public void MergeFrom(MetadataRequest other)
		{
		}

		[Address(RVA="0x1A20198", Offset="0x1A20198", VA="0x1A20198", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107580C", Offset="0x107580C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1FF4C", Offset="0x1A1FF4C", VA="0x1A1FF4C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10757CC", Offset="0x10757CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1FFB4", Offset="0x1A1FFB4", VA="0x1A1FFB4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10757DC", Offset="0x10757DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EEF8", Offset="0x104EEF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MetadataRequest.<>c <>9;

			[Address(RVA="0x1A2034C", Offset="0x1A2034C", VA="0x1A2034C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A203B0", Offset="0x1A203B0", VA="0x1A203B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A203B8", Offset="0x1A203B8", VA="0x1A203B8")]
			internal MetadataRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}