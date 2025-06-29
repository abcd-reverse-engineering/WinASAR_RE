using System;

// Token: 0x020003C1 RID: 961
internal sealed class Delegate433 : MulticastDelegate
{
	// Token: 0x06001E98 RID: 7832
	public extern void Invoke(object object_0, Array array_0, int int_0);

	// Token: 0x06001E99 RID: 7833 RVA: 0x0000AC5B File Offset: 0x00008E5B
	public static void smethod_0(object object_0, Array array_0, int int_0, Delegate433 delegate433_1)
	{
		delegate433_1(object_0, array_0, int_0);
	}

	// Token: 0x06001E9A RID: 7834
	public extern Delegate433(object object_0, IntPtr intptr_0);

	// Token: 0x06001E9B RID: 7835 RVA: 0x0000AC6A File Offset: 0x00008E6A
	static Delegate433()
	{
		Class15.smethod_14(typeof(Delegate433).TypeHandle);
	}

	// Token: 0x04000B91 RID: 2961
	internal static Delegate433 delegate433_0;
}
