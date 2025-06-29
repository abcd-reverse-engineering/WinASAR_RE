using System;

// Token: 0x02000263 RID: 611
internal sealed class Delegate83 : MulticastDelegate
{
	// Token: 0x06001920 RID: 6432
	public extern int Invoke(object object_0, object object_1);

	// Token: 0x06001921 RID: 6433 RVA: 0x0000897D File Offset: 0x00006B7D
	public static int smethod_0(object object_0, object object_1, Delegate83 delegate83_1)
	{
		return delegate83_1(object_0, object_1);
	}

	// Token: 0x06001922 RID: 6434
	public extern Delegate83(object object_0, IntPtr intptr_0);

	// Token: 0x06001923 RID: 6435 RVA: 0x0000898A File Offset: 0x00006B8A
	static Delegate83()
	{
		Class15.smethod_14(typeof(Delegate83).TypeHandle);
	}

	// Token: 0x04000A33 RID: 2611
	internal static Delegate83 delegate83_0;
}
