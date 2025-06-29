using System;

// Token: 0x0200059C RID: 1436
internal sealed class Delegate908 : MulticastDelegate
{
	// Token: 0x06002604 RID: 9732
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06002605 RID: 9733 RVA: 0x0000DB90 File Offset: 0x0000BD90
	public static void smethod_0(object object_0, string string_0, Delegate908 delegate908_1)
	{
		delegate908_1(object_0, string_0);
	}

	// Token: 0x06002606 RID: 9734
	public extern Delegate908(object object_0, IntPtr intptr_0);

	// Token: 0x06002607 RID: 9735 RVA: 0x0000DB9D File Offset: 0x0000BD9D
	static Delegate908()
	{
		Class15.smethod_14(typeof(Delegate908).TypeHandle);
	}

	// Token: 0x04000D6C RID: 3436
	internal static Delegate908 delegate908_0;
}
