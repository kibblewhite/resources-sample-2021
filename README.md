# resources-sample-2021 👍

This is an example C# 10 .Net 6 project demonstrating the use of resources (*.resx) and handling different locales


Output should look like the following:
```
Supported Cultures using Resource Manager
> German (Germany)
> English
> English (United Kingdom)
> Spanish (Spain)
 ====================
CurrentThread.CurrentUICulture: en-GB
Direct Test Value for Culture: en-GB: Test Value (In English for Great Britain)
 --------------------
CurrentThread.CurrentUICulture: es-ES
Direct Test Value for Culture: es-ES: Test Value (In Spanish for Spain)
 --------------------
CurrentThread.CurrentUICulture: de-DE
Direct Test Value for Culture: de-DE: Test Value (In German for Germany)
 --------------------
CurrentThread.CurrentUICulture: en-US
Direct Test Value for Culture: en: Test Value (In English)
 --------------------
CurrentThread.CurrentUICulture: es-MX
Direct Test Value for Culture: Default: Test Value (Default Fallback)
 --------------------
 ```