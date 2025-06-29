using System;

// Token: 0x02000267 RID: 615
internal sealed class Delegate87 : MulticastDelegate
{
	// Token: 0x06001930 RID: 6448
	public extern string Invoke(string string_0);

	// Token: 0x06001931 RID: 6449 RVA: 0x000089E1 File Offset: 0x00006BE1
	public static string smethod_0(string string_0, Delegate87 delegate87_1)
	{
		return delegate87_1(string_0);
	}

	// Token: 0x06001932 RID: 6450
	public extern Delegate87(object object_0, IntPtr intptr_0);

	// Token: 0x06001933 RID: 6451 RVA: 0x000089EC File Offset: 0x00006BEC
	static Delegate87()
	{
		Class15.smethod_14(typeof(Delegate87).TypeHandle);
	}

	// Token: 0x04000A37 RID: 2615
	internal static Delegate87 delegate87_0;
}
