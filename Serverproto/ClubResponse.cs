using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubResponse : IMessage<ClubResponse>, IMessage, IEquatable<ClubResponse>, IDeepCloneable<ClubResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D10", Offset="0x1094D10")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x200F2C4", Offset="0x200F2C4", VA="0x200F2C4")]
			get
			{
				return null;
			}
			[Address(RVA="0x200F2CC", Offset="0x200F2CC", VA="0x200F2CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094CF0", Offset="0x1094CF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x200F0F8", Offset="0x200F0F8", VA="0x200F0F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094CE0", Offset="0x1094CE0")]
		public static MessageParser<ClubResponse> Parser
		{
			[Address(RVA="0x200E7FC", Offset="0x200E7FC", VA="0x200E7FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D00", Offset="0x1094D00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x200F1E4", Offset="0x200F1E4", VA="0x200F1E4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x200F78C", Offset="0x200F78C", VA="0x200F78C")]
		static ClubResponse()
		{
		}

		[Address(RVA="0x200F240", Offset="0x200F240", VA="0x200F240")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF1C", Offset="0x107AF1C")]
		public ClubResponse()
		{
		}

		[Address(RVA="0x200F248", Offset="0x200F248", VA="0x200F248")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF2C", Offset="0x107AF2C")]
		public ClubResponse(ClubResponse other)
		{
		}

		[Address(RVA="0x200F56C", Offset="0x200F56C", VA="0x200F56C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF9C", Offset="0x107AF9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x200F2D4", Offset="0x200F2D4", VA="0x200F2D4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF3C", Offset="0x107AF3C")]
		public ClubResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x200F334", Offset="0x200F334", VA="0x200F334", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF4C", Offset="0x107AF4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x200F3A8", Offset="0x200F3A8", VA="0x200F3A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF5C", Offset="0x107AF5C")]
		public bool Equals(ClubResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x200F40C", Offset="0x200F40C", VA="0x200F40C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF6C", Offset="0x107AF6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x200F5FC", Offset="0x200F5FC", VA="0x200F5FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AFAC", Offset="0x107AFAC")]
		public void MergeFrom(ClubResponse other)
		{
		}

		[Address(RVA="0x200F6B0", Offset="0x200F6B0", VA="0x200F6B0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AFBC", Offset="0x107AFBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x200F464", Offset="0x200F464", VA="0x200F464", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF7C", Offset="0x107AF7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x200F4CC", Offset="0x200F4CC", VA="0x200F4CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AF8C", Offset="0x107AF8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F728", Offset="0x104F728")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubResponse.<>c <>9;

			[Address(RVA="0x1B14850", Offset="0x1B14850", VA="0x1B14850")]
			static <>c()
			{
			}

			[Address(RVA="0x1B148B4", Offset="0x1B148B4", VA="0x1B148B4")]
			public <>c()
			{
			}

			[Address(RVA="0x1B148BC", Offset="0x1B148BC", VA="0x1B148BC")]
			internal ClubResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}