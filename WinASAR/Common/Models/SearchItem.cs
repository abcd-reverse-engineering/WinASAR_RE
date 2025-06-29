using System;
using System.Runtime.CompilerServices;

namespace WinASAR.Common.Models
{
	// Token: 0x02000023 RID: 35
	public class SearchItem
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00024568 File Offset: 0x00022768
		public SearchItem()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
			{
				goto IL_0035;
			}
			goto IL_0054;
			IL_001C:
			this.IsMatchCase = false;
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
			{
				goto IL_0054;
			}
			IL_0035:
			this.Keyword = string.Empty;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
			{
				goto IL_001C;
			}
			IL_0054:
			switch (num)
			{
			case 0:
				goto IL_0035;
			case 1:
				goto IL_001C;
			case 2:
				return;
			default:
				goto IL_0035;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000028AA File Offset: 0x00000AAA
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000245E0 File Offset: 0x000227E0
		public string Keyword
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000028B2 File Offset: 0x00000AB2
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00024618 File Offset: 0x00022818
		public bool IsMatchCase
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
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

		// Token: 0x04000120 RID: 288
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000121 RID: 289
		[CompilerGenerated]
		private bool bool_0;
	}
}
