using System;

// Token: 0x02000510 RID: 1296
internal sealed class Delegate768 : MulticastDelegate
{
	// Token: 0x060023D4 RID: 9172
	public extern string Invoke(string string_0);

	// Token: 0x060023D5 RID: 9173 RVA: 0x0000CDB6 File Offset: 0x0000AFB6
	public static string smethod_0(string string_0, Delegate768 delegate768_1)
	{
		return delegate768_1(string_0);
	}

	// Token: 0x060023D6 RID: 9174
	public extern Delegate768(object object_0, IntPtr intptr_0);

	// Token: 0x060023D7 RID: 9175 RVA: 0x0000CDC1 File Offset: 0x0000AFC1
	static Delegate768()
	{
		Class15.smethod_14(typeof(Delegate768).TypeHandle);
	}

	// Token: 0x04000CE0 RID: 3296
	internal static Delegate768 delegate768_0;
}
