using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerAutoWinRequest : IMessage<TowerAutoWinRequest>, IMessage, IEquatable<TowerAutoWinRequest>, IDeepCloneable<TowerAutoWinRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerAutoWinRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private TowerIdentifier id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093070", Offset="0x1093070")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6D46C", Offset="0x1B6D46C", VA="0x1B6D46C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093090", Offset="0x1093090")]
		public TowerIdentifier Id
		{
			[Address(RVA="0x1B6D638", Offset="0x1B6D638", VA="0x1B6D638")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6D6A0", Offset="0x1B6D6A0", VA="0x1B6D6A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093060", Offset="0x1093060")]
		public static MessageParser<TowerAutoWinRequest> Parser
		{
			[Address(RVA="0x1B6D404", Offset="0x1B6D404", VA="0x1B6D404")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093080", Offset="0x1093080")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6D55C", Offset="0x1B6D55C", VA="0x1B6D55C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B6DBB0", Offset="0x1B6DBB0", VA="0x1B6DBB0")]
		static TowerAutoWinRequest()
		{
		}

		[Address(RVA="0x1B6D5B8", Offset="0x1B6D5B8", VA="0x1B6D5B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077FFC", Offset="0x1077FFC")]
		public TowerAutoWinRequest()
		{
		}

		[Address(RVA="0x1B6D5C0", Offset="0x1B6D5C0", VA="0x1B6D5C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107800C", Offset="0x107800C")]
		public TowerAutoWinRequest(TowerAutoWinRequest other)
		{
		}

		[Address(RVA="0x1B6D940", Offset="0x1B6D940", VA="0x1B6D940", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107807C", Offset="0x107807C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6D6A8", Offset="0x1B6D6A8", VA="0x1B6D6A8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107801C", Offset="0x107801C")]
		public TowerAutoWinRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6D708", Offset="0x1B6D708", VA="0x1B6D708", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107802C", Offset="0x107802C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6D77C", Offset="0x1B6D77C", VA="0x1B6D77C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107803C", Offset="0x107803C")]
		public bool Equals(TowerAutoWinRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6D7E0", Offset="0x1B6D7E0", VA="0x1B6D7E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107804C", Offset="0x107804C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6D9D0", Offset="0x1B6D9D0", VA="0x1B6D9D0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107808C", Offset="0x107808C")]
		public void MergeFrom(TowerAutoWinRequest other)
		{
		}

		[Address(RVA="0x1B6DAD4", Offset="0x1B6DAD4", VA="0x1B6DAD4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107809C", Offset="0x107809C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6D838", Offset="0x1B6D838", VA="0x1B6D838", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107805C", Offset="0x107805C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6D8A0", Offset="0x1B6D8A0", VA="0x1B6D8A0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107806C", Offset="0x107806C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F2A8", Offset="0x104F2A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerAutoWinRequest.<>c <>9;

			[Address(RVA="0x1B6DC88", Offset="0x1B6DC88", VA="0x1B6DC88")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6DCEC", Offset="0x1B6DCEC", VA="0x1B6DCEC")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6DCF4", Offset="0x1B6DCF4", VA="0x1B6DCF4")]
			internal TowerAutoWinRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}