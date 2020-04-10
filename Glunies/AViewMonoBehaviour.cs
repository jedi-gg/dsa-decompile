using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies
{
	public abstract class AViewMonoBehaviour : MonoBehaviour
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064410", Offset="0x1064410")]
		[FieldOffset(Offset="0x18")]
		private Action<AudioClipGroup> PlayAudioEvent;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064420", Offset="0x1064420")]
		[FieldOffset(Offset="0x20")]
		private Action<AudioClipGroup> StopAudioEvent;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064430", Offset="0x1064430")]
		[FieldOffset(Offset="0x28")]
		private Action<AudioClipGroup> PlayAudioMusicEvent;

		public abstract ViewSerializedFields SerializedFields
		{
			get;
		}

		public virtual bool UseFontMapping
		{
			[Address(RVA="0x14F98E4", Offset="0x14F98E4", VA="0x14F98E4", Slot="5")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x14EC654", Offset="0x14EC654", VA="0x14EC654")]
		protected AViewMonoBehaviour()
		{
		}

		[Address(RVA="0x14F9A48", Offset="0x14F9A48", VA="0x14F9A48")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x14F98EC", Offset="0x14F98EC", VA="0x14F98EC")]
		public void PlayAudio(AudioClipGroup audio)
		{
		}

		[Address(RVA="0x14F99D4", Offset="0x14F99D4", VA="0x14F99D4", Slot="6")]
		public virtual void PlayMusic(AudioClipGroup audio)
		{
		}

		[Address(RVA="0x14F9960", Offset="0x14F9960", VA="0x14F9960")]
		public void StopAudio(AudioClipGroup audio)
		{
		}

		public event Action<AudioClipGroup> PlayAudioEvent
		{
			[Address(RVA="0x14F9620", Offset="0x14F9620", VA="0x14F9620")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A434", Offset="0x108A434")]
			add
			{
			}
			[Address(RVA="0x14F7A48", Offset="0x14F7A48", VA="0x14F7A48")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A444", Offset="0x108A444")]
			remove
			{
			}
		}

		public event Action<AudioClipGroup> PlayAudioMusicEvent
		{
			[Address(RVA="0x14F97F8", Offset="0x14F97F8", VA="0x14F97F8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A474", Offset="0x108A474")]
			add
			{
			}
			[Address(RVA="0x14F7C20", Offset="0x14F7C20", VA="0x14F7C20")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A484", Offset="0x108A484")]
			remove
			{
			}
		}

		public event Action<AudioClipGroup> StopAudioEvent
		{
			[Address(RVA="0x14F970C", Offset="0x14F970C", VA="0x14F970C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A454", Offset="0x108A454")]
			add
			{
			}
			[Address(RVA="0x14F7B34", Offset="0x14F7B34", VA="0x14F7B34")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A464", Offset="0x108A464")]
			remove
			{
			}
		}
	}
}