using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000181 RID: 385
	[Nullable(0)]
	[NullableContext(1)]
	internal class CompositeExpression : QueryExpression
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00006902 File Offset: 0x00004B02
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0000690A File Offset: 0x00004B0A
		public List<QueryExpression> Expressions { get; set; }

		// Token: 0x06001147 RID: 4423 RVA: 0x00089E28 File Offset: 0x00088028
		public CompositeExpression(QueryOperator @operator)
			: base(@operator)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
			{
				goto IL_003A;
			}
			do
			{
				IL_001B:
				this.Expressions = new List<QueryExpression>();
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0);
			IL_003A:
			switch (num)
			{
			case 0:
				goto IL_001B;
			case 1:
				return;
			default:
				goto IL_001B;
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00089E80 File Offset: 0x00088080
		public override bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			List<QueryExpression>.Enumerator enumerator;
			for (;;)
			{
				IL_0079:
				QueryOperator @operator = this.Operator;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_0093;
				}
				do
				{
					switch (num)
					{
					case 1:
						goto IL_0093;
					case 2:
						if (@operator == QueryOperator.And)
						{
							goto IL_0093;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto IL_0003;
						}
						continue;
					case 3:
						goto IL_0079;
					case 4:
						return true;
					case 5:
						goto IL_00A0;
					case 6:
						goto IL_01A1;
					case 7:
						goto IL_0120;
					case 8:
						goto IL_0003;
					}
					goto Block_5;
					IL_0003:
					if (@operator != QueryOperator.Or)
					{
						goto Block_1;
					}
					enumerator = this.Expressions.GetEnumerator();
					num = 7;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0);
			}
			Block_1:
			goto IL_01A1;
			Block_5:
			return false;
			IL_0093:
			enumerator = this.Expressions.GetEnumerator();
			IL_00A0:
			bool flag;
			try
			{
				IL_00E2:
				while (enumerator.MoveNext())
				{
					IL_00D1:
					while (!enumerator.Current.IsMatch(root, t, settings))
					{
						for (;;)
						{
							flag = false;
							int num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
							{
								break;
							}
							switch (num2)
							{
							default:
								goto IL_00D1;
							case 1:
								goto IL_00EE;
							case 2:
								goto IL_00EB;
							case 3:
								goto IL_00E2;
							case 4:
								break;
							}
						}
						IL_00EE:
						return flag;
					}
				}
				IL_00EB:;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					switch (num3)
					{
					}
				}
			}
			return true;
			IL_0120:
			try
			{
				IL_0165:
				while (enumerator.MoveNext())
				{
					IL_0154:
					while (enumerator.Current.IsMatch(root, t, settings))
					{
						for (;;)
						{
							flag = true;
							int num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
							{
								switch (num4)
								{
								case 1:
									goto IL_0154;
								case 2:
									continue;
								case 3:
									goto IL_016E;
								case 4:
									goto IL_0165;
								}
								break;
							}
							break;
						}
						return flag;
					}
				}
				IL_016E:
				return false;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					switch (num5)
					{
					}
				}
			}
			return flag;
			IL_01A1:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x040007AF RID: 1967
		[CompilerGenerated]
		private List<QueryExpression> list_0;
	}
}
