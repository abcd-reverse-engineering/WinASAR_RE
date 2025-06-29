using System;
using System.Globalization;

// Token: 0x02000376 RID: 886
internal sealed class Delegate358 : MulticastDelegate
{
	// Token: 0x06001D6C RID: 7532
	public extern bool Invoke(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref double double_0);

	// Token: 0x06001D6D RID: 7533 RVA: 0x0000A4C1 File Offset: 0x000086C1
	public static bool smethod_0(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref double double_0, Delegate358 delegate358_1)
	{
		return delegate358_1(string_0, numberStyles_0, iformatProvider_0, ref double_0);
	}

	// Token: 0x06001D6E RID: 7534
	public extern Delegate358(object object_0, IntPtr intptr_0);

	// Token: 0x06001D6F RID: 7535 RVA: 0x0000A4D2 File Offset: 0x000086D2
	static Delegate358()
	{
		Class15.smethod_14(typeof(Delegate358).TypeHandle);
	}

	// Token: 0x04000B46 RID: 2886
	internal static Delegate358 delegate358_0;
}
