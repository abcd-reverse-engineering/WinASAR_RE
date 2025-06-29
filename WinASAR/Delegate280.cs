using System;
using System.Drawing;

// Token: 0x02000328 RID: 808
internal sealed class Delegate280 : MulticastDelegate
{
	// Token: 0x06001C34 RID: 7220
	public extern Font Invoke(object object_0);

	// Token: 0x06001C35 RID: 7221 RVA: 0x00009CDD File Offset: 0x00007EDD
	public static Font smethod_0(object object_0, Delegate280 delegate280_1)
	{
		return delegate280_1(object_0);
	}

	// Token: 0x06001C36 RID: 7222
	public extern Delegate280(object object_0, IntPtr intptr_0);

	// Token: 0x06001C37 RID: 7223 RVA: 0x00009CE8 File Offset: 0x00007EE8
	static Delegate280()
	{
		Class15.smethod_14(typeof(Delegate280).TypeHandle);
	}

	// Token: 0x04000AF8 RID: 2808
	internal static Delegate280 delegate280_0;
}
