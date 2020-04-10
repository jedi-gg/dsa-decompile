using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CancelMatchmakingRequest : IMessage<CancelMatchmakingRequest>, IMessage, IEquatable<CancelMatchmakingRequest>, IDeepCloneable<CancelMatchmakingRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CancelMatchmakingRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10920A8", Offset="0x10920A8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F97F40", Offset="0x1F97F40", VA="0x1F97F40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092098", Offset="0x1092098")]
		public static MessageParser<CancelMatchmakingRequest> Parser
		{
			[Address(RVA="0x1F97ED8", Offset="0x1F97ED8", VA="0x1F97ED8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10920B8", Offset="0x10920B8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F98030", Offset="0x1F98030", VA="0x1F98030", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F98344", Offset="0x1F98344", VA="0x1F98344")]
		static CancelMatchmakingRequest()
		{
		}

		[Address(RVA="0x1F9808C", Offset="0x1F9808C", VA="0x1F9808C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107631C", Offset="0x107631C")]
		public CancelMatchmakingRequest()
		{
		}

		[Address(RVA="0x1F98094", Offset="0x1F98094", VA="0x1F98094")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107632C", Offset="0x107632C")]
		public CancelMatchmakingRequest(CancelMatchmakingRequest other)
		{
		}

		[Address(RVA="0x1F982A8", Offset="0x1F982A8", VA="0x1F982A8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107639C", Offset="0x107639C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F980D8", Offset="0x1F980D8", VA="0x1F980D8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107633C", Offset="0x107633C")]
		public CancelMatchmakingRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F98138", Offset="0x1F98138", VA="0x1F98138", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107634C", Offset="0x107634C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F981D0", Offset="0x1F981D0", VA="0x1F981D0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107635C", Offset="0x107635C")]
		public bool Equals(CancelMatchmakingRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F981FC", Offset="0x1F981FC", VA="0x1F981FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107636C", Offset="0x107636C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F982BC", Offset="0x1F982BC", VA="0x1F982BC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10763AC", Offset="0x10763AC")]
		public void MergeFrom(CancelMatchmakingRequest other)
		{
		}

		[Address(RVA="0x1F982F0", Offset="0x1F982F0", VA="0x1F982F0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10763BC", Offset="0x10763BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F9822C", Offset="0x1F9822C", VA="0x1F9822C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107637C", Offset="0x107637C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F98294", Offset="0x1F98294", VA="0x1F98294", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107638C", Offset="0x107638C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F008", Offset="0x104F008")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CancelMatchmakingRequest.<>c <>9;

			[Address(RVA="0x1F9841C", Offset="0x1F9841C", VA="0x1F9841C")]
			static <>c()
			{
			}

			[Address(RVA="0x1F98480", Offset="0x1F98480", VA="0x1F98480")]
			public <>c()
			{
			}

			[Address(RVA="0x1F98488", Offset="0x1F98488", VA="0x1F98488")]
			internal CancelMatchmakingRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}