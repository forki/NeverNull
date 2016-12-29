﻿using JetBrains.Annotations;

namespace NeverNull.Combinators {
    /// <summary>
    ///     Provides extension methods to transform instances of option into their Nullable representation.
    /// </summary>
    public static class ToNullableExt {
        /// <summary>
        ///     Returns a Nullable containing the value of the specified option or an empty Nullable otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="option"></param>
        /// <returns></returns>
        [CanBeNull]
        public static T? ToNullable<T>(this Option<T> option) where T : struct =>
            option.Match(
                None: () => default(T?),
                Some: x => x);
    }
}
