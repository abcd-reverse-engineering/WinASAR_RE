using System;
using System.Runtime.CompilerServices;

namespace WinASAR.ArchiveLib.ASAR
{
	// Token: 0x02000019 RID: 25
	public class AsarFile
	{
		// Token: 0x06000110 RID: 272 RVA: 0x000231D8 File Offset: 0x000213D8
		public AsarFile()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
			{
				goto IL_00C2;
			}
			goto IL_00D2;
			IL_0022:
			this.Offset = -1L;
			num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
			{
				return;
			}
			goto IL_00D2;
			IL_004B:
			this.Path = string.Empty;
			IL_0056:
			this.Name = string.Empty;
			IL_0061:
			this.IsDirectory = false;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
			{
				goto IL_00D2;
			}
			IL_007A:
			this.BaseOffset = null;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				goto IL_00D2;
			}
			IL_009C:
			this.Size = -1L;
			num = 6;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
			{
				goto IL_0022;
			}
			goto IL_00D2;
			IL_00C2:
			this.FullPath = string.Empty;
			goto IL_004B;
			IL_00D2:
			switch (num)
			{
			case 0:
				goto IL_007A;
			case 1:
				goto IL_00C2;
			case 2:
				goto IL_009C;
			case 3:
				goto IL_0056;
			case 4:
				goto IL_0061;
			case 5:
				goto IL_004B;
			case 6:
				goto IL_0022;
			case 7:
				break;
			default:
				goto IL_007A;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002766 File Offset: 0x00000966
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000232E0 File Offset: 0x000214E0
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000276E File Offset: 0x0000096E
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00023318 File Offset: 0x00021518
		public string Path
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002776 File Offset: 0x00000976
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00023350 File Offset: 0x00021550
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000277E File Offset: 0x0000097E
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00023388 File Offset: 0x00021588
		public bool IsDirectory
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002786 File Offset: 0x00000986
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000278E File Offset: 0x0000098E
		public long? BaseOffset { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002797 File Offset: 0x00000997
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000233C0 File Offset: 0x000215C0
		public long Size
		{
			[CompilerGenerated]
			get
			{
				return this.long_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.long_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000279F File Offset: 0x0000099F
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000233F8 File Offset: 0x000215F8
		public long Offset
		{
			[CompilerGenerated]
			get
			{
				return this.long_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.long_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
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

		// Token: 0x040000EE RID: 238
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040000F1 RID: 241
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040000F2 RID: 242
		[CompilerGenerated]
		private long? nullable_0;

		// Token: 0x040000F3 RID: 243
		[CompilerGenerated]
		private long long_0;

		// Token: 0x040000F4 RID: 244
		[CompilerGenerated]
		private long long_1;
	}
}
