using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AssetBundleMetadata : IMessage<AssetBundleMetadata>, IMessage, IEquatable<AssetBundleMetadata>, IDeepCloneable<AssetBundleMetadata>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AssetBundleMetadata> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BundleInfoFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Serverproto.BundleInfo> _repeated_bundleInfo_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Serverproto.BundleInfo> bundleInfo_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B60", Offset="0x1091B60")]
		public RepeatedField<Serverproto.BundleInfo> BundleInfo
		{
			[Address(RVA="0x160C9F8", Offset="0x160C9F8", VA="0x160C9F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B40", Offset="0x1091B40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x160C744", Offset="0x160C744", VA="0x160C744")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B30", Offset="0x1091B30")]
		public static MessageParser<AssetBundleMetadata> Parser
		{
			[Address(RVA="0x160C6DC", Offset="0x160C6DC", VA="0x160C6DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B50", Offset="0x1091B50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x160C834", Offset="0x160C834", VA="0x160C834", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x160CEE0", Offset="0x160CEE0", VA="0x160CEE0")]
		static AssetBundleMetadata()
		{
		}

		[Address(RVA="0x160C890", Offset="0x160C890", VA="0x160C890")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A2C", Offset="0x1075A2C")]
		public AssetBundleMetadata()
		{
		}

		[Address(RVA="0x160C900", Offset="0x160C900", VA="0x160C900")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A3C", Offset="0x1075A3C")]
		public AssetBundleMetadata(AssetBundleMetadata other)
		{
		}

		[Address(RVA="0x160CCB0", Offset="0x160CCB0", VA="0x160CCB0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075AAC", Offset="0x1075AAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160C998", Offset="0x160C998", VA="0x160C998", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A4C", Offset="0x1075A4C")]
		public AssetBundleMetadata Clone()
		{
			return null;
		}

		[Address(RVA="0x160CA00", Offset="0x160CA00", VA="0x160CA00", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A5C", Offset="0x1075A5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160CA74", Offset="0x160CA74", VA="0x160CA74", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A6C", Offset="0x1075A6C")]
		public bool Equals(AssetBundleMetadata other)
		{
			return new bool();
		}

		[Address(RVA="0x160CB24", Offset="0x160CB24", VA="0x160CB24", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A7C", Offset="0x1075A7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x160CD6C", Offset="0x160CD6C", VA="0x160CD6C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075ABC", Offset="0x1075ABC")]
		public void MergeFrom(AssetBundleMetadata other)
		{
		}

		[Address(RVA="0x160CDFC", Offset="0x160CDFC", VA="0x160CDFC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075ACC", Offset="0x1075ACC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160CB84", Offset="0x160CB84", VA="0x160CB84", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A8C", Offset="0x1075A8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160CBEC", Offset="0x160CBEC", VA="0x160CBEC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A9C", Offset="0x1075A9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF38", Offset="0x104EF38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AssetBundleMetadata.<>c <>9;

			[Address(RVA="0x160D004", Offset="0x160D004", VA="0x160D004")]
			static <>c()
			{
			}

			[Address(RVA="0x160D068", Offset="0x160D068", VA="0x160D068")]
			public <>c()
			{
			}

			[Address(RVA="0x160D070", Offset="0x160D070", VA="0x160D070")]
			internal AssetBundleMetadata <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}