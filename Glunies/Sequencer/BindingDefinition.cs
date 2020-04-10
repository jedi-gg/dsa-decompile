using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class BindingDefinition : ScriptableObject
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private string _name;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private BindingValueType _valueType;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private string _enumType;

		public string EnumType
		{
			[Address(RVA="0x152E6FC", Offset="0x152E6FC", VA="0x152E6FC")]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[Address(RVA="0x152E6F4", Offset="0x152E6F4", VA="0x152E6F4")]
			get
			{
				return null;
			}
		}

		public BindingValueType ValueType
		{
			[Address(RVA="0x152E2C8", Offset="0x152E2C8", VA="0x152E2C8")]
			get
			{
				return new BindingValueType();
			}
		}

		[Address(RVA="0x152E704", Offset="0x152E704", VA="0x152E704")]
		public BindingDefinition()
		{
		}
	}
}