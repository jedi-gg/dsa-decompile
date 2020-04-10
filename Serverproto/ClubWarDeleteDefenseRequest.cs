using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarDeleteDefenseRequest : IMessage<ClubWarDeleteDefenseRequest>, IMessage, IEquatable<ClubWarDeleteDefenseRequest>, IDeepCloneable<ClubWarDeleteDefenseRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarDeleteDefenseRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SquadIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string squadId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10960C0", Offset="0x10960C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B222A8", Offset="0x1B222A8", VA="0x1B222A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10960B0", Offset="0x10960B0")]
		public static MessageParser<ClubWarDeleteDefenseRequest> Parser
		{
			[Address(RVA="0x1B22240", Offset="0x1B22240", VA="0x1B22240")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10960D0", Offset="0x10960D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B22398", Offset="0x1B22398", VA="0x1B22398", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10960E0", Offset="0x10960E0")]
		public string SquadId
		{
			[Address(RVA="0x1B2250C", Offset="0x1B2250C", VA="0x1B2250C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B22514", Offset="0x1B22514", VA="0x1B22514")]
			set
			{
			}
		}

		[Address(RVA="0x1B229A4", Offset="0x1B229A4", VA="0x1B229A4")]
		static ClubWarDeleteDefenseRequest()
		{
		}

		[Address(RVA="0x1B223F4", Offset="0x1B223F4", VA="0x1B223F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DDDC", Offset="0x107DDDC")]
		public ClubWarDeleteDefenseRequest()
		{
		}

		[Address(RVA="0x1B2244C", Offset="0x1B2244C", VA="0x1B2244C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DDEC", Offset="0x107DDEC")]
		public ClubWarDeleteDefenseRequest(ClubWarDeleteDefenseRequest other)
		{
		}

		[Address(RVA="0x1B22800", Offset="0x1B22800", VA="0x1B22800", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE5C", Offset="0x107DE5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B224AC", Offset="0x1B224AC", VA="0x1B224AC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DDFC", Offset="0x107DDFC")]
		public ClubWarDeleteDefenseRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B22584", Offset="0x1B22584", VA="0x1B22584", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE0C", Offset="0x107DE0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B225F8", Offset="0x1B225F8", VA="0x1B225F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE1C", Offset="0x107DE1C")]
		public bool Equals(ClubWarDeleteDefenseRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B2265C", Offset="0x1B2265C", VA="0x1B2265C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE2C", Offset="0x107DE2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B228B4", Offset="0x1B228B4", VA="0x1B228B4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE6C", Offset="0x107DE6C")]
		public void MergeFrom(ClubWarDeleteDefenseRequest other)
		{
		}

		[Address(RVA="0x1B22920", Offset="0x1B22920", VA="0x1B22920", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE7C", Offset="0x107DE7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B226E0", Offset="0x1B226E0", VA="0x1B226E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE3C", Offset="0x107DE3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B22748", Offset="0x1B22748", VA="0x1B22748", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DE4C", Offset="0x107DE4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB78", Offset="0x104FB78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarDeleteDefenseRequest.<>c <>9;

			[Address(RVA="0x1B22A7C", Offset="0x1B22A7C", VA="0x1B22A7C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B22AE0", Offset="0x1B22AE0", VA="0x1B22AE0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B22AE8", Offset="0x1B22AE8", VA="0x1B22AE8")]
			internal ClubWarDeleteDefenseRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}