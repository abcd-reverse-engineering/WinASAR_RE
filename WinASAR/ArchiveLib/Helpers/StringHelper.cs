using System;
using System.Text;

namespace WinASAR.ArchiveLib.Helpers
{
	// Token: 0x02000018 RID: 24
	public static class StringHelper
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00022EAC File Offset: 0x000210AC
		public static int GetCustomLength(this string text, Encoding encoding)
		{
			object[] array;
			for (;;)
			{
				array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
				{
					goto IL_0003;
				}
				IL_003E:
				switch (num)
				{
				case 1:
					goto IL_0021;
				case 2:
					IL_0003:
					array[0] = text;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto IL_0021;
					}
					goto IL_003E;
				case 3:
					continue;
				case 4:
					goto IL_008A;
				}
				break;
				IL_0021:
				array[1] = encoding;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_003E;
				}
				break;
			}
			object[] array2 = Class24.smethod_1(30, array, null);
			IL_008A:
			return (int)array2[0];
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00022F4C File Offset: 0x0002114C
		public static string Trim(this string source, string trimString)
		{
			object[] array2;
			for (;;)
			{
				IL_0080:
				object[] array = new object[2];
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_0024;
					case 1:
						goto IL_009E;
					case 2:
						array[0] = source;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
						{
							goto IL_0024;
						}
						continue;
					case 3:
						goto IL_0080;
					case 4:
						break;
					default:
						goto IL_0024;
					}
					IL_0003:
					array2 = Class24.smethod_1(31, array, null);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						continue;
					}
					IL_0024:
					array[1] = trimString;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_0003;
					}
				}
			}
			IL_009E:
			return (string)array2[0];
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00023000 File Offset: 0x00021200
		public static string TrimStart(this string source, string trimString)
		{
			object[] array;
			for (;;)
			{
				IL_005A:
				array = new object[2];
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_007B;
					case 2:
						goto IL_008A;
					case 3:
						array[0] = source;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_005A;
					}
					array[1] = trimString;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto IL_007A;
					}
				}
			}
			IL_007A:
			IL_007B:
			object[] array2 = Class24.smethod_1(32, array, null);
			IL_008A:
			return (string)array2[0];
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000230A0 File Offset: 0x000212A0
		public static string TrimEnd(this string source, string trimString)
		{
			object[] array2;
			for (;;)
			{
				IL_0082:
				object[] array = new object[2];
				for (;;)
				{
					IL_0062:
					array[0] = source;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto IL_0046;
					}
					do
					{
						IL_0026:
						array[1] = trimString;
						num = 4;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0);
					for (;;)
					{
						IL_0046:
						switch (num)
						{
						case 1:
							goto IL_0091;
						case 2:
							goto IL_0062;
						case 3:
							goto IL_0082;
						case 4:
							array2 = Class24.smethod_1(33, array, null);
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
							{
								goto Block_1;
							}
							continue;
						}
						break;
					}
					goto IL_0026;
				}
			}
			Block_1:
			IL_0091:
			return (string)array2[0];
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00023148 File Offset: 0x00021348
		public static string GetRelativePath(string fullPath, string rootPath)
		{
			object[] array;
			for (;;)
			{
				array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_005D;
				case 3:
					goto IL_0078;
				case 4:
					goto IL_0069;
				}
				IL_0003:
				array[0] = fullPath;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_005D:
			array[1] = rootPath;
			IL_0069:
			object[] array2 = Class24.smethod_1(34, array, null);
			IL_0078:
			return (string)array2[0];
		}
	}
}
