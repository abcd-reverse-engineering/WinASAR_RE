using System;

// Token: 0x020005F2 RID: 1522
internal sealed class Delegate994 : MulticastDelegate
{
	// Token: 0x0600275C RID: 10076
	public extern string Invoke(object object_0);

	// Token: 0x0600275D RID: 10077 RVA: 0x0000E444 File Offset: 0x0000C644
	public static string smethod_0(object object_0, Delegate994 delegate994_1)
	{
		return delegate994_1(object_0);
	}

	// Token: 0x0600275E RID: 10078
	public extern Delegate994(object object_0, IntPtr intptr_0);

	// Token: 0x0600275F RID: 10079 RVA: 0x0000E44F File Offset: 0x0000C64F
	static Delegate994()
	{
		Class15.smethod_14(typeof(Delegate994).TypeHandle);
	}

	// Token: 0x04000DC2 RID: 3522
	internal static Delegate994 delegate994_0;
}
