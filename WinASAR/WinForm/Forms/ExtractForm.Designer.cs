namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000007 RID: 7
	public partial class ExtractForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00011D68 File Offset: 0x0000FF68
		protected override void Dispose(bool disposing)
		{
			for (;;)
			{
				if (disposing)
				{
					goto IL_0003;
				}
				goto IL_005F;
				int num;
				do
				{
					IL_001F:
					this.icontainer_0.Dispose();
					num = 2;
				}
				while (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0);
				IL_003E:
				switch (num)
				{
				case 0:
					goto IL_001F;
				case 1:
				case 2:
					break;
				case 3:
					return;
				case 4:
					IL_0003:
					if (this.icontainer_0 != null)
					{
						goto IL_001F;
					}
					num = 1;
					if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_003E;
					}
					break;
				case 5:
					continue;
				default:
					goto IL_001F;
				}
				IL_005F:
				base.Dispose(disposing);
				num = 1;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					break;
				}
				goto IL_003E;
			}
		}

		// Token: 0x0400002A RID: 42
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
