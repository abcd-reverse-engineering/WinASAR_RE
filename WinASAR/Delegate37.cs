using System;
using System.Configuration;

// Token: 0x02000235 RID: 565
internal sealed class Delegate37 : MulticastDelegate
{
	// Token: 0x06001868 RID: 6248
	public extern SettingsBase Invoke(SettingsBase settingsBase_0);

	// Token: 0x06001869 RID: 6249 RVA: 0x000084ED File Offset: 0x000066ED
	public static SettingsBase smethod_0(SettingsBase settingsBase_0, Delegate37 delegate37_1)
	{
		return delegate37_1(settingsBase_0);
	}

	// Token: 0x0600186A RID: 6250
	public extern Delegate37(object object_0, IntPtr intptr_0);

	// Token: 0x0600186B RID: 6251 RVA: 0x000084F8 File Offset: 0x000066F8
	static Delegate37()
	{
		Class15.smethod_14(typeof(Delegate37).TypeHandle);
	}

	// Token: 0x04000A05 RID: 2565
	internal static Delegate37 delegate37_0;
}
