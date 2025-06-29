using System;

// Token: 0x020005E2 RID: 1506
internal sealed class Delegate978 : MulticastDelegate
{
	// Token: 0x0600271C RID: 10012
	public extern void Invoke(object object_0);

	// Token: 0x0600271D RID: 10013 RVA: 0x0000E27C File Offset: 0x0000C47C
	public static void smethod_0(object object_0, Delegate978 delegate978_1)
	{
		delegate978_1(object_0);
	}

	// Token: 0x0600271E RID: 10014
	public extern Delegate978(object object_0, IntPtr intptr_0);

	// Token: 0x0600271F RID: 10015 RVA: 0x0000E287 File Offset: 0x0000C487
	static Delegate978()
	{
		Class15.smethod_14(typeof(Delegate978).TypeHandle);
	}

	// Token: 0x04000DB2 RID: 3506
	internal static Delegate978 delegate978_0;
}
