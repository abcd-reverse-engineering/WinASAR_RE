using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000080 RID: 128
	[Nullable(0)]
	[NullableContext(1)]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
		public BidirectionalDictionary()
			: this(EqualityComparer<TFirst>.Default, EqualityComparer<TSecond>.Default)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000374C File Offset: 0x0000194C
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
			: this(firstEqualityComparer, secondEqualityComparer, Class15.smethod_17(1760326587 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), Class15.smethod_17(974433665 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f))
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00003782 File Offset: 0x00001982
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
			this.idictionary_0 = new Dictionary<TFirst, TSecond>(firstEqualityComparer);
			this.idictionary_1 = new Dictionary<TSecond, TFirst>(secondEqualityComparer);
			this.string_0 = duplicateFirstErrorMessage;
			this.string_1 = duplicateSecondErrorMessage;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0003EB24 File Offset: 0x0003CD24
		public void Set(TFirst first, TSecond second)
		{
			TSecond tsecond;
			if (this.idictionary_0.TryGetValue(first, out tsecond) && !tsecond.Equals(second))
			{
				throw new ArgumentException(this.string_0.FormatWith(CultureInfo.InvariantCulture, first));
			}
			TFirst tfirst;
			if (this.idictionary_1.TryGetValue(second, out tfirst) && !tfirst.Equals(first))
			{
				throw new ArgumentException(this.string_1.FormatWith(CultureInfo.InvariantCulture, second));
			}
			this.idictionary_0.Add(first, second);
			this.idictionary_1.Add(second, first);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000037B3 File Offset: 0x000019B3
		public bool TryGetByFirst(TFirst first, [NotNullWhen(true)] [Nullable(2)] out TSecond second)
		{
			return this.idictionary_0.TryGetValue(first, out second);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000037C2 File Offset: 0x000019C2
		public bool TryGetBySecond(TSecond second, [NotNullWhen(true)] [Nullable(2)] out TFirst first)
		{
			return this.idictionary_1.TryGetValue(second, out first);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000037D1 File Offset: 0x000019D1
		internal static bool smethod_0()
		{
			return BidirectionalDictionary<TFirst, TSecond>.object_0 == null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000037DB File Offset: 0x000019DB
		internal static object smethod_1()
		{
			return BidirectionalDictionary<TFirst, TSecond>.object_0;
		}

		// Token: 0x04000340 RID: 832
		private readonly IDictionary<TFirst, TSecond> idictionary_0;

		// Token: 0x04000341 RID: 833
		private readonly IDictionary<TSecond, TFirst> idictionary_1;

		// Token: 0x04000342 RID: 834
		private readonly string string_0;

		// Token: 0x04000343 RID: 835
		private readonly string string_1;

		// Token: 0x04000344 RID: 836
		internal static object object_0;
	}
}
