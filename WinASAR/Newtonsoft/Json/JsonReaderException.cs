using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000062 RID: 98
	[Nullable(0)]
	[NullableContext(1)]
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00002DC6 File Offset: 0x00000FC6
		public int LineNumber { get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00002DCE File Offset: 0x00000FCE
		public int LinePosition { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00002DD6 File Offset: 0x00000FD6
		[Nullable(2)]
		public string Path
		{
			[NullableContext(2)]
			get;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0002BB54 File Offset: 0x00029D54
		public JsonReaderException()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0002BB88 File Offset: 0x00029D88
		public JsonReaderException(string message)
			: base(message)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0002BBBC File Offset: 0x00029DBC
		public JsonReaderException(string message, Exception innerException)
			: base(message, innerException)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		public JsonReaderException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0002BC24 File Offset: 0x00029E24
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, [Nullable(2)] Exception innerException)
			: base(message, innerException)
		{
			int num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
			{
				goto IL_001D;
			}
			do
			{
				IL_006A:
				switch (num)
				{
				case 1:
					return;
				case 2:
					this.LineNumber = lineNumber;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
					{
						continue;
					}
					break;
				case 3:
					goto IL_001D;
				}
				this.LinePosition = linePosition;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0);
			return;
			IL_001D:
			this.Path = path;
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
			{
				goto IL_006A;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002DDE File Offset: 0x00000FDE
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return JsonReaderException.Create(reader, message, null);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002DE8 File Offset: 0x00000FE8
		internal static JsonReaderException Create(JsonReader reader, string message, [Nullable(2)] Exception ex)
		{
			return JsonReaderException.Create(reader as IJsonLineInfo, reader.Path, message, ex);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0002BCB8 File Offset: 0x00029EB8
		internal static JsonReaderException Create([Nullable(2)] IJsonLineInfo lineInfo, string path, string message, [Nullable(2)] Exception ex)
		{
			int num2;
			int num3;
			for (;;)
			{
				message = JsonPosition.FormatMessage(lineInfo, path, message);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_0060;
				}
				IL_0066:
				switch (num)
				{
				case 0:
				case 2:
					goto IL_001B;
				case 1:
				case 7:
					goto IL_00B4;
				case 3:
					goto IL_003C;
				case 4:
					goto IL_0044;
				case 5:
					IL_0060:
					if (lineInfo != null)
					{
						goto IL_0020;
					}
					goto IL_001B;
				case 6:
					continue;
				case 8:
					goto IL_0020;
				case 9:
					break;
				default:
					goto IL_001B;
				}
				IL_0006:
				num2 = 0;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_0066;
				}
				IL_001B:
				num3 = 0;
				goto IL_0006;
				IL_0020:
				if (lineInfo.HasLineInfo())
				{
					goto IL_003C;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto IL_001B;
				}
				goto IL_0066;
				IL_0044:
				num2 = lineInfo.LinePosition;
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_001B;
				}
				goto IL_0066;
				IL_003C:
				num3 = lineInfo.LineNumber;
				goto IL_0044;
			}
			IL_00B4:
			return new JsonReaderException(message, path, num3, num2, ex);
		}

		// Token: 0x04000234 RID: 564
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x04000235 RID: 565
		[CompilerGenerated]
		private readonly int int_1;

		// Token: 0x04000236 RID: 566
		[Nullable(2)]
		[CompilerGenerated]
		private readonly string string_0;
	}
}
