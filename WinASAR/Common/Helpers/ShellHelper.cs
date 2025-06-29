using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace WinASAR.Common.Helpers
{
	// Token: 0x02000029 RID: 41
	public class ShellHelper
	{
		// Token: 0x060001BA RID: 442
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessageTimeout(IntPtr intptr_0, int int_0, IntPtr intptr_1, string string_0, uint uint_0, uint uint_1, IntPtr intptr_2);

		// Token: 0x060001BB RID: 443 RVA: 0x0002537C File Offset: 0x0002357C
		public static void CreateFileAssociation(string extension, string progId, string applicationPath, int iconIndex = 0)
		{
			RegistryKey classesRoot;
			for (;;)
			{
				IL_02F4:
				classesRoot = Registry.ClassesRoot;
				int num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_01A8;
				}
				goto IL_0279;
				RegistryKey registryKey;
				do
				{
					IL_0080:
					registryKey.Close();
					num = 23;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0);
				RegistryKey registryKey3;
				RegistryKey registryKey4;
				for (;;)
				{
					IL_0279:
					RegistryKey registryKey2;
					switch (num)
					{
					case 1:
						registryKey2 = registryKey3.CreateSubKey(Class15.smethod_17(1788638366 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
						goto IL_024F;
					case 2:
					case 17:
						goto IL_00DD;
					case 3:
						goto IL_01C9;
					case 4:
						goto IL_01D6;
					case 5:
						goto IL_0159;
					case 6:
						goto IL_00F9;
					case 7:
						goto IL_017A;
					case 8:
					case 23:
						goto IL_00D6;
					case 9:
						goto IL_013B;
					case 10:
					case 12:
						goto IL_0315;
					case 11:
						goto IL_0080;
					case 13:
						goto IL_0079;
					case 14:
						goto IL_024F;
					case 15:
						goto IL_0039;
					case 16:
						goto IL_003D;
					case 18:
						goto IL_0231;
					case 19:
						goto IL_01E4;
					case 20:
						goto IL_01E0;
					case 21:
						goto IL_01A8;
					case 22:
						goto IL_02F4;
					case 24:
						goto IL_0187;
					case 25:
						goto IL_009E;
					case 26:
						return;
					case 27:
						goto IL_0006;
					}
					goto Block_10;
					IL_0006:
					registryKey4 = registryKey.CreateSubKey(Class15.smethod_17(314780523 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						goto IL_0039;
					}
					continue;
					IL_017A:
					if (registryKey != null)
					{
						goto IL_0006;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_00D6;
					}
					continue;
					IL_009E:
					RegistryKey registryKey5;
					registryKey = registryKey5.CreateSubKey(Class15.smethod_17(299944967 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
					goto IL_017A;
					IL_0159:
					if (registryKey5 != null)
					{
						goto IL_009E;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_00DD;
					}
					continue;
					IL_013B:
					registryKey5 = registryKey3.CreateSubKey(Class15.smethod_17(2128217512 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
					goto IL_0159;
					IL_00DD:
					registryKey2.Close();
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
					{
						goto IL_00F9;
					}
					continue;
					IL_00D6:
					registryKey5.Close();
					goto IL_00DD;
					IL_00F9:
					registryKey2.SetValue(string.Empty, string.Format(Class15.smethod_17(1807881202 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), applicationPath, iconIndex));
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_013B;
					}
					continue;
					IL_024F:
					if (registryKey2 != null)
					{
						goto IL_00F9;
					}
					IL_0231:
					registryKey3.Close();
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_017A;
					}
				}
				IL_0079:
				registryKey4.Close();
				goto IL_0080;
				IL_003D:
				registryKey4.SetValue(string.Empty, Class15.smethod_17(538806727 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa) + applicationPath + Class15.smethod_17(2021164588 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
				goto IL_0079;
				IL_0039:
				if (registryKey4 != null)
				{
					goto IL_003D;
				}
				goto IL_0080;
				Block_10:
				goto IL_0227;
				IL_0187:
				RegistryKey registryKey6;
				registryKey6.Close();
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_0080;
				}
				goto IL_0279;
				IL_01E0:
				if (registryKey3 != null)
				{
					goto IL_01E4;
				}
				goto IL_0187;
				IL_01D6:
				registryKey3 = classesRoot.CreateSubKey(progId);
				goto IL_01E0;
				IL_01C9:
				registryKey6.SetValue(string.Empty, progId);
				goto IL_01D6;
				IL_0227:
				if (registryKey6 == null)
				{
					break;
				}
				goto IL_01C9;
				IL_01A8:
				registryKey6 = classesRoot.CreateSubKey(extension);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					goto IL_0227;
				}
				goto IL_0279;
				IL_01E4:
				registryKey3.SetValue(Class15.smethod_17(676704898 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b), Class15.smethod_17(642124686 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_0227;
				}
				goto IL_0279;
			}
			IL_0315:
			classesRoot.Close();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000256A8 File Offset: 0x000238A8
		public static void RemoveFileAssociation(string extension, string progId)
		{
			for (;;)
			{
				IL_01B3:
				RegistryKey classesRoot = Registry.ClassesRoot;
				for (;;)
				{
					IL_01A6:
					RegistryKey registryKey = classesRoot.OpenSubKey(extension, true);
					for (;;)
					{
						if (registryKey == null)
						{
							goto IL_0043;
						}
						goto IL_018D;
						IL_0110:
						int num;
						RegistryKey registryKey2;
						switch (num)
						{
						case 0:
							goto IL_0098;
						case 1:
						case 15:
							goto IL_00FD;
						case 2:
							goto IL_016F;
						case 3:
						case 11:
							goto IL_000F;
						case 4:
						case 5:
							break;
						case 6:
							goto IL_004E;
						case 7:
							IL_018D:
							registryKey.DeleteValue(string.Empty, false);
							goto IL_016F;
						case 8:
							return;
						case 9:
							goto IL_00C7;
						case 10:
							goto IL_0069;
						case 12:
							goto IL_01A6;
						case 13:
							goto IL_01B3;
						case 14:
						case 19:
							IL_0043:
							registryKey2 = classesRoot.OpenSubKey(progId, true);
							goto IL_004E;
						case 16:
							goto IL_00E4;
						case 17:
							goto IL_0019;
						case 18:
							continue;
						case 20:
							goto IL_0006;
						default:
							goto IL_0098;
						}
						IL_0022:
						classesRoot.Close();
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
						{
							return;
						}
						goto IL_0110;
						IL_000F:
						if (classesRoot.SubKeyCount > 0)
						{
							goto IL_0019;
						}
						goto IL_0022;
						IL_0006:
						classesRoot.DeleteSubKey(progId, false);
						goto IL_000F;
						IL_00FD:
						if (classesRoot.SubKeyCount <= 0)
						{
							goto IL_000F;
						}
						goto IL_0006;
						IL_004E:
						if (registryKey2 == null)
						{
							num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
							{
								goto IL_0022;
							}
							goto IL_0110;
						}
						IL_0069:
						registryKey2.DeleteValue(Class15.smethod_17(82310174 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), false);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
						{
							goto IL_0110;
						}
						IL_0098:
						registryKey2.DeleteSubKeyTree(Class15.smethod_17(432116527 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2), false);
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
						{
							goto IL_00C7;
						}
						goto IL_0110;
						IL_00E4:
						registryKey2.Close();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto IL_00FD;
						}
						goto IL_0110;
						IL_00C7:
						registryKey2.DeleteSubKeyTree(Class15.smethod_17(1471355607 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e), false);
						goto IL_00E4;
						IL_016F:
						registryKey.Close();
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
						{
							goto IL_000F;
						}
						goto IL_0110;
						IL_0019:
						classesRoot.DeleteSubKey(extension, false);
						goto IL_0022;
					}
				}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00025874 File Offset: 0x00023A74
		public static void RefreshIconCache()
		{
			for (;;)
			{
				IL_0143:
				ShellHelper.SendMessageTimeout(IntPtr.Zero, 26, IntPtr.Zero, Class15.smethod_17(1570991327 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), 2U, 5000U, IntPtr.Zero);
				for (;;)
				{
					IL_0125:
					Process[] processesByName = Process.GetProcessesByName(Class15.smethod_17(1570991349 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
					for (;;)
					{
						int num = 0;
						int num2 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto IL_0006;
						}
						goto IL_00D7;
						do
						{
							IL_0023:
							processesByName[num].Kill();
							num2 = 8;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0);
						IL_00D7:
						switch (num2)
						{
						case 1:
						case 5:
							goto IL_0023;
						case 2:
							goto IL_0125;
						case 3:
							goto IL_0143;
						case 4:
							goto IL_004E;
						case 6:
							continue;
						case 7:
						case 10:
							goto IL_0006;
						case 8:
							num++;
							goto IL_0006;
						case 9:
							goto IL_0044;
						}
						return;
						IL_0006:
						if (num >= processesByName.Length)
						{
							goto IL_0044;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							goto IL_0023;
						}
						goto IL_00D7;
						IL_004E:
						Process.Start(new ProcessStartInfo
						{
							FileName = Environment.GetEnvironmentVariable(Class15.smethod_17(2008558065 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)) + Class15.smethod_17(1788744475 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c),
							Arguments = Class15.smethod_17(2008558019 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb),
							UseShellExecute = false
						});
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
						{
							return;
						}
						goto IL_00D7;
						IL_0044:
						Thread.Sleep(2000);
						goto IL_004E;
					}
				}
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000259FC File Offset: 0x00023BFC
		public ShellHelper()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
