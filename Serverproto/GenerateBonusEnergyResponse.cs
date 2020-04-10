using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GenerateBonusEnergyResponse : IMessage<GenerateBonusEnergyResponse>, IMessage, IEquatable<GenerateBonusEnergyResponse>, IDeepCloneable<GenerateBonusEnergyResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GenerateBonusEnergyResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BonusGenerateEndTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong bonusGenerateEndTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ValidatedFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool validated_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B290", Offset="0x109B290")]
		public ulong BonusGenerateEndTimestamp
		{
			[Address(RVA="0x1BA55B4", Offset="0x1BA55B4", VA="0x1BA55B4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BA55BC", Offset="0x1BA55BC", VA="0x1BA55BC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B270", Offset="0x109B270")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA5380", Offset="0x1BA5380", VA="0x1BA5380")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B260", Offset="0x109B260")]
		public static MessageParser<GenerateBonusEnergyResponse> Parser
		{
			[Address(RVA="0x1BA5318", Offset="0x1BA5318", VA="0x1BA5318")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B280", Offset="0x109B280")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA5470", Offset="0x1BA5470", VA="0x1BA5470", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B2A0", Offset="0x109B2A0")]
		public bool Validated
		{
			[Address(RVA="0x1BA55C4", Offset="0x1BA55C4", VA="0x1BA55C4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BA55CC", Offset="0x1BA55CC", VA="0x1BA55CC")]
			set
			{
			}
		}

		[Address(RVA="0x1BA5A34", Offset="0x1BA5A34", VA="0x1BA5A34")]
		static GenerateBonusEnergyResponse()
		{
		}

		[Address(RVA="0x1BA54CC", Offset="0x1BA54CC", VA="0x1BA54CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108684C", Offset="0x108684C")]
		public GenerateBonusEnergyResponse()
		{
		}

		[Address(RVA="0x1BA54D4", Offset="0x1BA54D4", VA="0x1BA54D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108685C", Offset="0x108685C")]
		public GenerateBonusEnergyResponse(GenerateBonusEnergyResponse other)
		{
		}

		[Address(RVA="0x1BA5898", Offset="0x1BA5898", VA="0x1BA5898", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10868CC", Offset="0x10868CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA5554", Offset="0x1BA5554", VA="0x1BA5554", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108686C", Offset="0x108686C")]
		public GenerateBonusEnergyResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA55D8", Offset="0x1BA55D8", VA="0x1BA55D8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108687C", Offset="0x108687C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA564C", Offset="0x1BA564C", VA="0x1BA564C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108688C", Offset="0x108688C")]
		public bool Equals(GenerateBonusEnergyResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA56A8", Offset="0x1BA56A8", VA="0x1BA56A8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108689C", Offset="0x108689C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA5940", Offset="0x1BA5940", VA="0x1BA5940", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10868DC", Offset="0x10868DC")]
		public void MergeFrom(GenerateBonusEnergyResponse other)
		{
		}

		[Address(RVA="0x1BA598C", Offset="0x1BA598C", VA="0x1BA598C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10868EC", Offset="0x10868EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA5734", Offset="0x1BA5734", VA="0x1BA5734", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10868AC", Offset="0x10868AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA579C", Offset="0x1BA579C", VA="0x1BA579C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10868BC", Offset="0x10868BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050808", Offset="0x1050808")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GenerateBonusEnergyResponse.<>c <>9;

			[Address(RVA="0x1BA5B0C", Offset="0x1BA5B0C", VA="0x1BA5B0C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA5B70", Offset="0x1BA5B70", VA="0x1BA5B70")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA5B78", Offset="0x1BA5B78", VA="0x1BA5B78")]
			internal GenerateBonusEnergyResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}