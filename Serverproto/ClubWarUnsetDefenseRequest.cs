using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarUnsetDefenseRequest : IMessage<ClubWarUnsetDefenseRequest>, IMessage, IEquatable<ClubWarUnsetDefenseRequest>, IDeepCloneable<ClubWarUnsetDefenseRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarUnsetDefenseRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SquadIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string squadId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10961E0", Offset="0x10961E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE809C", Offset="0x1EE809C", VA="0x1EE809C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10961D0", Offset="0x10961D0")]
		public static MessageParser<ClubWarUnsetDefenseRequest> Parser
		{
			[Address(RVA="0x1EE8034", Offset="0x1EE8034", VA="0x1EE8034")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10961F0", Offset="0x10961F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE818C", Offset="0x1EE818C", VA="0x1EE818C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096200", Offset="0x1096200")]
		public string SquadId
		{
			[Address(RVA="0x1EE8300", Offset="0x1EE8300", VA="0x1EE8300")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE8308", Offset="0x1EE8308", VA="0x1EE8308")]
			set
			{
			}
		}

		[Address(RVA="0x1EE8798", Offset="0x1EE8798", VA="0x1EE8798")]
		static ClubWarUnsetDefenseRequest()
		{
		}

		[Address(RVA="0x1EE81E8", Offset="0x1EE81E8", VA="0x1EE81E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E09C", Offset="0x107E09C")]
		public ClubWarUnsetDefenseRequest()
		{
		}

		[Address(RVA="0x1EE8240", Offset="0x1EE8240", VA="0x1EE8240")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E0AC", Offset="0x107E0AC")]
		public ClubWarUnsetDefenseRequest(ClubWarUnsetDefenseRequest other)
		{
		}

		[Address(RVA="0x1EE85F4", Offset="0x1EE85F4", VA="0x1EE85F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E11C", Offset="0x107E11C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE82A0", Offset="0x1EE82A0", VA="0x1EE82A0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E0BC", Offset="0x107E0BC")]
		public ClubWarUnsetDefenseRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE8378", Offset="0x1EE8378", VA="0x1EE8378", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E0CC", Offset="0x107E0CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE83EC", Offset="0x1EE83EC", VA="0x1EE83EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E0DC", Offset="0x107E0DC")]
		public bool Equals(ClubWarUnsetDefenseRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE8450", Offset="0x1EE8450", VA="0x1EE8450", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E0EC", Offset="0x107E0EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE86A8", Offset="0x1EE86A8", VA="0x1EE86A8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E12C", Offset="0x107E12C")]
		public void MergeFrom(ClubWarUnsetDefenseRequest other)
		{
		}

		[Address(RVA="0x1EE8714", Offset="0x1EE8714", VA="0x1EE8714", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E13C", Offset="0x107E13C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE84D4", Offset="0x1EE84D4", VA="0x1EE84D4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E0FC", Offset="0x107E0FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE853C", Offset="0x1EE853C", VA="0x1EE853C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E10C", Offset="0x107E10C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FBB8", Offset="0x104FBB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarUnsetDefenseRequest.<>c <>9;

			[Address(RVA="0x1EE8870", Offset="0x1EE8870", VA="0x1EE8870")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE88D4", Offset="0x1EE88D4", VA="0x1EE88D4")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE88DC", Offset="0x1EE88DC", VA="0x1EE88DC")]
			internal ClubWarUnsetDefenseRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}