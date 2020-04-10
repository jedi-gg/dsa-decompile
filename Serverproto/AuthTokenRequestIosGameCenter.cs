using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AuthTokenRequestIosGameCenter : IMessage<AuthTokenRequestIosGameCenter>, IMessage, IEquatable<AuthTokenRequestIosGameCenter>, IDeepCloneable<AuthTokenRequestIosGameCenter>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AuthTokenRequestIosGameCenter> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[FieldOffset(Offset="0x0")]
		public const int PublicKeyUrlFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string publicKeyUrl_;

		[FieldOffset(Offset="0x0")]
		public const int TimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong timestamp_;

		[FieldOffset(Offset="0x0")]
		public const int SignatureFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string signature_;

		[FieldOffset(Offset="0x0")]
		public const int SaltFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string salt_;

		[FieldOffset(Offset="0x0")]
		public const int AliasFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string alias_;

		[FieldOffset(Offset="0x0")]
		public const int BundleIdFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string bundleId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091860", Offset="0x1091860")]
		public string Alias
		{
			[Address(RVA="0x1611480", Offset="0x1611480", VA="0x1611480")]
			get
			{
				return null;
			}
			[Address(RVA="0x1611488", Offset="0x1611488", VA="0x1611488")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091870", Offset="0x1091870")]
		public string BundleId
		{
			[Address(RVA="0x16114F8", Offset="0x16114F8", VA="0x16114F8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1611500", Offset="0x1611500", VA="0x1611500")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10917F0", Offset="0x10917F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1611040", Offset="0x1611040", VA="0x1611040")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10917E0", Offset="0x10917E0")]
		public static MessageParser<AuthTokenRequestIosGameCenter> Parser
		{
			[Address(RVA="0x160B24C", Offset="0x160B24C", VA="0x160B24C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091800", Offset="0x1091800")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x161112C", Offset="0x161112C", VA="0x161112C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091810", Offset="0x1091810")]
		public string PlayerId
		{
			[Address(RVA="0x1611290", Offset="0x1611290", VA="0x1611290")]
			get
			{
				return null;
			}
			[Address(RVA="0x1611298", Offset="0x1611298", VA="0x1611298")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091820", Offset="0x1091820")]
		public string PublicKeyUrl
		{
			[Address(RVA="0x1611308", Offset="0x1611308", VA="0x1611308")]
			get
			{
				return null;
			}
			[Address(RVA="0x1611310", Offset="0x1611310", VA="0x1611310")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091850", Offset="0x1091850")]
		public string Salt
		{
			[Address(RVA="0x1611408", Offset="0x1611408", VA="0x1611408")]
			get
			{
				return null;
			}
			[Address(RVA="0x1611410", Offset="0x1611410", VA="0x1611410")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091840", Offset="0x1091840")]
		public string Signature
		{
			[Address(RVA="0x1611390", Offset="0x1611390", VA="0x1611390")]
			get
			{
				return null;
			}
			[Address(RVA="0x1611398", Offset="0x1611398", VA="0x1611398")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091830", Offset="0x1091830")]
		public ulong Timestamp
		{
			[Address(RVA="0x1611380", Offset="0x1611380", VA="0x1611380")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1611388", Offset="0x1611388", VA="0x1611388")]
			set
			{
			}
		}

		[Address(RVA="0x16120C0", Offset="0x16120C0", VA="0x16120C0")]
		static AuthTokenRequestIosGameCenter()
		{
		}

		[Address(RVA="0x1610128", Offset="0x1610128", VA="0x1610128")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107555C", Offset="0x107555C")]
		public AuthTokenRequestIosGameCenter()
		{
		}

		[Address(RVA="0x1611188", Offset="0x1611188", VA="0x1611188")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107556C", Offset="0x107556C")]
		public AuthTokenRequestIosGameCenter(AuthTokenRequestIosGameCenter other)
		{
		}

		[Address(RVA="0x1611C64", Offset="0x1611C64", VA="0x1611C64", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10755DC", Offset="0x10755DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160F054", Offset="0x160F054", VA="0x160F054", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107557C", Offset="0x107557C")]
		public AuthTokenRequestIosGameCenter Clone()
		{
			return null;
		}

		[Address(RVA="0x1611570", Offset="0x1611570", VA="0x1611570", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107558C", Offset="0x107558C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x16115E4", Offset="0x16115E4", VA="0x16115E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107559C", Offset="0x107559C")]
		public bool Equals(AuthTokenRequestIosGameCenter other)
		{
			return new bool();
		}

		[Address(RVA="0x16116BC", Offset="0x16116BC", VA="0x16116BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10755AC", Offset="0x10755AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1610188", Offset="0x1610188", VA="0x1610188", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10755EC", Offset="0x10755EC")]
		public void MergeFrom(AuthTokenRequestIosGameCenter other)
		{
		}

		[Address(RVA="0x1611F14", Offset="0x1611F14", VA="0x1611F14", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10755FC", Offset="0x10755FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x16118BC", Offset="0x16118BC", VA="0x16118BC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10755BC", Offset="0x10755BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1611924", Offset="0x1611924", VA="0x1611924", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10755CC", Offset="0x10755CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EEC8", Offset="0x104EEC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AuthTokenRequestIosGameCenter.<>c <>9;

			[Address(RVA="0x1E6D4C8", Offset="0x1E6D4C8", VA="0x1E6D4C8")]
			static <>c()
			{
			}

			[Address(RVA="0x1E6D52C", Offset="0x1E6D52C", VA="0x1E6D52C")]
			public <>c()
			{
			}

			[Address(RVA="0x1E6D534", Offset="0x1E6D534", VA="0x1E6D534")]
			internal AuthTokenRequestIosGameCenter <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}