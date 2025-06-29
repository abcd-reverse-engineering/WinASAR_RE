using System;

// Token: 0x0200034A RID: 842
internal sealed class Delegate314 : MulticastDelegate
{
	// Token: 0x06001CBC RID: 7356
	public extern int Invoke();

	// Token: 0x06001CBD RID: 7357 RVA: 0x0000A045 File Offset: 0x00008245
	public static int smethod_0(Delegate314 delegate314_1)
	{
		return delegate314_1();
	}

	// Token: 0x06001CBE RID: 7358
	public extern Delegate314(object object_0, IntPtr intptr_0);

	// Token: 0x06001CBF RID: 7359 RVA: 0x0000A04E File Offset: 0x0000824E
	static Delegate314()
	{
		Class15.smethod_14(typeof(Delegate314).TypeHandle);
	}

	// Token: 0x04000B1A RID: 2842
	internal static Delegate314 delegate314_0;
}
