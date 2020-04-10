using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DisabledFeatureUpdated : IMessage<DisabledFeatureUpdated>, IMessage, IEquatable<DisabledFeatureUpdated>, IDeepCloneable<DisabledFeatureUpdated>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DisabledFeatureUpdated> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UpdatedFeaturesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<DisabledFeatureUpdatedEntry> _repeated_updatedFeatures_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<DisabledFeatureUpdatedEntry> updatedFeatures_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC60", Offset="0x109BC60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBA8CC", Offset="0x1FBA8CC", VA="0x1FBA8CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC50", Offset="0x109BC50")]
		public static MessageParser<DisabledFeatureUpdated> Parser
		{
			[Address(RVA="0x1FBA864", Offset="0x1FBA864", VA="0x1FBA864")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC70", Offset="0x109BC70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBA9BC", Offset="0x1FBA9BC", VA="0x1FBA9BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC80", Offset="0x109BC80")]
		public RepeatedField<DisabledFeatureUpdatedEntry> UpdatedFeatures
		{
			[Address(RVA="0x1FBAB80", Offset="0x1FBAB80", VA="0x1FBAB80")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FBB068", Offset="0x1FBB068", VA="0x1FBB068")]
		static DisabledFeatureUpdated()
		{
		}

		[Address(RVA="0x1FBAA18", Offset="0x1FBAA18", VA="0x1FBAA18")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C3C", Offset="0x1087C3C")]
		public DisabledFeatureUpdated()
		{
		}

		[Address(RVA="0x1FBAA88", Offset="0x1FBAA88", VA="0x1FBAA88")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C4C", Offset="0x1087C4C")]
		public DisabledFeatureUpdated(DisabledFeatureUpdated other)
		{
		}

		[Address(RVA="0x1FBAE38", Offset="0x1FBAE38", VA="0x1FBAE38", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087CBC", Offset="0x1087CBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBAB20", Offset="0x1FBAB20", VA="0x1FBAB20", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C5C", Offset="0x1087C5C")]
		public DisabledFeatureUpdated Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBAB88", Offset="0x1FBAB88", VA="0x1FBAB88", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C6C", Offset="0x1087C6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBABFC", Offset="0x1FBABFC", VA="0x1FBABFC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C7C", Offset="0x1087C7C")]
		public bool Equals(DisabledFeatureUpdated other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBACAC", Offset="0x1FBACAC", VA="0x1FBACAC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C8C", Offset="0x1087C8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBAEF4", Offset="0x1FBAEF4", VA="0x1FBAEF4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087CCC", Offset="0x1087CCC")]
		public void MergeFrom(DisabledFeatureUpdated other)
		{
		}

		[Address(RVA="0x1FBAF84", Offset="0x1FBAF84", VA="0x1FBAF84", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087CDC", Offset="0x1087CDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBAD0C", Offset="0x1FBAD0C", VA="0x1FBAD0C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C9C", Offset="0x1087C9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBAD74", Offset="0x1FBAD74", VA="0x1FBAD74", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087CAC", Offset="0x1087CAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10509D8", Offset="0x10509D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DisabledFeatureUpdated.<>c <>9;

			[Address(RVA="0x1FBB1F0", Offset="0x1FBB1F0", VA="0x1FBB1F0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBB254", Offset="0x1FBB254", VA="0x1FBB254")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBB25C", Offset="0x1FBB25C", VA="0x1FBB25C")]
			internal DisabledFeatureUpdated <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}