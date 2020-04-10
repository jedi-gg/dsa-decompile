using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarMakeDefenseResponse : IMessage<ClubWarMakeDefenseResponse>, IMessage, IEquatable<ClubWarMakeDefenseResponse>, IDeepCloneable<ClubWarMakeDefenseResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarMakeDefenseResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096090", Offset="0x1096090")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B2405C", Offset="0x1B2405C", VA="0x1B2405C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096080", Offset="0x1096080")]
		public static MessageParser<ClubWarMakeDefenseResponse> Parser
		{
			[Address(RVA="0x1B23FF4", Offset="0x1B23FF4", VA="0x1B23FF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10960A0", Offset="0x10960A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B2414C", Offset="0x1B2414C", VA="0x1B2414C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B24460", Offset="0x1B24460", VA="0x1B24460")]
		static ClubWarMakeDefenseResponse()
		{
		}

		[Address(RVA="0x1B241A8", Offset="0x1B241A8", VA="0x1B241A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD2C", Offset="0x107DD2C")]
		public ClubWarMakeDefenseResponse()
		{
		}

		[Address(RVA="0x1B241B0", Offset="0x1B241B0", VA="0x1B241B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD3C", Offset="0x107DD3C")]
		public ClubWarMakeDefenseResponse(ClubWarMakeDefenseResponse other)
		{
		}

		[Address(RVA="0x1B243C4", Offset="0x1B243C4", VA="0x1B243C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DDAC", Offset="0x107DDAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B241F4", Offset="0x1B241F4", VA="0x1B241F4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD4C", Offset="0x107DD4C")]
		public ClubWarMakeDefenseResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B24254", Offset="0x1B24254", VA="0x1B24254", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD5C", Offset="0x107DD5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B242EC", Offset="0x1B242EC", VA="0x1B242EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD6C", Offset="0x107DD6C")]
		public bool Equals(ClubWarMakeDefenseResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B24318", Offset="0x1B24318", VA="0x1B24318", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD7C", Offset="0x107DD7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B243D8", Offset="0x1B243D8", VA="0x1B243D8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DDBC", Offset="0x107DDBC")]
		public void MergeFrom(ClubWarMakeDefenseResponse other)
		{
		}

		[Address(RVA="0x1B2440C", Offset="0x1B2440C", VA="0x1B2440C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DDCC", Offset="0x107DDCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B24348", Offset="0x1B24348", VA="0x1B24348", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD8C", Offset="0x107DD8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B243B0", Offset="0x1B243B0", VA="0x1B243B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD9C", Offset="0x107DD9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB68", Offset="0x104FB68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarMakeDefenseResponse.<>c <>9;

			[Address(RVA="0x1B24538", Offset="0x1B24538", VA="0x1B24538")]
			static <>c()
			{
			}

			[Address(RVA="0x1B2459C", Offset="0x1B2459C", VA="0x1B2459C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B245A4", Offset="0x1B245A4", VA="0x1B245A4")]
			internal ClubWarMakeDefenseResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}