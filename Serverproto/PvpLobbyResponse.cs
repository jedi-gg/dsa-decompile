using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpLobbyResponse : IMessage<PvpLobbyResponse>, IMessage, IEquatable<PvpLobbyResponse>, IDeepCloneable<PvpLobbyResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpLobbyResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int LeftBannerAssetFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string leftBannerAsset_;

		[FieldOffset(Offset="0x0")]
		public const int LeftBannerTextFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string leftBannerText_;

		[FieldOffset(Offset="0x0")]
		public const int RightBannerAssetFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string rightBannerAsset_;

		[FieldOffset(Offset="0x0")]
		public const int RightBannerTextFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string rightBannerText_;

		[FieldOffset(Offset="0x0")]
		public const int LobbyAssetFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string lobbyAsset_;

		[FieldOffset(Offset="0x0")]
		public const int PackAssetFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string packAsset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B5A0", Offset="0x109B5A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2018B2C", Offset="0x2018B2C", VA="0x2018B2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B5C0", Offset="0x109B5C0")]
		public string LeftBannerAsset
		{
			[Address(RVA="0x2018E24", Offset="0x2018E24", VA="0x2018E24")]
			get
			{
				return null;
			}
			[Address(RVA="0x2018E2C", Offset="0x2018E2C", VA="0x2018E2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B5D0", Offset="0x109B5D0")]
		public string LeftBannerText
		{
			[Address(RVA="0x2018E9C", Offset="0x2018E9C", VA="0x2018E9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2018EA4", Offset="0x2018EA4", VA="0x2018EA4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B600", Offset="0x109B600")]
		public string LobbyAsset
		{
			[Address(RVA="0x2019004", Offset="0x2019004", VA="0x2019004")]
			get
			{
				return null;
			}
			[Address(RVA="0x201900C", Offset="0x201900C", VA="0x201900C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B610", Offset="0x109B610")]
		public string PackAsset
		{
			[Address(RVA="0x201907C", Offset="0x201907C", VA="0x201907C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2019084", Offset="0x2019084", VA="0x2019084")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B590", Offset="0x109B590")]
		public static MessageParser<PvpLobbyResponse> Parser
		{
			[Address(RVA="0x2018AC4", Offset="0x2018AC4", VA="0x2018AC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B5B0", Offset="0x109B5B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2018C1C", Offset="0x2018C1C", VA="0x2018C1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B5E0", Offset="0x109B5E0")]
		public string RightBannerAsset
		{
			[Address(RVA="0x2018F14", Offset="0x2018F14", VA="0x2018F14")]
			get
			{
				return null;
			}
			[Address(RVA="0x2018F1C", Offset="0x2018F1C", VA="0x2018F1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B5F0", Offset="0x109B5F0")]
		public string RightBannerText
		{
			[Address(RVA="0x2018F8C", Offset="0x2018F8C", VA="0x2018F8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2018F94", Offset="0x2018F94", VA="0x2018F94")]
			set
			{
			}
		}

		[Address(RVA="0x2019C98", Offset="0x2019C98", VA="0x2019C98")]
		static PvpLobbyResponse()
		{
		}

		[Address(RVA="0x2018C78", Offset="0x2018C78", VA="0x2018C78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F2C", Offset="0x1086F2C")]
		public PvpLobbyResponse()
		{
		}

		[Address(RVA="0x2018CD8", Offset="0x2018CD8", VA="0x2018CD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F3C", Offset="0x1086F3C")]
		public PvpLobbyResponse(PvpLobbyResponse other)
		{
		}

		[Address(RVA="0x2019760", Offset="0x2019760", VA="0x2019760", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086FAC", Offset="0x1086FAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2018DC4", Offset="0x2018DC4", VA="0x2018DC4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F4C", Offset="0x1086F4C")]
		public PvpLobbyResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x20190F4", Offset="0x20190F4", VA="0x20190F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F5C", Offset="0x1086F5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2019168", Offset="0x2019168", VA="0x2019168", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F6C", Offset="0x1086F6C")]
		public bool Equals(PvpLobbyResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2019230", Offset="0x2019230", VA="0x2019230", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F7C", Offset="0x1086F7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x20199D4", Offset="0x20199D4", VA="0x20199D4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086FBC", Offset="0x1086FBC")]
		public void MergeFrom(PvpLobbyResponse other)
		{
		}

		[Address(RVA="0x2019B1C", Offset="0x2019B1C", VA="0x2019B1C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086FCC", Offset="0x1086FCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2019410", Offset="0x2019410", VA="0x2019410", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F8C", Offset="0x1086F8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2019478", Offset="0x2019478", VA="0x2019478", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086F9C", Offset="0x1086F9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10508A8", Offset="0x10508A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpLobbyResponse.<>c <>9;

			[Address(RVA="0x2019D70", Offset="0x2019D70", VA="0x2019D70")]
			static <>c()
			{
			}

			[Address(RVA="0x2019DD4", Offset="0x2019DD4", VA="0x2019DD4")]
			public <>c()
			{
			}

			[Address(RVA="0x2019DDC", Offset="0x2019DDC", VA="0x2019DDC")]
			internal PvpLobbyResponse <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}