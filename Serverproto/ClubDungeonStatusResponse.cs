using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonStatusResponse : IMessage<ClubDungeonStatusResponse>, IMessage, IEquatable<ClubDungeonStatusResponse>, IDeepCloneable<ClubDungeonStatusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonStatusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubDungeonStatus status_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095910", Offset="0x1095910")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF6678", Offset="0x1FF6678", VA="0x1FF6678")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095900", Offset="0x1095900")]
		public static MessageParser<ClubDungeonStatusResponse> Parser
		{
			[Address(RVA="0x1FF6610", Offset="0x1FF6610", VA="0x1FF6610")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095920", Offset="0x1095920")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF6764", Offset="0x1FF6764", VA="0x1FF6764", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095930", Offset="0x1095930")]
		public ClubDungeonStatus Status
		{
			[Address(RVA="0x1FF6840", Offset="0x1FF6840", VA="0x1FF6840")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF6848", Offset="0x1FF6848", VA="0x1FF6848")]
			set
			{
			}
		}

		[Address(RVA="0x1FF6CFC", Offset="0x1FF6CFC", VA="0x1FF6CFC")]
		static ClubDungeonStatusResponse()
		{
		}

		[Address(RVA="0x1FF67C0", Offset="0x1FF67C0", VA="0x1FF67C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CBFC", Offset="0x107CBFC")]
		public ClubDungeonStatusResponse()
		{
		}

		[Address(RVA="0x1FF67C8", Offset="0x1FF67C8", VA="0x1FF67C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC0C", Offset="0x107CC0C")]
		public ClubDungeonStatusResponse(ClubDungeonStatusResponse other)
		{
		}

		[Address(RVA="0x1FF6AE8", Offset="0x1FF6AE8", VA="0x1FF6AE8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC7C", Offset="0x107CC7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF6850", Offset="0x1FF6850", VA="0x1FF6850", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC1C", Offset="0x107CC1C")]
		public ClubDungeonStatusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF68B0", Offset="0x1FF68B0", VA="0x1FF68B0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC2C", Offset="0x107CC2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF6924", Offset="0x1FF6924", VA="0x1FF6924", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC3C", Offset="0x107CC3C")]
		public bool Equals(ClubDungeonStatusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF6988", Offset="0x1FF6988", VA="0x1FF6988", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC4C", Offset="0x107CC4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF6B78", Offset="0x1FF6B78", VA="0x1FF6B78", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC8C", Offset="0x107CC8C")]
		public void MergeFrom(ClubDungeonStatusResponse other)
		{
		}

		[Address(RVA="0x1FF6C24", Offset="0x1FF6C24", VA="0x1FF6C24", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC9C", Offset="0x107CC9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF69E0", Offset="0x1FF69E0", VA="0x1FF69E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC5C", Offset="0x107CC5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF6A48", Offset="0x1FF6A48", VA="0x1FF6A48", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CC6C", Offset="0x107CC6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F9C8", Offset="0x104F9C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonStatusResponse.<>c <>9;

			[Address(RVA="0x1FF6DD4", Offset="0x1FF6DD4", VA="0x1FF6DD4")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF6E38", Offset="0x1FF6E38", VA="0x1FF6E38")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF6E40", Offset="0x1FF6E40", VA="0x1FF6E40")]
			internal ClubDungeonStatusResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}