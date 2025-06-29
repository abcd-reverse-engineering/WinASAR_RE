using System;

// Token: 0x020003C0 RID: 960
internal sealed class Delegate432 : MulticastDelegate
{
	// Token: 0x06001E94 RID: 7828
	public extern bool Invoke(object object_0, object object_1);

	// Token: 0x06001E95 RID: 7829 RVA: 0x0000AC41 File Offset: 0x00008E41
	public static bool smethod_0(object object_0, object object_1, Delegate432 delegate432_1)
	{
		return delegate432_1(object_0, object_1);
	}

	// Token: 0x06001E96 RID: 7830
	public extern Delegate432(object object_0, IntPtr intptr_0);

	// Token: 0x06001E97 RID: 7831 RVA: 0x0000AC4E File Offset: 0x00008E4E
	static Delegate432()
	{
		Class15.smethod_14(typeof(Delegate432).TypeHandle);
	}

	// Token: 0x04000B90 RID: 2960
	internal static Delegate432 delegate432_0;
}
