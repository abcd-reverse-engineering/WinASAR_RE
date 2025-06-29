using System;

// Token: 0x0200027E RID: 638
internal sealed class Delegate110 : MulticastDelegate
{
	// Token: 0x0600198C RID: 6540
	public extern string Invoke(object object_0);

	// Token: 0x0600198D RID: 6541 RVA: 0x00008C29 File Offset: 0x00006E29
	public static string smethod_0(object object_0, Delegate110 delegate110_1)
	{
		return delegate110_1(object_0);
	}

	// Token: 0x0600198E RID: 6542
	public extern Delegate110(object object_0, IntPtr intptr_0);

	// Token: 0x0600198F RID: 6543 RVA: 0x00008C34 File Offset: 0x00006E34
	static Delegate110()
	{
		Class15.smethod_14(typeof(Delegate110).TypeHandle);
	}

	// Token: 0x04000A4E RID: 2638
	internal static Delegate110 delegate110_0;
}
