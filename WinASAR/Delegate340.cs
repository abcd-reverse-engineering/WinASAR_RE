using System;

// Token: 0x02000364 RID: 868
internal sealed class Delegate340 : MulticastDelegate
{
	// Token: 0x06001D24 RID: 7460
	public extern bool Invoke(Type type_0, Type type_1);

	// Token: 0x06001D25 RID: 7461 RVA: 0x0000A2F1 File Offset: 0x000084F1
	public static bool smethod_0(Type type_0, Type type_1, Delegate340 delegate340_1)
	{
		return delegate340_1(type_0, type_1);
	}

	// Token: 0x06001D26 RID: 7462
	public extern Delegate340(object object_0, IntPtr intptr_0);

	// Token: 0x06001D27 RID: 7463 RVA: 0x0000A2FE File Offset: 0x000084FE
	static Delegate340()
	{
		Class15.smethod_14(typeof(Delegate340).TypeHandle);
	}

	// Token: 0x04000B34 RID: 2868
	internal static Delegate340 delegate340_0;
}
