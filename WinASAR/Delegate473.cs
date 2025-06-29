using System;

// Token: 0x020003E9 RID: 1001
internal sealed class Delegate473 : MulticastDelegate
{
	// Token: 0x06001F38 RID: 7992
	public extern TimeZoneInfo Invoke();

	// Token: 0x06001F39 RID: 7993 RVA: 0x0000B069 File Offset: 0x00009269
	public static TimeZoneInfo smethod_0(Delegate473 delegate473_1)
	{
		return delegate473_1();
	}

	// Token: 0x06001F3A RID: 7994
	public extern Delegate473(object object_0, IntPtr intptr_0);

	// Token: 0x06001F3B RID: 7995 RVA: 0x0000B072 File Offset: 0x00009272
	static Delegate473()
	{
		Class15.smethod_14(typeof(Delegate473).TypeHandle);
	}

	// Token: 0x04000BB9 RID: 3001
	internal static Delegate473 delegate473_0;
}
