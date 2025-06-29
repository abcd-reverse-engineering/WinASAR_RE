using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;
using WinASAR.WinForm.Forms;

namespace WinASAR.WinForm
{
	// Token: 0x02000002 RID: 2
	internal static class Program
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000EA34 File Offset: 0x0000CC34
		[STAThread]
		private static void Main(string[] args)
		{
			for (;;)
			{
				IL_010A:
				Class22.smethod_3();
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_00BD;
				}
				goto IL_00DA;
				do
				{
					IL_0006:
					Program.smethod_1(args);
					num = 9;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0);
				for (;;)
				{
					IL_00DA:
					switch (num)
					{
					case 1:
						goto IL_00BD;
					case 2:
						goto IL_0044;
					case 3:
						Application.EnableVisualStyles();
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto IL_00BD;
						}
						continue;
					case 4:
						goto IL_010A;
					case 5:
						goto IL_0039;
					case 6:
						goto IL_0023;
					case 7:
						goto IL_0006;
					case 8:
						return;
					case 9:
						return;
					}
					return;
				}
				IL_0023:
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_0039;
				}
				goto IL_00DA;
				IL_0044:
				Application.Run(new MainForm(Application.StartupPath));
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					break;
				}
				goto IL_00DA;
				IL_00BD:
				Application.SetCompatibleTextRenderingDefault(false);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0023;
				}
				goto IL_00DA;
				IL_0039:
				if (!Program.smethod_0())
				{
					goto IL_0006;
				}
				if (args.Length == 0)
				{
					goto IL_0044;
				}
				Application.Run(new MainForm(string.Join(Class15.smethod_17(1985312576 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba), args)));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					return;
				}
				goto IL_00DA;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000242B File Offset: 0x0000062B
		private static bool smethod_0()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		private static void smethod_1(string[] string_0)
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					UseShellExecute = true,
					WorkingDirectory = Environment.CurrentDirectory,
					FileName = Application.ExecutablePath,
					Arguments = string.Join(Class15.smethod_17(613120341 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), string_0),
					Verb = Class15.smethod_17(1243251896 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95)
				});
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					switch (num)
					{
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					switch (num2)
					{
					}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002441 File Offset: 0x00000641
		static Program()
		{
			Class22.smethod_3();
		}
	}
}
