using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubActivitiesResponse : IMessage<ClubActivitiesResponse>, IMessage, IEquatable<ClubActivitiesResponse>, IDeepCloneable<ClubActivitiesResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubActivitiesResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ActivitiesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubActivity> _repeated_activities_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubActivity> activities_;

		[FieldOffset(Offset="0x0")]
		public const int ResetTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong resetTimestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B00", Offset="0x1095B00")]
		public RepeatedField<ClubActivity> Activities
		{
			[Address(RVA="0x1A47C24", Offset="0x1A47C24", VA="0x1A47C24")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095AE0", Offset="0x1095AE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A47968", Offset="0x1A47968", VA="0x1A47968")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095AD0", Offset="0x1095AD0")]
		public static MessageParser<ClubActivitiesResponse> Parser
		{
			[Address(RVA="0x1A47900", Offset="0x1A47900", VA="0x1A47900")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095AF0", Offset="0x1095AF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A47A58", Offset="0x1A47A58", VA="0x1A47A58", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B10", Offset="0x1095B10")]
		public ulong ResetTimestamp
		{
			[Address(RVA="0x1A47C2C", Offset="0x1A47C2C", VA="0x1A47C2C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A47C34", Offset="0x1A47C34", VA="0x1A47C34")]
			set
			{
			}
		}

		[Address(RVA="0x1A48214", Offset="0x1A48214", VA="0x1A48214")]
		static ClubActivitiesResponse()
		{
		}

		[Address(RVA="0x1A47AB4", Offset="0x1A47AB4", VA="0x1A47AB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D17C", Offset="0x107D17C")]
		public ClubActivitiesResponse()
		{
		}

		[Address(RVA="0x1A47B24", Offset="0x1A47B24", VA="0x1A47B24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D18C", Offset="0x107D18C")]
		public ClubActivitiesResponse(ClubActivitiesResponse other)
		{
		}

		[Address(RVA="0x1A47F78", Offset="0x1A47F78", VA="0x1A47F78", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D1FC", Offset="0x107D1FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A47BC4", Offset="0x1A47BC4", VA="0x1A47BC4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D19C", Offset="0x107D19C")]
		public ClubActivitiesResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A47C3C", Offset="0x1A47C3C", VA="0x1A47C3C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D1AC", Offset="0x107D1AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A47CB0", Offset="0x1A47CB0", VA="0x1A47CB0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D1BC", Offset="0x107D1BC")]
		public bool Equals(ClubActivitiesResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A47D70", Offset="0x1A47D70", VA="0x1A47D70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D1CC", Offset="0x107D1CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4806C", Offset="0x1A4806C", VA="0x1A4806C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D20C", Offset="0x107D20C")]
		public void MergeFrom(ClubActivitiesResponse other)
		{
		}

		[Address(RVA="0x1A48108", Offset="0x1A48108", VA="0x1A48108", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D21C", Offset="0x107D21C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A47DF4", Offset="0x1A47DF4", VA="0x1A47DF4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D1DC", Offset="0x107D1DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A47E5C", Offset="0x1A47E5C", VA="0x1A47E5C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D1EC", Offset="0x107D1EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA48", Offset="0x104FA48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubActivitiesResponse.<>c <>9;

			[Address(RVA="0x1A4839C", Offset="0x1A4839C", VA="0x1A4839C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A48400", Offset="0x1A48400", VA="0x1A48400")]
			public <>c()
			{
			}

			[Address(RVA="0x1A48408", Offset="0x1A48408", VA="0x1A48408")]
			internal ClubActivitiesResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}