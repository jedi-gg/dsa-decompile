using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DeviceInfo : IMessage<DeviceInfo>, IMessage, IEquatable<DeviceInfo>, IDeepCloneable<DeviceInfo>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DeviceInfo> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlatformFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private DevicePlatform platform_;

		[FieldOffset(Offset="0x0")]
		public const int IosGenerationFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong iosGeneration_;

		[FieldOffset(Offset="0x0")]
		public const int GpuNameFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string gpuName_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091650", Offset="0x1091650")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FB9D70", Offset="0x1FB9D70", VA="0x1FB9D70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091690", Offset="0x1091690")]
		public string GpuName
		{
			[Address(RVA="0x1FBA02C", Offset="0x1FBA02C", VA="0x1FBA02C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FBA034", Offset="0x1FBA034", VA="0x1FBA034")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091680", Offset="0x1091680")]
		public ulong IosGeneration
		{
			[Address(RVA="0x1FBA01C", Offset="0x1FBA01C", VA="0x1FBA01C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FBA024", Offset="0x1FBA024", VA="0x1FBA024")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091640", Offset="0x1091640")]
		public static MessageParser<DeviceInfo> Parser
		{
			[Address(RVA="0x1FB9D08", Offset="0x1FB9D08", VA="0x1FB9D08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091660", Offset="0x1091660")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FB9E60", Offset="0x1FB9E60", VA="0x1FB9E60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091670", Offset="0x1091670")]
		public DevicePlatform Platform
		{
			[Address(RVA="0x1FBA00C", Offset="0x1FBA00C", VA="0x1FBA00C")]
			get
			{
				return new DevicePlatform();
			}
			[Address(RVA="0x1FBA014", Offset="0x1FBA014", VA="0x1FBA014")]
			set
			{
			}
		}

		[Address(RVA="0x1FBA6C8", Offset="0x1FBA6C8", VA="0x1FBA6C8")]
		static DeviceInfo()
		{
		}

		[Address(RVA="0x1FB9EBC", Offset="0x1FB9EBC", VA="0x1FB9EBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107529C", Offset="0x107529C")]
		public DeviceInfo()
		{
		}

		[Address(RVA="0x1FB9F14", Offset="0x1FB9F14", VA="0x1FB9F14")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10752AC", Offset="0x10752AC")]
		public DeviceInfo(DeviceInfo other)
		{
		}

		[Address(RVA="0x1FBA43C", Offset="0x1FBA43C", VA="0x1FBA43C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107531C", Offset="0x107531C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FB9FAC", Offset="0x1FB9FAC", VA="0x1FB9FAC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10752BC", Offset="0x10752BC")]
		public DeviceInfo Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBA0A4", Offset="0x1FBA0A4", VA="0x1FBA0A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10752CC", Offset="0x10752CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBA118", Offset="0x1FBA118", VA="0x1FBA118", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10752DC", Offset="0x10752DC")]
		public bool Equals(DeviceInfo other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBA19C", Offset="0x1FBA19C", VA="0x1FBA19C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10752EC", Offset="0x10752EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBA568", Offset="0x1FBA568", VA="0x1FBA568", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107532C", Offset="0x107532C")]
		public void MergeFrom(DeviceInfo other)
		{
		}

		[Address(RVA="0x1FBA5EC", Offset="0x1FBA5EC", VA="0x1FBA5EC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107533C", Offset="0x107533C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBA26C", Offset="0x1FBA26C", VA="0x1FBA26C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10752FC", Offset="0x10752FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBA2D4", Offset="0x1FBA2D4", VA="0x1FBA2D4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107530C", Offset="0x107530C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EE88", Offset="0x104EE88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DeviceInfo.<>c <>9;

			[Address(RVA="0x1FBA7A0", Offset="0x1FBA7A0", VA="0x1FBA7A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBA804", Offset="0x1FBA804", VA="0x1FBA804")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBA80C", Offset="0x1FBA80C", VA="0x1FBA80C")]
			internal DeviceInfo <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}