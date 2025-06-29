using System;

// Token: 0x0200061D RID: 1565
internal sealed class Delegate1037 : MulticastDelegate
{
	// Token: 0x06002808 RID: 10248
	public extern string Invoke(object object_0, int int_0);

	// Token: 0x06002809 RID: 10249 RVA: 0x0000E866 File Offset: 0x0000CA66
	public static string smethod_0(object object_0, int int_0, Delegate1037 delegate1037_1)
	{
		return delegate1037_1(object_0, int_0);
	}

	// Token: 0x0600280A RID: 10250
	public extern Delegate1037(object object_0, IntPtr intptr_0);

	// Token: 0x0600280B RID: 10251 RVA: 0x0000E873 File Offset: 0x0000CA73
	static Delegate1037()
	{
		Class15.smethod_14(typeof(Delegate1037).TypeHandle);
	}

	// Token: 0x04000DED RID: 3565
	internal static Delegate1037 delegate1037_0;
}
