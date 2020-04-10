using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CancelMatchmakingResponse : IMessage<CancelMatchmakingResponse>, IMessage, IEquatable<CancelMatchmakingResponse>, IDeepCloneable<CancelMatchmakingResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CancelMatchmakingResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10920D8", Offset="0x10920D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F9854C", Offset="0x1F9854C", VA="0x1F9854C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10920C8", Offset="0x10920C8")]
		public static MessageParser<CancelMatchmakingResponse> Parser
		{
			[Address(RVA="0x1F984E4", Offset="0x1F984E4", VA="0x1F984E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10920E8", Offset="0x10920E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F9863C", Offset="0x1F9863C", VA="0x1F9863C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F98950", Offset="0x1F98950", VA="0x1F98950")]
		static CancelMatchmakingResponse()
		{
		}

		[Address(RVA="0x1F98698", Offset="0x1F98698", VA="0x1F98698")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10763CC", Offset="0x10763CC")]
		public CancelMatchmakingResponse()
		{
		}

		[Address(RVA="0x1F986A0", Offset="0x1F986A0", VA="0x1F986A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10763DC", Offset="0x10763DC")]
		public CancelMatchmakingResponse(CancelMatchmakingResponse other)
		{
		}

		[Address(RVA="0x1F988B4", Offset="0x1F988B4", VA="0x1F988B4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107644C", Offset="0x107644C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F986E4", Offset="0x1F986E4", VA="0x1F986E4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10763EC", Offset="0x10763EC")]
		public CancelMatchmakingResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F98744", Offset="0x1F98744", VA="0x1F98744", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10763FC", Offset="0x10763FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F987DC", Offset="0x1F987DC", VA="0x1F987DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107640C", Offset="0x107640C")]
		public bool Equals(CancelMatchmakingResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F98808", Offset="0x1F98808", VA="0x1F98808", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107641C", Offset="0x107641C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F988C8", Offset="0x1F988C8", VA="0x1F988C8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107645C", Offset="0x107645C")]
		public void MergeFrom(CancelMatchmakingResponse other)
		{
		}

		[Address(RVA="0x1F988FC", Offset="0x1F988FC", VA="0x1F988FC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107646C", Offset="0x107646C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F98838", Offset="0x1F98838", VA="0x1F98838", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107642C", Offset="0x107642C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F988A0", Offset="0x1F988A0", VA="0x1F988A0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107643C", Offset="0x107643C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F018", Offset="0x104F018")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CancelMatchmakingResponse.<>c <>9;

			[Address(RVA="0x1F98A28", Offset="0x1F98A28", VA="0x1F98A28")]
			static <>c()
			{
			}

			[Address(RVA="0x1F98A8C", Offset="0x1F98A8C", VA="0x1F98A8C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F98A94", Offset="0x1F98A94", VA="0x1F98A94")]
			internal CancelMatchmakingResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}