using System;
using System.Drawing;

// Token: 0x0200032D RID: 813
internal sealed class Delegate285 : MulticastDelegate
{
	// Token: 0x06001C48 RID: 7240
	public extern Font Invoke(object object_0);

	// Token: 0x06001C49 RID: 7241 RVA: 0x00009D5D File Offset: 0x00007F5D
	public static Font smethod_0(object object_0, Delegate285 delegate285_1)
	{
		return delegate285_1(object_0);
	}

	// Token: 0x06001C4A RID: 7242
	public extern Delegate285(object object_0, IntPtr intptr_0);

	// Token: 0x06001C4B RID: 7243 RVA: 0x00009D68 File Offset: 0x00007F68
	static Delegate285()
	{
		Class15.smethod_14(typeof(Delegate285).TypeHandle);
	}

	// Token: 0x04000AFD RID: 2813
	internal static Delegate285 delegate285_0;
}
