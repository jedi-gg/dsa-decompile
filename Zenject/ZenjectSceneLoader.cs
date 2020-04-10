using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Zenject
{
	public class ZenjectSceneLoader
	{
		[FieldOffset(Offset="0x10")]
		private readonly ProjectKernel _projectKernel;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _sceneContainer;

		[Address(RVA="0x2340698", Offset="0x2340698", VA="0x2340698")]
		public ZenjectSceneLoader(SceneContext sceneRoot, ProjectKernel projectKernel)
		{
		}

		[Address(RVA="0x23406F0", Offset="0x23406F0", VA="0x23406F0")]
		public void LoadScene(string sceneName)
		{
		}

		[Address(RVA="0x2340704", Offset="0x2340704", VA="0x2340704")]
		public void LoadScene(string sceneName, LoadSceneMode loadMode)
		{
		}

		[Address(RVA="0x2340714", Offset="0x2340714", VA="0x2340714")]
		public void LoadScene(string sceneName, LoadSceneMode loadMode, Action<DiContainer> extraBindings)
		{
		}

		[Address(RVA="0x2340720", Offset="0x2340720", VA="0x2340720")]
		public void LoadScene(string sceneName, LoadSceneMode loadMode, Action<DiContainer> extraBindings, LoadSceneRelationship containerMode)
		{
		}

		[Address(RVA="0x2340728", Offset="0x2340728", VA="0x2340728")]
		public void LoadScene(string sceneName, LoadSceneMode loadMode, Action<DiContainer> extraBindings, LoadSceneRelationship containerMode, Action<DiContainer> extraBindingsLate)
		{
		}

		[Address(RVA="0x23409D8", Offset="0x23409D8", VA="0x23409D8")]
		public AsyncOperation LoadSceneAsync(string sceneName)
		{
			return null;
		}

		[Address(RVA="0x23409EC", Offset="0x23409EC", VA="0x23409EC")]
		public AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadMode)
		{
			return null;
		}

		[Address(RVA="0x23409FC", Offset="0x23409FC", VA="0x23409FC")]
		public AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadMode, Action<DiContainer> extraBindings)
		{
			return null;
		}

		[Address(RVA="0x2340A08", Offset="0x2340A08", VA="0x2340A08")]
		public AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadMode, Action<DiContainer> extraBindings, LoadSceneRelationship containerMode)
		{
			return null;
		}

		[Address(RVA="0x2340A10", Offset="0x2340A10", VA="0x2340A10")]
		public AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadMode, Action<DiContainer> extraBindings, LoadSceneRelationship containerMode, Action<DiContainer> extraBindingsLate)
		{
			return null;
		}

		[Address(RVA="0x23407E0", Offset="0x23407E0", VA="0x23407E0")]
		private void PrepareForLoadScene(LoadSceneMode loadMode, Action<DiContainer> extraBindings, Action<DiContainer> extraBindingsLate, LoadSceneRelationship containerMode)
		{
		}
	}
}