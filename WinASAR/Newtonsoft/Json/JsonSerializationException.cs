using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000064 RID: 100
	[Nullable(0)]
	[NullableContext(1)]
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00002DFD File Offset: 0x00000FFD
		public int LineNumber { get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00002E05 File Offset: 0x00001005
		public int LinePosition { get; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00002E0D File Offset: 0x0000100D
		[Nullable(2)]
		public string Path
		{
			[NullableContext(2)]
			get;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0002BDBC File Offset: 0x00029FBC
		public JsonSerializationException()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0002BDF0 File Offset: 0x00029FF0
		public JsonSerializationException(string message)
			: base(message)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0002BE24 File Offset: 0x0002A024
		public JsonSerializationException(string message, Exception innerException)
			: base(message, innerException)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0002BE58 File Offset: 0x0002A058
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0002BE8C File Offset: 0x0002A08C
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, [Nullable(2)] Exception innerException)
			: base(message, innerException)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
			{
				goto IL_0038;
			}
			for (;;)
			{
				IL_0050:
				switch (num)
				{
				case 1:
					this.Path = path;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						continue;
					}
					break;
				case 2:
					return;
				case 3:
					goto IL_0069;
				}
				break;
			}
			IL_0038:
			this.LineNumber = lineNumber;
			num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
			{
				goto IL_0050;
			}
			IL_0069:
			this.LinePosition = linePosition;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002E15 File Offset: 0x00001015
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return JsonSerializationException.Create(reader, message, null);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002E1F File Offset: 0x0000101F
		internal static JsonSerializationException Create(JsonReader reader, string message, [Nullable(2)] Exception ex)
		{
			return JsonSerializationException.Create(reader as IJsonLineInfo, reader.Path, message, ex);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0002BF0C File Offset: 0x0002A10C
		internal static JsonSerializationException Create([Nullable(2)] IJsonLineInfo lineInfo, string path, string message, [Nullable(2)] Exception ex)
		{
			int num2;
			int num3;
			for (;;)
			{
				IL_0080:
				message = JsonPosition.FormatMessage(lineInfo, path, message);
				for (;;)
				{
					if (lineInfo == null)
					{
						goto IL_004F;
					}
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_0047;
					}
					IL_0017:
					switch (num)
					{
					case 1:
					case 7:
						goto IL_009F;
					case 2:
						goto IL_0097;
					case 3:
					case 8:
						goto IL_004F;
					case 4:
						continue;
					case 5:
						goto IL_0080;
					case 6:
						IL_0047:
						if (!lineInfo.HasLineInfo())
						{
							goto IL_004F;
						}
						goto IL_008F;
					case 9:
						goto IL_008F;
					}
					IL_0003:
					num2 = 0;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_0017;
					}
					goto IL_008C;
					IL_004F:
					num3 = 0;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_0003;
					}
					goto IL_0017;
				}
			}
			IL_008C:
			goto IL_009F;
			IL_008F:
			num3 = lineInfo.LineNumber;
			IL_0097:
			num2 = lineInfo.LinePosition;
			IL_009F:
			return new JsonSerializationException(message, path, num3, num2, ex);
		}

		// Token: 0x04000239 RID: 569
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x0400023A RID: 570
		[CompilerGenerated]
		private readonly int int_1;

		// Token: 0x0400023B RID: 571
		[CompilerGenerated]
		[Nullable(2)]
		private readonly string string_0;
	}
}
