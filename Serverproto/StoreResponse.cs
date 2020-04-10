using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreResponse : IMessage<StoreResponse>, IMessage, IEquatable<StoreResponse>, IDeepCloneable<StoreResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TabsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<StoreTab> _repeated_tabs_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<StoreTab> tabs_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C4E8", Offset="0x109C4E8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B67E74", Offset="0x1B67E74", VA="0x1B67E74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C4D8", Offset="0x109C4D8")]
		public static MessageParser<StoreResponse> Parser
		{
			[Address(RVA="0x1B6786C", Offset="0x1B6786C", VA="0x1B6786C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C4F8", Offset="0x109C4F8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B67F60", Offset="0x1B67F60", VA="0x1B67F60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C508", Offset="0x109C508")]
		public RepeatedField<StoreTab> Tabs
		{
			[Address(RVA="0x1B68124", Offset="0x1B68124", VA="0x1B68124")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B6860C", Offset="0x1B6860C", VA="0x1B6860C")]
		static StoreResponse()
		{
		}

		[Address(RVA="0x1B67FBC", Offset="0x1B67FBC", VA="0x1B67FBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108852C", Offset="0x108852C")]
		public StoreResponse()
		{
		}

		[Address(RVA="0x1B6802C", Offset="0x1B6802C", VA="0x1B6802C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108853C", Offset="0x108853C")]
		public StoreResponse(StoreResponse other)
		{
		}

		[Address(RVA="0x1B683DC", Offset="0x1B683DC", VA="0x1B683DC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10885AC", Offset="0x10885AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B680C4", Offset="0x1B680C4", VA="0x1B680C4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108854C", Offset="0x108854C")]
		public StoreResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6812C", Offset="0x1B6812C", VA="0x1B6812C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108855C", Offset="0x108855C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B681A0", Offset="0x1B681A0", VA="0x1B681A0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108856C", Offset="0x108856C")]
		public bool Equals(StoreResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B68250", Offset="0x1B68250", VA="0x1B68250", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108857C", Offset="0x108857C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B68498", Offset="0x1B68498", VA="0x1B68498", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10885BC", Offset="0x10885BC")]
		public void MergeFrom(StoreResponse other)
		{
		}

		[Address(RVA="0x1B68528", Offset="0x1B68528", VA="0x1B68528", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10885CC", Offset="0x10885CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B682B0", Offset="0x1B682B0", VA="0x1B682B0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108858C", Offset="0x108858C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B68318", Offset="0x1B68318", VA="0x1B68318", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108859C", Offset="0x108859C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050AB8", Offset="0x1050AB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreResponse.<>c <>9;

			[Address(RVA="0x1B6872C", Offset="0x1B6872C", VA="0x1B6872C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B68790", Offset="0x1B68790", VA="0x1B68790")]
			public <>c()
			{
			}

			[Address(RVA="0x1B68798", Offset="0x1B68798", VA="0x1B68798")]
			internal StoreResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}