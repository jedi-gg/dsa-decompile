using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshTowerRequest : IMessage<RefreshTowerRequest>, IMessage, IEquatable<RefreshTowerRequest>, IDeepCloneable<RefreshTowerRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshTowerRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private TowerIdentifier id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF78", Offset="0x109CF78")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x202181C", Offset="0x202181C", VA="0x202181C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF98", Offset="0x109CF98")]
		public TowerIdentifier Id
		{
			[Address(RVA="0x20219EC", Offset="0x20219EC", VA="0x20219EC")]
			get
			{
				return null;
			}
			[Address(RVA="0x20219F4", Offset="0x20219F4", VA="0x20219F4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF68", Offset="0x109CF68")]
		public static MessageParser<RefreshTowerRequest> Parser
		{
			[Address(RVA="0x20217B4", Offset="0x20217B4", VA="0x20217B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF88", Offset="0x109CF88")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x202190C", Offset="0x202190C", VA="0x202190C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2021EB4", Offset="0x2021EB4", VA="0x2021EB4")]
		static RefreshTowerRequest()
		{
		}

		[Address(RVA="0x2021968", Offset="0x2021968", VA="0x2021968")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10899CC", Offset="0x10899CC")]
		public RefreshTowerRequest()
		{
		}

		[Address(RVA="0x2021970", Offset="0x2021970", VA="0x2021970")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10899DC", Offset="0x10899DC")]
		public RefreshTowerRequest(RefreshTowerRequest other)
		{
		}

		[Address(RVA="0x2021C94", Offset="0x2021C94", VA="0x2021C94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A4C", Offset="0x1089A4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x20219FC", Offset="0x20219FC", VA="0x20219FC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10899EC", Offset="0x10899EC")]
		public RefreshTowerRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2021A5C", Offset="0x2021A5C", VA="0x2021A5C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10899FC", Offset="0x10899FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2021AD0", Offset="0x2021AD0", VA="0x2021AD0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A0C", Offset="0x1089A0C")]
		public bool Equals(RefreshTowerRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2021B34", Offset="0x2021B34", VA="0x2021B34", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A1C", Offset="0x1089A1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2021D24", Offset="0x2021D24", VA="0x2021D24", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A5C", Offset="0x1089A5C")]
		public void MergeFrom(RefreshTowerRequest other)
		{
		}

		[Address(RVA="0x2021DD8", Offset="0x2021DD8", VA="0x2021DD8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A6C", Offset="0x1089A6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2021B8C", Offset="0x2021B8C", VA="0x2021B8C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A2C", Offset="0x1089A2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2021BF4", Offset="0x2021BF4", VA="0x2021BF4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A3C", Offset="0x1089A3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C98", Offset="0x1050C98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshTowerRequest.<>c <>9;

			[Address(RVA="0x2021F8C", Offset="0x2021F8C", VA="0x2021F8C")]
			static <>c()
			{
			}

			[Address(RVA="0x2021FF0", Offset="0x2021FF0", VA="0x2021FF0")]
			public <>c()
			{
			}

			[Address(RVA="0x2021FF8", Offset="0x2021FF8", VA="0x2021FF8")]
			internal RefreshTowerRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}