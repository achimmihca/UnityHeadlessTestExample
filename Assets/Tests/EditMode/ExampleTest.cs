using System.Threading.Tasks;
using NUnit.Framework;
using UnityEngine;

public class ExampleTest
{
    [Test]
    public async Task ShouldSucceed()
    {
        await Task.Delay(100);
        Debug.Log("Edit Mode test done");
    }
}
