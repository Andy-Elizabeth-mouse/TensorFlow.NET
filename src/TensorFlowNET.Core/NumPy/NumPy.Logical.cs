﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static Tensorflow.Binding;

namespace Tensorflow.NumPy
{
    public partial class np
    {
        public static NDArray logical_or(NDArray x1, NDArray x2)
            => tf.logical_or(x1, x2);

        public static NDArray logical_and(NDArray x1, NDArray x2)
            => tf.logical_and(x1, x2);
    }
}
