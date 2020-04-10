using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UpdateClubResponse : IMessage<UpdateClubResponse>, IMessage, IEquatable<UpdateClubResponse>, IDeepCloneable<UpdateClubResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UpdateClubResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D80", Offset="0x1094D80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B7730", Offset="0x14B7730", VA="0x14B7730")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D70", Offset="0x1094D70")]
		public static MessageParser<UpdateClubResponse> Parser
		{
			[Address(RVA="0x14B76C8", Offset="0x14B76C8", VA="0x14B76C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D90", Offset="0x1094D90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B7820", Offset="0x14B7820", VA="0x14B7820", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14B7B34", Offset="0x14B7B34", VA="0x14B7B34")]
		static UpdateClubResponse()
		{
		}

		[Address(RVA="0x14B787C", Offset="0x14B787C", VA="0x14B787C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B07C", Offset="0x107B07C")]
		public UpdateClubResponse()
		{
		}

		[Address(RVA="0x14B7884", Offset="0x14B7884", VA="0x14B7884")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B08C", Offset="0x107B08C")]
		public UpdateClubResponse(UpdateClubResponse other)
		{
		}

		[Address(RVA="0x14B7A98", Offset="0x14B7A98", VA="0x14B7A98", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B0FC", Offset="0x107B0FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B78C8", Offset="0x14B78C8", VA="0x14B78C8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B09C", Offset="0x107B09C")]
		public UpdateClubResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x14B7928", Offset="0x14B7928", VA="0x14B7928", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B0AC", Offset="0x107B0AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B79C0", Offset="0x14B79C0", VA="0x14B79C0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B0BC", Offset="0x107B0BC")]
		public bool Equals(UpdateClubResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x14B79EC", Offset="0x14B79EC", VA="0x14B79EC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B0CC", Offset="0x107B0CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B7AAC", Offset="0x14B7AAC", VA="0x14B7AAC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B10C", Offset="0x107B10C")]
		public void MergeFrom(UpdateClubResponse other)
		{
		}

		[Address(RVA="0x14B7AE0", Offset="0x14B7AE0", VA="0x14B7AE0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B11C", Offset="0x107B11C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B7A1C", Offset="0x14B7A1C", VA="0x14B7A1C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B0DC", Offset="0x107B0DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B7A84", Offset="0x14B7A84", VA="0x14B7A84", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B0EC", Offset="0x107B0EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F748", Offset="0x104F748")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UpdateClubResponse.<>c <>9;

			[Address(RVA="0x14B7C0C", Offset="0x14B7C0C", VA="0x14B7C0C")]
			static <>c()
			{
			}

			[Address(RVA="0x14B7C70", Offset="0x14B7C70", VA="0x14B7C70")]
			public <>c()
			{
			}

			[Address(RVA="0x14B7C78", Offset="0x14B7C78", VA="0x14B7C78")]
			internal UpdateClubResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}