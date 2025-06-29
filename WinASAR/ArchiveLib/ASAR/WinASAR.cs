using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WinASAR.ArchiveLib.ASAR
{
	// Token: 0x0200001B RID: 27
	public class WinASAR
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00023508 File Offset: 0x00021708
		public static List<AsarFile> ReadASAR(string asarFileName)
		{
			object[] array = Class24.smethod_1(35, new object[] { asarFileName }, null);
			return (List<AsarFile>)array[0];
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00023540 File Offset: 0x00021740
		public static void smethod_0(string asarFileName, string targetDirectory, List<ItemFilter> fileFilters = null, List<ItemFilter> directoryFilters = null)
		{
			Class24.smethod_1(36, new object[] { asarFileName, targetDirectory, fileFilters, directoryFilters }, null);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00023594 File Offset: 0x00021794
		public static void smethod_1(string asarFileName, string sourceDirectory)
		{
			object[] array;
			for (;;)
			{
				IL_003C:
				array = new object[2];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						array[0] = asarFileName;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_003C;
					case 3:
						goto IL_0069;
					case 4:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			array[1] = sourceDirectory;
			IL_0069:
			Class24.smethod_1(37, array, null);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00023618 File Offset: 0x00021818
		public static void smethod_2(string asarFileName, List<string> sourceFileOrDirectories)
		{
			Class24.smethod_1(38, new object[] { asarFileName, sourceFileOrDirectories }, null);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00023654 File Offset: 0x00021854
		public static void smethod_3(string oldAsarFileName, string newAsarFileName, List<ItemFilter> addFileFilters)
		{
			Class24.smethod_1(39, new object[] { oldAsarFileName, newAsarFileName, addFileFilters }, null);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0002369C File Offset: 0x0002189C
		public static void ReCreateASAR(string asarFileName, List<ItemFilter> deleteFileFilters = null)
		{
			Class24.smethod_1(40, new object[] { asarFileName, deleteFileFilters }, null);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000236D8 File Offset: 0x000218D8
		public static void ReCreateASAR(string asarFileName, string oldFileOrDirectory, string newFileOrDirectory)
		{
			object[] array;
			for (;;)
			{
				IL_0071:
				array = new object[3];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_0043;
				}
				for (;;)
				{
					IL_0051:
					switch (num)
					{
					case 1:
						goto IL_0043;
					case 2:
						goto IL_0071;
					case 3:
						return;
					case 4:
						goto IL_0023;
					case 5:
						array[2] = newFileOrDirectory;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
						{
							continue;
						}
						break;
					}
					goto Block_3;
				}
				IL_0023:
				array[1] = oldFileOrDirectory;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					break;
				}
				goto IL_0051;
				IL_0043:
				array[0] = asarFileName;
				goto IL_0023;
			}
			Block_3:
			Class24.smethod_1(41, array, null);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00023788 File Offset: 0x00021988
		private static void SadMkwVhaN(object object_0, List<AsarFile> list_0)
		{
			Class24.smethod_1(42, new object[] { object_0, list_0 }, null);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000237C4 File Offset: 0x000219C4
		private static List<AsarFile> smethod_4(List<string> list_0)
		{
			object[] array = Class24.smethod_1(43, new object[] { list_0 }, null);
			return (List<AsarFile>)array[0];
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000237FC File Offset: 0x000219FC
		private static List<AsarFile> smethod_5(object object_0, string string_0 = "")
		{
			object[] array = Class24.smethod_1(44, new object[] { object_0, string_0 }, null);
			return (List<AsarFile>)array[0];
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00023840 File Offset: 0x00021A40
		private static List<AsarFile> smethod_6(object object_0, object object_1, long long_0)
		{
			object[] array = Class24.smethod_1(45, new object[] { object_0, object_1, long_0 }, null);
			return (List<AsarFile>)array[0];
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00023894 File Offset: 0x00021A94
		public static List<AsarFile> ReadAsarFiles(JObject jsonTree, long baseOffset)
		{
			object[] array = Class24.smethod_1(46, new object[] { jsonTree, baseOffset }, null);
			return (List<AsarFile>)array[0];
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000238DC File Offset: 0x00021ADC
		private static JObject smethod_7(List<AsarFile> list_0)
		{
			object[] array = Class24.smethod_1(47, new object[] { list_0 }, null);
			return (JObject)array[0];
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00023914 File Offset: 0x00021B14
		private static void smethod_8(object object_0)
		{
			for (;;)
			{
				object[] array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0025;
				}
				IL_0033:
				switch (num)
				{
				case 0:
					goto IL_0025;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_0025;
				}
				IL_0003:
				Class24.smethod_1(48, array, null);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					break;
				}
				goto IL_0033;
				IL_0025:
				array[0] = object_0;
				goto IL_0003;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00023990 File Offset: 0x00021B90
		public WinASAR()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
