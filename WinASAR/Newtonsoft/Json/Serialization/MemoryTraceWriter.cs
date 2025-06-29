using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000120 RID: 288
	[Nullable(0)]
	[NullableContext(1)]
	public class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0000520A File Offset: 0x0000340A
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00069014 File Offset: 0x00067214
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return this.traceLevel_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.traceLevel_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0006904C File Offset: 0x0006724C
		public MemoryTraceWriter()
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
			{
				goto IL_006C;
			}
			IL_001A:
			this.LevelFilter = TraceLevel.Verbose;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
			{
				goto IL_006C;
			}
			IL_0033:
			this.queue_0 = new Queue<string>();
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
			{
				goto IL_006C;
			}
			IL_0050:
			this.object_0 = new object();
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
			{
				return;
			}
			IL_006C:
			switch (num)
			{
			case 0:
				goto IL_0050;
			case 1:
				goto IL_0033;
			case 2:
				break;
			case 3:
				goto IL_001A;
			default:
				goto IL_0050;
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000690E0 File Offset: 0x000672E0
		public void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex)
		{
			string text;
			object obj;
			bool flag;
			for (;;)
			{
				IL_0052:
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(DateTime.Now.ToString(Class15.smethod_17(299916891 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e), CultureInfo.InvariantCulture));
				stringBuilder.Append(Class15.smethod_17(124840108 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
				stringBuilder.Append(level.ToString(Class15.smethod_17(82274166 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909)));
				stringBuilder.Append(Class15.smethod_17(1603811198 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
				stringBuilder.Append(message);
				text = stringBuilder.ToString();
				for (;;)
				{
					obj = this.object_0;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_0003;
					}
					IL_001A:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0052;
					case 4:
						goto IL_00FA;
					}
					IL_0003:
					flag = false;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						goto IL_001A;
					}
					goto IL_00F9;
				}
			}
			IL_00F9:
			IL_00FA:
			try
			{
				Monitor.Enter(obj, ref flag);
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					goto IL_0138;
				}
				goto IL_014D;
				IL_0118:
				this.queue_0.Dequeue();
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_0166;
				}
				goto IL_014D;
				IL_0138:
				if (this.queue_0.Count >= 1000)
				{
					goto IL_0118;
				}
				goto IL_0166;
				IL_014D:
				switch (num2)
				{
				case 1:
					goto IL_0138;
				case 2:
					goto IL_0118;
				case 3:
					goto IL_0173;
				}
				IL_0166:
				this.queue_0.Enqueue(text);
				IL_0173:;
			}
			finally
			{
				if (flag)
				{
					goto IL_01A1;
				}
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
				{
					goto IL_01BA;
				}
				IL_018D:
				switch (num3)
				{
				case 2:
					IL_01A1:
					Monitor.Exit(obj);
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto IL_018D;
					}
					break;
				}
				IL_01BA:;
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00005212 File Offset: 0x00003412
		public IEnumerable<string> GetTraceMessages()
		{
			return this.queue_0;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000692B8 File Offset: 0x000674B8
		public override string ToString()
		{
			object obj;
			bool flag;
			string text;
			for (;;)
			{
				obj = this.object_0;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_0003;
				}
				IL_0017:
				switch (num)
				{
				case 1:
					IL_0003:
					flag = false;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto IL_0017;
					}
					break;
				case 2:
					continue;
				case 3:
					return text;
				}
				break;
			}
			try
			{
				Monitor.Enter(obj, ref flag);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_008B;
				}
				goto IL_0094;
				IL_006A:
				Queue<string>.Enumerator enumerator = this.queue_0.GetEnumerator();
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_00B1;
				}
				goto IL_0094;
				IL_008B:
				StringBuilder stringBuilder = new StringBuilder();
				goto IL_006A;
				IL_0094:
				switch (num2)
				{
				case 1:
					goto IL_008B;
				case 2:
					goto IL_006A;
				case 3:
					goto IL_017F;
				case 4:
					goto IL_0176;
				}
				IL_00B1:
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_011D;
						}
						int num3 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
						{
							break;
						}
						goto IL_00D1;
						do
						{
							IL_00F2:
							string text2;
							stringBuilder.Append(text2);
							num3 = 1;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0);
						IL_00D1:
						switch (num3)
						{
						case 0:
							goto IL_00F2;
						case 1:
							continue;
						case 2:
							goto IL_0110;
						case 3:
						{
							IL_011D:
							string text2 = enumerator.Current;
							goto IL_0110;
						}
						case 4:
							break;
						case 5:
							goto IL_0149;
						default:
							goto IL_00F2;
						}
						IL_00B8:
						stringBuilder.AppendLine();
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
						{
							goto IL_00D1;
						}
						goto IL_00F2;
						IL_0110:
						if (stringBuilder.Length > 0)
						{
							goto IL_00B8;
						}
						goto IL_00F2;
					}
					IL_0149:;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
					{
						switch (num4)
						{
						}
					}
				}
				IL_0176:
				text = stringBuilder.ToString();
				IL_017F:;
			}
			finally
			{
				if (flag)
				{
					goto IL_01AD;
				}
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_01C6;
				}
				IL_0199:
				switch (num5)
				{
				case 2:
					IL_01AD:
					Monitor.Exit(obj);
					num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						goto IL_0199;
					}
					break;
				}
				IL_01C6:;
			}
			return text;
		}

		// Token: 0x040005BF RID: 1471
		private readonly Queue<string> queue_0;

		// Token: 0x040005C0 RID: 1472
		private readonly object object_0;

		// Token: 0x040005C1 RID: 1473
		[CompilerGenerated]
		private TraceLevel traceLevel_0;
	}
}
