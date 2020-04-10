using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AuthTokenResponse : IMessage<AuthTokenResponse>, IMessage, IEquatable<AuthTokenResponse>, IDeepCloneable<AuthTokenResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AuthTokenResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AuthTokenFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string authToken_;

		[FieldOffset(Offset="0x0")]
		public const int AccountStatusFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private int accountStatus_;

		[FieldOffset(Offset="0x0")]
		public const int BanTimeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong banTime_;

		[FieldOffset(Offset="0x0")]
		public const int PublicIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string publicId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091980", Offset="0x1091980")]
		public int AccountStatus
		{
			[Address(RVA="0x1E6D92C", Offset="0x1E6D92C", VA="0x1E6D92C")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1E6D934", Offset="0x1E6D934", VA="0x1E6D934")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091970", Offset="0x1091970")]
		public string AuthToken
		{
			[Address(RVA="0x1E6D8B4", Offset="0x1E6D8B4", VA="0x1E6D8B4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6D8BC", Offset="0x1E6D8BC", VA="0x1E6D8BC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091990", Offset="0x1091990")]
		public ulong BanTime
		{
			[Address(RVA="0x1E6D93C", Offset="0x1E6D93C", VA="0x1E6D93C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E6D944", Offset="0x1E6D944", VA="0x1E6D944")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091950", Offset="0x1091950")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E6D5F8", Offset="0x1E6D5F8", VA="0x1E6D5F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091940", Offset="0x1091940")]
		public static MessageParser<AuthTokenResponse> Parser
		{
			[Address(RVA="0x1E6D590", Offset="0x1E6D590", VA="0x1E6D590")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091960", Offset="0x1091960")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E6D6E8", Offset="0x1E6D6E8", VA="0x1E6D6E8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10919A0", Offset="0x10919A0")]
		public string PublicId
		{
			[Address(RVA="0x1E6D94C", Offset="0x1E6D94C", VA="0x1E6D94C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6D954", Offset="0x1E6D954", VA="0x1E6D954")]
			set
			{
			}
		}

		[Address(RVA="0x1E6E16C", Offset="0x1E6E16C", VA="0x1E6E16C")]
		static AuthTokenResponse()
		{
		}

		[Address(RVA="0x1E6D744", Offset="0x1E6D744", VA="0x1E6D744")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10756BC", Offset="0x10756BC")]
		public AuthTokenResponse()
		{
		}

		[Address(RVA="0x1E6D7A0", Offset="0x1E6D7A0", VA="0x1E6D7A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10756CC", Offset="0x10756CC")]
		public AuthTokenResponse(AuthTokenResponse other)
		{
		}

		[Address(RVA="0x1E6DE24", Offset="0x1E6DE24", VA="0x1E6DE24", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107573C", Offset="0x107573C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E6D854", Offset="0x1E6D854", VA="0x1E6D854", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10756DC", Offset="0x10756DC")]
		public AuthTokenResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1E6D9C4", Offset="0x1E6D9C4", VA="0x1E6D9C4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10756EC", Offset="0x10756EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E6DA38", Offset="0x1E6DA38", VA="0x1E6DA38", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10756FC", Offset="0x10756FC")]
		public bool Equals(AuthTokenResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1E6DAD0", Offset="0x1E6DAD0", VA="0x1E6DAD0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107570C", Offset="0x107570C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E6DFB0", Offset="0x1E6DFB0", VA="0x1E6DFB0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107574C", Offset="0x107574C")]
		public void MergeFrom(AuthTokenResponse other)
		{
		}

		[Address(RVA="0x1E6E060", Offset="0x1E6E060", VA="0x1E6E060", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107575C", Offset="0x107575C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E6DBE4", Offset="0x1E6DBE4", VA="0x1E6DBE4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107571C", Offset="0x107571C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E6DC4C", Offset="0x1E6DC4C", VA="0x1E6DC4C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107572C", Offset="0x107572C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EEE8", Offset="0x104EEE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AuthTokenResponse.<>c <>9;

			[Address(RVA="0x1E6E244", Offset="0x1E6E244", VA="0x1E6E244")]
			static <>c()
			{
			}

			[Address(RVA="0x1E6E2A8", Offset="0x1E6E2A8", VA="0x1E6E2A8")]
			public <>c()
			{
			}

			[Address(RVA="0x1E6E2B0", Offset="0x1E6E2B0", VA="0x1E6E2B0")]
			internal AuthTokenResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}