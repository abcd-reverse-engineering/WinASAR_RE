using System;

// Token: 0x02000242 RID: 578
internal sealed class Delegate50 : MulticastDelegate
{
	// Token: 0x0600189C RID: 6300
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x0600189D RID: 6301 RVA: 0x00008635 File Offset: 0x00006835
	public static void smethod_0(object object_0, bool bool_0, Delegate50 delegate50_1)
	{
		delegate50_1(object_0, bool_0);
	}

	// Token: 0x0600189E RID: 6302
	public extern Delegate50(object object_0, IntPtr intptr_0);

	// Token: 0x0600189F RID: 6303 RVA: 0x00008642 File Offset: 0x00006842
	static Delegate50()
	{
		Class15.smethod_14(typeof(Delegate50).TypeHandle);
	}

	// Token: 0x04000A12 RID: 2578
	internal static Delegate50 delegate50_0;
}
