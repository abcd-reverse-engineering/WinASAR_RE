using System;

// Token: 0x02000401 RID: 1025
internal sealed class Delegate497 : MulticastDelegate
{
	// Token: 0x06001F98 RID: 8088
	public extern int Invoke(ref DateTime dateTime_0);

	// Token: 0x06001F99 RID: 8089 RVA: 0x0000B2D9 File Offset: 0x000094D9
	public static int smethod_0(ref DateTime dateTime_0, Delegate497 delegate497_1)
	{
		return delegate497_1(ref dateTime_0);
	}

	// Token: 0x06001F9A RID: 8090
	public extern Delegate497(object object_0, IntPtr intptr_0);

	// Token: 0x06001F9B RID: 8091 RVA: 0x0000B2E4 File Offset: 0x000094E4
	static Delegate497()
	{
		Class15.smethod_14(typeof(Delegate497).TypeHandle);
	}

	// Token: 0x04000BD1 RID: 3025
	internal static Delegate497 delegate497_0;
}
