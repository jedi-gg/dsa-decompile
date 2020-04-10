using Il2CppDummyDll;
using System;
using System.Text.RegularExpressions;

namespace Zenject
{
	public class ProfileBlock : IDisposable
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A74", Offset="0x1060A74")]
		[FieldOffset(Offset="0x0")]
		private static Regex <ProfilePattern>k__BackingField;

		public static Regex ProfilePattern
		{
			[Address(RVA="0x1842714", Offset="0x1842714", VA="0x1842714")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107405C", Offset="0x107405C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1842764", Offset="0x1842764", VA="0x1842764")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107406C", Offset="0x107406C")]
			set
			{
			}
		}

		[Address(RVA="0x1842704", Offset="0x1842704", VA="0x1842704")]
		private ProfileBlock(string sampleName, bool rootBlock)
		{
		}

		[Address(RVA="0x184270C", Offset="0x184270C", VA="0x184270C")]
		private ProfileBlock(string sampleName)
		{
		}

		[Address(RVA="0x18427D8", Offset="0x18427D8", VA="0x18427D8", Slot="4")]
		public void Dispose()
		{
		}

		[Address(RVA="0x18427B8", Offset="0x18427B8", VA="0x18427B8")]
		public static ProfileBlock Start()
		{
			return null;
		}

		[Address(RVA="0x18427C0", Offset="0x18427C0", VA="0x18427C0")]
		public static ProfileBlock Start(string sampleNameFormat, object obj1, object obj2)
		{
			return null;
		}

		[Address(RVA="0x18427C8", Offset="0x18427C8", VA="0x18427C8")]
		public static ProfileBlock Start(string sampleNameFormat, object obj)
		{
			return null;
		}

		[Address(RVA="0x18427D0", Offset="0x18427D0", VA="0x18427D0")]
		public static ProfileBlock Start(string sampleName)
		{
			return null;
		}
	}
}