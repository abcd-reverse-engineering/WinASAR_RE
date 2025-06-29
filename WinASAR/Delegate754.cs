using System;

// Token: 0x02000502 RID: 1282
internal sealed class Delegate754 : MulticastDelegate
{
	// Token: 0x0600239C RID: 9116
	public extern bool Invoke(object object_0);

	// Token: 0x0600239D RID: 9117 RVA: 0x0000CC5A File Offset: 0x0000AE5A
	public static bool smethod_0(object object_0, Delegate754 delegate754_1)
	{
		return delegate754_1(object_0);
	}

	// Token: 0x0600239E RID: 9118
	public extern Delegate754(object object_0, IntPtr intptr_0);

	// Token: 0x0600239F RID: 9119 RVA: 0x0000CC65 File Offset: 0x0000AE65
	static Delegate754()
	{
		Class15.smethod_14(typeof(Delegate754).TypeHandle);
	}

	// Token: 0x04000CD2 RID: 3282
	internal static Delegate754 delegate754_0;
}
