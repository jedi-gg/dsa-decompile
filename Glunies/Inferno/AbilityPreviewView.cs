using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class AbilityPreviewView : AStandardView, IDispatchHandler<DMenuToggleAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x10647A8", Offset="0x10647A8")]
		[FieldOffset(Offset="0x68")]
		private AssetManifestController _assetManifest;

		[Attribute(Name="InjectAttribute", RVA="0x10647B8", Offset="0x10647B8")]
		[FieldOffset(Offset="0x70")]
		private AssetIdCache _assetIdCache;

		[FieldOffset(Offset="0x78")]
		private List<string> _previewAssetIds;

		private AbilityPreviewView.SerializedFields Fields
		{
			[Address(RVA="0x142E2FC", Offset="0x142E2FC", VA="0x142E2FC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x142EF58", Offset="0x142EF58", VA="0x142EF58")]
		public AbilityPreviewView()
		{
		}

		[Address(RVA="0x142EA2C", Offset="0x142EA2C", VA="0x142EA2C")]
		private void BindPreviewSelectData(WrappedScrollRectListItem listItem, int listItemIndex)
		{
		}

		[Address(RVA="0x142E088", Offset="0x142E088", VA="0x142E088")]
		public void ClearPreviews()
		{
		}

		[Address(RVA="0x142E4E4", Offset="0x142E4E4", VA="0x142E4E4", Slot="21")]
		public void HandleDispatchAction(DMenuToggleAction action)
		{
		}

		[Address(RVA="0x142EBB8", Offset="0x142EBB8", VA="0x142EBB8")]
		private void LoadPreview(string previewAssetId)
		{
		}

		[Address(RVA="0x142ED04", Offset="0x142ED04", VA="0x142ED04")]
		private void PlayPreview()
		{
		}

		[Address(RVA="0x142EC64", Offset="0x142EC64", VA="0x142EC64")]
		private void ReloadPreview()
		{
		}

		[Address(RVA="0x142DE38", Offset="0x142DE38", VA="0x142DE38")]
		public void SetPreviews(List<string> simAssetIds)
		{
		}

		[Address(RVA="0x142DE3C", Offset="0x142DE3C", VA="0x142DE3C")]
		public void ShowLoadedPreview(bool showLoaded, AbilityPreview preview = // 
		// Current member / type: System.Void Glunies.Inferno.AbilityPreviewView::ShowLoadedPreview(System.Boolean,Glunies.Inferno.AbilityPreview)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ShowLoadedPreview(System.Boolean,Glunies.Inferno.AbilityPreview)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x142EEF4", Offset="0x142EEF4", VA="0x142EEF4")]
		private void ToggleInterrupt(bool isOn)
		{
		}

		[Address(RVA="0x142EE54", Offset="0x142EE54", VA="0x142EE54")]
		private void UnloadPreview()
		{
		}

		[Address(RVA="0x142E3DC", Offset="0x142E3DC", VA="0x142E3DC")]
		private void UpdatePreviewAssetIds(List<string> assetIds)
		{
		}

		[Address(RVA="0x142E548", Offset="0x142E548", VA="0x142E548", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x142E898", Offset="0x142E898", VA="0x142E898", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			[SerializeField]
			public UnityEngine.GameObject PreviewUnloadedContainer;

			[FieldOffset(Offset="0x30")]
			[SerializeField]
			public WrappedScrollRect PreviewSelectList;

			[FieldOffset(Offset="0x38")]
			[SerializeField]
			public UnityEngine.GameObject PreviewLoadedContainer;

			[FieldOffset(Offset="0x40")]
			[SerializeField]
			public TextMeshProUGUI PreviewNameLabel;

			[FieldOffset(Offset="0x48")]
			[SerializeField]
			public TextMeshProUGUI PreviewDurationLabel;

			[FieldOffset(Offset="0x50")]
			[SerializeField]
			public Toggle InterruptToggle;

			[FieldOffset(Offset="0x58")]
			[SerializeField]
			public TMP_InputField InterruptAtInputS;

			[FieldOffset(Offset="0x60")]
			[SerializeField]
			public Button PlayButton;

			[FieldOffset(Offset="0x68")]
			[SerializeField]
			public Button ReloadPreview;

			[FieldOffset(Offset="0x70")]
			[SerializeField]
			public Button UnloadPreview;

			[Address(RVA="0x151C438", Offset="0x151C438", VA="0x151C438")]
			public SerializedFields()
			{
			}
		}
	}
}