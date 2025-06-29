namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000008 RID: 8
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0001967C File Offset: 0x0001787C
		protected override void Dispose(bool disposing)
		{
			for (;;)
			{
				if (!disposing)
				{
					goto IL_0044;
				}
				int num = 1;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 0:
					goto IL_0039;
				case 1:
					IL_0003:
					if (this.icontainer_0 != null)
					{
						num = 0;
						if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_001C;
						}
						goto IL_0039;
					}
					break;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					return;
				default:
					goto IL_0039;
				}
				IL_0044:
				base.Dispose(disposing);
				num = 1;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					break;
				}
				goto IL_001C;
				IL_0039:
				this.icontainer_0.Dispose();
				goto IL_0044;
			}
		}

		// Token: 0x0400003F RID: 63
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
