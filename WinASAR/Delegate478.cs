using System;

// Token: 0x020003EE RID: 1006
internal sealed class Delegate478 : MulticastDelegate
{
	// Token: 0x06001F4C RID: 8012
	public extern bool Invoke(DateTime dateTime_0, DateTime dateTime_1);

	// Token: 0x06001F4D RID: 8013 RVA: 0x0000B0E1 File Offset: 0x000092E1
	public static bool smethod_0(DateTime dateTime_0, DateTime dateTime_1, Delegate478 delegate478_1)
	{
		return delegate478_1(dateTime_0, dateTime_1);
	}

	// Token: 0x06001F4E RID: 8014
	public extern Delegate478(object object_0, IntPtr intptr_0);

	// Token: 0x06001F4F RID: 8015 RVA: 0x0000B0EE File Offset: 0x000092EE
	static Delegate478()
	{
		Class15.smethod_14(typeof(Delegate478).TypeHandle);
	}

	// Token: 0x04000BBE RID: 3006
	internal static Delegate478 delegate478_0;
}
