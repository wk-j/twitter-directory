## Cmd

```bash
wk-folder-download  https://github.com/aspnet/AspNetCore/tree/master/src/Security/Authentication/Twitter twitter

dotnet user-secrets --project src/TwitterDirectory set Authentication:Twitter:ConsumerAPIKey <key>
dotnet user-secrets --project src/TwitterDirectory set Authentication:Twitter:ConsumerAPISecret <key>
```