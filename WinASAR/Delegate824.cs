using System;

// Token: 0x02000548 RID: 1352
internal sealed class Delegate824 : MulticastDelegate
{
	// Token: 0x060024B4 RID: 9396
	public extern string Invoke(object object_0);

	// Token: 0x060024B5 RID: 9397 RVA: 0x0000D346 File Offset: 0x0000B546
	public static string smethod_0(object object_0, Delegate824 delegate824_1)
	{
		return delegate824_1(object_0);
	}

	// Token: 0x060024B6 RID: 9398
	public extern Delegate824(object object_0, IntPtr intptr_0);

	// Token: 0x060024B7 RID: 9399 RVA: 0x0000D351 File Offset: 0x0000B551
	static Delegate824()
	{
		Class15.smethod_14(typeof(Delegate824).TypeHandle);
	}

	// Token: 0x04000D18 RID: 3352
	internal static Delegate824 delegate824_0;
}
