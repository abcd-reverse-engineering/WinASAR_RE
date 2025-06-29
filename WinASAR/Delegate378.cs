using System;

// Token: 0x0200038A RID: 906
internal sealed class Delegate378 : MulticastDelegate
{
	// Token: 0x06001DBC RID: 7612
	public extern char Invoke(int int_0);

	// Token: 0x06001DBD RID: 7613 RVA: 0x0000A6DD File Offset: 0x000088DD
	public static char smethod_0(int int_0, Delegate378 delegate378_1)
	{
		return delegate378_1(int_0);
	}

	// Token: 0x06001DBE RID: 7614
	public extern Delegate378(object object_0, IntPtr intptr_0);

	// Token: 0x06001DBF RID: 7615 RVA: 0x0000A6E8 File Offset: 0x000088E8
	static Delegate378()
	{
		Class15.smethod_14(typeof(Delegate378).TypeHandle);
	}

	// Token: 0x04000B5A RID: 2906
	internal static Delegate378 delegate378_0;
}
