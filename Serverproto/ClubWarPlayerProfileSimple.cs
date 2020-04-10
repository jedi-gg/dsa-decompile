using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarPlayerProfileSimple : IMessage<ClubWarPlayerProfileSimple>, IMessage, IEquatable<ClubWarPlayerProfileSimple>, IDeepCloneable<ClubWarPlayerProfileSimple>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarPlayerProfileSimple> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int UsernameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string username_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong avatarId_;

		[FieldOffset(Offset="0x0")]
		public const int ShowVipProfileBgFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private bool showVipProfileBg_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10966F0", Offset="0x10966F0")]
		public ulong AvatarId
		{
			[Address(RVA="0x1B27AA0", Offset="0x1B27AA0", VA="0x1B27AA0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B27AA8", Offset="0x1B27AA8", VA="0x1B27AA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10966A0", Offset="0x10966A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B276CC", Offset="0x1B276CC", VA="0x1B276CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10966C0", Offset="0x10966C0")]
		public string Id
		{
			[Address(RVA="0x1B279A0", Offset="0x1B279A0", VA="0x1B279A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B279A8", Offset="0x1B279A8", VA="0x1B279A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10966E0", Offset="0x10966E0")]
		public ulong Level
		{
			[Address(RVA="0x1B27A90", Offset="0x1B27A90", VA="0x1B27A90")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B27A98", Offset="0x1B27A98", VA="0x1B27A98")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096690", Offset="0x1096690")]
		public static MessageParser<ClubWarPlayerProfileSimple> Parser
		{
			[Address(RVA="0x1B27664", Offset="0x1B27664", VA="0x1B27664")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10966B0", Offset="0x10966B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B277BC", Offset="0x1B277BC", VA="0x1B277BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096700", Offset="0x1096700")]
		public bool ShowVipProfileBg
		{
			[Address(RVA="0x1B27AB0", Offset="0x1B27AB0", VA="0x1B27AB0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B27AB8", Offset="0x1B27AB8", VA="0x1B27AB8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10966D0", Offset="0x10966D0")]
		public string Username
		{
			[Address(RVA="0x1B27A18", Offset="0x1B27A18", VA="0x1B27A18")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B27A20", Offset="0x1B27A20", VA="0x1B27A20")]
			set
			{
			}
		}

		[Address(RVA="0x1B28350", Offset="0x1B28350", VA="0x1B28350")]
		static ClubWarPlayerProfileSimple()
		{
		}

		[Address(RVA="0x1B27818", Offset="0x1B27818", VA="0x1B27818")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EAEC", Offset="0x107EAEC")]
		public ClubWarPlayerProfileSimple()
		{
		}

		[Address(RVA="0x1B27870", Offset="0x1B27870", VA="0x1B27870")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EAFC", Offset="0x107EAFC")]
		public ClubWarPlayerProfileSimple(ClubWarPlayerProfileSimple other)
		{
		}

		[Address(RVA="0x1B27FC0", Offset="0x1B27FC0", VA="0x1B27FC0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB6C", Offset="0x107EB6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B27940", Offset="0x1B27940", VA="0x1B27940", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB0C", Offset="0x107EB0C")]
		public ClubWarPlayerProfileSimple Clone()
		{
			return null;
		}

		[Address(RVA="0x1B27AC4", Offset="0x1B27AC4", VA="0x1B27AC4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB1C", Offset="0x107EB1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B27B38", Offset="0x1B27B38", VA="0x1B27B38", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB2C", Offset="0x107EB2C")]
		public bool Equals(ClubWarPlayerProfileSimple other)
		{
			return new bool();
		}

		[Address(RVA="0x1B27BF0", Offset="0x1B27BF0", VA="0x1B27BF0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB3C", Offset="0x107EB3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B2815C", Offset="0x1B2815C", VA="0x1B2815C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB7C", Offset="0x107EB7C")]
		public void MergeFrom(ClubWarPlayerProfileSimple other)
		{
		}

		[Address(RVA="0x1B28218", Offset="0x1B28218", VA="0x1B28218", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB8C", Offset="0x107EB8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B27D24", Offset="0x1B27D24", VA="0x1B27D24", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB4C", Offset="0x107EB4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B27D8C", Offset="0x1B27D8C", VA="0x1B27D8C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB5C", Offset="0x107EB5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FCA8", Offset="0x104FCA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarPlayerProfileSimple.<>c <>9;

			[Address(RVA="0x1B28428", Offset="0x1B28428", VA="0x1B28428")]
			static <>c()
			{
			}

			[Address(RVA="0x1B2848C", Offset="0x1B2848C", VA="0x1B2848C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B28494", Offset="0x1B28494", VA="0x1B28494")]
			internal ClubWarPlayerProfileSimple <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}