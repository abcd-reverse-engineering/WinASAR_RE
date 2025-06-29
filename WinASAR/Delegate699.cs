using System;

// Token: 0x020004CB RID: 1227
internal sealed class Delegate699 : MulticastDelegate
{
	// Token: 0x060022C0 RID: 8896
	public extern bool Invoke(object object_0);

	// Token: 0x060022C1 RID: 8897 RVA: 0x0000C706 File Offset: 0x0000A906
	public static bool smethod_0(object object_0, Delegate699 delegate699_1)
	{
		return delegate699_1(object_0);
	}

	// Token: 0x060022C2 RID: 8898
	public extern Delegate699(object object_0, IntPtr intptr_0);

	// Token: 0x060022C3 RID: 8899 RVA: 0x0000C711 File Offset: 0x0000A911
	static Delegate699()
	{
		Class15.smethod_14(typeof(Delegate699).TypeHandle);
	}

	// Token: 0x04000C9B RID: 3227
	internal static Delegate699 delegate699_0;
}
