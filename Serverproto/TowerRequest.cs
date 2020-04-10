using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerRequest : IMessage<TowerRequest>, IMessage, IEquatable<TowerRequest>, IDeepCloneable<TowerRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE78", Offset="0x109CE78")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B7631C", Offset="0x1B7631C", VA="0x1B7631C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE68", Offset="0x109CE68")]
		public static MessageParser<TowerRequest> Parser
		{
			[Address(RVA="0x1B7617C", Offset="0x1B7617C", VA="0x1B7617C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE88", Offset="0x109CE88")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B76408", Offset="0x1B76408", VA="0x1B76408", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B7671C", Offset="0x1B7671C", VA="0x1B7671C")]
		static TowerRequest()
		{
		}

		[Address(RVA="0x1B76464", Offset="0x1B76464", VA="0x1B76464")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108970C", Offset="0x108970C")]
		public TowerRequest()
		{
		}

		[Address(RVA="0x1B7646C", Offset="0x1B7646C", VA="0x1B7646C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108971C", Offset="0x108971C")]
		public TowerRequest(TowerRequest other)
		{
		}

		[Address(RVA="0x1B76680", Offset="0x1B76680", VA="0x1B76680", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108978C", Offset="0x108978C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B764B0", Offset="0x1B764B0", VA="0x1B764B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108972C", Offset="0x108972C")]
		public TowerRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B76510", Offset="0x1B76510", VA="0x1B76510", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108973C", Offset="0x108973C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B765A8", Offset="0x1B765A8", VA="0x1B765A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108974C", Offset="0x108974C")]
		public bool Equals(TowerRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B765D4", Offset="0x1B765D4", VA="0x1B765D4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108975C", Offset="0x108975C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B76694", Offset="0x1B76694", VA="0x1B76694", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108979C", Offset="0x108979C")]
		public void MergeFrom(TowerRequest other)
		{
		}

		[Address(RVA="0x1B766C8", Offset="0x1B766C8", VA="0x1B766C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10897AC", Offset="0x10897AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B76604", Offset="0x1B76604", VA="0x1B76604", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108976C", Offset="0x108976C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B7666C", Offset="0x1B7666C", VA="0x1B7666C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108977C", Offset="0x108977C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C58", Offset="0x1050C58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerRequest.<>c <>9;

			[Address(RVA="0x1B767F4", Offset="0x1B767F4", VA="0x1B767F4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B76858", Offset="0x1B76858", VA="0x1B76858")]
			public <>c()
			{
			}

			[Address(RVA="0x1B76860", Offset="0x1B76860", VA="0x1B76860")]
			internal TowerRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}