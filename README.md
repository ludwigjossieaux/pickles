Pickles
=======

Pickles is an open source living documentation generator that works on feature files written in the Gherkin language, popularized in tools like Cucumber and SpecFlow.

[![Join the chat at https://gitter.im/picklesdoc/pickles](https://badges.gitter.im/picklesdoc/pickles.svg)](https://gitter.im/picklesdoc/pickles?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Build status](https://ci.appveyor.com/api/projects/status/rqt59hq1m2jt2a5v?svg=true)](https://ci.appveyor.com/project/dirkrombauts/pickles-715)

|                             |Status                                                                                                                                   |
|-----------------------------|-----------------------------------------------------------------------------------------------------------------------------------------|
| Docs                        |[![Documentation Status](https://readthedocs.org/projects/pickles/badge/?version=stable)](http://docs.picklesdoc.com/en/latest/)         |
| GitHub Release              |[![GitHub release](https://img.shields.io/github/release/picklesdoc/pickles.svg)](https://github.com/picklesdoc/pickles/releases/latest) |
| Chocolatey (pickles)        |[![Chocolatey](https://img.shields.io/chocolatey/v/pickles.svg)](https://chocolatey.org/packages/pickles)                                |
| Chocolatey (picklesui)      |[![Chocolatey](https://img.shields.io/chocolatey/v/picklesui.svg)](https://chocolatey.org/packages/picklesui)                            |
| NuGet (Pickles)             |[![NuGet](https://img.shields.io/nuget/v/Pickles.svg)](https://www.nuget.org/packages/Pickles)                                           |
| NuGet (Pickles.CommandLine) |[![NuGet](https://img.shields.io/nuget/v/Pickles.CommandLine.svg)](https://www.nuget.org/packages/Pickles.CommandLine)                   |
| NuGet (Pickles.MSBuild)     |[![NuGet](https://img.shields.io/nuget/v/Pickles.MSBuild.svg)](https://www.nuget.org/packages/Pickles.MSBuild)                           |



Pickles can be incorporated into your build process to produce living documentation in a format that is more accessible to your clients.  Gherkin language files are written in plain text and stored in your source folder.  This can make them inaccessible to clients who may not know how to work with source control or who are not interested in seeing all of the source code, just the features.

Why stop with just the features though?  Pickles can also read plain text files written in the Markdown format so you can add other files to your feature to add all sorts of context.  Well-written features are great to have but even the best written features can leave out some important context information.  Markdown is very simple to write and is designed to be easily read even in plain text files so they are a great way of adding additional context to your feature files to turn them into a real set of living documentation.

Supported Output Formats
------------------------

- HTML
- DHTML (javascript-enabled, search capabilities)
- JSON
- Word
- Excel

If there are other formats you would like to see feel free to create a [GitHub Issue](https://github.com/picklesdoc/pickles/issues).

Supported Test Runner Integrations
----------------------------------

- NUnit (versions 2.x and 3.x)
- xUnit (versions 1.x and 2.x)
- MSTest
- Cucumber JSON
- SpecFlow+ Runner (formerly known as SpecRun)

Contributing
------------

It's easy to contribute to Pickles, just setup an account on github and fork the project.  When you have some code to contribute, send a pull request!  There are plenty of ideas for contributions on the wiki and in the issues list.

License
-------

Pickles is licensed with the Apache License, version 2.0.  You can find more information on the license here: http://www.apache.org/licenses/LICENSE-2.0.html
