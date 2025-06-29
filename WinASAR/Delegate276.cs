using System;

// Token: 0x02000324 RID: 804
internal sealed class Delegate276 : MulticastDelegate
{
	// Token: 0x06001C24 RID: 7204
	public extern int Invoke(object object_0);

	// Token: 0x06001C25 RID: 7205 RVA: 0x00009C75 File Offset: 0x00007E75
	public static int smethod_0(object object_0, Delegate276 delegate276_1)
	{
		return delegate276_1(object_0);
	}

	// Token: 0x06001C26 RID: 7206
	public extern Delegate276(object object_0, IntPtr intptr_0);

	// Token: 0x06001C27 RID: 7207 RVA: 0x00009C80 File Offset: 0x00007E80
	static Delegate276()
	{
		Class15.smethod_14(typeof(Delegate276).TypeHandle);
	}

	// Token: 0x04000AF4 RID: 2804
	internal static Delegate276 delegate276_0;
}
