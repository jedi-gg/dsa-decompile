using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshKothAttemptsResponse : IMessage<RefreshKothAttemptsResponse>, IMessage, IEquatable<RefreshKothAttemptsResponse>, IDeepCloneable<RefreshKothAttemptsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshKothAttemptsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AttemptsRemainingFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong attemptsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int CooldownEndTimeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong cooldownEndTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B690", Offset="0x109B690")]
		public ulong AttemptsRemaining
		{
			[Address(RVA="0x201FD88", Offset="0x201FD88", VA="0x201FD88")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201FD90", Offset="0x201FD90", VA="0x201FD90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B6A0", Offset="0x109B6A0")]
		public ulong CooldownEndTime
		{
			[Address(RVA="0x201FD98", Offset="0x201FD98", VA="0x201FD98")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201FDA0", Offset="0x201FDA0", VA="0x201FDA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B670", Offset="0x109B670")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201FB54", Offset="0x201FB54", VA="0x201FB54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B660", Offset="0x109B660")]
		public static MessageParser<RefreshKothAttemptsResponse> Parser
		{
			[Address(RVA="0x201FAEC", Offset="0x201FAEC", VA="0x201FAEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B680", Offset="0x109B680")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201FC44", Offset="0x201FC44", VA="0x201FC44", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2020210", Offset="0x2020210", VA="0x2020210")]
		static RefreshKothAttemptsResponse()
		{
		}

		[Address(RVA="0x201FCA0", Offset="0x201FCA0", VA="0x201FCA0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108708C", Offset="0x108708C")]
		public RefreshKothAttemptsResponse()
		{
		}

		[Address(RVA="0x201FCA8", Offset="0x201FCA8", VA="0x201FCA8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108709C", Offset="0x108709C")]
		public RefreshKothAttemptsResponse(RefreshKothAttemptsResponse other)
		{
		}

		[Address(RVA="0x202004C", Offset="0x202004C", VA="0x202004C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108710C", Offset="0x108710C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201FD28", Offset="0x201FD28", VA="0x201FD28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10870AC", Offset="0x10870AC")]
		public RefreshKothAttemptsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x201FDA8", Offset="0x201FDA8", VA="0x201FDA8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10870BC", Offset="0x10870BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201FE1C", Offset="0x201FE1C", VA="0x201FE1C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10870CC", Offset="0x10870CC")]
		public bool Equals(RefreshKothAttemptsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x201FE68", Offset="0x201FE68", VA="0x201FE68", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10870DC", Offset="0x10870DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2020120", Offset="0x2020120", VA="0x2020120", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108711C", Offset="0x108711C")]
		public void MergeFrom(RefreshKothAttemptsResponse other)
		{
		}

		[Address(RVA="0x202016C", Offset="0x202016C", VA="0x202016C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108712C", Offset="0x108712C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201FEEC", Offset="0x201FEEC", VA="0x201FEEC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10870EC", Offset="0x10870EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201FF54", Offset="0x201FF54", VA="0x201FF54", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10870FC", Offset="0x10870FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10508C8", Offset="0x10508C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshKothAttemptsResponse.<>c <>9;

			[Address(RVA="0x20202E8", Offset="0x20202E8", VA="0x20202E8")]
			static <>c()
			{
			}

			[Address(RVA="0x202034C", Offset="0x202034C", VA="0x202034C")]
			public <>c()
			{
			}

			[Address(RVA="0x2020354", Offset="0x2020354", VA="0x2020354")]
			internal RefreshKothAttemptsResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}