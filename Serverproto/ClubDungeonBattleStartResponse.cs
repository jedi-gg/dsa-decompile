using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonBattleStartResponse : IMessage<ClubDungeonBattleStartResponse>, IMessage, IEquatable<ClubDungeonBattleStartResponse>, IDeepCloneable<ClubDungeonBattleStartResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonBattleStartResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093180", Offset="0x1093180")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1A4F180", Offset="0x1A4F180", VA="0x1A4F180")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4F188", Offset="0x1A4F188", VA="0x1A4F188")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093160", Offset="0x1093160")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4EEE4", Offset="0x1A4EEE4", VA="0x1A4EEE4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093150", Offset="0x1093150")]
		public static MessageParser<ClubDungeonBattleStartResponse> Parser
		{
			[Address(RVA="0x1A4EE7C", Offset="0x1A4EE7C", VA="0x1A4EE7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093170", Offset="0x1093170")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4EFD4", Offset="0x1A4EFD4", VA="0x1A4EFD4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093190", Offset="0x1093190")]
		public ulong PlayerId
		{
			[Address(RVA="0x1A4F1F8", Offset="0x1A4F1F8", VA="0x1A4F1F8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A4F200", Offset="0x1A4F200", VA="0x1A4F200")]
			set
			{
			}
		}

		[Address(RVA="0x1A4F788", Offset="0x1A4F788", VA="0x1A4F788")]
		static ClubDungeonBattleStartResponse()
		{
		}

		[Address(RVA="0x1A4F030", Offset="0x1A4F030", VA="0x1A4F030")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107820C", Offset="0x107820C")]
		public ClubDungeonBattleStartResponse()
		{
		}

		[Address(RVA="0x1A4F0A4", Offset="0x1A4F0A4", VA="0x1A4F0A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107821C", Offset="0x107821C")]
		public ClubDungeonBattleStartResponse(ClubDungeonBattleStartResponse other)
		{
		}

		[Address(RVA="0x1A4F56C", Offset="0x1A4F56C", VA="0x1A4F56C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107828C", Offset="0x107828C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4F120", Offset="0x1A4F120", VA="0x1A4F120", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107822C", Offset="0x107822C")]
		public ClubDungeonBattleStartResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4F208", Offset="0x1A4F208", VA="0x1A4F208", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107823C", Offset="0x107823C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4F27C", Offset="0x1A4F27C", VA="0x1A4F27C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107824C", Offset="0x107824C")]
		public bool Equals(ClubDungeonBattleStartResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4F348", Offset="0x1A4F348", VA="0x1A4F348", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107825C", Offset="0x107825C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4F664", Offset="0x1A4F664", VA="0x1A4F664", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107829C", Offset="0x107829C")]
		public void MergeFrom(ClubDungeonBattleStartResponse other)
		{
		}

		[Address(RVA="0x1A4F6DC", Offset="0x1A4F6DC", VA="0x1A4F6DC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10782AC", Offset="0x10782AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4F3F4", Offset="0x1A4F3F4", VA="0x1A4F3F4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107826C", Offset="0x107826C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4F45C", Offset="0x1A4F45C", VA="0x1A4F45C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107827C", Offset="0x107827C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F2D8", Offset="0x104F2D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonBattleStartResponse.<>c <>9;

			[Address(RVA="0x1A4F860", Offset="0x1A4F860", VA="0x1A4F860")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4F8C4", Offset="0x1A4F8C4", VA="0x1A4F8C4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4F8CC", Offset="0x1A4F8CC", VA="0x1A4F8CC")]
			internal ClubDungeonBattleStartResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}