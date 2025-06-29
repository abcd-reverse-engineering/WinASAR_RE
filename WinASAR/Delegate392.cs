using System;

// Token: 0x02000398 RID: 920
internal sealed class Delegate392 : MulticastDelegate
{
	// Token: 0x06001DF4 RID: 7668
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001DF5 RID: 7669 RVA: 0x0000A835 File Offset: 0x00008A35
	public static void smethod_0(object object_0, string string_0, Delegate392 delegate392_1)
	{
		delegate392_1(object_0, string_0);
	}

	// Token: 0x06001DF6 RID: 7670
	public extern Delegate392(object object_0, IntPtr intptr_0);

	// Token: 0x06001DF7 RID: 7671 RVA: 0x0000A842 File Offset: 0x00008A42
	static Delegate392()
	{
		Class15.smethod_14(typeof(Delegate392).TypeHandle);
	}

	// Token: 0x04000B68 RID: 2920
	internal static Delegate392 delegate392_0;
}
