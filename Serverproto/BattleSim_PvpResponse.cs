using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_PvpResponse : IMessage<BattleSim_PvpResponse>, IMessage, IEquatable<BattleSim_PvpResponse>, IDeepCloneable<BattleSim_PvpResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_PvpResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerOneTeamIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong playerOneTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTwoTeamIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong playerTwoTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ByteString bootstrap_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093EA0", Offset="0x1093EA0")]
		public ByteString Bootstrap
		{
			[Address(RVA="0x1DD50FC", Offset="0x1DD50FC", VA="0x1DD50FC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD5104", Offset="0x1DD5104", VA="0x1DD5104")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E60", Offset="0x1093E60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD4E28", Offset="0x1DD4E28", VA="0x1DD4E28")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E50", Offset="0x1093E50")]
		public static MessageParser<BattleSim_PvpResponse> Parser
		{
			[Address(RVA="0x1DCF50C", Offset="0x1DCF50C", VA="0x1DCF50C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E70", Offset="0x1093E70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD4F14", Offset="0x1DD4F14", VA="0x1DD4F14", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E80", Offset="0x1093E80")]
		public ulong PlayerOneTeamId
		{
			[Address(RVA="0x1DD50DC", Offset="0x1DD50DC", VA="0x1DD50DC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD50E4", Offset="0x1DD50E4", VA="0x1DD50E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E90", Offset="0x1093E90")]
		public ulong PlayerTwoTeamId
		{
			[Address(RVA="0x1DD50EC", Offset="0x1DD50EC", VA="0x1DD50EC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD50F4", Offset="0x1DD50F4", VA="0x1DD50F4")]
			set
			{
			}
		}

		[Address(RVA="0x1DD57E8", Offset="0x1DD57E8", VA="0x1DD57E8")]
		static BattleSim_PvpResponse()
		{
		}

		[Address(RVA="0x1DD4F70", Offset="0x1DD4F70", VA="0x1DD4F70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107949C", Offset="0x107949C")]
		public BattleSim_PvpResponse()
		{
		}

		[Address(RVA="0x1DD4FE4", Offset="0x1DD4FE4", VA="0x1DD4FE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10794AC", Offset="0x10794AC")]
		public BattleSim_PvpResponse(BattleSim_PvpResponse other)
		{
		}

		[Address(RVA="0x1DD555C", Offset="0x1DD555C", VA="0x1DD555C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107951C", Offset="0x107951C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD507C", Offset="0x1DD507C", VA="0x1DD507C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10794BC", Offset="0x10794BC")]
		public BattleSim_PvpResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD5174", Offset="0x1DD5174", VA="0x1DD5174", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10794CC", Offset="0x10794CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD51E8", Offset="0x1DD51E8", VA="0x1DD51E8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10794DC", Offset="0x10794DC")]
		public bool Equals(BattleSim_PvpResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD52C4", Offset="0x1DD52C4", VA="0x1DD52C4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10794EC", Offset="0x10794EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD5688", Offset="0x1DD5688", VA="0x1DD5688", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107952C", Offset="0x107952C")]
		public void MergeFrom(BattleSim_PvpResponse other)
		{
		}

		[Address(RVA="0x1DD570C", Offset="0x1DD570C", VA="0x1DD570C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107953C", Offset="0x107953C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD538C", Offset="0x1DD538C", VA="0x1DD538C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10794FC", Offset="0x10794FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD53F4", Offset="0x1DD53F4", VA="0x1DD53F4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107950C", Offset="0x107950C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F4C8", Offset="0x104F4C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_PvpResponse.<>c <>9;

			[Address(RVA="0x1DD58C0", Offset="0x1DD58C0", VA="0x1DD58C0")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD5924", Offset="0x1DD5924", VA="0x1DD5924")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD592C", Offset="0x1DD592C", VA="0x1DD592C")]
			internal BattleSim_PvpResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}