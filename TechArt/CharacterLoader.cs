using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace TechArt
{
	public class CharacterLoader : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private bool disableViewerLight;

		[Attribute(Name="RangeAttribute", RVA="0x1069504", Offset="0x1069504")]
		[FieldOffset(Offset="0x1C")]
		[SerializeField]
		private int LightRot;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private bool autoRotateLight;

		[FieldOffset(Offset="0x24")]
		[SerializeField]
		private float lightRotationSpeed;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private int EnvironmentIndex;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		public string envString;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private int CharIndex;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		public string charString;

		[FieldOffset(Offset="0x0")]
		private static string charStringRootPath;

		[FieldOffset(Offset="0x8")]
		private static string charStringname;

		[FieldOffset(Offset="0x10")]
		private static bool isCharLoaded;

		[FieldOffset(Offset="0x48")]
		private GameObject directionalLightRoot;

		[FieldOffset(Offset="0x50")]
		private List<string> EnvironmentGUIDs;

		[FieldOffset(Offset="0x58")]
		private GameObject internalObjRef;

		[FieldOffset(Offset="0x60")]
		private GameObject characterHolderObj;

		[FieldOffset(Offset="0x18")]
		private static string lastLoadedCharName;

		[FieldOffset(Offset="0x68")]
		private Vector3 dirLightDefaultRotation;

		[FieldOffset(Offset="0x78")]
		private GameObject characterGroundPlane;

		[Address(RVA="0x132255C", Offset="0x132255C", VA="0x132255C")]
		static CharacterLoader()
		{
		}

		[Address(RVA="0x13224D0", Offset="0x13224D0", VA="0x13224D0")]
		public CharacterLoader()
		{
		}

		[Address(RVA="0x1322204", Offset="0x1322204", VA="0x1322204")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108B044", Offset="0x108B044")]
		private IEnumerator CleanOutLastCharacter()
		{
			return null;
		}

		[Address(RVA="0x1322278", Offset="0x1322278", VA="0x1322278")]
		public void DestroyLastCharObject()
		{
		}

		[Address(RVA="0x1322084", Offset="0x1322084", VA="0x1322084")]
		public bool InstantiateNextCharObject()
		{
			return new bool();
		}

		[Address(RVA="0x1321E90", Offset="0x1321E90", VA="0x1321E90")]
		public bool LoadEnv()
		{
			return new bool();
		}

		[Address(RVA="0x13223A4", Offset="0x13223A4", VA="0x13223A4")]
		private void OnGUI()
		{
		}

		[Address(RVA="0x1321B94", Offset="0x1321B94", VA="0x1321B94")]
		private void Start()
		{
		}

		[Address(RVA="0x1321F8C", Offset="0x1321F8C", VA="0x1321F8C")]
		public void UnLoadEnv()
		{
		}

		[Address(RVA="0x1321C54", Offset="0x1321C54", VA="0x1321C54")]
		private void Update()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051508", Offset="0x1051508")]
		private sealed class <CleanOutLastCharacter>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			public CharacterLoader <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x1322690", Offset="0x1322690", VA="0x1322690", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1322700", Offset="0x1322700", VA="0x1322700", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1322378", Offset="0x1322378", VA="0x1322378")]
			[DebuggerHidden]
			public <CleanOutLastCharacter>d__24(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x13225DC", Offset="0x13225DC", VA="0x13225DC", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1322698", Offset="0x1322698", VA="0x1322698", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x13225D8", Offset="0x13225D8", VA="0x13225D8", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}