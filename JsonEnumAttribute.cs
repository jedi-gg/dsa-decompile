using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="AttributeUsageAttribute", RVA="0x1048388", Offset="0x1048388")]
public class JsonEnumAttribute : PropertyAttribute
{
	[FieldOffset(Offset="0x10")]
	private Type _enumType;

	public Type EnumType
	{
		[Address(RVA="0x11C7B84", Offset="0x11C7B84", VA="0x11C7B84")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11C7B8C", Offset="0x11C7B8C", VA="0x11C7B8C")]
	public JsonEnumAttribute(Type enumType)
	{
	}
}