using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AuthTokenRequest : IMessage<AuthTokenRequest>, IMessage, IEquatable<AuthTokenRequest>, IDeepCloneable<AuthTokenRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AuthTokenRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AuthTypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.AuthType authType_;

		[FieldOffset(Offset="0x0")]
		public const int AnonIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string anonId_;

		[FieldOffset(Offset="0x0")]
		public const int AuthDataGpgsFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private AuthTokenRequestAndroidGpgs authDataGpgs_;

		[FieldOffset(Offset="0x0")]
		public const int AuthDataGameCenterFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private AuthTokenRequestIosGameCenter authDataGameCenter_;

		[FieldOffset(Offset="0x0")]
		public const int TimezoneFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string timezone_;

		[FieldOffset(Offset="0x0")]
		public const int ClientAppVersionFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string clientAppVersion_;

		[FieldOffset(Offset="0x0")]
		public const int PushNotificationProviderFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private Serverproto.PushNotificationProvider pushNotificationProvider_;

		[FieldOffset(Offset="0x0")]
		public const int PushNotificationTokenFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private string pushNotificationToken_;

		[FieldOffset(Offset="0x0")]
		public const int LanguageFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private string language_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10918C0", Offset="0x10918C0")]
		public string AnonId
		{
			[Address(RVA="0x160F12C", Offset="0x160F12C", VA="0x160F12C")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F134", Offset="0x160F134", VA="0x160F134")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10918E0", Offset="0x10918E0")]
		public AuthTokenRequestIosGameCenter AuthDataGameCenter
		{
			[Address(RVA="0x160F04C", Offset="0x160F04C", VA="0x160F04C")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F0B4", Offset="0x160F0B4", VA="0x160F0B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10918D0", Offset="0x10918D0")]
		public AuthTokenRequestAndroidGpgs AuthDataGpgs
		{
			[Address(RVA="0x160EFDC", Offset="0x160EFDC", VA="0x160EFDC")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F044", Offset="0x160F044", VA="0x160F044")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10918B0", Offset="0x10918B0")]
		public Serverproto.AuthType AuthType
		{
			[Address(RVA="0x160F11C", Offset="0x160F11C", VA="0x160F11C")]
			get
			{
				return new Serverproto.AuthType();
			}
			[Address(RVA="0x160F124", Offset="0x160F124", VA="0x160F124")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091900", Offset="0x1091900")]
		public string ClientAppVersion
		{
			[Address(RVA="0x160F21C", Offset="0x160F21C", VA="0x160F21C")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F224", Offset="0x160F224", VA="0x160F224")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091890", Offset="0x1091890")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x160ED70", Offset="0x160ED70", VA="0x160ED70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091930", Offset="0x1091930")]
		public string Language
		{
			[Address(RVA="0x160F31C", Offset="0x160F31C", VA="0x160F31C")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F324", Offset="0x160F324", VA="0x160F324")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091880", Offset="0x1091880")]
		public static MessageParser<AuthTokenRequest> Parser
		{
			[Address(RVA="0x160B2B4", Offset="0x160B2B4", VA="0x160B2B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10918A0", Offset="0x10918A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x160EE5C", Offset="0x160EE5C", VA="0x160EE5C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091910", Offset="0x1091910")]
		public Serverproto.PushNotificationProvider PushNotificationProvider
		{
			[Address(RVA="0x160F294", Offset="0x160F294", VA="0x160F294")]
			get
			{
				return new Serverproto.PushNotificationProvider();
			}
			[Address(RVA="0x160F29C", Offset="0x160F29C", VA="0x160F29C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091920", Offset="0x1091920")]
		public string PushNotificationToken
		{
			[Address(RVA="0x160F2A4", Offset="0x160F2A4", VA="0x160F2A4")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F2AC", Offset="0x160F2AC", VA="0x160F2AC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10918F0", Offset="0x10918F0")]
		public string Timezone
		{
			[Address(RVA="0x160F1A4", Offset="0x160F1A4", VA="0x160F1A4")]
			get
			{
				return null;
			}
			[Address(RVA="0x160F1AC", Offset="0x160F1AC", VA="0x160F1AC")]
			set
			{
			}
		}

		[Address(RVA="0x1610540", Offset="0x1610540", VA="0x1610540")]
		static AuthTokenRequest()
		{
		}

		[Address(RVA="0x160EEB8", Offset="0x160EEB8", VA="0x160EEB8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107560C", Offset="0x107560C")]
		public AuthTokenRequest()
		{
		}

		[Address(RVA="0x160EF18", Offset="0x160EF18", VA="0x160EF18")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107561C", Offset="0x107561C")]
		public AuthTokenRequest(AuthTokenRequest other)
		{
		}

		[Address(RVA="0x160FB4C", Offset="0x160FB4C", VA="0x160FB4C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107568C", Offset="0x107568C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160F0BC", Offset="0x160F0BC", VA="0x160F0BC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107562C", Offset="0x107562C")]
		public AuthTokenRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x160F394", Offset="0x160F394", VA="0x160F394", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107563C", Offset="0x107563C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160F408", Offset="0x160F408", VA="0x160F408", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107564C", Offset="0x107564C")]
		public bool Equals(AuthTokenRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x160F504", Offset="0x160F504", VA="0x160F504", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107565C", Offset="0x107565C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x160FE50", Offset="0x160FE50", VA="0x160FE50", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107569C", Offset="0x107569C")]
		public void MergeFrom(AuthTokenRequest other)
		{
		}

		[Address(RVA="0x16102DC", Offset="0x16102DC", VA="0x16102DC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10756AC", Offset="0x10756AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160F70C", Offset="0x160F70C", VA="0x160F70C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107566C", Offset="0x107566C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160F774", Offset="0x160F774", VA="0x160F774", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107567C", Offset="0x107567C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EED8", Offset="0x104EED8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AuthTokenRequest.<>c <>9;

			[Address(RVA="0x1610618", Offset="0x1610618", VA="0x1610618")]
			static <>c()
			{
			}

			[Address(RVA="0x161067C", Offset="0x161067C", VA="0x161067C")]
			public <>c()
			{
			}

			[Address(RVA="0x1610684", Offset="0x1610684", VA="0x1610684")]
			internal AuthTokenRequest <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}