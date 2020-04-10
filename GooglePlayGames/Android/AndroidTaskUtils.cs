using Il2CppDummyDll;
using System;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidTaskUtils
	{
		[Address(RVA="0x1EB48C8", Offset="0x1EB48C8", VA="0x1EB48C8")]
		private AndroidTaskUtils()
		{
		}

		[Address(RVA="0x1388760", Offset="0x1388760", VA="0x1388760")]
		public static void AddOnCompleteListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}

		[Address(RVA="0x1EAC068", Offset="0x1EAC068", VA="0x1EAC068")]
		public static void AddOnFailureListener(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		[Address(RVA="0x1388910", Offset="0x1388910", VA="0x1388910")]
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}

		[Address(RVA="0x1388E2C", Offset="0x1388E2C", VA="0x1388E2C")]
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, bool disposeResult, Action<T> callback)
		{
		}

		private class TaskOnCompleteProxy<T> : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x0")]
			private Action<T> mCallback;

			[Address(RVA="0x1D8D648", Offset="0x1D8D648", VA="0x1D8D648")]
			public TaskOnCompleteProxy(Action<T> callback)
			{
			}

			[Address(RVA="0x1D8D6DC", Offset="0x1D8D6DC", VA="0x1D8D6DC")]
			public void onComplete(T result)
			{
			}
		}

		private class TaskOnFailedProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private Action<AndroidJavaObject> mCallback;

			[Address(RVA="0x1EB48D0", Offset="0x1EB48D0", VA="0x1EB48D0")]
			public TaskOnFailedProxy(Action<AndroidJavaObject> callback)
			{
			}

			[Address(RVA="0x1EB4958", Offset="0x1EB4958", VA="0x1EB4958")]
			public void onFailure(AndroidJavaObject exception)
			{
			}
		}

		private class TaskOnSuccessProxy<T> : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x0")]
			private Action<T> mCallback;

			[FieldOffset(Offset="0x0")]
			private Action<AndroidJavaObject> mCallback2;

			[FieldOffset(Offset="0x0")]
			private bool mDisposeResult;

			[Address(RVA="0x1D8D8D0", Offset="0x1D8D8D0", VA="0x1D8D8D0")]
			public TaskOnSuccessProxy(Action<T> callback, bool disposeResult)
			{
			}

			[Address(RVA="0x1D8D970", Offset="0x1D8D970", VA="0x1D8D970")]
			public void onSuccess(T result)
			{
			}
		}
	}
}