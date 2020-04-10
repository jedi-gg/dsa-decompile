using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetDailyEventsRequest : IMessage<GetDailyEventsRequest>, IMessage, IEquatable<GetDailyEventsRequest>, IDeepCloneable<GetDailyEventsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetDailyEventsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097438", Offset="0x1097438")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA7C2C", Offset="0x1BA7C2C", VA="0x1BA7C2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097428", Offset="0x1097428")]
		public static MessageParser<GetDailyEventsRequest> Parser
		{
			[Address(RVA="0x1BA7BC4", Offset="0x1BA7BC4", VA="0x1BA7BC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097448", Offset="0x1097448")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA7D1C", Offset="0x1BA7D1C", VA="0x1BA7D1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA8030", Offset="0x1BA8030", VA="0x1BA8030")]
		static GetDailyEventsRequest()
		{
		}

		[Address(RVA="0x1BA7D78", Offset="0x1BA7D78", VA="0x1BA7D78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FABC", Offset="0x107FABC")]
		public GetDailyEventsRequest()
		{
		}

		[Address(RVA="0x1BA7D80", Offset="0x1BA7D80", VA="0x1BA7D80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FACC", Offset="0x107FACC")]
		public GetDailyEventsRequest(GetDailyEventsRequest other)
		{
		}

		[Address(RVA="0x1BA7F94", Offset="0x1BA7F94", VA="0x1BA7F94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB3C", Offset="0x107FB3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA7DC4", Offset="0x1BA7DC4", VA="0x1BA7DC4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FADC", Offset="0x107FADC")]
		public GetDailyEventsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA7E24", Offset="0x1BA7E24", VA="0x1BA7E24", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FAEC", Offset="0x107FAEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA7EBC", Offset="0x1BA7EBC", VA="0x1BA7EBC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FAFC", Offset="0x107FAFC")]
		public bool Equals(GetDailyEventsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA7EE8", Offset="0x1BA7EE8", VA="0x1BA7EE8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB0C", Offset="0x107FB0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA7FA8", Offset="0x1BA7FA8", VA="0x1BA7FA8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB4C", Offset="0x107FB4C")]
		public void MergeFrom(GetDailyEventsRequest other)
		{
		}

		[Address(RVA="0x1BA7FDC", Offset="0x1BA7FDC", VA="0x1BA7FDC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB5C", Offset="0x107FB5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA7F18", Offset="0x1BA7F18", VA="0x1BA7F18", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB1C", Offset="0x107FB1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA7F80", Offset="0x1BA7F80", VA="0x1BA7F80", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FB2C", Offset="0x107FB2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE18", Offset="0x104FE18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetDailyEventsRequest.<>c <>9;

			[Address(RVA="0x1BA8108", Offset="0x1BA8108", VA="0x1BA8108")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA816C", Offset="0x1BA816C", VA="0x1BA816C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA8174", Offset="0x1BA8174", VA="0x1BA8174")]
			internal GetDailyEventsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}