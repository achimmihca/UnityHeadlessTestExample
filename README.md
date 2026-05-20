# Unity Headless Test Example

Example how to run unit tests outside the Unity editor (10× faster).

See also the [Blogpost on gamedev.center](https://gamedev.center/run-unity-tests-faster-dotnet/)

## Why it is relevant

From the [blogpost on gamedev.center](https://gamedev.center/run-unity-tests-faster-dotnet/)

> The AI & Iteration Advantage

> Beyond personal developer productivity, this infrastructure unlocks a massive advantage for modern AI-assisted workflows. When working with LLMs, the AI can sometimes break working code while fixing bugs. Verifying changes with unit tests is essential, but the friction of the Unity Test Runner makes this slow and manual.

> By running tests on the latest .NET without the Unity Editor, AI agents can now run tests themselves to verify their edits and the editor is still available for you to play the game yourself or wire things up in the inspector. This automated verification takes mere seconds, ensuring the AI delivers working code without requiring the developer to manually switch contexts or wait for reloads.

> Furthermore, iteration speed is crucial for big teams. Slow Editor performance and assembly reloads can cost hours per week per developer. Moving logic verification outside of Unity isn’t just a “nice-to-have” for small projects, it’s a critical architectural choice for maintaining high velocity in large-scale game development.

## How to use

Headless unit tests are in `Assets/Tests/Headless~`.
Run `dotnet test` to execute these tests.

The `~` is used as folder name suffix to make Unity Editor ignore it during compilation. See [Unity Manual on Special Folders](https://docs.unity3d.com/Manual/SpecialFolders.html)

## How it works

There is a separate solution folder `HeadlessTests` with a standalone `.csproj` targeting .NET and referencing Unity managed DLL files.