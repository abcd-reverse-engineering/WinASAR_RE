using System;

// Token: 0x02000228 RID: 552
internal sealed class Delegate24 : MulticastDelegate
{
	// Token: 0x06001834 RID: 6196
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001835 RID: 6197 RVA: 0x000083AB File Offset: 0x000065AB
	public static void smethod_0(object object_0, bool bool_0, Delegate24 delegate24_1)
	{
		delegate24_1(object_0, bool_0);
	}

	// Token: 0x06001836 RID: 6198
	public extern Delegate24(object object_0, IntPtr intptr_0);

	// Token: 0x06001837 RID: 6199 RVA: 0x000083B8 File Offset: 0x000065B8
	static Delegate24()
	{
		Class15.smethod_14(typeof(Delegate24).TypeHandle);
	}

	// Token: 0x040009F8 RID: 2552
	internal static Delegate24 delegate24_0;
}
