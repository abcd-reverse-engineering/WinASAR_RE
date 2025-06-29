using System;

// Token: 0x0200050A RID: 1290
internal sealed class Delegate762 : MulticastDelegate
{
	// Token: 0x060023BC RID: 9148
	public extern int Invoke(object object_0);

	// Token: 0x060023BD RID: 9149 RVA: 0x0000CD1C File Offset: 0x0000AF1C
	public static int smethod_0(object object_0, Delegate762 delegate762_1)
	{
		return delegate762_1(object_0);
	}

	// Token: 0x060023BE RID: 9150
	public extern Delegate762(object object_0, IntPtr intptr_0);

	// Token: 0x060023BF RID: 9151 RVA: 0x0000CD27 File Offset: 0x0000AF27
	static Delegate762()
	{
		Class15.smethod_14(typeof(Delegate762).TypeHandle);
	}

	// Token: 0x04000CDA RID: 3290
	internal static Delegate762 delegate762_0;
}
