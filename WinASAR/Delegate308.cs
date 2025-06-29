using System;

// Token: 0x02000344 RID: 836
internal sealed class Delegate308 : MulticastDelegate
{
	// Token: 0x06001CA4 RID: 7332
	public extern int Invoke(object object_0);

	// Token: 0x06001CA5 RID: 7333 RVA: 0x00009FB1 File Offset: 0x000081B1
	public static int smethod_0(object object_0, Delegate308 delegate308_1)
	{
		return delegate308_1(object_0);
	}

	// Token: 0x06001CA6 RID: 7334
	public extern Delegate308(object object_0, IntPtr intptr_0);

	// Token: 0x06001CA7 RID: 7335 RVA: 0x00009FBC File Offset: 0x000081BC
	static Delegate308()
	{
		Class15.smethod_14(typeof(Delegate308).TypeHandle);
	}

	// Token: 0x04000B14 RID: 2836
	internal static Delegate308 delegate308_0;
}
