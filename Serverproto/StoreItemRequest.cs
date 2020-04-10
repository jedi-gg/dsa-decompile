using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreItemRequest : IMessage<StoreItemRequest>, IMessage, IEquatable<StoreItemRequest>, IDeepCloneable<StoreItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong storeItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C8A8", Offset="0x109C8A8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BE01F8", Offset="0x1BE01F8", VA="0x1BE01F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C898", Offset="0x109C898")]
		public static MessageParser<StoreItemRequest> Parser
		{
			[Address(RVA="0x1BE0190", Offset="0x1BE0190", VA="0x1BE0190")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C8B8", Offset="0x109C8B8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BE02E8", Offset="0x1BE02E8", VA="0x1BE02E8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C8C8", Offset="0x109C8C8")]
		public ulong StoreItemId
		{
			[Address(RVA="0x1BE0410", Offset="0x1BE0410", VA="0x1BE0410")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BE0418", Offset="0x1BE0418", VA="0x1BE0418")]
			set
			{
			}
		}

		[Address(RVA="0x1BE078C", Offset="0x1BE078C", VA="0x1BE078C")]
		static StoreItemRequest()
		{
		}

		[Address(RVA="0x1BE0344", Offset="0x1BE0344", VA="0x1BE0344")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B5C", Offset="0x1088B5C")]
		public StoreItemRequest()
		{
		}

		[Address(RVA="0x1BE034C", Offset="0x1BE034C", VA="0x1BE034C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B6C", Offset="0x1088B6C")]
		public StoreItemRequest(StoreItemRequest other)
		{
		}

		[Address(RVA="0x1BE0640", Offset="0x1BE0640", VA="0x1BE0640", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088BDC", Offset="0x1088BDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BE03B0", Offset="0x1BE03B0", VA="0x1BE03B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B7C", Offset="0x1088B7C")]
		public StoreItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BE0420", Offset="0x1BE0420", VA="0x1BE0420", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B8C", Offset="0x1088B8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BE0494", Offset="0x1BE0494", VA="0x1BE0494", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B9C", Offset="0x1088B9C")]
		public bool Equals(StoreItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BE04D0", Offset="0x1BE04D0", VA="0x1BE04D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088BAC", Offset="0x1088BAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BE06D0", Offset="0x1BE06D0", VA="0x1BE06D0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088BEC", Offset="0x1088BEC")]
		public void MergeFrom(StoreItemRequest other)
		{
		}

		[Address(RVA="0x1BE0710", Offset="0x1BE0710", VA="0x1BE0710", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088BFC", Offset="0x1088BFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BE0538", Offset="0x1BE0538", VA="0x1BE0538", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088BBC", Offset="0x1088BBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BE05A0", Offset="0x1BE05A0", VA="0x1BE05A0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088BCC", Offset="0x1088BCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B48", Offset="0x1050B48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreItemRequest.<>c <>9;

			[Address(RVA="0x1BE0864", Offset="0x1BE0864", VA="0x1BE0864")]
			static <>c()
			{
			}

			[Address(RVA="0x1BE08C8", Offset="0x1BE08C8", VA="0x1BE08C8")]
			public <>c()
			{
			}

			[Address(RVA="0x1BE08D0", Offset="0x1BE08D0", VA="0x1BE08D0")]
			internal StoreItemRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}