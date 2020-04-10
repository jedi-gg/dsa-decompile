using System;

namespace Csdk.GluAppTracking.Implementation
{
	public interface ISerializableJsonObject
	{
		void WriteObject(JsonStringer json);
	}
}