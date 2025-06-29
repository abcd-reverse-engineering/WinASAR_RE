using System;

// Token: 0x02000323 RID: 803
internal sealed class Delegate275 : MulticastDelegate
{
	// Token: 0x06001C20 RID: 7200
	public extern int Invoke(object object_0);

	// Token: 0x06001C21 RID: 7201 RVA: 0x00009C5D File Offset: 0x00007E5D
	public static int smethod_0(object object_0, Delegate275 delegate275_1)
	{
		return delegate275_1(object_0);
	}

	// Token: 0x06001C22 RID: 7202
	public extern Delegate275(object object_0, IntPtr intptr_0);

	// Token: 0x06001C23 RID: 7203 RVA: 0x00009C68 File Offset: 0x00007E68
	static Delegate275()
	{
		Class15.smethod_14(typeof(Delegate275).TypeHandle);
	}

	// Token: 0x04000AF3 RID: 2803
	internal static Delegate275 delegate275_0;
}
