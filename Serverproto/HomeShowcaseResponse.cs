using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeShowcaseResponse : IMessage<HomeShowcaseResponse>, IMessage, IEquatable<HomeShowcaseResponse>, IDeepCloneable<HomeShowcaseResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeShowcaseResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ShowcasesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<HomeShowcase> _repeated_showcases_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<HomeShowcase> showcases_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F10", Offset="0x1097F10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D5DA4", Offset="0x18D5DA4", VA="0x18D5DA4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F00", Offset="0x1097F00")]
		public static MessageParser<HomeShowcaseResponse> Parser
		{
			[Address(RVA="0x18D5D3C", Offset="0x18D5D3C", VA="0x18D5D3C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F20", Offset="0x1097F20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D5E94", Offset="0x18D5E94", VA="0x18D5E94", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F30", Offset="0x1097F30")]
		public RepeatedField<HomeShowcase> Showcases
		{
			[Address(RVA="0x18D6058", Offset="0x18D6058", VA="0x18D6058")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D6540", Offset="0x18D6540", VA="0x18D6540")]
		static HomeShowcaseResponse()
		{
		}

		[Address(RVA="0x18D5EF0", Offset="0x18D5EF0", VA="0x18D5EF0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080DFC", Offset="0x1080DFC")]
		public HomeShowcaseResponse()
		{
		}

		[Address(RVA="0x18D5F60", Offset="0x18D5F60", VA="0x18D5F60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E0C", Offset="0x1080E0C")]
		public HomeShowcaseResponse(HomeShowcaseResponse other)
		{
		}

		[Address(RVA="0x18D6310", Offset="0x18D6310", VA="0x18D6310", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E7C", Offset="0x1080E7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D5FF8", Offset="0x18D5FF8", VA="0x18D5FF8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E1C", Offset="0x1080E1C")]
		public HomeShowcaseResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18D6060", Offset="0x18D6060", VA="0x18D6060", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E2C", Offset="0x1080E2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D60D4", Offset="0x18D60D4", VA="0x18D60D4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E3C", Offset="0x1080E3C")]
		public bool Equals(HomeShowcaseResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18D6184", Offset="0x18D6184", VA="0x18D6184", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E4C", Offset="0x1080E4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D63CC", Offset="0x18D63CC", VA="0x18D63CC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E8C", Offset="0x1080E8C")]
		public void MergeFrom(HomeShowcaseResponse other)
		{
		}

		[Address(RVA="0x18D645C", Offset="0x18D645C", VA="0x18D645C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E9C", Offset="0x1080E9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D61E4", Offset="0x18D61E4", VA="0x18D61E4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E5C", Offset="0x1080E5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D624C", Offset="0x18D624C", VA="0x18D624C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080E6C", Offset="0x1080E6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FFD8", Offset="0x104FFD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeShowcaseResponse.<>c <>9;

			[Address(RVA="0x18D6660", Offset="0x18D6660", VA="0x18D6660")]
			static <>c()
			{
			}

			[Address(RVA="0x18D66C4", Offset="0x18D66C4", VA="0x18D66C4")]
			public <>c()
			{
			}

			[Address(RVA="0x18D66CC", Offset="0x18D66CC", VA="0x18D66CC")]
			internal HomeShowcaseResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}