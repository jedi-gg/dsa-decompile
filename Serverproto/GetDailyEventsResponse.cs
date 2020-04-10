using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetDailyEventsResponse : IMessage<GetDailyEventsResponse>, IMessage, IEquatable<GetDailyEventsResponse>, IDeepCloneable<GetDailyEventsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetDailyEventsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DailyEventsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Event> _repeated_dailyEvents_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Event> dailyEvents_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097488", Offset="0x1097488")]
		public RepeatedField<Event> DailyEvents
		{
			[Address(RVA="0x1BA84EC", Offset="0x1BA84EC", VA="0x1BA84EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097468", Offset="0x1097468")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA8238", Offset="0x1BA8238", VA="0x1BA8238")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097458", Offset="0x1097458")]
		public static MessageParser<GetDailyEventsResponse> Parser
		{
			[Address(RVA="0x1BA81D0", Offset="0x1BA81D0", VA="0x1BA81D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097478", Offset="0x1097478")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA8328", Offset="0x1BA8328", VA="0x1BA8328", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA89D4", Offset="0x1BA89D4", VA="0x1BA89D4")]
		static GetDailyEventsResponse()
		{
		}

		[Address(RVA="0x1BA8384", Offset="0x1BA8384", VA="0x1BA8384")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB6C", Offset="0x107FB6C")]
		public GetDailyEventsResponse()
		{
		}

		[Address(RVA="0x1BA83F4", Offset="0x1BA83F4", VA="0x1BA83F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB7C", Offset="0x107FB7C")]
		public GetDailyEventsResponse(GetDailyEventsResponse other)
		{
		}

		[Address(RVA="0x1BA87A4", Offset="0x1BA87A4", VA="0x1BA87A4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FBEC", Offset="0x107FBEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA848C", Offset="0x1BA848C", VA="0x1BA848C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB8C", Offset="0x107FB8C")]
		public GetDailyEventsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA84F4", Offset="0x1BA84F4", VA="0x1BA84F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB9C", Offset="0x107FB9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA8568", Offset="0x1BA8568", VA="0x1BA8568", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FBAC", Offset="0x107FBAC")]
		public bool Equals(GetDailyEventsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA8618", Offset="0x1BA8618", VA="0x1BA8618", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FBBC", Offset="0x107FBBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA8860", Offset="0x1BA8860", VA="0x1BA8860", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FBFC", Offset="0x107FBFC")]
		public void MergeFrom(GetDailyEventsResponse other)
		{
		}

		[Address(RVA="0x1BA88F0", Offset="0x1BA88F0", VA="0x1BA88F0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC0C", Offset="0x107FC0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA8678", Offset="0x1BA8678", VA="0x1BA8678", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FBCC", Offset="0x107FBCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA86E0", Offset="0x1BA86E0", VA="0x1BA86E0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FBDC", Offset="0x107FBDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE28", Offset="0x104FE28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetDailyEventsResponse.<>c <>9;

			[Address(RVA="0x1BA8AF8", Offset="0x1BA8AF8", VA="0x1BA8AF8")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA8B5C", Offset="0x1BA8B5C", VA="0x1BA8B5C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA8B64", Offset="0x1BA8B64", VA="0x1BA8B64")]
			internal GetDailyEventsResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}