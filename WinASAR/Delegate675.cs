using System;

// Token: 0x020004B3 RID: 1203
internal sealed class Delegate675 : MulticastDelegate
{
	// Token: 0x06002260 RID: 8800
	public extern object[] Invoke(object object_0, bool bool_0);

	// Token: 0x06002261 RID: 8801 RVA: 0x0000C4AB File Offset: 0x0000A6AB
	public static object[] smethod_0(object object_0, bool bool_0, Delegate675 delegate675_1)
	{
		return delegate675_1(object_0, bool_0);
	}

	// Token: 0x06002262 RID: 8802
	public extern Delegate675(object object_0, IntPtr intptr_0);

	// Token: 0x06002263 RID: 8803 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
	static Delegate675()
	{
		Class15.smethod_14(typeof(Delegate675).TypeHandle);
	}

	// Token: 0x04000C83 RID: 3203
	internal static Delegate675 delegate675_0;
}
