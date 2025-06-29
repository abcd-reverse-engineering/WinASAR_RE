using System;
using System.Numerics;

// Token: 0x02000523 RID: 1315
internal sealed class Delegate787 : MulticastDelegate
{
	// Token: 0x06002420 RID: 9248
	public extern byte Invoke(BigInteger bigInteger_0);

	// Token: 0x06002421 RID: 9249 RVA: 0x0000CF96 File Offset: 0x0000B196
	public static byte smethod_0(BigInteger bigInteger_0, Delegate787 delegate787_1)
	{
		return delegate787_1(bigInteger_0);
	}

	// Token: 0x06002422 RID: 9250
	public extern Delegate787(object object_0, IntPtr intptr_0);

	// Token: 0x06002423 RID: 9251 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
	static Delegate787()
	{
		Class15.smethod_14(typeof(Delegate787).TypeHandle);
	}

	// Token: 0x04000CF3 RID: 3315
	internal static Delegate787 delegate787_0;
}
