using System;

namespace Csdk.GluAds.Implementation
{
	public interface ISerializableJsonObject
	{
		void WriteObject(JsonStringer json);
	}
}