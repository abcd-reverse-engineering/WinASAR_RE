using System;

// Token: 0x020004DD RID: 1245
internal sealed class Delegate717 : MulticastDelegate
{
	// Token: 0x06002308 RID: 8968
	public extern bool Invoke(object object_0);

	// Token: 0x06002309 RID: 8969 RVA: 0x0000C8BA File Offset: 0x0000AABA
	public static bool smethod_0(object object_0, Delegate717 delegate717_1)
	{
		return delegate717_1(object_0);
	}

	// Token: 0x0600230A RID: 8970
	public extern Delegate717(object object_0, IntPtr intptr_0);

	// Token: 0x0600230B RID: 8971 RVA: 0x0000C8C5 File Offset: 0x0000AAC5
	static Delegate717()
	{
		Class15.smethod_14(typeof(Delegate717).TypeHandle);
	}

	// Token: 0x04000CAD RID: 3245
	internal static Delegate717 delegate717_0;
}
