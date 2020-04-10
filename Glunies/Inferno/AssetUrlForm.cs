using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class AssetUrlForm : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		private const string DIALOG_COLOR = "#192126FF";

		[FieldOffset(Offset="0x0")]
		private const string TEXT_COLOR = "#8CB5CFFF";

		[FieldOffset(Offset="0x0")]
		private const string ERROR_TEXT_COLOR = "#DD4A55FF";

		[FieldOffset(Offset="0x0")]
		private const string INPUT_TEXT_COLOR = "#EBECF0FF";

		[FieldOffset(Offset="0x0")]
		private const string PLACEHOLDER_TEXT_COLOR = "#192026FF";

		[FieldOffset(Offset="0x0")]
		private const string INPUT_FIELD_COLOR = "#484D51FF";

		[FieldOffset(Offset="0x0")]
		private const string BUTTON_COLOR = "#1BB0ACFF";

		[FieldOffset(Offset="0x0")]
		private const string LOADING_SCRIM_COLOR = "#192126AA";

		[FieldOffset(Offset="0x0")]
		private const string LOADING_TEXT_COLOR = "#EBECF0FF";

		[FieldOffset(Offset="0x0")]
		private const int MAX_LOADING_DOTS = 3;

		[FieldOffset(Offset="0x18")]
		private Button _submitButton;

		[FieldOffset(Offset="0x20")]
		private InputField _assetUrlInputField;

		[FieldOffset(Offset="0x28")]
		private Text _errorText;

		[FieldOffset(Offset="0x30")]
		private GameObject _loadingScrim;

		[FieldOffset(Offset="0x38")]
		private Text _loadingText;

		[FieldOffset(Offset="0x40")]
		private int _currentNumLoadingDots;

		[Address(RVA="0x151E5B8", Offset="0x151E5B8", VA="0x151E5B8")]
		public AssetUrlForm()
		{
		}

		[Address(RVA="0x151CAC0", Offset="0x151CAC0", VA="0x151CAC0")]
		private void AnimatedLoadingText()
		{
		}

		[Address(RVA="0x151C98C", Offset="0x151C98C", VA="0x151C98C")]
		private void BuildForm()
		{
		}

		[Address(RVA="0x151D674", Offset="0x151D674", VA="0x151D674")]
		private Transform CreateAssetUrlInputContainer(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151CC1C", Offset="0x151CC1C", VA="0x151CC1C")]
		private Transform CreateCanvas()
		{
			return null;
		}

		[Address(RVA="0x151CDC8", Offset="0x151CDC8", VA="0x151CDC8")]
		private Transform CreateDialog(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151D3E0", Offset="0x151D3E0", VA="0x151D3E0")]
		private Text CreateErrorText(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151DFF4", Offset="0x151DFF4", VA="0x151DFF4")]
		private Transform CreateLoadingScrim(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151E2D8", Offset="0x151E2D8", VA="0x151E2D8")]
		private Text CreateLoadingText(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151DD48", Offset="0x151DD48", VA="0x151DD48")]
		private Button CreateSubmitButton(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151D11C", Offset="0x151D11C", VA="0x151D11C")]
		private void CreateTitle(Transform parent)
		{
		}

		[Address(RVA="0x151D8D0", Offset="0x151D8D0", VA="0x151D8D0")]
		private InputField CreateUrlInputField(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x151C884", Offset="0x151C884", VA="0x151C884")]
		public void Initialize(AssetUrlForm.FormSubmitted formSubmitted)
		{
		}

		[Address(RVA="0x151C800", Offset="0x151C800", VA="0x151C800")]
		public void ShowErrorMessage(string errorMessage)
		{
		}

		[Address(RVA="0x151C7C8", Offset="0x151C7C8", VA="0x151C7C8")]
		public void ShowLoading(bool show)
		{
		}

		[Address(RVA="0x151CA2C", Offset="0x151CA2C", VA="0x151CA2C")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x151CA74", Offset="0x151CA74", VA="0x151CA74")]
		private void Update()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10511B8", Offset="0x10511B8")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public AssetUrlForm.FormSubmitted formSubmitted;

			[FieldOffset(Offset="0x18")]
			public AssetUrlForm <>4__this;

			[Address(RVA="0x151C984", Offset="0x151C984", VA="0x151C984")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x151E5C0", Offset="0x151E5C0", VA="0x151E5C0")]
			internal void <Initialize>b__0()
			{
			}
		}

		public delegate void FormSubmitted(string assetUrl);
	}
}