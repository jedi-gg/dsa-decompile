using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarRewardsRequest : IMessage<ClubWarRewardsRequest>, IMessage, IEquatable<ClubWarRewardsRequest>, IDeepCloneable<ClubWarRewardsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarRewardsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096350", Offset="0x1096350")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE2470", Offset="0x1EE2470", VA="0x1EE2470")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096340", Offset="0x1096340")]
		public static MessageParser<ClubWarRewardsRequest> Parser
		{
			[Address(RVA="0x1EE2408", Offset="0x1EE2408", VA="0x1EE2408")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096360", Offset="0x1096360")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE2560", Offset="0x1EE2560", VA="0x1EE2560", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE2874", Offset="0x1EE2874", VA="0x1EE2874")]
		static ClubWarRewardsRequest()
		{
		}

		[Address(RVA="0x1EE25BC", Offset="0x1EE25BC", VA="0x1EE25BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E4BC", Offset="0x107E4BC")]
		public ClubWarRewardsRequest()
		{
		}

		[Address(RVA="0x1EE25C4", Offset="0x1EE25C4", VA="0x1EE25C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E4CC", Offset="0x107E4CC")]
		public ClubWarRewardsRequest(ClubWarRewardsRequest other)
		{
		}

		[Address(RVA="0x1EE27D8", Offset="0x1EE27D8", VA="0x1EE27D8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E53C", Offset="0x107E53C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE2608", Offset="0x1EE2608", VA="0x1EE2608", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E4DC", Offset="0x107E4DC")]
		public ClubWarRewardsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE2668", Offset="0x1EE2668", VA="0x1EE2668", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E4EC", Offset="0x107E4EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE2700", Offset="0x1EE2700", VA="0x1EE2700", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E4FC", Offset="0x107E4FC")]
		public bool Equals(ClubWarRewardsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE272C", Offset="0x1EE272C", VA="0x1EE272C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E50C", Offset="0x107E50C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE27EC", Offset="0x1EE27EC", VA="0x1EE27EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E54C", Offset="0x107E54C")]
		public void MergeFrom(ClubWarRewardsRequest other)
		{
		}

		[Address(RVA="0x1EE2820", Offset="0x1EE2820", VA="0x1EE2820", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E55C", Offset="0x107E55C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE275C", Offset="0x1EE275C", VA="0x1EE275C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E51C", Offset="0x107E51C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE27C4", Offset="0x1EE27C4", VA="0x1EE27C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E52C", Offset="0x107E52C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC18", Offset="0x104FC18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarRewardsRequest.<>c <>9;

			[Address(RVA="0x1EE294C", Offset="0x1EE294C", VA="0x1EE294C")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE29B0", Offset="0x1EE29B0", VA="0x1EE29B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE29B8", Offset="0x1EE29B8", VA="0x1EE29B8")]
			internal ClubWarRewardsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}