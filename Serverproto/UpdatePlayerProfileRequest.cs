using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UpdatePlayerProfileRequest : IMessage<UpdatePlayerProfileRequest>, IMessage, IEquatable<UpdatePlayerProfileRequest>, IDeepCloneable<UpdatePlayerProfileRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UpdatePlayerProfileRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NewUsernameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string newUsername_;

		[FieldOffset(Offset="0x0")]
		public const int NewAvatarIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong newAvatarId_;

		[FieldOffset(Offset="0x0")]
		public const int ShowVipBgFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool showVipBg_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A580", Offset="0x109A580")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B7D3C", Offset="0x14B7D3C", VA="0x14B7D3C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A5B0", Offset="0x109A5B0")]
		public ulong NewAvatarId
		{
			[Address(RVA="0x14B8050", Offset="0x14B8050", VA="0x14B8050")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B8058", Offset="0x14B8058", VA="0x14B8058")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A5A0", Offset="0x109A5A0")]
		public string NewUsername
		{
			[Address(RVA="0x14B7FD8", Offset="0x14B7FD8", VA="0x14B7FD8")]
			get
			{
				return null;
			}
			[Address(RVA="0x14B7FE0", Offset="0x14B7FE0", VA="0x14B7FE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A570", Offset="0x109A570")]
		public static MessageParser<UpdatePlayerProfileRequest> Parser
		{
			[Address(RVA="0x14B7CD4", Offset="0x14B7CD4", VA="0x14B7CD4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A590", Offset="0x109A590")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B7E2C", Offset="0x14B7E2C", VA="0x14B7E2C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A5C0", Offset="0x109A5C0")]
		public bool ShowVipBg
		{
			[Address(RVA="0x14B8060", Offset="0x14B8060", VA="0x14B8060")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14B8068", Offset="0x14B8068", VA="0x14B8068")]
			set
			{
			}
		}

		[Address(RVA="0x14B868C", Offset="0x14B868C", VA="0x14B868C")]
		static UpdatePlayerProfileRequest()
		{
		}

		[Address(RVA="0x14B7E88", Offset="0x14B7E88", VA="0x14B7E88")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108469C", Offset="0x108469C")]
		public UpdatePlayerProfileRequest()
		{
		}

		[Address(RVA="0x14B7EE0", Offset="0x14B7EE0", VA="0x14B7EE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10846AC", Offset="0x10846AC")]
		public UpdatePlayerProfileRequest(UpdatePlayerProfileRequest other)
		{
		}

		[Address(RVA="0x14B8420", Offset="0x14B8420", VA="0x14B8420", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108471C", Offset="0x108471C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B7F78", Offset="0x14B7F78", VA="0x14B7F78", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10846BC", Offset="0x10846BC")]
		public UpdatePlayerProfileRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x14B8074", Offset="0x14B8074", VA="0x14B8074", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10846CC", Offset="0x10846CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B80E8", Offset="0x14B80E8", VA="0x14B80E8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10846DC", Offset="0x10846DC")]
		public bool Equals(UpdatePlayerProfileRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x14B817C", Offset="0x14B817C", VA="0x14B817C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10846EC", Offset="0x10846EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B8528", Offset="0x14B8528", VA="0x14B8528", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108472C", Offset="0x108472C")]
		public void MergeFrom(UpdatePlayerProfileRequest other)
		{
		}

		[Address(RVA="0x14B85AC", Offset="0x14B85AC", VA="0x14B85AC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108473C", Offset="0x108473C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B824C", Offset="0x14B824C", VA="0x14B824C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10846FC", Offset="0x10846FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B82B4", Offset="0x14B82B4", VA="0x14B82B4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108470C", Offset="0x108470C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10504F8", Offset="0x10504F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UpdatePlayerProfileRequest.<>c <>9;

			[Address(RVA="0x14B8764", Offset="0x14B8764", VA="0x14B8764")]
			static <>c()
			{
			}

			[Address(RVA="0x14B87C8", Offset="0x14B87C8", VA="0x14B87C8")]
			public <>c()
			{
			}

			[Address(RVA="0x14B87D0", Offset="0x14B87D0", VA="0x14B87D0")]
			internal UpdatePlayerProfileRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}