using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarRewardsResponse : IMessage<ClubWarRewardsResponse>, IMessage, IEquatable<ClubWarRewardsResponse>, IDeepCloneable<ClubWarRewardsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarRewardsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubWarRewardsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubWarReward> _repeated_clubWarRewards_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubWarReward> clubWarRewards_;

		[FieldOffset(Offset="0x0")]
		public const int PlaceFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong place_;

		[FieldOffset(Offset="0x0")]
		public const int IsPlayerEligibleFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool isPlayerEligible_;

		[FieldOffset(Offset="0x0")]
		public const int WarTelemetryIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string warTelemetryId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10963A0", Offset="0x10963A0")]
		public RepeatedField<ClubWarReward> ClubWarRewards
		{
			[Address(RVA="0x1EE2D58", Offset="0x1EE2D58", VA="0x1EE2D58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096380", Offset="0x1096380")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE2A7C", Offset="0x1EE2A7C", VA="0x1EE2A7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10963C0", Offset="0x10963C0")]
		public bool IsPlayerEligible
		{
			[Address(RVA="0x1EE2D70", Offset="0x1EE2D70", VA="0x1EE2D70")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EE2D78", Offset="0x1EE2D78", VA="0x1EE2D78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096370", Offset="0x1096370")]
		public static MessageParser<ClubWarRewardsResponse> Parser
		{
			[Address(RVA="0x1EE2A14", Offset="0x1EE2A14", VA="0x1EE2A14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096390", Offset="0x1096390")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE2B6C", Offset="0x1EE2B6C", VA="0x1EE2B6C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10963B0", Offset="0x10963B0")]
		public ulong Place
		{
			[Address(RVA="0x1EE2D60", Offset="0x1EE2D60", VA="0x1EE2D60")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EE2D68", Offset="0x1EE2D68", VA="0x1EE2D68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10963D0", Offset="0x10963D0")]
		public string WarTelemetryId
		{
			[Address(RVA="0x1EE2D84", Offset="0x1EE2D84", VA="0x1EE2D84")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE2D8C", Offset="0x1EE2D8C", VA="0x1EE2D8C")]
			set
			{
			}
		}

		[Address(RVA="0x1EE3644", Offset="0x1EE3644", VA="0x1EE3644")]
		static ClubWarRewardsResponse()
		{
		}

		[Address(RVA="0x1EE2BC8", Offset="0x1EE2BC8", VA="0x1EE2BC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E56C", Offset="0x107E56C")]
		public ClubWarRewardsResponse()
		{
		}

		[Address(RVA="0x1EE2C48", Offset="0x1EE2C48", VA="0x1EE2C48")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E57C", Offset="0x107E57C")]
		public ClubWarRewardsResponse(ClubWarRewardsResponse other)
		{
		}

		[Address(RVA="0x1EE32A4", Offset="0x1EE32A4", VA="0x1EE32A4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E5EC", Offset="0x107E5EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE2CF8", Offset="0x1EE2CF8", VA="0x1EE2CF8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E58C", Offset="0x107E58C")]
		public ClubWarRewardsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE2DFC", Offset="0x1EE2DFC", VA="0x1EE2DFC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E59C", Offset="0x107E59C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE2E70", Offset="0x1EE2E70", VA="0x1EE2E70", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E5AC", Offset="0x107E5AC")]
		public bool Equals(ClubWarRewardsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE2F64", Offset="0x1EE2F64", VA="0x1EE2F64", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E5BC", Offset="0x107E5BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE3400", Offset="0x1EE3400", VA="0x1EE3400", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E5FC", Offset="0x107E5FC")]
		public void MergeFrom(ClubWarRewardsResponse other)
		{
		}

		[Address(RVA="0x1EE34D4", Offset="0x1EE34D4", VA="0x1EE34D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E60C", Offset="0x107E60C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE3054", Offset="0x1EE3054", VA="0x1EE3054", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E5CC", Offset="0x107E5CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE30BC", Offset="0x1EE30BC", VA="0x1EE30BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E5DC", Offset="0x107E5DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC28", Offset="0x104FC28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarRewardsResponse.<>c <>9;

			[Address(RVA="0x1EE3768", Offset="0x1EE3768", VA="0x1EE3768")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE37CC", Offset="0x1EE37CC", VA="0x1EE37CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE37D4", Offset="0x1EE37D4", VA="0x1EE37D4")]
			internal ClubWarRewardsResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}