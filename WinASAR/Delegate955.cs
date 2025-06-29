using System;

// Token: 0x020005CB RID: 1483
internal sealed class Delegate955 : MulticastDelegate
{
	// Token: 0x060026C0 RID: 9920
	public extern void Invoke(object object_0, sbyte sbyte_0);

	// Token: 0x060026C1 RID: 9921 RVA: 0x0000E018 File Offset: 0x0000C218
	public static void smethod_0(object object_0, sbyte sbyte_0, Delegate955 delegate955_1)
	{
		delegate955_1(object_0, sbyte_0);
	}

	// Token: 0x060026C2 RID: 9922
	public extern Delegate955(object object_0, IntPtr intptr_0);

	// Token: 0x060026C3 RID: 9923 RVA: 0x0000E025 File Offset: 0x0000C225
	static Delegate955()
	{
		Class15.smethod_14(typeof(Delegate955).TypeHandle);
	}

	// Token: 0x04000D9B RID: 3483
	internal static Delegate955 delegate955_0;
}
