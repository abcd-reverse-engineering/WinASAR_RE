using System;

// Token: 0x02000307 RID: 775
internal sealed class Delegate247 : MulticastDelegate
{
	// Token: 0x06001BB0 RID: 7088
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001BB1 RID: 7089 RVA: 0x000099A5 File Offset: 0x00007BA5
	public static void smethod_0(object object_0, bool bool_0, Delegate247 delegate247_1)
	{
		delegate247_1(object_0, bool_0);
	}

	// Token: 0x06001BB2 RID: 7090
	public extern Delegate247(object object_0, IntPtr intptr_0);

	// Token: 0x06001BB3 RID: 7091 RVA: 0x000099B2 File Offset: 0x00007BB2
	static Delegate247()
	{
		Class15.smethod_14(typeof(Delegate247).TypeHandle);
	}

	// Token: 0x04000AD7 RID: 2775
	internal static Delegate247 delegate247_0;
}
