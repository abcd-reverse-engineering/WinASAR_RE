using System;

// Token: 0x02000240 RID: 576
internal sealed class Delegate48 : MulticastDelegate
{
	// Token: 0x06001894 RID: 6292
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001895 RID: 6293 RVA: 0x00008601 File Offset: 0x00006801
	public static void smethod_0(object object_0, int int_0, Delegate48 delegate48_1)
	{
		delegate48_1(object_0, int_0);
	}

	// Token: 0x06001896 RID: 6294
	public extern Delegate48(object object_0, IntPtr intptr_0);

	// Token: 0x06001897 RID: 6295 RVA: 0x0000860E File Offset: 0x0000680E
	static Delegate48()
	{
		Class15.smethod_14(typeof(Delegate48).TypeHandle);
	}

	// Token: 0x04000A10 RID: 2576
	internal static Delegate48 delegate48_0;
}
