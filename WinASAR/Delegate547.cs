using System;

// Token: 0x02000433 RID: 1075
internal sealed class Delegate547 : MulticastDelegate
{
	// Token: 0x06002060 RID: 8288
	public extern object Invoke(object object_0);

	// Token: 0x06002061 RID: 8289 RVA: 0x0000B7DD File Offset: 0x000099DD
	public static object smethod_0(object object_0, Delegate547 delegate547_1)
	{
		return delegate547_1(object_0);
	}

	// Token: 0x06002062 RID: 8290
	public extern Delegate547(object object_0, IntPtr intptr_0);

	// Token: 0x06002063 RID: 8291 RVA: 0x0000B7E8 File Offset: 0x000099E8
	static Delegate547()
	{
		Class15.smethod_14(typeof(Delegate547).TypeHandle);
	}

	// Token: 0x04000C03 RID: 3075
	internal static Delegate547 delegate547_0;
}
