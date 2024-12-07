<h1 align="center">ContentAPI</h1>
<div align="center">Join our <a href="https://discord.gg/namelesscircus">Discord</a> for support.</div>

Welcome to **ContentAPI**, a powerful extension designed to streamline modding by providing enhanced access to game components such as players, shops, and more. With built-in events and utility features, it simplifies game patching and improves the overall modding experience.

## Installation

To install **ContentAPI**, follow these steps:

1. Download the [latest DLL](https://github.com/CircusStudios/ContentAPI/releases/latest).
2. Place the downloaded file inside the `BepInEx\plugins` directory.

---

## For Developers

To integrate **ContentAPI** into your project:

1. Go to nuget and search for `ContentAPI`
2. Add the nuget package to your project as a reference.
3. Ensure it is also placed in the `BepInEx\plugins` directory.

In your code, set up the dependency as follows:

```csharp
[BepInDependency(ContentPlugin.ContentGUID)] // Specify whether this is a hard or soft dependency. Note: BepInEx defaults to hard dependencies.
public class YourMod : BaseUnityPlugin 
{
    // Implement your mod logic.
}
```

### Contributing

We welcome contributions! If you'd like to help improve **ContentAPI**, submit a [Pull Request](https://github.com/CircusStudios/ContentAPI/pulls) with your changes.

---

## Reporting Issues

Encountered a bug or issue? Please let us know through one of the following:

1. Use the [GitHub Issues page](https://github.com/CircusStudios/ContentAPI/issues/new).
    - Include a copy of the error message, a brief description of the issue, and any relevant context or expected behavior.
2. Join our [Discord](https://discord.gg/namelesscircus) for quick support from the community and developers.

---

## Dependencies

This plugin requires [BepInEx](https://github.com/BepInEx/BepInEx) to function.

---