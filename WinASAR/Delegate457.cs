using System;

// Token: 0x020003D9 RID: 985
internal sealed class Delegate457 : MulticastDelegate
{
	// Token: 0x06001EF8 RID: 7928
	public extern bool Invoke(object object_0, Type type_0);

	// Token: 0x06001EF9 RID: 7929 RVA: 0x0000AEC5 File Offset: 0x000090C5
	public static bool smethod_0(object object_0, Type type_0, Delegate457 delegate457_1)
	{
		return delegate457_1(object_0, type_0);
	}

	// Token: 0x06001EFA RID: 7930
	public extern Delegate457(object object_0, IntPtr intptr_0);

	// Token: 0x06001EFB RID: 7931 RVA: 0x0000AED2 File Offset: 0x000090D2
	static Delegate457()
	{
		Class15.smethod_14(typeof(Delegate457).TypeHandle);
	}

	// Token: 0x04000BA9 RID: 2985
	internal static Delegate457 delegate457_0;
}
