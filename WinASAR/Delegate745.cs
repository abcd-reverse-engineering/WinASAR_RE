using System;

// Token: 0x020004F9 RID: 1273
internal sealed class Delegate745 : MulticastDelegate
{
	// Token: 0x06002378 RID: 9080
	public extern string Invoke(object object_0, object object_1);

	// Token: 0x06002379 RID: 9081 RVA: 0x0000CB76 File Offset: 0x0000AD76
	public static string smethod_0(object object_0, object object_1, Delegate745 delegate745_1)
	{
		return delegate745_1(object_0, object_1);
	}

	// Token: 0x0600237A RID: 9082
	public extern Delegate745(object object_0, IntPtr intptr_0);

	// Token: 0x0600237B RID: 9083 RVA: 0x0000CB83 File Offset: 0x0000AD83
	static Delegate745()
	{
		Class15.smethod_14(typeof(Delegate745).TypeHandle);
	}

	// Token: 0x04000CC9 RID: 3273
	internal static Delegate745 delegate745_0;
}
