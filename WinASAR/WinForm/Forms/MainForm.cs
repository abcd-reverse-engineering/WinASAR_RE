using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using WinASAR.ArchiveLib.ASAR;
using WinASAR.ArchiveLib.Helpers;
using WinASAR.Common.Enums;
using WinASAR.Common.Helpers;
using WinASAR.Common.Models;
using WinASAR.WinForm.Common;
using WinASAR.WinForm.Properties;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000008 RID: 8
	public partial class MainForm : Form
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00012BDC File Offset: 0x00010DDC
		public MainForm(string path)
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
			{
				goto IL_0071;
			}
			do
			{
				IL_0093:
				switch (num)
				{
				case 1:
					this.InitializeEvent();
					goto IL_0056;
				case 2:
					goto IL_0071;
				case 3:
					goto IL_0056;
				}
				break;
				IL_0056:
				this.InitializeData(path);
				num = 0;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0);
			return;
			IL_0071:
			this.method_62();
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
			{
				goto IL_0093;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00012C98 File Offset: 0x00010E98
		public void InitializeData(string path)
		{
			object[] array;
			for (;;)
			{
				array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
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
				array[0] = path;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0059:
			Class24.smethod_1(9, array, this);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00012D0C File Offset: 0x00010F0C
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					Class24.smethod_1(10, array, this);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_0022;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00012D70 File Offset: 0x00010F70
		private void method_0()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0025;
				}
				do
				{
					IL_0003:
					Class24.smethod_1(11, array, this);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0);
				IL_0025:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return;
				default:
					goto IL_0003;
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00012DD8 File Offset: 0x00010FD8
		private static bool smethod_0(object object_0)
		{
			object[] array2;
			for (;;)
			{
				IL_005B:
				object[] array = new object[1];
				for (;;)
				{
					array[0] = object_0;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
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
					array2 = Class24.smethod_1(12, array, null);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_0023;
					}
					goto IL_0069;
				}
			}
			IL_0069:
			IL_006A:
			return (bool)array2[0];
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00012E58 File Offset: 0x00011058
		private string method_1(string string_1)
		{
			object[] array2;
			for (;;)
			{
				IL_0059:
				object[] array = new object[1];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					goto IL_0021;
				}
				for (;;)
				{
					IL_0041:
					switch (num)
					{
					case 1:
						array[0] = string_1;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0059;
					case 3:
						goto IL_007A;
					}
					break;
				}
				IL_0021:
				array2 = Class24.smethod_1(13, array, this);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_0041;
				}
				break;
			}
			IL_007A:
			return (string)array2[0];
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00012EE8 File Offset: 0x000110E8
		private void method_2(int int_2, int int_3, string string_1)
		{
			for (;;)
			{
				IL_009B:
				object[] array = new object[3];
				for (;;)
				{
					IL_0076:
					array[0] = int_2;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_0024;
					}
					for (;;)
					{
						IL_0056:
						switch (num)
						{
						case 1:
							goto IL_0024;
						case 2:
							Class24.smethod_1(14, array, this);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
							{
								continue;
							}
							break;
						case 3:
							goto IL_0006;
						case 4:
							goto IL_0076;
						case 5:
							goto IL_009B;
						}
						return;
					}
					IL_0006:
					array[2] = string_1;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						goto IL_0056;
					}
					IL_0024:
					array[1] = int_3;
					goto IL_0006;
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00012FA0 File Offset: 0x000111A0
		private void method_3(int int_2, int int_3, string string_1)
		{
			for (;;)
			{
				IL_00AE:
				object[] array = new object[3];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto IL_0069;
				}
				goto IL_008E;
				do
				{
					IL_0047:
					Class24.smethod_1(15, array, this);
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0);
				for (;;)
				{
					IL_008E:
					switch (num)
					{
					case 1:
						goto IL_00AE;
					case 2:
						goto IL_0047;
					case 3:
						return;
					case 4:
						goto IL_0029;
					case 5:
						array[1] = int_3;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
						{
							goto IL_0029;
						}
						continue;
					}
					break;
				}
				goto IL_0069;
				IL_0029:
				array[2] = string_1;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_0047;
				}
				goto IL_008E;
				IL_0069:
				array[0] = int_2;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0029;
				}
				goto IL_008E;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0001307C File Offset: 0x0001127C
		private void method_4(string string_1)
		{
			object[] array;
			for (;;)
			{
				IL_0038:
				array = new object[1];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						array[0] = string_1;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0038;
					case 3:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			Class24.smethod_1(16, array, this);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000130F0 File Offset: 0x000112F0
		private void method_5(List<FileItem> list_2, string string_1, SortOrder sortOrder_1)
		{
			Class24.smethod_1(17, new object[] { list_2, string_1, sortOrder_1 }, this);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0001313C File Offset: 0x0001133C
		private ArchiveInfo method_6(string string_1, bool bool_2 = false)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_0037;
				}
				IL_0045:
				switch (num)
				{
				case 1:
					IL_0037:
					array[0] = string_1;
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0014;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0014:
				array2 = Class24.smethod_1(18, array, this);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					break;
				}
				goto IL_0045;
				IL_0003:
				array[1] = bool_2;
				goto IL_0014;
			}
			return (ArchiveInfo)array2[0];
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000131D4 File Offset: 0x000113D4
		public static string GetFirstExistingFilePath(string fileOrDirPath)
		{
			object[] array;
			for (;;)
			{
				array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
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
					goto IL_0068;
				}
				IL_0003:
				array[0] = fileOrDirPath;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0059:
			object[] array2 = Class24.smethod_1(19, array, null);
			IL_0068:
			return (string)array2[0];
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00013254 File Offset: 0x00011454
		private void method_7(string string_1, bool bool_2 = false)
		{
			for (;;)
			{
				IL_0071:
				object[] array = new object[2];
				for (;;)
				{
					IL_0063:
					array[0] = string_1;
					for (;;)
					{
						array[1] = bool_2;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							goto IL_0003;
						}
						IL_0022:
						switch (num)
						{
						case 1:
							return;
						case 2:
							goto IL_0063;
						case 3:
							goto IL_0071;
						case 4:
							continue;
						}
						IL_0003:
						Class24.smethod_1(20, array, this);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
						{
							goto IL_0022;
						}
						return;
					}
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000132E4 File Offset: 0x000114E4
		private void method_8(string string_1, bool bool_2 = false)
		{
			for (;;)
			{
				object[] array = new object[2];
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					goto IL_0003;
				}
				goto IL_0066;
				do
				{
					IL_0044:
					Class24.smethod_1(21, array, this);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0);
				IL_0066:
				switch (num)
				{
				case 0:
					goto IL_0044;
				case 1:
					break;
				case 2:
					return;
				case 3:
					IL_0003:
					array[0] = string_1;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0066;
					}
					break;
				case 4:
					continue;
				default:
					goto IL_0044;
				}
				array[1] = bool_2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_0044;
				}
				goto IL_0066;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00013398 File Offset: 0x00011598
		private void method_9(string string_1, bool bool_2 = false, bool bool_3 = false)
		{
			try
			{
				List<string> list = new List<string>();
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0846;
				}
				FileItem fileItem;
				FileInfo fileInfo;
				Icon icon2;
				string text2;
				ArchiveInfo archiveInfo;
				for (;;)
				{
					IL_0855:
					List<string>.Enumerator enumerator;
					switch (num)
					{
					case 1:
						goto IL_0058;
					case 2:
						goto IL_0332;
					case 3:
						goto IL_02D0;
					case 4:
						goto IL_02E1;
					case 5:
					case 37:
						goto IL_00C7;
					case 6:
						goto IL_09C3;
					case 7:
					case 23:
						goto IL_09BD;
					case 8:
						goto IL_014A;
					case 9:
						goto IL_0A24;
					case 10:
					case 48:
						goto IL_0342;
					case 11:
						goto IL_0846;
					case 12:
					case 28:
						goto IL_03B1;
					case 13:
						goto IL_0142;
					case 14:
						try
						{
							IL_080D:
							while (enumerator.MoveNext())
							{
								for (;;)
								{
									IL_07FE:
									string text = enumerator.Current;
									for (;;)
									{
										IL_07F5:
										fileItem = new FileItem();
										for (;;)
										{
											IL_07D2:
											fileInfo = new FileInfo(text);
											int num2 = 3;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
											{
												goto IL_05D4;
											}
											DirectoryInfo directoryInfo;
											for (;;)
											{
												IL_0733:
												switch (num2)
												{
												case 1:
													goto IL_080D;
												case 2:
													fileItem.Type = 1;
													goto IL_06FA;
												case 3:
													goto IL_05BF;
												case 4:
													goto IL_0816;
												case 5:
													goto IL_048D;
												case 6:
													goto IL_0716;
												case 7:
													goto IL_05C7;
												case 8:
													goto IL_06A8;
												case 9:
												case 12:
													goto IL_0549;
												case 10:
													goto IL_04F1;
												case 11:
													goto IL_07FE;
												case 13:
												case 22:
													goto IL_056C;
												case 14:
													goto IL_06FA;
												case 15:
													goto IL_06B6;
												case 16:
													goto IL_06D6;
												case 17:
													goto IL_0469;
												case 18:
													goto IL_05DD;
												case 19:
													goto IL_05F4;
												case 20:
													goto IL_07D2;
												case 21:
													goto IL_04BE;
												case 23:
													goto IL_0445;
												case 24:
													goto IL_0617;
												case 25:
													goto IL_049B;
												case 26:
													goto IL_06C9;
												case 27:
													goto IL_0685;
												case 28:
													goto IL_05E6;
												case 29:
													goto IL_059C;
												case 30:
													goto IL_064D;
												case 31:
													goto IL_0424;
												case 32:
													goto IL_04CC;
												case 33:
													goto IL_07F5;
												case 34:
													goto IL_05D4;
												case 35:
													goto IL_0593;
												}
												goto Block_28;
												IL_0685:
												fileItem.CreationTime = directoryInfo.CreationTime;
												num2 = 4;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
												{
													goto IL_06A8;
												}
												continue;
												IL_06D6:
												fileItem.Length = -1L;
												num2 = 21;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
												{
													goto IL_0685;
												}
												continue;
												IL_06FA:
												fileItem.IsDirectory = true;
												num2 = 16;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
												{
													goto IL_06D6;
												}
											}
											IL_064D:
											fileItem.Extension = (string.IsNullOrEmpty(fileInfo.Extension) ? Class15.smethod_17(314773499 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927) : fileInfo.Extension);
											goto IL_05BF;
											IL_0716:
											fileItem.Name = fileInfo.Name;
											goto IL_064D;
											IL_06C9:
											Icon icon = IconHelper.GetFileDefaultIcon(text, true);
											goto IL_0532;
											IL_06B6:
											fileItem.LastAccessTime = directoryInfo.LastAccessTime;
											goto IL_050E;
											IL_06A8:
											fileItem.LastWriteTime = directoryInfo.LastWriteTime;
											goto IL_06B6;
											Block_28:
											goto IL_050E;
											IL_0424:
											if (fileItem.Type == 0)
											{
												goto IL_04F1;
											}
											num2 = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
											{
												goto IL_0445;
											}
											goto IL_0733;
											IL_050E:
											if (this.listView_0.SmallImageList.Images.ContainsKey(fileItem.Extension))
											{
												goto IL_056C;
											}
											goto IL_0424;
											IL_0445:
											if (fileItem.Type == 1)
											{
												num2 = 3;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
												{
													goto IL_04F1;
												}
												goto IL_0733;
											}
											IL_0469:
											if ((icon = IconHelper.GetFileIcon(text, true)) != null)
											{
												goto IL_0532;
											}
											num2 = 26;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
											{
												goto IL_048D;
											}
											goto IL_0733;
											IL_049B:
											fileItem.CreationTime = fileInfo.CreationTime;
											num2 = 1;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
											{
												goto IL_04BE;
											}
											goto IL_0733;
											IL_048D:
											fileItem.Length = fileInfo.Length;
											goto IL_049B;
											IL_05C7:
											fileItem.IsDirectory = false;
											goto IL_048D;
											IL_05BF:
											fileItem.Type = 2;
											goto IL_05C7;
											IL_04CC:
											fileItem.LastAccessTime = fileInfo.LastAccessTime;
											num2 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
											{
												goto IL_050E;
											}
											goto IL_0733;
											IL_04BE:
											fileItem.LastWriteTime = fileInfo.LastWriteTime;
											goto IL_04CC;
											IL_04F1:
											icon2 = IconHelper.GetFolderIcon(true);
											num2 = 9;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
											{
												goto IL_050E;
											}
											goto IL_0733;
											IL_0532:
											icon2 = icon;
											num2 = 8;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
											{
												goto IL_0549;
											}
											goto IL_0733;
											IL_056C:
											this.list_0.Add(fileItem);
											num2 = 1;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
											{
												goto Block_23;
											}
											goto IL_0733;
											IL_0549:
											this.listView_0.SmallImageList.Images.Add(fileItem.Extension, icon2.ToBitmap());
											goto IL_056C;
											IL_059C:
											fileItem.FullPath = fileInfo.FullName;
											num2 = 6;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
											{
												goto IL_05BF;
											}
											goto IL_0733;
											IL_0593:
											fileInfo = new FileInfo(text);
											goto IL_059C;
											IL_05D4:
											if (!fileInfo.Exists)
											{
												goto IL_05DD;
											}
											goto IL_0593;
											IL_05F4:
											fileItem.Name = directoryInfo.Name;
											num2 = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
											{
												goto IL_0617;
											}
											goto IL_0733;
											IL_05E6:
											fileItem.FullPath = directoryInfo.FullName;
											goto IL_05F4;
											IL_05DD:
											directoryInfo = new DirectoryInfo(text);
											goto IL_05E6;
											IL_0617:
											fileItem.Extension = Class15.smethod_17(1953682975 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f);
											num2 = 2;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
											{
												goto Block_24;
											}
											goto IL_0733;
										}
									}
								}
								Block_23:
								Block_24:;
							}
							IL_0816:
							goto IL_035C;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
							{
								switch (num3)
								{
								}
							}
						}
						goto IL_0846;
					case 15:
						goto IL_0052;
					case 16:
						goto IL_039E;
					case 17:
						goto IL_02FD;
					case 18:
						goto IL_040C;
					case 19:
						goto IL_0A18;
					case 20:
						goto IL_0167;
					case 21:
						goto IL_01EB;
					case 22:
						goto IL_01FD;
					case 24:
						goto IL_0284;
					case 25:
						goto IL_098F;
					case 26:
						goto IL_02AE;
					case 27:
						goto IL_01D6;
					case 29:
						goto IL_010A;
					case 30:
						goto IL_0235;
					case 31:
						goto IL_094C;
					case 32:
					case 35:
						goto IL_0A29;
					case 33:
						goto IL_0960;
					case 34:
					case 39:
						goto IL_00D4;
					case 36:
						goto IL_0A27;
					case 38:
						fileItem.Length = -1L;
						goto IL_040C;
					case 40:
						goto IL_0367;
					case 41:
					case 46:
						goto IL_002A;
					case 42:
						goto IL_0242;
					case 43:
						goto IL_0188;
					case 44:
						goto IL_0A31;
					case 45:
						goto IL_0126;
					case 47:
						goto IL_0292;
					case 49:
						goto IL_02BF;
					case 50:
						goto IL_020F;
					case 51:
						goto IL_00A9;
					case 52:
					case 58:
						goto IL_0022;
					case 53:
						if (fileInfo.Directory != null)
						{
							goto IL_00F7;
						}
						num = 39;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
						{
							goto Block_9;
						}
						continue;
					case 54:
						goto IL_035C;
					case 55:
						this.listView_0.SmallImageList.Images.Add(fileItem.Extension, icon2.ToBitmap());
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
						{
							goto Block_5;
						}
						continue;
					case 56:
						goto IL_00F7;
					case 57:
						goto IL_008C;
					}
					goto Block_11;
					IL_008C:
					icon2 = IconHelper.GetFolderIcon(true);
					num = 55;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						continue;
					}
					IL_00A9:
					if (this.listView_0.SmallImageList.Images.ContainsKey(fileItem.Extension))
					{
						goto IL_00C7;
					}
					goto IL_008C;
					IL_00D4:
					enumerator = list.GetEnumerator();
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						break;
					}
					continue;
					IL_00C7:
					this.list_0.Add(fileItem);
					goto IL_00D4;
					IL_014A:
					fileItem.IsDirectory = true;
					num = 38;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_0167;
					}
					continue;
					IL_0142:
					fileItem.Type = 0;
					goto IL_014A;
					IL_0126:
					fileItem.Extension = Class15.smethod_17(1760311449 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_0142;
					IL_010A:
					fileItem.Name = Class15.smethod_17(2060610084 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
					goto IL_0126;
					IL_00F7:
					fileItem.FullPath = fileInfo.Directory.FullName;
					goto IL_010A;
					IL_0167:
					fileItem.LastWriteTime = DateTime.MinValue;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0188;
					}
					continue;
					IL_040C:
					fileItem.CreationTime = DateTime.MinValue;
					goto IL_0167;
					IL_0367:
					text2 = this.listView_0.Columns[this.int_0].Tag as string;
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_039E;
					}
					continue;
					IL_035C:
					this.listView_0.EndUpdate();
					goto IL_0367;
					IL_03B1:
					this.listView_0.BeginUpdate();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto Block_7;
					}
					continue;
					IL_039E:
					list.AddRange(Directory.GetFiles(archiveInfo.FullPath));
					goto IL_03B1;
					IL_0188:
					fileItem.LastAccessTime = DateTime.MinValue;
					goto IL_00A9;
				}
				goto IL_09C3;
				Block_5:
				Block_7:
				goto IL_0332;
				Block_9:
				goto IL_098F;
				Block_11:
				goto IL_0064;
				IL_094C:
				this.method_5(this.list_0, text2, this.sortOrder_0);
				IL_0960:
				int num4 = this.list_0.Count(new Func<FileItem, bool>(MainForm.<>c.<>c_0.method_5));
				IL_098F:
				int num5 = this.list_0.Count(new Func<FileItem, bool>(MainForm.<>c.<>c_0.method_6));
				IL_09C3:
				string humanReadableSize = FileHelper.GetHumanReadableSize(this.list_0.Where(new Func<FileItem, bool>(MainForm.<>c.<>c_0.method_7)).Sum(new Func<FileItem, long>(MainForm.<>c.<>c_0.method_8)));
				IL_0A18:
				this.method_2(num4, num5, humanReadableSize);
				IL_0A24:
				return;
				IL_0022:
				icon2 = IconHelper.GetFolderIcon(true);
				IL_002A:
				list.AddRange(Directory.GetDirectories(archiveInfo.FullPath));
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0855;
				}
				IL_0052:
				if (bool_2)
				{
					goto IL_0A29;
				}
				IL_0058:
				if (archiveInfo.IsAsarFile)
				{
					goto IL_0A29;
				}
				IL_0064:
				this.method_7(archiveInfo.FullPath, bool_3);
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_0A27;
				}
				goto IL_0855;
				IL_01D6:
				this.listView_0.SmallImageList.Images.Clear();
				IL_01EB:
				this.toolStripButton_7.Image = icon2.ToBitmap();
				IL_01FD:
				this.string_0 = archiveInfo.FullPath.Trim();
				IL_020F:
				this.toolStripComboBox_0.Text = this.string_0;
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0855;
				}
				IL_0235:
				string fileName = Path.GetFileName(this.string_0);
				IL_0242:
				this.Text = ((!string.IsNullOrEmpty(fileName)) ? (fileName + Class15.smethod_17(974448323 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f)) : Class15.smethod_17(538804481 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
				IL_0284:
				fileInfo = new FileInfo(archiveInfo.FullPath);
				IL_0292:
				fileItem = new FileItem();
				num = 53;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_0855;
				}
				IL_02AE:
				if (File.Exists(archiveInfo.FullPath))
				{
					goto IL_0052;
				}
				IL_02BF:
				if (!Directory.Exists(archiveInfo.FullPath))
				{
					goto IL_09BD;
				}
				IL_02D0:
				if (!MainForm.smethod_0(archiveInfo.FullPath))
				{
					goto IL_0022;
				}
				IL_02E1:
				if (archiveInfo.FullPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
				{
					goto IL_0342;
				}
				IL_02FD:
				ArchiveInfo archiveInfo2 = archiveInfo;
				archiveInfo2.FullPath += Path.DirectorySeparatorChar.ToString();
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_0855;
				}
				IL_0332:
				this.list_0.Clear();
				goto IL_01D6;
				IL_0342:
				icon2 = IconHelper.GetDriverIcon(archiveInfo.FullPath[0], true);
				goto IL_002A;
				IL_0846:
				archiveInfo = this.method_6(string_1, false);
				goto IL_02AE;
				IL_09BD:
				IL_0A27:
				return;
				IL_0A29:
				this.method_8(string_1, bool_3);
				IL_0A31:;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				int num6 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					switch (num6)
					{
					}
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00013E38 File Offset: 0x00012038
		private void method_10()
		{
			for (;;)
			{
				IL_0036:
				object[] array = new object[0];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						Class24.smethod_1(22, array, this);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00013E9C File Offset: 0x0001209C
		private void method_11(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_01B0;
					}
				}
				try
				{
					openFileDialog.Filter = Class15.smethod_17(1176456876 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto IL_00A4;
					}
					string text;
					for (;;)
					{
						IL_0120:
						switch (num2)
						{
						case 1:
							if (openFileDialog.ShowDialog() != DialogResult.OK)
							{
								goto IL_016C;
							}
							num2 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
							{
								goto IL_00DA;
							}
							continue;
						case 2:
						case 9:
							goto IL_016C;
						case 3:
							goto IL_006B;
						case 4:
							goto IL_00DA;
						case 5:
							goto IL_00BE;
						case 6:
							goto IL_0162;
						case 7:
							goto IL_005D;
						case 8:
							goto IL_0153;
						}
						break;
						IL_006B:
						if (Path.GetExtension(text).Equals(Class15.smethod_17(635811153 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), StringComparison.OrdinalIgnoreCase))
						{
							goto IL_0153;
						}
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
						{
							break;
						}
						continue;
						IL_005D:
						text = openFileDialog.FileName.Trim();
						goto IL_006B;
						IL_00DA:
						if (string.IsNullOrWhiteSpace(openFileDialog.FileName))
						{
							goto IL_016C;
						}
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							goto IL_005D;
						}
					}
					goto IL_00A4;
					IL_0153:
					if (WinASAR.ReadASAR(text).Count <= 0)
					{
						goto IL_016C;
					}
					IL_0162:
					this.method_9(text, true, false);
					IL_016C:
					goto IL_01B0;
					IL_00A4:
					openFileDialog.RestoreDirectory = false;
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_0120;
					}
					IL_00BE:
					openFileDialog.Multiselect = false;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_00A4;
					}
					goto IL_0120;
				}
				finally
				{
					if (openFileDialog != null)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
						{
							goto IL_019F;
						}
						do
						{
							IL_0184:
							((IDisposable)openFileDialog).Dispose();
							num3 = 1;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0);
						IL_019F:
						switch (num3)
						{
						case 0:
							goto IL_0184;
						case 1:
							break;
						default:
							goto IL_0184;
						}
					}
				}
				IL_01B0:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(699005380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000140D4 File Offset: 0x000122D4
		private void method_12(object sender, EventArgs e)
		{
			try
			{
				ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_0049;
				}
				goto IL_0069;
				IL_0024:
				if (string.IsNullOrEmpty(archiveInfo.FullPath))
				{
					goto IL_0170;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_008A;
				}
				goto IL_0069;
				IL_0049:
				if (!archiveInfo.IsAsarFile)
				{
					goto IL_0170;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto IL_0024;
				}
				IL_0069:
				switch (num)
				{
				case 0:
					goto IL_0049;
				case 1:
					break;
				case 2:
					goto IL_0024;
				case 3:
					goto IL_0170;
				case 4:
					goto IL_009F;
				case 5:
					goto IL_0098;
				default:
					goto IL_0049;
				}
				IL_008A:
				string fileName = Path.GetFileName(archiveInfo.FullPath);
				IL_0098:
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				IL_009F:
				try
				{
					saveFileDialog.Filter = Class15.smethod_17(538806339 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_00E7;
					}
					IL_00CE:
					saveFileDialog.RestoreDirectory = false;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_0104;
					}
					IL_00E7:
					switch (num2)
					{
					case 0:
						goto IL_00CE;
					case 1:
						break;
					case 2:
						goto IL_012B;
					case 3:
						goto IL_010D;
					case 4:
						goto IL_0117;
					default:
						goto IL_00CE;
					}
					IL_0104:
					saveFileDialog.FileName = fileName;
					IL_010D:
					if (saveFileDialog.ShowDialog() != DialogResult.OK)
					{
						goto IL_012B;
					}
					IL_0117:
					File.Copy(archiveInfo.FullPath, saveFileDialog.FileName, true);
					IL_012B:;
				}
				finally
				{
					if (saveFileDialog != null)
					{
						goto IL_0156;
					}
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						goto IL_016F;
					}
					IL_0145:
					switch (num3)
					{
					default:
						IL_0156:
						((IDisposable)saveFileDialog).Dispose();
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
						{
							goto IL_0145;
						}
						break;
					case 1:
					case 2:
						break;
					}
					IL_016F:;
				}
				IL_0170:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(635812187 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000142CC File Offset: 0x000124CC
		private void method_13(object sender, EventArgs e)
		{
			for (;;)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_0003;
				}
				IL_004E:
				switch (num)
				{
				case 0:
					goto IL_001C;
				case 1:
					return;
				case 2:
					break;
				case 3:
					goto IL_002A;
				case 4:
					IL_0003:
					if (toolStripMenuItem == null)
					{
						return;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto IL_001C;
					}
					goto IL_004E;
				case 5:
					continue;
				default:
					goto IL_001C;
				}
				IL_0033:
				string text;
				this.method_9(text, false, false);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_004E;
				}
				break;
				IL_002A:
				if (!string.IsNullOrEmpty(text))
				{
					goto IL_0033;
				}
				break;
				IL_001C:
				text = toolStripMenuItem.Tag as string;
				goto IL_002A;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00014368 File Offset: 0x00012568
		private void method_14(object sender, EventArgs e)
		{
			try
			{
				if (this.listView_0.SelectedItems.Count > 0)
				{
					for (;;)
					{
						ListView.SelectedListViewItemCollection selectedItems = this.listView_0.SelectedItems;
						List<string> list = new List<string>();
						IEnumerator enumerator = selectedItems.GetEnumerator();
						for (;;)
						{
							try
							{
								for (;;)
								{
									if (enumerator.MoveNext())
									{
										goto IL_0064;
									}
									int num = 2;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
									{
										break;
									}
									IL_0034:
									FileItem fileItem;
									switch (num)
									{
									case 0:
										goto IL_00A5;
									case 1:
										if (!Class15.smethod_17(1570982027 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).Equals(fileItem.Extension))
										{
											goto IL_00A5;
										}
										continue;
									case 2:
									case 5:
										continue;
									case 3:
										break;
									case 4:
										IL_0064:
										fileItem = (FileItem)((ListViewItem)enumerator.Current).Tag;
										break;
									case 6:
										goto IL_00D9;
									default:
										goto IL_00A5;
									}
									if (fileItem.IsDirectory)
									{
										num = 1;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
										{
											goto IL_0034;
										}
									}
									IL_00A5:
									list.Add(fileItem.FullPath);
								}
								IL_00D9:
								goto IL_01D7;
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								while (disposable != null)
								{
									int num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
									{
										goto IL_0116;
									}
									do
									{
										IL_00FB:
										disposable.Dispose();
										num2 = 1;
									}
									while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0);
									IL_0116:
									switch (num2)
									{
									case 0:
										goto IL_00FB;
									case 1:
										goto IL_012E;
									case 2:
										break;
									default:
										goto IL_00FB;
									}
								}
								IL_012E:;
							}
							goto IL_012F;
							IL_0171:
							int num3;
							switch (num3)
							{
							case 1:
								goto IL_0168;
							case 2:
								goto IL_01A9;
							case 3:
								continue;
							case 4:
								goto IL_0140;
							case 5:
								goto IL_012F;
							case 7:
								goto IL_0208;
							case 8:
								goto IL_020C;
							case 9:
								goto IL_020A;
							case 10:
								goto IL_01CA;
							case 11:
								IL_01D7:
								if (list.Count <= 0)
								{
									goto Block_7;
								}
								goto IL_01CA;
							}
							break;
							IL_0140:
							this.toolStripMenuItem_47.Enabled = this.bool_0;
							num3 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
							{
								goto Block_4;
							}
							goto IL_0171;
							IL_012F:
							this.toolStripMenuItem_26.Enabled = this.bool_0;
							goto IL_0140;
							IL_01A9:
							this.list_1.AddRange(list);
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
							{
								goto IL_0168;
							}
							goto IL_0171;
							IL_01CA:
							this.list_1.Clear();
							goto IL_01A9;
							IL_0168:
							this.bool_0 = true;
							goto IL_012F;
						}
					}
					Block_4:
					Block_7:
					IL_0208:
					IL_020A:;
				}
				IL_020C:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(1387462814 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000145FC File Offset: 0x000127FC
		private void method_15(object sender, EventArgs e)
		{
			try
			{
				if (this.bool_0)
				{
					for (;;)
					{
						if (this.list_1.Count > 0)
						{
							goto IL_0270;
						}
						int num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
						{
							break;
						}
						IL_01F9:
						switch (num)
						{
						case 0:
							goto IL_01DF;
						case 1:
							goto IL_0116;
						case 2:
						case 10:
						case 20:
							goto IL_02BC;
						case 3:
							continue;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_02AE;
						case 6:
							IL_0270:
							if (Directory.Exists(this.string_0))
							{
								goto IL_0012;
							}
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
							{
								goto IL_01DF;
							}
							goto IL_01F9;
						case 7:
							break;
						case 8:
							goto IL_02B0;
						case 9:
							goto IL_0012;
						case 11:
							goto IL_01AD;
						case 12:
						case 21:
							goto IL_01C5;
						case 13:
							goto IL_011D;
						case 14:
						case 18:
							goto IL_0167;
						case 15:
							goto IL_0019;
						case 16:
							goto IL_0185;
						case 17:
							goto IL_0195;
						case 19:
							goto IL_012E;
						default:
							goto IL_01DF;
						}
						IL_013F:
						this.method_9(this.string_0, false, false);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto IL_01DF;
						}
						goto IL_01F9;
						IL_012E:
						this.toolStripMenuItem_47.Enabled = this.bool_0;
						goto IL_013F;
						IL_011D:
						this.toolStripMenuItem_26.Enabled = this.bool_0;
						goto IL_012E;
						IL_0116:
						this.bool_0 = false;
						goto IL_011D;
						IL_0026:
						List<string>.Enumerator enumerator;
						List<string> list;
						try
						{
							IL_00E0:
							while (enumerator.MoveNext())
							{
								string text;
								string text2;
								for (;;)
								{
									text = enumerator.Current;
									int num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
									{
										goto IL_005D;
									}
									IL_0066:
									switch (num2)
									{
									case 0:
										goto IL_005D;
									case 1:
										goto IL_00C7;
									case 2:
									case 9:
									case 11:
										goto IL_00D7;
									case 3:
										goto IL_00E0;
									case 4:
									case 10:
										goto IL_00BE;
									case 5:
										goto IL_00E9;
									case 6:
										continue;
									case 7:
										break;
									case 8:
										goto IL_002D;
									default:
										goto IL_005D;
									}
									IL_0039:
									text2 = FileHelper.CopyFile(text, this.string_0, true);
									num2 = 3;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
									{
										break;
									}
									goto IL_0066;
									IL_002D:
									if (File.Exists(text))
									{
										goto IL_0039;
									}
									goto IL_00BE;
									IL_005D:
									text2 = string.Empty;
									goto IL_002D;
								}
								IL_00D7:
								list.Add(text2);
								continue;
								IL_00BE:
								if (Directory.Exists(text))
								{
									goto IL_00C7;
								}
								goto IL_00D7;
								IL_00C7:
								text2 = FileHelper.CopyDirectory(text, this.string_0, true);
								goto IL_00D7;
							}
							IL_00E9:;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
							{
								switch (num3)
								{
								}
							}
						}
						goto IL_0116;
						IL_0019:
						enumerator = this.list_1.GetEnumerator();
						goto IL_0026;
						IL_0012:
						list = new List<string>();
						goto IL_0019;
						IL_01AD:
						int num4;
						num4++;
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto IL_01C5;
						}
						goto IL_01F9;
						IL_0195:
						this.listView_0.Items[num4].Selected = true;
						goto IL_01AD;
						IL_0185:
						FileItem fileItem;
						if (list.Contains(fileItem.FullPath))
						{
							goto IL_0195;
						}
						goto IL_01AD;
						IL_0167:
						fileItem = (FileItem)this.listView_0.Items[num4].Tag;
						goto IL_0185;
						IL_01C5:
						if (num4 < this.listView_0.Items.Count)
						{
							goto IL_0167;
						}
						goto IL_02B0;
						IL_01DF:
						num4 = 0;
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
						{
							goto IL_01C5;
						}
						goto IL_01F9;
					}
					IL_02AE:
					return;
					IL_02B0:
					this.listView_0.Focus();
				}
				IL_02BC:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(2128228044 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					switch (num5)
					{
					}
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00014940 File Offset: 0x00012B40
		private void method_16(object sender, EventArgs e)
		{
			try
			{
				ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_01B5;
				}
				goto IL_01D9;
				IL_002A:
				List<string> list;
				if (list.Count <= 0)
				{
					goto IL_021B;
				}
				IL_0037:
				Clipboard.SetText(list[0]);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0271;
				}
				goto IL_01D9;
				IL_005E:
				IEnumerator enumerator;
				try
				{
					IL_0101:
					while (enumerator.MoveNext())
					{
						FileItem fileItem;
						for (;;)
						{
							IL_00E7:
							fileItem = (FileItem)((ListViewItem)enumerator.Current).Tag;
							for (;;)
							{
								if (fileItem.IsDirectory)
								{
									goto IL_00A1;
								}
								int num2 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
								{
									goto Block_10;
								}
								IL_0079:
								switch (num2)
								{
								case 2:
									goto IL_0101;
								case 3:
								case 4:
									goto IL_013D;
								case 5:
									goto IL_00E7;
								case 6:
									continue;
								case 7:
									IL_00A1:
									if (Class15.smethod_17(974448291 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f).Equals(fileItem.Extension))
									{
										goto IL_0101;
									}
									num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
									{
										goto IL_0079;
									}
									break;
								}
								goto Block_8;
							}
						}
						Block_8:
						Block_10:
						list.Add(archiveInfo.IsAsarFile ? Path.Combine(archiveInfo.RelativePath, fileItem.Name) : fileItem.FullPath);
						IL_013D:
						goto IL_002A;
					}
					goto IL_013D;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						goto IL_0172;
					}
					IL_015D:
					if (disposable != null)
					{
						goto IL_018D;
					}
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_0194;
					}
					IL_0172:
					switch (num3)
					{
					case 0:
						goto IL_015D;
					case 1:
					case 3:
						goto IL_0194;
					case 2:
						break;
					default:
						goto IL_015D;
					}
					IL_018D:
					disposable.Dispose();
					IL_0194:;
				}
				IL_0195:
				enumerator = this.listView_0.SelectedItems.GetEnumerator();
				goto IL_005E;
				IL_01AC:
				list = new List<string>();
				goto IL_0195;
				IL_01B5:
				if (this.listView_0.SelectedItems.Count > 0)
				{
					goto IL_01AC;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0247;
				}
				IL_01D9:
				switch (num)
				{
				case 0:
					goto IL_01B5;
				case 1:
					goto IL_01AC;
				case 2:
					goto IL_0195;
				case 3:
				case 5:
				case 7:
					goto IL_0271;
				case 4:
				case 9:
					break;
				case 6:
					goto IL_0037;
				case 8:
					goto IL_005E;
				case 10:
				case 12:
					goto IL_0247;
				case 11:
					goto IL_002A;
				default:
					goto IL_01B5;
				}
				IL_021B:
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(89035048 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_0271;
				IL_0247:
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(613118317 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				IL_0271:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(1387462814 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00014C38 File Offset: 0x00012E38
		private void method_17(object sender, EventArgs e)
		{
			for (;;)
			{
				IEnumerator<int> enumerator = Enumerable.Range(0, this.listView_0.Items.Count).GetEnumerator();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_0006;
				}
				goto IL_00EF;
				do
				{
					IL_00CF:
					this.listView_0.Focus();
					num = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0);
				IL_00EF:
				switch (num)
				{
				case 0:
					goto IL_00CF;
				case 1:
					return;
				case 2:
					IL_0006:
					try
					{
						for (;;)
						{
							if (enumerator.MoveNext())
							{
								goto IL_0046;
							}
							int num2 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
							{
								break;
							}
							IL_002E:
							int num3;
							switch (num2)
							{
							case 1:
								IL_0046:
								num3 = enumerator.Current;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
								{
									goto IL_002E;
								}
								break;
							case 2:
								goto IL_0087;
							case 3:
								continue;
							}
							this.listView_0.SelectedIndices.Add(num3);
							num2 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
							{
								goto IL_002E;
							}
							break;
						}
						IL_0087:;
					}
					finally
					{
						if (enumerator != null)
						{
							goto IL_00B5;
						}
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							goto IL_00CE;
						}
						IL_00A1:
						switch (num4)
						{
						case 1:
							IL_00B5:
							enumerator.Dispose();
							num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
							{
								goto IL_00A1;
							}
							break;
						}
						IL_00CE:;
					}
					goto IL_00CF;
				case 3:
					break;
				default:
					goto IL_00CF;
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00014D90 File Offset: 0x00012F90
		private void method_18(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_00A6:
				List<int> list = new List<int>(this.listView_0.SelectedIndices.Cast<int>());
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0055;
				}
				for (;;)
				{
					IL_007A:
					int num2;
					switch (num)
					{
					case 0:
					case 8:
						goto IL_0041;
					case 1:
						return;
					case 2:
						goto IL_0055;
					case 3:
					case 4:
						goto IL_0006;
					case 5:
						num2 = 0;
						goto IL_0041;
					case 6:
						goto IL_00A6;
					case 7:
						break;
					default:
						goto IL_0041;
					}
					IL_0029:
					num2++;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
					{
						goto IL_0041;
					}
					continue;
					IL_0006:
					this.listView_0.Items[num2].Selected = !list.Contains(num2);
					goto IL_0029;
					IL_0041:
					if (num2 >= this.listView_0.Items.Count)
					{
						break;
					}
					goto IL_0006;
				}
				IL_0055:
				this.listView_0.Focus();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					break;
				}
				goto IL_007A;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00014E70 File Offset: 0x00013070
		private void method_19(object sender, EventArgs e)
		{
			for (;;)
			{
				base.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
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
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00014EA8 File Offset: 0x000130A8
		private void method_20(object sender, EventArgs e)
		{
			int? num3;
			for (;;)
			{
				IL_0200:
				if (this.listView_0.SelectedItems.Count > 0)
				{
					goto IL_019B;
				}
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(314769445 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				int num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_00AC;
				}
				ListView.SelectedListViewItemCollection selectedItems;
				int num2;
				for (;;)
				{
					IL_01A5:
					switch (num)
					{
					case 1:
					case 15:
						goto IL_0134;
					case 3:
					case 17:
						goto IL_014C;
					case 4:
						goto IL_019B;
					case 5:
						goto IL_0200;
					case 6:
						goto IL_00FF;
					case 7:
						goto IL_021C;
					case 8:
						goto IL_017A;
					case 9:
						goto IL_0160;
					case 10:
						return;
					case 11:
						return;
					case 12:
					case 18:
						goto IL_00AC;
					case 13:
						goto IL_00CC;
					case 14:
						return;
					case 16:
						goto IL_00F6;
					case 19:
						MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(1116164263 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							continue;
						}
						break;
					}
					break;
					IL_00CC:
					FileItem fileItem = (FileItem)selectedItems[num2].Tag;
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto IL_00F6;
					}
					continue;
					IL_014C:
					if (num2 >= selectedItems.Count)
					{
						break;
					}
					goto IL_00CC;
					IL_00FF:
					if (!Class15.smethod_17(2048538197 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).Equals(fileItem.Extension))
					{
						goto IL_00AC;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_0134;
					}
					continue;
					IL_00F6:
					if (fileItem.IsDirectory)
					{
						goto IL_00FF;
					}
					goto IL_00AC;
					IL_0134:
					num2++;
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_014C;
					}
				}
				IL_0086:
				if (num3 != null)
				{
					goto IL_021C;
				}
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					break;
				}
				goto IL_01A5;
				IL_00AC:
				num3 = new int?(num2);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_0086;
				}
				goto IL_01A5;
				IL_0160:
				num2 = 0;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0086;
				}
				goto IL_01A5;
				IL_017A:
				selectedItems = this.listView_0.SelectedItems;
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_0160;
				}
				goto IL_01A5;
				IL_019B:
				num3 = null;
				goto IL_017A;
			}
			return;
			IL_021C:
			this.listView_0.SelectedItems[num3.Value].BeginEdit();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000150F0 File Offset: 0x000132F0
		private void method_21(object sender, EventArgs e)
		{
			for (;;)
			{
				new SettingForm
				{
					StartPosition = FormStartPosition.CenterParent,
					Icon = base.Icon
				}.ShowDialog(this);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
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
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00015140 File Offset: 0x00013340
		private void method_22(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_00A2:
				AppHelper.AppConfigCenter.FileViewType = 1;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.toolStripMenuItem_40.Checked = true;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
						{
							goto IL_0050;
						}
						continue;
					case 2:
						goto IL_00A2;
					case 3:
						goto IL_0030;
					case 4:
						goto IL_0050;
					case 5:
						goto IL_0024;
					case 6:
						goto IL_0006;
					}
					return;
					IL_0006:
					this.toolStripMenuItem_15.Checked = true;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_0024;
					}
					continue;
					IL_0050:
					this.toolStripMenuItem_41.Checked = false;
					goto IL_0006;
					IL_0030:
					this.listView_0.View = View.List;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						return;
					}
					continue;
					IL_0024:
					this.toolStripMenuItem_16.Checked = false;
					goto IL_0030;
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00015210 File Offset: 0x00013410
		private void method_23(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_00B4:
				AppHelper.AppConfigCenter.FileViewType = 0;
				for (;;)
				{
					IL_00A6:
					this.toolStripMenuItem_40.Checked = false;
					for (;;)
					{
						this.toolStripMenuItem_41.Checked = true;
						int num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
						{
							goto IL_0006;
						}
						IL_005F:
						switch (num)
						{
						case 1:
							goto IL_0042;
						case 2:
							continue;
						case 3:
							IL_0006:
							this.toolStripMenuItem_15.Checked = false;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
							{
								goto IL_005F;
							}
							break;
						case 4:
							return;
						case 5:
							goto IL_00A6;
						case 6:
							goto IL_00B4;
						}
						this.toolStripMenuItem_16.Checked = true;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
						{
							goto IL_005F;
						}
						IL_0042:
						this.listView_0.View = View.Details;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto IL_005F;
						}
						return;
					}
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000152E0 File Offset: 0x000134E0
		private void method_24(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(543259884 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
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
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0001532C File Offset: 0x0001352C
		private void method_25(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(1471363231 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
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
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00015378 File Offset: 0x00013578
		private void method_26(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(1743167518 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
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
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000153C4 File Offset: 0x000135C4
		private void method_27(object sender, EventArgs e)
		{
			for (;;)
			{
				new AboutForm(Class15.smethod_17(1829607979 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae))
				{
					StartPosition = FormStartPosition.CenterParent,
					Icon = base.Icon
				}.ShowDialog(this);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
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
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00015428 File Offset: 0x00013628
		private void method_28(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_015A:
				ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
				for (;;)
				{
					IL_012E:
					this.toolStripMenuItem_25.Visible = !archiveInfo.IsAsarFile;
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_009C;
					}
					for (;;)
					{
						IL_00F9:
						switch (num)
						{
						case 1:
							return;
						case 2:
							goto IL_012E;
						case 3:
							goto IL_015A;
						case 4:
							goto IL_001B;
						case 5:
							goto IL_0082;
						case 6:
							goto IL_005B;
						case 7:
							this.toolStripMenuItem_47.Enabled = this.bool_0;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
							{
								continue;
							}
							break;
						case 8:
							goto IL_009C;
						case 9:
							goto IL_0046;
						case 10:
							goto IL_0006;
						}
						this.toolStripMenuItem_23.Enabled = archiveInfo.IsAsarFile;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
						{
							return;
						}
					}
					IL_001B:
					this.toolStripMenuItem_26.Enabled = this.bool_0;
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						continue;
					}
					goto IL_00F9;
					IL_0006:
					this.toolStripMenuItem_7.Enabled = !archiveInfo.IsAsarFile;
					goto IL_001B;
					IL_0082:
					this.toolStripMenuItem_25.Enabled = !archiveInfo.IsAsarFile;
					goto IL_0006;
					IL_005B:
					this.toolStripMenuItem_47.Visible = !archiveInfo.IsAsarFile;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_0082;
					}
					goto IL_00F9;
					IL_0046:
					this.toolStripMenuItem_26.Visible = !archiveInfo.IsAsarFile;
					goto IL_005B;
					IL_009C:
					this.toolStripMenuItem_7.Visible = !archiveInfo.IsAsarFile;
					goto IL_0046;
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000155A4 File Offset: 0x000137A4
		private void method_29(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_0001:
				List<string> list = new List<string>();
				for (;;)
				{
					IL_0008:
					List<ItemFilter> list2 = new List<ItemFilter>();
					int num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0024;
					}
					OpenFileDialog openFileDialog;
					ArchiveInfo archiveInfo;
					FileInfo fileInfo;
					string fileNameWithoutExtension;
					string text3;
					for (;;)
					{
						IL_0783:
						switch (num)
						{
						case 1:
							goto IL_0321;
						case 2:
							goto IL_0260;
						case 3:
							goto IL_01D6;
						case 4:
							this.method_9(this.string_0, false, false);
							num = 34;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
							{
								goto Block_15;
							}
							continue;
						case 6:
							goto IL_074C;
						case 7:
							goto IL_024B;
						case 8:
							goto IL_0254;
						case 9:
							goto IL_0024;
						case 10:
						case 35:
							goto IL_026E;
						case 11:
							goto IL_0221;
						case 12:
						case 38:
							goto IL_0853;
						case 13:
							try
							{
								openFileDialog.Filter = Class15.smethod_17(2071400092 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
								for (;;)
								{
									IL_06F2:
									openFileDialog.RestoreDirectory = false;
									for (;;)
									{
										IL_06E8:
										openFileDialog.Multiselect = true;
										while (openFileDialog.ShowDialog() == DialogResult.OK)
										{
											int num2 = 8;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
											{
												goto IL_05C4;
											}
											IL_068C:
											switch (num2)
											{
											case 0:
											case 6:
												goto IL_0673;
											case 1:
												break;
											case 2:
											case 16:
												goto IL_0702;
											case 3:
												goto IL_05F3;
											case 4:
												goto IL_06FD;
											case 5:
												continue;
											case 7:
												goto IL_060D;
											case 8:
												goto IL_0652;
											case 9:
												goto IL_06E8;
											case 10:
												goto IL_0707;
											case 11:
												goto IL_065B;
											case 12:
												goto IL_06F2;
											case 13:
												goto IL_0629;
											case 14:
												goto IL_0614;
											case 15:
												IL_05C4:
												if (string.IsNullOrWhiteSpace(openFileDialog.FileName))
												{
													goto IL_0702;
												}
												break;
											default:
												goto IL_0673;
											}
											string[] fileNames = openFileDialog.FileNames;
											num2 = 3;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
											{
												goto IL_068C;
											}
											IL_05F3:
											int num3 = 0;
											num2 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
											{
												goto IL_0673;
											}
											goto IL_068C;
											IL_0629:
											string text;
											string text2;
											ItemFilter itemFilter = new ItemFilter
											{
												FullPath = text,
												Path = text2
											};
											num2 = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
											{
												goto IL_0652;
											}
											goto IL_068C;
											IL_0614:
											text2 = Path.Combine(archiveInfo.RelativePath, Path.GetFileName(text));
											goto IL_0629;
											IL_060D:
											text = fileNames[num3];
											goto IL_0614;
											IL_0673:
											if (num3 < fileNames.Length)
											{
												goto IL_060D;
											}
											num2 = 2;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
											{
												goto IL_068C;
											}
											goto IL_06FC;
											IL_065B:
											num3++;
											num2 = 1;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
											{
												goto IL_0673;
											}
											goto IL_068C;
											IL_0652:
											list2.Add(itemFilter);
											goto IL_065B;
										}
										goto IL_0707;
									}
								}
								IL_06FC:
								IL_06FD:
								IL_0702:
								goto IL_0840;
								IL_0707:
								return;
							}
							finally
							{
								if (openFileDialog != null)
								{
									int num4 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
									{
										goto IL_073A;
									}
									IL_0722:
									((IDisposable)openFileDialog).Dispose();
									num4 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
									{
										goto IL_074B;
									}
									IL_073A:
									switch (num4)
									{
									case 0:
										goto IL_0722;
									case 1:
										break;
									default:
										goto IL_0722;
									}
								}
								IL_074B:;
							}
							goto IL_074C;
						case 14:
							goto IL_057E;
						case 15:
							goto IL_0203;
						case 16:
							goto IL_02B2;
						case 17:
							goto IL_00A1;
						case 18:
							goto IL_055D;
						case 19:
							goto IL_01CD;
						case 20:
							goto IL_0075;
						case 21:
						case 37:
							goto IL_0840;
						case 22:
							goto IL_00B3;
						case 23:
							goto IL_0008;
						case 24:
							goto IL_0001;
						case 25:
							goto IL_01F3;
						case 26:
							goto IL_02D7;
						case 27:
							goto IL_0283;
						case 28:
							goto IL_053A;
						case 29:
							goto IL_01E9;
						case 31:
							goto IL_0488;
						case 32:
							goto IL_01FC;
						case 34:
							return;
						case 39:
							goto IL_0277;
						case 40:
							goto IL_04DF;
						case 41:
							goto IL_004D;
						case 42:
							return;
						}
						break;
						IL_04DF:
						text3 = Path.Combine(fileInfo.DirectoryName, fileNameWithoutExtension + Class15.smethod_17(2060610002 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177));
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							break;
						}
						continue;
						IL_074C:
						if (fileInfo.DirectoryName == null)
						{
							break;
						}
						goto IL_04DF;
					}
					goto IL_04CC;
					Block_15:
					goto IL_026E;
					goto IL_04CC;
					IL_0024:
					archiveInfo = this.method_6(this.string_0, false);
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						goto IL_057E;
					}
					goto IL_0783;
					IL_004D:
					if (this.listView_0.SelectedItems.Count <= 0)
					{
						goto IL_00A1;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_0075;
					}
					goto IL_0783;
					IL_0840:
					if (list.Count <= 0)
					{
						goto IL_004D;
					}
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto IL_0254;
					}
					goto IL_0783;
					IL_057E:
					if (!archiveInfo.IsAsarFile)
					{
						goto IL_0840;
					}
					goto IL_053A;
					IL_0075:
					IEnumerator enumerator = this.listView_0.SelectedItems.GetEnumerator();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_0321;
					}
					goto IL_0783;
					IL_0203:
					string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(text3);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						goto IL_0221;
					}
					goto IL_0783;
					IL_01FC:
					string directoryName;
					if (directoryName != null)
					{
						goto IL_0203;
					}
					goto IL_04CC;
					IL_01F3:
					directoryName = Path.GetDirectoryName(text3);
					goto IL_01FC;
					IL_01E9:
					if (list.Count == 1)
					{
						goto IL_01F3;
					}
					goto IL_024B;
					IL_01E7:
					string text4;
					text3 = text4;
					goto IL_01E9;
					IL_01CD:
					if (!archiveInfo.IsAsarFile)
					{
						goto IL_01D6;
					}
					text4 = archiveInfo.FullPath;
					goto IL_01E7;
					IL_0853:
					if (list.Count <= 0)
					{
						goto IL_0488;
					}
					goto IL_01CD;
					IL_0321:
					try
					{
						for (;;)
						{
							if (enumerator.MoveNext())
							{
								goto IL_03C3;
							}
							int num5 = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
							{
								break;
							}
							goto IL_039B;
							IL_0345:
							FileItem fileItem;
							if (!Class15.smethod_17(1953682983 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).Equals(fileItem.Extension))
							{
								goto IL_037C;
							}
							num5 = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
							{
								continue;
							}
							goto IL_039B;
							IL_0328:
							if (fileItem.IsDirectory)
							{
								goto IL_0345;
							}
							num5 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
							{
								goto IL_037C;
							}
							goto IL_039B;
							IL_03C3:
							fileItem = (FileItem)((ListViewItem)enumerator.Current).Tag;
							num5 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
							{
								goto IL_0328;
							}
							IL_039B:
							switch (num5)
							{
							case 1:
								goto IL_0345;
							case 2:
								goto IL_03C3;
							case 4:
							case 6:
								continue;
							case 5:
								goto IL_0328;
							case 7:
								goto IL_0419;
							}
							IL_037C:
							list.Add(fileItem.FullPath);
							num5 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
							{
								goto IL_039B;
							}
						}
						IL_0419:
						goto IL_0853;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num6 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_0456;
						}
						goto IL_046B;
						IL_043B:
						disposable.Dispose();
						num6 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto IL_0487;
						}
						goto IL_046B;
						IL_0456:
						if (disposable != null)
						{
							goto IL_043B;
						}
						num6 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_0487;
						}
						IL_046B:
						switch (num6)
						{
						case 2:
							goto IL_0456;
						case 3:
							goto IL_043B;
						}
						IL_0487:;
					}
					goto IL_0488;
					IL_00B3:
					try
					{
						IL_0155:
						while (enumerator.MoveNext())
						{
							FileItem fileItem2;
							for (;;)
							{
								fileItem2 = (FileItem)((ListViewItem)enumerator.Current).Tag;
								int num7 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
								{
									goto IL_00BA;
								}
								IL_00D7:
								switch (num7)
								{
								case 1:
									continue;
								case 2:
									goto IL_0147;
								case 3:
									goto IL_0155;
								case 4:
									IL_00BA:
									if (!fileItem2.IsDirectory)
									{
										goto IL_0147;
									}
									num7 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
									{
										goto IL_00D7;
									}
									break;
								case 5:
									goto IL_015E;
								}
								break;
							}
							IL_0124:
							if (!Class15.smethod_17(1788629090 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).Equals(fileItem2.Extension))
							{
								goto IL_0147;
							}
							continue;
							goto IL_0124;
							IL_0147:
							list.Add(fileItem2.FullPath);
							continue;
							goto IL_0124;
						}
						IL_015E:
						goto IL_0853;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num8 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							goto IL_019B;
						}
						goto IL_01B0;
						IL_0180:
						disposable.Dispose();
						num8 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							goto IL_01CC;
						}
						goto IL_01B0;
						IL_019B:
						if (disposable != null)
						{
							goto IL_0180;
						}
						num8 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							goto IL_01CC;
						}
						IL_01B0:
						switch (num8)
						{
						case 1:
							goto IL_019B;
						case 3:
							goto IL_0180;
						}
						IL_01CC:;
					}
					goto IL_01CD;
					IL_00A1:
					enumerator = this.listView_0.Items.GetEnumerator();
					goto IL_00B3;
					IL_01D6:
					text4 = list[0];
					goto IL_01E7;
					IL_02B2:
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.DirectoryName);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0321;
					}
					goto IL_0783;
					IL_0260:
					if (fileInfo.Directory.Parent == null)
					{
						goto IL_026E;
					}
					goto IL_02B2;
					IL_0254:
					if (fileInfo.Directory != null)
					{
						goto IL_0260;
					}
					goto IL_04CC;
					IL_024B:
					fileInfo = new FileInfo(text3);
					goto IL_0254;
					IL_02ED:
					object obj2;
					object obj = obj2;
					obj.StartPosition = FormStartPosition.CenterParent;
					obj.Icon = base.Icon;
					if (obj.ShowDialog(this) != DialogResult.OK)
					{
						return;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_0321;
					}
					goto IL_0783;
					IL_04CC:
					if (list2.Count <= 0)
					{
						goto IL_02D7;
					}
					obj2 = new CompressForm(text3, null, list2);
					goto IL_02ED;
					IL_0283:
					string fileNameWithoutExtension3;
					text3 = Path.Combine(fileInfo.DirectoryName, fileNameWithoutExtension3 + Class15.smethod_17(486530884 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
					goto IL_04CC;
					IL_0277:
					if (fileInfo.DirectoryName != null)
					{
						goto IL_0283;
					}
					goto IL_04CC;
					IL_026E:
					fileNameWithoutExtension3 = Path.GetFileNameWithoutExtension(text3);
					goto IL_0277;
					IL_0221:
					text3 = Path.Combine(directoryName, fileNameWithoutExtension2 + Class15.smethod_17(486530884 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
					goto IL_04CC;
					IL_02D7:
					obj2 = new CompressForm(text3, list, null);
					goto IL_02ED;
					IL_0488:
					MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(41443501 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = 42;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_0221;
					}
					goto IL_0783;
					IL_053A:
					list.Add(archiveInfo.FullPath);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0783;
					}
					IL_055D:
					openFileDialog = new OpenFileDialog();
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						goto IL_04CC;
					}
					goto IL_0783;
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00015E64 File Offset: 0x00014064
		private void method_30(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				for (;;)
				{
					IL_06A5:
					List<ItemFilter> list2 = new List<ItemFilter>();
					int num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_052C;
					}
					goto IL_060E;
					FileInfo fileInfo;
					string text;
					do
					{
						IL_01ED:
						text = Path.Combine(fileInfo.Directory.FullName, FileHelper.GetBaseName(fileInfo.FullName));
						num = 3;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0);
					List<ItemFilter> list3;
					for (;;)
					{
						IL_060E:
						IEnumerator enumerator;
						ArchiveInfo archiveInfo;
						string text2;
						switch (num)
						{
						case 0:
							goto IL_0256;
						case 1:
							goto IL_01ED;
						case 2:
							goto IL_06CA;
						case 3:
						case 18:
						case 27:
							goto IL_02D2;
						case 4:
						case 7:
							goto IL_01BB;
						case 5:
							goto IL_001F;
						case 6:
							enumerator = this.listView_0.SelectedItems.GetEnumerator();
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
							{
								goto IL_0413;
							}
							continue;
						case 8:
							goto IL_0334;
						case 9:
							goto IL_037F;
						case 10:
							goto IL_0223;
						case 11:
							archiveInfo = this.method_6(this.string_0, false);
							goto IL_058F;
						case 12:
							goto IL_05AF;
						case 13:
							goto IL_035C;
						case 14:
							goto IL_0295;
						case 15:
							goto IL_0230;
						case 16:
							goto IL_029E;
						case 17:
						case 22:
						case 28:
							goto IL_06FA;
						case 19:
							goto IL_023A;
						case 20:
							break;
						case 21:
							goto IL_058F;
						case 23:
							if (!File.Exists(text2))
							{
								goto IL_02D2;
							}
							num = 32;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
							{
								goto IL_0404;
							}
							continue;
						case 24:
							goto IL_054D;
						case 25:
							goto IL_052C;
						case 26:
							goto IL_0413;
						case 29:
							goto IL_06A5;
						case 30:
							goto IL_02F3;
						case 31:
							goto IL_0277;
						case 32:
							goto IL_0404;
						case 33:
							goto IL_03C3;
						case 34:
							goto IL_000D;
						default:
							goto IL_0256;
						}
						IL_01C5:
						if (this.listView_0.SelectedItems.Count <= 0)
						{
							goto IL_0223;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto IL_01ED;
						}
						continue;
						IL_01BB:
						if (list.Count <= 0)
						{
							goto IL_01C5;
						}
						goto IL_0223;
						IL_001F:
						try
						{
							for (;;)
							{
								IL_014D:
								if (enumerator.MoveNext())
								{
									goto IL_00F1;
								}
								int num2 = 4;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
								{
									break;
								}
								FileItem fileItem;
								string relativePath;
								ItemFilter itemFilter;
								for (;;)
								{
									IL_00B5:
									switch (num2)
									{
									case 1:
										goto IL_0120;
									case 2:
										goto IL_0069;
									case 3:
									case 5:
									case 11:
										goto IL_014D;
									case 4:
										goto IL_015A;
									case 6:
										goto IL_012B;
									case 7:
										goto IL_00F1;
									case 8:
										goto IL_0042;
									case 9:
										goto IL_008F;
									case 10:
										itemFilter = new ItemFilter
										{
											FullPath = fileItem.FullPath,
											Path = relativePath
										};
										goto IL_0042;
									}
									goto Block_27;
									IL_0042:
									if (!fileItem.IsDirectory)
									{
										goto IL_012B;
									}
									num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
									{
										goto IL_0060;
									}
								}
								IL_0120:
								list3.Add(itemFilter);
								continue;
								IL_012B:
								list2.Add(itemFilter);
								continue;
								Block_27:
								goto IL_0060;
								IL_0069:
								if (!Class15.smethod_17(277641988 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98).Equals(fileItem.Extension))
								{
									goto IL_008F;
								}
								continue;
								IL_0060:
								if (fileItem.IsDirectory)
								{
									goto IL_0069;
								}
								IL_008F:
								relativePath = StringHelper.GetRelativePath(fileItem.FullPath, archiveInfo.FullPath);
								num2 = 10;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
								{
									goto IL_00B5;
								}
								IL_00F1:
								fileItem = (FileItem)((ListViewItem)enumerator.Current).Tag;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
								{
									goto IL_0060;
								}
								goto IL_00B5;
							}
							IL_015A:;
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
							{
								goto IL_01A5;
							}
							IL_0177:
							if (disposable == null)
							{
								goto IL_01BA;
							}
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
							{
								goto IL_01A5;
							}
							IL_018D:
							disposable.Dispose();
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
							{
								goto IL_01BA;
							}
							IL_01A5:
							switch (num3)
							{
							case 1:
								goto IL_018D;
							case 2:
								goto IL_0177;
							}
							IL_01BA:;
						}
						goto IL_01BB;
						IL_000D:
						enumerator = this.listView_0.SelectedItems.GetEnumerator();
						goto IL_001F;
						IL_023A:
						text = string.Empty;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto IL_0256;
						}
						continue;
						IL_0230:
						text2 = list[0];
						goto IL_023A;
						IL_0223:
						if (list.Count > 0)
						{
							goto IL_0230;
						}
						goto IL_037F;
						IL_0256:
						if (!archiveInfo.IsAsarFile)
						{
							goto IL_035C;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
						{
							continue;
						}
						IL_0277:
						FileInfo fileInfo2 = new FileInfo(text2);
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
						{
							goto IL_0295;
						}
						continue;
						IL_029E:
						text = Path.Combine(fileInfo2.Directory.FullName, FileHelper.GetBaseName(fileInfo2.FullName));
						num = 27;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
						{
							goto IL_02D2;
						}
						continue;
						IL_0295:
						if (fileInfo2.Directory != null)
						{
							goto IL_029E;
						}
						IL_02D2:
						if (string.IsNullOrEmpty(text))
						{
							goto IL_06CA;
						}
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							goto IL_02F3;
						}
						continue;
						IL_0404:
						if (fileInfo.Directory != null)
						{
							goto IL_03C3;
						}
						goto IL_02D2;
						IL_02F3:
						if (new ExtractForm(text2, text, list2, list3)
						{
							StartPosition = FormStartPosition.CenterParent,
							Icon = base.Icon
						}.ShowDialog(this) != DialogResult.OK)
						{
							goto IL_06FA;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
						{
							continue;
						}
						IL_0334:
						this.method_9(this.string_0, false, false);
						num = 26;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
						{
							goto Block_8;
						}
						continue;
						IL_035C:
						fileInfo = new FileInfo(text2);
						num = 23;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
						{
							goto Block_9;
						}
						continue;
						IL_037F:
						MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(1829608067 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
						{
							goto Block_10;
						}
						continue;
						IL_03C3:
						if (Path.GetExtension(text2).Equals(Class15.smethod_17(1788753151 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c), StringComparison.OrdinalIgnoreCase))
						{
							goto IL_01ED;
						}
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
						{
							goto IL_02D2;
						}
						continue;
						IL_058F:
						if (!archiveInfo.IsAsarFile)
						{
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
							{
								goto IL_01BB;
							}
							continue;
						}
						IL_05AF:
						list.Add(archiveInfo.FullPath);
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
						{
							continue;
						}
						IL_054D:
						if (this.listView_0.SelectedItems.Count > 0)
						{
							goto IL_000D;
						}
						goto IL_01BB;
						IL_0413:
						try
						{
							FileItem fileItem2;
							for (;;)
							{
								if (enumerator.MoveNext())
								{
									goto IL_0484;
								}
								int num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
								{
									break;
								}
								goto IL_042E;
								IL_0452:
								while (!Class15.smethod_17(1788753665 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).Equals(fileItem2.Extension))
								{
									num4 = 4;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
									{
										goto IL_042E;
									}
								}
								continue;
								IL_042E:
								switch (num4)
								{
								case 0:
									goto IL_0484;
								case 1:
								case 6:
									goto IL_04D2;
								case 2:
									goto IL_0452;
								case 3:
									continue;
								case 4:
									goto IL_04C4;
								case 5:
									break;
								default:
									goto IL_0484;
								}
								IL_0478:
								if (fileItem2.IsDirectory)
								{
									goto IL_0452;
								}
								goto IL_04C4;
								IL_0484:
								fileItem2 = (FileItem)((ListViewItem)enumerator.Current).Tag;
								goto IL_0478;
							}
							goto IL_04D2;
							IL_04C4:
							list.Add(fileItem2.FullPath);
							IL_04D2:
							goto IL_0223;
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							int num5 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
							{
								goto IL_050F;
							}
							goto IL_0516;
							IL_04F4:
							disposable.Dispose();
							num5 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
							{
								break;
							}
							goto IL_0516;
							IL_050F:
							if (disposable != null)
							{
								goto IL_04F4;
							}
							break;
							IL_0516:
							switch (num5)
							{
							case 0:
								goto IL_050F;
							case 1:
								break;
							case 2:
								goto IL_04F4;
							default:
								goto IL_050F;
							}
						}
						break;
					}
					IL_052C:
					list3 = new List<ItemFilter>();
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
					{
						goto IL_01ED;
					}
					goto IL_060E;
				}
				Block_8:
				goto IL_06FA;
				Block_9:
				goto IL_06CA;
				Block_10:
				goto IL_06FA;
				IL_06CA:
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.FileAsarNotFound), Class15.smethod_17(538806331 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				IL_06FA:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(1424572834 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num6 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					switch (num6)
					{
					}
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000165FC File Offset: 0x000147FC
		private void method_31(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				int num4;
				int num5;
				int num6;
				string text2;
				for (;;)
				{
					ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
					int num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_000D;
					}
					goto IL_0378;
					IL_0052:
					while (this.listView_0.SelectedItems.Count <= 0)
					{
						num = 31;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
						{
							goto IL_0378;
						}
					}
					goto IL_0065;
					do
					{
						IL_0216:
						MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.FileAsarNotFound), Class15.smethod_17(197590421 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num = 4;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0);
					IL_0378:
					switch (num)
					{
					case 0:
						goto IL_008C;
					case 1:
					case 24:
						goto IL_0455;
					case 2:
					case 20:
					case 31:
						goto IL_01F2;
					case 3:
						goto IL_0216;
					case 4:
					case 6:
					case 8:
					case 34:
					case 36:
						goto IL_05B2;
					case 5:
					case 23:
						goto IL_04EE;
					case 7:
					case 9:
					case 29:
					case 41:
						goto IL_051B;
					case 10:
						goto IL_02DC;
					case 11:
					case 14:
						goto IL_0320;
					case 12:
						goto IL_0052;
					case 13:
						goto IL_01B9;
					case 15:
						goto IL_04B8;
					case 16:
						goto IL_02E1;
					case 17:
						goto IL_0487;
					case 18:
					case 33:
						break;
					case 19:
						goto IL_04F3;
					case 21:
						goto IL_018E;
					case 22:
						continue;
					case 25:
						goto IL_0520;
					case 26:
						goto IL_0065;
					case 27:
						goto IL_025A;
					case 28:
						goto IL_033C;
					case 30:
						goto IL_0198;
					case 32:
						goto IL_0261;
					case 35:
						goto IL_0300;
					case 37:
						goto IL_01A4;
					case 38:
						goto IL_0578;
					case 39:
						goto IL_01AD;
					case 40:
						IL_000D:
						if (archiveInfo.IsAsarFile)
						{
							goto IL_0300;
						}
						break;
					default:
						goto IL_008C;
					}
					if (list.Count <= 0)
					{
						goto IL_0052;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_01F2;
					}
					goto IL_0378;
					IL_0065:
					IEnumerator enumerator = this.listView_0.SelectedItems.GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_008C;
					}
					goto IL_0378;
					IL_01B9:
					string extension;
					if (!extension.Equals(Class15.smethod_17(1802340845 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4), StringComparison.OrdinalIgnoreCase))
					{
						goto IL_0216;
					}
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_0065;
					}
					goto IL_0378;
					IL_01AD:
					if (!archiveInfo.IsAsarFile)
					{
						goto IL_01B9;
					}
					goto IL_025A;
					IL_01A4:
					string text;
					extension = Path.GetExtension(text);
					goto IL_01AD;
					IL_0198:
					if (File.Exists(text))
					{
						goto IL_01A4;
					}
					goto IL_04B8;
					IL_018E:
					text = list[0];
					goto IL_0198;
					IL_01F2:
					if (list.Count > 0)
					{
						goto IL_018E;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						break;
					}
					goto IL_0378;
					IL_008C:
					try
					{
						FileItem fileItem;
						for (;;)
						{
							if (enumerator.MoveNext())
							{
								goto IL_0093;
							}
							int num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
							{
								goto Block_22;
							}
							IL_00BC:
							switch (num2)
							{
							case 0:
								goto IL_00E5;
							case 1:
							case 3:
								goto IL_0148;
							case 2:
								break;
							case 4:
								continue;
							case 5:
								IL_0093:
								fileItem = (FileItem)((ListViewItem)enumerator.Current).Tag;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
								{
									goto IL_00BC;
								}
								goto IL_00E5;
							case 6:
							case 7:
								goto IL_013A;
							default:
								goto IL_00E5;
							}
							IL_00EE:
							if (!Class15.smethod_17(1270984460 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112).Equals(fileItem.Extension))
							{
								break;
							}
							continue;
							IL_00E5:
							if (fileItem.IsDirectory)
							{
								goto IL_00EE;
							}
							break;
						}
						goto IL_013A;
						Block_22:
						goto IL_0148;
						IL_013A:
						list.Add(fileItem.FullPath);
						IL_0148:
						goto IL_01F2;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num3 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
						{
							switch (num3)
							{
							case 0:
								goto IL_0186;
							case 1:
								break;
							case 2:
							case 3:
								goto IL_018D;
							default:
								goto IL_0186;
							}
						}
						if (disposable == null)
						{
							goto IL_018D;
						}
						IL_0186:
						disposable.Dispose();
						IL_018D:;
					}
					goto IL_018E;
					IL_02E1:
					if (num4 > 0)
					{
						goto IL_0487;
					}
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto Block_14;
					}
					goto IL_0378;
					IL_02DC:
					if (num5 > 0)
					{
						goto IL_02E1;
					}
					goto IL_0320;
					IL_0261:
					List<AsarFile> list2 = WinASAR.ReadASAR(text);
					num5 = list2.Count(new Func<AsarFile, bool>(MainForm.<>c.<>c_0.method_9));
					num4 = list2.Count(new Func<AsarFile, bool>(MainForm.<>c.<>c_0.method_10));
					num6 = list2.Count(new Func<AsarFile, bool>(MainForm.<>c.<>c_0.method_11));
					goto IL_02DC;
					IL_025A:
					text2 = string.Empty;
					goto IL_0261;
					IL_0300:
					list.Add(archiveInfo.FullPath);
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_0378;
					}
					IL_0320:
					if (num5 <= 0)
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							goto Block_16;
						}
						goto IL_0378;
					}
					IL_033C:
					text2 = string.Format(Class15.smethod_17(1829608383 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae), Environment.NewLine, num5);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_0378;
					}
					goto IL_04ED;
				}
				goto IL_0455;
				Block_14:
				Block_16:
				goto IL_04EE;
				IL_0455:
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(197590421 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_05B2;
				IL_0487:
				text2 = string.Format(Class15.smethod_17(543258096 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89), Environment.NewLine, num5, num4);
				goto IL_051B;
				IL_04B8:
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.FileNotFound), Class15.smethod_17(197590421 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_05B2;
				IL_04ED:
				IL_04EE:
				if (num4 <= 0)
				{
					goto IL_051B;
				}
				IL_04F3:
				text2 = string.Format(Class15.smethod_17(699005144 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a), Environment.NewLine, num4);
				IL_051B:
				if (num6 <= 0)
				{
					goto IL_0578;
				}
				IL_0520:
				MessageBox.Show(string.Format(Class15.smethod_17(543257698 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89), num6, Class15.smethod_17(124838338 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719), text2), Class15.smethod_17(314769445 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_05B2;
				IL_0578:
				MessageBox.Show(Class15.smethod_17(1387463132 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923) + text2, Class15.smethod_17(82304718 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_05B2:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(432125991 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num7 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					switch (num7)
					{
					}
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00016C34 File Offset: 0x00014E34
		private void method_32(object sender, EventArgs e)
		{
			while (this.listView_0.SelectedItems.Count > 0)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_003A;
				}
				IL_0059:
				FileItem fileItem;
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_003A:
					fileItem = (FileItem)this.listView_0.SelectedItems[0].Tag;
					break;
				case 2:
					continue;
				case 3:
					return;
				case 4:
					break;
				default:
					return;
				}
				this.method_9(fileItem.FullPath, false, true);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_0059;
				}
				return;
			}
			MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(2071399956 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00016CFC File Offset: 0x00014EFC
		private void method_33(object sender, EventArgs e)
		{
			try
			{
				ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
				int num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					goto IL_00B9;
				}
				IEnumerator enumerator;
				List<string> list;
				for (;;)
				{
					IL_0203:
					switch (num)
					{
					case 1:
					case 18:
						goto IL_0349;
					case 2:
					case 19:
						goto IL_051C;
					case 3:
						goto IL_008D;
					case 4:
						goto IL_0500;
					case 5:
						goto IL_0066;
					case 6:
						goto IL_0262;
					case 7:
						goto IL_00B9;
					case 8:
						goto IL_0096;
					case 9:
						goto IL_0057;
					case 10:
						goto IL_0329;
					case 11:
						goto IL_032E;
					case 12:
						if (this.listView_0.SelectedItems.Count > 0)
						{
							goto IL_0057;
						}
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
						{
							goto Block_4;
						}
						continue;
					case 13:
					case 15:
					case 17:
						goto IL_050E;
					case 14:
						goto IL_0335;
					case 16:
						goto IL_02F4;
					case 20:
						goto IL_0378;
					}
					goto Block_8;
					IL_0066:
					enumerator = this.listView_0.SelectedItems.GetEnumerator();
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						continue;
					}
					IL_008D:
					list = new List<string>();
					goto IL_0066;
					IL_0057:
					if (archiveInfo.IsAsarFile)
					{
						goto Block_5;
					}
					goto IL_008D;
				}
				Block_4:
				goto IL_0349;
				Block_5:
				goto IL_02F4;
				Block_8:
				goto IL_04F2;
				IL_0262:
				List<string>.Enumerator enumerator2;
				try
				{
					for (;;)
					{
						if (enumerator2.MoveNext())
						{
							goto IL_0266;
						}
						int num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
						{
							break;
						}
						IL_0283:
						switch (num2)
						{
						case 1:
							goto IL_02BB;
						case 2:
							IL_0266:
							FileHelper.DeleteFileWithUndo(enumerator2.Current);
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
							{
								goto IL_0283;
							}
							break;
						}
					}
					IL_02BB:
					goto IL_050E;
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						switch (num3)
						{
						}
					}
				}
				goto IL_02EB;
				IL_02F4:
				if (MessageBox.Show(Class15.smethod_17(2048538639 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), Class15.smethod_17(1270980972 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					goto IL_032E;
				}
				IL_0329:
				return;
				IL_032E:
				List<ItemFilter> list2 = new List<ItemFilter>();
				IL_0335:
				enumerator = this.listView_0.Items.GetEnumerator();
				goto IL_0378;
				IL_0349:
				MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(1424572834 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_051C;
				IL_0378:
				try
				{
					IL_0495:
					while (enumerator.MoveNext())
					{
						ItemFilter itemFilter;
						for (;;)
						{
							IL_0478:
							ListViewItem listViewItem = (ListViewItem)enumerator.Current;
							for (;;)
							{
								IL_0468:
								FileItem fileItem = (FileItem)listViewItem.Tag;
								for (;;)
								{
									IL_045C:
									if (!fileItem.IsDirectory)
									{
										goto IL_0413;
									}
									goto IL_0436;
									for (;;)
									{
										IL_03AF:
										int num4;
										switch (num4)
										{
										case 1:
											goto IL_0478;
										case 2:
											goto IL_03EA;
										case 3:
										case 7:
											goto IL_0495;
										case 4:
											goto IL_049E;
										case 5:
										case 10:
											goto IL_0413;
										case 6:
											goto IL_045C;
										case 8:
											goto IL_0468;
										case 9:
											goto IL_0436;
										case 11:
										{
											string relativePath;
											itemFilter = new ItemFilter
											{
												FullPath = fileItem.FullPath,
												Path = relativePath
											};
											num4 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
											{
												continue;
											}
											break;
										}
										}
										goto Block_30;
									}
									for (;;)
									{
										IL_03EA:
										string relativePath = StringHelper.GetRelativePath(fileItem.FullPath, archiveInfo.FullPath);
										int num4 = 11;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
										{
											goto IL_03AF;
										}
									}
									IL_0436:
									if (Class15.smethod_17(197587553 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).Equals(fileItem.Extension))
									{
										int num4 = 6;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
										{
											goto Block_33;
										}
										goto IL_03AF;
									}
									IL_0413:
									if (listViewItem.Selected)
									{
										goto IL_03EA;
									}
									goto IL_0495;
								}
							}
						}
						Block_33:
						continue;
						IL_048C:
						list2.Add(itemFilter);
						continue;
						Block_30:
						goto IL_048C;
					}
					IL_049E:;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					while (disposable != null)
					{
						int num5 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							goto IL_04BD;
						}
						IL_04D5:
						switch (num5)
						{
						case 0:
							goto IL_04F1;
						case 1:
							IL_04BD:
							disposable.Dispose();
							num5 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
							{
								goto IL_04D5;
							}
							goto IL_04F1;
						case 2:
							break;
						default:
							goto IL_04F1;
						}
					}
					IL_04F1:;
				}
				goto IL_04F2;
				IL_0096:
				enumerator2 = list.GetEnumerator();
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_02EB;
				}
				goto IL_0203;
				IL_00B9:
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_0151;
						}
						int num6 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							goto IL_00C0;
						}
						goto IL_0129;
						IL_00F7:
						FileItem fileItem2;
						while (Class15.smethod_17(1953682983 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).Equals(fileItem2.Extension))
						{
							num6 = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
							{
								goto IL_0129;
							}
						}
						IL_00C0:
						list.Add(fileItem2.FullPath);
						num6 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
						{
							continue;
						}
						IL_0129:
						switch (num6)
						{
						case 1:
							goto IL_00F7;
						case 2:
						case 3:
							goto IL_00C0;
						case 4:
							IL_0151:
							fileItem2 = (FileItem)((ListViewItem)enumerator.Current).Tag;
							num6 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
							{
								goto IL_0129;
							}
							break;
						case 5:
							goto IL_01A3;
						case 6:
						case 7:
							continue;
						}
						if (!fileItem2.IsDirectory)
						{
							goto IL_00C0;
						}
						goto IL_00F7;
					}
					IL_01A3:
					goto IL_0096;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					for (;;)
					{
						if (disposable != null)
						{
							goto IL_01B3;
						}
						int num7 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
						{
							break;
						}
						IL_01CB:
						switch (num7)
						{
						case 2:
							IL_01B3:
							disposable.Dispose();
							num7 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
							{
								goto IL_01CB;
							}
							break;
						case 3:
							continue;
						}
						break;
					}
				}
				goto IL_0203;
				IL_02EB:
				IL_04F2:
				if (string.IsNullOrEmpty(archiveInfo.FullPath))
				{
					goto IL_050E;
				}
				IL_0500:
				WinASAR.ReCreateASAR(archiveInfo.FullPath, list2);
				IL_050E:
				this.method_9(this.string_0, false, false);
				IL_051C:;
			}
			catch (Exception ex)
			{
				this.method_9(this.string_0, false, false);
				MessageBox.Show(ex.Message, Class15.smethod_17(1243253894 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num8 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					switch (num8)
					{
					}
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000172DC File Offset: 0x000154DC
		private void JquWidZduU(object sender, EventArgs e)
		{
			for (;;)
			{
				SearchForm searchForm = new SearchForm(this.searchItem_0);
				searchForm.SearchSubmitted += this.method_35;
				searchForm.StartPosition = FormStartPosition.CenterParent;
				searchForm.Icon = base.Icon;
				searchForm.ShowDialog(this);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
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
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00017344 File Offset: 0x00015544
		private void method_34(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_35(this.searchItem_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
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
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00017380 File Offset: 0x00015580
		private void method_35(SearchItem searchItem_1)
		{
			IL_021D:
			while (searchItem_1 != null)
			{
				for (;;)
				{
					this.searchItem_0 = new SearchItem
					{
						Keyword = searchItem_1.Keyword,
						IsMatchCase = searchItem_1.IsMatchCase
					};
					int num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_0156;
					}
					IL_0161:
					string text;
					int num2;
					int num3;
					switch (num)
					{
					case 0:
						goto IL_011E;
					case 1:
						goto IL_0060;
					case 2:
					case 20:
						goto IL_0094;
					case 3:
						goto IL_00D5;
					case 4:
						goto IL_022B;
					case 5:
						goto IL_00DD;
					case 6:
						IL_003E:
						if (this.searchItem_0.IsMatchCase)
						{
							text = this.searchItem_0.Keyword;
							goto IL_007D;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							goto IL_0060;
						}
						goto IL_0161;
					case 7:
						goto IL_001A;
					case 8:
						goto IL_0159;
					case 9:
						goto IL_00FF;
					case 10:
						IL_007F:
						if (num2 > this.int_1)
						{
							goto IL_0089;
						}
						goto IL_0094;
					case 11:
						goto IL_0089;
					case 12:
					case 13:
						goto IL_009A;
					case 14:
						goto IL_0027;
					case 15:
						goto IL_0224;
					case 16:
					case 23:
						goto IL_00CD;
					case 17:
						return;
					case 18:
						goto IL_0136;
					case 19:
					case 26:
						goto IL_0006;
					case 21:
						goto IL_00C9;
					case 22:
						return;
					case 24:
						IL_0156:
						num3 = -1;
						goto IL_0159;
					case 25:
						goto IL_023D;
					case 27:
						continue;
					case 28:
						goto IL_021D;
					default:
						goto IL_011E;
					}
					IL_003C:
					string text3;
					string text2 = text3;
					goto IL_003E;
					IL_0027:
					ListViewItem listViewItem;
					text3 = listViewItem.Text.ToLower();
					goto IL_003C;
					IL_001A:
					if (!this.searchItem_0.IsMatchCase)
					{
						goto IL_0027;
					}
					text3 = listViewItem.Text;
					goto IL_003C;
					IL_0006:
					listViewItem = this.listView_0.Items[num2];
					goto IL_001A;
					IL_009A:
					if (num2 < this.listView_0.Items.Count)
					{
						goto IL_0006;
					}
					goto IL_00CD;
					IL_0094:
					num2++;
					goto IL_009A;
					IL_007D:
					string text4 = text;
					goto IL_007F;
					IL_0060:
					text = this.searchItem_0.Keyword.ToLower();
					goto IL_007D;
					IL_00DD:
					this.listView_0.SelectedItems.Clear();
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
					{
						goto IL_00FF;
					}
					goto IL_0161;
					IL_00D5:
					this.int_1 = num3;
					goto IL_00DD;
					IL_00CD:
					if (num3 > -1)
					{
						goto IL_00D5;
					}
					goto IL_0224;
					IL_00C9:
					num3 = num2;
					goto IL_00CD;
					IL_00FF:
					this.listView_0.EnsureVisible(num3);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
					{
						goto IL_011E;
					}
					goto IL_0161;
					IL_0136:
					this.listView_0.Focus();
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_00DD;
					}
					goto IL_0161;
					IL_011E:
					this.listView_0.Items[num3].Selected = true;
					goto IL_0136;
					IL_0159:
					num2 = 0;
					goto IL_009A;
					IL_0089:
					if (!text2.Contains(text4))
					{
						goto IL_0094;
					}
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_00C9;
					}
					goto IL_0161;
				}
				return;
				IL_0224:
				this.int_1 = -1;
				IL_022B:
				if (string.IsNullOrEmpty(this.searchItem_0.Keyword))
				{
					break;
				}
				IL_023D:
				MessageBox.Show(Class15.smethod_17(277640572 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98) + this.searchItem_0.Keyword + Class15.smethod_17(2021174368 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), Class15.smethod_17(1807890560 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00017624 File Offset: 0x00015824
		private void method_36(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				for (;;)
				{
					IL_024B:
					ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
					for (;;)
					{
						if (!archiveInfo.IsAsarFile)
						{
							goto IL_0218;
						}
						int num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto IL_0040;
						}
						IL_01C1:
						switch (num)
						{
						case 1:
						case 7:
							goto IL_01AE;
						case 2:
							continue;
						case 3:
							goto IL_024B;
						case 4:
						case 5:
							goto IL_0068;
						case 6:
							IL_0040:
							list.Add(archiveInfo.FullPath);
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
							{
								goto IL_0218;
							}
							goto IL_01C1;
						case 9:
							goto IL_00BE;
						case 10:
							goto IL_0218;
						case 11:
							goto IL_025F;
						case 12:
							goto IL_00AC;
						case 13:
							goto IL_000D;
						}
						goto Block_8;
						IL_0068:
						MessageBox.Show(EnumHelper.GetEnumDescription(AsarExceptions.NoFileSelected), Class15.smethod_17(1176456850 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							goto Block_5;
						}
						goto IL_01C1;
						IL_01AE:
						if (list.Count > 0)
						{
							goto IL_025F;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
						{
							goto IL_0068;
						}
						goto IL_01C1;
						IL_00BE:
						IEnumerator enumerator;
						try
						{
							IL_013C:
							while (enumerator.MoveNext())
							{
								FileItem fileItem;
								for (;;)
								{
									fileItem = (FileItem)((ListViewItem)enumerator.Current).Tag;
									int num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
									{
										goto IL_010F;
									}
									switch (num2)
									{
									case 1:
										goto IL_0110;
									case 2:
									case 5:
										goto IL_0159;
									case 3:
										goto IL_0119;
									case 4:
										goto IL_014B;
									case 6:
										goto IL_013C;
									}
								}
								IL_0119:
								if (Class15.smethod_17(2008550907 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).Equals(fileItem.Extension))
								{
									continue;
								}
								goto IL_014B;
								IL_0110:
								if (fileItem.IsDirectory)
								{
									goto IL_0119;
								}
								goto IL_014B;
								IL_010F:
								goto IL_0110;
								IL_014B:
								list.Add(fileItem.FullPath);
								IL_0159:
								break;
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
							{
								goto IL_018B;
							}
							IL_0176:
							if (disposable != null)
							{
								goto IL_01A6;
							}
							num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
							{
								goto IL_01AD;
							}
							IL_018B:
							switch (num3)
							{
							case 0:
								goto IL_0176;
							case 1:
							case 3:
								goto IL_01AD;
							case 2:
								break;
							default:
								goto IL_0176;
							}
							IL_01A6:
							disposable.Dispose();
							IL_01AD:;
						}
						goto IL_01AE;
						IL_00AC:
						enumerator = this.listView_0.SelectedItems.GetEnumerator();
						goto IL_00BE;
						IL_000D:
						if (this.listView_0.SelectedItems.Count > 0)
						{
							goto IL_00AC;
						}
						goto IL_01AE;
						IL_0218:
						if (list.Count <= 0)
						{
							goto IL_000D;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
						{
							goto IL_01AE;
						}
						goto IL_01C1;
					}
				}
				Block_5:
				Block_8:
				goto IL_026C;
				IL_025F:
				FileHelper.ShowFileProperties(list[0]);
				IL_026C:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(538806331 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00017918 File Offset: 0x00015B18
		private void method_37(object sender, EventArgs e)
		{
			IL_00B6:
			while (this.listView_0.Items.Count > 0)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					goto IL_007B;
				}
				goto IL_009A;
				IL_0055:
				FileItem fileItem;
				while (Class15.smethod_17(1788629090 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).Equals(fileItem.Extension))
				{
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_009A;
					}
				}
				break;
				for (;;)
				{
					IL_009A:
					switch (num)
					{
					case 1:
						goto IL_007B;
					case 2:
						goto IL_00B6;
					case 3:
						goto IL_0055;
					case 4:
						this.method_9(fileItem.FullPath, false, false);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
				break;
				IL_007B:
				fileItem = (FileItem)this.listView_0.Items[0].Tag;
				goto IL_0055;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000179F8 File Offset: 0x00015BF8
		private void method_38(object sender, KeyEventArgs e)
		{
			IL_0054:
			while (e.KeyCode == Keys.Return)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_9(this.toolStripComboBox_0.Text.Trim(), false, false);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0054;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00017A6C File Offset: 0x00015C6C
		private void method_39(object sender, CancelEventArgs e)
		{
			FileItem fileItem;
			for (;;)
			{
				IL_0223:
				ArchiveInfo archiveInfo = this.method_6(this.string_0, false);
				for (;;)
				{
					IL_020C:
					this.toolStripMenuItem_25.Visible = !archiveInfo.IsAsarFile;
					for (;;)
					{
						this.toolStripMenuItem_7.Visible = !archiveInfo.IsAsarFile;
						int num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto IL_011F;
						}
						IL_0172:
						switch (num)
						{
						case 0:
							goto IL_0146;
						case 1:
							goto IL_006B;
						case 2:
							continue;
						case 3:
							goto IL_00DF;
						case 4:
							goto IL_00FC;
						case 5:
							goto IL_0030;
						case 6:
						case 9:
							goto IL_0293;
						case 7:
							goto IL_020C;
						case 8:
							goto IL_0223;
						case 10:
							goto IL_00B1;
						case 11:
							goto IL_0045;
						case 12:
							goto IL_0091;
						case 13:
							goto IL_00BD;
						case 14:
							IL_011F:
							this.toolStripMenuItem_26.Visible = !archiveInfo.IsAsarFile;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
							{
								goto IL_0146;
							}
							goto IL_0172;
						case 15:
							goto IL_02AD;
						case 16:
							goto IL_02A0;
						case 17:
							goto IL_025B;
						case 18:
							goto IL_00C9;
						case 19:
							goto IL_0237;
						case 20:
							goto IL_0287;
						case 21:
							goto IL_027B;
						case 22:
							break;
						case 23:
							return;
						default:
							goto IL_0146;
						}
						IL_0006:
						this.toolStripMenuItem_25.Enabled = !archiveInfo.IsAsarFile;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							goto IL_0030;
						}
						goto IL_0172;
						IL_0045:
						this.toolStripMenuItem_26.Enabled = this.bool_0;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
						{
							goto IL_006B;
						}
						goto IL_0172;
						IL_0030:
						this.toolStripMenuItem_7.Enabled = !archiveInfo.IsAsarFile;
						goto IL_0045;
						IL_006B:
						this.toolStripMenuItem_47.Enabled = this.bool_0;
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
						{
							goto IL_0091;
						}
						goto IL_0172;
						IL_00FC:
						if (!fileItem.IsDirectory)
						{
							goto IL_0237;
						}
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto Block_2;
						}
						goto IL_0172;
						IL_00DF:
						fileItem = (FileItem)this.listView_0.SelectedItems[0].Tag;
						goto IL_00FC;
						IL_00C9:
						if (this.listView_0.SelectedItems.Count > 0)
						{
							goto IL_00DF;
						}
						goto IL_0293;
						IL_00BD:
						this.toolStripSeparator_1.Visible = false;
						goto IL_00C9;
						IL_00B1:
						this.toolStripMenuItem_5.Visible = false;
						goto IL_00BD;
						IL_0091:
						this.toolStripMenuItem_5.Text = Class15.smethod_17(594362628 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b);
						goto IL_00B1;
						IL_0146:
						this.toolStripMenuItem_47.Visible = !archiveInfo.IsAsarFile;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
						{
							goto IL_0006;
						}
						goto IL_0172;
					}
				}
			}
			Block_2:
			goto IL_0293;
			IL_0237:
			if (!Class15.smethod_17(1387463032 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).Equals(fileItem.Extension, StringComparison.OrdinalIgnoreCase))
			{
				goto IL_027B;
			}
			IL_025B:
			this.toolStripMenuItem_5.Text = Class15.smethod_17(1116164469 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
			IL_027B:
			this.toolStripMenuItem_5.Visible = true;
			IL_0287:
			this.toolStripSeparator_1.Visible = true;
			IL_0293:
			bool flag = Directory.Exists(this.string_0);
			IL_02A0:
			this.toolStripMenuItem_12.Visible = flag;
			IL_02AD:
			this.toolStripMenuItem_46.Visible = flag;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00017D34 File Offset: 0x00015F34
		private void method_40(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_49(sender, e);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
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
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00017D6C File Offset: 0x00015F6C
		private void method_41(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_9(this.string_0, false, false);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
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
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00017DAC File Offset: 0x00015FAC
		private void method_42(object sender, EventArgs e)
		{
			try
			{
				string text = this.string_0;
				int num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
				{
					goto IL_005C;
				}
				for (;;)
				{
					IL_0164:
					switch (num)
					{
					case 1:
					case 3:
						IL_012F:
						text = Path.Combine(text, Class15.smethod_17(1802339373 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto Block_8;
						}
						continue;
					case 2:
					case 8:
						goto IL_0041;
					case 4:
						goto IL_00DF;
					case 5:
						goto IL_00EC;
					case 6:
						goto IL_0118;
					case 7:
						goto IL_0127;
					case 10:
						goto IL_00BB;
					case 11:
						goto IL_0081;
					case 12:
					case 13:
						goto IL_005C;
					case 14:
						goto IL_00C9;
					case 15:
						if (File.Exists(this.string_0))
						{
							goto IL_0118;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
						{
							continue;
						}
						break;
					case 16:
						goto IL_00B2;
					case 17:
						goto IL_0020;
					}
					goto Block_9;
					IL_012D:
					string directoryName;
					text = directoryName;
					goto IL_012F;
					IL_0127:
					directoryName = this.string_0;
					goto IL_012D;
					IL_0118:
					if ((directoryName = Path.GetDirectoryName(this.string_0)) == null)
					{
						goto IL_0127;
					}
					goto IL_012D;
				}
				IL_00B2:
				string text2 = FileHelper.CreateDirectoryUniqueName(text);
				IL_00BB:
				this.method_9(this.string_0, false, false);
				IL_00C9:
				if (this.listView_0.Items.Count <= 0)
				{
					goto IL_01BB;
				}
				IL_00DF:
				ListView.ListViewItemCollection items = this.listView_0.Items;
				IL_00EC:
				int num2 = 0;
				goto IL_005C;
				goto IL_01BB;
				Block_8:
				goto IL_00B2;
				Block_9:
				goto IL_01BB;
				IL_0020:
				if (((FileItem)items[num2].Tag).FullPath == text2)
				{
					goto IL_0081;
				}
				IL_0041:
				num2++;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0164;
				}
				IL_005C:
				if (num2 < items.Count)
				{
					goto IL_0020;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_01BB;
				}
				goto IL_0164;
				IL_0081:
				this.listView_0.Items[num2].BeginEdit();
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_0164;
				}
				IL_01BB:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(552176112 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					switch (num3)
					{
					}
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00017FD4 File Offset: 0x000161D4
		private void method_43(object sender, EventArgs e)
		{
			try
			{
				string text = this.string_0;
				for (;;)
				{
					if (!File.Exists(this.string_0))
					{
						goto IL_018E;
					}
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0177;
					}
					goto IL_012C;
					IL_005C:
					int num2;
					ListView.ListViewItemCollection items;
					if (num2 < items.Count)
					{
						goto IL_0035;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						continue;
					}
					goto IL_012C;
					IL_0030:
					num2 = 0;
					goto IL_005C;
					IL_000E:
					items = this.listView_0.Items;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_0030;
					}
					goto IL_012C;
					IL_00FF:
					if (this.listView_0.Items.Count <= 0)
					{
						break;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_000E;
					}
					goto IL_012C;
					IL_00DF:
					this.method_9(this.string_0, false, false);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_00FF;
					}
					goto IL_012C;
					IL_00C4:
					string text2 = FileHelper.CreateFileUniqueName(text);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
					{
						goto IL_00DF;
					}
					goto IL_012C;
					IL_018E:
					text = Path.Combine(text, Class15.smethod_17(2021175204 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_00C4;
					}
					goto IL_012C;
					IL_018C:
					string directoryName;
					text = directoryName;
					goto IL_018E;
					IL_0177:
					if ((directoryName = Path.GetDirectoryName(this.string_0)) == null)
					{
						goto IL_0186;
					}
					goto IL_018C;
					IL_012C:
					switch (num)
					{
					case 0:
						goto IL_00DF;
					case 1:
						goto IL_00FF;
					case 2:
					case 13:
						goto IL_005C;
					case 3:
						continue;
					case 4:
						goto IL_0186;
					case 5:
					case 7:
						goto IL_01F1;
					case 6:
						goto IL_0177;
					case 8:
						goto IL_0096;
					case 9:
						goto IL_018E;
					case 10:
						goto IL_0035;
					case 11:
						goto IL_0030;
					case 12:
						break;
					case 14:
						goto IL_00C4;
					case 15:
						goto IL_000E;
					default:
						goto IL_00DF;
					}
					IL_0056:
					num2++;
					goto IL_005C;
					IL_0035:
					if (!(((FileItem)items[num2].Tag).FullPath == text2))
					{
						goto IL_0056;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						goto IL_0096;
					}
					goto IL_012C;
					IL_0186:
					directoryName = this.string_0;
					goto IL_018C;
					IL_0096:
					this.listView_0.Items[num2].BeginEdit();
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						break;
					}
					goto IL_012C;
				}
				IL_01F1:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(1985314680 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					switch (num3)
					{
					}
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00018234 File Offset: 0x00016434
		private void method_44(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_0161:
				int num = 0;
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					goto IL_007E;
				}
				string text;
				for (;;)
				{
					IL_011A:
					switch (num2)
					{
					case 1:
					case 6:
						goto IL_007E;
					case 2:
						goto IL_0161;
					case 3:
						goto IL_005C;
					case 4:
						return;
					case 5:
						goto IL_00C7;
					case 7:
						return;
					case 8:
						goto IL_00D7;
					case 9:
						goto IL_0023;
					case 10:
						this.sortOrder_0 = SortOrder.Ascending;
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							goto IL_00B7;
						}
						continue;
					case 11:
						goto IL_00B7;
					case 12:
						goto IL_0041;
					case 13:
					case 14:
						goto IL_0006;
					}
					break;
					IL_00D7:
					this.method_5(this.list_0, text, this.sortOrder_0);
					num2 = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto Block_7;
					}
					continue;
					IL_00C7:
					AppHelper.AppConfigCenter.SortOrder = (int)this.sortOrder_0;
					goto IL_00D7;
					IL_00B7:
					AppHelper.AppConfigCenter.SortColumn = this.int_0;
					goto IL_00C7;
				}
				goto IL_0098;
				IL_0006:
				num++;
				num2 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_007E;
				}
				goto IL_011A;
				IL_0041:
				if (text != null)
				{
					goto IL_005C;
				}
				num2 = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_0006;
				}
				goto IL_011A;
				IL_0023:
				text = this.listView_0.Columns[num].Tag as string;
				goto IL_0041;
				IL_007E:
				if (num >= this.listView_0.Columns.Count)
				{
					break;
				}
				goto IL_0023;
				IL_0098:
				this.int_0 = num;
				num2 = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto Block_6;
				}
				goto IL_011A;
				IL_005C:
				if (!text.Equals(Class15.smethod_17(538806807 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa), StringComparison.OrdinalIgnoreCase))
				{
					goto IL_0006;
				}
				goto IL_0098;
			}
			return;
			Block_6:
			Block_7:;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000183C4 File Offset: 0x000165C4
		private void method_45(object sender, EventArgs e)
		{
			string text;
			for (;;)
			{
				int num = 0;
				int num2 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_0024;
				}
				IL_00D1:
				switch (num2)
				{
				case 0:
					goto IL_0091;
				case 1:
				case 6:
					goto IL_00A9;
				case 2:
					break;
				case 3:
					goto IL_0063;
				case 4:
					return;
				case 5:
					goto IL_0024;
				case 7:
					continue;
				case 8:
					return;
				case 9:
					goto IL_005B;
				case 10:
				case 14:
					text = this.listView_0.Columns[num].Tag as string;
					goto IL_0024;
				case 11:
					goto IL_006A;
				case 12:
					goto IL_0144;
				case 13:
					goto IL_0134;
				default:
					goto IL_0091;
				}
				IL_0028:
				if (text.Equals(Class15.smethod_17(432126527 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2), StringComparison.OrdinalIgnoreCase))
				{
					goto IL_005B;
				}
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_0091;
				}
				goto IL_00D1;
				IL_0024:
				if (text != null)
				{
					goto IL_0028;
				}
				goto IL_0091;
				IL_006A:
				AppHelper.AppConfigCenter.SortColumn = this.int_0;
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					break;
				}
				goto IL_00D1;
				IL_0063:
				this.sortOrder_0 = SortOrder.Ascending;
				goto IL_006A;
				IL_005B:
				this.int_0 = num;
				goto IL_0063;
				IL_0091:
				num++;
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_00D1;
				}
				IL_00A9:
				if (num >= this.listView_0.Columns.Count)
				{
					return;
				}
				num2 = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_00D1;
				}
			}
			IL_0134:
			AppHelper.AppConfigCenter.SortOrder = (int)this.sortOrder_0;
			IL_0144:
			this.method_5(this.list_0, text, this.sortOrder_0);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0001852C File Offset: 0x0001672C
		private void method_46(object sender, EventArgs e)
		{
			string text;
			for (;;)
			{
				IL_0109:
				int i = 0;
				IL_00F2:
				while (i < this.listView_0.Columns.Count)
				{
					for (;;)
					{
						IL_00B7:
						text = this.listView_0.Columns[i].Tag as string;
						int num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
						{
							goto IL_0006;
						}
						goto IL_0074;
						IL_0033:
						while (text.Equals(Class15.smethod_17(613118819 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), StringComparison.OrdinalIgnoreCase))
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
							{
								goto IL_0074;
							}
						}
						break;
						for (;;)
						{
							IL_0074:
							switch (num)
							{
							case 1:
								this.int_0 = i;
								num = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
								{
									continue;
								}
								goto IL_010E;
							case 2:
								goto IL_010F;
							case 3:
								goto IL_0126;
							case 4:
								goto IL_0136;
							case 5:
							case 13:
								goto IL_00F2;
							case 6:
								goto IL_0109;
							case 7:
								goto IL_0116;
							case 8:
							case 9:
								goto IL_00B7;
							case 10:
								return;
							case 11:
								goto IL_0006;
							case 12:
								return;
							}
							break;
						}
						goto IL_0033;
						IL_0006:
						if (text == null)
						{
							break;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							goto IL_0033;
						}
						goto IL_0074;
					}
					i++;
				}
				return;
			}
			IL_010E:
			IL_010F:
			this.sortOrder_0 = SortOrder.Ascending;
			IL_0116:
			AppHelper.AppConfigCenter.SortColumn = this.int_0;
			IL_0126:
			AppHelper.AppConfigCenter.SortOrder = (int)this.sortOrder_0;
			IL_0136:
			this.method_5(this.list_0, text, this.sortOrder_0);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00018684 File Offset: 0x00016884
		private void method_47(object sender, EventArgs e)
		{
			string text;
			for (;;)
			{
				IL_014B:
				int i = 0;
				IL_0134:
				while (i < this.listView_0.Columns.Count)
				{
					for (;;)
					{
						IL_00FC:
						text = this.listView_0.Columns[i].Tag as string;
						int num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
						{
							goto Block_8;
						}
						for (;;)
						{
							IL_00BC:
							switch (num)
							{
							case 1:
								goto IL_003F;
							case 2:
								return;
							case 3:
								return;
							case 4:
								this.sortOrder_0 = SortOrder.Ascending;
								goto IL_005B;
							case 5:
								if (text != null)
								{
									goto IL_0006;
								}
								goto IL_012E;
							case 6:
								AppHelper.AppConfigCenter.SortOrder = (int)this.sortOrder_0;
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
								{
									continue;
								}
								break;
							case 7:
								goto IL_005B;
							case 8:
								goto IL_012E;
							case 9:
							case 10:
								goto IL_0134;
							case 11:
								goto IL_014B;
							case 12:
								goto IL_00FC;
							case 13:
								goto IL_0006;
							}
							goto Block_7;
							for (;;)
							{
								IL_003F:
								this.int_0 = i;
								num = 4;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
								{
									goto IL_00BC;
								}
							}
							IL_0006:
							if (text.Equals(Class15.smethod_17(1793858214 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a), StringComparison.OrdinalIgnoreCase))
							{
								goto IL_003F;
							}
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
							{
								goto Block_2;
							}
							continue;
							IL_005B:
							AppHelper.AppConfigCenter.SortColumn = this.int_0;
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
							{
								goto IL_003F;
							}
						}
					}
					IL_012E:
					i++;
				}
				return;
			}
			Block_2:
			Block_7:
			goto IL_0158;
			Block_8:
			return;
			IL_0158:
			this.method_5(this.list_0, text, this.sortOrder_0);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00018800 File Offset: 0x00016A00
		private void method_48(object sender, KeyEventArgs e)
		{
			for (;;)
			{
				int num;
				if (e.KeyCode == Keys.Return)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0028;
					}
				}
				else
				{
					if (e.KeyCode == Keys.Back)
					{
						break;
					}
					if (e.KeyData == (Keys)131137)
					{
						goto IL_0085;
					}
					return;
				}
				IL_0052:
				switch (num)
				{
				case 1:
					goto IL_00E1;
				case 2:
					IL_0028:
					if (this.listView_0.SelectedItems.Count > 0)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
						{
							goto IL_0052;
						}
						goto IL_00E0;
					}
					break;
				case 3:
					continue;
				case 4:
					return;
				case 5:
					return;
				case 6:
					goto IL_0103;
				case 7:
					goto IL_01B8;
				case 8:
					goto IL_01C1;
				case 9:
				{
					IL_0085:
					IEnumerator<int> enumerator = Enumerable.Range(0, this.listView_0.Items.Count).GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto Block_5;
					}
					goto IL_0052;
				}
				}
				goto Block_4;
			}
			goto IL_01B8;
			Block_4:
			return;
			Block_5:
			goto IL_0103;
			IL_00E0:
			IL_00E1:
			FileItem fileItem = (FileItem)this.listView_0.SelectedItems[0].Tag;
			goto IL_01C1;
			IL_0103:
			try
			{
				for (;;)
				{
					IEnumerator<int> enumerator;
					if (enumerator.MoveNext())
					{
						goto IL_0107;
					}
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						break;
					}
					IL_0121:
					int num3;
					switch (num2)
					{
					case 1:
						goto IL_013A;
					case 2:
						continue;
					case 3:
						IL_0107:
						num3 = enumerator.Current;
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
						{
							goto IL_0121;
						}
						goto IL_013A;
					}
					break;
					IL_013A:
					this.listView_0.SelectedIndices.Add(num3);
				}
				return;
			}
			finally
			{
				IEnumerator<int> enumerator;
				if (enumerator != null)
				{
					goto IL_019E;
				}
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_01B7;
				}
				IL_018A:
				switch (num4)
				{
				case 1:
					IL_019E:
					enumerator.Dispose();
					num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_018A;
					}
					break;
				}
				IL_01B7:;
			}
			IL_01B8:
			this.method_37(null, null);
			return;
			IL_01C1:
			this.method_9(fileItem.FullPath, false, false);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000189F0 File Offset: 0x00016BF0
		private void method_49(object sender, EventArgs e)
		{
			while (this.listView_0.SelectedItems.Count > 0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					goto IL_0015;
				}
				IL_0043:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0072;
				case 3:
					return;
				}
				IL_0015:
				FileItem fileItem = (FileItem)this.listView_0.SelectedItems[0].Tag;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_0043;
				}
				IL_0072:
				this.method_9(fileItem.FullPath, false, false);
				break;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00018A80 File Offset: 0x00016C80
		private void method_50(object sender, ColumnClickEventArgs e)
		{
			IL_011A:
			while (e.Column >= 0)
			{
				for (;;)
				{
					if (e.Column != this.int_0)
					{
						goto IL_00CF;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_002D;
					}
					IL_008F:
					switch (num)
					{
					case 0:
					case 5:
						goto IL_007A;
					case 1:
						goto IL_0061;
					case 2:
						goto IL_0048;
					case 3:
						goto IL_0127;
					case 4:
						goto IL_003C;
					case 6:
						IL_002D:
						if (this.sortOrder_0 == SortOrder.Ascending)
						{
							goto IL_00CF;
						}
						goto IL_003C;
					case 7:
						break;
					case 8:
						goto IL_0149;
					case 9:
					case 13:
						return;
					case 10:
						goto IL_011A;
					case 11:
						continue;
					case 12:
						goto IL_00CF;
					default:
						goto IL_007A;
					}
					IL_0006:
					AppHelper.AppConfigCenter.SortOrder = (int)this.sortOrder_0;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
					{
						break;
					}
					goto IL_008F;
					IL_007A:
					AppHelper.AppConfigCenter.SortColumn = this.int_0;
					goto IL_0006;
					IL_0048:
					this.sortOrder_0 = SortOrder.Ascending;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						goto IL_0061;
					}
					goto IL_008F;
					IL_003C:
					this.int_0 = e.Column;
					goto IL_0048;
					IL_0061:
					this.sortOrder_0 = SortOrder.Descending;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_007A;
					}
					goto IL_008F;
					IL_00CF:
					this.int_0 = e.Column;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0061;
					}
					goto IL_008F;
				}
				IL_0127:
				string text = this.listView_0.Columns[e.Column].Tag as string;
				IL_0149:
				this.method_5(this.list_0, text, this.sortOrder_0);
				return;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00018BEC File Offset: 0x00016DEC
		private void method_51()
		{
			while (!this.bool_1)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_004E;
				}
				IL_006B:
				switch (num)
				{
				case 0:
					goto IL_004E;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				case 4:
					goto IL_001A;
				default:
					goto IL_004E;
				}
				IL_0028:
				this.timer_0.Change(200, -1);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					break;
				}
				goto IL_006B;
				IL_001A:
				this.timer_0.Change(-1, -1);
				goto IL_0028;
				IL_004E:
				this.bool_1 = true;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_001A;
				}
				goto IL_006B;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00018C94 File Offset: 0x00016E94
		private void method_52(object object_0)
		{
			for (;;)
			{
				base.Invoke(new MethodInvoker(this.method_63));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
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
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002702 File Offset: 0x00000902
		private void method_53(object sender, EventArgs e)
		{
			this.method_51();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00018CD8 File Offset: 0x00016ED8
		private void method_54(object sender, LabelEditEventArgs e)
		{
			IL_0033:
			while (((FileItem)this.listView_0.Items[e.Item].Tag).Type == 0)
			{
				for (;;)
				{
					e.CancelEdit = true;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 3:
							goto IL_0033;
						}
						break;
					}
					break;
				}
				return;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00018D44 File Offset: 0x00016F44
		private void method_55(object sender, LabelEditEventArgs e)
		{
			try
			{
				if (e.Label != null)
				{
					for (;;)
					{
						IL_01DC:
						FileItem fileItem = (FileItem)this.listView_0.Items[e.Item].Tag;
						for (;;)
						{
							IL_01B6:
							string directoryName = Path.GetDirectoryName(fileItem.FullPath);
							int num = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
							{
								goto IL_00FB;
							}
							string text;
							ArchiveInfo archiveInfo;
							for (;;)
							{
								IL_0157:
								string relativePath;
								switch (num)
								{
								case 1:
								case 4:
									goto IL_0082;
								case 2:
									goto IL_01DC;
								case 3:
								case 9:
									goto IL_0204;
								case 5:
									relativePath = StringHelper.GetRelativePath(text, archiveInfo.FullPath);
									goto IL_0012;
								case 6:
								case 7:
								case 16:
									goto IL_00B5;
								case 8:
								case 12:
									goto IL_0064;
								case 10:
									goto IL_00BC;
								case 11:
									goto IL_0138;
								case 13:
									goto IL_00FB;
								case 14:
									archiveInfo = this.method_6(fileItem.FullPath, false);
									num = 11;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
									{
										goto Block_9;
									}
									continue;
								case 15:
									goto IL_00F3;
								case 17:
									goto IL_01B6;
								case 18:
									goto IL_00E1;
								case 19:
									goto IL_0092;
								case 20:
									goto IL_0012;
								}
								goto Block_11;
								IL_0012:
								WinASAR.ReCreateASAR(archiveInfo.FullPath, archiveInfo.RelativePath, relativePath);
								num = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
								{
									goto IL_003C;
								}
							}
							IL_00F3:
							string label = e.Label;
							goto IL_00FB;
							IL_0138:
							if (directoryName != null)
							{
								goto IL_00F3;
							}
							goto IL_0204;
							Block_11:
							IL_003C:
							if (string.IsNullOrEmpty(archiveInfo.RelativePath))
							{
								goto IL_0064;
							}
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
							{
								goto Block_4;
							}
							goto IL_0157;
							IL_00E1:
							if (!archiveInfo.IsAsarFile)
							{
								goto IL_0064;
							}
							goto IL_003C;
							IL_00FB:
							text = Path.Combine(directoryName, label ?? "");
							goto IL_00E1;
							IL_0064:
							if (!fileItem.IsDirectory)
							{
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
								{
									goto IL_0082;
								}
								goto IL_0157;
							}
							IL_0092:
							Directory.Move(fileItem.FullPath, text);
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
							{
								goto IL_00B5;
							}
							goto IL_0157;
							IL_00BC:
							this.method_9(this.string_0, false, false);
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
							{
								goto Block_6;
							}
							goto IL_0157;
							IL_00B5:
							e.CancelEdit = true;
							goto IL_00BC;
							IL_0082:
							File.Move(fileItem.FullPath, text);
							goto IL_00B5;
						}
						Block_9:;
					}
					Block_4:
					Block_6:;
				}
				IL_0204:;
			}
			catch (Exception ex)
			{
				e.CancelEdit = true;
				MessageBox.Show(ex.Message, Class15.smethod_17(486527822 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					switch (num2)
					{
					}
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00018FBC File Offset: 0x000171BC
		private void method_56(object sender, MouseEventArgs e)
		{
			while (e.Button == MouseButtons.Left)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_0015;
				}
				IL_003D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0015:
				this.contextMenuStrip_1.Show(this, base.PointToClient(Control.MousePosition));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_003D;
				}
				break;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0001902C File Offset: 0x0001722C
		private void method_57(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(1807888756 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
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
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00019078 File Offset: 0x00017278
		private void method_58(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_0347:
				if (AppHelper.AppConfigCenter.FileViewType != 1)
				{
					goto IL_0320;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					goto IL_01AC;
				}
				int num2;
				List<Column> displayColumns;
				for (;;)
				{
					IL_028E:
					switch (num)
					{
					case 1:
						goto IL_0347;
					case 2:
						goto IL_0284;
					case 3:
						goto IL_0236;
					case 4:
					case 19:
						goto IL_006E;
					case 5:
					case 7:
						goto IL_008B;
					case 6:
						goto IL_0214;
					case 8:
						goto IL_0259;
					case 9:
						goto IL_024C;
					case 10:
						goto IL_0187;
					case 11:
						goto IL_0320;
					case 12:
						this.sortOrder_0 = ((AppHelper.AppConfigCenter.SortOrder == 2) ? SortOrder.Descending : SortOrder.Ascending);
						goto IL_0214;
					case 13:
					case 17:
						goto IL_02FA;
					case 14:
						goto IL_01CE;
					case 15:
						goto IL_00BD;
					case 16:
					case 21:
						return;
					case 18:
						goto IL_0358;
					case 20:
						goto IL_009F;
					case 22:
						goto IL_0053;
					case 23:
						goto IL_0006;
					}
					break;
					IL_0006:
					MessageBox.Show(Class15.smethod_17(642130442 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), Class15.smethod_17(2071399956 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto Block_1;
					}
					continue;
					IL_01CE:
					if (AppHelper.AppConfigCenter.AppWizardKeys.Contains(Class15.smethod_17(2021175232 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8)))
					{
						goto Block_5;
					}
					goto IL_0006;
					IL_0236:
					string text;
					this.method_5(this.list_0, text, this.sortOrder_0);
					goto IL_01CE;
					IL_0214:
					text = this.listView_0.Columns[this.int_0].Tag as string;
					goto IL_0236;
					IL_0053:
					num2--;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_006E;
					}
					continue;
					IL_00BD:
					List<Column>.Enumerator enumerator;
					ColumnHeader columnHeader;
					try
					{
						IL_014E:
						while (enumerator.MoveNext())
						{
							for (;;)
							{
								IL_0142:
								Column column = enumerator.Current;
								for (;;)
								{
									IL_0132:
									string text2 = columnHeader.Tag as string;
									for (;;)
									{
										int num3;
										if (!column.Name.Equals(text2, StringComparison.OrdinalIgnoreCase))
										{
											num3 = 4;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
											{
												goto Block_16;
											}
											goto IL_00E6;
										}
										do
										{
											IL_00C4:
											columnHeader.Width = column.Width;
											num3 = 1;
										}
										while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0);
										IL_00E6:
										switch (num3)
										{
										case 0:
											goto IL_00C4;
										case 1:
										case 4:
											goto IL_014E;
										case 2:
											break;
										case 3:
											goto IL_0142;
										case 5:
											goto IL_0157;
										case 6:
											goto IL_0132;
										default:
											goto IL_00C4;
										}
									}
								}
							}
							Block_16:;
						}
						IL_0157:
						goto IL_0053;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
						{
							switch (num4)
							{
							}
						}
					}
					goto IL_0187;
					IL_006E:
					if (num2 < 0)
					{
						goto IL_0187;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_008B;
					}
					continue;
					IL_009F:
					enumerator = displayColumns.GetEnumerator();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto IL_00BD;
					}
					continue;
					IL_008B:
					columnHeader = this.listView_0.Columns[num2];
					goto IL_009F;
				}
				goto IL_01AC;
				IL_0259:
				num2 = this.listView_0.Columns.Count - 1;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					continue;
				}
				goto IL_028E;
				IL_024C:
				if (displayColumns.Count > 0)
				{
					goto IL_0259;
				}
				goto IL_0187;
				IL_0284:
				if (displayColumns != null)
				{
					goto IL_024C;
				}
				goto IL_0187;
				IL_02FA:
				displayColumns = AppHelper.AppConfigCenter.DisplayColumns;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_0284;
				}
				goto IL_028E;
				IL_01AC:
				this.method_22(sender, e);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_02FA;
				}
				goto IL_028E;
				IL_0187:
				this.int_0 = AppHelper.AppConfigCenter.SortColumn;
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_01AC;
				}
				goto IL_028E;
				IL_0320:
				this.method_23(sender, e);
				goto IL_02FA;
			}
			Block_1:
			goto IL_0358;
			Block_5:
			return;
			IL_0358:
			new SettingForm
			{
				StartPosition = FormStartPosition.CenterParent,
				Icon = base.Icon
			}.ShowDialog(this);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0001940C File Offset: 0x0001760C
		private void method_59(object sender, EventArgs e)
		{
			for (;;)
			{
				this.statusStrip_0.Focus();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
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
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00019448 File Offset: 0x00017648
		private void method_60(object sender, EventArgs e)
		{
			for (;;)
			{
				this.toolStripComboBox_0.Width = this.toolStrip_1.Width - 74;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
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
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00019494 File Offset: 0x00017694
		private void method_61(object sender, CancelEventArgs e)
		{
			try
			{
				this.method_10();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_0047;
				}
				IL_001B:
				switch (num)
				{
				case 0:
					goto IL_0047;
				case 1:
					break;
				case 2:
					goto IL_017B;
				default:
					goto IL_0047;
				}
				IL_002F:
				Environment.Exit(0);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_001B;
				}
				IL_0047:
				try
				{
					this.timer_0.Change(-1, -1);
					int num2 = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_006B;
					}
					int num3;
					for (;;)
					{
						IL_011A:
						switch (num2)
						{
						case 1:
						case 6:
							goto IL_00F5;
						case 3:
							goto IL_00BF;
						case 4:
							goto IL_00A0;
						case 5:
							goto IL_0076;
						case 7:
							goto IL_007D;
						case 8:
							goto IL_00D6;
						case 9:
							num3++;
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
							{
								goto Block_11;
							}
							continue;
						case 10:
							goto IL_006B;
						}
						goto Block_12;
					}
					Block_11:
					goto IL_00F5;
					Block_12:
					goto IL_014F;
					IL_006B:
					this.timer_0.Dispose();
					IL_0076:
					string tempPath = Path.GetTempPath();
					IL_007D:
					if (!Directory.Exists(tempPath))
					{
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
						{
							goto IL_014F;
						}
						goto IL_011A;
					}
					IL_00A0:
					string[] directories = Directory.GetDirectories(tempPath, Class15.smethod_17(768784560 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7), SearchOption.TopDirectoryOnly);
					IL_00BF:
					num3 = 0;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_00F5;
					}
					goto IL_011A;
					IL_00D6:
					Directory.Delete(directories[num3], true);
					num2 = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_00BF;
					}
					goto IL_011A;
					IL_00F5:
					if (num3 < directories.Length)
					{
						goto IL_00D6;
					}
					IL_014F:
					goto IL_002F;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						switch (num4)
						{
						}
					}
					goto IL_002F;
				}
				IL_017B:;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.Message);
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					switch (num5)
					{
					}
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00019704 File Offset: 0x00017904
		private void method_62()
		{
			for (;;)
			{
				IL_48CA:
				this.icontainer_0 = new Container();
				int num = 162;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_2B24;
				}
				for (;;)
				{
					IL_40BB:
					switch (num)
					{
					case 0:
						goto IL_3984;
					case 1:
						goto IL_21B6;
					case 2:
						goto IL_2402;
					case 3:
						goto IL_2465;
					case 4:
						goto IL_03E2;
					case 5:
						goto IL_1B81;
					case 6:
						goto IL_355D;
					case 7:
						goto IL_1A88;
					case 8:
						goto IL_0FFD;
					case 9:
						goto IL_025E;
					case 10:
						goto IL_04FC;
					case 11:
						goto IL_15EF;
					case 12:
						goto IL_0C1E;
					case 13:
						goto IL_0ADC;
					case 14:
						goto IL_018E;
					case 15:
						goto IL_3AC7;
					case 16:
						goto IL_0775;
					case 17:
						goto IL_1D38;
					case 18:
						goto IL_1C7E;
					case 19:
						goto IL_08D3;
					case 20:
						goto IL_0C86;
					case 21:
						goto IL_0E7F;
					case 22:
						goto IL_2E19;
					case 23:
						goto IL_09CD;
					case 24:
						this.toolStrip_0.ResumeLayout(false);
						goto IL_23F7;
					case 25:
						goto IL_0283;
					case 26:
						goto IL_258D;
					case 27:
						goto IL_1DE8;
					case 28:
						goto IL_0E5A;
					case 29:
						goto IL_3B17;
					case 30:
						goto IL_0A02;
					case 31:
						goto IL_01C2;
					case 32:
						goto IL_3F84;
					case 33:
						goto IL_1CC7;
					case 34:
						goto IL_2419;
					case 35:
						goto IL_0B44;
					case 36:
						goto IL_22A0;
					case 37:
						this.toolStripMenuItem_44.Size = new Size(196, 22);
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_3398;
						}
						continue;
					case 38:
						goto IL_1284;
					case 39:
						goto IL_10FF;
					case 40:
						goto IL_3243;
					case 41:
						goto IL_14E1;
					case 42:
						goto IL_28D1;
					case 43:
						goto IL_36FB;
					case 44:
						goto IL_2B45;
					case 45:
						goto IL_0550;
					case 46:
						goto IL_0485;
					case 47:
						goto IL_05E2;
					case 48:
						goto IL_3D83;
					case 49:
						goto IL_092A;
					case 50:
						goto IL_24F7;
					case 51:
						goto IL_070C;
					case 52:
						goto IL_220D;
					case 53:
						goto IL_156C;
					case 54:
						goto IL_0951;
					case 55:
						goto IL_0DB7;
					case 56:
						goto IL_111F;
					case 57:
						goto IL_04F1;
					case 58:
						goto IL_2FD1;
					case 59:
						goto IL_1989;
					case 60:
						goto IL_20FF;
					case 61:
						goto IL_1536;
					case 62:
						goto IL_02C4;
					case 63:
						goto IL_07A5;
					case 64:
						goto IL_2665;
					case 65:
						goto IL_3298;
					case 66:
						goto IL_3070;
					case 67:
						goto IL_28B1;
					case 68:
						this.toolStripMenuItem_38 = new ToolStripMenuItem();
						num = 109;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
						{
							goto IL_3EAC;
						}
						continue;
					case 69:
						goto IL_2E72;
					case 70:
						goto IL_0D97;
					case 71:
						goto IL_1C4D;
					case 72:
						goto IL_3DAC;
					case 73:
						goto IL_3B00;
					case 74:
						goto IL_2ACE;
					case 75:
						goto IL_2513;
					case 76:
						goto IL_0BD2;
					case 77:
						goto IL_24E7;
					case 78:
						this.toolStripStatusLabel_4.Spring = true;
						num = 332;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
						{
							goto IL_13B5;
						}
						continue;
					case 79:
						goto IL_207E;
					case 80:
						goto IL_0B60;
					case 81:
						goto IL_1A53;
					case 82:
						goto IL_007B;
					case 83:
						goto IL_2558;
					case 84:
						goto IL_1CDF;
					case 85:
						goto IL_0B86;
					case 86:
						goto IL_0E0E;
					case 87:
						goto IL_2FA4;
					case 88:
						goto IL_398F;
					case 89:
						base.Controls.Add(this.toolStrip_0);
						num = 134;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							goto IL_38B5;
						}
						continue;
					case 90:
						goto IL_2F84;
					case 91:
						this.toolStripMenuItem_31.Text = Class15.smethod_17(676699538 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b);
						num = 273;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
						{
							goto IL_37B4;
						}
						continue;
					case 92:
						goto IL_227F;
					case 93:
						goto IL_3AA7;
					case 94:
						goto IL_093A;
					case 95:
						goto IL_2533;
					case 96:
						this.toolStripButton_7.Margin = new Padding(5, 1, 0, 2);
						goto IL_1B17;
					case 97:
						goto IL_1C92;
					case 98:
						goto IL_366B;
					case 99:
						goto IL_3CCF;
					case 100:
						goto IL_1780;
					case 101:
						goto IL_2BAB;
					case 102:
						goto IL_0FDD;
					case 103:
						goto IL_139E;
					case 104:
						this.toolStripMenuItem_12 = new ToolStripMenuItem();
						num = 451;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							goto IL_2FC4;
						}
						continue;
					case 105:
						goto IL_1C3D;
					case 106:
						goto IL_00D3;
					case 107:
						goto IL_1140;
					case 108:
						goto IL_15BD;
					case 109:
						goto IL_0092;
					case 110:
						goto IL_292E;
					case 111:
						return;
					case 112:
						this.toolStripMenuItem_24 = new ToolStripMenuItem();
						goto IL_3F84;
					case 113:
						goto IL_239D;
					case 114:
						goto IL_1E66;
					case 115:
						goto IL_3B23;
					case 116:
						goto IL_1E1D;
					case 117:
						goto IL_1679;
					case 118:
						this.columnHeader_0 = new ColumnHeader();
						goto IL_3A61;
					case 119:
						goto IL_1D9D;
					case 120:
						goto IL_2BDC;
					case 121:
						goto IL_3132;
					case 122:
						goto IL_1C31;
					case 123:
						this.toolStrip_0.Size = new Size(834, 62);
						goto IL_36CA;
					case 124:
						goto IL_2A31;
					case 125:
						this.toolStripMenuItem_42.Text = Class15.smethod_17(642136710 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
						goto IL_3E87;
					case 126:
						goto IL_068B;
					case 127:
						goto IL_07D1;
					case 128:
						goto IL_1F1D;
					case 129:
						goto IL_267F;
					case 130:
						goto IL_0BFE;
					case 131:
						goto IL_2855;
					case 132:
						this.toolStripButton_1.Padding = new Padding(1);
						num = 134;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto IL_2E39;
						}
						continue;
					case 133:
						goto IL_3194;
					case 134:
						goto IL_3B43;
					case 135:
						this.toolStripSeparator_6.Size = new Size(230, 6);
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
						{
							goto IL_2E52;
						}
						continue;
					case 136:
						goto IL_047A;
					case 137:
						goto IL_0F63;
					case 138:
						goto IL_1904;
					case 139:
						this.toolStripButton_5.TextImageRelation = TextImageRelation.ImageAboveText;
						goto IL_2A31;
					case 140:
						goto IL_245A;
					case 141:
						goto IL_0A62;
					case 142:
						goto IL_218B;
					case 143:
						goto IL_27BB;
					case 144:
						goto IL_0F98;
					case 145:
						goto IL_3EAC;
					case 146:
						goto IL_154C;
					case 147:
						goto IL_3E87;
					case 148:
						goto IL_2140;
					case 149:
						goto IL_19E8;
					case 150:
						goto IL_173B;
					case 151:
						goto IL_0229;
					case 152:
						goto IL_3201;
					case 153:
						goto IL_1EC3;
					case 154:
						goto IL_0049;
					case 155:
						goto IL_3BA9;
					case 156:
						goto IL_0B31;
					case 157:
						goto IL_2C98;
					case 158:
						goto IL_0674;
					case 159:
						goto IL_072C;
					case 160:
						goto IL_184D;
					case 161:
						this.toolStripStatusLabel_4.Name = Class15.smethod_17(1802344673 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
						{
							goto IL_3367;
						}
						continue;
					case 162:
						goto IL_48EF;
					case 163:
						goto IL_0D1D;
					case 164:
						goto IL_2BED;
					case 165:
						goto IL_13B5;
					case 166:
						goto IL_180D;
					case 167:
						goto IL_0299;
					case 168:
						goto IL_22C0;
					case 169:
						goto IL_04C6;
					case 170:
						goto IL_145B;
					case 171:
						this.toolStripButton_4.ImageScaling = ToolStripItemImageScaling.None;
						goto IL_1A88;
					case 172:
						goto IL_2645;
					case 173:
						this.toolStripMenuItem_25.Size = new Size(233, 22);
						num = 127;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
						{
							goto Block_69;
						}
						continue;
					case 174:
						this.menuStrip_0.SuspendLayout();
						num = 76;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto IL_328D;
						}
						continue;
					case 175:
						this.toolStripStatusLabel_6.Name = Class15.smethod_17(89033904 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
						goto IL_3D83;
					case 176:
						this.toolStripMenuItem_14 = new ToolStripMenuItem();
						goto IL_3745;
					case 177:
						goto IL_087E;
					case 178:
						goto IL_1244;
					case 179:
						goto IL_3482;
					case 180:
						this.toolStripMenuItem_2 = new ToolStripMenuItem();
						num = 23;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto IL_0283;
						}
						continue;
					case 181:
						this.columnHeader_3.Tag = Class15.smethod_17(768784452 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
						num = 362;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							goto IL_26A4;
						}
						continue;
					case 182:
						goto IL_0527;
					case 183:
						goto IL_362F;
					case 184:
						this.toolStripMenuItem_6.Size = new Size(293, 22);
						goto IL_3CCF;
					case 185:
						this.toolStripSeparator_8.Size = new Size(165, 6);
						num = 108;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
						{
							goto IL_2ED4;
						}
						continue;
					case 186:
						goto IL_2B2F;
					case 187:
						goto IL_24AA;
					case 188:
						goto IL_2C18;
					case 189:
						goto IL_0B59;
					case 190:
						goto IL_24B6;
					case 191:
						goto IL_131C;
					case 192:
						goto IL_16B0;
					case 193:
						goto IL_2A66;
					case 194:
						goto IL_0A3C;
					case 195:
						goto IL_0E3A;
					case 196:
						this.toolStripMenuItem_21 = new ToolStripMenuItem();
						num = 265;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
						{
							goto IL_350D;
						}
						continue;
					case 197:
						goto IL_1EA7;
					case 198:
						goto IL_1DA8;
					case 199:
						goto IL_297A;
					case 200:
						this.toolStripButton_5.Font = new Font(Class15.smethod_17(41446913 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						goto IL_1C21;
					case 201:
						goto IL_328D;
					case 202:
						goto IL_20F4;
					case 203:
						goto IL_1A08;
					case 204:
						goto IL_0AA7;
					case 205:
						goto IL_212A;
					case 206:
						this.toolStripButton_6 = new ToolStripButton();
						num = 149;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
						{
							goto IL_2C28;
						}
						continue;
					case 207:
						goto IL_0DCE;
					case 208:
						goto IL_0BAC;
					case 209:
						goto IL_30BC;
					case 210:
						goto IL_1990;
					case 211:
						goto IL_3044;
					case 212:
						this.toolStripStatusLabel_2.Name = Class15.smethod_17(974452181 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
						goto IL_2EA3;
					case 213:
						goto IL_387B;
					case 214:
						goto IL_37FA;
					case 215:
						goto IL_20AF;
					case 216:
						goto IL_2FC4;
					case 217:
						goto IL_3B7E;
					case 218:
						goto IL_2544;
					case 219:
						goto IL_1B58;
					case 220:
						goto IL_17E1;
					case 221:
						this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
						num = 96;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							goto IL_0DB7;
						}
						continue;
					case 222:
						goto IL_3024;
					case 223:
						goto IL_1BF3;
					case 224:
						goto IL_1305;
					case 225:
						goto IL_13D5;
					case 226:
						goto IL_23CD;
					case 227:
						goto IL_3342;
					case 228:
						goto IL_0DEE;
					case 229:
						goto IL_1F97;
					case 230:
						this.toolStripMenuItem_2.Size = new Size(59, 21);
						num = 121;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
						{
							goto IL_3B00;
						}
						continue;
					case 231:
						this.contextMenuStrip_0.ResumeLayout(false);
						num = 162;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
						{
							goto IL_3AA7;
						}
						continue;
					case 232:
						goto IL_33B8;
					case 233:
						goto IL_044E;
					case 234:
						goto IL_3087;
					case 235:
						goto IL_0A82;
					case 236:
						goto IL_1FBE;
					case 237:
						goto IL_0B75;
					case 238:
						goto IL_01E2;
					case 239:
						goto IL_21DD;
					case 240:
						goto IL_3A61;
					case 241:
						goto IL_0CB6;
					case 242:
						this.toolStripMenuItem_44 = new ToolStripMenuItem();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							goto IL_3984;
						}
						continue;
					case 243:
						goto IL_3462;
					case 244:
						this.toolStripMenuItem_10.ShortcutKeys = Keys.Delete;
						goto IL_30E1;
					case 245:
						goto IL_39CB;
					case 246:
						goto IL_2CDF;
					case 247:
						goto IL_18F9;
					case 248:
						goto IL_2014;
					case 249:
						goto IL_1659;
					case 250:
						goto IL_0332;
					case 251:
						goto IL_0CED;
					case 252:
						goto IL_226F;
					case 253:
						goto IL_171B;
					case 254:
						goto IL_2EFC;
					case 255:
						this.toolStripMenuItem_48.Name = Class15.smethod_17(649961182 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
						num = 115;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
						{
							goto IL_395F;
						}
						continue;
					case 256:
						this.toolStripMenuItem_36.Size = new Size(279, 22);
						goto IL_39CB;
					case 257:
						goto IL_0795;
					case 258:
						goto IL_2196;
					case 259:
						goto IL_090A;
					case 260:
						goto IL_2503;
					case 261:
						goto IL_2135;
					case 262:
						goto IL_09A6;
					case 263:
						goto IL_299A;
					case 264:
						goto IL_0352;
					case 265:
						goto IL_07F1;
					case 266:
						goto IL_26D9;
					case 267:
						goto IL_395F;
					case 268:
						goto IL_243A;
					case 269:
						goto IL_3900;
					case 270:
						goto IL_016E;
					case 271:
						goto IL_2F43;
					case 272:
						goto IL_1AAE;
					case 273:
						goto IL_0D49;
					case 274:
						goto IL_294E;
					case 275:
						this.toolStripMenuItem_38.Text = Class15.smethod_17(1788748023 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
						num = 47;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto IL_35E5;
						}
						continue;
					case 276:
						goto IL_0C7A;
					case 277:
						this.toolStripMenuItem_49.Text = Class15.smethod_17(2128226638 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
						goto IL_3900;
					case 278:
						goto IL_0832;
					case 279:
						goto IL_38B5;
					case 280:
						this.toolStripButton_6.Image = Resources.GoBack;
						goto IL_2DF9;
					case 281:
						goto IL_240E;
					case 282:
						goto IL_0654;
					case 283:
						goto IL_039D;
					case 284:
						goto IL_236E;
					case 285:
						goto IL_182D;
					case 286:
						break;
					case 287:
						goto IL_049B;
					case 288:
						this.listView_0.View = View.Details;
						goto IL_387B;
					case 289:
						goto IL_0490;
					case 290:
						goto IL_1FA7;
					case 291:
						goto IL_0306;
					case 292:
						goto IL_0852;
					case 293:
						goto IL_0507;
					case 294:
						this.listView_0.Dock = DockStyle.Fill;
						num = 186;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
						{
							goto IL_2B7A;
						}
						continue;
					case 295:
						goto IL_121F;
					case 296:
						goto IL_0585;
					case 297:
						this.toolStripMenuItem_30.Text = Class15.smethod_17(2048539707 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
						num = 185;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_32D8;
						}
						continue;
					case 298:
						this.toolStripButton_1.ImageScaling = ToolStripItemImageScaling.None;
						goto IL_37FA;
					case 299:
						goto IL_0E6B;
					case 300:
						goto IL_3004;
					case 301:
						goto IL_289B;
					case 302:
						goto IL_03F9;
					case 303:
						goto IL_0FC9;
					case 304:
						goto IL_37B4;
					case 305:
						goto IL_2C0D;
					case 306:
						goto IL_0971;
					case 307:
						goto IL_48F6;
					case 308:
						goto IL_04D1;
					case 309:
						goto IL_0209;
					case 310:
						goto IL_0F0D;
					case 311:
						goto IL_142F;
					case 312:
						goto IL_31BF;
					case 313:
						goto IL_1AC2;
					case 314:
						goto IL_046F;
					case 315:
						goto IL_3654;
					case 316:
						goto IL_378F;
					case 317:
						goto IL_1264;
					case 318:
						this.toolStripStatusLabel_6.Text = Class15.smethod_17(552179068 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f);
						goto IL_1CC7;
					case 319:
						this.toolStripMenuItem_34.ShortcutKeys = (Keys)262230;
						goto IL_2F6D;
					case 320:
						goto IL_234E;
					case 321:
						goto IL_3745;
					case 322:
						this.toolStripMenuItem_19.Text = Class15.smethod_17(594366746 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b);
						goto IL_0D97;
					case 323:
						goto IL_3599;
					case 324:
						goto IL_2D70;
					case 325:
						goto IL_1064;
					case 326:
						goto IL_23BD;
					case 327:
						goto IL_32A3;
					case 328:
						goto IL_15FF;
					case 329:
						this.toolStripSeparator_10 = new ToolStripSeparator();
						goto IL_36FB;
					case 330:
						goto IL_0C5A;
					case 331:
						goto IL_36CA;
					case 332:
						this.toolStripStatusLabel_4.Text = Class15.smethod_17(1953678515 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f);
						goto IL_2F36;
					case 333:
						this.toolStripMenuItem_32.ShortcutKeyDisplayString = "";
						goto IL_362F;
					case 334:
						goto IL_35E5;
					case 335:
						goto IL_35D3;
					case 336:
						goto IL_3582;
					case 337:
						goto IL_0AFC;
					case 338:
						goto IL_210A;
					case 339:
						goto IL_1EB3;
					case 340:
						goto IL_3538;
					case 341:
						goto IL_350D;
					case 342:
						goto IL_15CA;
					case 343:
						goto IL_02A4;
					case 344:
						goto IL_0EC0;
					case 345:
						goto IL_34D3;
					case 346:
						goto IL_1959;
					case 347:
						goto IL_0CCD;
					case 348:
						this.toolStripMenuItem_13.Size = new Size(293, 22);
						goto IL_34D3;
					case 349:
						goto IL_0D0D;
					case 350:
						this.toolStripSeparator_4.Size = new Size(230, 6);
						goto IL_3462;
					case 351:
						goto IL_10A5;
					case 352:
						this.statusStrip_0.Name = Class15.smethod_17(649954700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
						num = 73;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_0283;
						}
						continue;
					case 353:
						goto IL_3398;
					case 354:
						goto IL_135D;
					case 355:
						goto IL_1501;
					case 356:
						goto IL_10C5;
					case 357:
						goto IL_1F77;
					case 358:
						goto IL_06C0;
					case 359:
						goto IL_1D0F;
					case 360:
						goto IL_03D2;
					case 361:
						goto IL_27D2;
					case 362:
						goto IL_05F9;
					case 363:
						goto IL_3367;
					case 364:
						goto IL_1690;
					case 365:
						goto IL_32D8;
					case 366:
						goto IL_32B3;
					case 367:
						this.toolStrip_1 = new ToolStrip();
						num = 206;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
						{
							goto IL_328D;
						}
						continue;
					case 368:
						goto IL_1CEF;
					case 369:
						goto IL_1B99;
					case 370:
						goto IL_2813;
					case 371:
						goto IL_27DE;
					case 372:
						goto IL_1EF8;
					case 373:
						goto IL_2A9E;
					case 374:
						goto IL_2CAE;
					case 375:
						goto IL_1F09;
					case 376:
						this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
						goto IL_3243;
					case 377:
						this.toolStripButton_2.TextImageRelation = TextImageRelation.ImageAboveText;
						num = 94;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
						{
							goto IL_3201;
						}
						continue;
					case 378:
						goto IL_005B;
					case 379:
						goto IL_31CF;
					case 380:
						goto IL_18B9;
					case 381:
						goto IL_0419;
					case 382:
						goto IL_214B;
					case 383:
						goto IL_1872;
					case 384:
						goto IL_316C;
					case 385:
						this.toolStrip_0.Name = Class15.smethod_17(1116162573 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
						num = 123;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
						{
							goto IL_3132;
						}
						continue;
					case 386:
						goto IL_1DC8;
					case 387:
						goto IL_30E1;
					case 388:
						goto IL_28F1;
					case 389:
						this.toolStripMenuItem_39.Size = new Size(168, 22);
						goto IL_3004;
					case 390:
						goto IL_17AC;
					case 391:
						goto IL_2F6D;
					case 392:
						goto IL_2788;
					case 393:
						goto IL_2B3A;
					case 394:
						goto IL_2ABE;
					case 395:
						goto IL_2F36;
					case 396:
						goto IL_2ED4;
					case 397:
						goto IL_2EA3;
					case 398:
						goto IL_2E52;
					case 399:
						goto IL_2C33;
					case 400:
						goto IL_1C6D;
					case 401:
						goto IL_0633;
					case 402:
						goto IL_028E;
					case 403:
						goto IL_1949;
					case 404:
						goto IL_2CA3;
					case 405:
						goto IL_2C78;
					case 406:
						goto IL_089E;
					case 407:
						goto IL_1E31;
					case 408:
						goto IL_2E39;
					case 409:
						goto IL_2E0E;
					case 410:
						goto IL_11FF;
					case 411:
						goto IL_2DF9;
					case 412:
						goto IL_1074;
					case 413:
						goto IL_0FB8;
					case 414:
						this.toolStripStatusLabel_2 = new ToolStripStatusLabel();
						num = 403;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto IL_1899;
						}
						continue;
					case 415:
						goto IL_2D9A;
					case 416:
						goto IL_279B;
					case 417:
						goto IL_1B4C;
					case 418:
						this.toolStripButton_4.Font = new Font(Class15.smethod_17(1743169494 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						num = 271;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
						{
							goto IL_2D70;
						}
						continue;
					case 419:
						goto IL_05C2;
					case 420:
						goto IL_2D05;
					case 421:
						goto IL_0E9F;
					case 422:
						this.listView_0.TabIndex = 3;
						num = 183;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_2CDF;
						}
						continue;
					case 423:
						goto IL_2C58;
					case 424:
						goto IL_14B5;
					case 425:
						goto IL_2C28;
					case 426:
						goto IL_10EB;
					case 427:
						goto IL_2BBC;
					case 428:
						goto IL_1AF2;
					case 429:
						goto IL_2B7A;
					case 430:
						goto IL_22F5;
					case 431:
						goto IL_18D9;
					case 432:
						goto IL_2B6A;
					case 433:
						goto IL_1AE2;
					case 434:
						goto IL_101E;
					case 435:
						goto IL_0CA6;
					case 436:
						goto IL_2B24;
					case 437:
						goto IL_48CA;
					case 438:
						goto IL_2AFF;
					case 439:
						goto IL_0F2D;
					case 440:
						goto IL_02E4;
					case 441:
						goto IL_19AB;
					case 442:
						goto IL_140F;
					case 443:
						goto IL_08EA;
					case 444:
						this.toolStripMenuItem_1.Text = Class15.smethod_17(1424573526 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf);
						goto IL_2A9E;
					case 445:
						goto IL_2A11;
					case 446:
						goto IL_0F4D;
					case 447:
						goto IL_0740;
					case 448:
						this.toolStripMenuItem_41.Checked = true;
						goto IL_2922;
					case 449:
						goto IL_2922;
					case 450:
						this.toolStripButton_3.TextImageRelation = TextImageRelation.ImageAboveText;
						num = 418;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto IL_289B;
						}
						continue;
					case 451:
						this.toolStripMenuItem_46 = new ToolStripMenuItem();
						goto IL_2855;
					case 452:
						goto IL_2839;
					case 453:
						goto IL_2739;
					case 454:
						goto IL_223E;
					case 455:
						goto IL_2728;
					case 456:
						goto IL_1D58;
					case 457:
						goto IL_2703;
					case 458:
						goto IL_1A28;
					case 459:
						goto IL_26A4;
					case 460:
						goto IL_216B;
					case 461:
						goto IL_248A;
					case 462:
						goto IL_23F7;
					case 463:
						goto IL_1095;
					case 464:
						goto IL_2326;
					case 465:
						goto IL_11CF;
					case 466:
						goto IL_01A2;
					case 467:
						goto IL_1CD3;
					case 468:
						goto IL_221E;
					case 469:
						goto IL_1B8D;
					case 470:
						goto IL_174F;
					case 471:
						goto IL_21ED;
					case 472:
						goto IL_21D2;
					case 473:
						this.toolStripMenuItem_29 = new ToolStripMenuItem();
						goto IL_20F4;
					case 474:
						this.statusStrip_0.GripStyle = ToolStripGripStyle.Visible;
						goto IL_2014;
					case 475:
						goto IL_1FE3;
					case 476:
						goto IL_1F57;
					case 477:
						goto IL_1E97;
					case 478:
						this.toolStripMenuItem_40 = new ToolStripMenuItem();
						goto IL_1D9D;
					case 479:
						goto IL_1D6D;
					case 480:
						goto IL_0812;
					case 481:
						goto IL_1C21;
					case 482:
						this.toolStripMenuItem_12.Text = Class15.smethod_17(543253824 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89);
						num = 390;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							goto IL_1BF3;
						}
						continue;
					case 483:
						goto IL_1B17;
					case 484:
						goto IL_137E;
					case 485:
						goto IL_11DF;
					case 486:
						goto IL_1A9D;
					case 487:
						goto IL_19D1;
					case 488:
						goto IL_196E;
					case 489:
						this.toolStripMenuItem_33.Name = Class15.smethod_17(2048540613 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
						goto IL_1949;
					case 490:
						goto IL_1899;
					case 491:
						goto IL_1774;
					case 492:
						goto IL_16EA;
					case 493:
						this.toolStripMenuItem_28.Text = Class15.smethod_17(642131340 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
						goto IL_1659;
					case 494:
						goto IL_1629;
					case 495:
						goto IL_159D;
					case 496:
						this.toolStripMenuItem_50.Name = Class15.smethod_17(2056984823 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
						num = 160;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_14B5;
						}
						continue;
					case 497:
						goto IL_01F2;
					case 498:
						goto IL_133C;
					case 499:
						this.toolStripMenuItem_15.Name = Class15.smethod_17(1243258282 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
						num = 79;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							goto IL_1305;
						}
						continue;
					case 500:
						goto IL_1175;
					case 501:
						goto IL_06E0;
					case 502:
						goto IL_1296;
					case 503:
						goto IL_11AF;
					case 504:
						goto IL_1165;
					case 505:
						goto IL_0EF6;
					case 506:
						this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
						goto IL_0E3A;
					case 507:
						goto IL_04A6;
					case 508:
						goto IL_0D6E;
					case 509:
						goto IL_0C43;
					case 510:
						goto IL_09B7;
					case 511:
						goto IL_0387;
					case 512:
						goto IL_0006;
					default:
						goto IL_3984;
					}
					IL_009E:
					this.menuStrip_0.Text = Class15.smethod_17(2060609280 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
					num = 69;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_00D3;
					}
					continue;
					IL_0092:
					this.menuStrip_0.TabIndex = 0;
					goto IL_009E;
					IL_007B:
					this.menuStrip_0.Size = new Size(834, 25);
					goto IL_0092;
					IL_005B:
					this.menuStrip_0.Name = Class15.smethod_17(2048539473 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
					goto IL_007B;
					IL_0049:
					this.menuStrip_0.Location = new Point(0, 0);
					goto IL_005B;
					IL_0006:
					this.menuStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_3, this.toolStripMenuItem_4 });
					goto IL_0049;
					IL_00D3:
					this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
					{
						this.toolStripMenuItem_22, this.toolStripMenuItem_23, this.toolStripMenuItem_24, this.toolStripSeparator_4, this.toolStripMenuItem_25, this.toolStripMenuItem_26, this.toolStripMenuItem_27, this.toolStripSeparator_5, this.toolStripMenuItem_28, this.toolStripMenuItem_29,
						this.toolStripSeparator_6, this.toolStripMenuItem_30
					});
					num = 177;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_016E;
					}
					continue;
					IL_0229:
					this.toolStripMenuItem_23.Name = Class15.smethod_17(635812385 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						goto IL_025E;
					}
					continue;
					IL_0209:
					this.toolStripMenuItem_22.Text = Class15.smethod_17(613118583 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6);
					goto IL_0229;
					IL_01F2:
					this.toolStripMenuItem_22.Size = new Size(233, 22);
					goto IL_0209;
					IL_01E2:
					this.toolStripMenuItem_22.ShortcutKeys = (Keys)131151;
					goto IL_01F2;
					IL_01C2:
					this.toolStripMenuItem_22.Name = Class15.smethod_17(1396556438 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7);
					goto IL_01E2;
					IL_01A2:
					this.toolStripMenuItem_0.Text = Class15.smethod_17(1802340129 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
					goto IL_01C2;
					IL_018E:
					this.toolStripMenuItem_0.Size = new Size(58, 21);
					goto IL_01A2;
					IL_016E:
					this.toolStripMenuItem_0.Name = Class15.smethod_17(1743170472 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
					goto IL_018E;
					IL_025E:
					this.toolStripButton_1.Image = Resources.Extract;
					num = 298;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
					{
						goto IL_0283;
					}
					continue;
					IL_0EC0:
					this.toolStripButton_1.Font = new Font(Class15.smethod_17(1802341195 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_025E;
					IL_02A4:
					this.toolStripMenuItem_3 = new ToolStripMenuItem();
					num = 68;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
					{
						goto IL_02C4;
					}
					continue;
					IL_0299:
					this.toolStripMenuItem_37 = new ToolStripMenuItem();
					goto IL_02A4;
					IL_028E:
					this.toolStripMenuItem_49 = new ToolStripMenuItem();
					goto IL_0299;
					IL_0283:
					this.toolStripMenuItem_48 = new ToolStripMenuItem();
					goto IL_028E;
					IL_09CD:
					this.toolStripMenuItem_12.Name = Class15.smethod_17(2128232118 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
					num = 114;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_0A02;
					}
					continue;
					IL_09B7:
					this.toolStripSeparator_3.Size = new Size(290, 6);
					goto IL_09CD;
					IL_1140:
					this.toolStripSeparator_3.Name = Class15.smethod_17(1603809130 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
					goto IL_09B7;
					IL_1FBE:
					this.toolStripMenuItem_11.Text = Class15.smethod_17(1807892076 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
					goto IL_1140;
					IL_1FA7:
					this.toolStripMenuItem_11.Size = new Size(293, 22);
					goto IL_1FBE;
					IL_1F97:
					this.toolStripMenuItem_11.ShortcutKeys = (Keys)262230;
					goto IL_1FA7;
					IL_1F77:
					this.toolStripMenuItem_11.Name = Class15.smethod_17(1829602639 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
					goto IL_1F97;
					IL_1F57:
					this.toolStripMenuItem_10.Text = Class15.smethod_17(2008548663 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
					goto IL_1F77;
					IL_30E1:
					this.toolStripMenuItem_10.Size = new Size(293, 22);
					goto IL_1F57;
					IL_0A3C:
					this.listView_0.ContextMenuStrip = this.contextMenuStrip_0;
					num = 294;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
					{
						goto IL_0A62;
					}
					continue;
					IL_0A02:
					this.listView_0.Columns.AddRange(new ColumnHeader[] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3 });
					goto IL_0A3C;
					IL_1D58:
					this.toolStripStatusLabel_5.VisitedLinkColor = SystemColors.ControlText;
					goto IL_0A02;
					IL_1D38:
					this.toolStripStatusLabel_5.Text = Class15.smethod_17(635806857 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					goto IL_1D58;
					IL_0A62:
					this.toolStripStatusLabel_1 = new ToolStripStatusLabel();
					num = 414;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto IL_0A82;
					}
					continue;
					IL_21DD:
					this.toolStripStatusLabel_0 = new ToolStripStatusLabel();
					goto IL_0A62;
					IL_21D2:
					this.statusStrip_0 = new StatusStrip();
					goto IL_21DD;
					IL_0AA7:
					this.toolStripMenuItem_36.ShortcutKeyDisplayString = Class15.smethod_17(314771249 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
					num = 256;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						goto IL_0ADC;
					}
					continue;
					IL_0C1E:
					this.toolStripMenuItem_36.Name = Class15.smethod_17(635813495 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					goto IL_0AA7;
					IL_0A82:
					this.toolStripMenuItem_35.Text = Class15.smethod_17(538808067 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
					goto IL_0C1E;
					IL_2FD1:
					this.toolStripMenuItem_35.Size = new Size(279, 22);
					goto IL_0A82;
					IL_2FC4:
					this.toolStripMenuItem_35.ShortcutKeys = Keys.Delete;
					goto IL_2FD1;
					IL_2FA4:
					this.toolStripMenuItem_35.Name = Class15.smethod_17(1387464270 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
					goto IL_2FC4;
					IL_2F84:
					this.toolStripMenuItem_34.Text = Class15.smethod_17(1829608559 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
					goto IL_2FA4;
					IL_2F6D:
					this.toolStripMenuItem_34.Size = new Size(279, 22);
					goto IL_2F84;
					IL_0AFC:
					this.contextMenuStrip_1.Name = Class15.smethod_17(649956326 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						goto IL_0B31;
					}
					continue;
					IL_0ADC:
					this.toolStripMenuItem_21.Text = Class15.smethod_17(314774111 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
					goto IL_0AFC;
					IL_0E0E:
					this.toolStripMenuItem_21.Size = new Size(144, 22);
					goto IL_0ADC;
					IL_0DEE:
					this.toolStripMenuItem_21.Name = Class15.smethod_17(974453627 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
					goto IL_0E0E;
					IL_0DCE:
					this.toolStripMenuItem_20.Text = Class15.smethod_17(1829603519 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
					goto IL_0DEE;
					IL_0DB7:
					this.toolStripMenuItem_20.Size = new Size(144, 22);
					goto IL_0DCE;
					IL_0D97:
					this.toolStripMenuItem_20.Name = Class15.smethod_17(926382107 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296);
					goto IL_0DB7;
					IL_0B86:
					base.Controls.Add(this.statusStrip_0);
					num = 43;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_0BAC;
					}
					continue;
					IL_0B75:
					base.Controls.Add(this.listView_0);
					goto IL_0B86;
					IL_0B60:
					base.ClientSize = new Size(834, 561);
					goto IL_0B75;
					IL_0B59:
					base.AutoScaleMode = AutoScaleMode.Font;
					goto IL_0B60;
					IL_0B44:
					base.AutoScaleDimensions = new SizeF(6f, 12f);
					goto IL_0B59;
					IL_0B31:
					this.contextMenuStrip_1.Size = new Size(61, 4);
					goto IL_0B44;
					IL_0BAC:
					base.Controls.Add(this.toolStrip_1);
					num = 89;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
					{
						continue;
					}
					IL_0BD2:
					this.toolStripMenuItem_49.Size = new Size(181, 22);
					num = 277;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_0BFE;
					}
					continue;
					IL_1284:
					this.toolStripMenuItem_49.ShortcutKeys = Keys.F3;
					goto IL_0BD2;
					IL_1264:
					this.toolStripMenuItem_49.Name = Class15.smethod_17(1788755799 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
					goto IL_1284;
					IL_1244:
					this.toolStripMenuItem_48.Text = Class15.smethod_17(2128226674 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
					goto IL_1264;
					IL_21B6:
					this.toolStripMenuItem_48.Size = new Size(181, 22);
					goto IL_1244;
					IL_0BFE:
					this.menuStrip_0.PerformLayout();
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_0C1E;
					}
					continue;
					IL_0D1D:
					this.toolStripMenuItem_8.Size = new Size(293, 22);
					num = 82;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						break;
					}
					continue;
					IL_0D0D:
					this.toolStripMenuItem_8.ShortcutKeys = (Keys)196675;
					goto IL_0D1D;
					IL_0CED:
					this.toolStripMenuItem_8.Name = Class15.smethod_17(1788749769 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
					goto IL_0D0D;
					IL_0CCD:
					this.toolStripMenuItem_47.Text = Class15.smethod_17(314770497 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
					goto IL_0CED;
					IL_0CB6:
					this.toolStripMenuItem_47.Size = new Size(293, 22);
					goto IL_0CCD;
					IL_0CA6:
					this.toolStripMenuItem_47.ShortcutKeys = (Keys)131158;
					goto IL_0CB6;
					IL_0C86:
					this.toolStripMenuItem_47.Name = Class15.smethod_17(1424580476 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf);
					goto IL_0CA6;
					IL_0C7A:
					this.toolStripMenuItem_47.Enabled = false;
					goto IL_0C86;
					IL_0C5A:
					this.toolStripMenuItem_7.Text = Class15.smethod_17(1243252900 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					goto IL_0C7A;
					IL_0C43:
					this.toolStripMenuItem_7.Size = new Size(293, 22);
					goto IL_0C5A;
					IL_0D6E:
					this.toolStripMenuItem_1.Size = new Size(60, 21);
					num = 444;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto IL_0D97;
					}
					continue;
					IL_3342:
					this.toolStripMenuItem_1.Name = Class15.smethod_17(2021173270 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
					goto IL_0D6E;
					IL_0E9F:
					this.toolStripButton_0.TextImageRelation = TextImageRelation.ImageAboveText;
					num = 142;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_0EC0;
					}
					continue;
					IL_0E7F:
					this.toolStripButton_0.Text = Class15.smethod_17(124844670 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
					goto IL_0E9F;
					IL_0E6B:
					this.toolStripButton_0.Size = new Size(54, 59);
					goto IL_0E7F;
					IL_0E5A:
					this.toolStripButton_0.Padding = new Padding(1);
					goto IL_0E6B;
					IL_0E3A:
					this.toolStripButton_0.Name = Class15.smethod_17(1760308705 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_0E5A;
					IL_0F63:
					this.toolStripMenuItem_34.Name = Class15.smethod_17(2008548491 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
					num = 319;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						goto IL_0F98;
					}
					continue;
					IL_0F4D:
					this.toolStripSeparator_7.Size = new Size(276, 6);
					goto IL_0F63;
					IL_0F2D:
					this.toolStripSeparator_7.Name = Class15.smethod_17(1807892012 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
					goto IL_0F4D;
					IL_0F0D:
					this.toolStripMenuItem_33.Text = Class15.smethod_17(277639868 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
					goto IL_0F2D;
					IL_0EF6:
					this.toolStripMenuItem_33.Size = new Size(279, 22);
					goto IL_0F0D;
					IL_1959:
					this.toolStripMenuItem_33.ShortcutKeys = (Keys)262228;
					goto IL_0EF6;
					IL_1949:
					this.toolStripMenuItem_33.ShortcutKeyDisplayString = "";
					goto IL_1959;
					IL_0FFD:
					this.toolStripButton_4.TextImageRelation = TextImageRelation.ImageAboveText;
					num = 306;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
					{
						goto IL_101E;
					}
					continue;
					IL_0FDD:
					this.toolStripButton_4.Text = Class15.smethod_17(2060608588 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
					goto IL_0FFD;
					IL_0FC9:
					this.toolStripButton_4.Size = new Size(54, 59);
					goto IL_0FDD;
					IL_0FB8:
					this.toolStripButton_4.Padding = new Padding(1);
					goto IL_0FC9;
					IL_0F98:
					this.toolStripButton_4.Name = Class15.smethod_17(1953677999 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f);
					goto IL_0FB8;
					IL_1A88:
					this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
					goto IL_0F98;
					IL_101E:
					this.toolStripButton_8.Font = new Font(Class15.smethod_17(2056982319 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						goto IL_1064;
					}
					continue;
					IL_1074:
					this.toolStripButton_8.ImageScaling = ToolStripItemImageScaling.None;
					num = 156;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_1095;
					}
					continue;
					IL_1064:
					this.toolStripButton_8.Image = Resources.Search;
					goto IL_1074;
					IL_10C5:
					this.toolStripButton_8.Padding = new Padding(1);
					num = 398;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						goto IL_10EB;
					}
					continue;
					IL_10A5:
					this.toolStripButton_8.Name = Class15.smethod_17(1243256800 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					goto IL_10C5;
					IL_1095:
					this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
					goto IL_10A5;
					IL_111F:
					this.toolStripButton_8.TextImageRelation = TextImageRelation.ImageAboveText;
					num = 200;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_1140;
					}
					continue;
					IL_10FF:
					this.toolStripButton_8.Text = Class15.smethod_17(432120679 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2);
					goto IL_111F;
					IL_10EB:
					this.toolStripButton_8.Size = new Size(54, 59);
					goto IL_10FF;
					IL_1175:
					this.toolStripStatusLabel_0.Name = Class15.smethod_17(613117239 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6);
					num = 486;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_1165:
					this.toolStripStatusLabel_0.Image = Resources.DriverGray;
					goto IL_1175;
					IL_3B43:
					this.toolStripStatusLabel_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
					goto IL_1165;
					IL_3B23:
					this.statusStrip_0.Text = Class15.smethod_17(1471360467 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e);
					goto IL_3B43;
					IL_3B17:
					this.statusStrip_0.TabIndex = 4;
					goto IL_3B23;
					IL_3B00:
					this.statusStrip_0.Size = new Size(834, 27);
					goto IL_3B17;
					IL_121F:
					this.columnHeader_2.Width = 140;
					num = 181;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_1244;
					}
					continue;
					IL_11FF:
					this.columnHeader_2.Text = Class15.smethod_17(594370276 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b);
					goto IL_121F;
					IL_11DF:
					this.columnHeader_2.Tag = Class15.smethod_17(1743170402 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
					goto IL_11FF;
					IL_11CF:
					this.columnHeader_1.Width = 150;
					goto IL_11DF;
					IL_11AF:
					this.columnHeader_1.Text = Class15.smethod_17(926382045 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296);
					goto IL_11CF;
					IL_355D:
					this.columnHeader_1.Tag = Class15.smethod_17(543258390 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89);
					goto IL_11AF;
					IL_1296:
					this.toolStripButton_6.Text = Class15.smethod_17(82297598 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909);
					num = 233;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_0DEE;
					}
					continue;
					IL_133C:
					this.toolStripMenuItem_16.Checked = true;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_135D;
					}
					continue;
					IL_131C:
					this.toolStripMenuItem_15.Text = Class15.smethod_17(2056984931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
					goto IL_133C;
					IL_1305:
					this.toolStripMenuItem_15.Size = new Size(144, 22);
					goto IL_131C;
					IL_135D:
					this.toolStripMenuItem_16.CheckState = CheckState.Checked;
					num = 312;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto IL_137E;
					}
					continue;
					IL_142F:
					this.toolStripMenuItem_17.Size = new Size(293, 22);
					num = 53;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_145B;
					}
					continue;
					IL_140F:
					this.toolStripMenuItem_17.Name = Class15.smethod_17(1807886824 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
					goto IL_142F;
					IL_13D5:
					this.toolStripMenuItem_17.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_18, this.toolStripMenuItem_19, this.toolStripMenuItem_20, this.toolStripMenuItem_21 });
					goto IL_140F;
					IL_13B5:
					this.toolStripMenuItem_16.Text = Class15.smethod_17(1570987603 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406);
					goto IL_13D5;
					IL_139E:
					this.toolStripMenuItem_16.Size = new Size(144, 22);
					goto IL_13B5;
					IL_137E:
					this.toolStripMenuItem_16.Name = Class15.smethod_17(768781106 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
					goto IL_139E;
					IL_14B5:
					this.toolStripMenuItem_50.Size = new Size(196, 22);
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_14E1;
					}
					continue;
					IL_1501:
					this.toolStripSeparator_10.Name = Class15.smethod_17(1116162535 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_1536;
					}
					continue;
					IL_14E1:
					this.toolStripMenuItem_50.Text = Class15.smethod_17(635805703 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					goto IL_1501;
					IL_156C:
					this.toolStripMenuItem_43.Size = new Size(196, 22);
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_01C2;
					}
					continue;
					IL_154C:
					this.toolStripMenuItem_43.Name = Class15.smethod_17(2048532539 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
					goto IL_156C;
					IL_1536:
					this.toolStripSeparator_10.Size = new Size(193, 6);
					goto IL_154C;
					IL_15CA:
					this.toolStripStatusLabel_3.ForeColor = Color.Silver;
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
					{
						goto IL_15EF;
					}
					continue;
					IL_15BD:
					this.toolStripStatusLabel_2.TextAlign = ContentAlignment.MiddleLeft;
					goto IL_15CA;
					IL_159D:
					this.toolStripStatusLabel_2.Text = Class15.smethod_17(1678092746 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a);
					goto IL_15BD;
					IL_2839:
					this.toolStripStatusLabel_2.Spring = true;
					goto IL_159D;
					IL_15FF:
					this.toolStripMenuItem_7.ShortcutKeys = (Keys)131139;
					num = 309;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0C43;
					}
					continue;
					IL_15EF:
					this.toolStripMenuItem_7.ShortcutKeyDisplayString = "";
					goto IL_15FF;
					IL_16B0:
					this.toolStripSeparator_6.Name = Class15.smethod_17(1570980383 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406);
					num = 135;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
					{
						goto Block_6;
					}
					continue;
					IL_1690:
					this.toolStripMenuItem_29.Text = Class15.smethod_17(1953684643 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f);
					goto IL_16B0;
					IL_1679:
					this.toolStripMenuItem_29.Size = new Size(233, 22);
					goto IL_1690;
					IL_1659:
					this.toolStripMenuItem_29.Name = Class15.smethod_17(124839310 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
					goto IL_1679;
					IL_1780:
					this.toolStripComboBox_0.Size = new Size(756, 25);
					num = 474;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
					{
						goto IL_17AC;
					}
					continue;
					IL_1774:
					this.toolStripComboBox_0.Overflow = ToolStripItemOverflow.Never;
					goto IL_1780;
					IL_1B99:
					this.toolStripComboBox_0.Name = Class15.smethod_17(642137252 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
					goto IL_1774;
					IL_1B8D:
					this.toolStripComboBox_0.AutoSize = false;
					goto IL_1B99;
					IL_1B81:
					this.toolStripComboBox_0.Alignment = ToolStripItemAlignment.Right;
					goto IL_1B8D;
					IL_17AC:
					this.toolStripMenuItem_46.Name = Class15.smethod_17(299955985 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
					num = 157;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						continue;
					}
					IL_17E1:
					this.toolStripMenuItem_46.Size = new Size(293, 22);
					num = 39;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_180D;
					}
					continue;
					IL_184D:
					this.toolStripMenuItem_13.ShortcutKeyDisplayString = "";
					num = 222;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_1872;
					}
					continue;
					IL_182D:
					this.toolStripMenuItem_13.Name = Class15.smethod_17(1603809230 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
					goto IL_184D;
					IL_180D:
					this.toolStripMenuItem_46.Text = Class15.smethod_17(1042092445 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad);
					goto IL_182D;
					IL_1872:
					this.toolStripMenuItem_13.ShortcutKeys = Keys.F2;
					num = 348;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						goto IL_15CA;
					}
					continue;
					IL_1899:
					this.toolStripStatusLabel_3 = new ToolStripStatusLabel();
					num = 301;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						continue;
					}
					IL_18B9:
					this.toolStripStatusLabel_4 = new ToolStripStatusLabel();
					num = 245;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						continue;
					}
					IL_18D9:
					this.toolStripStatusLabel_6 = new ToolStripStatusLabel();
					num = 113;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_18F9;
					}
					continue;
					IL_1904:
					this.listView_0 = new ListView();
					num = 118;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_0E0E;
					}
					continue;
					IL_18F9:
					this.toolStripStatusLabel_5 = new ToolStripStatusLabel();
					goto IL_1904;
					IL_19AB:
					this.menuStrip_0.ResumeLayout(false);
					num = 85;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto IL_0BFE;
					}
					continue;
					IL_1990:
					this.Text = Class15.smethod_17(1788630700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
					goto IL_19AB;
					IL_1989:
					base.StartPosition = FormStartPosition.CenterScreen;
					goto IL_1990;
					IL_196E:
					base.Name = Class15.smethod_17(1985309996 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba);
					goto IL_1989;
					IL_31CF:
					base.MainMenuStrip = this.menuStrip_0;
					goto IL_196E;
					IL_1A28:
					this.toolStripSeparator_1.Size = new Size(290, 6);
					num = 113;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_1A53;
					}
					continue;
					IL_1A08:
					this.toolStripSeparator_1.Name = Class15.smethod_17(768779380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
					goto IL_1A28;
					IL_19E8:
					this.toolStripMenuItem_5.Text = Class15.smethod_17(1176457056 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
					goto IL_1A08;
					IL_19D1:
					this.toolStripMenuItem_5.Size = new Size(293, 22);
					goto IL_19E8;
					IL_267F:
					this.toolStripMenuItem_5.Name = Class15.smethod_17(1270988440 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112);
					goto IL_19D1;
					IL_2665:
					this.contextMenuStrip_0.Size = new Size(294, 330);
					goto IL_267F;
					IL_2645:
					this.contextMenuStrip_0.Name = Class15.smethod_17(1396563878 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7);
					goto IL_2665;
					IL_258D:
					this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
					{
						this.toolStripMenuItem_5, this.toolStripSeparator_1, this.toolStripMenuItem_6, this.toolStripMenuItem_7, this.toolStripMenuItem_47, this.toolStripMenuItem_8, this.toolStripMenuItem_45, this.toolStripSeparator_2, this.toolStripMenuItem_9, this.toolStripMenuItem_10,
						this.toolStripMenuItem_11, this.toolStripSeparator_3, this.toolStripMenuItem_12, this.toolStripMenuItem_46, this.toolStripMenuItem_13, this.toolStripMenuItem_14, this.toolStripMenuItem_17
					});
					goto IL_2645;
					IL_1A53:
					this.toolStripMenuItem_7.Name = Class15.smethod_17(89034714 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_1A88;
					}
					continue;
					IL_3CCF:
					this.toolStripMenuItem_6.Text = Class15.smethod_17(1387464104 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
					goto IL_1A53;
					IL_1B17:
					this.toolStripButton_7.Name = Class15.smethod_17(1570986839 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406);
					num = 173;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
					{
						goto IL_1B4C;
					}
					continue;
					IL_1B58:
					this.toolStripButton_7.Size = new Size(23, 22);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
					{
						goto IL_1B81;
					}
					continue;
					IL_1B4C:
					this.toolStripButton_7.Overflow = ToolStripItemOverflow.Never;
					goto IL_1B58;
					IL_1BF3:
					this.toolStripButton_6.Size = new Size(23, 22);
					num = 399;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_1296;
					}
					continue;
					IL_220D:
					this.toolStripButton_6.Overflow = ToolStripItemOverflow.Never;
					goto IL_1BF3;
					IL_21ED:
					this.toolStripButton_6.Name = Class15.smethod_17(314776563 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
					goto IL_220D;
					IL_2DF9:
					this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
					goto IL_21ED;
					IL_1C92:
					this.toolStripButton_5.Text = Class15.smethod_17(1176458556 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
					num = 139;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
					{
						goto IL_1CC7;
					}
					continue;
					IL_1C7E:
					this.toolStripButton_5.Size = new Size(54, 59);
					goto IL_1C92;
					IL_1C6D:
					this.toolStripButton_5.Padding = new Padding(1);
					goto IL_1C7E;
					IL_1C4D:
					this.toolStripButton_5.Name = Class15.smethod_17(698999420 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
					goto IL_1C6D;
					IL_1C3D:
					this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
					goto IL_1C4D;
					IL_1C31:
					this.toolStripButton_5.ImageScaling = ToolStripItemImageScaling.None;
					goto IL_1C3D;
					IL_1C21:
					this.toolStripButton_5.Image = Resources.Info;
					goto IL_1C31;
					IL_1D0F:
					this.toolStripStatusLabel_5.Size = new Size(85, 22);
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_1D38;
					}
					continue;
					IL_1CEF:
					this.toolStripStatusLabel_5.Name = Class15.smethod_17(1678092496 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a);
					goto IL_1D0F;
					IL_1CDF:
					this.toolStripStatusLabel_5.LinkColor = SystemColors.ControlText;
					goto IL_1CEF;
					IL_1CD3:
					this.toolStripStatusLabel_5.LinkBehavior = LinkBehavior.HoverUnderline;
					goto IL_1CDF;
					IL_1CC7:
					this.toolStripStatusLabel_5.IsLink = true;
					goto IL_1CD3;
					IL_1D6D:
					this.toolStripMenuItem_50 = new ToolStripMenuItem();
					num = 329;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
					{
						goto IL_0E5A;
					}
					continue;
					IL_1DA8:
					this.toolStripMenuItem_4 = new ToolStripMenuItem();
					num = 479;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
					{
						goto IL_1DC8;
					}
					continue;
					IL_1D9D:
					this.toolStripMenuItem_41 = new ToolStripMenuItem();
					goto IL_1DA8;
					IL_1DC8:
					this.toolStripMenuItem_39 = new ToolStripMenuItem();
					num = 478;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto IL_1DE8;
					}
					continue;
					IL_3EAC:
					this.toolStripSeparator_8 = new ToolStripSeparator();
					goto IL_1DC8;
					IL_1DE8:
					this.toolStripStatusLabel_3.Name = Class15.smethod_17(1802344649 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
					num = 35;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_1E1D;
					}
					continue;
					IL_1E31:
					this.toolStripStatusLabel_3.Text = Class15.smethod_17(974452187 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
					num = 161;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
					{
						goto IL_1E66;
					}
					continue;
					IL_1E1D:
					this.toolStripStatusLabel_3.Size = new Size(11, 22);
					goto IL_1E31;
					IL_1E66:
					this.toolStripMenuItem_12.Size = new Size(293, 22);
					num = 482;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto IL_1D6D;
					}
					continue;
					IL_1EC3:
					this.toolStripButton_3.Name = Class15.smethod_17(552178410 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f);
					num = 62;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_1EF8;
					}
					continue;
					IL_1EB3:
					this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
					goto IL_1EC3;
					IL_1EA7:
					this.toolStripButton_3.ImageScaling = ToolStripItemImageScaling.None;
					goto IL_1EB3;
					IL_1E97:
					this.toolStripButton_3.Image = Resources.Viewer;
					goto IL_1EA7;
					IL_3201:
					this.toolStripButton_3.Font = new Font(Class15.smethod_17(299952633 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_1E97;
					IL_1F1D:
					this.toolStripButton_3.Text = Class15.smethod_17(486525002 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c);
					num = 450;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						goto IL_0092;
					}
					continue;
					IL_1F09:
					this.toolStripButton_3.Size = new Size(54, 59);
					goto IL_1F1D;
					IL_1EF8:
					this.toolStripButton_3.Padding = new Padding(1);
					goto IL_1F09;
					IL_2014:
					this.statusStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabel_0, this.toolStripStatusLabel_1, this.toolStripStatusLabel_2, this.toolStripStatusLabel_3, this.toolStripStatusLabel_4, this.toolStripStatusLabel_6, this.toolStripStatusLabel_5 });
					num = 133;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_207E;
					}
					continue;
					IL_20AF:
					this.toolStripMenuItem_2.Name = Class15.smethod_17(2008548733 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
					num = 230;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
					{
						goto IL_1A53;
					}
					continue;
					IL_207E:
					this.toolStripMenuItem_2.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_48, this.toolStripMenuItem_49, this.toolStripMenuItem_37 });
					goto IL_20AF;
					IL_39CB:
					this.toolStripMenuItem_36.Text = Class15.smethod_17(538808119 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
					goto IL_207E;
					IL_210A:
					this.toolStripMenuItem_1 = new ToolStripMenuItem();
					num = 46;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_212A;
					}
					continue;
					IL_20FF:
					this.toolStripMenuItem_30 = new ToolStripMenuItem();
					goto IL_210A;
					IL_20F4:
					this.toolStripSeparator_6 = new ToolStripSeparator();
					goto IL_20FF;
					IL_214B:
					this.toolStripSeparator_7 = new ToolStripSeparator();
					num = 297;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_216B;
					}
					continue;
					IL_2140:
					this.toolStripMenuItem_33 = new ToolStripMenuItem();
					goto IL_214B;
					IL_2135:
					this.toolStripMenuItem_32 = new ToolStripMenuItem();
					goto IL_2140;
					IL_212A:
					this.toolStripMenuItem_31 = new ToolStripMenuItem();
					goto IL_2135;
					IL_216B:
					this.toolStripMenuItem_34 = new ToolStripMenuItem();
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_218B;
					}
					continue;
					IL_2196:
					this.toolStripMenuItem_36 = new ToolStripMenuItem();
					num = 180;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_21B6;
					}
					continue;
					IL_218B:
					this.toolStripMenuItem_35 = new ToolStripMenuItem();
					goto IL_2196;
					IL_227F:
					this.toolStripButton_0.ImageScaling = ToolStripItemImageScaling.None;
					num = 506;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto IL_22A0;
					}
					continue;
					IL_226F:
					this.toolStripButton_0.Image = Resources.Compress;
					goto IL_227F;
					IL_223E:
					this.toolStripButton_0.Font = new Font(Class15.smethod_17(1270984276 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_226F;
					IL_221E:
					this.toolStrip_0.Text = Class15.smethod_17(768778408 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
					goto IL_223E;
					IL_22C0:
					this.toolStripMenuItem_42.Name = Class15.smethod_17(1788748069 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
					num = 150;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
					{
						goto IL_22F5;
					}
					continue;
					IL_22A0:
					this.toolStripMenuItem_43.Text = Class15.smethod_17(1042094287 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad);
					goto IL_22C0;
					IL_22F5:
					this.toolStripMenuItem_42.Size = new Size(196, 22);
					num = 125;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_1E66;
					}
					continue;
					IL_2326:
					this.listView_0.Location = new Point(0, 112);
					num = 187;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_234E;
					}
					continue;
					IL_2728:
					this.listView_0.LabelEdit = true;
					goto IL_2326;
					IL_2BAB:
					this.listView_0.FullRowSelect = true;
					goto IL_2728;
					IL_2B7A:
					this.listView_0.Font = new Font(Class15.smethod_17(1807889964 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_2BAB;
					IL_236E:
					this.listView_0.Size = new Size(834, 422);
					num = 422;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto IL_239D;
					}
					continue;
					IL_234E:
					this.listView_0.Name = Class15.smethod_17(1807886010 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
					goto IL_236E;
					IL_23CD:
					this.toolStripMenuItem_6.ShortcutKeys = (Keys)131137;
					num = 184;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto Block_16;
					}
					continue;
					IL_23BD:
					this.toolStripMenuItem_6.ShortcutKeyDisplayString = "";
					goto IL_23CD;
					IL_239D:
					this.toolStripMenuItem_6.Name = Class15.smethod_17(1802345339 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
					goto IL_23BD;
					IL_2419:
					this.statusStrip_0.ResumeLayout(false);
					num = 190;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_243A;
					}
					continue;
					IL_240E:
					this.toolStrip_1.PerformLayout();
					goto IL_2419;
					IL_2402:
					this.toolStrip_1.ResumeLayout(false);
					goto IL_240E;
					IL_23F7:
					this.toolStrip_0.PerformLayout();
					goto IL_2402;
					IL_243A:
					this.statusStrip_0.PerformLayout();
					num = 231;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_245A;
					}
					continue;
					IL_2465:
					this.toolStripMenuItem_17 = new ToolStripMenuItem();
					num = 57;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						goto IL_0C1E;
					}
					continue;
					IL_245A:
					this.toolStripMenuItem_16 = new ToolStripMenuItem();
					goto IL_2465;
					IL_3745:
					this.toolStripMenuItem_15 = new ToolStripMenuItem();
					goto IL_245A;
					IL_2558:
					this.toolStripButton_2.Text = Class15.smethod_17(1807885218 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
					num = 377;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						goto IL_258D;
					}
					continue;
					IL_2544:
					this.toolStripButton_2.Size = new Size(54, 59);
					goto IL_2558;
					IL_2533:
					this.toolStripButton_2.Padding = new Padding(1);
					goto IL_2544;
					IL_2513:
					this.toolStripButton_2.Name = Class15.smethod_17(41450389 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d);
					goto IL_2533;
					IL_2503:
					this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
					goto IL_2513;
					IL_24F7:
					this.toolStripButton_2.ImageScaling = ToolStripItemImageScaling.None;
					goto IL_2503;
					IL_24E7:
					this.toolStripButton_2.Image = Resources.Tester;
					goto IL_24F7;
					IL_24B6:
					this.toolStripButton_2.Font = new Font(Class15.smethod_17(277641820 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_24E7;
					IL_24AA:
					this.toolStripButton_1.TextImageRelation = TextImageRelation.ImageAboveText;
					goto IL_24B6;
					IL_248A:
					this.toolStripButton_1.Text = Class15.smethod_17(2128229378 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
					goto IL_24AA;
					IL_2E39:
					this.toolStripButton_1.Size = new Size(54, 59);
					goto IL_248A;
					IL_26A4:
					this.columnHeader_3.Text = Class15.smethod_17(1829602441 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
					num = 146;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						continue;
					}
					IL_26D9:
					this.columnHeader_3.Width = 180;
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_0283;
					}
					continue;
					IL_2703:
					this.toolStripSeparator_9 = new ToolStripSeparator();
					num = 242;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_1989;
					}
					continue;
					IL_2739:
					this.toolStrip_1.Items.AddRange(new ToolStripItem[] { this.toolStripButton_6, this.toolStripSeparator_0, this.toolStripButton_7, this.toolStripComboBox_0 });
					num = 131;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_2788;
					}
					continue;
					IL_2A66:
					this.toolStripSeparator_0.Size = new Size(6, 25);
					goto IL_2739;
					IL_27DE:
					this.toolStrip_1.Text = Class15.smethod_17(197584457 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81);
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_2813;
					}
					continue;
					IL_27D2:
					this.toolStrip_1.TabIndex = 2;
					goto IL_27DE;
					IL_27BB:
					this.toolStrip_1.Size = new Size(834, 25);
					goto IL_27D2;
					IL_279B:
					this.toolStrip_1.Name = Class15.smethod_17(642136900 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
					goto IL_27BB;
					IL_2788:
					this.toolStrip_1.Location = new Point(0, 87);
					goto IL_279B;
					IL_2813:
					this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
					num = 280;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
					{
						goto IL_2503;
					}
					continue;
					IL_2855:
					this.toolStripMenuItem_13 = new ToolStripMenuItem();
					num = 176;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto IL_1989;
					}
					continue;
					IL_28F1:
					this.toolStripMenuItem_28.Size = new Size(233, 22);
					num = 493;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
					{
						goto IL_1BF3;
					}
					continue;
					IL_28D1:
					this.toolStripMenuItem_28.ShortcutKeyDisplayString = Class15.smethod_17(89036270 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
					goto IL_28F1;
					IL_28B1:
					this.toolStripMenuItem_28.Name = Class15.smethod_17(635813251 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					goto IL_28D1;
					IL_289B:
					this.toolStripSeparator_5.Size = new Size(230, 6);
					goto IL_28B1;
					IL_30BC:
					this.toolStripSeparator_5.Name = Class15.smethod_17(1760310241 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_289B;
					IL_294E:
					this.toolStripMenuItem_41.Size = new Size(144, 22);
					num = 115;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_297A;
					}
					continue;
					IL_292E:
					this.toolStripMenuItem_41.Name = Class15.smethod_17(124844096 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
					goto IL_294E;
					IL_2922:
					this.toolStripMenuItem_41.CheckState = CheckState.Checked;
					goto IL_292E;
					IL_299A:
					this.toolStripMenuItem_4.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_50, this.toolStripSeparator_10, this.toolStripMenuItem_43, this.toolStripMenuItem_42, this.toolStripSeparator_9, this.toolStripMenuItem_44 });
					num = 475;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto IL_27BB;
					}
					continue;
					IL_297A:
					this.toolStripMenuItem_41.Text = Class15.smethod_17(1424578702 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf);
					goto IL_299A;
					IL_2A11:
					this.toolStripSeparator_0 = new ToolStripSeparator();
					num = 367;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						continue;
					}
					IL_2A31:
					this.toolStripSeparator_0.Name = Class15.smethod_17(314776451 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
					num = 61;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						goto IL_2A66;
					}
					continue;
					IL_2ACE:
					this.toolStripMenuItem_31.Size = new Size(279, 22);
					num = 91;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto IL_0C86;
					}
					continue;
					IL_2ABE:
					this.toolStripMenuItem_31.ShortcutKeys = (Keys)262209;
					goto IL_2ACE;
					IL_2A9E:
					this.toolStripMenuItem_31.Name = Class15.smethod_17(926379043 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296);
					goto IL_2ABE;
					IL_2AFF:
					this.toolStripButton_5 = new ToolStripButton();
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_2A11;
					}
					continue;
					IL_2CAE:
					this.toolStripButton_8 = new ToolStripButton();
					goto IL_2AFF;
					IL_2CA3:
					this.toolStripButton_4 = new ToolStripButton();
					goto IL_2CAE;
					IL_2C98:
					this.toolStripButton_3 = new ToolStripButton();
					goto IL_2CA3;
					IL_2BBC:
					this.columnHeader_3 = new ColumnHeader();
					num = 52;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_2BDC;
					}
					continue;
					IL_31BF:
					this.columnHeader_2 = new ColumnHeader();
					goto IL_2BBC;
					IL_2BED:
					this.toolStripMenuItem_5 = new ToolStripMenuItem();
					num = 123;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_2C0D;
					}
					continue;
					IL_2BDC:
					this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
					goto IL_2BED;
					IL_2C33:
					this.toolStripComboBox_0 = new ToolStripComboBox();
					num = 336;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_21D2;
					}
					continue;
					IL_2C28:
					this.toolStripButton_7 = new ToolStripButton();
					goto IL_2C33;
					IL_2C58:
					this.toolStripButton_1 = new ToolStripButton();
					num = 136;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						continue;
					}
					IL_2C78:
					this.toolStripButton_2 = new ToolStripButton();
					num = 131;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto IL_2C98;
					}
					continue;
					IL_2CDF:
					this.listView_0.UseCompatibleStateImageBehavior = false;
					num = 288;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
					{
						goto IL_1D9D;
					}
					continue;
					IL_2D05:
					this.toolStripMenuItem_27 = new ToolStripMenuItem();
					num = 494;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto IL_16B0;
					}
					continue;
					IL_3AC7:
					this.toolStripMenuItem_26 = new ToolStripMenuItem();
					goto IL_2D05;
					IL_2D70:
					this.toolStripButton_4.Image = Resources.Delete;
					num = 171;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
					{
						goto IL_0229;
					}
					continue;
					IL_2D9A:
					this.toolStripButton_1.Name = Class15.smethod_17(82297900 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909);
					num = 132;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto Block_31;
					}
					continue;
					IL_37FA:
					this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
					goto IL_2D9A;
					IL_2E19:
					base.SuspendLayout();
					num = 384;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0006;
					}
					continue;
					IL_2E0E:
					this.contextMenuStrip_0.SuspendLayout();
					goto IL_2E19;
					IL_32A3:
					this.statusStrip_0.SuspendLayout();
					goto IL_2E0E;
					IL_3298:
					this.toolStrip_1.SuspendLayout();
					goto IL_32A3;
					IL_328D:
					this.toolStrip_0.SuspendLayout();
					goto IL_3298;
					IL_2E72:
					this.toolStripMenuItem_30.Size = new Size(233, 22);
					num = 297;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto IL_1C4D;
					}
					continue;
					IL_2E52:
					this.toolStripMenuItem_30.Name = Class15.smethod_17(1793858926 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
					goto IL_2E72;
					IL_2EA3:
					this.toolStripStatusLabel_2.Size = new Size(339, 22);
					num = 151;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_2839;
					}
					continue;
					IL_2EFC:
					this.toolStripMenuItem_39.Name = Class15.smethod_17(89033066 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
					num = 389;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto Block_36;
					}
					continue;
					IL_2ED4:
					this.toolStripMenuItem_39.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_40, this.toolStripMenuItem_41 });
					goto IL_2EFC;
					IL_2F43:
					this.toolStripStatusLabel_6.ForeColor = Color.Silver;
					num = 175;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						goto IL_10FF;
					}
					continue;
					IL_2F36:
					this.toolStripStatusLabel_4.TextAlign = ContentAlignment.MiddleLeft;
					goto IL_2F43;
					IL_3044:
					this.toolStripMenuItem_40.Size = new Size(144, 22);
					num = 72;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_3070;
					}
					continue;
					IL_3024:
					this.toolStripMenuItem_40.Name = Class15.smethod_17(564893496 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
					goto IL_3044;
					IL_3004:
					this.toolStripMenuItem_39.Text = Class15.smethod_17(2048532793 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
					goto IL_3024;
					IL_3087:
					this.toolStripMenuItem_27.Text = Class15.smethod_17(2008549027 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
					num = 106;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto IL_30BC;
					}
					continue;
					IL_3070:
					this.toolStripMenuItem_27.Size = new Size(233, 22);
					goto IL_3087;
					IL_3132:
					this.toolStripMenuItem_2.Text = Class15.smethod_17(1985312798 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba);
					num = 255;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_2140;
					}
					continue;
					IL_316C:
					this.toolStrip_0.Location = new Point(0, 25);
					num = 385;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto IL_3194;
					}
					continue;
					IL_33B8:
					this.toolStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3, this.toolStripButton_4, this.toolStripButton_8, this.toolStripButton_5 });
					goto IL_316C;
					IL_3398:
					this.toolStripMenuItem_44.Text = Class15.smethod_17(1387469514 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
					goto IL_33B8;
					IL_3194:
					this.statusStrip_0.Location = new Point(0, 534);
					num = 352;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
					{
						goto IL_31BF;
					}
					continue;
					IL_3243:
					this.toolStripButton_7.Image = Resources.Folder;
					num = 221;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_2E72;
					}
					continue;
					IL_32B3:
					this.toolStripMenuItem_42 = new ToolStripMenuItem();
					num = 289;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_2703;
					}
					continue;
					IL_32D8:
					this.toolStripMenuItem_1.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_31, this.toolStripMenuItem_32, this.toolStripMenuItem_33, this.toolStripSeparator_7, this.toolStripMenuItem_34, this.toolStripMenuItem_35, this.toolStripMenuItem_36 });
					num = 194;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_3342;
					}
					continue;
					IL_3367:
					this.toolStripStatusLabel_4.Size = new Size(339, 22);
					num = 78;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_2419;
					}
					continue;
					IL_3482:
					this.toolStripMenuItem_25.ShortcutKeyDisplayString = Class15.smethod_17(1829609137 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
					num = 173;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_2FD1;
					}
					continue;
					IL_3462:
					this.toolStripMenuItem_25.Name = Class15.smethod_17(1270981430 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112);
					goto IL_3482;
					IL_34D3:
					this.toolStripMenuItem_13.Text = Class15.smethod_17(197586301 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81);
					num = 108;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto Block_44;
					}
					continue;
					IL_350D:
					this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
					num = 174;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
					{
						goto IL_14E1;
					}
					continue;
					IL_3538:
					this.columnHeader_0.Width = 300;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
					{
						goto IL_355D;
					}
					continue;
					IL_378F:
					this.columnHeader_0.Text = Class15.smethod_17(197583799 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81);
					goto IL_3538;
					IL_387B:
					this.columnHeader_0.Tag = Class15.smethod_17(2021175216 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
					goto IL_378F;
					IL_3599:
					this.toolStripMenuItem_37.Text = Class15.smethod_17(564889704 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
					num = 492;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						goto IL_025E;
					}
					continue;
					IL_3582:
					this.toolStripMenuItem_37.Size = new Size(181, 22);
					goto IL_3599;
					IL_35D3:
					this.toolStripMenuItem_37.ShortcutKeys = (Keys)262217;
					goto IL_3582;
					IL_3900:
					this.toolStripMenuItem_37.Name = Class15.smethod_17(1387464566 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
					goto IL_35D3;
					IL_35E5:
					this.toolStripSeparator_8.Name = Class15.smethod_17(676692026 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b);
					num = 185;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_2558;
					}
					continue;
					IL_362F:
					this.toolStripMenuItem_32.ShortcutKeys = (Keys)262211;
					num = 103;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_3654;
					}
					continue;
					IL_366B:
					this.toolStripMenuItem_32.Text = Class15.smethod_17(1793859292 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
					num = 489;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_2F36;
					}
					continue;
					IL_3654:
					this.toolStripMenuItem_32.Size = new Size(279, 22);
					goto IL_366B;
					IL_36CA:
					this.toolStrip_0.TabIndex = 1;
					num = 41;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						goto IL_221E;
					}
					continue;
					IL_36FB:
					this.toolStripMenuItem_43 = new ToolStripMenuItem();
					num = 116;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_32B3;
					}
					continue;
					IL_37B4:
					this.toolStripMenuItem_32.Name = Class15.smethod_17(1424574392 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf);
					num = 333;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_15BD;
					}
					continue;
					IL_38B5:
					base.Controls.Add(this.menuStrip_0);
					num = 225;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_31CF;
					}
					continue;
					IL_395F:
					this.toolStripMenuItem_48.ShortcutKeys = (Keys)131142;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_3984;
					}
					continue;
					IL_398F:
					this.toolStripButton_0 = new ToolStripButton();
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_2C58;
					}
					continue;
					IL_3984:
					this.toolStrip_0 = new ToolStrip();
					goto IL_398F;
					IL_3A61:
					this.columnHeader_1 = new ColumnHeader();
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_31BF;
					}
					continue;
					IL_3AA7:
					this.toolStripMenuItem_25 = new ToolStripMenuItem();
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_3AC7;
					}
					continue;
					IL_3F84:
					this.toolStripSeparator_4 = new ToolStripSeparator();
					goto IL_3AA7;
					IL_3B7E:
					this.toolStripSeparator_9.Size = new Size(193, 6);
					num = 148;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						goto IL_3BA9;
					}
					continue;
					IL_3E87:
					this.toolStripSeparator_9.Name = Class15.smethod_17(1042094895 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad);
					goto IL_3B7E;
					IL_3BA9:
					this.toolStripMenuItem_44.Name = Class15.smethod_17(277638814 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
					num = 37;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						goto IL_0B44;
					}
					continue;
					IL_3D83:
					this.toolStripStatusLabel_6.Size = new Size(11, 22);
					num = 318;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						continue;
					}
					IL_3DAC:
					this.toolStripMenuItem_40.Text = Class15.smethod_17(698999076 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
					num = 448;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_3201;
					}
				}
				IL_0D49:
				this.toolStripMenuItem_8.Text = Class15.smethod_17(2021173552 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
				goto IL_02C4;
				IL_2B6A:
				this.toolStripMenuItem_7 = new ToolStripMenuItem();
				goto IL_046F;
				IL_2C18:
				this.toolStripMenuItem_6 = new ToolStripMenuItem();
				goto IL_2B6A;
				IL_2C0D:
				this.toolStripSeparator_1 = new ToolStripSeparator();
				goto IL_2C18;
				IL_1FE3:
				this.toolStripMenuItem_4.Name = Class15.smethod_17(594368998 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b);
				goto IL_0527;
				Block_36:
				goto IL_0550;
				Block_44:
				goto IL_0585;
				IL_145B:
				this.toolStripMenuItem_17.Text = Class15.smethod_17(1743173676 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
				goto IL_09A6;
				IL_1629:
				this.toolStripSeparator_5 = new ToolStripSeparator();
				goto IL_070C;
				IL_1AF2:
				this.toolStripStatusLabel_1.Name = Class15.smethod_17(314776721 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
				goto IL_072C;
				IL_1AE2:
				this.toolStripStatusLabel_1.ForeColor = Color.Silver;
				goto IL_1AF2;
				IL_1AC2:
				this.toolStripStatusLabel_0.Text = Class15.smethod_17(1743172924 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
				goto IL_1AE2;
				IL_1AAE:
				this.toolStripStatusLabel_0.Size = new Size(22, 22);
				goto IL_1AC2;
				IL_1A9D:
				this.toolStripStatusLabel_0.Padding = new Padding(3);
				goto IL_1AAE;
				Block_2:
				goto IL_072C;
				IL_174F:
				this.toolStripMenuItem_3.Text = Class15.smethod_17(2060615152 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
				goto IL_0775;
				IL_173B:
				this.toolStripMenuItem_3.Size = new Size(62, 21);
				goto IL_174F;
				IL_171B:
				this.toolStripMenuItem_3.Name = Class15.smethod_17(1678095076 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a);
				goto IL_173B;
				IL_16EA:
				this.toolStripMenuItem_3.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_38, this.toolStripSeparator_8, this.toolStripMenuItem_39 });
				goto IL_171B;
				Block_16:
				goto IL_0951;
				Block_69:
				goto IL_093A;
				Block_31:
				goto IL_092A;
				Block_6:
				goto IL_08D3;
				IL_02E4:
				this.toolStripMenuItem_45.ShortcutKeys = Keys.F5;
				num = 93;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0306;
				}
				goto IL_40BB;
				IL_02C4:
				this.toolStripMenuItem_45.Name = Class15.smethod_17(486526046 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c);
				goto IL_02E4;
				IL_0306:
				this.toolStripMenuItem_45.Size = new Size(293, 22);
				num = 250;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_0332;
				}
				goto IL_40BB;
				IL_0352:
				this.toolStripSeparator_2.Name = Class15.smethod_17(277638042 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
				num = 493;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					goto IL_0387;
				}
				goto IL_40BB;
				IL_0332:
				this.toolStripMenuItem_45.Text = Class15.smethod_17(1243255804 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
				goto IL_0352;
				IL_039D:
				this.toolStripMenuItem_9.Name = Class15.smethod_17(197583403 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81);
				num = 176;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_03D2;
				}
				goto IL_40BB;
				IL_0387:
				this.toolStripSeparator_2.Size = new Size(290, 6);
				goto IL_039D;
				IL_0419:
				this.toolStripMenuItem_10.Name = Class15.smethod_17(124845944 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
				num = 244;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
				{
					goto IL_044E;
				}
				goto IL_40BB;
				IL_03F9:
				this.toolStripMenuItem_9.Text = Class15.smethod_17(538810281 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
				goto IL_0419;
				IL_03E2:
				this.toolStripMenuItem_9.Size = new Size(293, 22);
				goto IL_03F9;
				IL_03D2:
				this.toolStripMenuItem_9.ShortcutKeys = (Keys)262209;
				goto IL_03E2;
				IL_044E:
				this.toolStripButton_7.AutoSize = false;
				num = 376;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto IL_046F;
				}
				goto IL_40BB;
				IL_04A6:
				this.toolStripMenuItem_10 = new ToolStripMenuItem();
				num = 50;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_04C6;
				}
				goto IL_40BB;
				IL_049B:
				this.toolStripMenuItem_9 = new ToolStripMenuItem();
				goto IL_04A6;
				IL_0490:
				this.toolStripSeparator_2 = new ToolStripSeparator();
				goto IL_049B;
				IL_0485:
				this.toolStripMenuItem_45 = new ToolStripMenuItem();
				goto IL_0490;
				IL_047A:
				this.toolStripMenuItem_8 = new ToolStripMenuItem();
				goto IL_0485;
				IL_046F:
				this.toolStripMenuItem_47 = new ToolStripMenuItem();
				goto IL_047A;
				IL_04D1:
				this.toolStripSeparator_3 = new ToolStripSeparator();
				num = 104;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_04F1;
				}
				goto IL_40BB;
				IL_04C6:
				this.toolStripMenuItem_11 = new ToolStripMenuItem();
				goto IL_04D1;
				IL_0507:
				this.toolStripMenuItem_20 = new ToolStripMenuItem();
				num = 196;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					goto IL_0527;
				}
				goto IL_40BB;
				IL_04FC:
				this.toolStripMenuItem_19 = new ToolStripMenuItem();
				goto IL_0507;
				IL_04F1:
				this.toolStripMenuItem_18 = new ToolStripMenuItem();
				goto IL_04FC;
				IL_0527:
				this.toolStripMenuItem_4.Size = new Size(61, 21);
				num = 29;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_40BB;
				}
				IL_0550:
				this.toolStripMenuItem_4.Text = Class15.smethod_17(1270987260 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112);
				num = 496;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_40BB;
				}
				IL_0585:
				this.toolStripMenuItem_14.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_15, this.toolStripMenuItem_16 });
				num = 148;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_05C2;
				}
				goto IL_40BB;
				IL_05F9:
				this.toolStripMenuItem_14.Text = Class15.smethod_17(543253536 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89);
				num = 499;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_09A6;
				}
				goto IL_40BB;
				IL_05E2:
				this.toolStripMenuItem_14.Size = new Size(293, 22);
				goto IL_05F9;
				IL_05C2:
				this.toolStripMenuItem_14.Name = Class15.smethod_17(1793853442 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
				goto IL_05E2;
				IL_0633:
				this.toolStripMenuItem_18.CheckState = CheckState.Checked;
				num = 47;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_0654;
				}
				goto IL_40BB;
				IL_09A6:
				this.toolStripMenuItem_18.Checked = true;
				goto IL_0633;
				IL_068B:
				this.toolStripMenuItem_18.Text = Class15.smethod_17(543253694 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89);
				num = 267;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_06C0;
				}
				goto IL_40BB;
				IL_0674:
				this.toolStripMenuItem_18.Size = new Size(144, 22);
				goto IL_068B;
				IL_0654:
				this.toolStripMenuItem_18.Name = Class15.smethod_17(1788628524 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
				goto IL_0674;
				IL_06E0:
				this.toolStripMenuItem_19.Size = new Size(144, 22);
				num = 322;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_070C;
				}
				goto IL_40BB;
				IL_06C0:
				this.toolStripMenuItem_19.Name = Class15.smethod_17(277636454 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
				goto IL_06E0;
				IL_070C:
				this.toolStripMenuItem_28 = new ToolStripMenuItem();
				num = 473;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_072C;
				}
				goto IL_40BB;
				IL_0740:
				this.toolStripStatusLabel_1.Text = Class15.smethod_17(676693214 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b);
				num = 212;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_0775;
				}
				goto IL_40BB;
				IL_072C:
				this.toolStripStatusLabel_1.Size = new Size(11, 22);
				goto IL_0740;
				IL_07A5:
				this.toolStripMenuItem_38.Size = new Size(168, 22);
				num = 275;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto IL_07D1;
				}
				goto IL_40BB;
				IL_0795:
				this.toolStripMenuItem_38.ShortcutKeys = (Keys)131155;
				goto IL_07A5;
				IL_0775:
				this.toolStripMenuItem_38.Name = Class15.smethod_17(1678093628 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a);
				goto IL_0795;
				IL_07F1:
				this.toolStripMenuItem_26.Enabled = false;
				num = 118;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_0812;
				}
				goto IL_40BB;
				IL_07D1:
				this.toolStripMenuItem_25.Text = Class15.smethod_17(1788631988 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
				goto IL_07F1;
				IL_0852:
				this.toolStripMenuItem_26.Size = new Size(233, 22);
				num = 93;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_087E;
				}
				goto IL_40BB;
				IL_0832:
				this.toolStripMenuItem_26.ShortcutKeyDisplayString = Class15.smethod_17(1743170830 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
				goto IL_0852;
				IL_0812:
				this.toolStripMenuItem_26.Name = Class15.smethod_17(41444515 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d);
				goto IL_0832;
				IL_089E:
				this.toolStripMenuItem_27.Name = Class15.smethod_17(1788755125 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
				num = 66;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					goto IL_08D3;
				}
				goto IL_40BB;
				IL_087E:
				this.toolStripMenuItem_26.Text = Class15.smethod_17(277639316 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
				goto IL_089E;
				IL_0971:
				this.toolStripSeparator_4.Name = Class15.smethod_17(2008547829 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
				num = 350;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
				{
					goto IL_09A6;
				}
				goto IL_40BB;
				IL_0951:
				this.toolStripMenuItem_24.Text = Class15.smethod_17(635812559 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
				goto IL_0971;
				IL_093A:
				this.toolStripMenuItem_24.Size = new Size(233, 22);
				goto IL_0951;
				IL_092A:
				this.toolStripMenuItem_24.ShortcutKeys = (Keys)131140;
				goto IL_093A;
				IL_090A:
				this.toolStripMenuItem_24.Name = Class15.smethod_17(277641024 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
				goto IL_092A;
				IL_08EA:
				this.toolStripMenuItem_23.Text = Class15.smethod_17(1270981532 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112);
				goto IL_090A;
				IL_08D3:
				this.toolStripMenuItem_23.Size = new Size(233, 22);
				goto IL_08EA;
				IL_2B45:
				this.toolStripMenuItem_23 = new ToolStripMenuItem();
				num = 112;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_02C4;
				}
				goto IL_40BB;
				IL_2B3A:
				this.toolStripMenuItem_22 = new ToolStripMenuItem();
				goto IL_2B45;
				IL_2B2F:
				this.toolStripMenuItem_0 = new ToolStripMenuItem();
				goto IL_2B3A;
				IL_2B24:
				this.menuStrip_0 = new MenuStrip();
				goto IL_2B2F;
			}
			IL_48EF:
			base.ResumeLayout(false);
			IL_48F6:
			base.PerformLayout();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001E010 File Offset: 0x0001C210
		[CompilerGenerated]
		private void method_63()
		{
			for (;;)
			{
				if (this.listView_0.SelectedItems.Count > 0)
				{
					goto IL_0245;
				}
				int num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					break;
				}
				IL_01EF:
				List<FileItem> list;
				switch (num)
				{
				case 0:
					goto IL_01C2;
				case 1:
				case 12:
					goto IL_0104;
				case 2:
					goto IL_022B;
				case 3:
					break;
				case 4:
					goto IL_018A;
				case 5:
					return;
				case 6:
					IL_0245:
					list = new List<FileItem>();
					goto IL_0231;
				case 7:
				case 8:
					this.toolStripStatusLabel_2.Text = string.Empty;
					goto IL_0104;
				case 9:
					continue;
				case 10:
					goto IL_0231;
				case 11:
					goto IL_0127;
				default:
					goto IL_01C2;
				}
				IL_00C2:
				int num2 = list.Count(new Func<FileItem, bool>(MainForm.<>c.<>c_0.method_12));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_01C2;
				}
				goto IL_01EF;
				IL_022B:
				IEnumerator enumerator;
				try
				{
					IL_0065:
					while (enumerator.MoveNext())
					{
						for (;;)
						{
							IL_0042:
							ListViewItem listViewItem = (ListViewItem)enumerator.Current;
							int num3 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
							{
								for (;;)
								{
									switch (num3)
									{
									default:
										goto IL_0042;
									case 1:
										goto IL_0065;
									case 2:
										goto IL_006E;
									case 3:
										list.Add((FileItem)listViewItem.Tag);
										num3 = 1;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
										{
											goto IL_0064;
										}
										break;
									}
								}
							}
						}
						IL_0064:;
					}
					IL_006E:;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					while (disposable != null)
					{
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
						{
							goto IL_008D;
						}
						IL_00A5:
						switch (num4)
						{
						case 1:
							goto IL_00C1;
						case 2:
							continue;
						}
						IL_008D:
						disposable.Dispose();
						num4 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
						{
							goto IL_00A5;
						}
						break;
					}
					IL_00C1:;
				}
				goto IL_00C2;
				IL_0231:
				enumerator = this.listView_0.SelectedItems.GetEnumerator();
				goto IL_022B;
				IL_0104:
				this.bool_1 = false;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					break;
				}
				goto IL_01EF;
				IL_0127:
				string humanReadableSize = FileHelper.GetHumanReadableSize(list.Where(new Func<FileItem, bool>(MainForm.<>c.<>c_0.method_14)).Sum(new Func<FileItem, long>(MainForm.<>c.<>c_0.method_15)));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_018A;
				}
				goto IL_01EF;
				IL_01C2:
				int num5 = list.Count(new Func<FileItem, bool>(MainForm.<>c.<>c_0.method_13));
				goto IL_0127;
				IL_018A:
				this.method_3(num2, num5, humanReadableSize);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0104;
				}
				goto IL_01EF;
			}
		}

		// Token: 0x04000035 RID: 53
		private string string_0 = string.Empty;

		// Token: 0x04000036 RID: 54
		private readonly List<FileItem> list_0 = new List<FileItem>();

		// Token: 0x04000037 RID: 55
		private int int_0;

		// Token: 0x04000038 RID: 56
		private SortOrder sortOrder_0 = SortOrder.Ascending;

		// Token: 0x04000039 RID: 57
		private SearchItem searchItem_0 = new SearchItem();

		// Token: 0x0400003A RID: 58
		private int int_1 = -1;

		// Token: 0x0400003B RID: 59
		private readonly List<string> list_1 = new List<string>();

		// Token: 0x0400003C RID: 60
		private bool bool_0;

		// Token: 0x0400003D RID: 61
		private global::System.Threading.Timer timer_0;

		// Token: 0x0400003E RID: 62
		private volatile bool bool_1;

		// Token: 0x04000040 RID: 64
		private MenuStrip menuStrip_0;

		// Token: 0x04000041 RID: 65
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000042 RID: 66
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000043 RID: 67
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000044 RID: 68
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000045 RID: 69
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000046 RID: 70
		private ToolStrip toolStrip_0;

		// Token: 0x04000047 RID: 71
		private ToolStripButton toolStripButton_0;

		// Token: 0x04000048 RID: 72
		private ToolStripButton toolStripButton_1;

		// Token: 0x04000049 RID: 73
		private ToolStripButton toolStripButton_2;

		// Token: 0x0400004A RID: 74
		private ToolStripButton toolStripButton_3;

		// Token: 0x0400004B RID: 75
		private ToolStripButton toolStripButton_4;

		// Token: 0x0400004C RID: 76
		private ToolStripButton toolStripButton_5;

		// Token: 0x0400004D RID: 77
		private ToolStripButton toolStripButton_6;

		// Token: 0x0400004E RID: 78
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x0400004F RID: 79
		private ToolStrip toolStrip_1;

		// Token: 0x04000050 RID: 80
		private StatusStrip statusStrip_0;

		// Token: 0x04000051 RID: 81
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x04000052 RID: 82
		private ToolStripStatusLabel toolStripStatusLabel_1;

		// Token: 0x04000053 RID: 83
		private ToolStripStatusLabel toolStripStatusLabel_2;

		// Token: 0x04000054 RID: 84
		private ToolStripStatusLabel toolStripStatusLabel_3;

		// Token: 0x04000055 RID: 85
		private ToolStripStatusLabel toolStripStatusLabel_4;

		// Token: 0x04000056 RID: 86
		private ListView listView_0;

		// Token: 0x04000057 RID: 87
		private ColumnHeader columnHeader_0;

		// Token: 0x04000058 RID: 88
		private ColumnHeader columnHeader_1;

		// Token: 0x04000059 RID: 89
		private ColumnHeader columnHeader_2;

		// Token: 0x0400005A RID: 90
		private ColumnHeader columnHeader_3;

		// Token: 0x0400005B RID: 91
		private ToolStripButton toolStripButton_7;

		// Token: 0x0400005C RID: 92
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x0400005D RID: 93
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x0400005E RID: 94
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x0400005F RID: 95
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04000060 RID: 96
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04000061 RID: 97
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04000062 RID: 98
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04000063 RID: 99
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04000064 RID: 100
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x04000065 RID: 101
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x04000066 RID: 102
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x04000067 RID: 103
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04000068 RID: 104
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x04000069 RID: 105
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x0400006A RID: 106
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x0400006B RID: 107
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x0400006C RID: 108
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x0400006D RID: 109
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x0400006E RID: 110
		private ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x0400006F RID: 111
		private ToolStripMenuItem toolStripMenuItem_19;

		// Token: 0x04000070 RID: 112
		private ToolStripMenuItem toolStripMenuItem_20;

		// Token: 0x04000071 RID: 113
		private ToolStripMenuItem toolStripMenuItem_21;

		// Token: 0x04000072 RID: 114
		private ToolStripMenuItem toolStripMenuItem_22;

		// Token: 0x04000073 RID: 115
		private ToolStripMenuItem toolStripMenuItem_23;

		// Token: 0x04000074 RID: 116
		private ToolStripMenuItem toolStripMenuItem_24;

		// Token: 0x04000075 RID: 117
		private ToolStripSeparator toolStripSeparator_4;

		// Token: 0x04000076 RID: 118
		private ToolStripMenuItem toolStripMenuItem_25;

		// Token: 0x04000077 RID: 119
		private ToolStripMenuItem toolStripMenuItem_26;

		// Token: 0x04000078 RID: 120
		private ToolStripMenuItem toolStripMenuItem_27;

		// Token: 0x04000079 RID: 121
		private ToolStripSeparator toolStripSeparator_5;

		// Token: 0x0400007A RID: 122
		private ToolStripMenuItem toolStripMenuItem_28;

		// Token: 0x0400007B RID: 123
		private ToolStripMenuItem toolStripMenuItem_29;

		// Token: 0x0400007C RID: 124
		private ToolStripSeparator toolStripSeparator_6;

		// Token: 0x0400007D RID: 125
		private ToolStripMenuItem toolStripMenuItem_30;

		// Token: 0x0400007E RID: 126
		private ToolStripMenuItem toolStripMenuItem_31;

		// Token: 0x0400007F RID: 127
		private ToolStripMenuItem toolStripMenuItem_32;

		// Token: 0x04000080 RID: 128
		private ToolStripMenuItem toolStripMenuItem_33;

		// Token: 0x04000081 RID: 129
		private ToolStripSeparator toolStripSeparator_7;

		// Token: 0x04000082 RID: 130
		private ToolStripMenuItem toolStripMenuItem_34;

		// Token: 0x04000083 RID: 131
		private ToolStripMenuItem toolStripMenuItem_35;

		// Token: 0x04000084 RID: 132
		private ToolStripMenuItem toolStripMenuItem_36;

		// Token: 0x04000085 RID: 133
		private ToolStripMenuItem toolStripMenuItem_37;

		// Token: 0x04000086 RID: 134
		private ToolStripMenuItem toolStripMenuItem_38;

		// Token: 0x04000087 RID: 135
		private ToolStripSeparator toolStripSeparator_8;

		// Token: 0x04000088 RID: 136
		private ToolStripMenuItem toolStripMenuItem_39;

		// Token: 0x04000089 RID: 137
		private ToolStripMenuItem toolStripMenuItem_40;

		// Token: 0x0400008A RID: 138
		private ToolStripMenuItem toolStripMenuItem_41;

		// Token: 0x0400008B RID: 139
		private ToolStripMenuItem toolStripMenuItem_42;

		// Token: 0x0400008C RID: 140
		private ToolStripMenuItem toolStripMenuItem_43;

		// Token: 0x0400008D RID: 141
		private ToolStripSeparator toolStripSeparator_9;

		// Token: 0x0400008E RID: 142
		private ToolStripMenuItem toolStripMenuItem_44;

		// Token: 0x0400008F RID: 143
		private ContextMenuStrip contextMenuStrip_1;

		// Token: 0x04000090 RID: 144
		private ToolStripMenuItem toolStripMenuItem_45;

		// Token: 0x04000091 RID: 145
		private ToolStripMenuItem toolStripMenuItem_46;

		// Token: 0x04000092 RID: 146
		private ToolStripMenuItem toolStripMenuItem_47;

		// Token: 0x04000093 RID: 147
		private ToolStripMenuItem toolStripMenuItem_48;

		// Token: 0x04000094 RID: 148
		private ToolStripButton toolStripButton_8;

		// Token: 0x04000095 RID: 149
		private ToolStripMenuItem toolStripMenuItem_49;

		// Token: 0x04000096 RID: 150
		private ToolStripMenuItem toolStripMenuItem_50;

		// Token: 0x04000097 RID: 151
		private ToolStripSeparator toolStripSeparator_10;

		// Token: 0x04000098 RID: 152
		private ToolStripStatusLabel toolStripStatusLabel_5;

		// Token: 0x04000099 RID: 153
		private ToolStripStatusLabel toolStripStatusLabel_6;
	}
}
