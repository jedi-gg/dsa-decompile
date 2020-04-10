using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class ZenjectBinding : MonoBehaviour
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1060570", Offset="0x1060570")]
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private Component[] _components;

		[Attribute(Name="TooltipAttribute", RVA="0x10605BC", Offset="0x10605BC")]
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private string _identifier;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1060608", Offset="0x1060608")]
		[Attribute(Name="TooltipAttribute", RVA="0x1060608", Offset="0x1060608")]
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private Zenject.Context _context;

		[Attribute(Name="TooltipAttribute", RVA="0x1060678", Offset="0x1060678")]
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private ZenjectBinding.BindTypes _bindType;

		public ZenjectBinding.BindTypes BindType
		{
			[Address(RVA="0x2340434", Offset="0x2340434", VA="0x2340434")]
			get
			{
				return new ZenjectBinding.BindTypes();
			}
		}

		public Component[] Components
		{
			[Address(RVA="0x2340424", Offset="0x2340424", VA="0x2340424")]
			get
			{
				return null;
			}
		}

		public Zenject.Context Context
		{
			[Address(RVA="0x234041C", Offset="0x234041C", VA="0x234041C")]
			get
			{
				return null;
			}
		}

		public string Identifier
		{
			[Address(RVA="0x234042C", Offset="0x234042C", VA="0x234042C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2340440", Offset="0x2340440", VA="0x2340440")]
		public ZenjectBinding()
		{
		}

		[Address(RVA="0x234043C", Offset="0x234043C", VA="0x234043C")]
		public void Start()
		{
		}

		public enum BindTypes
		{
			[FieldOffset(Offset="0x0")]
			Self,
			[FieldOffset(Offset="0x0")]
			AllInterfaces,
			[FieldOffset(Offset="0x0")]
			AllInterfacesAndSelf,
			[FieldOffset(Offset="0x0")]
			BaseType
		}
	}
}