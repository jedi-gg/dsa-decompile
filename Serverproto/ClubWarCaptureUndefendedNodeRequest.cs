using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarCaptureUndefendedNodeRequest : IMessage<ClubWarCaptureUndefendedNodeRequest>, IMessage, IEquatable<ClubWarCaptureUndefendedNodeRequest>, IDeepCloneable<ClubWarCaptureUndefendedNodeRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarCaptureUndefendedNodeRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GdNodeIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string gdNodeId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10964F0", Offset="0x10964F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1DD68", Offset="0x1B1DD68", VA="0x1B1DD68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096510", Offset="0x1096510")]
		public string GdNodeId
		{
			[Address(RVA="0x1B1DFCC", Offset="0x1B1DFCC", VA="0x1B1DFCC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1DFD4", Offset="0x1B1DFD4", VA="0x1B1DFD4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10964E0", Offset="0x10964E0")]
		public static MessageParser<ClubWarCaptureUndefendedNodeRequest> Parser
		{
			[Address(RVA="0x1B1DD00", Offset="0x1B1DD00", VA="0x1B1DD00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096500", Offset="0x1096500")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1DE58", Offset="0x1B1DE58", VA="0x1B1DE58", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1E464", Offset="0x1B1E464", VA="0x1B1E464")]
		static ClubWarCaptureUndefendedNodeRequest()
		{
		}

		[Address(RVA="0x1B1DEB4", Offset="0x1B1DEB4", VA="0x1B1DEB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E82C", Offset="0x107E82C")]
		public ClubWarCaptureUndefendedNodeRequest()
		{
		}

		[Address(RVA="0x1B1DF0C", Offset="0x1B1DF0C", VA="0x1B1DF0C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E83C", Offset="0x107E83C")]
		public ClubWarCaptureUndefendedNodeRequest(ClubWarCaptureUndefendedNodeRequest other)
		{
		}

		[Address(RVA="0x1B1E2C0", Offset="0x1B1E2C0", VA="0x1B1E2C0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E8AC", Offset="0x107E8AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1DF6C", Offset="0x1B1DF6C", VA="0x1B1DF6C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E84C", Offset="0x107E84C")]
		public ClubWarCaptureUndefendedNodeRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1E044", Offset="0x1B1E044", VA="0x1B1E044", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E85C", Offset="0x107E85C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1E0B8", Offset="0x1B1E0B8", VA="0x1B1E0B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E86C", Offset="0x107E86C")]
		public bool Equals(ClubWarCaptureUndefendedNodeRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1E11C", Offset="0x1B1E11C", VA="0x1B1E11C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E87C", Offset="0x107E87C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1E374", Offset="0x1B1E374", VA="0x1B1E374", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E8BC", Offset="0x107E8BC")]
		public void MergeFrom(ClubWarCaptureUndefendedNodeRequest other)
		{
		}

		[Address(RVA="0x1B1E3E0", Offset="0x1B1E3E0", VA="0x1B1E3E0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E8CC", Offset="0x107E8CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1E1A0", Offset="0x1B1E1A0", VA="0x1B1E1A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E88C", Offset="0x107E88C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1E208", Offset="0x1B1E208", VA="0x1B1E208", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E89C", Offset="0x107E89C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC68", Offset="0x104FC68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarCaptureUndefendedNodeRequest.<>c <>9;

			[Address(RVA="0x1B1E53C", Offset="0x1B1E53C", VA="0x1B1E53C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1E5A0", Offset="0x1B1E5A0", VA="0x1B1E5A0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1E5A8", Offset="0x1B1E5A8", VA="0x1B1E5A8")]
			internal ClubWarCaptureUndefendedNodeRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}