﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cysharp.Text
{
    public static partial class ZString
    {
        public static string Format<T0>(string format, T0 arg0)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1>(string format, T0 arg0, T1 arg1)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        public static string Format<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            var sb = new Utf16ValueStringBuilder();
            sb.Init(true);
            try
            {
                sb.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

    }
}