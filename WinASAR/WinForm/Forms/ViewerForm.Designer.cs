namespace WinASAR.WinForm.Forms
{
	// Token: 0x0200000F RID: 15
	public partial class ViewerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x0002143C File Offset: 0x0001F63C
		protected override void Dispose(bool disposing)
		{
			while (disposing)
			{
				int num = 3;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_0015;
				}
				IL_004D:
				switch (num)
				{
				case 0:
				case 1:
					goto IL_0077;
				case 2:
					break;
				case 3:
					IL_0015:
					if (this.icontainer_0 == null)
					{
						num = 0;
						if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_0077;
						}
						goto IL_004D;
					}
					break;
				case 4:
					continue;
				case 5:
					return;
				default:
					goto IL_0077;
				}
				this.icontainer_0.Dispose();
				num = 0;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_004D;
				}
				break;
			}
			IL_0077:
			base.Dispose(disposing);
		}

		// Token: 0x040000C7 RID: 199
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
