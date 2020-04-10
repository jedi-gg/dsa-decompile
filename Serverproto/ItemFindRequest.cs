using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ItemFindRequest : IMessage<ItemFindRequest>, IMessage, IEquatable<ItemFindRequest>, IDeepCloneable<ItemFindRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ItemFindRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D40", Offset="0x1098D40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A92528", Offset="0x1A92528", VA="0x1A92528")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D60", Offset="0x1098D60")]
		public ulong ItemId
		{
			[Address(RVA="0x1A9273C", Offset="0x1A9273C", VA="0x1A9273C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A92744", Offset="0x1A92744", VA="0x1A92744")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D30", Offset="0x1098D30")]
		public static MessageParser<ItemFindRequest> Parser
		{
			[Address(RVA="0x1A9061C", Offset="0x1A9061C", VA="0x1A9061C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D50", Offset="0x1098D50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A92614", Offset="0x1A92614", VA="0x1A92614", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A92AB8", Offset="0x1A92AB8", VA="0x1A92AB8")]
		static ItemFindRequest()
		{
		}

		[Address(RVA="0x1A92670", Offset="0x1A92670", VA="0x1A92670")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108234C", Offset="0x108234C")]
		public ItemFindRequest()
		{
		}

		[Address(RVA="0x1A92678", Offset="0x1A92678", VA="0x1A92678")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108235C", Offset="0x108235C")]
		public ItemFindRequest(ItemFindRequest other)
		{
		}

		[Address(RVA="0x1A9296C", Offset="0x1A9296C", VA="0x1A9296C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10823CC", Offset="0x10823CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A926DC", Offset="0x1A926DC", VA="0x1A926DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108236C", Offset="0x108236C")]
		public ItemFindRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9274C", Offset="0x1A9274C", VA="0x1A9274C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108237C", Offset="0x108237C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A927C0", Offset="0x1A927C0", VA="0x1A927C0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108238C", Offset="0x108238C")]
		public bool Equals(ItemFindRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A927FC", Offset="0x1A927FC", VA="0x1A927FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108239C", Offset="0x108239C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A929FC", Offset="0x1A929FC", VA="0x1A929FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10823DC", Offset="0x10823DC")]
		public void MergeFrom(ItemFindRequest other)
		{
		}

		[Address(RVA="0x1A92A3C", Offset="0x1A92A3C", VA="0x1A92A3C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10823EC", Offset="0x10823EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A92864", Offset="0x1A92864", VA="0x1A92864", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10823AC", Offset="0x10823AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A928CC", Offset="0x1A928CC", VA="0x1A928CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10823BC", Offset="0x10823BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10501C8", Offset="0x10501C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ItemFindRequest.<>c <>9;

			[Address(RVA="0x1A92B90", Offset="0x1A92B90", VA="0x1A92B90")]
			static <>c()
			{
			}

			[Address(RVA="0x1A92BF4", Offset="0x1A92BF4", VA="0x1A92BF4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A92BFC", Offset="0x1A92BFC", VA="0x1A92BFC")]
			internal ItemFindRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}