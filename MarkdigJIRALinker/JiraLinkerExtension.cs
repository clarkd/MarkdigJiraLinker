using System;
using System.Collections.Generic;
using System.Text;
using Markdig;
using Markdig.Parsers.Inlines;
using Markdig.Renderers;

namespace MarkdigJiraLinker
{
    /// <summary>
    /// Simple inline parser extension for Markdig to find, and 
    /// automatically add links to JIRA issue numbers.
    /// </summary>
    public class JiraLinkerExtension : IMarkdownExtension
    {
        private readonly JiraLinkOptions _options;

        public JiraLinkerExtension(JiraLinkOptions options)
        {
            _options = options;
        }

        public void Setup(MarkdownPipelineBuilder pipeline)
        {
            if (!pipeline.InlineParsers.Contains<JiraLinkInlineParser>())
            {
                // Insert the parser before the link inline parser
                pipeline.InlineParsers.InsertBefore<LinkInlineParser>(new JiraLinkInlineParser());
            }
        }

        public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
        {
            var htmlRenderer = renderer as HtmlRenderer;
            if (htmlRenderer != null && !htmlRenderer.ObjectRenderers.Contains<JiraLinkRenderer>())
            {
                htmlRenderer.ObjectRenderers.Add(new JiraLinkRenderer(_options));
            }
        }
    }

    /// <summary>
    /// Add a extension method to add the extension to the pipeline
    /// </summary>
    public static class JiraLinkExtensionFunctions
    {
        public static MarkdownPipelineBuilder UseJiraLinks(this MarkdownPipelineBuilder pipeline, JiraLinkOptions options)
        {
            if (!pipeline.Extensions.Contains<JiraLinkerExtension>())
            {
                pipeline.Extensions.Add(new JiraLinkerExtension(options));
            }
            return pipeline;
        }

    }
    
}
