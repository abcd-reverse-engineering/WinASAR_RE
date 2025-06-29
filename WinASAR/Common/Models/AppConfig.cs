using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WinASAR.Common.Models
{
	// Token: 0x0200001E RID: 30
	public class AppConfig
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00023A6C File Offset: 0x00021C6C
		public AppConfig()
		{
			for (;;)
			{
				IL_0221:
				this.Width = 850;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_000D;
				}
				for (;;)
				{
					IL_01C9:
					switch (num)
					{
					case 1:
						goto IL_00F9;
					case 2:
						goto IL_0050;
					case 3:
						goto IL_0174;
					case 4:
						this.SortColumn = 0;
						goto IL_01A5;
					case 5:
						goto IL_0128;
					case 6:
						goto IL_0155;
					case 7:
						goto IL_01A5;
					case 8:
						goto IL_0034;
					case 9:
						goto IL_0018;
					case 10:
						goto IL_0183;
					case 11:
						goto IL_0221;
					case 12:
						goto IL_003B;
					case 13:
						goto IL_0042;
					case 14:
						goto IL_0049;
					case 15:
						goto IL_0088;
					case 16:
						goto IL_00D7;
					case 17:
						goto IL_005B;
					case 18:
						goto IL_00AA;
					case 19:
						goto IL_000D;
					}
					return;
					IL_0183:
					this.AppWizardKeys = new List<string>();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						return;
					}
					continue;
					IL_01A5:
					this.SortOrder = 1;
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_0183;
					}
				}
				IL_0018:
				this.IsAssociationASAR = true;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_0034;
				}
				goto IL_01C9;
				IL_000D:
				this.Height = 600;
				goto IL_0018;
				IL_0088:
				Column column;
				this.DisplayColumns.Add(column);
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					goto IL_00AA;
				}
				goto IL_01C9;
				IL_005B:
				column = new Column
				{
					Name = Class15.smethod_17(1788754649 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c),
					Width = 300
				};
				goto IL_0088;
				IL_0050:
				this.DisplayColumns = new List<Column>();
				goto IL_005B;
				IL_0049:
				this.FileViewType = 0;
				goto IL_0050;
				IL_0042:
				this.OverwriteType = 0;
				goto IL_0049;
				IL_003B:
				this.IsExtractAsk = true;
				goto IL_0042;
				IL_0034:
				this.IsCreateShortcuts = true;
				goto IL_003B;
				IL_00D7:
				this.DisplayColumns.Add(column);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_00F9;
				}
				goto IL_01C9;
				IL_00AA:
				column = new Column
				{
					Name = Class15.smethod_17(974449497 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f),
					Width = 150
				};
				goto IL_00D7;
				IL_0155:
				this.DisplayColumns.Add(column);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0174;
				}
				goto IL_01C9;
				IL_0128:
				column = new Column
				{
					Name = Class15.smethod_17(2071399530 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808),
					Width = 160
				};
				goto IL_0155;
				IL_0174:
				this.DisplayColumns.Add(column);
				goto IL_0128;
				IL_00F9:
				column = new Column
				{
					Name = Class15.smethod_17(594363118 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b),
					Width = 150
				};
				goto IL_0174;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000027BF File Offset: 0x000009BF
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00023CC0 File Offset: 0x00021EC0
		public int Width
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000027C7 File Offset: 0x000009C7
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00023CF8 File Offset: 0x00021EF8
		public int Height
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000027CF File Offset: 0x000009CF
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00023D30 File Offset: 0x00021F30
		public bool IsAssociationASAR
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000027D7 File Offset: 0x000009D7
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00023D68 File Offset: 0x00021F68
		public bool IsCreateShortcuts
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000027DF File Offset: 0x000009DF
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00023DA0 File Offset: 0x00021FA0
		public bool IsExtractAsk
		{
			[CompilerGenerated]
			get
			{
				return this.bool_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000027E7 File Offset: 0x000009E7
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00023DD8 File Offset: 0x00021FD8
		public int OverwriteType
		{
			[CompilerGenerated]
			get
			{
				return this.int_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000027EF File Offset: 0x000009EF
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00023E10 File Offset: 0x00022010
		public int FileViewType
		{
			[CompilerGenerated]
			get
			{
				return this.int_3;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_3 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000027F7 File Offset: 0x000009F7
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000027FF File Offset: 0x000009FF
		public List<Column> DisplayColumns { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00023E48 File Offset: 0x00022048
		public int SortColumn
		{
			[CompilerGenerated]
			get
			{
				return this.int_4;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_4 = value;
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002810 File Offset: 0x00000A10
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00023E80 File Offset: 0x00022080
		public int SortOrder
		{
			[CompilerGenerated]
			get
			{
				return this.int_5;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_5 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002818 File Offset: 0x00000A18
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002820 File Offset: 0x00000A20
		public List<string> AppWizardKeys { get; set; }

		// Token: 0x040000FD RID: 253
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040000FF RID: 255
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000100 RID: 256
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000101 RID: 257
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000102 RID: 258
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04000103 RID: 259
		[CompilerGenerated]
		private int int_3;

		// Token: 0x04000104 RID: 260
		[CompilerGenerated]
		private List<Column> list_0;

		// Token: 0x04000105 RID: 261
		[CompilerGenerated]
		private int int_4;

		// Token: 0x04000106 RID: 262
		[CompilerGenerated]
		private int int_5;

		// Token: 0x04000107 RID: 263
		[CompilerGenerated]
		private List<string> list_1;
	}
}
