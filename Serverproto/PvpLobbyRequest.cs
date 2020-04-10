using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpLobbyRequest : IMessage<PvpLobbyRequest>, IMessage, IEquatable<PvpLobbyRequest>, IDeepCloneable<PvpLobbyRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpLobbyRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B570", Offset="0x109B570")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2018520", Offset="0x2018520", VA="0x2018520")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B560", Offset="0x109B560")]
		public static MessageParser<PvpLobbyRequest> Parser
		{
			[Address(RVA="0x20184B8", Offset="0x20184B8", VA="0x20184B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B580", Offset="0x109B580")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2018610", Offset="0x2018610", VA="0x2018610", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2018924", Offset="0x2018924", VA="0x2018924")]
		static PvpLobbyRequest()
		{
		}

		[Address(RVA="0x201866C", Offset="0x201866C", VA="0x201866C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E7C", Offset="0x1086E7C")]
		public PvpLobbyRequest()
		{
		}

		[Address(RVA="0x2018674", Offset="0x2018674", VA="0x2018674")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E8C", Offset="0x1086E8C")]
		public PvpLobbyRequest(PvpLobbyRequest other)
		{
		}

		[Address(RVA="0x2018888", Offset="0x2018888", VA="0x2018888", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086EFC", Offset="0x1086EFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x20186B8", Offset="0x20186B8", VA="0x20186B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E9C", Offset="0x1086E9C")]
		public PvpLobbyRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2018718", Offset="0x2018718", VA="0x2018718", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086EAC", Offset="0x1086EAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x20187B0", Offset="0x20187B0", VA="0x20187B0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086EBC", Offset="0x1086EBC")]
		public bool Equals(PvpLobbyRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x20187DC", Offset="0x20187DC", VA="0x20187DC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086ECC", Offset="0x1086ECC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201889C", Offset="0x201889C", VA="0x201889C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F0C", Offset="0x1086F0C")]
		public void MergeFrom(PvpLobbyRequest other)
		{
		}

		[Address(RVA="0x20188D0", Offset="0x20188D0", VA="0x20188D0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F1C", Offset="0x1086F1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201880C", Offset="0x201880C", VA="0x201880C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086EDC", Offset="0x1086EDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2018874", Offset="0x2018874", VA="0x2018874", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086EEC", Offset="0x1086EEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050898", Offset="0x1050898")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpLobbyRequest.<>c <>9;

			[Address(RVA="0x20189FC", Offset="0x20189FC", VA="0x20189FC")]
			static <>c()
			{
			}

			[Address(RVA="0x2018A60", Offset="0x2018A60", VA="0x2018A60")]
			public <>c()
			{
			}

			[Address(RVA="0x2018A68", Offset="0x2018A68", VA="0x2018A68")]
			internal PvpLobbyRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}