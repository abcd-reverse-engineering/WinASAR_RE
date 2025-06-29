using System;

// Token: 0x02000365 RID: 869
internal sealed class Delegate341 : MulticastDelegate
{
	// Token: 0x06001D28 RID: 7464
	public extern int Invoke(object object_0, char[] char_0);

	// Token: 0x06001D29 RID: 7465 RVA: 0x0000A30B File Offset: 0x0000850B
	public static int smethod_0(object object_0, char[] char_0, Delegate341 delegate341_1)
	{
		return delegate341_1(object_0, char_0);
	}

	// Token: 0x06001D2A RID: 7466
	public extern Delegate341(object object_0, IntPtr intptr_0);

	// Token: 0x06001D2B RID: 7467 RVA: 0x0000A318 File Offset: 0x00008518
	static Delegate341()
	{
		Class15.smethod_14(typeof(Delegate341).TypeHandle);
	}

	// Token: 0x04000B35 RID: 2869
	internal static Delegate341 delegate341_0;
}
