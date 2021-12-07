# What is the difference between CurrentCulture and CurrentUICulture properties of CultureInfo in .NET?

CurrentCulture is the .NET representation of the default user locale of the system. This controls default number and date formatting and the like.

CurrentUICulture refers to the default user interface language, a setting introduced in Windows 2000. This is primarily regarding the UI localization/translation part of your app.

Whatever regional options the system is configured to have will be the "Current" values in your .NET app.

Often times they are both the same. But on my system they would be different: I prefer my numbers and dates in the German format, so the CurrentCulture would be German, but I also prefer all my applications in English, so the CurrentUICulture would be English.

There is a nice article on the topic: Sorting it all Out: Why we have both CurrentCulture and CurrentUICulture


This is a simple trick I use to remember which one to use:

```
(date, currency, double).tostring = CurrentCulture

resource.fr-CA.resx file = currentUICulture
```

A good way to make a difference in addition to the nice explanations done by fellow users, and an important aspect in web application development is the following:

CurrentCulture represents the setup of the web server. For example, if your ASP.NET web application is hosted in Germany, the value of CutlureInfo.CurrentCulture would most probably be de-DE. Thus, the default .ToString() formatting for IFormattable types would use the default German formattings, or the ones which have been set up on the server OS as defaults.

CurrentUICulture can be captured from the user agent, and may represent the user interface culture of the client connecting to the website. For example, if you load that website from Russia, your local settings are set to use Russian language, and your user agent sends your locale settings to the server (Opera and IE do this automatically, not sure for Chrome and FireFox), the CurrenUICulture would represent ru-RU. This will cause any resources like localized strings retrieved via ResourceManager or localization expressions in ASP.NET aspx/ascx files to be in Russian (if translations are available).