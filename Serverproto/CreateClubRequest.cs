using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CreateClubRequest : IMessage<CreateClubRequest>, IMessage, IEquatable<CreateClubRequest>, IDeepCloneable<CreateClubRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CreateClubRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int SettingsFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubSettings settings_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C10", Offset="0x1094C10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF4080", Offset="0x1EF4080", VA="0x1EF4080")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C30", Offset="0x1094C30")]
		public string Name
		{
			[Address(RVA="0x1EF4308", Offset="0x1EF4308", VA="0x1EF4308")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF4310", Offset="0x1EF4310", VA="0x1EF4310")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C00", Offset="0x1094C00")]
		public static MessageParser<CreateClubRequest> Parser
		{
			[Address(RVA="0x1EF4018", Offset="0x1EF4018", VA="0x1EF4018")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C20", Offset="0x1094C20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF4170", Offset="0x1EF4170", VA="0x1EF4170", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C40", Offset="0x1094C40")]
		public ClubSettings Settings
		{
			[Address(RVA="0x1EF4298", Offset="0x1EF4298", VA="0x1EF4298")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF42A0", Offset="0x1EF42A0", VA="0x1EF42A0")]
			set
			{
			}
		}

		[Address(RVA="0x1EF4964", Offset="0x1EF4964", VA="0x1EF4964")]
		static CreateClubRequest()
		{
		}

		[Address(RVA="0x1EF41CC", Offset="0x1EF41CC", VA="0x1EF41CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD0C", Offset="0x107AD0C")]
		public CreateClubRequest()
		{
		}

		[Address(RVA="0x1EF4224", Offset="0x1EF4224", VA="0x1EF4224")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD1C", Offset="0x107AD1C")]
		public CreateClubRequest(CreateClubRequest other)
		{
		}

		[Address(RVA="0x1EF4680", Offset="0x1EF4680", VA="0x1EF4680", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD8C", Offset="0x107AD8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF42A8", Offset="0x1EF42A8", VA="0x1EF42A8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD2C", Offset="0x107AD2C")]
		public CreateClubRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF4380", Offset="0x1EF4380", VA="0x1EF4380", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD3C", Offset="0x107AD3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF43F4", Offset="0x1EF43F4", VA="0x1EF43F4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD4C", Offset="0x107AD4C")]
		public bool Equals(CreateClubRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF446C", Offset="0x1EF446C", VA="0x1EF446C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD5C", Offset="0x107AD5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF4778", Offset="0x1EF4778", VA="0x1EF4778", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD9C", Offset="0x107AD9C")]
		public void MergeFrom(CreateClubRequest other)
		{
		}

		[Address(RVA="0x1EF4858", Offset="0x1EF4858", VA="0x1EF4858", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ADAC", Offset="0x107ADAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF4508", Offset="0x1EF4508", VA="0x1EF4508", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD6C", Offset="0x107AD6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF4570", Offset="0x1EF4570", VA="0x1EF4570", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AD7C", Offset="0x107AD7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F6F8", Offset="0x104F6F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CreateClubRequest.<>c <>9;

			[Address(RVA="0x1EF4A3C", Offset="0x1EF4A3C", VA="0x1EF4A3C")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF4AA0", Offset="0x1EF4AA0", VA="0x1EF4AA0")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF4AA8", Offset="0x1EF4AA8", VA="0x1EF4AA8")]
			internal CreateClubRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}