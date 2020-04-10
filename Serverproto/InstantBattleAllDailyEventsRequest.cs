using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InstantBattleAllDailyEventsRequest : IMessage<InstantBattleAllDailyEventsRequest>, IMessage, IEquatable<InstantBattleAllDailyEventsRequest>, IDeepCloneable<InstantBattleAllDailyEventsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InstantBattleAllDailyEventsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E20", Offset="0x1092E20")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E3D50", Offset="0x18E3D50", VA="0x18E3D50")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E10", Offset="0x1092E10")]
		public static MessageParser<InstantBattleAllDailyEventsRequest> Parser
		{
			[Address(RVA="0x18E3CE8", Offset="0x18E3CE8", VA="0x18E3CE8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E30", Offset="0x1092E30")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E3E40", Offset="0x18E3E40", VA="0x18E3E40", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E4154", Offset="0x18E4154", VA="0x18E4154")]
		static InstantBattleAllDailyEventsRequest()
		{
		}

		[Address(RVA="0x18E3E9C", Offset="0x18E3E9C", VA="0x18E3E9C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B2C", Offset="0x1077B2C")]
		public InstantBattleAllDailyEventsRequest()
		{
		}

		[Address(RVA="0x18E3EA4", Offset="0x18E3EA4", VA="0x18E3EA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B3C", Offset="0x1077B3C")]
		public InstantBattleAllDailyEventsRequest(InstantBattleAllDailyEventsRequest other)
		{
		}

		[Address(RVA="0x18E40B8", Offset="0x18E40B8", VA="0x18E40B8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077BAC", Offset="0x1077BAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E3EE8", Offset="0x18E3EE8", VA="0x18E3EE8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B4C", Offset="0x1077B4C")]
		public InstantBattleAllDailyEventsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18E3F48", Offset="0x18E3F48", VA="0x18E3F48", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B5C", Offset="0x1077B5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E3FE0", Offset="0x18E3FE0", VA="0x18E3FE0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B6C", Offset="0x1077B6C")]
		public bool Equals(InstantBattleAllDailyEventsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18E400C", Offset="0x18E400C", VA="0x18E400C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B7C", Offset="0x1077B7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E40CC", Offset="0x18E40CC", VA="0x18E40CC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077BBC", Offset="0x1077BBC")]
		public void MergeFrom(InstantBattleAllDailyEventsRequest other)
		{
		}

		[Address(RVA="0x18E4100", Offset="0x18E4100", VA="0x18E4100", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077BCC", Offset="0x1077BCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E403C", Offset="0x18E403C", VA="0x18E403C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B8C", Offset="0x1077B8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E40A4", Offset="0x18E40A4", VA="0x18E40A4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B9C", Offset="0x1077B9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F238", Offset="0x104F238")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InstantBattleAllDailyEventsRequest.<>c <>9;

			[Address(RVA="0x18E422C", Offset="0x18E422C", VA="0x18E422C")]
			static <>c()
			{
			}

			[Address(RVA="0x18E4290", Offset="0x18E4290", VA="0x18E4290")]
			public <>c()
			{
			}

			[Address(RVA="0x18E4298", Offset="0x18E4298", VA="0x18E4298")]
			internal InstantBattleAllDailyEventsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}