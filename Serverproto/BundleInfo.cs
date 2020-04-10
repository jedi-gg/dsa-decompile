using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BundleInfo : IMessage<BundleInfo>, IMessage, IEquatable<BundleInfo>, IDeepCloneable<BundleInfo>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BundleInfo> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BundleNameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string bundleName_;

		[FieldOffset(Offset="0x0")]
		public const int DownloadSizeByteFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong downloadSizeByte_;

		[FieldOffset(Offset="0x0")]
		public const int DownloadOrderFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private int downloadOrder_;

		[FieldOffset(Offset="0x0")]
		public const int CrcFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong crc_;

		[FieldOffset(Offset="0x0")]
		public const int TutorialAssetFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private bool tutorialAsset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091BA0", Offset="0x1091BA0")]
		public string BundleName
		{
			[Address(RVA="0x1DDA928", Offset="0x1DDA928", VA="0x1DDA928")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DDA930", Offset="0x1DDA930", VA="0x1DDA930")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091BD0", Offset="0x1091BD0")]
		public ulong Crc
		{
			[Address(RVA="0x1DDA9C0", Offset="0x1DDA9C0", VA="0x1DDA9C0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DDA9C8", Offset="0x1DDA9C8", VA="0x1DDA9C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B80", Offset="0x1091B80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DDA654", Offset="0x1DDA654", VA="0x1DDA654")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091BC0", Offset="0x1091BC0")]
		public int DownloadOrder
		{
			[Address(RVA="0x1DDA9B0", Offset="0x1DDA9B0", VA="0x1DDA9B0")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1DDA9B8", Offset="0x1DDA9B8", VA="0x1DDA9B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091BB0", Offset="0x1091BB0")]
		public ulong DownloadSizeByte
		{
			[Address(RVA="0x1DDA9A0", Offset="0x1DDA9A0", VA="0x1DDA9A0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DDA9A8", Offset="0x1DDA9A8", VA="0x1DDA9A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B70", Offset="0x1091B70")]
		public static MessageParser<BundleInfo> Parser
		{
			[Address(RVA="0x1DDA5EC", Offset="0x1DDA5EC", VA="0x1DDA5EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B90", Offset="0x1091B90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DDA744", Offset="0x1DDA744", VA="0x1DDA744", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091BE0", Offset="0x1091BE0")]
		public bool TutorialAsset
		{
			[Address(RVA="0x1DDA9D0", Offset="0x1DDA9D0", VA="0x1DDA9D0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1DDA9D8", Offset="0x1DDA9D8", VA="0x1DDA9D8")]
			set
			{
			}
		}

		[Address(RVA="0x1DDB1E8", Offset="0x1DDB1E8", VA="0x1DDB1E8")]
		static BundleInfo()
		{
		}

		[Address(RVA="0x1DDA7A0", Offset="0x1DDA7A0", VA="0x1DDA7A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075ADC", Offset="0x1075ADC")]
		public BundleInfo()
		{
		}

		[Address(RVA="0x1DDA7F8", Offset="0x1DDA7F8", VA="0x1DDA7F8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075AEC", Offset="0x1075AEC")]
		public BundleInfo(BundleInfo other)
		{
		}

		[Address(RVA="0x1DDAE9C", Offset="0x1DDAE9C", VA="0x1DDAE9C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B5C", Offset="0x1075B5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DDA8C8", Offset="0x1DDA8C8", VA="0x1DDA8C8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075AFC", Offset="0x1075AFC")]
		public BundleInfo Clone()
		{
			return null;
		}

		[Address(RVA="0x1DDA9E4", Offset="0x1DDA9E4", VA="0x1DDA9E4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B0C", Offset="0x1075B0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDAA58", Offset="0x1DDAA58", VA="0x1DDAA58", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B1C", Offset="0x1075B1C")]
		public bool Equals(BundleInfo other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDAB0C", Offset="0x1DDAB0C", VA="0x1DDAB0C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B2C", Offset="0x1075B2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DDB01C", Offset="0x1DDB01C", VA="0x1DDB01C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B6C", Offset="0x1075B6C")]
		public void MergeFrom(BundleInfo other)
		{
		}

		[Address(RVA="0x1DDB0B8", Offset="0x1DDB0B8", VA="0x1DDB0B8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B7C", Offset="0x1075B7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DDAC18", Offset="0x1DDAC18", VA="0x1DDAC18", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B3C", Offset="0x1075B3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DDAC80", Offset="0x1DDAC80", VA="0x1DDAC80", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B4C", Offset="0x1075B4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF48", Offset="0x104EF48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BundleInfo.<>c <>9;

			[Address(RVA="0x1DDB2C0", Offset="0x1DDB2C0", VA="0x1DDB2C0")]
			static <>c()
			{
			}

			[Address(RVA="0x1DDB324", Offset="0x1DDB324", VA="0x1DDB324")]
			public <>c()
			{
			}

			[Address(RVA="0x1DDB32C", Offset="0x1DDB32C", VA="0x1DDB32C")]
			internal BundleInfo <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}