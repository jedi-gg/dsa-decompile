using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class LockableFeatureUpdated : IMessage<LockableFeatureUpdated>, IMessage, IEquatable<LockableFeatureUpdated>, IDeepCloneable<LockableFeatureUpdated>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<LockableFeatureUpdated> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UpdatedFeaturesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<LockableFeatureUpdatedEntry> _repeated_updatedFeatures_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<LockableFeatureUpdatedEntry> updatedFeatures_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BBD0", Offset="0x109BBD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A18018", Offset="0x1A18018", VA="0x1A18018")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BBC0", Offset="0x109BBC0")]
		public static MessageParser<LockableFeatureUpdated> Parser
		{
			[Address(RVA="0x1A17FB0", Offset="0x1A17FB0", VA="0x1A17FB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BBE0", Offset="0x109BBE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A18108", Offset="0x1A18108", VA="0x1A18108", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BBF0", Offset="0x109BBF0")]
		public RepeatedField<LockableFeatureUpdatedEntry> UpdatedFeatures
		{
			[Address(RVA="0x1A182CC", Offset="0x1A182CC", VA="0x1A182CC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A187B4", Offset="0x1A187B4", VA="0x1A187B4")]
		static LockableFeatureUpdated()
		{
		}

		[Address(RVA="0x1A18164", Offset="0x1A18164", VA="0x1A18164")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087ADC", Offset="0x1087ADC")]
		public LockableFeatureUpdated()
		{
		}

		[Address(RVA="0x1A181D4", Offset="0x1A181D4", VA="0x1A181D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087AEC", Offset="0x1087AEC")]
		public LockableFeatureUpdated(LockableFeatureUpdated other)
		{
		}

		[Address(RVA="0x1A18584", Offset="0x1A18584", VA="0x1A18584", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B5C", Offset="0x1087B5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1826C", Offset="0x1A1826C", VA="0x1A1826C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087AFC", Offset="0x1087AFC")]
		public LockableFeatureUpdated Clone()
		{
			return null;
		}

		[Address(RVA="0x1A182D4", Offset="0x1A182D4", VA="0x1A182D4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B0C", Offset="0x1087B0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A18348", Offset="0x1A18348", VA="0x1A18348", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B1C", Offset="0x1087B1C")]
		public bool Equals(LockableFeatureUpdated other)
		{
			return new bool();
		}

		[Address(RVA="0x1A183F8", Offset="0x1A183F8", VA="0x1A183F8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B2C", Offset="0x1087B2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A18640", Offset="0x1A18640", VA="0x1A18640", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B6C", Offset="0x1087B6C")]
		public void MergeFrom(LockableFeatureUpdated other)
		{
		}

		[Address(RVA="0x1A186D0", Offset="0x1A186D0", VA="0x1A186D0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B7C", Offset="0x1087B7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A18458", Offset="0x1A18458", VA="0x1A18458", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B3C", Offset="0x1087B3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A184C0", Offset="0x1A184C0", VA="0x1A184C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B4C", Offset="0x1087B4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10509B8", Offset="0x10509B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static LockableFeatureUpdated.<>c <>9;

			[Address(RVA="0x1A1893C", Offset="0x1A1893C", VA="0x1A1893C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A189A0", Offset="0x1A189A0", VA="0x1A189A0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A189A8", Offset="0x1A189A8", VA="0x1A189A8")]
			internal LockableFeatureUpdated <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}