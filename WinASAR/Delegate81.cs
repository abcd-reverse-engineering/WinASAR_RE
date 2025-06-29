using System;

// Token: 0x02000261 RID: 609
internal sealed class Delegate81 : MulticastDelegate
{
	// Token: 0x06001918 RID: 6424
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001919 RID: 6425 RVA: 0x00008949 File Offset: 0x00006B49
	public static void smethod_0(object object_0, string string_0, Delegate81 delegate81_1)
	{
		delegate81_1(object_0, string_0);
	}

	// Token: 0x0600191A RID: 6426
	public extern Delegate81(object object_0, IntPtr intptr_0);

	// Token: 0x0600191B RID: 6427 RVA: 0x00008956 File Offset: 0x00006B56
	static Delegate81()
	{
		Class15.smethod_14(typeof(Delegate81).TypeHandle);
	}

	// Token: 0x04000A31 RID: 2609
	internal static Delegate81 delegate81_0;
}
