using System;

// Token: 0x0200050B RID: 1291
internal sealed class Delegate763 : MulticastDelegate
{
	// Token: 0x060023C0 RID: 9152
	public extern int Invoke(ref bool bool_0);

	// Token: 0x060023C1 RID: 9153 RVA: 0x0000CD34 File Offset: 0x0000AF34
	public static int smethod_0(ref bool bool_0, Delegate763 delegate763_1)
	{
		return delegate763_1(ref bool_0);
	}

	// Token: 0x060023C2 RID: 9154
	public extern Delegate763(object object_0, IntPtr intptr_0);

	// Token: 0x060023C3 RID: 9155 RVA: 0x0000CD3F File Offset: 0x0000AF3F
	static Delegate763()
	{
		Class15.smethod_14(typeof(Delegate763).TypeHandle);
	}

	// Token: 0x04000CDB RID: 3291
	internal static Delegate763 delegate763_0;
}
