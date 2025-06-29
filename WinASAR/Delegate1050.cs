using System;

// Token: 0x0200062A RID: 1578
internal sealed class Delegate1050 : MulticastDelegate
{
	// Token: 0x0600283C RID: 10300
	public extern RuntimeFieldHandle Invoke(object object_0);

	// Token: 0x0600283D RID: 10301 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
	public static RuntimeFieldHandle smethod_0(object object_0, Delegate1050 delegate1050_1)
	{
		return delegate1050_1(object_0);
	}

	// Token: 0x0600283E RID: 10302
	public extern Delegate1050(object object_0, IntPtr intptr_0);

	// Token: 0x0600283F RID: 10303 RVA: 0x0000E9BF File Offset: 0x0000CBBF
	static Delegate1050()
	{
		Class15.smethod_14(typeof(Delegate1050).TypeHandle);
	}

	// Token: 0x04000DFA RID: 3578
	internal static Delegate1050 delegate1050_0;
}
