using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DisabledFeatureUpdatedEntry : IMessage<DisabledFeatureUpdatedEntry>, IMessage, IEquatable<DisabledFeatureUpdatedEntry>, IDeepCloneable<DisabledFeatureUpdatedEntry>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DisabledFeatureUpdatedEntry> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int FeatureIndexFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong featureIndex_;

		[FieldOffset(Offset="0x0")]
		public const int IsDisabledFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool isDisabled_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC10", Offset="0x109BC10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBB2B4", Offset="0x1FBB2B4", VA="0x1FBB2B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC30", Offset="0x109BC30")]
		public ulong FeatureIndex
		{
			[Address(RVA="0x1FBB4E8", Offset="0x1FBB4E8", VA="0x1FBB4E8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FBB4F0", Offset="0x1FBB4F0", VA="0x1FBB4F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC40", Offset="0x109BC40")]
		public bool IsDisabled
		{
			[Address(RVA="0x1FBB4F8", Offset="0x1FBB4F8", VA="0x1FBB4F8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FBB500", Offset="0x1FBB500", VA="0x1FBB500")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC00", Offset="0x109BC00")]
		public static MessageParser<DisabledFeatureUpdatedEntry> Parser
		{
			[Address(RVA="0x1FBB188", Offset="0x1FBB188", VA="0x1FBB188")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC20", Offset="0x109BC20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBB3A4", Offset="0x1FBB3A4", VA="0x1FBB3A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FBB968", Offset="0x1FBB968", VA="0x1FBB968")]
		static DisabledFeatureUpdatedEntry()
		{
		}

		[Address(RVA="0x1FBB400", Offset="0x1FBB400", VA="0x1FBB400")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B8C", Offset="0x1087B8C")]
		public DisabledFeatureUpdatedEntry()
		{
		}

		[Address(RVA="0x1FBB408", Offset="0x1FBB408", VA="0x1FBB408")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087B9C", Offset="0x1087B9C")]
		public DisabledFeatureUpdatedEntry(DisabledFeatureUpdatedEntry other)
		{
		}

		[Address(RVA="0x1FBB7CC", Offset="0x1FBB7CC", VA="0x1FBB7CC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C0C", Offset="0x1087C0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBB488", Offset="0x1FBB488", VA="0x1FBB488", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087BAC", Offset="0x1087BAC")]
		public DisabledFeatureUpdatedEntry Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBB50C", Offset="0x1FBB50C", VA="0x1FBB50C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087BBC", Offset="0x1087BBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBB580", Offset="0x1FBB580", VA="0x1FBB580", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087BCC", Offset="0x1087BCC")]
		public bool Equals(DisabledFeatureUpdatedEntry other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBB5DC", Offset="0x1FBB5DC", VA="0x1FBB5DC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087BDC", Offset="0x1087BDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBB874", Offset="0x1FBB874", VA="0x1FBB874", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C1C", Offset="0x1087C1C")]
		public void MergeFrom(DisabledFeatureUpdatedEntry other)
		{
		}

		[Address(RVA="0x1FBB8C0", Offset="0x1FBB8C0", VA="0x1FBB8C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087C2C", Offset="0x1087C2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBB668", Offset="0x1FBB668", VA="0x1FBB668", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087BEC", Offset="0x1087BEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBB6D0", Offset="0x1FBB6D0", VA="0x1FBB6D0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087BFC", Offset="0x1087BFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10509C8", Offset="0x10509C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DisabledFeatureUpdatedEntry.<>c <>9;

			[Address(RVA="0x1FBBA40", Offset="0x1FBBA40", VA="0x1FBBA40")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBBAA4", Offset="0x1FBBAA4", VA="0x1FBBAA4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBBAAC", Offset="0x1FBBAAC", VA="0x1FBBAAC")]
			internal DisabledFeatureUpdatedEntry <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}