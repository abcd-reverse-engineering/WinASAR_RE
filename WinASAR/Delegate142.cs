using System;

// Token: 0x0200029E RID: 670
internal sealed class Delegate142 : MulticastDelegate
{
	// Token: 0x06001A0C RID: 6668
	public extern object Invoke(object object_0);

	// Token: 0x06001A0D RID: 6669 RVA: 0x00008F3D File Offset: 0x0000713D
	public static object smethod_0(object object_0, Delegate142 delegate142_1)
	{
		return delegate142_1(object_0);
	}

	// Token: 0x06001A0E RID: 6670
	public extern Delegate142(object object_0, IntPtr intptr_0);

	// Token: 0x06001A0F RID: 6671 RVA: 0x00008F48 File Offset: 0x00007148
	static Delegate142()
	{
		Class15.smethod_14(typeof(Delegate142).TypeHandle);
	}

	// Token: 0x04000A6E RID: 2670
	internal static Delegate142 delegate142_0;
}
