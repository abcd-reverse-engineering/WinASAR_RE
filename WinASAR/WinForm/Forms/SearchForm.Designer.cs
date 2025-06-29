namespace WinASAR.WinForm.Forms
{
	// Token: 0x0200000B RID: 11
	public partial class SearchForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0001E848 File Offset: 0x0001CA48
		protected override void Dispose(bool disposing)
		{
			for (;;)
			{
				int num;
				if (disposing)
				{
					num = 0;
					if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto IL_0025;
					}
					goto IL_0041;
				}
				do
				{
					IL_005E:
					base.Dispose(disposing);
					num = 3;
				}
				while (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0);
				IL_0041:
				switch (num)
				{
				case 0:
					goto IL_0025;
				case 1:
					continue;
				case 2:
					goto IL_005E;
				case 3:
					return;
				case 4:
					break;
				default:
					goto IL_0025;
				}
				IL_0006:
				this.icontainer_0.Dispose();
				num = 2;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_005E;
				}
				goto IL_0041;
				IL_0025:
				if (this.icontainer_0 == null)
				{
					goto IL_005E;
				}
				num = 1;
				if (global::<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_0006;
				}
				goto IL_0041;
			}
		}

		// Token: 0x040000B0 RID: 176
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
