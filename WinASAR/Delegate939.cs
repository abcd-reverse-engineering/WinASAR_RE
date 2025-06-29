using System;

// Token: 0x020005BB RID: 1467
internal sealed class Delegate939 : MulticastDelegate
{
	// Token: 0x06002680 RID: 9856
	public extern void Invoke(object object_0);

	// Token: 0x06002681 RID: 9857 RVA: 0x0000DE8E File Offset: 0x0000C08E
	public static void smethod_0(object object_0, Delegate939 delegate939_1)
	{
		delegate939_1(object_0);
	}

	// Token: 0x06002682 RID: 9858
	public extern Delegate939(object object_0, IntPtr intptr_0);

	// Token: 0x06002683 RID: 9859 RVA: 0x0000DE99 File Offset: 0x0000C099
	static Delegate939()
	{
		Class15.smethod_14(typeof(Delegate939).TypeHandle);
	}

	// Token: 0x04000D8B RID: 3467
	internal static Delegate939 delegate939_0;
}
