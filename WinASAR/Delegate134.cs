using System;

// Token: 0x02000296 RID: 662
internal sealed class Delegate134 : MulticastDelegate
{
	// Token: 0x060019EC RID: 6636
	public extern string Invoke(object object_0);

	// Token: 0x060019ED RID: 6637 RVA: 0x00008E7B File Offset: 0x0000707B
	public static string smethod_0(object object_0, Delegate134 delegate134_1)
	{
		return delegate134_1(object_0);
	}

	// Token: 0x060019EE RID: 6638
	public extern Delegate134(object object_0, IntPtr intptr_0);

	// Token: 0x060019EF RID: 6639 RVA: 0x00008E86 File Offset: 0x00007086
	static Delegate134()
	{
		Class15.smethod_14(typeof(Delegate134).TypeHandle);
	}

	// Token: 0x04000A66 RID: 2662
	internal static Delegate134 delegate134_0;
}
