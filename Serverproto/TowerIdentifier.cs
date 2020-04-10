using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerIdentifier : IMessage<TowerIdentifier>, IMessage, IEquatable<TowerIdentifier>, IDeepCloneable<TowerIdentifier>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerIdentifier> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TowerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong towerId_;

		[FieldOffset(Offset="0x0")]
		public const int MapIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong mapId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B40", Offset="0x1096B40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B71624", Offset="0x1B71624", VA="0x1B71624")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B70", Offset="0x1096B70")]
		public ulong MapId
		{
			[Address(RVA="0x1B71800", Offset="0x1B71800", VA="0x1B71800")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B71808", Offset="0x1B71808", VA="0x1B71808")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B30", Offset="0x1096B30")]
		public static MessageParser<TowerIdentifier> Parser
		{
			[Address(RVA="0x1B715BC", Offset="0x1B715BC", VA="0x1B715BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B50", Offset="0x1096B50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B71714", Offset="0x1B71714", VA="0x1B71714", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B60", Offset="0x1096B60")]
		public ulong TowerId
		{
			[Address(RVA="0x1B717F0", Offset="0x1B717F0", VA="0x1B717F0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B717F8", Offset="0x1B717F8", VA="0x1B717F8")]
			set
			{
			}
		}

		[Address(RVA="0x1B71C2C", Offset="0x1B71C2C", VA="0x1B71C2C")]
		static TowerIdentifier()
		{
		}

		[Address(RVA="0x1B6DA80", Offset="0x1B6DA80", VA="0x1B6DA80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F06C", Offset="0x107F06C")]
		public TowerIdentifier()
		{
		}

		[Address(RVA="0x1B71770", Offset="0x1B71770", VA="0x1B71770")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F07C", Offset="0x107F07C")]
		public TowerIdentifier(TowerIdentifier other)
		{
		}

		[Address(RVA="0x1B71AB4", Offset="0x1B71AB4", VA="0x1B71AB4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F0EC", Offset="0x107F0EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6D640", Offset="0x1B6D640", VA="0x1B6D640", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F08C", Offset="0x107F08C")]
		public TowerIdentifier Clone()
		{
			return null;
		}

		[Address(RVA="0x1B71810", Offset="0x1B71810", VA="0x1B71810", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F09C", Offset="0x107F09C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B71884", Offset="0x1B71884", VA="0x1B71884", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F0AC", Offset="0x107F0AC")]
		public bool Equals(TowerIdentifier other)
		{
			return new bool();
		}

		[Address(RVA="0x1B718D0", Offset="0x1B718D0", VA="0x1B718D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F0BC", Offset="0x107F0BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6DA88", Offset="0x1B6DA88", VA="0x1B6DA88", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F0FC", Offset="0x107F0FC")]
		public void MergeFrom(TowerIdentifier other)
		{
		}

		[Address(RVA="0x1B71B88", Offset="0x1B71B88", VA="0x1B71B88", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F10C", Offset="0x107F10C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B71954", Offset="0x1B71954", VA="0x1B71954", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F0CC", Offset="0x107F0CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B719BC", Offset="0x1B719BC", VA="0x1B719BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F0DC", Offset="0x107F0DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD28", Offset="0x104FD28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerIdentifier.<>c <>9;

			[Address(RVA="0x1B71D04", Offset="0x1B71D04", VA="0x1B71D04")]
			static <>c()
			{
			}

			[Address(RVA="0x1B71D68", Offset="0x1B71D68", VA="0x1B71D68")]
			public <>c()
			{
			}

			[Address(RVA="0x1B71D70", Offset="0x1B71D70", VA="0x1B71D70")]
			internal TowerIdentifier <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}