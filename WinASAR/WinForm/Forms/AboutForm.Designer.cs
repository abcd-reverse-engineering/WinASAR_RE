namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000005 RID: 5
	public partial class AboutForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		protected override void Dispose(bool disposing)
		{
			IL_0050:
			while (disposing)
			{
				int num = 1;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (this.icontainer_0 != null)
						{
							goto IL_005C;
						}
						num = 0;
						if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0050;
					case 3:
						goto IL_005C;
					case 5:
						return;
					}
					break;
				}
				break;
				IL_005C:
				this.icontainer_0.Dispose();
				break;
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
