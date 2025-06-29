using System;
using System.Numerics;

// Token: 0x020003D2 RID: 978
internal sealed class Delegate450 : MulticastDelegate
{
	// Token: 0x06001EDC RID: 7900
	public extern ulong Invoke(BigInteger bigInteger_0);

	// Token: 0x06001EDD RID: 7901 RVA: 0x0000AE11 File Offset: 0x00009011
	public static ulong smethod_0(BigInteger bigInteger_0, Delegate450 delegate450_1)
	{
		return delegate450_1(bigInteger_0);
	}

	// Token: 0x06001EDE RID: 7902
	public extern Delegate450(object object_0, IntPtr intptr_0);

	// Token: 0x06001EDF RID: 7903 RVA: 0x0000AE1C File Offset: 0x0000901C
	static Delegate450()
	{
		Class15.smethod_14(typeof(Delegate450).TypeHandle);
	}

	// Token: 0x04000BA2 RID: 2978
	internal static Delegate450 delegate450_0;
}
