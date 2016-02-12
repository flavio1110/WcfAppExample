# WcfAppExample
Just an example of wcf multi-ways binds and proxies + mvc

The main objective is show didactically how wcf can be configured, exposed and consumed. 

The project is divided in three main parts:
- Web: a mvc application with just one controller without views. The HomeController has three actions that call the wcf services in different ways.
- Service: There's two projects, one for ServicesContracts and another to Services implementation. In several wcf examples the contracts and the implementaion are in the same project, but I wanted expose my contract without expose the implementation.
- Host: I created two hosts, a console host that serves http and nettcp and a webhost that serve only http for logical reasons.

Feel free to fork. :)
