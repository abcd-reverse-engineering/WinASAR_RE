using System;
using System.Dynamic;

// Token: 0x02000418 RID: 1048
internal sealed class Delegate520 : MulticastDelegate
{
	// Token: 0x06001FF4 RID: 8180
	public extern DynamicMetaObject Invoke(object object_0, ConvertBinder convertBinder_0);

	// Token: 0x06001FF5 RID: 8181 RVA: 0x0000B519 File Offset: 0x00009719
	public static DynamicMetaObject smethod_0(object object_0, ConvertBinder convertBinder_0, Delegate520 delegate520_1)
	{
		return delegate520_1(object_0, convertBinder_0);
	}

	// Token: 0x06001FF6 RID: 8182
	public extern Delegate520(object object_0, IntPtr intptr_0);

	// Token: 0x06001FF7 RID: 8183 RVA: 0x0000B526 File Offset: 0x00009726
	static Delegate520()
	{
		Class15.smethod_14(typeof(Delegate520).TypeHandle);
	}

	// Token: 0x04000BE8 RID: 3048
	internal static Delegate520 delegate520_0;
}
