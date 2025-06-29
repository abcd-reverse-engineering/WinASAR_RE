using System;
using System.Text;

namespace WinASAR.Common.Helpers
{
	// Token: 0x02000025 RID: 37
	public static class FileHelper
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00024700 File Offset: 0x00022900
		public static string GetHumanReadableSize(long size)
		{
			object[] array2;
			for (;;)
			{
				IL_0063:
				object[] array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_004B;
				}
				do
				{
					IL_0026:
					array[0] = size;
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0);
				for (;;)
				{
					IL_004B:
					switch (num)
					{
					case 1:
						goto IL_0026;
					case 2:
						goto IL_0063;
					case 3:
						array2 = Class24.smethod_1(49, array, null);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
						{
							continue;
						}
						break;
					}
					goto Block_3;
				}
			}
			Block_3:
			return (string)array2[0];
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002479C File Offset: 0x0002299C
		public static void Start(string fileName)
		{
			for (;;)
			{
				object[] array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_0025;
				}
				IL_0033:
				switch (num)
				{
				case 1:
					IL_0025:
					array[0] = fileName;
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				Class24.smethod_1(50, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					break;
				}
				goto IL_0033;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00024818 File Offset: 0x00022A18
		public static string GetBaseName(string path)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[1];
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
				{
					goto IL_0003;
				}
				IL_0041:
				switch (num)
				{
				case 1:
					goto IL_0021;
				case 2:
					IL_0003:
					array[0] = path;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						goto IL_0021;
					}
					goto IL_0041;
				case 3:
					continue;
				}
				break;
				IL_0021:
				array2 = Class24.smethod_1(51, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_0041;
				}
				break;
			}
			return (string)array2[0];
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000248A8 File Offset: 0x00022AA8
		public static Encoding DetectFileEncoding(string filePath)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[1];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0026;
				}
				IL_0046:
				switch (num)
				{
				case 1:
					IL_0026:
					array[0] = filePath;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_0003;
					}
					goto IL_0046;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				array2 = Class24.smethod_1(52, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					break;
				}
				goto IL_0046;
			}
			return (Encoding)array2[0];
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00024940 File Offset: 0x00022B40
		public static string ReadFileWithDetectedEncoding(string filePath)
		{
			object[] array2;
			for (;;)
			{
				IL_005B:
				object[] array = new object[1];
				for (;;)
				{
					array[0] = filePath;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_0003;
					}
					IL_0023:
					switch (num)
					{
					case 1:
						goto IL_006A;
					case 2:
						continue;
					case 3:
						goto IL_005B;
					}
					IL_0003:
					array2 = Class24.smethod_1(53, array, null);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto IL_0023;
					}
					goto IL_0069;
				}
			}
			IL_0069:
			IL_006A:
			return (string)array2[0];
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000249C0 File Offset: 0x00022BC0
		public static void ShowFileProperties(string filePath)
		{
			object[] array;
			for (;;)
			{
				array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				array[0] = filePath;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0020;
				}
			}
			IL_0059:
			Class24.smethod_1(54, array, null);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00024A34 File Offset: 0x00022C34
		public static void DeleteFileWithUndo(string filePath)
		{
			for (;;)
			{
				IL_0058:
				object[] array = new object[1];
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						array[0] = filePath;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
						{
							continue;
						}
						break;
					case 3:
						goto IL_0058;
					}
					Class24.smethod_1(55, array, null);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00024ABC File Offset: 0x00022CBC
		public static string CopyFile(string sourceFilePath, string destDirPath, bool autoRename = false)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[3];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_0058;
				}
				IL_0066:
				switch (num)
				{
				case 0:
					goto IL_0035;
				case 1:
					IL_0058:
					array[0] = sourceFilePath;
					goto IL_0006;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_00A7;
				case 5:
					goto IL_0006;
				default:
					goto IL_0035;
				}
				IL_0012:
				array[2] = autoRename;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_0035;
				}
				goto IL_0066;
				IL_0006:
				array[1] = destDirPath;
				goto IL_0012;
				IL_0035:
				array2 = Class24.smethod_1(56, array, null);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				goto IL_0066;
			}
			IL_00A7:
			return (string)array2[0];
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00024B7C File Offset: 0x00022D7C
		private static void smethod_0(object object_0, object object_1)
		{
			for (;;)
			{
				IL_0068:
				object[] array = new object[2];
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_002D;
				}
				for (;;)
				{
					IL_004C:
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_002D;
					case 3:
						array[0] = object_0;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_0068;
					}
					break;
				}
				IL_0021:
				array[1] = object_1;
				goto IL_002D;
				goto IL_0021;
				IL_002D:
				Class24.smethod_1(57, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_004C;
				}
				break;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00024C14 File Offset: 0x00022E14
		public static string CopyDirectory(string sourceDirPath, string destDirPath, bool autoRename = false)
		{
			object[] array2;
			for (;;)
			{
				IL_009A:
				object[] array = new object[3];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
				{
					goto IL_006C;
				}
				for (;;)
				{
					IL_007A:
					switch (num)
					{
					case 1:
						goto IL_006C;
					case 2:
						goto IL_009A;
					case 3:
						goto IL_00BB;
					case 4:
						array[2] = autoRename;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
						{
							continue;
						}
						break;
					case 5:
						goto IL_0006;
					}
					break;
				}
				goto IL_0024;
				IL_0006:
				array[1] = destDirPath;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_0024;
				}
				goto IL_007A;
				IL_006C:
				array[0] = sourceDirPath;
				goto IL_0006;
				IL_0024:
				array2 = Class24.smethod_1(58, array, null);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
				{
					break;
				}
				goto IL_007A;
			}
			IL_00BB:
			return (string)array2[0];
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00024CE8 File Offset: 0x00022EE8
		public static string GetFileUniqueName(string filePath, string suffixName = "")
		{
			object[] array;
			for (;;)
			{
				IL_005A:
				array = new object[2];
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_0021;
					case 2:
						goto IL_008A;
					case 3:
						array[0] = filePath;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
						{
							goto IL_0021;
						}
						continue;
					case 4:
						goto IL_005A;
					}
					goto Block_1;
					IL_0021:
					array[1] = suffixName;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_007A;
					}
				}
			}
			Block_1:
			IL_007A:
			object[] array2 = Class24.smethod_1(59, array, null);
			IL_008A:
			return (string)array2[0];
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00024D88 File Offset: 0x00022F88
		public static string CreateFileUniqueName(string filePath)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[1];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_0003;
				}
				IL_0041:
				switch (num)
				{
				case 1:
					goto IL_0021;
				case 2:
					IL_0003:
					array[0] = filePath;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto IL_0021;
					}
					goto IL_0041;
				case 3:
					continue;
				}
				break;
				IL_0021:
				array2 = Class24.smethod_1(60, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					goto IL_0041;
				}
				break;
			}
			return (string)array2[0];
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00024E18 File Offset: 0x00023018
		public static string GetDirectoryUniqueName(string dirPath, string suffixName = "")
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_0034;
				}
				IL_0054:
				switch (num)
				{
				case 0:
					goto IL_0034;
				case 1:
					continue;
				case 2:
					goto IL_0026;
				case 3:
					break;
				case 4:
					goto IL_0091;
				default:
					goto IL_0034;
				}
				IL_0003:
				array2 = Class24.smethod_1(61, array, null);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					break;
				}
				goto IL_0054;
				IL_0026:
				array[1] = suffixName;
				goto IL_0003;
				IL_0034:
				array[0] = dirPath;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					goto IL_0026;
				}
				goto IL_0054;
			}
			IL_0091:
			return (string)array2[0];
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00024EC0 File Offset: 0x000230C0
		public static string CreateDirectoryUniqueName(string dirPath)
		{
			object[] array2;
			for (;;)
			{
				IL_005B:
				object[] array = new object[1];
				for (;;)
				{
					array[0] = dirPath;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_0003;
					}
					IL_0023:
					switch (num)
					{
					case 1:
						goto IL_006A;
					case 2:
						continue;
					case 3:
						goto IL_005B;
					}
					IL_0003:
					array2 = Class24.smethod_1(62, array, null);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
					{
						goto IL_0023;
					}
					goto IL_0069;
				}
			}
			IL_0069:
			IL_006A:
			return (string)array2[0];
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00024F40 File Offset: 0x00023140
		public static string ReadFile(string fileFullName)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[1];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0026;
				}
				IL_0034:
				switch (num)
				{
				case 1:
					IL_0026:
					array[0] = fileFullName;
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				array2 = Class24.smethod_1(63, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					break;
				}
				goto IL_0034;
			}
			return (string)array2[0];
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00024FC4 File Offset: 0x000231C4
		public static void WriteFile(string fileFullName, string content)
		{
			for (;;)
			{
				IL_0082:
				object[] array = new object[2];
				for (;;)
				{
					array[0] = fileFullName;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto IL_0025;
					}
					IL_0045:
					switch (num)
					{
					case 0:
						goto IL_0025;
					case 1:
						break;
					case 2:
						continue;
					case 3:
						goto IL_0082;
					case 4:
						return;
					default:
						goto IL_0025;
					}
					IL_0003:
					Class24.smethod_1(64, array, null);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						break;
					}
					goto IL_0045;
					IL_0025:
					array[1] = content;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_0003;
					}
					goto IL_0045;
				}
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00025064 File Offset: 0x00023264
		static FileHelper()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_0006;
				}
				IL_0111:
				switch (num)
				{
				case 1:
					goto IL_001C;
				case 2:
					IL_0006:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_001C;
					}
					goto IL_0111;
				case 3:
					continue;
				}
				break;
				IL_001C:
				FileHelper.string_0 = new string[]
				{
					Class15.smethod_17(41437925 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d),
					Class15.smethod_17(676704788 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b),
					Class15.smethod_17(1603802616 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c),
					Class15.smethod_17(1802350417 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4),
					Class15.smethod_17(2071405754 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808),
					Class15.smethod_17(2056989477 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48),
					Class15.smethod_17(89045942 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454),
					Class15.smethod_17(1788744291 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c),
					Class15.smethod_17(676704988 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b)
				};
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					goto IL_0111;
				}
				break;
			}
		}

		// Token: 0x04000124 RID: 292
		private static readonly string[] string_0;
	}
}
