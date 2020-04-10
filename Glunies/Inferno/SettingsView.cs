using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class SettingsView : AView, IDispatchHandler<DMenuToggleAction>, IDispatchHandler
	{
		private SettingsView.SerializedFields Fields
		{
			[Address(RVA="0x1525838", Offset="0x1525838", VA="0x1525838")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1525A10", Offset="0x1525A10", VA="0x1525A10")]
		public SettingsView()
		{
		}

		[Address(RVA="0x15256E8", Offset="0x15256E8", VA="0x15256E8", Slot="21")]
		public void HandleDispatchAction(DMenuToggleAction action)
		{
		}

		[Address(RVA="0x15259AC", Offset="0x15259AC", VA="0x15259AC")]
		private void ReloadAssetsClicked()
		{
		}

		[Address(RVA="0x1525748", Offset="0x1525748", VA="0x1525748", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x1525920", Offset="0x1525920", VA="0x1525920", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			[SerializeField]
			private Button _reloadAssetsButton;

			public Button ReloadAssetsButton
			{
				[Address(RVA="0x1525918", Offset="0x1525918", VA="0x1525918")]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1525A18", Offset="0x1525A18", VA="0x1525A18")]
			public SerializedFields()
			{
			}
		}
	}
}