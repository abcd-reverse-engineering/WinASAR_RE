using System;
using System.Reflection;

// Token: 0x020003B3 RID: 947
internal sealed class Delegate419 : MulticastDelegate
{
	// Token: 0x06001E60 RID: 7776
	public extern ConstructorInfo[] Invoke(object object_0, BindingFlags bindingFlags_0);

	// Token: 0x06001E61 RID: 7777 RVA: 0x0000AAF5 File Offset: 0x00008CF5
	public static ConstructorInfo[] smethod_0(object object_0, BindingFlags bindingFlags_0, Delegate419 delegate419_1)
	{
		return delegate419_1(object_0, bindingFlags_0);
	}

	// Token: 0x06001E62 RID: 7778
	public extern Delegate419(object object_0, IntPtr intptr_0);

	// Token: 0x06001E63 RID: 7779 RVA: 0x0000AB02 File Offset: 0x00008D02
	static Delegate419()
	{
		Class15.smethod_14(typeof(Delegate419).TypeHandle);
	}

	// Token: 0x04000B83 RID: 2947
	internal static Delegate419 delegate419_0;
}
