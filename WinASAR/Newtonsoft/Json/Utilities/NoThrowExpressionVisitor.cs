using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000AA RID: 170
	[NullableContext(1)]
	[Nullable(0)]
	internal class NoThrowExpressionVisitor : ExpressionVisitor
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x00049810 File Offset: 0x00047A10
		protected override Expression VisitConditional(ConditionalExpression node)
		{
			while (node.IfFalse.NodeType == ExpressionType.Throw)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return Expression.Condition(node.Test, node.IfTrue, Expression.Constant(NoThrowExpressionVisitor.ErrorResult));
			}
			return base.VisitConditional(node);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00049878 File Offset: 0x00047A78
		public NoThrowExpressionVisitor()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000498AC File Offset: 0x00047AAC
		static NoThrowExpressionVisitor()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0021;
				}
				IL_0036:
				switch (num)
				{
				case 1:
					IL_0021:
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_0003;
					}
					goto IL_0036;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				NoThrowExpressionVisitor.ErrorResult = new object();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					break;
				}
				goto IL_0036;
			}
		}

		// Token: 0x04000415 RID: 1045
		internal static readonly object ErrorResult;
	}
}
