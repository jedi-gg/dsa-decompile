using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreItemResponse : IMessage<StoreItemResponse>, IMessage, IEquatable<StoreItemResponse>, IDeepCloneable<StoreItemResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreItemResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TitleLocKeyFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string titleLocKey_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionLocKeyFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string descriptionLocKey_;

		[FieldOffset(Offset="0x0")]
		public const int GrantsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<StoreItemGrant> _repeated_grants_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<StoreItemGrant> grants_;

		[FieldOffset(Offset="0x0")]
		public const int ShortDescriptionLocKeyFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string shortDescriptionLocKey_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C9D8", Offset="0x109C9D8")]
		public string DescriptionLocKey
		{
			[Address(RVA="0x1BE0D20", Offset="0x1BE0D20", VA="0x1BE0D20")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BE0D28", Offset="0x1BE0D28", VA="0x1BE0D28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C9A8", Offset="0x109C9A8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BE0994", Offset="0x1BE0994", VA="0x1BE0994")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C9E8", Offset="0x109C9E8")]
		public RepeatedField<StoreItemGrant> Grants
		{
			[Address(RVA="0x1BE0D98", Offset="0x1BE0D98", VA="0x1BE0D98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C998", Offset="0x109C998")]
		public static MessageParser<StoreItemResponse> Parser
		{
			[Address(RVA="0x1BE092C", Offset="0x1BE092C", VA="0x1BE092C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C9B8", Offset="0x109C9B8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BE0A84", Offset="0x1BE0A84", VA="0x1BE0A84", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C9F8", Offset="0x109C9F8")]
		public string ShortDescriptionLocKey
		{
			[Address(RVA="0x1BE0DA0", Offset="0x1BE0DA0", VA="0x1BE0DA0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BE0DA8", Offset="0x1BE0DA8", VA="0x1BE0DA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C9C8", Offset="0x109C9C8")]
		public string TitleLocKey
		{
			[Address(RVA="0x1BE0CA8", Offset="0x1BE0CA8", VA="0x1BE0CA8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BE0CB0", Offset="0x1BE0CB0", VA="0x1BE0CB0")]
			set
			{
			}
		}

		[Address(RVA="0x1BE1788", Offset="0x1BE1788", VA="0x1BE1788")]
		static StoreItemResponse()
		{
		}

		[Address(RVA="0x1BE0AE0", Offset="0x1BE0AE0", VA="0x1BE0AE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D6C", Offset="0x1088D6C")]
		public StoreItemResponse()
		{
		}

		[Address(RVA="0x1BE0B6C", Offset="0x1BE0B6C", VA="0x1BE0B6C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D7C", Offset="0x1088D7C")]
		public StoreItemResponse(StoreItemResponse other)
		{
		}

		[Address(RVA="0x1BE1330", Offset="0x1BE1330", VA="0x1BE1330", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088DEC", Offset="0x1088DEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BE0C48", Offset="0x1BE0C48", VA="0x1BE0C48", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D8C", Offset="0x1088D8C")]
		public StoreItemResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BE0E18", Offset="0x1BE0E18", VA="0x1BE0E18", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D9C", Offset="0x1088D9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BE0E8C", Offset="0x1BE0E8C", VA="0x1BE0E8C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088DAC", Offset="0x1088DAC")]
		public bool Equals(StoreItemResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BE0F78", Offset="0x1BE0F78", VA="0x1BE0F78", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088DBC", Offset="0x1088DBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BE14F8", Offset="0x1BE14F8", VA="0x1BE14F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088DFC", Offset="0x1088DFC")]
		public void MergeFrom(StoreItemResponse other)
		{
		}

		[Address(RVA="0x1BE160C", Offset="0x1BE160C", VA="0x1BE160C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E0C", Offset="0x1088E0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BE10B4", Offset="0x1BE10B4", VA="0x1BE10B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088DCC", Offset="0x1088DCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BE111C", Offset="0x1BE111C", VA="0x1BE111C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088DDC", Offset="0x1088DDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B78", Offset="0x1050B78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreItemResponse.<>c <>9;

			[Address(RVA="0x1B5F900", Offset="0x1B5F900", VA="0x1B5F900")]
			static <>c()
			{
			}

			[Address(RVA="0x1B5F964", Offset="0x1B5F964", VA="0x1B5F964")]
			public <>c()
			{
			}

			[Address(RVA="0x1B5F96C", Offset="0x1B5F96C", VA="0x1B5F96C")]
			internal StoreItemResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}