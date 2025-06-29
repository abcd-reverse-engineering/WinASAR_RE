using System;

// Token: 0x02000469 RID: 1129
internal sealed class Delegate601 : MulticastDelegate
{
	// Token: 0x06002138 RID: 8504
	public extern string[] Invoke(Type type_0);

	// Token: 0x06002139 RID: 8505 RVA: 0x0000BD3B File Offset: 0x00009F3B
	public static string[] smethod_0(Type type_0, Delegate601 delegate601_1)
	{
		return delegate601_1(type_0);
	}

	// Token: 0x0600213A RID: 8506
	public extern Delegate601(object object_0, IntPtr intptr_0);

	// Token: 0x0600213B RID: 8507 RVA: 0x0000BD46 File Offset: 0x00009F46
	static Delegate601()
	{
		Class15.smethod_14(typeof(Delegate601).TypeHandle);
	}

	// Token: 0x04000C39 RID: 3129
	internal static Delegate601 delegate601_0;
}
