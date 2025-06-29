using System;
using System.Reflection;

// Token: 0x02000338 RID: 824
internal sealed class Delegate296 : MulticastDelegate
{
	// Token: 0x06001C74 RID: 7284
	public extern FieldInfo Invoke(object object_0, string string_0);

	// Token: 0x06001C75 RID: 7285 RVA: 0x00009E75 File Offset: 0x00008075
	public static FieldInfo smethod_0(object object_0, string string_0, Delegate296 delegate296_1)
	{
		return delegate296_1(object_0, string_0);
	}

	// Token: 0x06001C76 RID: 7286
	public extern Delegate296(object object_0, IntPtr intptr_0);

	// Token: 0x06001C77 RID: 7287 RVA: 0x00009E82 File Offset: 0x00008082
	static Delegate296()
	{
		Class15.smethod_14(typeof(Delegate296).TypeHandle);
	}

	// Token: 0x04000B08 RID: 2824
	internal static Delegate296 delegate296_0;
}
