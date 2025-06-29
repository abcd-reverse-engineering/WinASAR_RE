using System;

// Token: 0x020003A7 RID: 935
internal sealed class Delegate407 : MulticastDelegate
{
	// Token: 0x06001E30 RID: 7728
	public extern bool Invoke(ref double double_0, double double_1);

	// Token: 0x06001E31 RID: 7729 RVA: 0x0000A9B9 File Offset: 0x00008BB9
	public static bool smethod_0(ref double double_0, double double_1, Delegate407 delegate407_1)
	{
		return delegate407_1(ref double_0, double_1);
	}

	// Token: 0x06001E32 RID: 7730
	public extern Delegate407(object object_0, IntPtr intptr_0);

	// Token: 0x06001E33 RID: 7731 RVA: 0x0000A9C6 File Offset: 0x00008BC6
	static Delegate407()
	{
		Class15.smethod_14(typeof(Delegate407).TypeHandle);
	}

	// Token: 0x04000B77 RID: 2935
	internal static Delegate407 delegate407_0;
}
