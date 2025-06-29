using System;
using System.Reflection;

// Token: 0x02000620 RID: 1568
internal sealed class Delegate1040 : MulticastDelegate
{
	// Token: 0x06002814 RID: 10260
	public extern bool Invoke(MethodBase methodBase_0, MethodBase methodBase_1);

	// Token: 0x06002815 RID: 10261 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
	public static bool smethod_0(MethodBase methodBase_0, MethodBase methodBase_1, Delegate1040 delegate1040_1)
	{
		return delegate1040_1(methodBase_0, methodBase_1);
	}

	// Token: 0x06002816 RID: 10262
	public extern Delegate1040(object object_0, IntPtr intptr_0);

	// Token: 0x06002817 RID: 10263 RVA: 0x0000E8C1 File Offset: 0x0000CAC1
	static Delegate1040()
	{
		Class15.smethod_14(typeof(Delegate1040).TypeHandle);
	}

	// Token: 0x04000DF0 RID: 3568
	internal static Delegate1040 delegate1040_0;
}
