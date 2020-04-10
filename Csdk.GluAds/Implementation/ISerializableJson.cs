using System;

namespace Csdk.GluAds.Implementation
{
	public interface ISerializableJson
	{
		void Write(JsonStringer json, string key);
	}
}