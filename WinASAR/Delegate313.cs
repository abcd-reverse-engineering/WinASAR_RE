using System;

// Token: 0x02000349 RID: 841
internal sealed class Delegate313 : MulticastDelegate
{
	// Token: 0x06001CB8 RID: 7352
	public extern string Invoke(string string_0);

	// Token: 0x06001CB9 RID: 7353 RVA: 0x0000A02D File Offset: 0x0000822D
	public static string smethod_0(string string_0, Delegate313 delegate313_1)
	{
		return delegate313_1(string_0);
	}

	// Token: 0x06001CBA RID: 7354
	public extern Delegate313(object object_0, IntPtr intptr_0);

	// Token: 0x06001CBB RID: 7355 RVA: 0x0000A038 File Offset: 0x00008238
	static Delegate313()
	{
		Class15.smethod_14(typeof(Delegate313).TypeHandle);
	}

	// Token: 0x04000B19 RID: 2841
	internal static Delegate313 delegate313_0;
}
