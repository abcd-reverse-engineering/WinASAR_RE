using System;
using System.Runtime.CompilerServices;

namespace WinASAR.Common.Models
{
	// Token: 0x0200001F RID: 31
	public class ArchiveInfo
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00023EB8 File Offset: 0x000220B8
		public ArchiveInfo()
		{
			for (;;)
			{
				this.FullPath = string.Empty;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_000A;
				}
				IL_003F:
				switch (num)
				{
				case 1:
					IL_000A:
					this.RelativePath = string.Empty;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_003F;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				this.IsAsarFile = false;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_003F;
				}
				break;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002829 File Offset: 0x00000A29
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00023F3C File Offset: 0x0002213C
		public string FullPath
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
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
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002831 File Offset: 0x00000A31
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00023F74 File Offset: 0x00022174
		public string RelativePath
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
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
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002839 File Offset: 0x00000A39
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00023FAC File Offset: 0x000221AC
		public bool IsAsarFile
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
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
		}

		// Token: 0x04000109 RID: 265
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400010A RID: 266
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400010B RID: 267
		[CompilerGenerated]
		private bool bool_0;
	}
}
