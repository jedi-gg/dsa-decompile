using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarCaptureUndefendedNodeResponse : IMessage<ClubWarCaptureUndefendedNodeResponse>, IMessage, IEquatable<ClubWarCaptureUndefendedNodeResponse>, IDeepCloneable<ClubWarCaptureUndefendedNodeResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarCaptureUndefendedNodeResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NodeDetailFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubWarNodeDetailResponse nodeDetail_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096530", Offset="0x1096530")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1E668", Offset="0x1B1E668", VA="0x1B1E668")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096550", Offset="0x1096550")]
		public ClubWarNodeDetailResponse NodeDetail
		{
			[Address(RVA="0x1B1E834", Offset="0x1B1E834", VA="0x1B1E834")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1E89C", Offset="0x1B1E89C", VA="0x1B1E89C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096520", Offset="0x1096520")]
		public static MessageParser<ClubWarCaptureUndefendedNodeResponse> Parser
		{
			[Address(RVA="0x1B1E600", Offset="0x1B1E600", VA="0x1B1E600")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096540", Offset="0x1096540")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1E758", Offset="0x1B1E758", VA="0x1B1E758", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1EE68", Offset="0x1B1EE68", VA="0x1B1EE68")]
		static ClubWarCaptureUndefendedNodeResponse()
		{
		}

		[Address(RVA="0x1B1E7B4", Offset="0x1B1E7B4", VA="0x1B1E7B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E8DC", Offset="0x107E8DC")]
		public ClubWarCaptureUndefendedNodeResponse()
		{
		}

		[Address(RVA="0x1B1E7BC", Offset="0x1B1E7BC", VA="0x1B1E7BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E8EC", Offset="0x107E8EC")]
		public ClubWarCaptureUndefendedNodeResponse(ClubWarCaptureUndefendedNodeResponse other)
		{
		}

		[Address(RVA="0x1B1EB3C", Offset="0x1B1EB3C", VA="0x1B1EB3C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E95C", Offset="0x107E95C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1E8A4", Offset="0x1B1E8A4", VA="0x1B1E8A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E8FC", Offset="0x107E8FC")]
		public ClubWarCaptureUndefendedNodeResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1E904", Offset="0x1B1E904", VA="0x1B1E904", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E90C", Offset="0x107E90C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1E978", Offset="0x1B1E978", VA="0x1B1E978", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E91C", Offset="0x107E91C")]
		public bool Equals(ClubWarCaptureUndefendedNodeResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1E9DC", Offset="0x1B1E9DC", VA="0x1B1E9DC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E92C", Offset="0x107E92C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1EBCC", Offset="0x1B1EBCC", VA="0x1B1EBCC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E96C", Offset="0x107E96C")]
		public void MergeFrom(ClubWarCaptureUndefendedNodeResponse other)
		{
		}

		[Address(RVA="0x1B1ED90", Offset="0x1B1ED90", VA="0x1B1ED90", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E97C", Offset="0x107E97C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1EA34", Offset="0x1B1EA34", VA="0x1B1EA34", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E93C", Offset="0x107E93C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1EA9C", Offset="0x1B1EA9C", VA="0x1B1EA9C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E94C", Offset="0x107E94C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC78", Offset="0x104FC78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarCaptureUndefendedNodeResponse.<>c <>9;

			[Address(RVA="0x1B1EF40", Offset="0x1B1EF40", VA="0x1B1EF40")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1EFA4", Offset="0x1B1EFA4", VA="0x1B1EFA4")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1EFAC", Offset="0x1B1EFAC", VA="0x1B1EFAC")]
			internal ClubWarCaptureUndefendedNodeResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}