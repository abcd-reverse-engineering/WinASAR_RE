using System;
using System.Runtime.CompilerServices;

namespace WinASAR.ArchiveLib.ASAR
{
	// Token: 0x0200001A RID: 26
	public class ItemFilter
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00023430 File Offset: 0x00021630
		public ItemFilter()
		{
			for (;;)
			{
				this.FullPath = string.Empty;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					goto IL_000A;
				}
				IL_0026:
				switch (num)
				{
				case 1:
					IL_000A:
					this.Path = string.Empty;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_0026;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000027A7 File Offset: 0x000009A7
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00023498 File Offset: 0x00021698
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000027AF File Offset: 0x000009AF
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000234D0 File Offset: 0x000216D0
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

		// Token: 0x040000F6 RID: 246
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000F7 RID: 247
		[CompilerGenerated]
		private string string_1;
	}
}
