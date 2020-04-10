using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerVipStatusUpdatedDynamicMessage : IMessage<PlayerVipStatusUpdatedDynamicMessage>, IMessage, IEquatable<PlayerVipStatusUpdatedDynamicMessage>, IDeepCloneable<PlayerVipStatusUpdatedDynamicMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerVipStatusUpdatedDynamicMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ExpireTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong expireTimestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD78", Offset="0x109BD78")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B12044", Offset="0x1B12044", VA="0x1B12044")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD98", Offset="0x109BD98")]
		public ulong ExpireTimestamp
		{
			[Address(RVA="0x1B1225C", Offset="0x1B1225C", VA="0x1B1225C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B12264", Offset="0x1B12264", VA="0x1B12264")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD68", Offset="0x109BD68")]
		public static MessageParser<PlayerVipStatusUpdatedDynamicMessage> Parser
		{
			[Address(RVA="0x1B11FDC", Offset="0x1B11FDC", VA="0x1B11FDC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD88", Offset="0x109BD88")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B12134", Offset="0x1B12134", VA="0x1B12134", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B125D8", Offset="0x1B125D8", VA="0x1B125D8")]
		static PlayerVipStatusUpdatedDynamicMessage()
		{
		}

		[Address(RVA="0x1B12190", Offset="0x1B12190", VA="0x1B12190")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E4C", Offset="0x1087E4C")]
		public PlayerVipStatusUpdatedDynamicMessage()
		{
		}

		[Address(RVA="0x1B12198", Offset="0x1B12198", VA="0x1B12198")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E5C", Offset="0x1087E5C")]
		public PlayerVipStatusUpdatedDynamicMessage(PlayerVipStatusUpdatedDynamicMessage other)
		{
		}

		[Address(RVA="0x1B1248C", Offset="0x1B1248C", VA="0x1B1248C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087ECC", Offset="0x1087ECC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B121FC", Offset="0x1B121FC", VA="0x1B121FC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E6C", Offset="0x1087E6C")]
		public PlayerVipStatusUpdatedDynamicMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1226C", Offset="0x1B1226C", VA="0x1B1226C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E7C", Offset="0x1087E7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B122E0", Offset="0x1B122E0", VA="0x1B122E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E8C", Offset="0x1087E8C")]
		public bool Equals(PlayerVipStatusUpdatedDynamicMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1231C", Offset="0x1B1231C", VA="0x1B1231C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E9C", Offset="0x1087E9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1251C", Offset="0x1B1251C", VA="0x1B1251C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087EDC", Offset="0x1087EDC")]
		public void MergeFrom(PlayerVipStatusUpdatedDynamicMessage other)
		{
		}

		[Address(RVA="0x1B1255C", Offset="0x1B1255C", VA="0x1B1255C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087EEC", Offset="0x1087EEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B12384", Offset="0x1B12384", VA="0x1B12384", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087EAC", Offset="0x1087EAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B123EC", Offset="0x1B123EC", VA="0x1B123EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087EBC", Offset="0x1087EBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A08", Offset="0x1050A08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerVipStatusUpdatedDynamicMessage.<>c <>9;

			[Address(RVA="0x1B126B0", Offset="0x1B126B0", VA="0x1B126B0")]
			static <>c()
			{
			}

			[Address(RVA="0x1B12714", Offset="0x1B12714", VA="0x1B12714")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1271C", Offset="0x1B1271C", VA="0x1B1271C")]
			internal PlayerVipStatusUpdatedDynamicMessage <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}