using System;

// Token: 0x02000530 RID: 1328
internal sealed class Delegate800 : MulticastDelegate
{
	// Token: 0x06002454 RID: 9300
	public extern decimal Invoke(decimal decimal_0);

	// Token: 0x06002455 RID: 9301 RVA: 0x0000D0DC File Offset: 0x0000B2DC
	public static decimal smethod_0(decimal decimal_0, Delegate800 delegate800_1)
	{
		return delegate800_1(decimal_0);
	}

	// Token: 0x06002456 RID: 9302
	public extern Delegate800(object object_0, IntPtr intptr_0);

	// Token: 0x06002457 RID: 9303 RVA: 0x0000D0E7 File Offset: 0x0000B2E7
	static Delegate800()
	{
		Class15.smethod_14(typeof(Delegate800).TypeHandle);
	}

	// Token: 0x04000D00 RID: 3328
	internal static Delegate800 delegate800_0;
}
