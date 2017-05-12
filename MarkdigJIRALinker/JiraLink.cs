﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Markdig.Syntax.Inlines;

namespace MarkdigJiraLinker
{
    /// <summary>
    /// Model for a JIRA link item
    /// </summary>
    [DebuggerDisplay("{Key}-{Issue}")]
    public class JiraLink : LeafInline
    {
        /// <summary>
        /// JIRA Project Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// JIRA Issue Number
        /// </summary>
        public string Issue { get; set; }
    }
}
