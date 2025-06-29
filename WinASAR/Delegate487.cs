using System;

// Token: 0x020003F7 RID: 1015
internal sealed class Delegate487 : MulticastDelegate
{
	// Token: 0x06001F70 RID: 8048
	public extern TimeSpan Invoke(double double_0);

	// Token: 0x06001F71 RID: 8049 RVA: 0x0000B1D3 File Offset: 0x000093D3
	public static TimeSpan smethod_0(double double_0, Delegate487 delegate487_1)
	{
		return delegate487_1(double_0);
	}

	// Token: 0x06001F72 RID: 8050
	public extern Delegate487(object object_0, IntPtr intptr_0);

	// Token: 0x06001F73 RID: 8051 RVA: 0x0000B1DE File Offset: 0x000093DE
	static Delegate487()
	{
		Class15.smethod_14(typeof(Delegate487).TypeHandle);
	}

	// Token: 0x04000BC7 RID: 3015
	internal static Delegate487 delegate487_0;
}
