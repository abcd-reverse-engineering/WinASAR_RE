using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000112 RID: 274
	[Nullable(0)]
	[NullableContext(1)]
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x06000ABC RID: 2748 RVA: 0x0005B82C File Offset: 0x00059A2C
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
			for (;;)
			{
				IL_005A:
				ValidationUtils.ArgumentNotNull(serializer, Class15.smethod_17(1243283280 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
				for (;;)
				{
					this.Serializer = serializer;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_000A;
					}
					IL_0027:
					switch (num)
					{
					case 1:
						IL_000A:
						this.TraceWriter = serializer.TraceWriter;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
						{
							goto IL_0027;
						}
						break;
					case 2:
						goto IL_005A;
					case 3:
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0005B8B4 File Offset: 0x00059AB4
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			get
			{
				if (this.bidirectionalDictionary_0 == null)
				{
					this.bidirectionalDictionary_0 = new BidirectionalDictionary<string, object>(EqualityComparer<string>.Default, new JsonSerializerInternalBase.Class7(), Class15.smethod_17(1985284934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba), Class15.smethod_17(82291350 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
				}
				return this.bidirectionalDictionary_0;
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0005B910 File Offset: 0x00059B10
		protected NullValueHandling ResolvedNullValueHandling([Nullable(2)] JsonObjectContract containerContract, JsonProperty property)
		{
			NullValueHandling? nullValueHandling;
			NullValueHandling? nullValueHandling4;
			for (;;)
			{
				IL_00AF:
				nullValueHandling = property.NullValueHandling;
				while (nullValueHandling == null)
				{
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto IL_0050;
					}
					IL_0074:
					NullValueHandling? nullValueHandling3;
					NullValueHandling? nullValueHandling2;
					switch (num)
					{
					case 0:
						goto IL_0030;
					case 1:
						goto IL_00BD;
					case 2:
						goto IL_005B;
					case 3:
						goto IL_00C5;
					case 4:
						goto IL_0053;
					case 5:
						IL_0050:
						if (containerContract != null)
						{
							goto IL_0053;
						}
						goto IL_005B;
					case 6:
						continue;
					case 7:
						goto IL_00AF;
					case 8:
						nullValueHandling2 = nullValueHandling3;
						break;
					default:
						goto IL_0030;
					}
					IL_001C:
					nullValueHandling4 = nullValueHandling2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto IL_0074;
					}
					IL_0030:
					if (nullValueHandling4 == null)
					{
						goto IL_00C5;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto Block_3;
					}
					goto IL_0074;
					IL_005B:
					nullValueHandling3 = null;
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						goto IL_0074;
					}
					goto IL_00B9;
					IL_0053:
					nullValueHandling2 = containerContract.ItemNullValueHandling;
					goto IL_001C;
				}
				goto IL_00D1;
			}
			Block_3:
			goto IL_00BD;
			IL_00B9:
			goto IL_00C5;
			IL_00BD:
			return nullValueHandling4.GetValueOrDefault();
			IL_00C5:
			return this.Serializer._nullValueHandling;
			IL_00D1:
			return nullValueHandling.GetValueOrDefault();
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		private ErrorContext method_0([Nullable(2)] object currentObject, [Nullable(2)] object member, string string_0, Exception exception_0)
		{
			for (;;)
			{
				IL_0054:
				if (this.errorContext_0 == null)
				{
					goto IL_0042;
				}
				IL_0030:
				while (this.errorContext_0.Error != exception_0)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_005F;
					}
					switch (num)
					{
					case 0:
						goto IL_0042;
					case 1:
						goto IL_0060;
					case 2:
					case 3:
						break;
					case 4:
						goto IL_0054;
					default:
						goto IL_0042;
					}
				}
				goto IL_007B;
				IL_0042:
				this.errorContext_0 = new ErrorContext(currentObject, member, string_0, exception_0);
				goto IL_0030;
			}
			IL_005F:
			IL_0060:
			throw new InvalidOperationException(Class15.smethod_17(552206276 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
			IL_007B:
			return this.errorContext_0;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0005BA88 File Offset: 0x00059C88
		protected void ClearErrorContext()
		{
			for (;;)
			{
				int num;
				if (this.errorContext_0 == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						break;
					}
				}
				else
				{
					this.errorContext_0 = null;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						return;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				break;
			}
			throw new InvalidOperationException(Class15.smethod_17(543228840 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0005BB00 File Offset: 0x00059D00
		[NullableContext(2)]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, [Nullable(1)] string path, [Nullable(1)] Exception ex)
		{
			ErrorContext errorContext;
			for (;;)
			{
				errorContext = this.method_0(currentObject, keyValue, path, ex);
				int num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0006;
				}
				IL_01CA:
				string text;
				switch (num)
				{
				case 0:
					goto IL_00F0;
				case 1:
				case 23:
					goto IL_009B;
				case 2:
					goto IL_0165;
				case 3:
				case 19:
					goto IL_0104;
				case 4:
					goto IL_0027;
				case 5:
					IL_0053:
					if (contract != null)
					{
						goto IL_0056;
					}
					goto IL_009B;
				case 6:
					goto IL_00C5;
				case 7:
				case 20:
					goto IL_00D5;
				case 8:
					break;
				case 9:
					goto IL_0006;
				case 10:
					goto IL_00D8;
				case 11:
					goto IL_0056;
				case 12:
				case 13:
					goto IL_0261;
				case 14:
					goto IL_01B6;
				case 15:
					if (this.TraceWriter != null)
					{
						goto IL_01B6;
					}
					goto IL_00D5;
				case 16:
					continue;
				case 17:
					goto IL_015D;
				case 18:
					text = JsonPosition.FormatMessage(lineInfo, path, text);
					goto IL_00C5;
				case 21:
					goto IL_0151;
				case 22:
					goto IL_0127;
				default:
					goto IL_00F0;
				}
				IL_017F:
				string text2 = Class15.smethod_17(41424805 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d);
				goto IL_003C;
				IL_0165:
				if (base.GetType() == typeof(JsonSerializerInternalWriter))
				{
					goto IL_017F;
				}
				goto IL_0027;
				IL_015D:
				errorContext.Traced = true;
				goto IL_0165;
				IL_0151:
				if (!errorContext.Traced)
				{
					goto IL_015D;
				}
				goto IL_00D5;
				IL_01B6:
				if (this.TraceWriter.LevelFilter >= TraceLevel.Error)
				{
					goto IL_0151;
				}
				goto IL_00D5;
				IL_0006:
				if (ex is JsonException)
				{
					goto IL_00C5;
				}
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_0027;
				}
				goto IL_01CA;
				IL_009B:
				text = text + Class15.smethod_17(314799947 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927) + ex.Message;
				goto IL_0006;
				IL_003C:
				text = text2;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_0053;
				}
				goto IL_01CA;
				IL_0027:
				text2 = Class15.smethod_17(1788618920 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
				goto IL_003C;
				IL_0056:
				string text3 = text;
				string text4 = Class15.smethod_17(1176454826 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
				Type underlyingType = contract.UnderlyingType;
				text = text3 + text4 + ((underlyingType == null) ? null : underlyingType.ToString());
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_009B;
				}
				goto IL_01CA;
				IL_00D8:
				if (currentObject == null)
				{
					goto IL_0104;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					goto IL_00F0;
				}
				goto IL_01CA;
				IL_00D5:
				if (contract != null)
				{
					goto IL_00D8;
				}
				goto IL_0104;
				IL_00C5:
				this.TraceWriter.Trace(TraceLevel.Error, text, ex);
				goto IL_00D5;
				IL_0104:
				if (!errorContext.Handled)
				{
					goto IL_0127;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
				{
					break;
				}
				goto IL_01CA;
				IL_00F0:
				contract.InvokeOnError(currentObject, this.Serializer.Context, errorContext);
				goto IL_0104;
				IL_0127:
				this.Serializer.OnError(new ErrorEventArgs(currentObject, errorContext));
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					break;
				}
				goto IL_01CA;
			}
			IL_0261:
			return errorContext.Handled;
		}

		// Token: 0x04000586 RID: 1414
		[Nullable(2)]
		private ErrorContext errorContext_0;

		// Token: 0x04000587 RID: 1415
		[Nullable(new byte[] { 2, 1, 1 })]
		private BidirectionalDictionary<string, object> bidirectionalDictionary_0;

		// Token: 0x04000588 RID: 1416
		internal readonly JsonSerializer Serializer;

		// Token: 0x04000589 RID: 1417
		[Nullable(2)]
		internal readonly ITraceWriter TraceWriter;

		// Token: 0x0400058A RID: 1418
		[Nullable(2)]
		protected JsonSerializerProxy InternalSerializer;

		// Token: 0x02000113 RID: 275
		[NullableContext(0)]
		private class Class7 : IEqualityComparer<object>
		{
			// Token: 0x06000AC5 RID: 2757 RVA: 0x00004FA1 File Offset: 0x000031A1
			[NullableContext(2)]
			bool IEqualityComparer<object>.Equals(object x, object y)
			{
				return x == y;
			}

			// Token: 0x06000AC6 RID: 2758 RVA: 0x00004FA7 File Offset: 0x000031A7
			[NullableContext(1)]
			int IEqualityComparer<object>.GetHashCode(object obj)
			{
				return RuntimeHelpers.GetHashCode(obj);
			}

			// Token: 0x06000AC7 RID: 2759 RVA: 0x0005BD78 File Offset: 0x00059F78
			public Class7()
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					switch (num)
					{
					}
				}
			}
		}
	}
}
