using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000144 RID: 324
	[Nullable(0)]
	[NullableContext(1)]
	public static class Extensions
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x00072118 File Offset: 0x00070318
		public static IJEnumerable<JToken> Ancestors<[Nullable(0)] T>(this IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(1788771757 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
			return source.SelectMany(new Func<T, IEnumerable<JToken>>(Extensions.<>c__0<T>.<>c__0_0.method_0)).AsJEnumerable<JToken>();
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0007216C File Offset: 0x0007036C
		public static IJEnumerable<JToken> AncestorsAndSelf<[Nullable(0)] T>(this IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(277623208 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
			return source.SelectMany(new Func<T, IEnumerable<JToken>>(Extensions.<>c__1<T>.<>c__1_0.method_0)).AsJEnumerable<JToken>();
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000721C0 File Offset: 0x000703C0
		public static IJEnumerable<JToken> Descendants<[Nullable(0)] T>(this IEnumerable<T> source) where T : JContainer
		{
			ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(2021189828 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
			return source.SelectMany(new Func<T, IEnumerable<JToken>>(Extensions.<>c__2<T>.<>c__2_0.CkuLzTicKi)).AsJEnumerable<JToken>();
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00072214 File Offset: 0x00070414
		public static IJEnumerable<JToken> DescendantsAndSelf<[Nullable(0)] T>(this IEnumerable<T> source) where T : JContainer
		{
			ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(1603828254 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
			return source.SelectMany(new Func<T, IEnumerable<JToken>>(Extensions.<>c__3<T>.<>c__3_0.method_0)).AsJEnumerable<JToken>();
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00072268 File Offset: 0x00070468
		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(486512150 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
			return source.SelectMany(new Func<JObject, IEnumerable<JProperty>>(Extensions.<>c.<>c_0.method_0)).AsJEnumerable<JProperty>();
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00005BB9 File Offset: 0x00003DB9
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, [Nullable(2)] object key)
		{
			return source.Values(key).AsJEnumerable<JToken>();
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00005BC7 File Offset: 0x00003DC7
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			return source.Values(null);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00005BD0 File Offset: 0x00003DD0
		[return: Nullable(new byte[] { 1, 2 })]
		public static IEnumerable<U> Values<[Nullable(2)] U>(this IEnumerable<JToken> source, object key)
		{
			return source.Values(key);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00005BD9 File Offset: 0x00003DD9
		[return: Nullable(new byte[] { 1, 2 })]
		public static IEnumerable<U> Values<[Nullable(2)] U>(this IEnumerable<JToken> source)
		{
			return source.Values(null);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00005BE2 File Offset: 0x00003DE2
		[NullableContext(2)]
		public static U Value<U>([Nullable(1)] this IEnumerable<JToken> value)
		{
			return value.Value<JToken, U>();
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000722BC File Offset: 0x000704BC
		[return: Nullable(2)]
		public static U Value<[Nullable(0)] T, [Nullable(2)] U>(this IEnumerable<T> value) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(594374034 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			JToken jtoken = value as JToken;
			if (jtoken == null)
			{
				throw new ArgumentException(Class15.smethod_17(1788774951 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
			}
			return jtoken.Convert<JToken, U>();
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00005BEA File Offset: 0x00003DEA
		[return: Nullable(new byte[] { 1, 2 })]
		internal static IEnumerable<U> Values<[Nullable(0)] T, [Nullable(2)] U>(this IEnumerable<T> source, [Nullable(2)] object key) where T : JToken
		{
			Extensions.<Values>d__11<T, U> <Values>d__ = new Extensions.<Values>d__11<T, U>(-2);
			<Values>d__.<>3__source = source;
			<Values>d__.<>3__key = key;
			return <Values>d__;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00005C01 File Offset: 0x00003E01
		public static IJEnumerable<JToken> Children<[Nullable(0)] T>(this IEnumerable<T> source) where T : JToken
		{
			return source.Children<T, JToken>().AsJEnumerable<JToken>();
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00072310 File Offset: 0x00070510
		[return: Nullable(new byte[] { 1, 2 })]
		public static IEnumerable<U> Children<[Nullable(0)] T, [Nullable(2)] U>(this IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(538824035 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
			return source.SelectMany(new Func<T, IEnumerable<JToken>>(Extensions.<>c__13<T, U>.<>c__13_0.method_0)).Convert<JToken, U>();
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00005C0E File Offset: 0x00003E0E
		[return: Nullable(new byte[] { 1, 2 })]
		internal static IEnumerable<U> Convert<[Nullable(0)] T, [Nullable(2)] U>(this IEnumerable<T> source) where T : JToken
		{
			Extensions.<Convert>d__14<T, U> <Convert>d__ = new Extensions.<Convert>d__14<T, U>(-2);
			<Convert>d__.<>3__source = source;
			return <Convert>d__;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00072364 File Offset: 0x00070564
		[NullableContext(2)]
		internal static U Convert<[Nullable(0)] T, U>([Nullable(1)] this T token) where T : JToken
		{
			if (token == null)
			{
				return default(U);
			}
			if (token is U)
			{
				U u = token as U;
				if (typeof(U) != typeof(IComparable) && typeof(U) != typeof(IFormattable))
				{
					return u;
				}
			}
			JValue jvalue = token as JValue;
			if (jvalue == null)
			{
				throw new InvalidCastException(Class15.smethod_17(594408420 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, token.GetType(), typeof(T)));
			}
			object value = jvalue.Value;
			if (value is U)
			{
				return (U)((object)value);
			}
			Type type = typeof(U);
			if (ReflectionUtils.IsNullableType(type))
			{
				if (jvalue.Value == null)
				{
					return default(U);
				}
				type = Nullable.GetUnderlyingType(type);
			}
			return (U)((object)global::System.Convert.ChangeType(jvalue.Value, type, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00072484 File Offset: 0x00070684
		public static IJEnumerable<T> AsJEnumerable<[Nullable(0)] T>(this IEnumerable<T> source) where T : JToken
		{
			if (source == null)
			{
				return null;
			}
			IJEnumerable<T> ijenumerable = source as IJEnumerable<T>;
			if (ijenumerable != null)
			{
				return ijenumerable;
			}
			return new JEnumerable<T>(source);
		}
	}
}
