namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000006 RID: 6
	public partial class CompressForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00010398 File Offset: 0x0000E598
		protected override void Dispose(bool disposing)
		{
			IL_0040:
			while (disposing)
			{
				while (this.icontainer_0 == null)
				{
					int num = 1;
					if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						goto IL_0054;
					}
					switch (num)
					{
					case 1:
					case 2:
					case 4:
						goto IL_0054;
					case 3:
						goto IL_0040;
					case 5:
						return;
					case 6:
						goto IL_0049;
					}
				}
				IL_0049:
				this.icontainer_0.Dispose();
				IL_0054:
				base.Dispose(disposing);
				return;
			}
			goto IL_0054;
		}

		// Token: 0x04000016 RID: 22
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
