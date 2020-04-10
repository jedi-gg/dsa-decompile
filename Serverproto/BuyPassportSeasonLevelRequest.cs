using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyPassportSeasonLevelRequest : IMessage<BuyPassportSeasonLevelRequest>, IMessage, IEquatable<BuyPassportSeasonLevelRequest>, IDeepCloneable<BuyPassportSeasonLevelRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyPassportSeasonLevelRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B1C0", Offset="0x109B1C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F84E1C", Offset="0x1F84E1C", VA="0x1F84E1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B1B0", Offset="0x109B1B0")]
		public static MessageParser<BuyPassportSeasonLevelRequest> Parser
		{
			[Address(RVA="0x1F84DB4", Offset="0x1F84DB4", VA="0x1F84DB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B1D0", Offset="0x109B1D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F84F0C", Offset="0x1F84F0C", VA="0x1F84F0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F85220", Offset="0x1F85220", VA="0x1F85220")]
		static BuyPassportSeasonLevelRequest()
		{
		}

		[Address(RVA="0x1F84F68", Offset="0x1F84F68", VA="0x1F84F68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108663C", Offset="0x108663C")]
		public BuyPassportSeasonLevelRequest()
		{
		}

		[Address(RVA="0x1F84F70", Offset="0x1F84F70", VA="0x1F84F70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108664C", Offset="0x108664C")]
		public BuyPassportSeasonLevelRequest(BuyPassportSeasonLevelRequest other)
		{
		}

		[Address(RVA="0x1F85184", Offset="0x1F85184", VA="0x1F85184", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10866BC", Offset="0x10866BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F84FB4", Offset="0x1F84FB4", VA="0x1F84FB4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108665C", Offset="0x108665C")]
		public BuyPassportSeasonLevelRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F85014", Offset="0x1F85014", VA="0x1F85014", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108666C", Offset="0x108666C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F850AC", Offset="0x1F850AC", VA="0x1F850AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108667C", Offset="0x108667C")]
		public bool Equals(BuyPassportSeasonLevelRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F850D8", Offset="0x1F850D8", VA="0x1F850D8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108668C", Offset="0x108668C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F85198", Offset="0x1F85198", VA="0x1F85198", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10866CC", Offset="0x10866CC")]
		public void MergeFrom(BuyPassportSeasonLevelRequest other)
		{
		}

		[Address(RVA="0x1F851CC", Offset="0x1F851CC", VA="0x1F851CC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10866DC", Offset="0x10866DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F85108", Offset="0x1F85108", VA="0x1F85108", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108669C", Offset="0x108669C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F85170", Offset="0x1F85170", VA="0x1F85170", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10866AC", Offset="0x10866AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10507D8", Offset="0x10507D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyPassportSeasonLevelRequest.<>c <>9;

			[Address(RVA="0x1F852F8", Offset="0x1F852F8", VA="0x1F852F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8535C", Offset="0x1F8535C", VA="0x1F8535C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F85364", Offset="0x1F85364", VA="0x1F85364")]
			internal BuyPassportSeasonLevelRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}