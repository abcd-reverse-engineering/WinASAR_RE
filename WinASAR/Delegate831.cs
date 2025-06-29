using System;

// Token: 0x0200054F RID: 1359
internal sealed class Delegate831 : MulticastDelegate
{
	// Token: 0x060024D0 RID: 9424
	public extern string Invoke(object object_0);

	// Token: 0x060024D1 RID: 9425 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
	public static string smethod_0(object object_0, Delegate831 delegate831_1)
	{
		return delegate831_1(object_0);
	}

	// Token: 0x060024D2 RID: 9426
	public extern Delegate831(object object_0, IntPtr intptr_0);

	// Token: 0x060024D3 RID: 9427 RVA: 0x0000D3FF File Offset: 0x0000B5FF
	static Delegate831()
	{
		Class15.smethod_14(typeof(Delegate831).TypeHandle);
	}

	// Token: 0x04000D1F RID: 3359
	internal static Delegate831 delegate831_0;
}
