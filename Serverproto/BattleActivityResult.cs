using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleActivityResult : IMessage<BattleActivityResult>, IMessage, IEquatable<BattleActivityResult>, IDeepCloneable<BattleActivityResult>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleActivityResult> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattlePlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong battlePlayerId_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityDefIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong activityDefId_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityValueFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong activityValue_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091DC8", Offset="0x1091DC8")]
		public ulong ActivityDefId
		{
			[Address(RVA="0x1E6ED48", Offset="0x1E6ED48", VA="0x1E6ED48")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E6ED50", Offset="0x1E6ED50", VA="0x1E6ED50")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091DD8", Offset="0x1091DD8")]
		public ulong ActivityValue
		{
			[Address(RVA="0x1E6ED58", Offset="0x1E6ED58", VA="0x1E6ED58")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E6ED60", Offset="0x1E6ED60", VA="0x1E6ED60")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091DB8", Offset="0x1091DB8")]
		public ulong BattlePlayerId
		{
			[Address(RVA="0x1E6ED38", Offset="0x1E6ED38", VA="0x1E6ED38")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E6ED40", Offset="0x1E6ED40", VA="0x1E6ED40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D98", Offset="0x1091D98")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E6EAE8", Offset="0x1E6EAE8", VA="0x1E6EAE8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D88", Offset="0x1091D88")]
		public static MessageParser<BattleActivityResult> Parser
		{
			[Address(RVA="0x1E6EA80", Offset="0x1E6EA80", VA="0x1E6EA80")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091DA8", Offset="0x1091DA8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E6EBD8", Offset="0x1E6EBD8", VA="0x1E6EBD8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1E6F2D0", Offset="0x1E6F2D0", VA="0x1E6F2D0")]
		static BattleActivityResult()
		{
		}

		[Address(RVA="0x1E6EC34", Offset="0x1E6EC34", VA="0x1E6EC34")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E4C", Offset="0x1075E4C")]
		public BattleActivityResult()
		{
		}

		[Address(RVA="0x1E6EC3C", Offset="0x1E6EC3C", VA="0x1E6EC3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E5C", Offset="0x1075E5C")]
		public BattleActivityResult(BattleActivityResult other)
		{
		}

		[Address(RVA="0x1E6F090", Offset="0x1E6F090", VA="0x1E6F090", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075ECC", Offset="0x1075ECC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E6ECD8", Offset="0x1E6ECD8", VA="0x1E6ECD8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E6C", Offset="0x1075E6C")]
		public BattleActivityResult Clone()
		{
			return null;
		}

		[Address(RVA="0x1E6ED68", Offset="0x1E6ED68", VA="0x1E6ED68", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E7C", Offset="0x1075E7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E6EDDC", Offset="0x1E6EDDC", VA="0x1E6EDDC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E8C", Offset="0x1075E8C")]
		public bool Equals(BattleActivityResult other)
		{
			return new bool();
		}

		[Address(RVA="0x1E6EE38", Offset="0x1E6EE38", VA="0x1E6EE38", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E9C", Offset="0x1075E9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E6F1A0", Offset="0x1E6F1A0", VA="0x1E6F1A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075EDC", Offset="0x1075EDC")]
		public void MergeFrom(BattleActivityResult other)
		{
		}

		[Address(RVA="0x1E6F1F8", Offset="0x1E6F1F8", VA="0x1E6F1F8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075EEC", Offset="0x1075EEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E6EED8", Offset="0x1E6EED8", VA="0x1E6EED8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075EAC", Offset="0x1075EAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E6EF40", Offset="0x1E6EF40", VA="0x1E6EF40", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075EBC", Offset="0x1075EBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF98", Offset="0x104EF98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleActivityResult.<>c <>9;

			[Address(RVA="0x1E6F3A8", Offset="0x1E6F3A8", VA="0x1E6F3A8")]
			static <>c()
			{
			}

			[Address(RVA="0x1E6F40C", Offset="0x1E6F40C", VA="0x1E6F40C")]
			public <>c()
			{
			}

			[Address(RVA="0x1E6F414", Offset="0x1E6F414", VA="0x1E6F414")]
			internal BattleActivityResult <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}