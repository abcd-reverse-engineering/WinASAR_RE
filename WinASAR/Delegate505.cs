using System;

// Token: 0x02000409 RID: 1033
internal sealed class Delegate505 : MulticastDelegate
{
	// Token: 0x06001FB8 RID: 8120
	public extern object Invoke(object object_0, object object_1);

	// Token: 0x06001FB9 RID: 8121 RVA: 0x0000B3A1 File Offset: 0x000095A1
	public static object smethod_0(object object_0, object object_1, Delegate505 delegate505_1)
	{
		return delegate505_1(object_0, object_1);
	}

	// Token: 0x06001FBA RID: 8122
	public extern Delegate505(object object_0, IntPtr intptr_0);

	// Token: 0x06001FBB RID: 8123 RVA: 0x0000B3AE File Offset: 0x000095AE
	static Delegate505()
	{
		Class15.smethod_14(typeof(Delegate505).TypeHandle);
	}

	// Token: 0x04000BD9 RID: 3033
	internal static Delegate505 delegate505_0;
}
