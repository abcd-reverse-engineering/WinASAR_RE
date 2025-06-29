using System;
using System.Drawing;

// Token: 0x0200032E RID: 814
internal sealed class Delegate286 : MulticastDelegate
{
	// Token: 0x06001C4C RID: 7244
	public extern Color Invoke();

	// Token: 0x06001C4D RID: 7245 RVA: 0x00009D75 File Offset: 0x00007F75
	public static Color smethod_0(Delegate286 delegate286_1)
	{
		return delegate286_1();
	}

	// Token: 0x06001C4E RID: 7246
	public extern Delegate286(object object_0, IntPtr intptr_0);

	// Token: 0x06001C4F RID: 7247 RVA: 0x00009D7E File Offset: 0x00007F7E
	static Delegate286()
	{
		Class15.smethod_14(typeof(Delegate286).TypeHandle);
	}

	// Token: 0x04000AFE RID: 2814
	internal static Delegate286 delegate286_0;
}
