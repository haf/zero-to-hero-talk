- title: From Zero to Hero of HTTP APIs
- description: How Suave was build and what it is now
- author: Henrik Feldt
- theme: night
- transition: default

***

### From Zero to Hero with HTTP APIs
***
### Agenda

 1. Agenda
 1. About me
 1. About [Suave.io](https://suave.io) and Ademar
 1. Demo Say what
 1. Demo chat
 1. Suave fundamentals
   - Functions for compositions
   - A web server implementation
   - Supports WebSockets and Server-Sent Events
 1. Package with Dockerfile
 1. Push to dockerhub
 1. Demo deploy on minikube
 1. Suave internals
   - https://github.com/SuaveIO/suave/blob/master/src/Suave/Tcp.fs#L45
   - https://github.com/SuaveIO/suave/blob/master/src/Suave/Tcp.fs#L171
   - https://github.com/SuaveIO/suave/blob/master/src/Suave/Tcp.fs#L119
 1. Patterns
   - Logging `open Suave.Logging`
   - Env vars https://12factor.net/ https://kubernetes.io/docs/tasks/inject-data-application/distribute-credentials-secure/
   - Suave-server-per test https://github.com/logibit/Logibit.Hawk/blob/master/src/Logibit.Hawk.Suave.Tests/Hawk.fs#L77-L96

 1. API reference https://suave.io/Suave.html walkthrough
 1. Further Resources
 - Books
   - [Suave Music Store](https://www.gitbook.com/book/theimowski/suave-music-store/details)
   - [F# applied](http://products.tamizhvendan.in/fsharp-applied/)

 - Getting started
   - [Fable Suave Scaffold](https://github.com/fable-compiler/fable-suave-scaffold/)
   - Ionide Suave template

 - Libraries on top of suave
   - [Suave EvReact](https://github.com/unipi-itc/Suave.EvReact)
   - [Suave Swagger](https://github.com/rflechner/Suave.Swagger/blob/develop/examples/Suave.Swagger.PetStoreAPi/Program.fs)
   - https://rflechner.github.io/Suave.RouteTypeProvider/tutorial.html + [Presentation](https://rflechner.github.io/SuavePresentation/#/5/1)
   - [FsReveal](https://github.com/fsprojects/FsReveal)
   - [Ionide/F# auto complete](https://github.com/fsharp/FsAutoComplete)
   - [Suave.OAuth](https://github.com/SuaveIO/Suave.OAuth)
   - [Logary SuaveReporter](https://www.nuget.org/packages/Logary.Services.SuaveReporter/)
   - [Suave Testing](https://github.com/SuaveIO/suave/blob/master/src/Suave.Testing/Testing.fs)
   - [Suave Locale](https://github.com/SuaveIO/Suave.Locale)
   - [Logibit Hawk](https://github.com/logibit/logibit.hawk/)
   - [Suave DotLiquid](https://www.nuget.org/packages/Suave.DotLiquid/)
   - [Suave Razor](https://www.nuget.org/packages/Suave.Razor/)
   - [Suave and Azure functions](https://www.nuget.org/packages/Suave.Azure.Functions/)
   - [WebSharper and Suave](https://www.nuget.org/packages/WebSharper.Suave/)
   - [Shaver](https://www.nuget.org/packages/Shaver/)

 - Cool demo
   - [SMSServer](https://github.com/rflechner/SmsServer/blob/master/iOS/AppDelegate.fs)
   - [Suave from Scratch](https://github.com/search?p=4&q=nuget+Suave&type=Code&utf8=%E2%9C%93) + [YouTube](https://www.youtube.com/watch?v=ujxwW6fFXOc)
   - [Say whaaat?](https://gist.github.com/haf/007259288fe98de62a88bb4ca37cb944#file-web-fsx)
   - [Hypermedia-driven lambda calculus evaluator. Yes.](https://github.com/einarwh/hyperlamb)

 - Videos
   - [Hypermedia APIs with Suave](https://vimeo.com/album/2132360/video/171317244)
   - [Intro to VS 2017 F# and Suave](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-F-Tools)
   - https://vimeo.com/album/2132360/video/171317244
   - https://github.com/haf/suave-presentation.2015-09-03

 - Github
   - https://github.com/suaveio