# Deprecated
This extension has been merged into the core of [markdig](https://github.com/lunet-io/markdig). Thanks @xoofx!

----------------

# Markdig Jira Linker
This is a Markdig extension that automatically add links to JIRA issue items within your markdown, e.g. XX-1234

## Getting Started
* Build & reference the library
* Add the extension to your pipeline using the extension method `UseJiraLinks`
* Set your JIRA base URL within the options
* All done!

```
var pipeline = new MarkdownPipelineBuilder()
	.UseJiraLinks(new JiraLinkOptions()
	{
		Url = "https://company.atlassian.net"
	})
	.Build();
```

## Authors
* [**Dave Clarke**](https://daveclarke.me)

## License
This project is licensed under the MIT license. See the [LICENSE.md](https://github.com/clarkd/MarkdigJiraLinker/blob/master/LICENSE) for details.

## Contributing
Please feel free to raise pull requests or issues for any issues you find. 

