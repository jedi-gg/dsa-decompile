using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubLeaderboardRequest : IMessage<ClubLeaderboardRequest>, IMessage, IEquatable<ClubLeaderboardRequest>, IDeepCloneable<ClubLeaderboardRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubLeaderboardRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubLeaderboardType type_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10995C0", Offset="0x10995C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFC154", Offset="0x1FFC154", VA="0x1FFC154")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10995B0", Offset="0x10995B0")]
		public static MessageParser<ClubLeaderboardRequest> Parser
		{
			[Address(RVA="0x1FFC0EC", Offset="0x1FFC0EC", VA="0x1FFC0EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10995D0", Offset="0x10995D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFC244", Offset="0x1FFC244", VA="0x1FFC244", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10995E0", Offset="0x10995E0")]
		public ClubLeaderboardType Type
		{
			[Address(RVA="0x1FFC36C", Offset="0x1FFC36C", VA="0x1FFC36C")]
			get
			{
				return new ClubLeaderboardType();
			}
			[Address(RVA="0x1FFC374", Offset="0x1FFC374", VA="0x1FFC374")]
			set
			{
			}
		}

		[Address(RVA="0x1FFC6E8", Offset="0x1FFC6E8", VA="0x1FFC6E8")]
		static ClubLeaderboardRequest()
		{
		}

		[Address(RVA="0x1FFC2A0", Offset="0x1FFC2A0", VA="0x1FFC2A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108347C", Offset="0x108347C")]
		public ClubLeaderboardRequest()
		{
		}

		[Address(RVA="0x1FFC2A8", Offset="0x1FFC2A8", VA="0x1FFC2A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108348C", Offset="0x108348C")]
		public ClubLeaderboardRequest(ClubLeaderboardRequest other)
		{
		}

		[Address(RVA="0x1FFC59C", Offset="0x1FFC59C", VA="0x1FFC59C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10834FC", Offset="0x10834FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFC30C", Offset="0x1FFC30C", VA="0x1FFC30C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108349C", Offset="0x108349C")]
		public ClubLeaderboardRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFC37C", Offset="0x1FFC37C", VA="0x1FFC37C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10834AC", Offset="0x10834AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFC3F0", Offset="0x1FFC3F0", VA="0x1FFC3F0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10834BC", Offset="0x10834BC")]
		public bool Equals(ClubLeaderboardRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFC42C", Offset="0x1FFC42C", VA="0x1FFC42C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10834CC", Offset="0x10834CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFC62C", Offset="0x1FFC62C", VA="0x1FFC62C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108350C", Offset="0x108350C")]
		public void MergeFrom(ClubLeaderboardRequest other)
		{
		}

		[Address(RVA="0x1FFC66C", Offset="0x1FFC66C", VA="0x1FFC66C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108351C", Offset="0x108351C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFC494", Offset="0x1FFC494", VA="0x1FFC494", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10834DC", Offset="0x10834DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFC4FC", Offset="0x1FFC4FC", VA="0x1FFC4FC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10834EC", Offset="0x10834EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050358", Offset="0x1050358")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubLeaderboardRequest.<>c <>9;

			[Address(RVA="0x1FFC7C0", Offset="0x1FFC7C0", VA="0x1FFC7C0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFC824", Offset="0x1FFC824", VA="0x1FFC824")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFC82C", Offset="0x1FFC82C", VA="0x1FFC82C")]
			internal ClubLeaderboardRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}