using System.Runtime.CompilerServices;

public class HeadlessTestUtil
{
    public static T CreateComponent<T>()
    {
        return (T)RuntimeHelpers.GetUninitializedObject(typeof(T));
    }
}
