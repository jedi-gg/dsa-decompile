using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Glunies.Audio
{
	public class AudioSystem : ILoggable<LogCategory>, IAssetDependentLifecycleObject, IDispatchHandler<DAudioEventPlayAction>, IDispatchHandler, IDispatchHandler<DAudioEventStopAction>, IDispatchHandler<DAudioMusicEventPlayAction>, IDispatchHandler<DAudioMusicEventStopAction>, IDispatchHandler<DAudioSettingsChangedAction>, IDispatchHandler<DAudioSnapshotAction>
	{
		[FieldOffset(Offset="0x0")]
		public const string SNAPSHOT_MAIN = "Main";

		[FieldOffset(Offset="0x0")]
		public const string SNAPSHOT_PAUSED = "Paused";

		[FieldOffset(Offset="0x0")]
		public const string SNAPSHOT_MUTED = "Muted";

		[FieldOffset(Offset="0x0")]
		public const string SNAPSHOT_POST_ENV = "PostEnv";

		[FieldOffset(Offset="0x0")]
		private readonly static string[] s_persistentBundleAssets;

		[Attribute(Name="InjectAttribute", RVA="0x1064684", Offset="0x1064684")]
		[FieldOffset(Offset="0x10")]
		private DispatchSystem _dispatch;

		[Attribute(Name="InjectAttribute", RVA="0x1064694", Offset="0x1064694")]
		[FieldOffset(Offset="0x18")]
		private SharedPrefs _sharedPrefs;

		[Attribute(Name="InjectAttribute", RVA="0x10646A4", Offset="0x10646A4")]
		[FieldOffset(Offset="0x20")]
		private SingleAssetRegistry _audioMixerAssetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x10646B4", Offset="0x10646B4")]
		[FieldOffset(Offset="0x28")]
		private AssetRegistry _persistentBundleAssetRegistry;

		[FieldOffset(Offset="0x30")]
		private bool _initialized;

		[FieldOffset(Offset="0x38")]
		private AudioMixer _audioMixer;

		[FieldOffset(Offset="0x40")]
		private AudioMixerGroup _fallbackMixerGroup;

		[FieldOffset(Offset="0x48")]
		private GameObject _audioSystemObject;

		[FieldOffset(Offset="0x50")]
		private Queue<AudioEvent> _inactiveAudio;

		[FieldOffset(Offset="0x58")]
		private List<AudioEvent> _activeAudio;

		[FieldOffset(Offset="0x60")]
		private Queue<AudioEvent> _inactiveMusic;

		[FieldOffset(Offset="0x68")]
		private List<AudioEvent> _activeMusic;

		[FieldOffset(Offset="0x70")]
		private List<AudioEvent> _activeMusicTransitioningToBackupLoop;

		[FieldOffset(Offset="0x78")]
		private bool _persistentBundlesSafeToOpen;

		[FieldOffset(Offset="0x79")]
		private bool _persistentBundlesHaveBeenOpened;

		public int ActiveAudioCount
		{
			[Address(RVA="0x1416EF8", Offset="0x1416EF8", VA="0x1416EF8")]
			get
			{
				return new int();
			}
		}

		public int ActiveMusicCount
		{
			[Address(RVA="0x1416F58", Offset="0x1416F58", VA="0x1416F58")]
			get
			{
				return new int();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x1416EF0", Offset="0x1416EF0", VA="0x1416EF0", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1418B68", Offset="0x1418B68", VA="0x1418B68")]
		static AudioSystem()
		{
		}

		[Address(RVA="0x1418B60", Offset="0x1418B60", VA="0x1418B60")]
		public AudioSystem()
		{
		}

		[Address(RVA="0x1418984", Offset="0x1418984", VA="0x1418984")]
		private void AudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		[Address(RVA="0x1418038", Offset="0x1418038", VA="0x1418038")]
		private bool EvictLowerPriorityAudio(DAudioEventPlayAction action)
		{
			return new bool();
		}

		[Address(RVA="0x1417D00", Offset="0x1417D00", VA="0x1417D00", Slot="9")]
		public void HandleDispatchAction(DAudioEventPlayAction action)
		{
		}

		[Address(RVA="0x141815C", Offset="0x141815C", VA="0x141815C", Slot="10")]
		public void HandleDispatchAction(DAudioEventStopAction action)
		{
		}

		[Address(RVA="0x141829C", Offset="0x141829C", VA="0x141829C", Slot="11")]
		public void HandleDispatchAction(DAudioMusicEventPlayAction action)
		{
		}

		[Address(RVA="0x1418638", Offset="0x1418638", VA="0x1418638", Slot="12")]
		public void HandleDispatchAction(DAudioMusicEventStopAction action)
		{
		}

		[Address(RVA="0x14186FC", Offset="0x14186FC", VA="0x14186FC", Slot="13")]
		public void HandleDispatchAction(DAudioSettingsChangedAction action)
		{
		}

		[Address(RVA="0x1418864", Offset="0x1418864", VA="0x1418864", Slot="14")]
		public void HandleDispatchAction(DAudioSnapshotAction action)
		{
		}

		[Address(RVA="0x1416FB8", Offset="0x1416FB8", VA="0x1416FB8", Slot="5")]
		public void Initialize(Action finished)
		{
		}

		[Address(RVA="0x1417E68", Offset="0x1417E68", VA="0x1417E68")]
		private bool LimitAudioClipGroup(DAudioEventPlayAction action)
		{
			return new bool();
		}

		[Address(RVA="0x14173C8", Offset="0x14173C8", VA="0x14173C8", Slot="7")]
		public void LoadAssets(Action finished)
		{
		}

		[Address(RVA="0x141765C", Offset="0x141765C", VA="0x141765C")]
		public void MarkPersistentBundlesSafeToOpen()
		{
		}

		[Address(RVA="0x14175EC", Offset="0x14175EC", VA="0x14175EC", Slot="8")]
		public void ReleaseAssets()
		{
		}

		[Address(RVA="0x1418A4C", Offset="0x1418A4C", VA="0x1418A4C")]
		private void RemoveActiveAudioAtIndex(int index)
		{
		}

		[Address(RVA="0x1418524", Offset="0x1418524", VA="0x1418524")]
		private void RemoveActiveMusicAtIndex(int index)
		{
		}

		[Address(RVA="0x1418700", Offset="0x1418700", VA="0x1418700")]
		private void SetMixerLevelsFromPrefs()
		{
		}

		[Address(RVA="0x14174C0", Offset="0x14174C0", VA="0x14174C0", Slot="6")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x14178C4", Offset="0x14178C4", VA="0x14178C4")]
		public void TickUpdate()
		{
		}

		[Address(RVA="0x1417674", Offset="0x1417674", VA="0x1417674")]
		private void TryOpenPersistentBundles()
		{
		}

		[Address(RVA="0x1417900", Offset="0x1417900", VA="0x1417900")]
		private void UpdateActiveAudio()
		{
		}

		[Address(RVA="0x14179E0", Offset="0x14179E0", VA="0x14179E0")]
		private void UpdateActiveMusic()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051118", Offset="0x1051118")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public AudioSystem <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action finished;

			[Address(RVA="0x14173C0", Offset="0x14173C0", VA="0x14173C0")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x1418C7C", Offset="0x1418C7C", VA="0x1418C7C")]
			internal void <Initialize>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051128", Offset="0x1051128")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public AudioSystem <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action finished;

			[Address(RVA="0x141771C", Offset="0x141771C", VA="0x141771C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x1418CC8", Offset="0x1418CC8", VA="0x1418CC8")]
			internal void <LoadAssets>b__0(AssetHandle asset)
			{
			}
		}
	}
}