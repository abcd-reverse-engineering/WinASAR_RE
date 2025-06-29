using System;
using System.Numerics;

// Token: 0x0200052B RID: 1323
internal sealed class Delegate795 : MulticastDelegate
{
	// Token: 0x06002440 RID: 9280
	public extern byte[] Invoke(ref BigInteger bigInteger_0);

	// Token: 0x06002441 RID: 9281 RVA: 0x0000D05E File Offset: 0x0000B25E
	public static byte[] smethod_0(ref BigInteger bigInteger_0, Delegate795 delegate795_1)
	{
		return delegate795_1(ref bigInteger_0);
	}

	// Token: 0x06002442 RID: 9282
	public extern Delegate795(object object_0, IntPtr intptr_0);

	// Token: 0x06002443 RID: 9283 RVA: 0x0000D069 File Offset: 0x0000B269
	static Delegate795()
	{
		Class15.smethod_14(typeof(Delegate795).TypeHandle);
	}

	// Token: 0x04000CFB RID: 3323
	internal static Delegate795 delegate795_0;
}
