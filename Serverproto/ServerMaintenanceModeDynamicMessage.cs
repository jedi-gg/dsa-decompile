using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ServerMaintenanceModeDynamicMessage : IMessage<ServerMaintenanceModeDynamicMessage>, IMessage, IEquatable<ServerMaintenanceModeDynamicMessage>, IDeepCloneable<ServerMaintenanceModeDynamicMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ServerMaintenanceModeDynamicMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnderMaintenanceFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool underMaintenance_;

		[FieldOffset(Offset="0x0")]
		public const int RawMessageOverrideFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string rawMessageOverride_;

		[FieldOffset(Offset="0x0")]
		public const int MessageOverrideFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string messageOverride_;

		[FieldOffset(Offset="0x0")]
		public const int MaintenanceDurationFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string maintenanceDuration_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BDB8", Offset="0x109BDB8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BCF9E0", Offset="0x1BCF9E0", VA="0x1BCF9E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE08", Offset="0x109BE08")]
		public string MaintenanceDuration
		{
			[Address(RVA="0x1BCFD9C", Offset="0x1BCFD9C", VA="0x1BCFD9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BCFDA4", Offset="0x1BCFDA4", VA="0x1BCFDA4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BDF8", Offset="0x109BDF8")]
		public string MessageOverride
		{
			[Address(RVA="0x1BCFD24", Offset="0x1BCFD24", VA="0x1BCFD24")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BCFD2C", Offset="0x1BCFD2C", VA="0x1BCFD2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BDA8", Offset="0x109BDA8")]
		public static MessageParser<ServerMaintenanceModeDynamicMessage> Parser
		{
			[Address(RVA="0x1BCEA80", Offset="0x1BCEA80", VA="0x1BCEA80")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BDC8", Offset="0x109BDC8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BCFACC", Offset="0x1BCFACC", VA="0x1BCFACC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BDE8", Offset="0x109BDE8")]
		public string RawMessageOverride
		{
			[Address(RVA="0x1BCFCAC", Offset="0x1BCFCAC", VA="0x1BCFCAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BCFCB4", Offset="0x1BCFCB4", VA="0x1BCFCB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BDD8", Offset="0x109BDD8")]
		public bool UnderMaintenance
		{
			[Address(RVA="0x1BCFC98", Offset="0x1BCFC98", VA="0x1BCFC98")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BCFCA0", Offset="0x1BCFCA0", VA="0x1BCFCA0")]
			set
			{
			}
		}

		[Address(RVA="0x1BD0618", Offset="0x1BD0618", VA="0x1BD0618")]
		static ServerMaintenanceModeDynamicMessage()
		{
		}

		[Address(RVA="0x1BCFB28", Offset="0x1BCFB28", VA="0x1BCFB28")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087EFC", Offset="0x1087EFC")]
		public ServerMaintenanceModeDynamicMessage()
		{
		}

		[Address(RVA="0x1BCFB84", Offset="0x1BCFB84", VA="0x1BCFB84")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F0C", Offset="0x1087F0C")]
		public ServerMaintenanceModeDynamicMessage(ServerMaintenanceModeDynamicMessage other)
		{
		}

		[Address(RVA="0x1BD02C0", Offset="0x1BD02C0", VA="0x1BD02C0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F7C", Offset="0x1087F7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BCFC38", Offset="0x1BCFC38", VA="0x1BCFC38", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F1C", Offset="0x1087F1C")]
		public ServerMaintenanceModeDynamicMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1BCFE14", Offset="0x1BCFE14", VA="0x1BCFE14", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F2C", Offset="0x1087F2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCFE88", Offset="0x1BCFE88", VA="0x1BCFE88", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F3C", Offset="0x1087F3C")]
		public bool Equals(ServerMaintenanceModeDynamicMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCFF34", Offset="0x1BCFF34", VA="0x1BCFF34", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F4C", Offset="0x1087F4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD0430", Offset="0x1BD0430", VA="0x1BD0430", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F8C", Offset="0x1087F8C")]
		public void MergeFrom(ServerMaintenanceModeDynamicMessage other)
		{
		}

		[Address(RVA="0x1BD0500", Offset="0x1BD0500", VA="0x1BD0500", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F9C", Offset="0x1087F9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD0064", Offset="0x1BD0064", VA="0x1BD0064", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F5C", Offset="0x1087F5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD00CC", Offset="0x1BD00CC", VA="0x1BD00CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087F6C", Offset="0x1087F6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A18", Offset="0x1050A18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ServerMaintenanceModeDynamicMessage.<>c <>9;

			[Address(RVA="0x1BD06F0", Offset="0x1BD06F0", VA="0x1BD06F0")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD0754", Offset="0x1BD0754", VA="0x1BD0754")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD075C", Offset="0x1BD075C", VA="0x1BD075C")]
			internal ServerMaintenanceModeDynamicMessage <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}