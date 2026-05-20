using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class ExamplePlayModeTest
{
    [UnityTest]
    public IEnumerator ShouldSucceed() => ShouldSucceedAsync();

    private async Awaitable ShouldSucceedAsync()
    {
        await Awaitable.WaitForSecondsAsync(0.1f);
        Debug.Log("Play Mode test done");
    }
}
