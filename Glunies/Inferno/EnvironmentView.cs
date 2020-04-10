using Glunies;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class EnvironmentView : AStandardView, IDispatchHandler<DMenuToggleAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064A20", Offset="0x1064A20")]
		[FieldOffset(Offset="0x68")]
		private AssetManifestController _assetManifest;

		[Attribute(Name="InjectAttribute", RVA="0x1064A30", Offset="0x1064A30")]
		[FieldOffset(Offset="0x70")]
		private AssetIdCache _assetIdCache;

		private EnvironmentView.SerializedFields Fields
		{
			[Address(RVA="0x1523888", Offset="0x1523888", VA="0x1523888")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1523E84", Offset="0x1523E84", VA="0x1523E84")]
		public EnvironmentView()
		{
		}

		[Address(RVA="0x1523C24", Offset="0x1523C24", VA="0x1523C24")]
		private void BindEnvSelectData(WrappedScrollRectListItem listItem, int listItemIndex)
		{
		}

		[Address(RVA="0x1523DA8", Offset="0x1523DA8", VA="0x1523DA8")]
		private void EnvironmentSelected(string envAssetId)
		{
		}

		[Address(RVA="0x1523968", Offset="0x1523968", VA="0x1523968", Slot="21")]
		public void HandleDispatchAction(DMenuToggleAction action)
		{
		}

		[Address(RVA="0x15237F0", Offset="0x15237F0", VA="0x15237F0")]
		public void HideEnvironmentDetails()
		{
		}

		[Address(RVA="0x1523610", Offset="0x1523610", VA="0x1523610")]
		public void ShowEnvironmenentDetails(DEnvironmentDisplayData displayData)
		{
		}

		[Address(RVA="0x1523E1C", Offset="0x1523E1C", VA="0x1523E1C")]
		private void UnloadEnvironmentClicked()
		{
		}

		[Address(RVA="0x15239CC", Offset="0x15239CC", VA="0x15239CC", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x1523B68", Offset="0x1523B68", VA="0x1523B68", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			[SerializeField]
			public UnityEngine.GameObject EnvUnloadedContainer;

			[FieldOffset(Offset="0x30")]
			[SerializeField]
			public WrappedScrollRect EnvSelectList;

			[FieldOffset(Offset="0x38")]
			[SerializeField]
			public UnityEngine.GameObject EnvLoadedContainer;

			[FieldOffset(Offset="0x40")]
			[SerializeField]
			public TextMeshProUGUI EnvNameLabel;

			[FieldOffset(Offset="0x48")]
			[SerializeField]
			public TextMeshProUGUI EnvVertCountLabel;

			[FieldOffset(Offset="0x50")]
			[SerializeField]
			public TextMeshProUGUI EnvTriCountLabel;

			[FieldOffset(Offset="0x58")]
			[SerializeField]
			public Button UnloadEnvButton;

			[Address(RVA="0x1523E8C", Offset="0x1523E8C", VA="0x1523E8C")]
			public SerializedFields()
			{
			}
		}
	}
}