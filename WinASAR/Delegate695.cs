using System;

// Token: 0x020004C7 RID: 1223
internal sealed class Delegate695 : MulticastDelegate
{
	// Token: 0x060022B0 RID: 8880
	public extern bool Invoke(object object_0);

	// Token: 0x060022B1 RID: 8881 RVA: 0x0000C6A6 File Offset: 0x0000A8A6
	public static bool smethod_0(object object_0, Delegate695 delegate695_1)
	{
		return delegate695_1(object_0);
	}

	// Token: 0x060022B2 RID: 8882
	public extern Delegate695(object object_0, IntPtr intptr_0);

	// Token: 0x060022B3 RID: 8883 RVA: 0x0000C6B1 File Offset: 0x0000A8B1
	static Delegate695()
	{
		Class15.smethod_14(typeof(Delegate695).TypeHandle);
	}

	// Token: 0x04000C97 RID: 3223
	internal static Delegate695 delegate695_0;
}
