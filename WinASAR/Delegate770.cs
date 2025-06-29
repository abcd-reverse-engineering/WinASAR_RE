using System;

// Token: 0x02000512 RID: 1298
internal sealed class Delegate770 : MulticastDelegate
{
	// Token: 0x060023DC RID: 9180
	public extern string[] Invoke(object object_0, char[] char_0, StringSplitOptions stringSplitOptions_0);

	// Token: 0x060023DD RID: 9181 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
	public static string[] smethod_0(object object_0, char[] char_0, StringSplitOptions stringSplitOptions_0, Delegate770 delegate770_1)
	{
		return delegate770_1(object_0, char_0, stringSplitOptions_0);
	}

	// Token: 0x060023DE RID: 9182
	public extern Delegate770(object object_0, IntPtr intptr_0);

	// Token: 0x060023DF RID: 9183 RVA: 0x0000CDF7 File Offset: 0x0000AFF7
	static Delegate770()
	{
		Class15.smethod_14(typeof(Delegate770).TypeHandle);
	}

	// Token: 0x04000CE2 RID: 3298
	internal static Delegate770 delegate770_0;
}
