using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MetadataResponse : IMessage<MetadataResponse>, IMessage, IEquatable<MetadataResponse>, IDeepCloneable<MetadataResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MetadataResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BundleVersionFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string bundleVersion_;

		[FieldOffset(Offset="0x0")]
		public const int GamedataVersionFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string gamedataVersion_;

		[FieldOffset(Offset="0x0")]
		public const int CdnBaseUrlFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string cdnBaseUrl_;

		[FieldOffset(Offset="0x0")]
		public const int LocVersionFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string locVersion_;

		[FieldOffset(Offset="0x0")]
		public const int LocCdnBaseUrlFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string locCdnBaseUrl_;

		[FieldOffset(Offset="0x0")]
		public const int AssetCdnBaseUrlFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string assetCdnBaseUrl_;

		[FieldOffset(Offset="0x0")]
		public const int GraphicsSettingFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private DeviceGraphicsSetting graphicsSetting_;

		[FieldOffset(Offset="0x0")]
		public const int MaxGraphicsSettingFieldNumber = 8;

		[FieldOffset(Offset="0x4C")]
		private DeviceGraphicsSetting maxGraphicsSetting_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A70", Offset="0x1091A70")]
		public string AssetCdnBaseUrl
		{
			[Address(RVA="0x1A20A04", Offset="0x1A20A04", VA="0x1A20A04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A20A0C", Offset="0x1A20A0C", VA="0x1A20A0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A20", Offset="0x1091A20")]
		public string BundleVersion
		{
			[Address(RVA="0x1A207AC", Offset="0x1A207AC", VA="0x1A207AC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A207B4", Offset="0x1A207B4", VA="0x1A207B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A40", Offset="0x1091A40")]
		public string CdnBaseUrl
		{
			[Address(RVA="0x1A2089C", Offset="0x1A2089C", VA="0x1A2089C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A208A4", Offset="0x1A208A4", VA="0x1A208A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A00", Offset="0x1091A00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A2047C", Offset="0x1A2047C", VA="0x1A2047C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A30", Offset="0x1091A30")]
		public string GamedataVersion
		{
			[Address(RVA="0x1A20824", Offset="0x1A20824", VA="0x1A20824")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2082C", Offset="0x1A2082C", VA="0x1A2082C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A80", Offset="0x1091A80")]
		public DeviceGraphicsSetting GraphicsSetting
		{
			[Address(RVA="0x1A20A7C", Offset="0x1A20A7C", VA="0x1A20A7C")]
			get
			{
				return new DeviceGraphicsSetting();
			}
			[Address(RVA="0x1A20A84", Offset="0x1A20A84", VA="0x1A20A84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A60", Offset="0x1091A60")]
		public string LocCdnBaseUrl
		{
			[Address(RVA="0x1A2098C", Offset="0x1A2098C", VA="0x1A2098C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A20994", Offset="0x1A20994", VA="0x1A20994")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A50", Offset="0x1091A50")]
		public string LocVersion
		{
			[Address(RVA="0x1A20914", Offset="0x1A20914", VA="0x1A20914")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2091C", Offset="0x1A2091C", VA="0x1A2091C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A90", Offset="0x1091A90")]
		public DeviceGraphicsSetting MaxGraphicsSetting
		{
			[Address(RVA="0x1A20A8C", Offset="0x1A20A8C", VA="0x1A20A8C")]
			get
			{
				return new DeviceGraphicsSetting();
			}
			[Address(RVA="0x1A20A94", Offset="0x1A20A94", VA="0x1A20A94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10919F0", Offset="0x10919F0")]
		public static MessageParser<MetadataResponse> Parser
		{
			[Address(RVA="0x1A20414", Offset="0x1A20414", VA="0x1A20414")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091A10", Offset="0x1091A10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A2056C", Offset="0x1A2056C", VA="0x1A2056C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A2183C", Offset="0x1A2183C", VA="0x1A2183C")]
		static MetadataResponse()
		{
		}

		[Address(RVA="0x1A205C8", Offset="0x1A205C8", VA="0x1A205C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107581C", Offset="0x107581C")]
		public MetadataResponse()
		{
		}

		[Address(RVA="0x1A20628", Offset="0x1A20628", VA="0x1A20628")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107582C", Offset="0x107582C")]
		public MetadataResponse(MetadataResponse other)
		{
		}

		[Address(RVA="0x1A21214", Offset="0x1A21214", VA="0x1A21214", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107589C", Offset="0x107589C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A2074C", Offset="0x1A2074C", VA="0x1A2074C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107583C", Offset="0x107583C")]
		public MetadataResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A20A9C", Offset="0x1A20A9C", VA="0x1A20A9C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107584C", Offset="0x107584C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A20B10", Offset="0x1A20B10", VA="0x1A20B10", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107585C", Offset="0x107585C")]
		public bool Equals(MetadataResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A20BF8", Offset="0x1A20BF8", VA="0x1A20BF8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107586C", Offset="0x107586C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A21500", Offset="0x1A21500", VA="0x1A21500", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10758AC", Offset="0x10758AC")]
		public void MergeFrom(MetadataResponse other)
		{
		}

		[Address(RVA="0x1A21660", Offset="0x1A21660", VA="0x1A21660", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10758BC", Offset="0x10758BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A20E14", Offset="0x1A20E14", VA="0x1A20E14", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107587C", Offset="0x107587C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A20E7C", Offset="0x1A20E7C", VA="0x1A20E7C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107588C", Offset="0x107588C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF08", Offset="0x104EF08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MetadataResponse.<>c <>9;

			[Address(RVA="0x1A21914", Offset="0x1A21914", VA="0x1A21914")]
			static <>c()
			{
			}

			[Address(RVA="0x1A21978", Offset="0x1A21978", VA="0x1A21978")]
			public <>c()
			{
			}

			[Address(RVA="0x1A21980", Offset="0x1A21980", VA="0x1A21980")]
			internal MetadataResponse <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}