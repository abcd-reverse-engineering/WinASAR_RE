using System;

// Token: 0x020002CF RID: 719
internal sealed class Delegate191 : MulticastDelegate
{
	// Token: 0x06001AD0 RID: 6864
	public extern bool Invoke(object object_0, string string_0, StringComparison stringComparison_0);

	// Token: 0x06001AD1 RID: 6865 RVA: 0x00009415 File Offset: 0x00007615
	public static bool smethod_0(object object_0, string string_0, StringComparison stringComparison_0, Delegate191 delegate191_1)
	{
		return delegate191_1(object_0, string_0, stringComparison_0);
	}

	// Token: 0x06001AD2 RID: 6866
	public extern Delegate191(object object_0, IntPtr intptr_0);

	// Token: 0x06001AD3 RID: 6867 RVA: 0x00009424 File Offset: 0x00007624
	static Delegate191()
	{
		Class15.smethod_14(typeof(Delegate191).TypeHandle);
	}

	// Token: 0x04000A9F RID: 2719
	internal static Delegate191 delegate191_0;
}
