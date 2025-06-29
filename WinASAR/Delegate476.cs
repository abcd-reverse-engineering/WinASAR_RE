using System;

// Token: 0x020003EC RID: 1004
internal sealed class Delegate476 : MulticastDelegate
{
	// Token: 0x06001F44 RID: 8004
	public extern DateTime Invoke(ref DateTime dateTime_0);

	// Token: 0x06001F45 RID: 8005 RVA: 0x0000B0B1 File Offset: 0x000092B1
	public static DateTime smethod_0(ref DateTime dateTime_0, Delegate476 delegate476_1)
	{
		return delegate476_1(ref dateTime_0);
	}

	// Token: 0x06001F46 RID: 8006
	public extern Delegate476(object object_0, IntPtr intptr_0);

	// Token: 0x06001F47 RID: 8007 RVA: 0x0000B0BC File Offset: 0x000092BC
	static Delegate476()
	{
		Class15.smethod_14(typeof(Delegate476).TypeHandle);
	}

	// Token: 0x04000BBC RID: 3004
	internal static Delegate476 delegate476_0;
}
