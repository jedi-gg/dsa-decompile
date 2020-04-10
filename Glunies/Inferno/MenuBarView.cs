using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class MenuBarView : AStandardView
	{
		private MenuBarView.SerializedFields Fields
		{
			[Address(RVA="0x15254B0", Offset="0x15254B0", VA="0x15254B0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1525590", Offset="0x1525590", VA="0x1525590")]
		public MenuBarView()
		{
		}

		[Address(RVA="0x1525460", Offset="0x1525460", VA="0x1525460", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			[SerializeField]
			private UnityEngine.GameObject _menuBar;

			public UnityEngine.GameObject MenuBar
			{
				[Address(RVA="0x1525598", Offset="0x1525598", VA="0x1525598")]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x15255A0", Offset="0x15255A0", VA="0x15255A0")]
			public SerializedFields()
			{
			}
		}
	}
}