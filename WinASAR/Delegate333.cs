using System;

// Token: 0x0200035D RID: 861
internal sealed class Delegate333 : MulticastDelegate
{
	// Token: 0x06001D08 RID: 7432
	public extern string Invoke(ref sbyte sbyte_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D09 RID: 7433 RVA: 0x0000A237 File Offset: 0x00008437
	public static string smethod_0(ref sbyte sbyte_0, string string_0, IFormatProvider iformatProvider_0, Delegate333 delegate333_1)
	{
		return delegate333_1(ref sbyte_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001D0A RID: 7434
	public extern Delegate333(object object_0, IntPtr intptr_0);

	// Token: 0x06001D0B RID: 7435 RVA: 0x0000A246 File Offset: 0x00008446
	static Delegate333()
	{
		Class15.smethod_14(typeof(Delegate333).TypeHandle);
	}

	// Token: 0x04000B2D RID: 2861
	internal static Delegate333 delegate333_0;
}
