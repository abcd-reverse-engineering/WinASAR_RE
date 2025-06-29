namespace WinASAR.WinForm.Forms
{
	// Token: 0x0200000D RID: 13
	public partial class SettingForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CD RID: 205 RVA: 0x0001F814 File Offset: 0x0001DA14
		protected override void Dispose(bool disposing)
		{
			for (;;)
			{
				if (disposing)
				{
					goto IL_0022;
				}
				goto IL_004A;
				IL_002D:
				int num;
				switch (num)
				{
				case 0:
					goto IL_004A;
				case 1:
					return;
				case 2:
					IL_0022:
					if (this.icontainer_0 == null)
					{
						goto IL_004A;
					}
					break;
				case 3:
					continue;
				case 4:
					break;
				default:
					goto IL_004A;
				}
				this.icontainer_0.Dispose();
				num = 0;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_002D;
				}
				IL_004A:
				base.Dispose(disposing);
				num = 1;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
				{
					break;
				}
				goto IL_002D;
			}
		}

		// Token: 0x040000B8 RID: 184
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
