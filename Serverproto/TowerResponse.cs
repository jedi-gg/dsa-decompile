using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerResponse : IMessage<TowerResponse>, IMessage, IEquatable<TowerResponse>, IDeepCloneable<TowerResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TowerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Tower tower_;

		[FieldOffset(Offset="0x0")]
		public const int TowersFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Serverproto.Tower> _repeated_towers_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<Serverproto.Tower> towers_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CEA8", Offset="0x109CEA8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B768BC", Offset="0x1B768BC", VA="0x1B768BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE98", Offset="0x109CE98")]
		public static MessageParser<TowerResponse> Parser
		{
			[Address(RVA="0x1B761E4", Offset="0x1B761E4", VA="0x1B761E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CEB8", Offset="0x109CEB8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B769A8", Offset="0x1B769A8", VA="0x1B769A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CEC8", Offset="0x109CEC8")]
		public Serverproto.Tower Tower
		{
			[Address(RVA="0x1B76B38", Offset="0x1B76B38", VA="0x1B76B38")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B76B40", Offset="0x1B76B40", VA="0x1B76B40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CED8", Offset="0x109CED8")]
		public RepeatedField<Serverproto.Tower> Towers
		{
			[Address(RVA="0x1B76BA8", Offset="0x1B76BA8", VA="0x1B76BA8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B77204", Offset="0x1B77204", VA="0x1B77204")]
		static TowerResponse()
		{
		}

		[Address(RVA="0x1B76A04", Offset="0x1B76A04", VA="0x1B76A04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10897BC", Offset="0x10897BC")]
		public TowerResponse()
		{
		}

		[Address(RVA="0x1B76A74", Offset="0x1B76A74", VA="0x1B76A74")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10897CC", Offset="0x10897CC")]
		public TowerResponse(TowerResponse other)
		{
		}

		[Address(RVA="0x1B76EF4", Offset="0x1B76EF4", VA="0x1B76EF4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108983C", Offset="0x108983C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B76B48", Offset="0x1B76B48", VA="0x1B76B48", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10897DC", Offset="0x10897DC")]
		public TowerResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B76BB0", Offset="0x1B76BB0", VA="0x1B76BB0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10897EC", Offset="0x10897EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B76C24", Offset="0x1B76C24", VA="0x1B76C24", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10897FC", Offset="0x10897FC")]
		public bool Equals(TowerResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B76CE8", Offset="0x1B76CE8", VA="0x1B76CE8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108980C", Offset="0x108980C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B76FF0", Offset="0x1B76FF0", VA="0x1B76FF0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108984C", Offset="0x108984C")]
		public void MergeFrom(TowerResponse other)
		{
		}

		[Address(RVA="0x1B770C8", Offset="0x1B770C8", VA="0x1B770C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108985C", Offset="0x108985C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B76D70", Offset="0x1B76D70", VA="0x1B76D70", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108981C", Offset="0x108981C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B76DD8", Offset="0x1B76DD8", VA="0x1B76DD8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108982C", Offset="0x108982C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C68", Offset="0x1050C68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerResponse.<>c <>9;

			[Address(RVA="0x1B77324", Offset="0x1B77324", VA="0x1B77324")]
			static <>c()
			{
			}

			[Address(RVA="0x1B77388", Offset="0x1B77388", VA="0x1B77388")]
			public <>c()
			{
			}

			[Address(RVA="0x1B77390", Offset="0x1B77390", VA="0x1B77390")]
			internal TowerResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}