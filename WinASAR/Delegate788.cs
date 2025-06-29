using System;
using System.Numerics;

// Token: 0x02000524 RID: 1316
internal sealed class Delegate788 : MulticastDelegate
{
	// Token: 0x06002424 RID: 9252
	public extern sbyte Invoke(BigInteger bigInteger_0);

	// Token: 0x06002425 RID: 9253 RVA: 0x0000CFAE File Offset: 0x0000B1AE
	public static sbyte smethod_0(BigInteger bigInteger_0, Delegate788 delegate788_1)
	{
		return delegate788_1(bigInteger_0);
	}

	// Token: 0x06002426 RID: 9254
	public extern Delegate788(object object_0, IntPtr intptr_0);

	// Token: 0x06002427 RID: 9255 RVA: 0x0000CFB9 File Offset: 0x0000B1B9
	static Delegate788()
	{
		Class15.smethod_14(typeof(Delegate788).TypeHandle);
	}

	// Token: 0x04000CF4 RID: 3316
	internal static Delegate788 delegate788_0;
}
