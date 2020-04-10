using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshShipmentRequest : IMessage<RefreshShipmentRequest>, IMessage, IEquatable<RefreshShipmentRequest>, IDeepCloneable<RefreshShipmentRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshShipmentRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int LocationFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong location_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentDefIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong shipmentDefId_;

		[FieldOffset(Offset="0x0")]
		public const int UseFreeClubSupportFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool useFreeClubSupport_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C7D0", Offset="0x109C7D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2020418", Offset="0x2020418", VA="0x2020418")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C7F0", Offset="0x109C7F0")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109C7F0", Offset="0x109C7F0")]
		public ulong Location
		{
			[Address(RVA="0x2020668", Offset="0x2020668", VA="0x2020668")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x2020670", Offset="0x2020670", VA="0x2020670")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C7C0", Offset="0x109C7C0")]
		public static MessageParser<RefreshShipmentRequest> Parser
		{
			[Address(RVA="0x20203B0", Offset="0x20203B0", VA="0x20203B0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C7E0", Offset="0x109C7E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2020508", Offset="0x2020508", VA="0x2020508", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C828", Offset="0x109C828")]
		public ulong ShipmentDefId
		{
			[Address(RVA="0x2020678", Offset="0x2020678", VA="0x2020678")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x2020680", Offset="0x2020680", VA="0x2020680")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C838", Offset="0x109C838")]
		public bool UseFreeClubSupport
		{
			[Address(RVA="0x2020688", Offset="0x2020688", VA="0x2020688")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x2020690", Offset="0x2020690", VA="0x2020690")]
			set
			{
			}
		}

		[Address(RVA="0x2020C00", Offset="0x2020C00", VA="0x2020C00")]
		static RefreshShipmentRequest()
		{
		}

		[Address(RVA="0x2020564", Offset="0x2020564", VA="0x2020564")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10889FC", Offset="0x10889FC")]
		public RefreshShipmentRequest()
		{
		}

		[Address(RVA="0x202056C", Offset="0x202056C", VA="0x202056C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A0C", Offset="0x1088A0C")]
		public RefreshShipmentRequest(RefreshShipmentRequest other)
		{
		}

		[Address(RVA="0x20209E0", Offset="0x20209E0", VA="0x20209E0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A7C", Offset="0x1088A7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2020608", Offset="0x2020608", VA="0x2020608", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A1C", Offset="0x1088A1C")]
		public RefreshShipmentRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x202069C", Offset="0x202069C", VA="0x202069C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A2C", Offset="0x1088A2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2020710", Offset="0x2020710", VA="0x2020710", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A3C", Offset="0x1088A3C")]
		public bool Equals(RefreshShipmentRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x202077C", Offset="0x202077C", VA="0x202077C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A4C", Offset="0x1088A4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2020ACC", Offset="0x2020ACC", VA="0x2020ACC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A8C", Offset="0x1088A8C")]
		public void MergeFrom(RefreshShipmentRequest other)
		{
		}

		[Address(RVA="0x2020B24", Offset="0x2020B24", VA="0x2020B24", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A9C", Offset="0x1088A9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2020824", Offset="0x2020824", VA="0x2020824", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A5C", Offset="0x1088A5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x202088C", Offset="0x202088C", VA="0x202088C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088A6C", Offset="0x1088A6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B28", Offset="0x1050B28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshShipmentRequest.<>c <>9;

			[Address(RVA="0x2020CD8", Offset="0x2020CD8", VA="0x2020CD8")]
			static <>c()
			{
			}

			[Address(RVA="0x2020D3C", Offset="0x2020D3C", VA="0x2020D3C")]
			public <>c()
			{
			}

			[Address(RVA="0x2020D44", Offset="0x2020D44", VA="0x2020D44")]
			internal RefreshShipmentRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}