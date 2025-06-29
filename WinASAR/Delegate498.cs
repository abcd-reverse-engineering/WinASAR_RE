using System;

// Token: 0x02000402 RID: 1026
internal sealed class Delegate498 : MulticastDelegate
{
	// Token: 0x06001F9C RID: 8092
	public extern int Invoke(ref TimeSpan timeSpan_0);

	// Token: 0x06001F9D RID: 8093 RVA: 0x0000B2F1 File Offset: 0x000094F1
	public static int smethod_0(ref TimeSpan timeSpan_0, Delegate498 delegate498_1)
	{
		return delegate498_1(ref timeSpan_0);
	}

	// Token: 0x06001F9E RID: 8094
	public extern Delegate498(object object_0, IntPtr intptr_0);

	// Token: 0x06001F9F RID: 8095 RVA: 0x0000B2FC File Offset: 0x000094FC
	static Delegate498()
	{
		Class15.smethod_14(typeof(Delegate498).TypeHandle);
	}

	// Token: 0x04000BD2 RID: 3026
	internal static Delegate498 delegate498_0;
}
