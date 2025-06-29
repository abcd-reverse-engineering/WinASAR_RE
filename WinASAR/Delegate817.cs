using System;
using System.Globalization;

// Token: 0x02000541 RID: 1345
internal sealed class Delegate817 : MulticastDelegate
{
	// Token: 0x06002498 RID: 9368
	public extern bool Invoke(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref long long_0);

	// Token: 0x06002499 RID: 9369 RVA: 0x0000D292 File Offset: 0x0000B492
	public static bool smethod_0(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref long long_0, Delegate817 delegate817_1)
	{
		return delegate817_1(string_0, numberStyles_0, iformatProvider_0, ref long_0);
	}

	// Token: 0x0600249A RID: 9370
	public extern Delegate817(object object_0, IntPtr intptr_0);

	// Token: 0x0600249B RID: 9371 RVA: 0x0000D2A3 File Offset: 0x0000B4A3
	static Delegate817()
	{
		Class15.smethod_14(typeof(Delegate817).TypeHandle);
	}

	// Token: 0x04000D11 RID: 3345
	internal static Delegate817 delegate817_0;
}
