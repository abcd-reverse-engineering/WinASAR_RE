using System;

// Token: 0x020003C7 RID: 967
internal sealed class Delegate439 : MulticastDelegate
{
	// Token: 0x06001EB0 RID: 7856
	public extern void Invoke(object object_0, int int_0, object object_1);

	// Token: 0x06001EB1 RID: 7857 RVA: 0x0000ACF5 File Offset: 0x00008EF5
	public static void smethod_0(object object_0, int int_0, object object_1, Delegate439 delegate439_1)
	{
		delegate439_1(object_0, int_0, object_1);
	}

	// Token: 0x06001EB2 RID: 7858
	public extern Delegate439(object object_0, IntPtr intptr_0);

	// Token: 0x06001EB3 RID: 7859 RVA: 0x0000AD04 File Offset: 0x00008F04
	static Delegate439()
	{
		Class15.smethod_14(typeof(Delegate439).TypeHandle);
	}

	// Token: 0x04000B97 RID: 2967
	internal static Delegate439 delegate439_0;
}
