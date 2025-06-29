using System;

// Token: 0x02000621 RID: 1569
internal sealed class Delegate1041 : MulticastDelegate
{
	// Token: 0x06002818 RID: 10264
	public extern RuntimeMethodHandle Invoke(object object_0);

	// Token: 0x06002819 RID: 10265 RVA: 0x0000E8CE File Offset: 0x0000CACE
	public static RuntimeMethodHandle smethod_0(object object_0, Delegate1041 delegate1041_1)
	{
		return delegate1041_1(object_0);
	}

	// Token: 0x0600281A RID: 10266
	public extern Delegate1041(object object_0, IntPtr intptr_0);

	// Token: 0x0600281B RID: 10267 RVA: 0x0000E8D9 File Offset: 0x0000CAD9
	static Delegate1041()
	{
		Class15.smethod_14(typeof(Delegate1041).TypeHandle);
	}

	// Token: 0x04000DF1 RID: 3569
	internal static Delegate1041 delegate1041_0;
}
