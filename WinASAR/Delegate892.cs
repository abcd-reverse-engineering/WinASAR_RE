using System;

// Token: 0x0200058C RID: 1420
internal sealed class Delegate892 : MulticastDelegate
{
	// Token: 0x060025C4 RID: 9668
	public extern string Invoke(object object_0);

	// Token: 0x060025C5 RID: 9669 RVA: 0x0000DA08 File Offset: 0x0000BC08
	public static string smethod_0(object object_0, Delegate892 delegate892_1)
	{
		return delegate892_1(object_0);
	}

	// Token: 0x060025C6 RID: 9670
	public extern Delegate892(object object_0, IntPtr intptr_0);

	// Token: 0x060025C7 RID: 9671 RVA: 0x0000DA13 File Offset: 0x0000BC13
	static Delegate892()
	{
		Class15.smethod_14(typeof(Delegate892).TypeHandle);
	}

	// Token: 0x04000D5C RID: 3420
	internal static Delegate892 delegate892_0;
}
