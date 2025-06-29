using System;
using System.Reflection;

// Token: 0x020004E1 RID: 1249
internal sealed class Delegate721 : MulticastDelegate
{
	// Token: 0x06002318 RID: 8984
	public extern PropertyInfo Invoke(object object_0, string string_0, BindingFlags bindingFlags_0);

	// Token: 0x06002319 RID: 8985 RVA: 0x0000C91A File Offset: 0x0000AB1A
	public static PropertyInfo smethod_0(object object_0, string string_0, BindingFlags bindingFlags_0, Delegate721 delegate721_1)
	{
		return delegate721_1(object_0, string_0, bindingFlags_0);
	}

	// Token: 0x0600231A RID: 8986
	public extern Delegate721(object object_0, IntPtr intptr_0);

	// Token: 0x0600231B RID: 8987 RVA: 0x0000C929 File Offset: 0x0000AB29
	static Delegate721()
	{
		Class15.smethod_14(typeof(Delegate721).TypeHandle);
	}

	// Token: 0x04000CB1 RID: 3249
	internal static Delegate721 delegate721_0;
}
