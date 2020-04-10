using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimBonusClubDungeonAttemptResponse : IMessage<ClaimBonusClubDungeonAttemptResponse>, IMessage, IEquatable<ClaimBonusClubDungeonAttemptResponse>, IDeepCloneable<ClaimBonusClubDungeonAttemptResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimBonusClubDungeonAttemptResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int LimitedAttemptsRemainingFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong limitedAttemptsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int ValidatedFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool validated_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B60", Offset="0x1095B60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A40CBC", Offset="0x1A40CBC", VA="0x1A40CBC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B80", Offset="0x1095B80")]
		public ulong LimitedAttemptsRemaining
		{
			[Address(RVA="0x1A40EF0", Offset="0x1A40EF0", VA="0x1A40EF0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A40EF8", Offset="0x1A40EF8", VA="0x1A40EF8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B50", Offset="0x1095B50")]
		public static MessageParser<ClaimBonusClubDungeonAttemptResponse> Parser
		{
			[Address(RVA="0x1A40C54", Offset="0x1A40C54", VA="0x1A40C54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B70", Offset="0x1095B70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A40DAC", Offset="0x1A40DAC", VA="0x1A40DAC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B90", Offset="0x1095B90")]
		public bool Validated
		{
			[Address(RVA="0x1A40F00", Offset="0x1A40F00", VA="0x1A40F00")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A40F08", Offset="0x1A40F08", VA="0x1A40F08")]
			set
			{
			}
		}

		[Address(RVA="0x1A41370", Offset="0x1A41370", VA="0x1A41370")]
		static ClaimBonusClubDungeonAttemptResponse()
		{
		}

		[Address(RVA="0x1A40E08", Offset="0x1A40E08", VA="0x1A40E08")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D2DC", Offset="0x107D2DC")]
		public ClaimBonusClubDungeonAttemptResponse()
		{
		}

		[Address(RVA="0x1A40E10", Offset="0x1A40E10", VA="0x1A40E10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D2EC", Offset="0x107D2EC")]
		public ClaimBonusClubDungeonAttemptResponse(ClaimBonusClubDungeonAttemptResponse other)
		{
		}

		[Address(RVA="0x1A411D4", Offset="0x1A411D4", VA="0x1A411D4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D35C", Offset="0x107D35C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A40E90", Offset="0x1A40E90", VA="0x1A40E90", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D2FC", Offset="0x107D2FC")]
		public ClaimBonusClubDungeonAttemptResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A40F14", Offset="0x1A40F14", VA="0x1A40F14", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D30C", Offset="0x107D30C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A40F88", Offset="0x1A40F88", VA="0x1A40F88", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D31C", Offset="0x107D31C")]
		public bool Equals(ClaimBonusClubDungeonAttemptResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A40FE4", Offset="0x1A40FE4", VA="0x1A40FE4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D32C", Offset="0x107D32C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4127C", Offset="0x1A4127C", VA="0x1A4127C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D36C", Offset="0x107D36C")]
		public void MergeFrom(ClaimBonusClubDungeonAttemptResponse other)
		{
		}

		[Address(RVA="0x1A412C8", Offset="0x1A412C8", VA="0x1A412C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D37C", Offset="0x107D37C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A41070", Offset="0x1A41070", VA="0x1A41070", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D33C", Offset="0x107D33C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A410D8", Offset="0x1A410D8", VA="0x1A410D8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D34C", Offset="0x107D34C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA68", Offset="0x104FA68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimBonusClubDungeonAttemptResponse.<>c <>9;

			[Address(RVA="0x1A41448", Offset="0x1A41448", VA="0x1A41448")]
			static <>c()
			{
			}

			[Address(RVA="0x1A414AC", Offset="0x1A414AC", VA="0x1A414AC")]
			public <>c()
			{
			}

			[Address(RVA="0x1A414B4", Offset="0x1A414B4", VA="0x1A414B4")]
			internal ClaimBonusClubDungeonAttemptResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}