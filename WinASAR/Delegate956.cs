using System;

// Token: 0x020005CC RID: 1484
internal sealed class Delegate956 : MulticastDelegate
{
	// Token: 0x060026C4 RID: 9924
	public extern void Invoke(object object_0, byte byte_0);

	// Token: 0x060026C5 RID: 9925 RVA: 0x0000E032 File Offset: 0x0000C232
	public static void smethod_0(object object_0, byte byte_0, Delegate956 delegate956_1)
	{
		delegate956_1(object_0, byte_0);
	}

	// Token: 0x060026C6 RID: 9926
	public extern Delegate956(object object_0, IntPtr intptr_0);

	// Token: 0x060026C7 RID: 9927 RVA: 0x0000E03F File Offset: 0x0000C23F
	static Delegate956()
	{
		Class15.smethod_14(typeof(Delegate956).TypeHandle);
	}

	// Token: 0x04000D9C RID: 3484
	internal static Delegate956 delegate956_0;
}
