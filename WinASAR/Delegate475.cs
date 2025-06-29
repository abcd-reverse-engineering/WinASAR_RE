using System;

// Token: 0x020003EB RID: 1003
internal sealed class Delegate475 : MulticastDelegate
{
	// Token: 0x06001F40 RID: 8000
	public extern long Invoke(ref DateTime dateTime_0);

	// Token: 0x06001F41 RID: 8001 RVA: 0x0000B099 File Offset: 0x00009299
	public static long smethod_0(ref DateTime dateTime_0, Delegate475 delegate475_1)
	{
		return delegate475_1(ref dateTime_0);
	}

	// Token: 0x06001F42 RID: 8002
	public extern Delegate475(object object_0, IntPtr intptr_0);

	// Token: 0x06001F43 RID: 8003 RVA: 0x0000B0A4 File Offset: 0x000092A4
	static Delegate475()
	{
		Class15.smethod_14(typeof(Delegate475).TypeHandle);
	}

	// Token: 0x04000BBB RID: 3003
	internal static Delegate475 delegate475_0;
}
