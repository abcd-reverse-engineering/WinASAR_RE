using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000072 RID: 114
	[Nullable(0)]
	[NullableContext(1)]
	[Serializable]
	public class JsonWriterException : JsonException
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00003735 File Offset: 0x00001935
		[Nullable(2)]
		public string Path
		{
			[NullableContext(2)]
			get;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0003E354 File Offset: 0x0003C554
		public JsonWriterException()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0003E388 File Offset: 0x0003C588
		public JsonWriterException(string message)
			: base(message)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0003E3BC File Offset: 0x0003C5BC
		public JsonWriterException(string message, Exception innerException)
			: base(message, innerException)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		public JsonWriterException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0003E424 File Offset: 0x0003C624
		public JsonWriterException(string message, string path, [Nullable(2)] Exception innerException)
			: base(message, innerException)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Path = path;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000373D File Offset: 0x0000193D
		internal static JsonWriterException Create(JsonWriter writer, string message, [Nullable(2)] Exception ex)
		{
			return JsonWriterException.Create(writer.ContainerPath, message, ex);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0003E478 File Offset: 0x0003C678
		internal static JsonWriterException Create(string path, string message, [Nullable(2)] Exception ex)
		{
			for (;;)
			{
				message = JsonPosition.FormatMessage(null, path, message);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
			return new JsonWriterException(message, path, ex);
		}

		// Token: 0x04000304 RID: 772
		[Nullable(2)]
		[CompilerGenerated]
		private readonly string string_0;
	}
}
