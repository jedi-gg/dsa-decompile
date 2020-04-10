using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothLobbyRequest : IMessage<KothLobbyRequest>, IMessage, IEquatable<KothLobbyRequest>, IDeepCloneable<KothLobbyRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothLobbyRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B2C0", Offset="0x109B2C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9FCBC", Offset="0x1A9FCBC", VA="0x1A9FCBC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B2B0", Offset="0x109B2B0")]
		public static MessageParser<KothLobbyRequest> Parser
		{
			[Address(RVA="0x1A9FC54", Offset="0x1A9FC54", VA="0x1A9FC54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B2D0", Offset="0x109B2D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9FDAC", Offset="0x1A9FDAC", VA="0x1A9FDAC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AA00C0", Offset="0x1AA00C0", VA="0x1AA00C0")]
		static KothLobbyRequest()
		{
		}

		[Address(RVA="0x1A9FE08", Offset="0x1A9FE08", VA="0x1A9FE08")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10868FC", Offset="0x10868FC")]
		public KothLobbyRequest()
		{
		}

		[Address(RVA="0x1A9FE10", Offset="0x1A9FE10", VA="0x1A9FE10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108690C", Offset="0x108690C")]
		public KothLobbyRequest(KothLobbyRequest other)
		{
		}

		[Address(RVA="0x1AA0024", Offset="0x1AA0024", VA="0x1AA0024", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108697C", Offset="0x108697C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9FE54", Offset="0x1A9FE54", VA="0x1A9FE54", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108691C", Offset="0x108691C")]
		public KothLobbyRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9FEB4", Offset="0x1A9FEB4", VA="0x1A9FEB4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108692C", Offset="0x108692C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9FF4C", Offset="0x1A9FF4C", VA="0x1A9FF4C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108693C", Offset="0x108693C")]
		public bool Equals(KothLobbyRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9FF78", Offset="0x1A9FF78", VA="0x1A9FF78", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108694C", Offset="0x108694C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AA0038", Offset="0x1AA0038", VA="0x1AA0038", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108698C", Offset="0x108698C")]
		public void MergeFrom(KothLobbyRequest other)
		{
		}

		[Address(RVA="0x1AA006C", Offset="0x1AA006C", VA="0x1AA006C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108699C", Offset="0x108699C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9FFA8", Offset="0x1A9FFA8", VA="0x1A9FFA8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108695C", Offset="0x108695C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AA0010", Offset="0x1AA0010", VA="0x1AA0010", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108696C", Offset="0x108696C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050818", Offset="0x1050818")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothLobbyRequest.<>c <>9;

			[Address(RVA="0x1AA0198", Offset="0x1AA0198", VA="0x1AA0198")]
			static <>c()
			{
			}

			[Address(RVA="0x1AA01FC", Offset="0x1AA01FC", VA="0x1AA01FC")]
			public <>c()
			{
			}

			[Address(RVA="0x1AA0204", Offset="0x1AA0204", VA="0x1AA0204")]
			internal KothLobbyRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}