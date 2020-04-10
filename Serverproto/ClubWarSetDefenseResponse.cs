using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarSetDefenseResponse : IMessage<ClubWarSetDefenseResponse>, IMessage, IEquatable<ClubWarSetDefenseResponse>, IDeepCloneable<ClubWarSetDefenseResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarSetDefenseResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10961B0", Offset="0x10961B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE495C", Offset="0x1EE495C", VA="0x1EE495C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10961A0", Offset="0x10961A0")]
		public static MessageParser<ClubWarSetDefenseResponse> Parser
		{
			[Address(RVA="0x1EE48F4", Offset="0x1EE48F4", VA="0x1EE48F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10961C0", Offset="0x10961C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE4A4C", Offset="0x1EE4A4C", VA="0x1EE4A4C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE4D60", Offset="0x1EE4D60", VA="0x1EE4D60")]
		static ClubWarSetDefenseResponse()
		{
		}

		[Address(RVA="0x1EE4AA8", Offset="0x1EE4AA8", VA="0x1EE4AA8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DFEC", Offset="0x107DFEC")]
		public ClubWarSetDefenseResponse()
		{
		}

		[Address(RVA="0x1EE4AB0", Offset="0x1EE4AB0", VA="0x1EE4AB0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DFFC", Offset="0x107DFFC")]
		public ClubWarSetDefenseResponse(ClubWarSetDefenseResponse other)
		{
		}

		[Address(RVA="0x1EE4CC4", Offset="0x1EE4CC4", VA="0x1EE4CC4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E06C", Offset="0x107E06C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE4AF4", Offset="0x1EE4AF4", VA="0x1EE4AF4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E00C", Offset="0x107E00C")]
		public ClubWarSetDefenseResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE4B54", Offset="0x1EE4B54", VA="0x1EE4B54", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E01C", Offset="0x107E01C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE4BEC", Offset="0x1EE4BEC", VA="0x1EE4BEC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E02C", Offset="0x107E02C")]
		public bool Equals(ClubWarSetDefenseResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE4C18", Offset="0x1EE4C18", VA="0x1EE4C18", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E03C", Offset="0x107E03C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE4CD8", Offset="0x1EE4CD8", VA="0x1EE4CD8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E07C", Offset="0x107E07C")]
		public void MergeFrom(ClubWarSetDefenseResponse other)
		{
		}

		[Address(RVA="0x1EE4D0C", Offset="0x1EE4D0C", VA="0x1EE4D0C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E08C", Offset="0x107E08C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE4C48", Offset="0x1EE4C48", VA="0x1EE4C48", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E04C", Offset="0x107E04C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE4CB0", Offset="0x1EE4CB0", VA="0x1EE4CB0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E05C", Offset="0x107E05C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FBA8", Offset="0x104FBA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarSetDefenseResponse.<>c <>9;

			[Address(RVA="0x1EE4E38", Offset="0x1EE4E38", VA="0x1EE4E38")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE4E9C", Offset="0x1EE4E9C", VA="0x1EE4E9C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE4EA4", Offset="0x1EE4EA4", VA="0x1EE4EA4")]
			internal ClubWarSetDefenseResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}