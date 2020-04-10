using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FulfillClubSupportResponse : IMessage<FulfillClubSupportResponse>, IMessage, IEquatable<FulfillClubSupportResponse>, IDeepCloneable<FulfillClubSupportResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FulfillClubSupportResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NextFulfillAvailableTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private long nextFulfillAvailableTimestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10954F0", Offset="0x10954F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA340C", Offset="0x1BA340C", VA="0x1BA340C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095510", Offset="0x1095510")]
		public long NextFulfillAvailableTimestamp
		{
			[Address(RVA="0x1BA3624", Offset="0x1BA3624", VA="0x1BA3624")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1BA362C", Offset="0x1BA362C", VA="0x1BA362C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10954E0", Offset="0x10954E0")]
		public static MessageParser<FulfillClubSupportResponse> Parser
		{
			[Address(RVA="0x1BA33A4", Offset="0x1BA33A4", VA="0x1BA33A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095500", Offset="0x1095500")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA34FC", Offset="0x1BA34FC", VA="0x1BA34FC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA39A0", Offset="0x1BA39A0", VA="0x1BA39A0")]
		static FulfillClubSupportResponse()
		{
		}

		[Address(RVA="0x1BA3558", Offset="0x1BA3558", VA="0x1BA3558")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C3BC", Offset="0x107C3BC")]
		public FulfillClubSupportResponse()
		{
		}

		[Address(RVA="0x1BA3560", Offset="0x1BA3560", VA="0x1BA3560")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C3CC", Offset="0x107C3CC")]
		public FulfillClubSupportResponse(FulfillClubSupportResponse other)
		{
		}

		[Address(RVA="0x1BA3854", Offset="0x1BA3854", VA="0x1BA3854", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C43C", Offset="0x107C43C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA35C4", Offset="0x1BA35C4", VA="0x1BA35C4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C3DC", Offset="0x107C3DC")]
		public FulfillClubSupportResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA3634", Offset="0x1BA3634", VA="0x1BA3634", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C3EC", Offset="0x107C3EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA36A8", Offset="0x1BA36A8", VA="0x1BA36A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C3FC", Offset="0x107C3FC")]
		public bool Equals(FulfillClubSupportResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA36E4", Offset="0x1BA36E4", VA="0x1BA36E4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C40C", Offset="0x107C40C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA38E4", Offset="0x1BA38E4", VA="0x1BA38E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C44C", Offset="0x107C44C")]
		public void MergeFrom(FulfillClubSupportResponse other)
		{
		}

		[Address(RVA="0x1BA3924", Offset="0x1BA3924", VA="0x1BA3924", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C45C", Offset="0x107C45C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA374C", Offset="0x1BA374C", VA="0x1BA374C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C41C", Offset="0x107C41C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA37B4", Offset="0x1BA37B4", VA="0x1BA37B4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C42C", Offset="0x107C42C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F908", Offset="0x104F908")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FulfillClubSupportResponse.<>c <>9;

			[Address(RVA="0x1BA3A78", Offset="0x1BA3A78", VA="0x1BA3A78")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA3ADC", Offset="0x1BA3ADC", VA="0x1BA3ADC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA3AE4", Offset="0x1BA3AE4", VA="0x1BA3AE4")]
			internal FulfillClubSupportResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}