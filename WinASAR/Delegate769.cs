using System;

// Token: 0x02000511 RID: 1297
internal sealed class Delegate769 : MulticastDelegate
{
	// Token: 0x060023D8 RID: 9176
	public extern string Invoke(object object_0, char[] char_0);

	// Token: 0x060023D9 RID: 9177 RVA: 0x0000CDCE File Offset: 0x0000AFCE
	public static string smethod_0(object object_0, char[] char_0, Delegate769 delegate769_1)
	{
		return delegate769_1(object_0, char_0);
	}

	// Token: 0x060023DA RID: 9178
	public extern Delegate769(object object_0, IntPtr intptr_0);

	// Token: 0x060023DB RID: 9179 RVA: 0x0000CDDB File Offset: 0x0000AFDB
	static Delegate769()
	{
		Class15.smethod_14(typeof(Delegate769).TypeHandle);
	}

	// Token: 0x04000CE1 RID: 3297
	internal static Delegate769 delegate769_0;
}
