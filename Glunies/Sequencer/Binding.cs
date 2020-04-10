using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Serializable]
	public class Binding
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private BindingDefinition _bindingDef;

		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private BindingDefinition _bindingDefValue;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private int _intValue;

		[FieldOffset(Offset="0x24")]
		[SerializeField]
		private float _floatValue;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private string _stringValue;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private Vector3 _vector3Value;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private UnityEngine.Object _objectValue;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private bool _instantiateObj;

		[FieldOffset(Offset="0x4C")]
		[SerializeField]
		private Color _colorValue;

		[FieldOffset(Offset="0x5C")]
		[SerializeField]
		private bool _boolValue;

		[FieldOffset(Offset="0x60")]
		private UnityEngine.Object _objectInstance;

		public BindingDefinition BindingDefValue
		{
			[Address(RVA="0x152DF78", Offset="0x152DF78", VA="0x152DF78")]
			get
			{
				return null;
			}
			[Address(RVA="0x152DF80", Offset="0x152DF80", VA="0x152DF80")]
			set
			{
			}
		}

		public bool BoolValue
		{
			[Address(RVA="0x152E000", Offset="0x152E000", VA="0x152E000")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x152E008", Offset="0x152E008", VA="0x152E008")]
			set
			{
			}
		}

		public Color ColorValue
		{
			[Address(RVA="0x152DFE8", Offset="0x152DFE8", VA="0x152DFE8")]
			get
			{
				return new Color();
			}
			[Address(RVA="0x152DFF4", Offset="0x152DFF4", VA="0x152DFF4")]
			set
			{
			}
		}

		public float FloatValue
		{
			[Address(RVA="0x152DF98", Offset="0x152DF98", VA="0x152DF98")]
			get
			{
				return new float();
			}
			[Address(RVA="0x152DFA0", Offset="0x152DFA0", VA="0x152DFA0")]
			set
			{
			}
		}

		public int IntValue
		{
			[Address(RVA="0x152DF88", Offset="0x152DF88", VA="0x152DF88")]
			get
			{
				return new int();
			}
			[Address(RVA="0x152DF90", Offset="0x152DF90", VA="0x152DF90")]
			set
			{
			}
		}

		public UnityEngine.Object ObjectValue
		{
			[Address(RVA="0x152DFD0", Offset="0x152DFD0", VA="0x152DFD0")]
			get
			{
				return null;
			}
			[Address(RVA="0x152DFD8", Offset="0x152DFD8", VA="0x152DFD8")]
			set
			{
			}
		}

		public UnityEngine.Object RawObjectValue
		{
			[Address(RVA="0x152DFE0", Offset="0x152DFE0", VA="0x152DFE0")]
			get
			{
				return null;
			}
		}

		public string StringValue
		{
			[Address(RVA="0x152DFA8", Offset="0x152DFA8", VA="0x152DFA8")]
			get
			{
				return null;
			}
			[Address(RVA="0x152DFB0", Offset="0x152DFB0", VA="0x152DFB0")]
			set
			{
			}
		}

		public Vector3 Vector3Value
		{
			[Address(RVA="0x152DFB8", Offset="0x152DFB8", VA="0x152DFB8")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x152DFC4", Offset="0x152DFC4", VA="0x152DFC4")]
			set
			{
			}
		}

		[Address(RVA="0x152E6A0", Offset="0x152E6A0", VA="0x152E6A0")]
		public Binding()
		{
		}

		[Address(RVA="0x152E6A8", Offset="0x152E6A8", VA="0x152E6A8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A8F0", Offset="0x108A8F0")]
		private bool <ResolveSubObject>b__28_0(Binding b)
		{
			return new bool();
		}

		[Address(RVA="0x16A9A7C", Offset="0x16A9A7C", VA="0x16A9A7C")]
		public T GetObject<T>()
		where T : UnityEngine.Object
		{
			return null;
		}

		[Address(RVA="0x152E014", Offset="0x152E014", VA="0x152E014")]
		public void Initialize(Transform parent)
		{
		}

		[Address(RVA="0x152AF78", Offset="0x152AF78", VA="0x152AF78")]
		public bool IsBoundTo(BindingDefinition bindingDef)
		{
			return new bool();
		}

		[Address(RVA="0x152E2D0", Offset="0x152E2D0", VA="0x152E2D0")]
		public void ResolveSubObject(List<Binding> bindings, string sequencerName)
		{
		}
	}
}