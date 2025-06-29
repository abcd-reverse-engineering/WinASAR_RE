using System;
using System.Runtime.CompilerServices;

namespace WinASAR.Common.Models
{
	// Token: 0x02000020 RID: 32
	public class Column
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00023FE4 File Offset: 0x000221E4
		public Column()
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
			{
				goto IL_0058;
			}
			do
			{
				IL_0039:
				this.Width = 200;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0);
			for (;;)
			{
				IL_0058:
				switch (num)
				{
				case 1:
					return;
				case 2:
					this.Name = string.Empty;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						continue;
					}
					break;
				}
				break;
			}
			goto IL_0039;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002841 File Offset: 0x00000A41
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00024060 File Offset: 0x00022260
		public string Name
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002849 File Offset: 0x00000A49
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00024098 File Offset: 0x00022298
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
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

		// Token: 0x0400010D RID: 269
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400010E RID: 270
		[CompilerGenerated]
		private int int_0;
	}
}
