using System;
using System.Diagnostics;

// Token: 0x020004EF RID: 1263
internal sealed class Delegate735 : MulticastDelegate
{
	// Token: 0x06002350 RID: 9040
	public extern void Invoke(object object_0, TraceEventCache traceEventCache_0, string string_0, TraceEventType traceEventType_0, int int_0, string string_1);

	// Token: 0x06002351 RID: 9041 RVA: 0x0000CA70 File Offset: 0x0000AC70
	public static void smethod_0(object object_0, TraceEventCache traceEventCache_0, string string_0, TraceEventType traceEventType_0, int int_0, string string_1, Delegate735 delegate735_1)
	{
		delegate735_1(object_0, traceEventCache_0, string_0, traceEventType_0, int_0, string_1);
	}

	// Token: 0x06002352 RID: 9042
	public extern Delegate735(object object_0, IntPtr intptr_0);

	// Token: 0x06002353 RID: 9043 RVA: 0x0000CA85 File Offset: 0x0000AC85
	static Delegate735()
	{
		Class15.smethod_14(typeof(Delegate735).TypeHandle);
	}

	// Token: 0x04000CBF RID: 3263
	internal static Delegate735 delegate735_0;
}
