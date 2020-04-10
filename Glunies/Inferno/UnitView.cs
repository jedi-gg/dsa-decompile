using Glunies;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class UnitView : AStandardView, IDispatchHandler<DMenuToggleAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064BE4", Offset="0x1064BE4")]
		[FieldOffset(Offset="0x68")]
		private AssetManifestController _assetManifest;

		[Attribute(Name="InjectAttribute", RVA="0x1064BF4", Offset="0x1064BF4")]
		[FieldOffset(Offset="0x70")]
		private AssetIdCache _assetIdCache;

		private UnitView.SerializedFields Fields
		{
			[Address(RVA="0x15264B0", Offset="0x15264B0", VA="0x15264B0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1526AAC", Offset="0x1526AAC", VA="0x1526AAC")]
		public UnitView()
		{
		}

		[Address(RVA="0x152684C", Offset="0x152684C", VA="0x152684C")]
		private void BindUnitSelectData(WrappedScrollRectListItem listItem, int listItemIndex)
		{
		}

		[Address(RVA="0x1526590", Offset="0x1526590", VA="0x1526590", Slot="21")]
		public void HandleDispatchAction(DMenuToggleAction action)
		{
		}

		[Address(RVA="0x1526418", Offset="0x1526418", VA="0x1526418")]
		public void HideUnitDetails()
		{
		}

		[Address(RVA="0x1526238", Offset="0x1526238", VA="0x1526238")]
		public void ShowUnitDetails(DUnitDisplayData displayData)
		{
		}

		[Address(RVA="0x15269D0", Offset="0x15269D0", VA="0x15269D0")]
		private void UnitSelected(string unitAssetId)
		{
		}

		[Address(RVA="0x1526A44", Offset="0x1526A44", VA="0x1526A44")]
		private void UnloadUnitClicked()
		{
		}

		[Address(RVA="0x15265F4", Offset="0x15265F4", VA="0x15265F4", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x1526790", Offset="0x1526790", VA="0x1526790", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			[SerializeField]
			public UnityEngine.GameObject UnitUnloadedContainer;

			[FieldOffset(Offset="0x30")]
			[SerializeField]
			public WrappedScrollRect UnitSelectList;

			[FieldOffset(Offset="0x38")]
			[SerializeField]
			public UnityEngine.GameObject UnitLoadedContainer;

			[FieldOffset(Offset="0x40")]
			[SerializeField]
			public TextMeshProUGUI UnitNameLabel;

			[FieldOffset(Offset="0x48")]
			[SerializeField]
			public TextMeshProUGUI UnitVertCountLabel;

			[FieldOffset(Offset="0x50")]
			[SerializeField]
			public TextMeshProUGUI UnitTriCountLabel;

			[FieldOffset(Offset="0x58")]
			[SerializeField]
			public Button UnloadUnitButton;

			[Address(RVA="0x1526AB4", Offset="0x1526AB4", VA="0x1526AB4")]
			public SerializedFields()
			{
			}
		}
	}
}