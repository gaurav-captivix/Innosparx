﻿namespace Framework
{
    using System;

    /// -------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Benchmark item.
    /// </summary>
    /// -------------------------------------------------------------------------------------------------
    public class BenchmarkItem
    {
        /// -------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gets or sets the test.
        /// </summary>
        /// <value>
        /// The test.
        /// </value>
        /// -------------------------------------------------------------------------------------------------
        public Action Test { get; set; }

        /// -------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        /// -------------------------------------------------------------------------------------------------
        public string Title { get; set; }
    }
}