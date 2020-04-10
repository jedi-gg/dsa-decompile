using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeFriendsResponse : IMessage<HomeFriendsResponse>, IMessage, IEquatable<HomeFriendsResponse>, IDeepCloneable<HomeFriendsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeFriendsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int FriendsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Friend> _repeated_friends_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Friend> friends_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098210", Offset="0x1098210")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D043D4", Offset="0x1D043D4", VA="0x1D043D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098230", Offset="0x1098230")]
		public RepeatedField<Friend> Friends
		{
			[Address(RVA="0x1D04684", Offset="0x1D04684", VA="0x1D04684")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098200", Offset="0x1098200")]
		public static MessageParser<HomeFriendsResponse> Parser
		{
			[Address(RVA="0x1D0436C", Offset="0x1D0436C", VA="0x1D0436C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098220", Offset="0x1098220")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D044C0", Offset="0x1D044C0", VA="0x1D044C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D04B6C", Offset="0x1D04B6C", VA="0x1D04B6C")]
		static HomeFriendsResponse()
		{
		}

		[Address(RVA="0x1D0451C", Offset="0x1D0451C", VA="0x1D0451C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108142C", Offset="0x108142C")]
		public HomeFriendsResponse()
		{
		}

		[Address(RVA="0x1D0458C", Offset="0x1D0458C", VA="0x1D0458C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108143C", Offset="0x108143C")]
		public HomeFriendsResponse(HomeFriendsResponse other)
		{
		}

		[Address(RVA="0x1D0493C", Offset="0x1D0493C", VA="0x1D0493C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10814AC", Offset="0x10814AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D04624", Offset="0x1D04624", VA="0x1D04624", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108144C", Offset="0x108144C")]
		public HomeFriendsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D0468C", Offset="0x1D0468C", VA="0x1D0468C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108145C", Offset="0x108145C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D04700", Offset="0x1D04700", VA="0x1D04700", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108146C", Offset="0x108146C")]
		public bool Equals(HomeFriendsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D047B0", Offset="0x1D047B0", VA="0x1D047B0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108147C", Offset="0x108147C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D049F8", Offset="0x1D049F8", VA="0x1D049F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10814BC", Offset="0x10814BC")]
		public void MergeFrom(HomeFriendsResponse other)
		{
		}

		[Address(RVA="0x1D04A88", Offset="0x1D04A88", VA="0x1D04A88", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10814CC", Offset="0x10814CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D04810", Offset="0x1D04810", VA="0x1D04810", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108148C", Offset="0x108148C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D04878", Offset="0x1D04878", VA="0x1D04878", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108149C", Offset="0x108149C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050068", Offset="0x1050068")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeFriendsResponse.<>c <>9;

			[Address(RVA="0x1D04C90", Offset="0x1D04C90", VA="0x1D04C90")]
			static <>c()
			{
			}

			[Address(RVA="0x1D04CF4", Offset="0x1D04CF4", VA="0x1D04CF4")]
			public <>c()
			{
			}

			[Address(RVA="0x1D04CFC", Offset="0x1D04CFC", VA="0x1D04CFC")]
			internal HomeFriendsResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}