using System;

// Token: 0x02000614 RID: 1556
internal sealed class Delegate1028 : MulticastDelegate
{
	// Token: 0x060027E4 RID: 10212
	public extern int Invoke(ref IntPtr intptr_0);

	// Token: 0x060027E5 RID: 10213 RVA: 0x0000E78A File Offset: 0x0000C98A
	public static int smethod_0(ref IntPtr intptr_0, Delegate1028 delegate1028_1)
	{
		return delegate1028_1(ref intptr_0);
	}

	// Token: 0x060027E6 RID: 10214
	public extern Delegate1028(object object_0, IntPtr intptr_0);

	// Token: 0x060027E7 RID: 10215 RVA: 0x0000E795 File Offset: 0x0000C995
	static Delegate1028()
	{
		Class15.smethod_14(typeof(Delegate1028).TypeHandle);
	}

	// Token: 0x04000DE4 RID: 3556
	internal static Delegate1028 delegate1028_0;
}
