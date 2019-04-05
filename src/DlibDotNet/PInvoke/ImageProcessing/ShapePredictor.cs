﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace DlibDotNet
{

    internal sealed partial class NativeMethods
    {

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr shape_predictor_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern uint shape_predictor_num_parts(IntPtr predictor);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern uint shape_predictor_num_features(IntPtr predictor);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr deserialize_shape_predictor(byte[] filName);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr deserialize_shape_predictor_proxy(IntPtr proxy_deserialize);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern ErrorType shape_predictor_operator(IntPtr detector,
                                                                Array2DType imgType,
                                                                IntPtr img,
                                                                IntPtr rect,
                                                                out IntPtr fullObjDetect);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern ErrorType shape_predictor_matrix_operator(IntPtr detector,
                                                                       MatrixElementType imgType,
                                                                       IntPtr img,
                                                                       IntPtr rect,
                                                                       out IntPtr fullObjDetect);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern ErrorType shape_predictor_operator_mmod_rect(IntPtr detector,
                                                                          Array2DType imgType,
                                                                          IntPtr img,
                                                                          IntPtr rect,
                                                                          out IntPtr fullObjDetect);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern ErrorType shape_predictor_matrix_operator_mmod_rect(IntPtr detector,
                                                                                 MatrixElementType imgType,
                                                                                 IntPtr img,
                                                                                 IntPtr rect,
                                                                                 out IntPtr fullObjDetect);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void shape_predictor_delete(IntPtr point);

    }

}