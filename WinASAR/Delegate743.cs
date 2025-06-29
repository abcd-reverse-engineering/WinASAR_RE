using System;

// Token: 0x020004F7 RID: 1271
internal sealed class Delegate743 : MulticastDelegate
{
	// Token: 0x06002370 RID: 9072
	public extern Array Invoke(Type type_0, int int_0);

	// Token: 0x06002371 RID: 9073 RVA: 0x0000CB40 File Offset: 0x0000AD40
	public static Array smethod_0(Type type_0, int int_0, Delegate743 delegate743_1)
	{
		return delegate743_1(type_0, int_0);
	}

	// Token: 0x06002372 RID: 9074
	public extern Delegate743(object object_0, IntPtr intptr_0);

	// Token: 0x06002373 RID: 9075 RVA: 0x0000CB4D File Offset: 0x0000AD4D
	static Delegate743()
	{
		Class15.smethod_14(typeof(Delegate743).TypeHandle);
	}

	// Token: 0x04000CC7 RID: 3271
	internal static Delegate743 delegate743_0;
}
