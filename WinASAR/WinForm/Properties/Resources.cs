using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WinASAR.WinForm.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000EC38 File Offset: 0x0000CE38
		internal Resources()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				IL_005A:
				while (Resources.resourceManager_0 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							Resources.resourceManager_0 = new ResourceManager("WinASAR.WinForm.Properties.Resources", typeof(Resources).Assembly);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_005A;
						}
						break;
					}
					break;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002449 File Offset: 0x00000649
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002450 File Offset: 0x00000650
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002458 File Offset: 0x00000658
		internal static Bitmap AppIcon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(1471363487 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002483 File Offset: 0x00000683
		internal static Bitmap Background
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(1807888542 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000024AE File Offset: 0x000006AE
		internal static Bitmap Compress
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(486529864 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000024D9 File Offset: 0x000006D9
		internal static Bitmap Delete
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(635810097 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002504 File Offset: 0x00000704
		internal static Bitmap DriverGray
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(314771583 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000252F File Offset: 0x0000072F
		internal static Bitmap DriverGreen
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(642132216 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000255A File Offset: 0x0000075A
		internal static Bitmap Extract
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(2060610932 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177), Resources.cultureInfo_0);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002585 File Offset: 0x00000785
		internal static Bitmap Folder
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(1396558142 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7), Resources.cultureInfo_0);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000025B0 File Offset: 0x000007B0
		internal static Bitmap GoBack
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(2021172498 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), Resources.cultureInfo_0);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000025DB File Offset: 0x000007DB
		internal static Bitmap Info
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(1116166233 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54), Resources.cultureInfo_0);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002606 File Offset: 0x00000806
		internal static Bitmap Search
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(1270982674 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112), Resources.cultureInfo_0);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002631 File Offset: 0x00000831
		internal static Bitmap Tester
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(1829605977 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae), Resources.cultureInfo_0);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000265C File Offset: 0x0000085C
		internal static Bitmap Viewer
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject(Class15.smethod_17(926376205 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), Resources.cultureInfo_0);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002687 File Offset: 0x00000887
		internal static Icon WinASAR
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject(Class15.smethod_17(2021172390 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), Resources.cultureInfo_0);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026B2 File Offset: 0x000008B2
		static Resources()
		{
			Class22.smethod_3();
		}

		// Token: 0x04000002 RID: 2
		private static ResourceManager resourceManager_0;

		// Token: 0x04000003 RID: 3
		private static CultureInfo cultureInfo_0;
	}
}
