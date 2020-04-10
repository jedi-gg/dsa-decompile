using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TrainUnitRequest : IMessage<TrainUnitRequest>, IMessage, IEquatable<TrainUnitRequest>, IDeepCloneable<TrainUnitRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TrainUnitRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong level_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098960", Offset="0x1098960")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B79550", Offset="0x1B79550", VA="0x1B79550")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098990", Offset="0x1098990")]
		public ulong Level
		{
			[Address(RVA="0x1B79794", Offset="0x1B79794", VA="0x1B79794")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B7979C", Offset="0x1B7979C", VA="0x1B7979C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098950", Offset="0x1098950")]
		public static MessageParser<TrainUnitRequest> Parser
		{
			[Address(RVA="0x1B794E8", Offset="0x1B794E8", VA="0x1B794E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098970", Offset="0x1098970")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B79640", Offset="0x1B79640", VA="0x1B79640", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098980", Offset="0x1098980")]
		public ulong UnitId
		{
			[Address(RVA="0x1B79784", Offset="0x1B79784", VA="0x1B79784")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B7978C", Offset="0x1B7978C", VA="0x1B7978C")]
			set
			{
			}
		}

		[Address(RVA="0x1B79C0C", Offset="0x1B79C0C", VA="0x1B79C0C")]
		static TrainUnitRequest()
		{
		}

		[Address(RVA="0x1B7969C", Offset="0x1B7969C", VA="0x1B7969C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A5C", Offset="0x1081A5C")]
		public TrainUnitRequest()
		{
		}

		[Address(RVA="0x1B796A4", Offset="0x1B796A4", VA="0x1B796A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A6C", Offset="0x1081A6C")]
		public TrainUnitRequest(TrainUnitRequest other)
		{
		}

		[Address(RVA="0x1B79A48", Offset="0x1B79A48", VA="0x1B79A48", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081ADC", Offset="0x1081ADC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B79724", Offset="0x1B79724", VA="0x1B79724", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A7C", Offset="0x1081A7C")]
		public TrainUnitRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B797A4", Offset="0x1B797A4", VA="0x1B797A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A8C", Offset="0x1081A8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B79818", Offset="0x1B79818", VA="0x1B79818", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A9C", Offset="0x1081A9C")]
		public bool Equals(TrainUnitRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B79864", Offset="0x1B79864", VA="0x1B79864", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081AAC", Offset="0x1081AAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B79B1C", Offset="0x1B79B1C", VA="0x1B79B1C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081AEC", Offset="0x1081AEC")]
		public void MergeFrom(TrainUnitRequest other)
		{
		}

		[Address(RVA="0x1B79B68", Offset="0x1B79B68", VA="0x1B79B68", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081AFC", Offset="0x1081AFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B798E8", Offset="0x1B798E8", VA="0x1B798E8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081ABC", Offset="0x1081ABC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B79950", Offset="0x1B79950", VA="0x1B79950", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081ACC", Offset="0x1081ACC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10500F8", Offset="0x10500F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TrainUnitRequest.<>c <>9;

			[Address(RVA="0x1B79CE4", Offset="0x1B79CE4", VA="0x1B79CE4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B79D48", Offset="0x1B79D48", VA="0x1B79D48")]
			public <>c()
			{
			}

			[Address(RVA="0x1B79D50", Offset="0x1B79D50", VA="0x1B79D50")]
			internal TrainUnitRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}